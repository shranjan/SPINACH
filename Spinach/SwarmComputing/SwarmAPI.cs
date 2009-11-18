using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Management;

namespace Spinach
{
    public class SwarmConnection
    {
        //Delegate and Events**********************
        public delegate void ChangedEventHandler(List<string> conInfo);
        public event ChangedEventHandler ListChanged;
        public delegate void ChatEventHandler(string ChatMsg);
        public event ChatEventHandler ChatChanged;
        public delegate void ErrorEventHandler(int ErrorCode, string ErrorMsg);
        public event ErrorEventHandler ErrorChanged;
        private List<string> DisplayList = new List<string>();

        AsynchronousSocketListener mSocket = new AsynchronousSocketListener();
        public SwarmConnection()
        {
            mSocket.ListChanged += new AsynchronousSocketListener.ChangedEventHandler(List_Changed);
            mSocket.ChatChanged += new AsynchronousSocketListener.ChatEventHandler(Chat_Changed);
            mSocket.ErrorChanged += new AsynchronousSocketListener.ErrorEventHandler(Error_Changed);
        }
        private void List_Changed(Hashtable Displist)
        {
            foreach (string iport in Displist)
            {
                Peer st = (Peer)Displist[iport];
                string Username = st.mName;
                string conMsg = Username + " : " + iport;
                DisplayList.Add(conMsg);
            }
            if (ListChanged != null)
                ListChanged(DisplayList);

        }
        private void Chat_Changed(string ChatMessage)
        {
            if (ChatChanged != null)
                ChatChanged(ChatMessage);

        }
        private void Error_Changed(int errorcode,string ErrorMsg)
        {
            if (ErrorChanged != null)
                ErrorChanged(errorcode,ErrorMsg);

        }

        //*************************************
        public bool Join_Swarm(string DstIP, string DstPort,string SrcIP, string SrcPort,string Username)
        {
            Thread t1 = null;
            Thread t2 = null;
            try
            {
                t1 = new Thread(new ThreadStart(mSocket.StartListening));
                t1.Start();
                t1.IsBackground = true;
                string cpu = "1";
                mSocket.SetIP(SrcIP);
                mSocket.SetPort(SrcPort);
                mSocket.SetName(Username);
                mSocket.SetCPU(cpu);
                MessageGenerator msg = new MessageGenerator();
                string mMsg = msg.msgConnectionRequest
                    (mSocket.GetIP(), mSocket.GetPort(), mSocket.GetName(), mSocket.GetCPU());
                AsynchronousClient client = new AsynchronousClient();
                client.SetSingleMsg(DstIP, DstPort, mMsg);
                t2 = new Thread(new ThreadStart(client.SendSingleClient));
                t2.Start();
                t2.IsBackground = true;
                return true;
           
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            
        }

        public bool Create_Swarm(string SrcIP, string SrcPort, string Username)
        {
            try
            {
                Thread t1 = null;
                t1 = new Thread(new ThreadStart(mSocket.StartListening));
                t1.Start();
                t1.IsBackground = true;
                string cpu = "1";
                mSocket.SetIP(SrcIP);
                mSocket.SetPort(SrcPort);
                mSocket.SetName(Username);
                mSocket.SetCPU(cpu);
                mSocket.InsertPeer(mSocket.GetIP(), mSocket.GetPort(), mSocket.GetName(), mSocket.GetCPU());
                mSocket.SetMaster(mSocket.GetIP() + ":" + mSocket.GetPort());
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }

        public void Send_ChatMsg(string chatMsg, string Username)
        {
            try
            {
                Thread t = null;
                MessageGenerator mMsg = new MessageGenerator();
                //Chat username to be included
                string msg = mMsg.msgChat(chatMsg, mSocket.GetIP() + ":" + mSocket.GetPort());
                AsynchronousClient client = new AsynchronousClient();
                client.SetMultiMsg(mSocket.GetIPtoPeer(), msg, mSocket.GetIP() + ":" + mSocket.GetPort());
                t = new Thread(new ThreadStart(client.SendMultiClient));
                t.Start();
                t.IsBackground = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        public void CreatProgram(string pid)
        {
            SwarmMemory sm = new SwarmMemory(pid, mSocket.GetIP() + ":" + mSocket.GetPort());
            sm.setOwner(mSocket.GetIP() + ":" + mSocket.GetPort());
            mSocket.InsertProg(pid, sm);
        }

        public void AssignPermission(string pid,string code,string ip,string port,string read, string write)
        {
            string ipport = ip + ":" + port;
            SwarmMemory sm = mSocket.GetProg(pid);
            sm.addPermissionRequest(mSocket.GetIP() + ":" + mSocket.GetPort(), mSocket.GetIPtoPeer(), code, ipport, read, write);
        }

        public void ChangePermission(string pid, string ip,string port, string read, string write)
        {
            string ipport = ip + ":" + port;
            SwarmMemory sm = mSocket.GetProg(pid);
            sm.changePermissionRequest(mSocket.GetIP() + ":" + mSocket.GetPort(), mSocket.GetIPtoPeer(), ipport, read, write);
        }


        public Hashtable GetPermission(string pid)
        {
            return mSocket.GetPermission(pid);
        }

        public void Disconnect()
        {
            mSocket.Disconnect();
            mSocket.Clear();
        }
    }
}
