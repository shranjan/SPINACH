



using System;
using System.Collections.Generic;
using System.Collections;


public class NonEqualityOperationElement : Element
{
    VariableElement mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitNonEqualityOperationElement(this);
    }

    public VariableElement getnonequalityLhs() { return mLhs; }
    public void setnonequalityLhs(VariableElement lhs) { mLhs = lhs; }

    public Element getnonequalityRhs() { return mRhs; }
    public void setnonequalityRhs(Element rhs) { mRhs = rhs; }



}