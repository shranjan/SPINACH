////////////////////////////////////////////////////////////////////////
//  Keywords.cs: holds the data to highlight keywords
//  
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author:vinit mehta
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
//Version history:
//
//version 1.2: kuldeep made change to struct keyword. (version number correspondes to grammar file)



//# define TEST_KEYWORDS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   public class Keywords
    {
        List<string> keys = new List<string>();
         public Keywords()
            {
                addkeywords();           
            }
        
        public List<string> getkeywords() { return keys; }
        public void addkeywords()
        {
            keys.Add("int");
            keys.Add("double");
            keys.Add("log");
            keys.Add("linear");
            keys.Add("string");
            keys.Add("DOT");
            keys.Add("for");
            keys.Add("if");
            keys.Add("else");
            keys.Add("parallelfor");
            keys.Add("void");
            keys.Add("delete");
            keys.Add("subPlot");
            keys.Add("plot");
            keys.Add("resetPlot");
            keys.Add("setPlotAxis");
            keys.Add("setAxisTitle");
            keys.Add("setScaleMode");
            keys.Add("return");
            keys.Add("SYNC");
            keys.Add("to");
            keys.Add("print");
            keys.Add("struct");
            keys.Add("T");
            keys.Add("Vector");
            keys.Add("Matrix");
        }

    }

#if(TEST_KEYWORDS)

    //---------------< test stub >--------------------------------------------
class test1
{
    [STAThread]
    static void Main()
    {
        Keywords keys = new  Keywords();
        List<string> k = new List<string>();
       k = keys.getkeywords();
    }
    }   
#endif