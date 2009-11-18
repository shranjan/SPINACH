using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading;

namespace Spinach
{
    public partial class AsynchronousSocketListener
    {
        //Delegates and Events
        public delegate void ChatEventHandler(string ChatMsg);
        public event ChatEventHandler ChatChanged;
        public delegate void ErrorEventHandler(int ErrorCode,string ErrorMsg);
        public event ErrorEventHandler ErrorChanged;


      

        //*********************
        public void parseMsg(String msg)
        {
            String type=" ";
            XDocument xml = XDocument.Parse(msg);
            var q1 = from x in xml.Elements() select x;
            if (q1.ElementAt(0).Name.ToString() == "root")
            {
                var q = from x in xml.Descendants()
                        where (x.Name == "root")
                        select x;
                foreach (var elem in q)
                    type = elem.Attributes().ElementAt(0).Value;

                if (type == "Connection")
                    getConnectionRequestMsg(msg);
                else if (type == "IPtoPeer")
                    getIPtoPeerMsg(msg);
                //else if (type == "HeartBeatRequest")
                //    getHeartBeatRequest(ref mPeer);
                //else if (type == "HeartBeatReply")
                //    getmsgHeartBeatReply();
                else if (type == "Master")
                    getMasterMsg(msg);
                else if (type == "Backup")
                    getBackupMsg(msg);
                //else if (type == "Run")
                //    getRun(ref mPeer);
                //else if (type == "RunSucess")
                //    getRunSucess();
                //else if (type == "RunFail")
                //    getRunFail();
                //else if (type == "ReRun")
                //    getReRun(ref mPeer);
                else if (type == "Chat")
                    getChatMsg(msg);
                else if (type == "Error")
                    getErrorMsg(msg);
                else if (type == "Disconnect")
                    getDisconnectMsg(msg);
            }
            else if (q1.ElementAt(0).Name.ToString() == "data")
            {
                SwarmMemoryCaller smc = new SwarmMemoryCaller();
                SwarmMemory sm = smc.InitializeThePeer(msg, GetIP() + ":" + GetPort());
                InsertProg(sm.getPid().ToString(),sm);
            }
            else if (q1.ElementAt(0).Name.ToString() == "newProg")
            {
                SwarmMemoryCaller smc = new SwarmMemoryCaller();
                string[] temp=smc.addPermission(msg);
                SwarmMemory sm = new SwarmMemory("-1", GetIP() + ":" + GetPort());
                sm = GetProg(temp[0].ToString());
                sm.adder(temp[2].ToString(), temp[3].ToString(), temp[4].ToString(), temp[1].ToString(),GetIP()+":"+GetPort());
                InsertProg(temp[0].ToString(), sm);
            }
            else if (q1.ElementAt(0).Name.ToString() == "PermissionChange")
            {
                SwarmMemoryCaller smc = new SwarmMemoryCaller();
                string[] temp=smc.changePermission(msg);
                SwarmMemory sm = new SwarmMemory("-1", GetIP() + ":" + GetPort());
                sm=GetProg(temp[0].ToString());
                sm.changer(temp[1].ToString(), temp[2].ToString(), temp[3].ToString(), GetIP() + ":" + GetPort());
                InsertProg(temp[0].ToString(), sm);
            }            
        }

        public void getConnectionRequestMsg(String msg)
        {
            String ip;
            String port;
            String name;
            String cpu;
            Thread t1 = null;
            Thread t2 = null;
            Thread t3 = null;

            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Elements("root").Descendants()
                    select x;
            foreach (var elem in q)
            {

                ip = elem.Attributes().ElementAt(0).Value;
                port = elem.Attributes().ElementAt(1).Value;
                name = elem.Attributes().ElementAt(2).Value;
                cpu = elem.Attributes().ElementAt(3).Value;
                if (IPtoPeer.Count > 0)
                {
                    if (!NametoIP.Contains(name))
                    {
                        InsertPeer(ip, port, name, cpu);
                        if (IPtoPeer.Count == 2)
                            SetBackup(ip + ":" + port);

                        MessageGenerator temp = new MessageGenerator();
                        string mMsg = temp.msgIPtoPeer(IPtoPeer);
                        string master = temp.msgMaster(GetMaster());
                        string backup = temp.msgBackup(GetBackup());
                        AsynchronousClient client1 = new AsynchronousClient();
                        client1.SetMultiMsg(IPtoPeer, mMsg, mPeer.mIP + ":" + mPeer.mPort);
                        t1 = new Thread(new ThreadStart(client1.SendMultiClient));
                        t1.Start();
                        t1.IsBackground = true;
                        AsynchronousClient client2 = new AsynchronousClient();
                        client2.SetSingleMsg(ip, port, master);
                        t2 = new Thread(new ThreadStart(client2.SendSingleClient));
                        t2.Start();
                        t2.IsBackground = true;
                        AsynchronousClient client3 = new AsynchronousClient();
                        client3.SetSingleMsg(ip, port, backup);
                        t3 = new Thread(new ThreadStart(client3.SendSingleClient));
                        t3.Start();
                        t3.IsBackground = true;
                    }
                    else
                    {
                        MessageGenerator temp = new MessageGenerator();
                        string error = temp.msgError("10:Username Already Exists");
                        AsynchronousClient client = new AsynchronousClient();
                        client.SetSingleMsg(ip, port, error);
                        t1 = new Thread(new ThreadStart(client.SendSingleClient));
                        t1.Start();
                        t1.IsBackground = true;
                    }
                }
                else
                {
                    MessageGenerator temp = new MessageGenerator();
                    string error = temp.msgError("10:Peer is not a part of Swarm");
                    AsynchronousClient client = new AsynchronousClient();
                    client.SetSingleMsg(ip, port, error);
                    t1 = new Thread(new ThreadStart(client.SendSingleClient));
                    t1.Start();
                    t1.IsBackground = true;
                }
            }
            showTable();
        }
        public void getIPtoPeerMsg(String msg)
        {
            String ip;
            String port;
            String name;
            String cpu;

            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Elements("root").Descendants()
                    select x;
            foreach (var elem in q)
            {
                ip = elem.Attributes().ElementAt(0).Value;
                port = elem.Attributes().ElementAt(1).Value;
                name = elem.Attributes().ElementAt(2).Value;
                cpu = elem.Attributes().ElementAt(3).Value;
                InsertPeer(ip, port, name, cpu);
            }
            showTable();
        }

        //public void getHeartBeatRequest(ref Peer mPeer) 
        //{
        //    String ipport = mPeer.GetIP() + mPeer.GetPort();
        //    string smsg = mMsg.msgHeartBeatReply(ipport);

        //}

        //public void getmsgHeartBeatReply() { }

        public void getMasterMsg(String msg)
        {
            string master = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                master = elem.Value;
            SetMaster(master);
            showTable();
        }

        public void getBackupMsg(String msg)
        {
            string backup = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                backup = elem.Value;
            SetBackup(backup);
            showTable();
        }

        //public void getRun(ref Peer mPeer) 
        //{
        //    string temp;
        //    string ipport = mPeer.GetIP() + mPeer.GetPort();
        //    string pid = " ";
        //    XDocument xml = XDocument.Parse(msg);
        //    var q = from x in xml.Descendants()
        //            where (x.Name == "root")
        //            select x;
        //    foreach (var elem in q)
        //        pid = elem.Value;
        //    temp = mPeer.GetFlag(pid);

        //    if (temp == "0")
        //    {
        //        mPeer.SetFlag(pid, "1");
        //        string smsg = mMsg.msgRunSucessReply(pid,ipport);
        //    }
        //    else
        //    {
        //        string smsg = mMsg.msgRunFailReply(pid, ipport);
        //    }
        //}

        //public void getRunFail()
        //{
        //    string pid = " ";
        //    XDocument xml = XDocument.Parse(msg);
        //    var q = from x in xml.Descendants()
        //            where (x.Name == "root")
        //            select x;
        //    foreach (var elem in q)
        //        pid = elem.Value;
        //}

        //public void getRunSucess()
        //{
        //    string pid = " ";
        //    XDocument xml = XDocument.Parse(msg);
        //    var q = from x in xml.Descendants()
        //            where (x.Name == "root")
        //            select x;
        //    foreach (var elem in q)
        //        pid = elem.Value;
        //}

        //public void getReRun(ref Peer mPeer)
        //{
        //    string pid = " ";
        //    XDocument xml = XDocument.Parse(msg);
        //    var q = from x in xml.Descendants()
        //            where (x.Name == "root")
        //            select x;
        //    foreach (var elem in q)
        //        pid = elem.Value;
        //    mPeer.SetFlag(pid, "0");
        //}

        public void getChatMsg(String msg) 
        {
            string chat = "";
            string ip = "";
            XDocument xml = XDocument.Parse(msg);
            //var q = from x in xml.Descendants()
            //        where (x.Name == "root")
            //        select x;
            //foreach (var elem in q)
            //    chat = elem.Value;
            var q = from x in xml.Elements("root").Descendants()
                    select x;
            foreach (var elem in q)
            {

                ip = elem.Attributes().ElementAt(0).Value;
                chat = elem.Attributes().ElementAt(1).Value;
            }
            string name = "";
            Peer temp = new Peer();
            temp = (Peer)GetIPtoPeer()[ip];
            name = temp.mName;
            Console.WriteLine("{0}:{1}",name,chat);
            ////////////////////////////////////////////////
            if (ChatChanged != null)
                ChatChanged(chat);

            //
        }

        public void getErrorMsg(String msg)
        {
            string error = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                error = elem.Value;
            string[] sr = error.Split(':');
            int errorCode = Convert.ToInt32(sr[0]);
            string errorMsg = sr[1];
           // Console.WriteLine(error);
            ////////////////////////!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!////////////////
            if (ErrorChanged != null)
                ErrorChanged(errorCode,errorMsg);


            /////////
        }

        public void getDisconnectMsg(String msg)
        {
            string ipport = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                ipport = elem.Value;
            RemovePeer(ipport);
            showTable();
        }

        public void showTable()
        {
            foreach (Object ip in IPtoPeer.Keys)
            {
                Peer mPeer = (Peer)IPtoPeer[ip];
                Console.Write("{0} ---> IP:{1},Port:{2},Name:{3},CPU:{4}\n", 
                    ip, mPeer.mIP, mPeer.mPort, mPeer.mName, mPeer.mCPU);
            }
            Console.Write("Master: {0} ; Backup: {1}\n", GetMaster(), GetBackup());
        }
    }
}
