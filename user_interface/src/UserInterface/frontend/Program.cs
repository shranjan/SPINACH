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

namespace SPINACH_FRONTEND
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


       public Program(CommonTokenStream str):base(str)
       {
       }

      public void VisitLine(String line){
         ANTLRStringStream string_stream = new ANTLRStringStream(line);
         spinachLexer lexer = new spinachLexer(string_stream);
         CommonTokenStream tokens = new CommonTokenStream(lexer);			
         spinachParser parser = new Program(tokens);
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

      public List<string> getKeywords()
      {
          Keywords obj = new Keywords();
          return obj.getkeywords();
      }

      //public static void Main(String[] args)
      //{
      //    CommonTokenStream str = new CommonTokenStream();
      //    Program theprogram = new Program(str);
      //    //Deepak
      //    //theprogram.VisitLine("Vector<double>[5] v = [1.0,2.1,3.2,4.0,5.1]; Matrix<int>[3][2] m = [1,2,3,4,5]; delete m; int a; a = 10; int b;  print a; Struct simple{ int a; int b;}; simple s; s.a=4;");
      //    //Srinivasan
      //    //theprogram.VisitLine("for (j->3to10){int a; a = a + j;}parallelfor (i->0to2){String s; Vector<double>[5] v = [1.0,2.1,3.2,4.0,5.1]; Matrix<int>[3][2] m = [1,2,3,4,5]; delete m; SYNC; int a;int b;  print a; Struct simple{ int a; int b;}; simple s; s.a=4;} if (a <= 0){int a; double b; a =1; b = 1.1;} ");
      //    theprogram.VisitLine("if (a 0){int a; double b; a =; b = 0.1}");
      //    //theprogram.VisitLine("subPlot(1,1,a,abc,1D,2);plot(b,abcd,1D);");
      //    StringBuilder builder = theprogram.returnError();
      //    Console.Write(builder.ToString());

      //    //Kuldeep
      //    //theprogram.VisitLine("subPlot(1,1,a,1,abc,1);plot(b,1,abcd,1);");subplot(1,);
      //    //Vinit
      //    //theprogram.VisitLine("int add(int a, int b){int c; double d; return c;} add(2,3);");
      //    //BODMAS
      //    try
      //    {
      //        //theprogram.VisitLine(" a = (c+d)-(e*f)");
      //    }
      //    catch (Exception ex)
      //    {
      //        Console.Write(ex.ToString());
      //    }
      //}
   }



    /// <summary>
    /// -- testing.... 
    /// </summary>

 class exec
 {
     public exec()
     {
     }
     public static void Main(string[] args)
     {
         List<string> keywords = new List<string>();
         CommonTokenStream str = new CommonTokenStream();
         //We need the syntax for the core object
         Program myprog = new Program(str);
         keywords = myprog.getKeywords();
         myprog.error += new Program.errorreport(error1);
         //myprog.VisitLine("subPlot(1,1,a,\"abc\",1D);plot(b,\"abcd\",1D);for(i->1to4){struct s{int a;}; s.a = 0;//this is a comment string s; s = \"This is a example\";}");
         //myprog.VisitLine("if(a<=0){int a; a =9; double c; Vector<double>[2] vec=[1.1,2.2]; if(a==9){Matrix<int>[2][2] mat= [1,2,3,4];int d; return mat;} return a;}else{double e; return e;}");
         //myprog.VisitLine("int copy(Matrix<int> a,Vector<double> b , int c ){ int h; int l ; for(i->1to100){int a; a =9; double c; Vector<double>[2] vec=[1.1,2.2]; if(a==9){Matrix<int>[2][2] mat= [1,2,3,4];int d; return mat;}} return a; int j; h= (l+j)*h*l+l-h;}");
         myprog.VisitLine("parallelfor(i->1to4){Vector<int>[2] a =[1,2,3,4];}");

     }
     public static void error1(int code, string message)
     {
         Console.Write(code.ToString() + " ");
         Console.Write(message);
     }
 }
}
