////////////////////////////////////////////////////////////////////////
// LessThanEqualToElement.cs: Implements a vistor that interprets the 
//  LessThanEqualTo condition statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
/*
 * Module Operations
 * =================
 * This LessThanEqualToElement class will set and get the lhs and rhs
 * of the LessThanEqualTostatement.
 * 
 * Public Interface
 * ================
 * public Element getLessThanEqualToLhs(); 
 * public Element getLessThanEqualToRhs();
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs LessThanEqualToElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_LESSTHANEQUALTO define: LessThanEqualToElement.cs Element.cs
 */

//#define TEST_LESSTHANEQUALTO



using System;
using System.Collections.Generic;
using System.Collections;


public class LessThanEqualToElement : Element
{
    //Lhs element
    Element mLhs;
    //Rhs element
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitLessThanEqualToElement(this);
    }

    //get the Lhs element
    public Element getLessThanEqualToLhs() { return mLhs; }
    //set the Lhs element
    public void setLessThanEqualToLhs(Element lhs) { mLhs = lhs; }

    //get the Rhs element
    public Element getLessThanEqualToRhs() { return mRhs; }
    //set the Rhs element
    public void setLessThanEqualToRhs(Element rhs) { mRhs = rhs; }

}

//TEST STUB
#if TEST_LESSTHANEQUALTO
class Test
{
    static void Main(String[] args)
    {
        Console.WriteLine("\nTesting the LessThanEqualTo class");
        Console.WriteLine("\n==========================================\n");
        LessThanEqualToElement elem = new LessThanEqualToElement();
        VariableElement var_elem0 = new VariableElement();
        var_elem0.setText("a");
        elem.setLessThanEqualToLhs(var_elem0);
        VariableElement var_elem1 = new VariableElement();
        var_elem1.setText("b");
        elem.setLessThanEqualToRhs(var_elem1);
        VariableElement var_elem2 = new VariableElement();
        var_elem2 = (VariableElement)elem.getLessThanEqualToLhs();
        VariableElement var_elem3 = new VariableElement();
        var_elem3 = (VariableElement)elem.getLessThanEqualToRhs();
        Console.Write("LessThanEqualTo element is "+ var_elem2.getText().ToString()+" <= "+ var_elem3.getText().ToString()+"\n\n");
    }
}
#endif