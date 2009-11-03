////////////////////////////////////////////////////////////////////////
// ThreadReceiver.cs: Check for new data for plotting in list
// 
// version: 1.0
// description: Receive data for plotting
// author: Rushabh Ravindra Gandhi (rugandhi@syr.edu)
// language: Visual C#
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

public class ThreadReceiver
{
    public struct listdatatype
    {
        public int[,] values;
        public String str;

        public listdatatype(int[,] x, String y)
        {
            values = x;
            str = y;
        }
    };

    List<listdatatype> list = new List<listdatatype>();    

    public void CheckList()
    {
        int[,] sample_values1={{1,2},{34,53},{25,63}};
        int[,] sample_values2 = { { 3, 13 }, { 10, 5 }, { 9, 28 } };
        listdatatype m1 = new listdatatype(sample_values1, "plot_command1");
        listdatatype m2 = new listdatatype(sample_values2, "plot_command2");

        list.Add(m1);
        list.Add(m2);

        while (true)
        {
            if (list.Count>0)
            {
                Thread threadObj = new Thread(new ThreadStart(parsing));
                threadObj.Start();
                threadObj.Join();
            }
            if (!Thread.CurrentThread.IsAlive ) // program terminates
                break;
        }
    }

    private void parsing()
    {
        Console.WriteLine(list[0].str);
        for (int i = 0; i < list[0].values.GetLength(0); i++)
        {
            for (int j = 0; j < list[0].values.GetLength(1); j++)
                Console.Write(list[0].values[i, j]+" ");
            Console.WriteLine();
        }
        Console.WriteLine();
        list.RemoveAt(0);
        
        // call the function of paint module according to the type of plot_command
    }
}
