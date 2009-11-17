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

