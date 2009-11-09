using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace WPF_GUI
{
    class MessageParser
    {
        String msg;
        MessageGenerator mMsg = new MessageGenerator();
        public void GetMsg(String incoming) { msg = incoming; }

        public String parse(ref Peer mPeer)
        {
            String type=" ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                type = elem.Attributes().ElementAt(0).Value;

            if (type == "IPNameCPU")
                getIPandName(ref mPeer);
            else if (type == "HeartBeatRequest")
                getHeartBeatRequest(ref mPeer);
            else if (type == "HeartBeatReply")
                getmsgHeartBeatReply();
            else if (type == "Master")
                getMaster(ref mPeer);
            else if (type == "Backup")
                getBackup(ref mPeer);
            else if (type == "Run")
                getRun(ref mPeer);
            else if (type == "RunSucess")
                getRunSucess();
            else if (type == "RunFail")
                getRunFail();
            else if (type == "ReRun")
                getReRun(ref mPeer);
            else if (type == "Chat")
                getChat();

            return type;
                                
        }

        public void getIPandName(ref Peer mPeer)
        {
            String ipport;
            String name;
            String cpu;

            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Elements("root").Descendants()
                    select x;
            foreach (var elem in q)
            {
                ipport = elem.Attributes().ElementAt(0).Value;
                name = elem.Attributes().ElementAt(1).Value;
                cpu = elem.Attributes().ElementAt(2).Value;
                mPeer.InsertPeer(ipport, name, cpu);
            }
        }

        public void getHeartBeatRequest(ref Peer mPeer) 
        {
            String ipport = mPeer.GetIP() + mPeer.GetPort();
            string smsg = mMsg.msgHeartBeatReply(ipport);

        }

        public void getmsgHeartBeatReply() { }
        public void getMaster(ref Peer mPeer) 
        {
            string master=" ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                master = elem.Value;
            mPeer.SetMaster(master);
        }

        public void getBackup(ref Peer mPeer) 
        {
            string backup = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                backup = elem.Value;
            mPeer.SetBackup(backup);
        }

        public void getRun(ref Peer mPeer) 
        {
            string temp;
            string ipport = mPeer.GetIP() + mPeer.GetPort();
            string pid = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                pid = elem.Value;
            temp = mPeer.GetFlag(pid);

            if (temp == "0")
            {
                mPeer.SetFlag(pid, "1");
                string smsg = mMsg.msgRunSucess(pid,ipport);
            }
            else
            {
                string smsg = mMsg.msgRunFail(pid, ipport);
            }
        }

        public void getRunFail()
        {
            string pid = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                pid = elem.Value;
        }

        public void getRunSucess()
        {
            string pid = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                pid = elem.Value;
        }

        public void getReRun(ref Peer mPeer)
        {
            string pid = " ";
            XDocument xml = XDocument.Parse(msg);
            var q = from x in xml.Descendants()
                    where (x.Name == "root")
                    select x;
            foreach (var elem in q)
                pid = elem.Value;
            mPeer.SetFlag(pid, "0");
        }

        public void getChat() { }

    }
}
