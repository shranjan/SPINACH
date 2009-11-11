////////////////////////////////////////////////////////////////////////
// SubtractionElement.cs: holds the data needed for an 
//  Subtraction operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

//# define TEST_SUBTRACTION
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   public class SubtractionElement:Element
    {
        Element mLhs;
        Element mRhs;

        public override void Accept(Visitor visitor)
        {
            visitor.VisitSubtractionElement(this);
        }

        public Element getLhs() { return mLhs; }
        public void setLhs(Element lhs) { mLhs = lhs; }

        public Element getRhs() { return mRhs; }
        public void setRhs(Element rhs) { mRhs = rhs; }
    }

#if(TEST_SUBTRACTION)

    //---------------< test stub >--------------------------------------------
class test
{
    
    static void Main()
    {
        SubtractionElement sub = new SubtractionElement();
        IntegerElement a = new IntegerElement();
        IntegerElement b = new IntegerElement();

        a.setText("5");

        b.setText("5");
        sub.setLhs(a);
        sub.setRhs(b);
        Element c;
        Element d;
        c = (Element)sub.getLhs();
        d = (Element)sub.getRhs();
    }
}   
#endif