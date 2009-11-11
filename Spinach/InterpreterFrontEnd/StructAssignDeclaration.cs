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
    Element mdata;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitStructAssignment(this);
    }

    public Element getObjName() { return mName; }
    public void setObjName(Element text) { mName = text; }
    public Element getDataMember() { return mdata; }
    public void setDataMember(Element data) { mdata = data; }
}
