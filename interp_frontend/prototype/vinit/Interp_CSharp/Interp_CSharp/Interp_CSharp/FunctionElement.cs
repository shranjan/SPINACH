////////////////////////////////////////////////////////////////////////
// declerationelement.cs: declares the Accept function that takes a visitor 
// 
// version: 1.0
// description: part of the SPINACH code for function defination

// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



   public class FunctionElement: Element
    {
        
        Element returntype;
        VariableElement functionname;
        List<Element> body;
        List<DeclarationElement> parameters;

        public override void Accept(Visitor visitor)
        {
            visitor.VisitFunctionElement(this);
        }

        public Element getreturntype() { return returntype; }
        public void setreturntype(Element mreturntype) { returntype = mreturntype; }

        public VariableElement getfunctionname() { return functionname; }
        public void setfunctionname(VariableElement mfunctionname) { functionname = mfunctionname; }

        public List<DeclarationElement> getParameter() { return body; }
        public void setParameter(DeclarationElement decElem) { parameters.Add(decElem); }

        public List<Element> getBody() { return body; }
        public void setBody(Element mbody) { body.Add(mbody); }



    }

