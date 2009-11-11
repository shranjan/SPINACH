//Mehmet KAYA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Swarm;
namespace ParallelExecution
{
    class ParallelDistributer
    {
        
        public void distributeParallelCode(string[] statement)
        {
            //1. get the number of cpu of each computer
            //2. divide the statements into that number of subgroups
            //3. send them to the corresponding machines.
        }
        public void getPortion(string portion)
        {
            //getPortion the portions and send them To the proper function of the core teams.
        }
        public void getPartialResult(string resultInfo)
        {
            //I need the specific instance of the Swarm memory class for that string
            //decompose the message and call the function to fill the result table via the object of the class
            //the result table is completed?
        }

        public void sendPartialResult(string resultInfo)
        {
            //fill the machines result table and send to the others
            //the result table is complted? what now?    
        }


    }
}
