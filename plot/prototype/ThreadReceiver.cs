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
        public int num;
        public String str;

        public listdatatype(int x, String y)
        {
            num = x;
            str = y;
        }
    };

    List<listdatatype> data = new List<listdatatype>();    

    public void Check()
    {
        listdatatype m1 = new listdatatype(1, "Data~1");
        listdatatype m2 = new listdatatype(2, "Data~2");

        data.Add(m1);
        data.Add(m2);

        while (true)
        {
            if (data.Count>0)
            {
                Thread threadObj = new Thread(new ThreadStart(parsing));
                threadObj.Start();
                threadObj.Join();
            }
            if (false) // program terminates
                break;
        }
    }

    private void parsing()
    {
        Console.WriteLine(data[0].num+" "+data[0].str);
        data.RemoveAt(0);
    }
}
