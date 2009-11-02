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
            if(type=="IPNameCPU")
                getIPandName(ref mPeer);

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

        public void getHeartBeatRequest() { }
        public void getmsgHeartBeatReply() { }
        public void getMaster() { }
        public void getBackup() { }
        public void getRun() { }
        public void getChat() { }

    }
}
