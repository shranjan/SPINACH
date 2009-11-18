//Mehmet KAYA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace Spinach
{
    public class SwarmMemory
    {
        Stack<string> programStack;//Stack object for the program
        Hashtable partialResults ;//result table
        Hashtable IPPort_toCode;
        Hashtable permissions; 
        Hashtable programVariables ;//variable-value pairs
        Hashtable Reply;
        String Pid;
        String owner;
        public SwarmMemory(string _Pid, string myIPPort)
        {
            Reply = new Hashtable();
            programStack = new Stack<string>();//Stack object for the program
            partialResults = new Hashtable();//result table
            programVariables = new Hashtable();//variable-value pairs
            permissions = new Hashtable();
            IPPort_toCode = new Hashtable();
            Pid = _Pid;
            string[] temp = { "true", "true"};
            permissions.Add(myIPPort, temp);
           
        }
        public Hashtable getPartialResults()
        {
            return partialResults;
        }
        public Hashtable getPermissions()
        {
            return permissions;
        }
        public Hashtable getProgramVariables()
        {
            return programVariables;
        }
        public void setReply(Hashtable newReply)
        {
            Reply = newReply;
        }
        public void setProgramVariables(Hashtable newVariables)
        {
            programVariables = newVariables;
        }
        public void setPermissions(Hashtable newPermissons)
        {
            permissions = newPermissons;
        }
        public void setpartialResults(Hashtable newResults)
        {
            partialResults = newResults;
        }
        public void setProgramStack(Stack<string> newStack)
        {
            programStack = newStack;
        }
        public void setOwner(string _owner)
        {
            owner = _owner;
        }
        public string getPid()
        {
            return Pid;
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
        public Hashtable getReplies()
        {
            return Reply;
        }
       
        public void adder(string IPPort, string read, string write, string code, string myIPPort)
        {
            string[] privileges = { read, write };
            permissions[IPPort] = privileges;          
           
            if (myIPPort == IPPort)
            {
                string[] localPrivilege = (string[])permissions[myIPPort];
                
                //call the UI teams function to disable the program
                //function(localPrivilege[0].ToString, localPrivilege[1].ToString, code );
            }
            Console.WriteLine("the current priveleges");
            foreach (DictionaryEntry item in permissions)
            {
                string[] temp = (string[])item.Value;
                Console.WriteLine("IPPrt={0} read={1} write={2}", item.Key.ToString(), temp[0], temp[1]);
            }
        }
        public void changer(string IPPort, string read, string write, string myIPPort)
        {
            string[] privileges = { read, write };
            permissions[IPPort] = privileges;
            if (IPPort == myIPPort)
            {
                string[] localPrivilege = (string[])permissions[myIPPort];
                //call the UI teams function to disable the program
                //function(localPrivilege[0].ToString, localPrivilege[1].ToString );
            }
            Console.WriteLine("permission changed to the followin values");
            foreach (DictionaryEntry item in permissions)
            {
                string[] temp=(string[])item.Value;
                Console.WriteLine("IPPrt={0} read={1} write={2}", item.Key.ToString(), temp[0], temp[1]);
            }
        }
        private string changePermissionMessage(string IPPort, string read, string write)
        {
            string _xml = "<PermissionChange>" + "<Pid>" + Pid.ToString() + "</Pid>"
                + "<IPPort>" + IPPort + "</IPPort>" + "<read>" + read + "</read>" + "<write>" + write + "</write>"
                + "</PermissionChange>";
            return _xml;
        }
        public void changePermissionRequest(string myIPPort, Hashtable dests, string IPPort, string read, string write)
        {
           
            string[] privileges = { read, write };
            permissions[IPPort] = privileges;
            List<string> endPoints = Peers();
            Hashtable temp = dests;
            List<string> removed = new List<string>();
            foreach (DictionaryEntry item in temp)
            {
                if (!endPoints.Contains(item.Key.ToString()))
                    removed.Add(item.Key.ToString());
            }
            for (int i = 0; i < removed.Count; i++)
            {
                temp.Remove(removed[i].ToString());
            }
            string permissionMessage = changePermissionMessage(IPPort, read, write);
            AsynchronousClient client = new AsynchronousClient();
            client.SetMultiMsg(temp, permissionMessage, myIPPort);
            Thread t = new Thread(new ThreadStart(client.SendMultiClient));
            t.Start();
            t.IsBackground = true;
            
        }
        public void finalCodeChange(string changes)
        {
            XDocument doc = XDocument.Parse(changes);
            var q = from x in doc.Elements().Descendants("Pid") select x;
            string Pid = q.ElementAt(0).Value.ToString();
            q = from x in doc.Elements().Descendants("delete") select x;
            string delno = q.ElementAt(0).Value.ToString();
            q = from x in doc.Elements().Descendants("add") select x;
            string addno = q.ElementAt(0).Value.ToString();
            q = from x in doc.Elements().Descendants("addstring") select x;
            string addString = q.ElementAt(0).Value.ToString();
            //UIteams function 
            //function(Pid,delno,addno,addString);
        }
        public void masterCodeChanger(string changes)
        {
            List<string> endPoints = Peers();
            XDocument doc = XDocument.Parse(changes);
            var q = from x in doc.Elements().Descendants("Pid") select x;
            string Pid = q.ElementAt(0).Value.ToString();
            q = from x in doc.Elements().Descendants("delete") select x;
            string delno = q.ElementAt(0).Value.ToString();
            q = from x in doc.Elements().Descendants("add") select x;
            string addno = q.ElementAt(0).Value.ToString();
            q = from x in doc.Elements().Descendants("addstring") select x;
            string addString = q.ElementAt(0).Value.ToString();
            //UIteams function 
            //function(Pid,delno,addno,addString);
            changes = changes.Substring(changes.IndexOf('>') + 1, changes.LastIndexOf('<') - changes.IndexOf('>') - 1);
            changes = "<sourcechange>" + changes + "</sourcechange>";
            //senderFunction(endPoints,changes);
        }
        public void sourceCodeChanged(int dellineno, int addlineno, string addstring)
        {
            string codechange = "<masterSourceChange>" +"<Pid>"+Pid.ToString()+"</Pid>"+ "<delete>" + dellineno.ToString() + "</delete>" + "<add>" + addlineno.ToString() + "</add>" + "<addstring>" + addstring + "</addstring>" + "</masterSorurceChange>";
            //find the master machine
            //senderfunction(mastermachine,codechange);            
        }
        public bool writePrivilege(string uname)
        {
            string IPPort = "";
            //IPPort = returnIPportFunction(uname);
            string[] _privilege=(string[])permissions[IPPort];
            if (_privilege[1].ToString() == "true")
                return true;
            return false;
        }
        private List<string> Peers()
        {
            List<string> computers = new List<string>();
            foreach (DictionaryEntry comps in permissions)
            {
                //string[] rw = (string[])comps.Value;
                //if (rw[0].ToString() == "true" )
                computers.Add(comps.Key.ToString());
            }
            return computers;
        }
        private string InitialXMLString()
        {
            string XMLstring = "<data><stack>";
            foreach (string item in programStack)
            {
                XMLstring += "<value>" + item.ToString() + "</value>";
            }
            XMLstring += "</stack><partialResults>";
            foreach (DictionaryEntry item in partialResults)
            {
                string[] temp = (string[])item.Value;
                XMLstring +="<Result><IPPort>" + item.Key.ToString() + "</IPPort>"
                           + "<ResultValue>" + temp[0].ToString() + "</ResultValue>" + "<done>" + temp[1].ToString() + "</done></Result>";

            }
            XMLstring += "</partialResults><permissions>";           
            foreach (DictionaryEntry item in permissions)
            {
                string[] p = (string[])item.Value;
                XMLstring += "<permit><IPPort>"+item.Key.ToString()+"</IPPort><read>"+p[0].ToString()+
                    "</read><write>"+p[1].ToString()+"</write></permit>";  
            }
            XMLstring += "</permissions><programVariables>";
            foreach (DictionaryEntry item in programVariables)
            {
                XMLstring += "<variable><name>" + item.Key.ToString() + "</name><value>" + item.Value.ToString() + "</value></variable>";
            }
            XMLstring += "</programVariables><Replies>";
            foreach (DictionaryEntry item in Reply)
            {
                XMLstring += "<Reply><IPPort>" + item.Key.ToString() + "</IPPort><ReplyValue>" + item.Value.ToString() + "</ReplyValue></Reply>";
            }
            XMLstring += "</Replies><Pid>"+Pid+"</Pid><Owner>"+owner+"</Owner></data>";
            return XMLstring.ToString();

        }
        private void createInitialData(string IPPort)
        {

            string DstIp = IPPort.Substring(0, IPPort.IndexOf(':'));
            string DstPort = IPPort.Substring(IPPort.IndexOf(':') + 1);
            AsynchronousClient client = new AsynchronousClient();
            client.SetSingleMsg(DstIp, DstPort, InitialXMLString());
            Thread t = null;
            t = new Thread(new ThreadStart(client.SendSingleClient));
            t.Start();
            t.IsBackground = true;      
           
           /*
             *this is a part of Test1
            Console.WriteLine(InitialXMLString());            
             */
           
        }
        //this function is used to give a privilege to a computer for the first time, so it includes
        //the source code as well among the parameters. before that it has to initialize all the other
        //data on the new machine so it calls createInitialData function
        public void addPermissionRequest(string myIPPort, Hashtable dests, string code, string IPPort, string read, string write)
        {

            createInitialData(IPPort);
            string[] privileges = { read, write };
            permissions[IPPort]= privileges;

            List<string> endPoints = Peers();
            Hashtable temp = dests;
            List<string> removed = new List<string>();
            foreach (DictionaryEntry item in temp)
            {
                if (!endPoints.Contains(item.Key.ToString()))
                {
                    removed.Add(item.Key.ToString());
                }
            }
            for (int i = 0; i < removed.Count; i++)
			{
			    temp.Remove(removed[i].ToString());
			}
            
            code = "<newProg>" +"<code>"+ code +"</code>"+"<Pid>"+Pid+"</Pid>"+"<IPPort>"+IPPort+"</IPPort>"+"<read>"+read+"</read>"+"<write>"+write+"</write>"+"</newProg>";
           // Console.WriteLine(code); //this line is a part of test1
            AsynchronousClient client = new AsynchronousClient();
            client.SetMultiMsg(temp, code, myIPPort);
            Thread t = new Thread(new ThreadStart(client.SendMultiClient));
            t.Start();
            t.IsBackground = true;
            
        }
        public void receiveStack(string XML_stack)
        {
            //the stack with the data in the XML_satck
        }
        public void sendStack(string XML_stack)
        {
            //fill the stack with the data in the XML_satck
            //send them to all the other computers
        }
        public Stack<string> getStack()
        {
            return programStack;
        }
        public double getVariableValue(string variable)
        {
            string value=programVariables[variable].ToString();
            return double.Parse(value);
        }
        public void deleteVariable(string variable)
        {
            programVariables.Remove(variable);
        }
        public void incomingResult(string resultInfo)
        {
            //fill the result table
        }
        //==================distribute
        public void adjustThePartialTables(string statementXML)
        {
            XDocument doc = XDocument.Parse(statementXML);
            var q = from x in doc.Elements().Descendants("Computer").Descendants() select x;
            List<string> statements = new List<string>();
            string IPPort="";
            foreach (var item in q)
            {
                if (item.Name.ToString() == "IPPort")
                {
                    if (IPPort == "")
                        IPPort = item.Value.ToString();
                    else
                    {
                        IPPort_toCode.Add(IPPort, statements);
                        statements.Clear();
                        IPPort = item.Value.ToString();
                    }
                }
                if (item.Name.ToString() == "Statement")
                    statements.Add(item.Value.ToString());
            }
            q = from x in doc.Elements().Descendants("Computer").Descendants("IPPort") select x;
            string[] temp = { "", "0" };//o not calculated 1 calculated
            foreach (var item in q)
            {
                partialResults.Add(item.Value.ToString(), temp);
            }
            //this computers IPPort?
            string IPprt = "";
            //function of core team to calculate this portion
            //function(IPprt,List<string>(IPPort_toCode[IPprt]));            
        }
        private string PortionsIPXML(int LinePerCPU, string[] statement, List<string> calculationComputers, Hashtable IPtoCPU)
        {
            int nextComputer = 0;
            string Portions = "";
            if (LinePerCPU < 1)
            {
                Portions += "<IPPort_Portion>";
                for (int i = 0; i < statement.Length; i++)
                {
                    Portions += "<Computer><IPPort>" + calculationComputers[nextComputer].ToString() + "</IPPort>";
                    for (int k = i; k < i + int.Parse(IPtoCPU[calculationComputers[nextComputer].ToString()].ToString()); k++)
                    {
                        Portions += "<Statement>" + statement[k].ToString() + "</Statement>";
                    }
                    Portions += "</Computer>";
                    i = i + int.Parse(IPtoCPU[calculationComputers[i].ToString()].ToString());
                    nextComputer++;
                }
                Portions += "</IPPort_Portion>";
            }
            else
            {
                Portions += "<IPPort_Portion>";
                for (int i = 0; i < statement.Length; i++)
                {
                    Portions += "<Computer><IPPort>" + calculationComputers[nextComputer].ToString() + "</IPPort>";
                    for (int k = i; k < i + (int.Parse(IPtoCPU[calculationComputers[nextComputer].ToString()].ToString())) * LinePerCPU; k++)
                    {
                        Portions += "<Statement>" + statement[k].ToString() + "</Statement>";
                    }

                    i = i + int.Parse(IPtoCPU[calculationComputers[i].ToString()].ToString());
                    nextComputer++;
                    if (nextComputer > calculationComputers.Count && i < statement.Length)
                    {
                        while (i < statement.Length)
                        {
                            Portions += "<Statement>" + statement[i].ToString() + "</Statement>";
                            i++;
                        }
                    }
                    Portions += "</Computer>";
                }
                Portions += "<Pid>"+Pid+"</Pid></IPPort_Portion>";
            }
            return Portions;
        }
        public void distributeParallelCode(string[] statement)
        {   
            //1. get IP to # CPU
            List<string> calculationComputers = new List<string>();
            Hashtable IPtoCPU = new Hashtable();//should come from other modules
            int totalCPU = 0;
            foreach (DictionaryEntry allPeers in IPtoCPU)
            {
                foreach (DictionaryEntry permitted in permissions)
                {
                    string[] temp = (string[])permitted.Value;
                    if (allPeers.Key.ToString() == permitted.Key.ToString() && temp[0].ToString() == "true")
                    {
                        totalCPU = totalCPU + int.Parse(allPeers.Value.ToString());
                        calculationComputers.Add(permitted.Key.ToString());
                    }
                }
            }
            int LinePerCPU = (int)(statement.Length / totalCPU);
            string PortionStatement = PortionsIPXML(LinePerCPU, statement, calculationComputers, IPtoCPU);
            List<string> endPoints = Peers();            
            foreach (string dest in endPoints)
            {
                ThreadProc thrd = new ThreadProc(dest.ToString(), PortionStatement);
                Thread t = new Thread(new ThreadStart(thrd.sendThread));
                t.Start();
            }            
        }
    }
    class ThreadProc
    {
        string msg;
        string IPPort;
        public ThreadProc(string _IPPort, string _msg)
        {
            msg = _msg;
            IPPort = _IPPort;
        }
        public void sendThread()
        {
            //callthe sender function
            //function(IPPort,msg);
        }
    }
}
