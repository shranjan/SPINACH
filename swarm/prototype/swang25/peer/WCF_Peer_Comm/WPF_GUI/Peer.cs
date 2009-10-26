using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace WPF_GUI
{
    class ProgramInfo
    {
        public int ID;
        public String Contents; //This data structure depends on how program saved, it may not be string
        public String Owner;
        public int ReadPrivilige;
        public int WritePrivilige;


        public ProgramInfo(int id) { }
        //...interface to modifiy every data
    }
    class Peer
    {
        //connection part
        private String mIP;
        private String mPort;
        private String mName;
        private String mCPU;

        //computation part
        private int RunFlag;
        //result table may be finished after Core team's work

        //shared infomation part
        private String Master;
        private String Backup;
        private Hashtable IPtoName=new Hashtable();
        private Hashtable NametoIP=new Hashtable();
        private Hashtable IPtoCPU = new Hashtable();
        private ArrayList Program = new ArrayList(); //Use instance of ProgramInfo class as array member

        public Peer()
        {
            mIP = " ";
            mPort = " ";
            mName = " ";

            RunFlag = 0;
        }

        public Peer(String ip,String port,String name)
        {
            mIP = ip;
            mPort = port;
            mName = name;
         
            RunFlag = 0;
        }
        public int InsertPeer(String ip, String port, String name)
        {
            String ipport = ip +":"+ port;
            IPtoName[ipport] = name;
            NametoIP[name] = ipport;
            return 1;
        }

        public void AddSelf()
        {
            String ipport = mIP + ":" + mPort;
            InsertPeer(mIP, mPort, mName);
        }
        public int RemovePeer(String ip, String port, String name)
        {
            String ipport = ip +":"+ port;
            if (IPtoName.Contains(ipport) && NametoIP.Contains(name))
            {
                IPtoName.Remove(ipport);
                NametoIP.Remove(name);
                return 1;
            }
            else
                return 0;
        }
        public int InsertProg(int id, ProgramInfo prog) { return 0; }
        public int RemoveProg(int id, ProgramInfo prog) { return 0; }
        public int UpdateProg(int id, ProgramInfo prog) { return 0; }

        public String msgIPandName()
        {
            XDocument xml=new XDocument(new XDeclaration("1.0","utf-8","yes"),
                new XElement("table")
                );
            XElement temp = xml.Descendants("table").First();
            foreach (Object key in IPtoName.Keys)
            {
                XElement IPandName = new XElement("IPandName");
                XAttribute a1 = new XAttribute("IP",key.ToString());
                XAttribute a2 = new XAttribute("Name", IPtoName[key].ToString());
                IPandName.Add(a1);
                IPandName.Add(a2);
                 //more attribute here to further data
                temp.Add(IPandName);
            }
            string result = xml.ToString();
            return result;
        }
        public string getIPandName(string msg)
        {
            String result="Try to build table contains:\n ";
            Console.WriteLine("Demonstrate get a XML msg: {0}\n",msg);
            XDocument xml = XDocument.Parse(msg);
            Console.WriteLine(xml.ToString());
            var q = from x in xml.Descendants() 
                    where(x.Attributes().Count()>0)
                    select x;
            foreach (var elem in q)
            {
                result = result + "IP: " + elem.Attributes().ElementAt(0).Value + " <====> Name: " + elem.Attributes().ElementAt(1).Value + "\n";
                    IPtoName[elem.Attributes().ElementAt(0).Value.ToString()] = elem.Attributes().ElementAt(1).Value.ToString();
                    NametoIP[elem.Attributes().ElementAt(1).Value.ToString()] = elem.Attributes().ElementAt(0).Value.ToString();
            }
            return result;

        }
        //...interface to modifiy every data
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Demonstrate a Peer :\n");
    //        Peer a= new Peer("127.0.0.1","1","Alice",1);
    //        a.show();
    //        Console.WriteLine("Demonstrate generate a XML msg: {0}\n",a.msgIPandName());
    //        a.getIPandName("<table><IPandName IP=\"192.168.1.1:80\" Name=\"Alice\" /><IPandName IP=\"192.168.1.2:80\" Name=\"Bob\" /></table>");
    //    }
    //}
}
