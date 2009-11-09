////////////////////////////////////////////////////////////////////////
// DeclarationOperationElement.cs: holds the data needed for an 
//  function operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta (vnmehta@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
//#define TEST_Declaration

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class DeclarationElement:Element
    {
        String type;

        Element variable;
        public override void Accept(Visitor visitor)
        {
            visitor.VisitDeclarationElement(this);
        }

        public String gettype() { return type; }
        public void settype(String mtype) { type = mtype; }

        public Element getvariable() { return variable; }
        public void setvariable(Element mvariable) { variable = mvariable; }

    }

#if(TEST_Declaration)

    //---------------< test stub >--------------------------------------------

    class test
{
    static void Main()
    {
        DeclarationElement dec = new DeclarationElement();
        string mtext;
        mtext = "double";

        VariableElement name = new VariableElement();
        name.setText("a");
        dec.settype(mtext);
        dec.setvariable(name);
        string d;
        Element e;
        d= dec.gettype();
        e = (Element)dec.getvariable();
    }  
} 
#endif