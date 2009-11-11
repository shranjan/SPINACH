//Mehmet KAYA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using WPF_GUI;

namespace Swarm
{
    class SwarmMemory
    {
        Stack<string> programStack;//Stack object for the program
        List<string> partialResults ;//result table
        Hashtable permissions; 
        Hashtable programVariables ;//variable-value pairs
        Hashtable Reply;
        String Pid;
        String owner;
        public SwarmMemory(string _Pid)
        {
            Reply = new Hashtable();
            programStack = new Stack<string>();//Stack object for the program
            partialResults = new List<string>();//result table
            programVariables = new Hashtable();//variable-value pairs
            permissions = new Hashtable();
            Pid = _Pid;     
           
        }
        public void setOwner(string _owner)
        {
            owner = _owner;
        }
        public string getOwner()
        {
            return owner;
        }
        public int sizeOfReply()
        {
            return Reply.Count;
        }
        public void addReply(string IPP, string _reply)
        {
            Reply.Add(IPP, _reply);
        }
        public void deleteReply(string IPP)
        {
            Reply.Remove(IPP);
        }
        
       
        public void adder(string IPPort, string read, string write, string code)
        {
            string[] privileges = { read, write };
            permissions[IPPort] = privileges;
            string IPprt = "";
            //string IPprt=this compuetrs IPport
            string[] localPrivilege = (string[])permissions[IPprt];
            //call the UI teams function to disable the program
            //function(localPrivilege[0].ToString, localPrivilege[1].ToString, code );
        }
        public void changer(string IPPort, string read, string write)
        {
            string[] privileges = { read, write };
            permissions[IPPort] = privileges;
            string IPprt="";
            //string IPprt=this compuetrs IPport
            string[] localPrivilege =(string[])permissions[IPprt];            
            //call the UI teams function to disable the program
            //function(localPrivilege[0].ToString, localPrivilege[1].ToString );
        }
        private string changePermissionMessage(string IPPort, string read, string write)
        {
            string _xml = "<MessageType type=\"change\">" + "<Pid>" + Pid.ToString() + "</Pid>"
                + "<IPPort>" + IPPort + "</IPport>" + "<read>" + read + "</read>" + "<write>" + write + "</write>"
                + "</MessageType>";
            return _xml;
        }
        public void changePermissionRequest(string uname, string read, string write)
        {
            string IPPort="";
            //IPPort = returnIPportFunction(uname);
            string[] privileges = { read, write };
            permissions[IPPort] = privileges;
            List<string> endPoints = Peers();
            string permissionMessage = changePermissionMessage(IPPort, read, write);
            //senderfunction(endPoints, permissionMessage);
        }
        public void finalCodeChange(string changes)
        {
            // decompose the message and call the UI teams function to change the text box
            //function(dellineno, addlineno, addstring);
        }
        public void masterCodeChanger(string changes)
        {
            List<string> endPoints = Peers();
            //senderFunction(endPoints,changes);
        }
        public void sourceCodeChanged(int dellineno, int addlineno, string addstring)
        {
            string codechange = "<masterSourceChange>" +"<pid>"+Pid.ToString()+"</Pid>"+ "<delete>" + dellineno.ToString() + "</delete>" + "<add>" + addlineno.ToString() + "</add>" + "<addstring>" + addstring + "</addstring>" + "</masterSorurceChange>";
            //find the master machine
            //senderfunction(mastermachine,codechange);            
        }
        public bool writePrivilege(string uname)
        {
            string IPPort = "";
            //IPPort = returnIPportFunction(uname);
            string[] _privilege=(string[])permissions[IPPort];
            if (_privilege[1].ToString() == "True")
                return true;
            return false;
        }
        private List<string> Peers()
        {
            List<string> computers = new List<string>();
            foreach (DictionaryEntry comps in permissions)
            {
                string[] rw = (string[])comps.Value;
                if(rw[0].ToString()=="true")
                computers.Add(comps.Key.ToString());
            }
            return computers;
        }
        public void addPermissionRequest(string code, string uname, string read, string write)
        {
            
            string IPPort="";
            //IPPort = returnIPportFunction(uname);
            string[] privileges = {read , write};
            permissions.Add(IPPort,privileges);
            List<string> endPoints = Peers();
            code = "<newProg>" +"<code>"+ code +"</code>"+"<IP>"+IPPort+"</IP>"+"<read>"+read+"</read>"+"<write>"+write+"</write>"+"</newProg>";
            //senderfunction(endPoints, code);
        }
        public void setStack(string XML_stack)
        {
            //fill the stack with the data in the XML_satck
        }
        public Stack<string> getStack()
        {
            return programStack;
        }
        public double getVariableValue(string Pid, string variable)
        {
            return 0;
        }
        public void deleteVariable(string Pid, string variable)
        {
           
        }
        public void incomingResult(string resultInfo)
        {
            //fill the result table
        }
    }
}
