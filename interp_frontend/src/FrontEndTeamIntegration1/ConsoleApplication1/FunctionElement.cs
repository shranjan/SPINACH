////////////////////////////////////////////////////////////////////////
//FunctionElement.cs: holds the data needed for an 
//  function operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta (vnmehta@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

//#define TEST_FunctionElement
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



   public class FunctionElement: Element
    {
        
        String returntype;
        Element functionname;
        List<Element> body = new List<Element>();
        List<Element> Arguments = new List<Element>();

        public override void Accept(Visitor visitor)
        {
            visitor.VisitFunctionElement(this);
        }

        public String getreturntype() { return returntype; }
        public void setreturntype(String mreturntype) { returntype = mreturntype; }

        public Element getfunctionname() { return functionname; }
        public void setfunctionname(Element mfunctionname) { functionname= mfunctionname; }

        public List<Element> getArguments() { return Arguments; }
        public void setArguments(Element decElem) { Arguments.Add(decElem); }

        public List<Element> getBody() { return body; }
        public void setBody(Element mbody) { body.Add(mbody); }



    }

#if(TEST_FunctionElement)

    //---------------< test stub >--------------------------------------------
class test{

    [STAThread]
    static void Main()
    {
        FunctionElement func = new FunctionElement();
        func.setreturntype("int");
        string name = func.getreturntype();
        VariableElement funcname = new VariableElement();
        funcname.setText("add");
        func.setfunctionname(funcname);
        Element funcname1;
        funcname1 = (Element)func.getfunctionname();
        DeclarationElement dec = new DeclarationElement();
        dec.settype("double");
        dec.setvariable("a");
        DeclarationElement dec1 = new DeclarationElement();
        dec1.settype("double");
        dec1.setvariable("b");
        func.setArguments(dec);
        func.setArguments(dec1 );
        List<DeclarationElement> declist = new List<DeclarationElement>();
        declist = (DeclarationElement)func.getArguments();
         VariableElement name1 = new VariableElement();
        VariableElement name2 = new VariableElement();
          VariableElement name1 = new VariableElement();
        VariableElement name3 = new VariableElement();
        name1.setText("int a");
        name2.setText(" double b");
        name3.setText("add(a , b)");

        func.setBody(name1);
        func.setBody(name2);
        func.setBody(name3);
        List<Element> body = new List<Element>();
        body = (Element)func.getbody();

        
}        
    }   
#endif