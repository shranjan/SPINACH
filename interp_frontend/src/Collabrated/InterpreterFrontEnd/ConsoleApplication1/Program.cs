////////////////////////////////////////////////////////////////////////
// Program.cs: demonstrates the interpreter for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Antlr.Runtime;

namespace Interp_CSharp
{
   class Program
   {
      //InterpreterVisitor interp_visitor = new InterpreterVisitor();
      PrettyPrintVisitor print_visitor = new PrettyPrintVisitor();

      public void VisitLine(String line){
         ANTLRStringStream string_stream = new ANTLRStringStream(line);
         spinachLexer lexer = new spinachLexer(string_stream);
         CommonTokenStream tokens = new CommonTokenStream(lexer);			
         spinachParser parser = new spinachParser(tokens);
         try {
            spinachParser.program_return program = parser.program();
            List<Element> elements = program.ret;
            for(int i = 0; i < elements.Count; i++){
              Element curr = elements[i];
              curr.Accept(print_visitor);
              //curr.Accept(interp_visitor);
            }
          } catch (RecognitionException e)  {
            Console.WriteLine(e.Message);
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

      public static void Main(String[] args)
      {
          Program theprogram = new Program(); 
          //Deepak
          //theprogram.VisitLine("Vector<double>[5] v = [1.0,2.1,3.2,4.0,5.1]; Matrix<int>[3][2] m = [1,2,3,4,5]; delete m; int a; a = 10; int b;  print a; Struct simple{ int a; int b;}; simple s; s.a=4;");
          //Srinivasan
          //theprogram.VisitLine("for (j->3to10){int a; a = a + j;}parallelfor (i->0to2){String s; Vector<double>[5] v = [1.0,2.1,3.2,4.0,5.1]; Matrix<int>[3][2] m = [1,2,3,4,5]; delete m; SYNC; int a;int b;  print a; Struct simple{ int a; int b;}; simple s; s.a=4;} if (a!=0){int a; double b; a =1; b = 1.1;} ");
          //Kuldeep
          theprogram.VisitLine("subPlot(1,1,a,abc,1);subPlot(1,1,a,2,abcd,3);plot(b,1,abcd,1);resetPlot();setPlotAxis(1,2);setPlotAxis(1,2,3);");
          //Vinit
          //theprogram.VisitLine("int add(int a, int b){int c; double d; return c;} add(2,3);");
      }
   }
}
