////////////////////////////////////////////////////////////////////////
// PrettyPrintVisitor.cs: demonstrates printing the syntax tree in 
//  a difference source language than the input for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Srinivasan (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;

public class PrettyPrintVisitor : Visitor {

  public override void VisitVariableElement(VariableElement element){
    Console.Write(element.getText() + " ");
  }
  public override void VisitMatrixOperationElement(MatrixOperationElement element)
  {
      
  }
  public override void VisitStructDeclaration(StructDeclaration element)
  {
      Console.Write("Struct ");
      VisitElement(element.getName());
      Console.Write(";\n");
  }
  public override void VisitStructObject(StructObjectDeclaration element)
  {
      VisitElement(element.getStructName());
      Console.Write(" ");
      VisitElement(element.getObjName());
      Console.Write(";\n");
  }
  public override void VisitStructAssignment(StructAssignDeclaration element)
  {
      VisitElement(element.getName());
      Console.Write(".");
      VisitElement(element.getObj());
  }
  public override void VisitIntegerElement(IntegerElement element){
    Console.Write(element.getText() + " ");
  }
  public override void VisitDoubleElement(DoubleElement element)
  {
      Console.Write(element.getText() + " ");
  }
  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    VisitElement(element.getLhs());
    Console.Write("= ");
    VisitElement(element.getRhs());
    Console.Write(";\n");
  }
  public override void VisitAdditionOperationElement(AdditionOperationElement element){
    VisitElement(element.getLhs());
    Console.Write("+ ");
    VisitElement(element.getRhs());
  }
  public override void VisitMultiplicationOperationElement(MultiplicationOperationElement element)
  {
      VisitElement(element.getLhs());
      Console.Write("* ");
      VisitElement(element.getRhs());
      Console.Write(";\n ");
  }
  public override void VisitPrintOperationElement(PrintOperationElement element){
    Console.Write("function:print ");
    VisitElement(element.getChildElement());
    Console.Write(";\n");
  }
  public override void VisitDeclarationElement(DeclarationElement element)
  {
      Console.Write(element.gettype()+" ");
      VisitElement(element.getvariable());
  }
  public override void VisitDeleteElement(DeleteVariable element)
  {
      Console.Write("delete ");
      VisitElement(element.getVar());
      Console.Write(";\n");
  }
  public override void VisitEqualityOperationElement(EqualityOperationElement element)
  {
      Console.Write("(");
      VisitElement(element.getequalityLhs());
      Console.Write(" == ");
      VisitElement(element.getequalityRhs());
      Console.Write(")");
  }
  public override void VisitMatrixElement(MatrixVariableDeclaration element)
  {
      Console.Write("Matrix<" + element.getType()+">[");
      VisitElement(element.getRow());
      Console.Write("][");
      VisitElement(element.getColumn());
      Console.Write("] ");
      VisitElement(element.getVar());
      Console.Write(" = [");
      List<Element> elem = element.getList();
      for (int i = 0; i < elem.Count; i++)
      {
          VisitElement(elem[i]);
          if (elem.Count > 1 && i!= (elem.Count-1))
          {
              Console.Write(",");
          }
      }
      Console.Write("];\n");
  }
  public override void VisitNonEqualityOperationElement(NonEqualityOperationElement element)
  {
      Console.Write("(");
      VisitElement(element.getnonequalityLhs());
      Console.Write(" != ");
      VisitElement(element.getnonequalityRhs());
      Console.Write(")");
  }
  public override void VisitRangeElement(RangeElement element)
  {
      Console.Write("(");
      VisitElement(element.RANGEVARIABLE);
      Console.Write("->");
      VisitElement(element.STARTINGRANGE);
      Console.Write("to");
      VisitElement(element.ENDINGRANGE);
      Console.Write(")");
  }
  public override void VisitReturnElement(ReturnElement element)
  {
      Console.Write("return ");
      VisitElement(element.getreturnvariable());
      Console.Write(";\n");
  }
  public override void VisitStructVar(ScalarVariableDeclaration element)
  {
      Console.Write(element.getType()+" ");
      VisitElement(element.getVar());
      Console.Write(";\n");
  }
  public override void VisitVectorElement(VectorVariableDeclaration element)
  {
      Console.Write("Vector<" + element.getType()+">[");
      VisitElement(element.getRange());
      Console.Write("] ");
      VisitElement(element.getText());
      Console.Write(" = [");
      List<Element> elem = new List<Element>();
      elem = element.getList();
      for (int i = 0; i < elem.Count; i++)
      {
          VisitElement(elem[i]);
          if (elem.Count > 1 && i != (elem.Count - 1))
          {
              Console.Write(",");
          }
      }
      Console.Write("];\n");
  }
  public override void VisitFunctionCallElement(FunctionCallElement element)
  {
      VisitElement(element.getfunctioncallname());
      Console.Write("(");
      List<Element> param = element.getparameters();
      for (int i = 0; i < param.Count; i++)
      {
          VisitElement(param[i]);
          if (i < (param.Count - 1))
          {
              Console.Write(",");
          }
      }
      Console.Write(");\n");
  }
  public override void VisitFunctionElement(FunctionElement element)
  {
      Console.Write(element.getreturntype() + " ");
      VisitElement(element.getfunctionname());
      Console.Write("(");
      List<DeclarationElement> args = element.getArguments();
      for (int i = 0; i < args.Count; i++)
      {
          VisitElement(args[i]);
          if(i<(args.Count-1))
          {
              Console.Write(",");
          }
      }
      Console.Write(")");
      Console.Write("\n{\n\t");
      List<Element> funcbody = new List<Element>();
      funcbody = element.getBody();
      for (int i = 0; i < funcbody.Count; i++)
      {
          VisitElement(funcbody[i]);
          if (i < (funcbody.Count - 1))
          {
              Console.Write("\n\t");
          }
          else
          {
              Console.Write("\n");
          }
      }
      Console.Write("}\n");
  }
  public override void VisitForStatementElement(ForStatementElement element)
  {
      Console.Write("for");
      VisitElement(element.RANGE);
      Console.Write("\n{\n\t");
      List<Element> code = element.CODELIST;
      for (int i = 0; i < code.Count; i++)
      {
          VisitElement(code[i]);
          if (i != (code.Count - 1))
          {
              Console.Write("\n\t");
          }
          else
          {
              Console.Write("\n");
          }
      }
      Console.Write("}\n");
  }
  public override void VisitParallelForElement(ParallelForElement element)
  {
      Console.Write("parallelfor");
      VisitElement(element.RANGE);
      Console.Write("\n{\n\t");
      List<List<Element>> code = new List<List<Element>>();
      code = element.PARALLELCODE;
      bool flag = true;
      for (int i = 0; i < code.Count; i++)
      {
          if (i == (code.Count - 1))
          {
              flag = false;
          }
          List<Element> temp = new List<Element>();
          temp = code[i];
          for (int j = 0; j < temp.Count; j++)
          {
              VisitElement(temp[j]);
              if (flag)
              {
                  Console.Write("\n\t");
              }
              else
              {
                  if (j != (temp.Count - 1))
                  {
                      Console.Write("\n\t");
                  }
                  else
                  {
                      Console.Write("\n");
                  }
              }
          }
      }
      Console.Write("}\n");
  }
  public override void VisitIfStatementElement(IfStatementElement element)
  {
      Console.Write("if ");
      VisitElement(element.CONDITION);
      Console.Write("\n{\n\t");
      List<Element> If_code = new List<Element>();
      If_code = element.IFCODE;
      for (int i = 0; i < If_code.Count; i++)
      {
          VisitElement(If_code[i]);
          if (i < (If_code.Count - 1))
          {
              Console.Write("\n\t");
          }
          else
          {
              Console.Write("\n");
          }
      }
      Console.Write("}\n");
      List<Element> else_code = new List<Element>();
      else_code = element.ELSECODE;
      if (else_code!= null)
      {
          Console.Write("else\n{\n");
          for (int i = 0; i < else_code.Count; i++)
          {
              VisitElement(else_code[i]);
              if (i < (else_code.Count - 1))
              {
                  Console.Write("\n\t");
              }
              else
              {
                  Console.Write("\n");
              }
          }
          Console.Write("}\n");
      }
  }

  //public override void VisitPlotFunctionElement(PlotFunctionElement element)
  //{
  //    Console.WriteLine("Inside visit plot function..\n");
  //    //VisitElement(element.getData());

  //    if (element.getPlotFunction() == "subPlot")
  //    {
  //        if (element.getPlotType().getText() == "1")
  //        {
  //            //-- call the 1d subplot function.
  //            Console.WriteLine("\n visited type 1 of subPlot \n");
  //        }
  //        else if (element.getPlotType().getText() == "2")
  //        {
  //            //-- call the 2d subplot function.
  //            Console.WriteLine(" visited type 2 of subPlot \n");
  //        }
  //    }
  //    else if (element.getPlotFunction() == "plot")
  //    {
  //        Console.WriteLine("\n visited Plot \n");
  //    }

  //}
  public override void VisitPlotFunctionElement(PlotFunctionElement element)
  {
      {
          Console.WriteLine("Inside visit plot function Element\n");

          if (element.getPlotFunction() == "subPlot")
          {
              if (element.getPlotType().getText() == "1")
              {
                  Console.WriteLine("subPlot of type 1D :\n");
                  Console.Write("subPlot1D(");
                  VisitElement(element.getRow()); Console.Write(",");
                  VisitElement(element.getColumn()); Console.Write(",");
                  VisitElement(element.getData()); Console.Write(",");
                  VisitElement(element.getTitle()); Console.Write(");");



              }
              else if (element.getPlotType().getText() == "2")
              {
                  //-- call the 2d subplot function.
                  Console.WriteLine("visited subPlot type 2D \n");
                  Console.WriteLine("subPlot of type 2D :\n");
                  Console.Write("subPlot2D(");
                  VisitElement(element.getRow()); Console.Write(",");
                  VisitElement(element.getColumn()); Console.Write(",");
                  VisitElement(element.getData()); Console.Write(",");
                  VisitElement(element.getTitle()); Console.Write(");");
              }
              else if (element.getPlotType().getText() == "3")
              {
                  //-- call the 3d subplot function.
                  ///-- MODE: TBD
                  ///-- CHANGE: MODE TO A DEFAULT VALUE:

                  Console.WriteLine("visited subPlot type 3D \n");
                  Console.WriteLine("subPlot of type 3D :\n");
                  Console.Write("subPlot3D(");
                  VisitElement(element.getRow()); Console.Write(",");
                  VisitElement(element.getColumn()); Console.Write(",");
                  VisitElement(element.getData()); Console.Write(",");
                  VisitElement(element.getMode()); Console.Write(",");
                  VisitElement(element.getTitle()); Console.Write(");");
              }
          }
          else if (element.getPlotFunction() == "plot")
          {
              Console.WriteLine("\n visited plot \n");
          }
          else if (element.getPlotFunction() == "resetPlot")
          {
              Console.WriteLine("\n visited resetPlot \n");
          }
          else if (element.getPlotFunction() == "setPlotAxis")
          {
              Console.WriteLine("\n visited setPlotAxis \n");
          }
          else if (element.getPlotFunction() == "setPlotAxisTitle")
          {
              Console.WriteLine("\n visited setPlotAxisTitle\n");
          }
          else if (element.getPlotFunction() == "setScaleMode")
          {
              Console.WriteLine("\n visited setScaleMode \n");
          }

      }


  }
}
