////////////////////////////////////////////////////////////////////////
// ParallelForElement.cs: Implements a vistor that interprets the 
//  parallelfor statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
/*
 * Module Operations
 * =================
 * This ParallelForStatementElement class will set and get the range and the code
 * of the Parallelfor statement
 * 
 * Public Interface
 * ================
 * public RangeElement RANGE;
 * public List<List<Element>> PARALLELCODE;
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs ParallelForStatementElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_PARALLELFOR define: ParallelForStatementElement.cs Element.cs
 */

//#define TEST_PARALLELFOR


using System;
using System.Collections.Generic;
using System.Collections;


public class ParallelForElement : Element
{
    //The Range Variable.
    private VariableElement RangeVar;

    //The starting Range.
    private IntegerElement StartRange;

    //The Ending Range.
    private IntegerElement EndingRange;

    //List of code.
    private List<Element> Code;

    //List that contains the code in the body of the loop.
    private List<List<Element>> CodeList;
    
    //Constructor
    public ParallelForElement()
    {
        Code = new List<Element>();
        CodeList = new List<List<Element>>();
    }


    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelForElement(this);
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


    //adds the code inside the parallelfor loop to the list.
    public Element ADDCODE
    {
        set
        {
            Code.Add(value);
        }
    }

    //This function adds the list of elements to the List of list and clears itself.
    public void syncfunction()
    {
        CodeList.Add(Code);
        chkForIf(Code);
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


    public void chkForIf(List<Element> code)
    {
        for (int i = 0; i < code.Count; i++)
        {
            if (code[i] is IfStatementElement)
            {
                IfStatementElement if_elem = (IfStatementElement)code[i];
                if_elem.ChkforParallel();
            }
            if (code[i] is ForStatementElement)
            {
                ForStatementElement for_elem = (ForStatementElement)code[i];
                for_elem.ChkforParallel();
            }
        }
    }
}



//TEST STUB
#if TEST_PARALLELFOR
class Test
{
    static void Main(String[] args)
    {
        Console.WriteLine("\nTesting the ParallelForStatementElement class");
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
        ParallelForElement for_elem = new ParallelForElement();
        for_elem.RANGE = elem;
        ScalarVariableDeclaration scalar_elem = new ScalarVariableDeclaration();
        scalar_elem.setType("int");
        scalar_elem.setVar(var_elem);
        for_elem.ADDCODE = scalar_elem;
        for_elem.syncfunction();
        VariableElement elem2 = new VariableElement();
        elem2.setText("b");
        for_elem.ADDCODE = elem2;
        for_elem.syncfunction();
        RangeElement Relem = new RangeElement();
        Relem = for_elem.RANGE;
        Console.Write("Range is " + Relem.STARTINGRANGE.getText() + " to " + Relem.ENDINGRANGE.getText() + "\n");
        List<List<Element>> elem_list = new List<List<Element>>();
        elem_list = for_elem.PARALLELCODE;
        for(int i=0; i<elem_list.Count;i++)
        {
            List<Element> code = new List<Element>();
            code = elem_list[i];
            for (int j = 0; j<code.Count; j++)
            {
                Console.Write("The parallelfor statement code list "+ (i+1) +" has "+ code[j].ToString() + "\n");
            }
        }
    }
}
#endif

