using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ScalarArgument : Element
{

    string type;
    Element variable;
    public override void Accept(Visitor visitor)
    {
        visitor.VisitScalarArgument(this);
    }

    public String gettype() { return type; }
    public void settype(String mtype) { type = mtype; }

    public Element getvariable() { return variable; }
    public void setvariable(Element mvariable) { variable = mvariable; }

}