



using System;
using System.Collections.Generic;
using System.Collections;


public class NonEqualityOperationElement : Element
{
    Element mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitNonEqualityOperationElement(this);
    }

    public Element getnonequalityLhs() { return mLhs; }
    public void setnonequalityLhs(Element lhs) { mLhs = lhs; }

    public Element getnonequalityRhs() { return mRhs; }
    public void setnonequalityRhs(Element rhs) { mRhs = rhs; }



}