////////////////////////////////////////////////////////////////////////
// RangeElement.cs: Implements a vistor that interprets the range in
//  for statement and parallel for statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.Collections;



public class RangeElement : Element
{

    VariableElement variable;

    IntegerElement StartingRange;

    IntegerElement EndingRange;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitRangeElement(this);
    }

    public VariableElement RANGEVARIABLE
    {
        get
        {
            return variable;
        }
        set
        {
            variable = value;
        }
    }

    public IntegerElement STARTINGRANGE
    {
        get
        {
            return StartingRange;
        }
        set
        {
            StartingRange = value;
        }
    }

    public IntegerElement ENDINGRANGE
    {
        get
        {
            return EndingRange;
        }
        set
        {
            EndingRange = value;
        }
    }
}