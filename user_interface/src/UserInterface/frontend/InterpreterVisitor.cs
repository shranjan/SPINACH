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
  List<int> mList;
  List<int> rcList;

  public InterpreterVisitor(){
    mVariableMap = new Hashtable();
    mStack = new Stack<int>();
    mList = new List<int>();
    rcList = new List<int>();
  }

  public override void VisitVariableElement(VariableElement element){
    if(mVariableMap.ContainsKey(element.getText())){
       List<int> list = new List<int>();
        //list.Add(mVariableMap[element.getText()]);
        list = (List<int>)mVariableMap[element.getText()];
        for (int i = 0; i < list.Count; i++)
        {
            mStack.Push(list[i]);
        }
    } else {
      //lets assume that the syntax has been checked for this example because I don't like the exception
      //propegation that will happen if I throw here
      //throw new Exception("Variable " + element.getText() + " not defined.");
    }
  }
  public override void VisitStructDeclaration(StructDeclaration element)
  {
      //throw new NotImplementedException();
  }
  public override void VisitStructObject(StructObjectDeclaration element)
  {
      //throw new NotImplementedException();
  }
  public override void VisitStructAssignment(StructAssignDeclaration element)
  {
      //throw new NotImplementedException();
  }
  public override void VisitMatrixElement(MatrixOperationElement element)
  {
      VisitElement(element.getValue());
      VisitElement(element.getRow());
      VisitElement(element.getColumn());
      int column = mStack.Pop();
      int row = mStack.Pop();
      rcList.Add(row);
      rcList.Add(column);
      
  }
  public override void VisitIntegerElement(IntegerElement element){
    string text = element.getText();
    if (text.Contains(","))
    {
        string[] inputs = text.Split(',');
        if (mList.Count != 0)
        {
            mList.Clear();
        }
        foreach (string input in inputs)
        {
            mList.Add(int.Parse(input));
        }
    }
    else
    {
        int element_value = int.Parse(text);
        mStack.Push(element_value);
    }
  }
  public override void VisitAssignmentOperationElement(AssignmentOperationElement element){
    String variable_name = element.getLhs().getText();

    Element rhs = element.getRhs();
    VisitElement(rhs);
    List<int> inputlist = new List<int>();
    if (mStack.Count != 0)
    {
        int result = mStack.Pop();
        inputlist.Add(result);
        mVariableMap[variable_name] = inputlist;
    }
    else
    {
        for (int i = 0; i < mList.Count; i++)
        {
            inputlist.Add(mList[i]);
        }
            mVariableMap[variable_name] = inputlist;
        //if (mList.Count != 0)
        //{
        //    mList.Clear();
        //}
    }
  }
  public override void VisitAdditionOperationElement(AdditionOperationElement element){
    VisitElement(element.getLhs());
    VisitElement(element.getRhs());
    int rhs = mStack.Pop();
    int lhs = mStack.Pop();
    int result = rhs + lhs;
    mStack.Push(result);    
  }
  public override void VisitMultiplicationOperationElement(MultiplicationOperationElement element)
  {
      VisitElement(element.getLhs());
      VisitElement(element.getRhs());
      int rhs = mStack.Pop();
      int lhs = mStack.Pop();
      int result = rhs * lhs;
      mStack.Push(result);
  } 
  public override void VisitPrintOperationElement(PrintOperationElement element){
    VisitElement(element.getChildElement());
    int result = mStack.Pop();
    Console.WriteLine(result.ToString());
  }
}
