


using System;
using System.Collections.Generic;
using System.Collections;


public class EqualityOperationElement : Element
{
    VariableElement mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitEqualityOperationElement(this);
    }

    public VariableElement getequalityLhs() { return mLhs; }
    public void setequalityLhs(VariableElement lhs) { mLhs = lhs; }

    public Element getequalityRhs() { return mRhs; }
    public void setequalityRhs(Element rhs) { mRhs = rhs; }



}