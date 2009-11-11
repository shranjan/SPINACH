////////////////////////////////////////////////////////////////////////
// IntegerElement.cs: holds the data needed to represent an Integer.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class VectorElement : Element
{

    VariableElement mVar;
    IntegerElement mRange;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitVectorSingleElement(this);
    }

    public VariableElement getVar() { return mVar; }
    public void setVar(VariableElement var) { mVar = var; }
    public IntegerElement getRange() { return mRange; }
    public void setRange(IntegerElement range) { mRange = range; }
    
}

