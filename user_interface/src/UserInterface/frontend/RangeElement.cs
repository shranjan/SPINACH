

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