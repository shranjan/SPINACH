using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



   public class FunctionElement: Element
    {
        
        String returntype;
        Element functionname;
        List<Element> body = new List<Element>();
        List<DeclarationElement> Arguments = new List<DeclarationElement>();

        public override void Accept(Visitor visitor)
        {
            visitor.VisitFunctionElement(this);
        }

        public String getreturntype() { return returntype; }
        public void setreturntype(String mreturntype) { returntype = mreturntype; }

        public Element getfunctionname() { return functionname; }
        public void setfunctionname(Element mfunctionname) { functionname= mfunctionname; }

        public List<DeclarationElement> getArguments() { return Arguments; }
        public void setArguments(DeclarationElement decElem) { Arguments.Add(decElem); }

        public List<Element> getBody() { return body; }
        public void setBody(Element mbody) { body.Add(mbody); }



    }

