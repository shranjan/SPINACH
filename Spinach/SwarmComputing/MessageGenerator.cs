using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Spinach
{
    class MessageGenerator
    {
        public String msgConnectionRequest(String IP,String Port,String Name,String CPU)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root",new XAttribute("type","Connection"))
                );
            XElement temp = xml.Descendants("root").First();
            XElement Connection = new XElement("Connection");
            XAttribute a1 = new XAttribute("IP", IP);
            XAttribute a2 = new XAttribute("Port", Port);
            XAttribute a3 = new XAttribute("Name", Name);
            XAttribute a4 = new XAttribute("CPU", CPU);
            Connection.Add(a1);
            Connection.Add(a2);
            Connection.Add(a3);
            Connection.Add(a4);
            temp.Add(Connection);
            string result = xml.ToString();
            return result;
        }

        public String msgIPtoPeer(Hashtable IPtoPeer)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "IPtoPeer"))
                );
            XElement temp = xml.Descendants("root").First();
            foreach (Object ip in IPtoPeer.Keys)
            {
                Peer mPeer = (Peer)IPtoPeer[ip];
                XElement IPandName = new XElement("IPNameCPU");
                XAttribute a1 = new XAttribute("IP", mPeer.mIP);
                XAttribute a2 = new XAttribute("Port", mPeer.mPort);
                XAttribute a3 = new XAttribute("Name", mPeer.mName);
                XAttribute a4 = new XAttribute("CPU", mPeer.mCPU);
                IPandName.Add(a1);
                IPandName.Add(a2);
                IPandName.Add(a3);
                IPandName.Add(a4);
                temp.Add(IPandName);
            }
            string result = xml.ToString();
            return result;
        }

        public String msgHeartBeatRequest(String ipport)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "HeartBeatRequest"), ipport)
                );
            string result = xml.ToString();
            return result;
        }

        public String msgHeartBeatReply(String ipport)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "HeartBeatReply"), ipport)
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

        //public String msgRunRequest(String pid,String ipport)
        //{
        //    XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
        //        new XElement("root", new XAttribute("type", "Run"), new XAttribute("pid", ipport))
        //        );
        //    string result = xml.ToString();
        //    return result;
        //}

        //public String msgRunFailReply(String pid,String ipport)
        //{
        //    XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
        //        new XElement("root", new XAttribute("type", "RunFail"), new XAttribute("pid", ipport))
        //        );
        //    string result = xml.ToString();
        //    return result;
        //}

        //public String msgRunSucessReply(String pid, String ipport)
        //{
        //    XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
        //        new XElement("root", new XAttribute("type", "RunSucess"), new XAttribute("pid", ipport))
        //        );
        //    string result = xml.ToString();
        //    return result;
        //}
        //public String msgCancleRun(String pid)
        //{
        //    XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
        //        new XElement("root", new XAttribute("type", "ReRun"), pid)
        //        );
        //    string result = xml.ToString();
        //    return result;
        //}

        public String msgChat(String chat,String ipport)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "Chat"))
                );
            XElement temp = xml.Descendants("root").First();
            XElement Chating = new XElement("Chating");
            XAttribute a1 = new XAttribute("IP", ipport);
            XAttribute a2 = new XAttribute("Content", chat);
            Chating.Add(a1);
            Chating.Add(a2);
            temp.Add(Chating);
            string result = xml.ToString();
            return result;
        }

        public String msgError(String error)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "Error"), error)
                );
            string result = xml.ToString();
            return result;
        }

        public String msgDisconnect(String ipport)
        {
            XDocument xml = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("root", new XAttribute("type", "Disconnect"), ipport)
                );
            string result = xml.ToString();
            return result;
        }

        //public String msgProgram(ProgramInfo prog) { return " "; }
    }
}
