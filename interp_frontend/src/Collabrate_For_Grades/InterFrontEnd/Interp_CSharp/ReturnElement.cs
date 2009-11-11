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

