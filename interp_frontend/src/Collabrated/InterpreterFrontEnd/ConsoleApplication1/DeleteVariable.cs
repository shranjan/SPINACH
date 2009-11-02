////////////////////////////////////////////////////////////////////////
// VectorVariableDeclaration.cs: holds the data needed to represent matrix 
//  in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class DeleteVariable : Element
{

    VariableElement mVar;
    //IntegerElement mValue;
    //String mType;
    //IntegerElement Column;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitDeleteElement(this);
    }

    public VariableElement getVar() { return mVar; }
    public void setVar(VariableElement val) { mVar = val; }
    //public String getType() { return mType; }
    //public void setType(String type) { mType = type; }
    //public IntegerElement getValue() { return mValue; }
    //public void setValue(IntegerElement val) { mValue = val; }
    //public IntegerElement getColumn() { return Column; }
    //public void setColumn(IntegerElement c) { Column = c; }

}