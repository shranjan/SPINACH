////////////////////////////////////////////////////////////////////////
// GreaterThanEqualToElement.cs: Implements a vistor that interprets the 
//  GreaterThanEqualTo condition statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
/*
 * Module Operations
 * =================
 * This GreaterThanEqualToElement class will set and get the lhs and rhs
 * of the GreaterThanEqualTostatement.
 * 
 * Public Interface
 * ================
 * public Element getGreaterThanEqualToLhs(); 
 * public Element getGreaterThanEqualToRhs();
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs GreaterThanEqualToElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_GREATERTHANEQUALTO define: GreaterThanEqualToElement.cs Element.cs
 */

//#define TEST_GREATERTHANEQUALTO

using System;
using System.Collections.Generic;
using System.Collections;


public class GreaterThanEqualToElement : Element
{
    //Lhs element
    Element mLhs;
    //Rhs element
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitGreaterThanEqualToElement(this);
    }

    //get the Lhs element
    public Element getGreaterThanEqualToLhs() { return mLhs; }
    //set the Lhs element
    public void setGreaterThanEqualToLhs(Element lhs) { mLhs = lhs; }

    //get the Rhs element
    public Element getGreaterThanEqualToRhs() { return mRhs; }
    //set the Rhs element
    public void setGreaterThanEqualToRhs(Element rhs) { mRhs = rhs; }

}


//TEST STUB
#if TEST_GREATERTHANEQUALTO
class Test
{
    static void Main(String[] args)
    {
        Console.WriteLine("\nTesting the GREATERThanEqualTo class");
        Console.WriteLine("\n==========================================\n");
        GreaterThanEqualToElement elem = new GreaterThanEqualToElement();
        VariableElement var_elem0 = new VariableElement();
        var_elem0.setText("a");
        elem.setGreaterThanEqualToLhs(var_elem0);
        VariableElement var_elem1 = new VariableElement();
        var_elem1.setText("b");
        elem.setGreaterThanEqualToRhs(var_elem1);
        VariableElement var_elem2 = new VariableElement();
        var_elem2 = (VariableElement)elem.getGreaterThanEqualToLhs();
        VariableElement var_elem3 = new VariableElement();
        var_elem3 = (VariableElement)elem.getGreaterThanEqualToRhs();
        Console.Write("GreaterThanEqualTo element is "+ var_elem2.getText().ToString()+" >= "+ var_elem3.getText().ToString()+"\n\n");
    }
}
#endif