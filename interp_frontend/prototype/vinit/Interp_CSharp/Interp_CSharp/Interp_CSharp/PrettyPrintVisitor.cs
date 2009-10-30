////////////////////////////////////////////////////////////////////////
// PrettyPrintVisitor.cs: demonstrates printing the syntax tree in 
//  a difference source language than the input for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class PrettyPrintVisitor : Visitor {

  public override void VisitVariableElement(VariableElement element){
    Console.Write("var:" + element.getText() + " ");
  }
  public override void VisitIntegerElement(IntegerElement element){
    Console.Write("int:" + element.getText() + " ");
  }
  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    VisitElement(element.getLhs());
    Console.Write(":= ");
    VisitElement(element.getRhs());
    Console.WriteLine(";");
  }
  public override void VisitAdditionOperationElement(AdditionOperationElement element){
    VisitElement(element.getLhs());
    Console.Write("+ ");
    VisitElement(element.getRhs());
    Console.Write(" ");
  }
  public override void VisitPrintOperationElement(PrintOperationElement element){
    Console.Write("function:print ");
    VisitElement(element.getChildElement());
    Console.WriteLine(";");
  }
}
