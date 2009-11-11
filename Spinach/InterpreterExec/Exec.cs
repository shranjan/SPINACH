////////////////////////////////////////////////////////////////////////
// Exec.cs: demonstrates the interpreter for the Spinach language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Srinivasan Sundararajan (ssunda04@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

#define TEST_EXEC

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spinach
{
    public class executor
    {
        private Core coreObject;
        private exec frontEnd;
        public delegate void err(int code, string message);
        public event err errEvent;
        public void Onerror(int code, string message)
        {
            if (errEvent != null)
                errEvent(code, message);
        }
        public executor()
        {
            coreObject = new Core();
            frontEnd = new exec();
        }
        public void VisitLine(string args)
        {
            List<string> keywords = new List<string>();
            keywords = frontEnd.getKeywords();
            frontEnd.error_ += new Spinach.exec.errorreport(Onerror);
            frontEnd.astEvent += new Spinach.exec.ast(AST);
            frontEnd.Visitline(args);
        }
        public void AST(List<Element> elements)
        {
            coreObject.setAST(elements);
        }
    }
}



#if TEST_EXEC



namespace Spinach
{
    public class UI
    {
        public static void Main(string[] args)
        {
            Core obj = new Core();
            executor obj1 = new executor();
            obj1.errEvent += new executor.err(error);
            obj1.VisitLine("ubPlot(1,a,\"abc\",1D);vec[i]=i + 2;mat[i][j] = i + 2;");
        }
        public static void error(int code, string message)
        {
            Console.Write(code + " " + message);
        }
    }
}
#endif