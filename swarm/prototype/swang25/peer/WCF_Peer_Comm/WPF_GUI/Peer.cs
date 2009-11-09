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
    { }
    class Peer
    {
        //connection part
        private String mIP;
        private String mPort;
        private String mName;
        private String mCPU;

        //computation part
        private Hashtable RunFlag = new Hashtable();

        //shared infomation part
        private String Master;
        private String Backup;
        private Stirng LastHeartBeatTime;
        private Hashtable IPtoName=new Hashtable();
        private Hashtable NametoIP=new Hashtable();
        private Hashtable IPtoCPU = new Hashtable();
        

        private ArrayList Program = new ArrayList(); //Use instance of ProgramInfo class as array member

        public Peer()
        {
            mIP = " ";
            mPort = " ";
            mName = " ";
            mCPU = " ";

        }

        public void SetIP(String str) { mIP = str; }
        public String GetIP() { return mIP; }

        public void SetPort(String str) { mPort = str; }
        public String GetPort() { return mPort; }

        public void SetName(String str) { mName = str; }
        public String GetName() { return mName; }

        public void SetCPU(String str) { mCPU = str; }
        public String GetCPU() { return mCPU; }

        public void SetFlag(String pid,String flag) 
        {
            RunFlag[pid] = flag;
        }
        public String GetFlag(String pid) 
        {
            if(RunFlag.Contains(pid))
                return RunFlag[pid].ToString();
            else
                return "-1";
        }

        public void SetMaster(String str) { Master = str; }
        public String GetMaster() { return Master; }

        public void SetBackup(String str) { Backup = str; }
        public String GetBackup() { return Backup; }

        public int InsertPeer(String ipport, String name, String cpu)
        {
            IPtoName[ipport] = name;
            NametoIP[name] = ipport;
            IPtoCPU[ipport] = cpu;
            return 1;
        }

        public int RemovePeer(String ipport, String name)
        {
            if (IPtoName.Contains(ipport) && NametoIP.Contains(name))
            {
                IPtoName.Remove(ipport);
                NametoIP.Remove(name);
                IPtoCPU.Remove(ipport);
                return 1;
            }
            else
                return 0;
        }

        public Hashtable GetIPtoName() { return IPtoName; }
        public Hashtable GetIPtoCPU() { return IPtoCPU; }
        public Hashtable GetNametoIP() { return NametoIP; }

        public int InsertProg(int pid, ProgramInfo prog) { return 0; }
        public int RemoveProg(int pid) { return 0; }
        public int UpdateProg(int pid, ProgramInfo prog) { return 0; }
        public ProgramInfo GetProg(int pid) { return null; }

        public String ProgOwner(int pid) { return "owner"; }
        public int ReadAccess(int pid) { return 0; }
        public int WriteAccess(int pid) { return 0; }
    }
}
