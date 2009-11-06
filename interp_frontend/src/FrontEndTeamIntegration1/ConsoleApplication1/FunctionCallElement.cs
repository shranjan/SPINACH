////////////////////////////////////////////////////////////////////////
// FunctionCallElement.cs: holds the data needed for an 
//  assignment operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta (vnmehta@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

//#define TEST_FunctionCall

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


 public   class FunctionCallElement:Element
    {
        Element functioncallname;
        List<Element> parameters = new List<Element>();

        public override void Accept(Visitor visitor)
        {
            visitor.VisitFunctionCallElement(this);
        }

        public Element getfunctioncallname() { return functioncallname; }
        public void setfunctioncallname(Element mfunctioncallname) { functioncallname = mfunctioncallname; }

        public List<Element> getparameters() { return parameters; }
        public void setparameters(Element mparameters) { parameters.Add(mparameters); }


    }

#if(TEST_FunctionCall)

    //---------------< test stub >--------------------------------------------

    class test
{
    static void Main()
    {
        FunctionCallElement funccall = new FunctionCallElement();
        

        VariableElement name = new VariableElement();
        name.setText("functioncall");
        funccall.setfunctioncallname(name);
        VariableElement name1 = new VariableElement();
        VariableElement name2 = new VariableElement();
        name1.setText("a");
        name2.setText("b");
        funccall.setparameters(name1);
        funccall.setparameters(name2);

        List<Element> s = funccall.getparameters();
        Element e;
        
        e = (Element)funccall.getfunctioncallname();
    }  
} 
#endif