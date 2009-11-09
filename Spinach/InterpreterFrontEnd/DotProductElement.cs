////////////////////////////////////////////////////////////////////////
// DotProductElement.cs: holds the data needed for an 
//  assignment operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta (vnmehta@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
//#define TEST_DotProduct



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public  class DotProductElement :Element
    {
        VariableElement mLhs;
        VariableElement mRhs;

        public override void Accept(Visitor visitor)
        {
            visitor.VisitDotProductElement(this);
        }

        public VariableElement getLhs() { return mLhs; }
        public void setLhs(VariableElement lhs) { mLhs = lhs; }

        public VariableElement getRhs() { return mRhs; }
        public void setRhs(VariableElement rhs) { mRhs = rhs; }

    }

#if(TEST_DotProduct)

    //---------------< test stub >--------------------------------------------
class test{
    [STAThread]
    static void Main()
    {
        DotProductElement dp = new DotProductElement ();
        //VectorVariableDeclaration a = new VectorVariableDeclaration();
        //Element b;
        //Element c;
        //a.addValue(b);
        //a.addValue(c);

        //VectorVariableDeclaration aa = new VectorVariableDeclaration();
        //Element bb;
        //Element cc;
        //a.addValue(bb);
        //a.addValue(cc);
        VariableElement variable = new VariableElement();
        VariableElement variable1 = new VariableElement();
        variable.setText("vector");
        variable1.setText("vector1");
        dp.setLhs(variable);
        dp.setRhs(variable1);
        VariableElement variable2 = new VariableElement();
        VariableElement variable3 = new VariableElement();
        variable2 = dp.getLhs();
        variable3 = dp.getRhs();
        //dp.getRhs();
    }   
}
#endif