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

