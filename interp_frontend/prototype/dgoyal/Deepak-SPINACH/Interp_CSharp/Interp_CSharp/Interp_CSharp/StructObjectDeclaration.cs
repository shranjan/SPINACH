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

public class StructObjectDeclaration : Element
{

    VariableElement mObjName;
    VariableElement mStructName;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitStructObject(this);
    }

    public VariableElement getObjName() { return mObjName; }
    public void setObjName(VariableElement text) { mObjName = text; }
    public VariableElement getStructName() { return mStructName; }
    public void setStructName(VariableElement name) { mStructName = name; }
}

