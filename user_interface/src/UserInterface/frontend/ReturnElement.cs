////////////////////////////////////////////////////////////////////////
// ReturnElement.cs: holds the data needed for an 
//  Return operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

//#define TEST_Return
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


  public  class ReturnElement:Element

    {
        Element returnvariable;

        public override void Accept(Visitor visitor)
        {
            visitor.VisitReturnElement(this);
        }

        public Element getreturnvariable() { return returnvariable; }
        public void setreturnvariable(Element mreturnvariable) { returnvariable = mreturnvariable; }

    }

#if(TEST_Return)

    //---------------< test stub >--------------------------------------------
class test
{
    [STAThread]
    static void Main()
    {
        ReturnElement ret = new ReturnElement();
        VariableElement variable = new VariableElement();
        variable.setText("int");
        ret.setreturnvariable(variable);
        Element b;
        b = ret.getreturnvariable();
    } 
}  
#endif