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
<<<<<<< HEAD
        private Core coreObject;
        public Program MyProg;
=======
        public Core coreObject;
        public exec frontEnd;
>>>>>>> 4efd1032afc10710501156488d3a240631b09772
        public delegate void err(int code, string message);
        public event err errEvent;
        public delegate void result(string message);
        public event result resEvent;
        public void Onerror(int code, string message)
        {
            if (errEvent != null)
                errEvent(code, message);
        }
        public executor(PlotReceiver plot)
        {
<<<<<<< HEAD
            coreObject = new Core();
            Antlr.Runtime.CommonTokenStream str = new Antlr.Runtime.CommonTokenStream();
            MyProg = new Program(str);
=======
            coreObject = new Core(plot);
            frontEnd = new exec();
            frontEnd.error_ +=new exec.errorreport(Onerror);
            frontEnd.astEvent += new Spinach.exec.ast(AST);
            coreObject.errorcore_ +=new Core.errorcoremsg(Onerror);
            coreObject.rescore_ += new Core.resultcore(coreObject_rescore_);
        }

        
        void coreObject_rescore_(string coremsg)
        {
            if (resEvent != null)
                resEvent(coremsg);
>>>>>>> 4efd1032afc10710501156488d3a240631b09772
        }

        public void VisitLine(string args)
        {
            List<string> keywords = new List<string>();
<<<<<<< HEAD
            keywords = MyProg.getKeywords();
            MyProg.error += new Spinach.Program.errorreport(Onerror);
            MyProg.AstEvent += new Spinach.Program.AstReport(AST);
            MyProg.VisitLine(args);
=======
            keywords = frontEnd.getKeywords();
            //frontEnd.error_ += new Spinach.exec.errorreport(Onerror);
            
            
            frontEnd.Visitline(args);
>>>>>>> 4efd1032afc10710501156488d3a240631b09772
        }
        public void AST(List<Element> elements)
        {
            coreObject.clearVarMap();
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
            PlotReceiver plot = new PlotReceiver();
            Core obj = new Core(plot);
            executor obj1 = new executor(plot);
            obj1.errEvent += new executor.err(error);
            obj1.VisitLine("for(i->0to10){int a; double b; b = 1.1*(2.1*3.2);}struct s{}; struct sasda{int a; double b;};parallelfor(i->0to10){for(i->0to10){int a; double b;Matrix<int>[2][3] bv= []; b = 1.1*(2.1*3.2);}if(s.a!=0){int a;Vector<double>[4] vec= [1,2,3,4];}}");
        }
        public static void error(int code, string message)
        {
            Console.Write(code + " " + message);
        }
    }
}
#endif