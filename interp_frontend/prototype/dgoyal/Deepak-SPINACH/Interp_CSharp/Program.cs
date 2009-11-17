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
         InterpLexer lexer = new InterpLexer(string_stream);
         CommonTokenStream tokens = new CommonTokenStream(lexer);			
         InterpParser parser = new InterpParser(tokens);
         try {
            InterpParser.program_return program = parser.program();
            List<Element> elements = program.ret;
            for(int i = 0; i < elements.Count; i++){
              Element curr = elements[i];
              //curr.Accept(print_visitor);
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
         theprogram.VisitLine("Struct simple{ int a; int b;}; simple s; s.a=4; print s.a;");
         //theprogram.VisitLine("M=(3)(2)[1,1,1,1,1,1];N=(2)(3)[2,1,1,1,1,1];var = 3+2; Z=M*N; print var;");
      }
   }
}
