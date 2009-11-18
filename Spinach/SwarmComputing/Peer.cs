using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Spinach
{

    public struct Peer
    {
        public String mIP;
        public String mPort;
        public String mName;
        public String mCPU;
    }

    public struct Heartbeat
    {
        public String SendTime;
        public String ReceiveTime;
    }

    public partial class AsynchronousSocketListener
    {
        public delegate void ChangedEventHandler(Hashtable conInfo);
        public event ChangedEventHandler ListChanged;


        ////////////////////////////////////////////////////////////////////////////////
        
        
        //connection part
        Peer mPeer = new Peer();

        //computation part
        //private Hashtable RunFlag = new Hashtable();//pid->runflag
        private Hashtable Program = new Hashtable();//pid->swarm program object

        //shared infomation part
        private String Master;
        private String Backup;
        private Hashtable IPtoPeer=new Hashtable();//ip:port->peer object
        private Hashtable NametoIP=new Hashtable();//username->ip:port
        private Hashtable IPtoHeartbeat = new Hashtable();//ip:port->heartbeat object
        

        public void SetIP(String str) { mPeer.mIP = str; }
        public String GetIP() { return mPeer.mIP; }

        public void SetPort(String str) { mPeer.mPort = str; }
        public String GetPort() { return mPeer.mPort; }

        public void SetName(String str) { mPeer.mName = str; }
        public String GetName() { return mPeer.mName; }

        public void SetCPU(String str) { mPeer.mCPU = str; }
        public String GetCPU() { return mPeer.mCPU; }

        //public void SetFlag(String pid,String flag) 
        //{
        //    RunFlag[pid] = flag;
        //}
        //public String GetFlag(String pid) 
        //{
        //    if(RunFlag.Contains(pid))
        //        return RunFlag[pid].ToString();
        //    else
        //        return "-1";
        //}

        public void SetMaster(String str) { Master = str; }
        public String GetMaster() { return Master; }

        public void SetBackup(String str) { Backup = str; }
        public String GetBackup() { return Backup; }

        public int InsertPeer(String ip, String port, String name, String cpu)
        {
            string ipport = ip + ":" + port;
            Peer nPeer=new Peer();
            nPeer.mIP=ip;
            nPeer.mPort=port;
            nPeer.mName=name;
            nPeer.mCPU=cpu;
            IPtoPeer[ipport] = nPeer;
            NametoIP[name] = ipport;

            


            //////////////////////////////
            if (ListChanged != null)
                ListChanged(IPtoPeer);
            //////////////////////////////////
            return 1;
        }

        public int RemovePeer(String ipport)
        {
            if (IPtoPeer.Contains(ipport))
            {
                Peer temp = (Peer)IPtoPeer[ipport];
                string name = temp.mName;
                IPtoPeer.Remove(ipport);
                if(NametoIP.Contains(name))
                    NametoIP.Remove(name);
                return 1;
            }
            else
                return 0;
        }

        public void Clear()
        {
            if (IPtoPeer.Count > 0)
                IPtoPeer.Clear();
            if (NametoIP.Count > 0)
                NametoIP.Clear();
            if (Program.Count > 0)
                Program.Clear();
        }

        public Hashtable GetIPtoPeer() { return IPtoPeer; }
        public Hashtable GetNametoIP() { return NametoIP; }

        public void InsertProg(String pid, SwarmMemory prog)
        {
            Program[pid] = prog;
        }

        //public int RemoveProg(String pid) 
        //{
        //    if (Program.Contains(pid))
        //    {
        //        Program.Remove(pid);
        //        return 1;
        //    }
        //    else
        //        return 0; 
        //}

        public SwarmMemory GetProg(String pid) 
        {
            SwarmMemory temp = null;
            if (Program.Contains(pid))
                temp = (SwarmMemory)Program[pid];
            return temp;  
        }

        public Hashtable GetPermission(String pid)
        {
            SwarmMemory temp=new SwarmMemory("-1","");
            Hashtable result = new Hashtable();
            if (Program.Contains(pid))
                temp = (SwarmMemory)Program[pid];
            result = temp.getPermissions();
            foreach (DictionaryEntry item in result)
            {
                string[] temp1 = (string[])item.Value;
                Console.WriteLine("IPPrt={0} read={1} write={2}", item.Key.ToString(), temp1[0], temp1[1]);
            }
            return result;
        }
        //public int CheckRun(String pid)
        //{
        //    return 0;
        //}

        //public String ProgOwner(String pid) { return "owner"; }
        //public int ReadAccess(String pid) { return 0; }
        //public int WriteAccess(String pid) { return 0; }
    }
}
