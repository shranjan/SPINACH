//Mehmet KAYA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swarm
{
    class SwarmMemoryCaller
    {
        public void changePermission(string changes)
        {
            SwarmMemory mem = new SwarmMemory("dsf");
            //decompose changes and send the paramters to the function
            //take the proper instance of Swarm MEMory
            // SwarmMemory sm = function(Pid);
            //mem.changer(IPPort, read, write);
        }
        public void addPermission(string changes)
        {
            SwarmMemory mem = new SwarmMemory("dsf");
            //decompose changes and send the paramters to the function
            //take the proper instance of Swarm MEMory
            // SwarmMemory sm = function(Pid);
            //mem.adder(IPPort, read, write,code);
        }
        //if this is master machine
        public void finalSourceCodeChanger(string changes)
        {
            SwarmMemory mem = new SwarmMemory("dsf");
            //decompose and get Pid
            // SwarmMemory sm = function(Pid);
            //sm.finalCodeChange(changes);
        }
        public void masterSourceCodeChage(string changes)
        {
            SwarmMemory mem = new SwarmMemory("dsf");
            //decompose and get the Pid and send the changes to the other machines which has privilege on this program
            //ad another tag instead of masterSourcecodechange to the string
            //take the proper instance of Swarm MEMory
            // SwarmMemory sm = function(Pid);
            //sm.masterCodeChanger(changes);
        }
    }
}
