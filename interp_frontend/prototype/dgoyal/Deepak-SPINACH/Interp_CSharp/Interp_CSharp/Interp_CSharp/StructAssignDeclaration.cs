////////////////////////////////////////////////////////////////////////
// VariableElement.cs: holds the data needed to represent variables 
//  in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class StructAssignDeclaration : Element
{

    VariableElement mName;
    VariableElement mObj;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitStructAssignment(this);
    }

    public VariableElement getName() { return mName; }
    public void setName(VariableElement text) { mName = text; }
    public VariableElement getObj() { return mObj; }
    public void setObj(VariableElement obj) { mObj = obj; }
}
