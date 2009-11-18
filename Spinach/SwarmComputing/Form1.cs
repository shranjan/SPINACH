using System;
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
    public partial class Form1 : Form
    {
        AsynchronousSocketListener mSocket = new AsynchronousSocketListener();
        static IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
        static IPAddress SrcIp = ipHostInfo.AddressList[0];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ManagementClass core = new ManagementClass("Win32_Processor");
            //ManagementObjectCollection number = core.GetInstances();
            Thread t = null;
            string Username = "Peer1";
            string port = "11000";
            string cpu = "1";
            string ip = SrcIp.ToString();
            //string cpu = number.Count.ToString();
            mSocket.SetIP(ip);
            mSocket.SetPort(port);
            mSocket.SetName(textBox4.Text.ToString());
            mSocket.SetCPU(cpu);
                        
            try
            {
                t = new Thread(new ThreadStart(mSocket.StartListening));
                t.Start();
                t.IsBackground = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Connection_Request(object sender, EventArgs e)
        {
            MessageGenerator msg = new MessageGenerator();
            string DstIp = textBox1.Text;
            string DstPort = textBox2.Text;
            string mMsg = msg.msgConnectionRequest
                (mSocket.GetIP(), mSocket.GetPort(), mSocket.GetName(), mSocket.GetCPU());
            AsynchronousClient client = new AsynchronousClient();
            client.SetSingleMsg(DstIp, DstPort,mMsg);
            Thread t = null;
            t = new Thread(new ThreadStart(client.SendSingleClient));
            t.Start();
            t.IsBackground = true;
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = true;
        }

        private void Create_Swarm(object sender, EventArgs e)
        {
            mSocket.InsertPeer(mSocket.GetIP(),mSocket.GetPort(), mSocket.GetName(), mSocket.GetCPU());
            mSocket.SetMaster(mSocket.GetIP() + ":" + mSocket.GetPort());
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = true;
        }

        private void Send_ChatMsg(object sender, EventArgs e)
        {
            Thread t = null;
            MessageGenerator mMsg = new MessageGenerator();
            string msg = mMsg.msgChat(this.richTextBox1.Text, mSocket.GetIP() + ":" + mSocket.GetPort());
            AsynchronousClient client = new AsynchronousClient();
            client.SetMultiMsg(mSocket.GetIPtoPeer(), msg, mSocket.GetIP() + ":" + mSocket.GetPort());
            t = new Thread(new ThreadStart(client.SendMultiClient));
            t.Start();
            t.IsBackground = true;

            //m.HandleChatMessages("Peer1", richTextBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SwarmMemory sm = new SwarmMemory("1", mSocket.GetIP() + ":" + mSocket.GetPort());
            mSocket.InsertProg("1", sm);
            mSocket.GetProg("1").setOwner(mSocket.GetIP() + ":" + mSocket.GetPort());

            SwarmMemory sm1 = new SwarmMemory("2", mSocket.GetIP() + ":" + mSocket.GetPort());
            mSocket.InsertProg("2", sm1);
            mSocket.GetProg("2").setOwner(mSocket.GetIP() + ":" + mSocket.GetPort());

            Console.WriteLine(mSocket.GetProg("1").getPid().ToString());
            Console.WriteLine(mSocket.GetProg("2").getPid().ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SwarmMemory sm = mSocket.GetProg("1");
            sm.addPermissionRequest(mSocket.GetIP() + ":" + mSocket.GetPort(), mSocket.GetIPtoPeer(), "something", textBox3.Text.ToString(), "true", "false");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SwarmMemory sm = mSocket.GetProg("1");
            sm.changePermissionRequest(mSocket.GetIP() + ":" + mSocket.GetPort(), mSocket.GetIPtoPeer(), textBox3.Text.ToString(), "true", "true");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mSocket.GetPermission("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mSocket.Disconnect();
            mSocket.Clear();
        }
    }
}
