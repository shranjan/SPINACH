////////////////////////////////////////////////////////////////////////
// ForStatementElement.cs: Implements a vistor that interprets the 
//  for statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5

/*
 * Module Operations
 * =================
 * This ForStatementElement class will set and get the range and the code
 * of the for statement
 * 
 * Public Interface
 * ================
 * public RangeElement RANGE;
 * public List<Element> CODELIST;
 * 
 */
 //
 /*
  * Build Process
  * =============
  * Required Files:
  *   Element.cs ForStatementElement.cs
  * 
  * Compiler Command:
  *   csc /target:exe /Test_FOR define: ForStatementElement.cs Element.cs
  */

//#define TEST_FOR

using System;
using System.Collections.Generic;
using System.Collections;

public class ForStatementElement : Element
{
    //The Range Variable.
    private VariableElement RangeVar;

    //The starting Range.
    private IntegerElement StartRange;

    //The Ending Range.
    private IntegerElement EndingRange;

    //List that contains the code in the body of the loop.
    private List<Element> CodeList;

    //Boolean to check if its parallelizable
    bool IsParallelizable;

    //Constructor
    public ForStatementElement()
    {
        CodeList = new List<Element>();
        IsParallelizable = true;
    }

    public override void Accept(Visitor visitor)
    {
        visitor.VisitForStatementElement(this);
    }

    //Set and get property for range variable.
    public VariableElement RANGEVARIABLE
    {
        get
        {
            return RangeVar;
        }
        set
        {
            RangeVar = value;
        }
    }

    //set and get the starting range
    public IntegerElement STARTINGRANGE
    {
        get
        {
            return StartRange;
        }
        set
        {
            StartRange = value;
        }
    }

    //set and get the Ending range
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

    //Adds the element to the list
    public Element ADDCODE
    {
        set
        {
            CodeList.Add(value);   
        }
    }


    //returns the list of code inside the loop.
    public List<Element> CODELIST
    {
        get
        {
            return CodeList;
        }
    }


    //set and get the isParallelizable boolean
    public bool IsParallel
    {
        get
        {
            return IsParallelizable;
        }
        set
        {
            IsParallelizable = value;
        }
    }

    public void ChkforParallel()
    {
        for (int i = 0; i < CodeList.Count; i++)
        {
            if (CodeList[i] is MatrixVariableDeclaration)
            {
                IsParallel = false;
            }
            else if (CodeList[i] is PlotFunctionElement)
            {
                IsParallel = false;
            }
            else if (CodeList[i] is FunctionCallElement)
            {
                IsParallel = false;
            }
            else if (CodeList[i] is VectorVariableDeclaration)
            {
                IsParallel = false;
            }
        }
    }
}


//TEST STUB
#if TEST_FOR
class Test
{
    static void Main(String[] args)
    {
        Console.WriteLine("\nTesting the ForStatementElement class");
        Console.WriteLine("\n==========================================\n");
        RangeElement elem = new RangeElement();
        VariableElement var_elem = new VariableElement();
        var_elem.setText("a");
        elem.RANGEVARIABLE = var_elem;
        IntegerElement int_elem = new IntegerElement();
        int_elem.setText("1");
        elem.STARTINGRANGE = int_elem;
        IntegerElement int_elem2 = new IntegerElement();
        int_elem2.setText("10");
        elem.ENDINGRANGE = int_elem2;
        ForStatementElement for_elem = new ForStatementElement();
        for_elem.RANGE = elem;
        ScalarVariableDeclaration scalar_elem = new ScalarVariableDeclaration();
        scalar_elem.setType("int");
        scalar_elem.setVar(var_elem);
        for_elem.ADDCODE = scalar_elem;
        RangeElement Relem = new RangeElement();
        Relem = for_elem.RANGE;
        Console.Write("Range is "+Relem.STARTINGRANGE.getText()+" to "+ Relem.ENDINGRANGE.getText()+"\n");
        List<Element> elem_list = new List<Element>();
        elem_list = for_elem.CODELIST;
        for(int i=0; i<elem_list.Count;i++)
        {
            Console.Write("The for statement list has " + elem_list[i].ToString()+"\n");
        }
    }
}
#endif

