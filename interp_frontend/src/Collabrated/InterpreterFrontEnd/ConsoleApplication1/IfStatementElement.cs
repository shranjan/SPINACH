////////////////////////////////////////////////////////////////////////
// IfStatementElement.cs: Implements a vistor that interprets the 
//  If statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Collections;

public class IfStatementElement : Element
{
    //if condition element
    Element Condition;

    //List that contains If body
    List<Element> IfCode;

    //List that contains else Body
    List<Element> ElseCode;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitIfStatementElement(this);
    }

    //sets and gets the condition for if else.
    public Element CONDITION
    {
        get
        {
            return Condition;
        }
        set
        {
            Condition = value;
        }
    }

    //Sets and gets the if body.
    public List<Element> IFCODE
    {
        get
        {
            return IfCode;
        }
        set
        {
            IfCode = value;
        }
    }

    //Sets and gets the else body.
    public List<Element> ELSECODE
    {
        get
        {
            return ElseCode;
        }
        set
        {
            ElseCode = value;
        }
    }
}