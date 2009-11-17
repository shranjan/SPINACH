//Mehmet KAYA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Collections;

namespace AsyncServerForm
{
    class SwarmMemoryCaller
    {
        public void PortionReceive(string statementsXML)
        {
            XDocument doc = XDocument.Parse(statementsXML);
            var q = from x in doc.Elements().Descendants("Pid") select x;
            string Pid = q.ElementAt(0).Value.ToString();
            // SwarmMemory sm = function(Pid);
            SwarmMemory sm = new SwarmMemory("d","");
            sm.adjustThePartialTables(statementsXML);
        }
        public void StackInfo(string _stack)
        {
            // SwarmMemory sm = function(Pid);
            SwarmMemory sm = new SwarmMemory("d","");
            sm.receiveStack(_stack);
        }
        public SwarmMemory InitializeThePeer(string data, string myIPPort)
        {
            XDocument doc = XDocument.Parse(data);
            var q = from x in doc.Elements().Descendants("Pid") select x;
            string Pid = q.ElementAt(0).Value.ToString();
            
             SwarmMemory  sm = new SwarmMemory(Pid,myIPPort);            
            
            q = from x in doc.Elements().Descendants("stack").Descendants("value") select x;
            Stack<string> newProgramStack = new Stack<string>();

            foreach (var item in q)
            {
                newProgramStack.Push(item.Value.ToString());
            }
            newProgramStack.Reverse();
            sm.setProgramStack(newProgramStack);
            ////////////////////////////////////////////////////////
            q = from x in doc.Elements().Descendants("partialResults").Descendants("Result").Descendants("IPPort") select x;
            List<string> ResultIPorts = new List<string>();
            foreach (var item in q)
            {
                ResultIPorts.Add(item.Value.ToString());
            }
            q = from x in doc.Elements().Descendants("partialResults").Descendants("Result").Descendants("ResultValue") select x;
            List<string> ResultVal = new List<string>();
            foreach (var item in q)
            {
                ResultVal.Add(item.Value.ToString());
            }
            q = from x in doc.Elements().Descendants("partialResults").Descendants("Result").Descendants("done") select x;
            List<string> _done = new List<string>();
            foreach (var item in q)
            {
                _done.Add(item.Value.ToString());
            }
            Hashtable newPartialResults = new Hashtable();
            for (int i = 0; i < ResultIPorts.Count; i++)
            {
                string[] temp = { ResultVal[i].ToString(), _done[i].ToString() };
                newPartialResults.Add(ResultIPorts[i].ToString(), temp);
            }
            sm.setpartialResults(newPartialResults);
            /////////////////////////////
            q = from x in doc.Elements().Descendants("permissions").Descendants("permit").Descendants("IPPort") select x;
            List<string> IPorts = new List<string>();
            foreach (var item in q)
            {
                IPorts.Add(item.Value.ToString());
            }
            q = from x in doc.Elements().Descendants("permissions").Descendants("permit").Descendants("read") select x;
            List<string> reads = new List<string>();
            foreach (var item in q)
            {
                reads.Add(item.Value.ToString());
            }
            q = from x in doc.Elements().Descendants("permissions").Descendants("permit").Descendants("write") select x;
            List<string> writes = new List<string>();
            foreach (var item in q)
            {
                writes.Add(item.Value.ToString());
            }

            Hashtable newPermissions = new Hashtable();
            for (int i = 0; i < IPorts.Count; i++)
            {
                string[] temp = { reads[i].ToString(), writes[i].ToString() };
                newPermissions.Add(IPorts[i].ToString(), temp);
            }
            sm.setPermissions(newPermissions);
            //////////////////////////////
            q = from x in doc.Elements().Descendants("programVariables").Descendants("variable").Descendants("name") select x;
            List<string> varnames = new List<string>();
            foreach (var item in q)
            {
                varnames.Add(item.Value.ToString());
            }
            q = from x in doc.Elements().Descendants("programVariables").Descendants("variable").Descendants("value") select x;
            List<string> varvalues = new List<string>();
            foreach (var item in q)
            {
                varvalues.Add(item.Value.ToString());
            }
            Hashtable newProgramVariables = new Hashtable();
            for (int i = 0; i < varnames.Count; i++)
            {
                newProgramVariables.Add(varnames[i].ToString(), varvalues[i].ToString());
            }
            sm.setProgramVariables(newProgramVariables);
            ///////////////////////////////////////////
            q = from x in doc.Elements().Descendants("Replies").Descendants("Reply").Descendants("IPPort") select x;
            List<string> ports = new List<string>();
            foreach (var item in q)
            {
                ports.Add(item.Value.ToString());
            }
            q = from x in doc.Elements().Descendants("Replies").Descendants("Reply").Descendants("ReplyValue") select x;
            List<string> repVal = new List<string>();
            foreach (var item in q)
            {
                repVal.Add(item.Value.ToString());
            }
            Hashtable newReplies = new Hashtable();
            for (int i = 0; i < ports.Count; i++)
            {
                newReplies.Add(ports[i].ToString(), repVal[i].ToString());
            }
            sm.setReply(newReplies);
            ///////////////////////////////
            q = from x in doc.Elements().Descendants("Owner") select x;
            string owner = q.ElementAt(0).Value.ToString();
            sm.setOwner(owner);
            return sm;
            /*
            //////////////////////////////////////////////////////
            //this part belongs to TEST2
            string TestID = Pid;
            Stack<string> TestStack = sm.getStack();
            Hashtable TestPartialResults = sm.getPartialResults();
            Hashtable TestPermissions = sm.getPermissions();
            Hashtable TestVariables = sm.getProgramVariables();
            Hashtable TestReplies = sm.getReplies();
            string TestOwner = sm.getOwner();
            Console.WriteLine("========STACK=======");
            foreach (string item in TestStack)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("========PartialResults=======");
            foreach (DictionaryEntry item in TestPartialResults)
            {
                string[] temp = (string[])item.Value;
                Console.WriteLine("IP={0}  Value={1}  Done={2}", item.Key.ToString(), temp[0].ToString(), temp[1].ToString());
            }
            Console.WriteLine("========Permissions=======");
            foreach (DictionaryEntry item in TestPermissions)
            {
                string[] temp = (string[])item.Value;
                Console.WriteLine("IP={0}  read={1}  write={2}", item.Key.ToString(), temp[0].ToString(), temp[1].ToString());
            }
            Console.WriteLine("========Variables=======");
            foreach (DictionaryEntry item in TestVariables)
            {
                Console.WriteLine("name={0}  value={1}",item.Key.ToString(),item.Value.ToString());
            }
            Console.WriteLine("========Replies=======");
            foreach (DictionaryEntry item in TestReplies)
            {
                Console.WriteLine("IP={0}  Reply={1}", item.Key.ToString(), item.Value.ToString());
            }
            Console.WriteLine("========Owner=======");
            Console.WriteLine("Owner={0}",TestOwner);
             * */
        }
        public string[] changePermission(string changes)
        {            
            XDocument doc = XDocument.Parse(changes);

            var q = from x in doc.Elements().Descendants("Pid") select x;
            string Pid = q.ElementAt(0).Value.ToString();           
           

            q = from x in doc.Elements().Descendants("IPPort") select x;
            string IPPort = q.ElementAt(0).Value.ToString();
           
            q = from x in doc.Elements().Descendants("read") select x;
            string read = q.ElementAt(0).Value.ToString();
            
            q = from x in doc.Elements().Descendants("write") select x;
            string write = q.ElementAt(0).Value.ToString();

            string[] temp = { Pid, IPPort, read, write};
            return temp;
            //Console.WriteLine("Pid={0}  IPPort={1}  read={2}  write={3}",Pid,IPPort,read,write);
            //sm.changer(IPPort, read, write);
        }
        public string[] addPermission(string changes)
        {           
            XDocument doc = XDocument.Parse(changes);
            var q = from x in doc.Elements().Descendants("Pid") select x;
            string Pid = q.ElementAt(0).Value.ToString();                    
           
            q = from x in doc.Elements().Descendants("code") select x;
            string code=q.ElementAt(0).Value.ToString();

            q = from x in doc.Elements().Descendants("IPPort") select x;
            string IPPort=q.ElementAt(0).Value.ToString();

            q = from x in doc.Elements().Descendants("read") select x;
            string read = q.ElementAt(0).Value.ToString();

            q = from x in doc.Elements().Descendants("write") select x;
            string write = q.ElementAt(0).Value.ToString();

            string[] temp = { Pid, code, IPPort, read, write};
            return temp;
            /////////////test3/////////////

            //Console.WriteLine(IPPort);
            //Console.WriteLine(read);
            //Console.WriteLine(write);
            //Console.WriteLine(code);

            ///////////////////////////////
        }
        //if this is master machine
        public void finalSourceCodeChanger(string changes)
        {
            XDocument doc = XDocument.Parse(changes);
            var q = from x in doc.Elements().Descendants("Pid") select x;
            string Pid = q.ElementAt(0).Value.ToString();
            SwarmMemory sm = new SwarmMemory("dsf","");// SwarmMemory sm = function(Pid);
            sm.finalCodeChange(changes);
        }
        public void masterSourceCodeChage(string changes)
        {
            XDocument doc = XDocument.Parse(changes);
            var q = from x in doc.Elements().Descendants("Pid") select x;
            string Pid = q.ElementAt(0).Value.ToString();
            SwarmMemory sm = new SwarmMemory("dsf","");// SwarmMemory sm = function(Pid);
            sm.masterCodeChanger(changes);
           
        }
    }
}
