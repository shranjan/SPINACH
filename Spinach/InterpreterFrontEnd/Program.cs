////////////////////////////////////////////////////////////////////////
// Program.cs: demonstrates the interpreter for the Spinach language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Srinivasan Sundararajan (ssunda04@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
// Version control:
// Version 1.2: kg: Made changes for structassign Class, if-else class, for class, matrixelem, vectorelem, Matrixdeclaration, VectorDeclaration, Keyword

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;

namespace Spinach
{
    public class Program : spinachParser
    {
        static StringBuilder strBuilder = new StringBuilder();
        private string exLine;

        public delegate void errorreport(int code, string errormessage);
        public event errorreport error;
        public delegate void AstReport(List<Element> ast);
        public event AstReport AstEvent;
        public void Onerror(int code, string errormessage)
        {
            if (error != null)
                error(code, errormessage);
        }
        public void Onoutput(List<Element> elements)
        {
            if (AstEvent != null)
                AstEvent(elements);
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
        public Program(CommonTokenStream str)
            : base(str)
        {
            strBuilder = new StringBuilder();
            exLine = "";
        }

        public void VisitLine(String line)
        {
            ANTLRStringStream string_stream = new ANTLRStringStream(line);
            spinachLexer lexer = new spinachLexer(string_stream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            spinachParser parser = new Program(tokens);
            try
            {
                spinachParser.program_return program = parser.program(); //h= (l+j)*h*l+l-h;
                if (strBuilder.ToString() == "")
                {
                    List<Element> elements = program.ret;

                    ///-- call core function. to pass list of element.
                    Onoutput(elements);

                    for (int i = 0; i < elements.Count; i++)
                    {
                        Element curr = elements[i];
                        //curr.Accept(print_visitor);
                        //curr.Accept(interp_visitor);
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
        public List<string> getKeywords()
        {
            Keywords obj = new Keywords();
            return obj.getkeywords();
        }

    }



    /// <summary>
    /// -- Executor Class.... 
    /// </summary>

    public class exec
    {
        public exec()
        {
        }
        public void Visitline(string args)
        {
            CommonTokenStream str = new CommonTokenStream();
            //We need the syntax for the core object
            Program myprog = new Program(str);
            myprog.error += new Program.errorreport(Onerror);
            myprog.AstEvent += new Program.AstReport(Onoutput);
            myprog.VisitLine(args);
        }
        public void Onoutput(List<Element> elements)
        {
            if (astEvent != null)
                astEvent(elements);
        }
        public List<string> getKeywords()
        {
            Keywords obj = new Keywords();
            return obj.getkeywords();
        }
        public delegate void errorreport(int code, string errormessage);
        public event errorreport error_;
        public delegate void ast(List<Element> elements);
        public event ast astEvent;
        public void Onerror(int code, string message)
        {
            if (error_ != null)
                error_(code, message);
        }
    }
}
