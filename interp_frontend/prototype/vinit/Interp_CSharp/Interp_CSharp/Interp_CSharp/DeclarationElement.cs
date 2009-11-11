////////////////////////////////////////////////////////////////////////
// declerationelement.cs: declares the Accept function that takes a visitor 
// 
// version: 1.0
// description: part of the SPINACH code for accepting various function arguments

// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class DeclarationElement
    {
        Element type;

        Element variable;
        public override void Accept(Visitor visitor)
        {
            visitor.VisitDeclerationElement(this);
        }

        public Element gettype() { return type; }
        public void settype(Element mtype) { type = mtype; }

        public Element getvariable() { return variable; }
        public void setvariable(Element mvariable) { variable = mvariable; }

    }

