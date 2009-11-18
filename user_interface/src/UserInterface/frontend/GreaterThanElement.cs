////////////////////////////////////////////////////////////////////////
// GreaterThanElement.cs: Implements a vistor that interprets the 
//  GreaterThan condition statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
/*
 * Module Operations
 * =================
 * This GreaterThanElement class will set and get the lhs and rhs
 * of the GreaterThanstatement.
 * 
 * Public Interface
 * ================
 * public Element getGreaterThanLhs(); 
 * public Element getGreaterThanRhs();
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs GreaterThanElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_GREATERTHAN define: GreaterThanELement.cs Element.cs
 */

//#define TEST_GREATERTHAN




using System;
using System.Collections.Generic;
using System.Collections;


public class GreaterThanElement : Element
{
    //Lhs element
    Element mLhs;
    //Rhs element
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitGreaterThanElement(this);
    }

    //get the Lhs element
    public Element getGreaterThanLhs() { return mLhs; }
    //set the Lhs element
    public void setGreaterThanLhs(Element lhs) { mLhs = lhs; }

    //get the Rhs element
    public Element getGreaterThanRhs() { return mRhs; }
    //set the Rhs element
    public void setGreaterThanRhs(Element rhs) { mRhs = rhs; }

}


//TEST STUB
#if TEST_GREATERTHAN
class Test
{
    static void Main(String[] args)
    {
        Console.WriteLine("\nTesting the GreaterThan class");
        Console.WriteLine("\n==========================================\n");
        GreaterThanElement elem = new GreaterThanElement();
        VariableElement var_elem0 = new VariableElement();
        var_elem0.setText("a");
        elem.setGreaterThanLhs(var_elem0);
        VariableElement var_elem1 = new VariableElement();
        var_elem1.setText("b");
        elem.setGreaterThanRhs(var_elem1);
        VariableElement var_elem2 = new VariableElement();
        var_elem2 = (VariableElement)elem.getGreaterThanLhs();
        VariableElement var_elem3 = new VariableElement();
        var_elem3 = (VariableElement)elem.getGreaterThanRhs();
        Console.Write("GreaterThan element is "+ var_elem2.getText().ToString()+" > "+ var_elem3.getText().ToString()+"\n\n");
    }
}
#endif