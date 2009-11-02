using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace WPF_GUI
{
    class MessageGenerator
    {
        public String msgIPNameCPU(ref Peer mPeer)
        {
            Hashtable IPtoName = new Hashtable();
            Hashtable NametoIP = new Hashtable();
            Hashtable IPtoCPU = new Hashtable();
            IPtoName = mPeer.GetIPtoName();
            NametoIP = mPeer.GetNametoIP();
            IPtoCPU = mPeer.GetIPtoCPU();

            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root",new XAttribute("type","IPNameCPU"))
                );
            XElement temp = xml.Descendants("root").First();
            foreach (Object key in IPtoName.Keys)
            {
                XElement IPandName = new XElement("IPNameCPU");
                XAttribute a1 = new XAttribute("IP", key.ToString());
                XAttribute a2 = new XAttribute("Name", IPtoName[key].ToString());
                XAttribute a3 = new XAttribute("CPU", IPtoCPU[key].ToString());
                IPandName.Add(a1);
                IPandName.Add(a2);
                IPandName.Add(a3);
                //more attribute here to further data
                temp.Add(IPandName);
            }
            string result = xml.ToString();
            return result;
        }

        public String msgHeartBeatRequest()
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root",new XAttribute("type","HeartBeatRequest"))
                );
            string result = xml.ToString();
            return result;
        }

        public String msgHeartBeatReply()
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "HeartBeatReply"))
                );
            string result = xml.ToString();
            return result;
        }

        public String msgMaster(String ipport)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "Master"), ipport)
                );
            string result = xml.ToString();
            return result;
        }

        public String msgBackup(String ipport)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "Backup"), ipport)
                );
            string result = xml.ToString();
            return result;
        }

        public String msgRun()
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "Run"))
                );
            string result = xml.ToString();
            return result;
        }

        public String msgChat(String chat)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "Chat"), chat)
                );
            string result = xml.ToString();
            return result;
        }

        public String msgProgram(ProgramInfo prog) { return " "; }
    }
}
