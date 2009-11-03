////////////////////////////////////////////////////////////////////////
// ForStatementElement.cs: Implements a vistor that interprets the 
//  for statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Collections;

public class ForStatementElement : Element
{
    //The Range Element.
    RangeElement Range;

    //List that contains the code in the body of the loop.
    List<Element> CodeList = new List<Element>();

    public override void Accept(Visitor visitor)
    {
        visitor.VisitForStatementElement(this);
    }

    //Set and get property for range variable.
    public RangeElement RANGE
    {
        get
        {
            return Range;
        }
        set
        {
            Range = value;
        }
    }
    
    //Adds the code to the list.
    public Element ADDCODE
    {
        set
        {
            CodeList.Add(value);   
        }
    }


    //gets the code inside the parallelfor loop to the list.
    public List<Element> CODELIST
    {
        get
        {
            return CodeList;
        }
    }
}