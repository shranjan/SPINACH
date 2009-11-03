////////////////////////////////////////////////////////////////////////
// StructVariableDeclaration.cs: holds the data needed to represent structure 
//  in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class ScalarVariableDeclaration : Element
{

    //VariableElement mName;
    VariableElement mVar;
    String mType;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitStructVar(this);
    }

    //public VariableElement getName() { return mName; }
    //public void setName(VariableElement text) { mName = text; }
    public VariableElement getVar() { return mVar; }
    public void setVar(VariableElement var) { mVar = var; }
    public String getType() { return mType; }
    public void setType(String type) { mType = type; }
}

