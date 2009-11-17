////////////////////////////////////////////////////////////////////////
// Test_Core.cs: demonstrates the interpreter for the Spinach language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Rajika Tandon, Sushma Thimmappa
// source: Srinivasan Sundararajan (ssunda04@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;

namespace Spinach
{
    public class Test_Core : spinachParser
    {
        static StringBuilder strBuilder = new StringBuilder();
        private string exLine;

        public delegate void errorreport(int code, string errormessage);
        public event errorreport error;
        public void Onerror(int code, string errormessage)
        {
            if (error != null)
                error(code, errormessage);
        }
        public override void ReportError(RecognitionException e)
        {
            if (getEx() == null)
            {

                string[] arr = TokenNames;
                string str1 = GetErrorHeader(e);
                string str2 = GetErrorMessage(e, arr);
                strBuilder.Append(str1 + " " + str2 + "\n");
                setException(e);
            }
            else
            {
                string str = e.Line.ToString() + e.CharPositionInLine.ToString();
                if (str != getEx())
                {
                    string[] arr = TokenNames;
                    string str1 = GetErrorHeader(e);
                    string str2 = GetErrorMessage(e, arr);
                    strBuilder.Append(str1 + " " + str2 + "\n");
                    setException(e);
                }
            }
        }
        public string returnError()
        {
            return strBuilder.ToString();
        }

        public void setException(RecognitionException e)
        {
            exLine = e.Line.ToString() + e.CharPositionInLine.ToString();
        }
        public string getEx()
        {
            return exLine;
        }
        public Test_Core(CommonTokenStream str, String coreObject)
            : base(str)
        {
            strBuilder = new StringBuilder();
            exLine = "";
        }

        public void VisitLine(String line)
        {
            Core interp_visitor = new Core();
            PrintVisitor print_visitor = new PrintVisitor(interp_visitor);
            ANTLRStringStream string_stream = new ANTLRStringStream(line);
            spinachLexer lexer = new spinachLexer(string_stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            spinachParser parser = new Test_Core(tokens, "");
            try
            {
                spinachParser.program_return program = parser.program(); //h= (l+j)*h*l+l-h;
                if (strBuilder.ToString() == "")
                {
                    List<Element> elements = program.ret;

                    ///-- call core function. to pass list of element.

                    for (int i = 0; i < elements.Count; i++)
                    {
                        Element curr = elements[i];
                        curr.Accept(print_visitor);
                        curr.Accept(interp_visitor);//PlotReceiver
                    }
                }
                else
                {
                    Onerror(101, strBuilder.ToString());
                }
            }
            catch (RecognitionException e)
            {
                Onerror(102, e.Message);
            }
        }

        public void RunEvalLoop()
        {
            while (true)
            {
                Console.Write("Interp> ");
                String line = Console.ReadLine();
                if (line == "reset") { }
                else
                    VisitLine(line);
            }
        }
    }

#if(Test_Core)
    /// <summary>
    /// -- Executor Class.... 
    /// </summary>

    public class executive
    {
        public executive()
        {
        }
        public void Visitline(string args)
        {
            CommonTokenStream str = new CommonTokenStream();
            //We need the syntax for the core object
            Test_Core myprog = new Test_Core(str, "");
            myprog.error += new Test_Core.errorreport(Onerror);
            myprog.VisitLine(args);
        }
        public List<string> getKeywords()
        {
            Keywords obj = new Keywords();
            return obj.getkeywords();
        }
        public delegate void errorreport(int code, string errormessage);
        public event errorreport error_;
        public void Onerror(int code, string message)
        {
            if (error_ != null)
                error_(code, message);
        }
    }
}
    
/*
 * Test class
 * Entry point for console application.
 * 
 * 
 */
public class UI
{
    public static void Main(string[] args)
    {
        Spinach.exec obj = new Spinach.exec();
        List<string> keywords = new List<string>();
        keywords = obj.getKeywords();
        obj.error_ += new Spinach.exec.errorreport(error);
        obj.Visitline("int a");
        obj.Visitline("parallelfor(i->1to){Vector<int>[2] a =[1,2,3,4];}");
        obj.Visitline("subPlot(1,1,a,\"abc\",1D);plot(b,\"abcd\",1D);for(i->1to4){struct s{int a;}; s.a = 0;//this is a comment string s; s = \"This is a example\";}");
        obj.Visitline("if(a<=0){int a; a =9; double c; Vector<double>[2] vec=[1.1,2.2]; if(a==9){Matrix<int>[2][2] mat= [1,2,3,4];int d; return mat;} return a;}else{double e; return e;}");
        obj.Visitline("int copy(Matrix<int> a,Vector<double> b , int c ){ int h; int l ; for(i->1to100){int a; a =9; double c; Vector<double>[2] vec=[1.1,2.2]; if(a==9){Matrix<int>[2][2] mat= [1,2,3,4];int d; return mat;}} return a; int j; h= (l+j)*h*l+l-h;}");
        obj.Visitline("int a; a=10; int b; b=20; if(a==b) { print a; } else { print b; }");
    }
    public static void error(int code, string message)
    {
        Console.Write(code + " ");
        Console.Write(message);
    }

#endif

}