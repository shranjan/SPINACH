////////////////////////////////////////////////////////////////////////
// InterpreterVisitor.cs: Implements a vistor that interprets the 
//  syntax tree.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections;

public class InterpreterVisitor : Visitor {

  Hashtable mVariableMap;
  Stack<int> mStack;

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mStack = new Stack<int>();
  }

  public override void VisitVariableElement(VariableElement element){
    if(mVariableMap.ContainsKey(element.getText())){
      int element_value = (int) mVariableMap[element.getText()];
      mStack.Push(element_value);
    } else {
      //lets assume that the syntax has been checked for this example because I don't like the exception
      //propegation that will happen if I throw here
      //throw new Exception("Variable " + element.getText() + " not defined.");
    }
  }
  public override void VisitIntegerElement(IntegerElement element){
    int element_value = int.Parse(element.getText());
    mStack.Push(element_value);
  }
  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    String variable_name = element.getLhs().getText();

    Element rhs = element.getRhs();
    VisitElement(rhs);
    int result = mStack.Pop();    
    mVariableMap[variable_name] = result;
  }
  public override void VisitAdditionOperationElement(AdditionOperationElement element){
    VisitElement(element.getLhs());
    VisitElement(element.getRhs());
    int rhs = mStack.Pop();
    int lhs = mStack.Pop();
    int result = rhs + lhs;
    mStack.Push(result);    
  }
  public override void VisitPrintOperationElement(PrintOperationElement element){
    VisitElement(element.getChildElement());
    int result = mStack.Pop();
    Console.WriteLine(result.ToString());
  }
}
