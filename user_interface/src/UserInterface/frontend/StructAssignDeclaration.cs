////////////////////////////////////////////////////////////////////////
// StructAssignDeclaration.cs: holds the data needed to represent Structure 
//  in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class StructAssignDeclaration : Element
{

    Element mName;
    Element mObj;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitStructAssignment(this);
    }

    public Element getName() { return mName; }
    public void setName(Element text) { mName = text; }
    public Element getObj() { return mObj; }
    public void setObj(Element obj) { mObj = obj; }
}
