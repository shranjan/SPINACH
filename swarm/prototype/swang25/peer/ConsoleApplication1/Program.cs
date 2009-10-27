using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApplication1
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
        public String mIP;
        public String mPort;
        public String mName;
        public int mCPU;

        //computation part
        public int RunFlag;
        //result table may be finished after Core team's work

        //shared infomation part
        public String Master;
        public String Backup;
        public Hashtable IPtoName=new Hashtable();
        public Hashtable NametoIP=new Hashtable();
        public Hashtable IPtoCPU = new Hashtable();
        public ArrayList Program = new ArrayList(); //Use instance of ProgramInfo class as array member

        public Peer(String ip,String port,String name,int cpu)
        {
            mIP = ip;
            mPort = port;
            mName = name;
            mCPU = cpu;
            RunFlag = 0;
            String ipport = ip +":"+ port;
            InsertPeer(mIP, mPort, mName);
        }
        public int InsertPeer(String ip, String port, String name)
        {
            String ipport = ip +":"+ port;
            if (!IPtoName.Contains(ipport))
            {
                IPtoName[ipport] = name;
                NametoIP[name] = ipport;

                return 1;
            }
            else
                return 0;
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
        public void show()
        {
            Console.WriteLine("ip={0},port={1},name={2}\n", mIP, mPort, mName);
            Console.WriteLine("ip table:");
            foreach (Object key in IPtoName.Keys)
                Console.WriteLine("\n ({0},{1})", key, IPtoName[key]);
            Console.WriteLine("name table:");
            foreach (Object key in NametoIP.Keys)
                Console.WriteLine("\n ({0},{1})", key, NametoIP[key]);
        }
        public String msgIPandName()
        {
            XDocument xml=new XDocument(new XDeclaration("1.0","utf-8","yes"),
                new XComment("comment about this document"),
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
        public void getIPandName(string msg)
        {
            Console.WriteLine("Demonstrate get a XML msg: {0}\n",msg);
            XDocument xml = XDocument.Parse(msg);
            Console.WriteLine(xml.ToString());
            var q = from x in xml.Descendants() 
                    where(x.Attributes().Count()>0)
                    select x;
            foreach (var elem in q)
            {
                Console.Write(" IP: {0} <====> Name:{1}\n", elem.Attributes().ElementAt(0).Value, elem.Attributes().ElementAt(1).Value);
            }

        }
        //...interface to modifiy every data
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demonstrate a Peer :\n");
            Peer a= new Peer("127.0.0.1","1","Alice",1);
            a.show();
            Console.WriteLine("Demonstrate generate a XML msg: {0}\n",a.msgIPandName());
            a.getIPandName("<table><IPandName IP=\"192.168.1.1:80\" Name=\"Alice\" /><IPandName IP=\"192.168.1.2:80\" Name=\"Bob\" /></table>");
        }
    }
}
