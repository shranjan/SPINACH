////////////////////////////////////////////////////////////////////////
// ParallelForElement.cs: Implements a vistor that interprets the 
//  parallelfor statement.
// 
// version: 1.1
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Collections;


public class ParallelForElement : Element
{
    //The Range variable.
    RangeElement Range;
    
    //List of code.
    List<Element> Code = new List<Element>();

    //List that contains the code in the body of the loop.
    List<List<Element>> CodeList = new List<List<Element>>();
    
    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelForElement(this);
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
            Range= value;
        }
    }

    //adds the code inside the parallelfor loop to the list.
    public Element ADDCODE
    {
        set
        {
            Code.Add(value);
        }
    }

    //function that adds the list of code to the list of list and refreshes the original list.
    public void syncfunction()
    {
        CodeList.Add(Code);
        Code = new List<Element>();
    }


    //gets the whole body inside the parallel for
    public List<List<Element>> PARALLELCODE
    {
        get
        {
            return CodeList;
        }
    }
}