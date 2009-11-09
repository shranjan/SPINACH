////////////////////////////////////////////////////////////////////////
// LessThanElement.cs: Implements a vistor that interprets the 
//  LessThan condition statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
/*
 * Module Operations
 * =================
 * This LessThanElement class will set and get the lhs and rhs
 * of the LessThanstatement.
 * 
 * Public Interface
 * ================
 * public Element getLessThanLhs(); 
 * public Element getLessThanRhs();
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs LessThanElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_LESSTHAN define: LessThanELement.cs Element.cs
 */

//#define TEST_LESSTHAN




using System;
using System.Collections.Generic;
using System.Collections;


public class LessThanElement : Element
{
    //Lhs element
    Element mLhs;
    //Rhs element
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitLessThanElement(this);
    }

    //get Lhs element
    public Element getLessThanLhs() { return mLhs; }
    //set Lhs element
    public void setLessThanLhs(Element lhs) { mLhs = lhs; }

    //get Rhs element
    public Element getLessThanRhs() { return mRhs; }
    //set Rhs element
    public void setLessThanRhs(Element rhs) { mRhs = rhs; }
}


//TEST STUB
#if TEST_LESSTHAN
class Test
{
    static void Main(String[] args)
    {
        Console.WriteLine("\nTesting the LessThan class");
        Console.WriteLine("\n==========================================\n");
        LessThanElement elem = new LessThanElement();
        VariableElement var_elem0 = new VariableElement();
        var_elem0.setText("a");
        elem.setLessThanLhs(var_elem0);
        VariableElement var_elem1 = new VariableElement();
        var_elem1.setText("b");
        elem.setLessThanRhs(var_elem1);
        VariableElement var_elem2 = new VariableElement();
        var_elem2 = (VariableElement)elem.getLessThanLhs();
        VariableElement var_elem3 = new VariableElement();
        var_elem3 = (VariableElement)elem.getLessThanRhs();
        Console.Write("LessThan element is "+ var_elem2.getText().ToString()+" < "+ var_elem3.getText().ToString()+"\n\n");
    }
}
#endif