////////////////////////////////////////////////////////////////////////
// Program.cs: demonstrates the interpreter for the Spinach language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Srinivasan Sundararajan (ssunda04@syr.edu)
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
 public class Program :  spinachParser
   {
       static StringBuilder strBuilder = new StringBuilder();

       public delegate void errorreport(int code, string errormessage);
       public event errorreport error;
       public void Onerror(int code, string errormessage)
       {
           if (error != null)
               error(code, errormessage);
       }
       public override void ReportError(RecognitionException e)
       {
           
           string[] arr = TokenNames;
           string str = GetErrorHeader(e);
           string str1 = GetErrorMessage(e, arr);
           strBuilder.Append(str +" "+ str1+"\n");
       }
       public string returnError()
       {
           return strBuilder.ToString();
       }


       public Program(CommonTokenStream str,String coreObject):base(str)
       {

       }

      public void VisitLine(String line){
         ANTLRStringStream string_stream = new ANTLRStringStream(line);
         spinachLexer lexer = new spinachLexer(string_stream);
         CommonTokenStream tokens = new CommonTokenStream(lexer);			
         spinachParser parser = new Program(tokens,"");
         try {
             spinachParser.program_return program = parser.program(); //h= (l+j)*h*l+l-h;
             if (strBuilder.ToString() == "")
             {
                 List<Element> elements = program.ret;
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
          } catch (RecognitionException e)  {
              Onerror(102, e.Message);
          } 
      }

      public void RunEvalLoop(){
         while(true){
           Console.Write("Interp> ");
           String line = Console.ReadLine();
           if (line == "reset") { }
           else
               VisitLine(line);        
         }
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
         Program myprog = new Program(str,"");        
         myprog.error += new Program.errorreport(Onerror);
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
    obj.Visitline("parallelfor(i->1to){Vector<int>[2] a =[1,2,3,4];}");
    obj.Visitline("subPlot(1,1,a,\"abc\",1D);plot(b,\"abcd\",1D);for(i->1to4){struct s{int a;}; s.a = 0;//this is a comment string s; s = \"This is a example\";}");
    //obj.Visitline("if(a<=0){int a; a =9; double c; Vector<double>[2] vec=[1.1,2.2]; if(a==9){Matrix<int>[2][2] mat= [1,2,3,4];int d; return mat;} return a;}else{double e; return e;}");
    //obj.Visitline("int copy(Matrix<int> a,Vector<double> b , int c ){ int h; int l ; for(i->1to100){int a; a =9; double c; Vector<double>[2] vec=[1.1,2.2]; if(a==9){Matrix<int>[2][2] mat= [1,2,3,4];int d; return mat;}} return a; int j; h= (l+j)*h*l+l-h;}");

  }
  public static void error(int code, string message)
  {
    Console.Write(code + " ");
    Console.Write(message);
  }
}
