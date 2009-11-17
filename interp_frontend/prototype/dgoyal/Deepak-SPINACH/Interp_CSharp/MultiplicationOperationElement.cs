////////////////////////////////////////////////////////////////////////
// MulitplicationOperationElement.java: holds the data needed for an multiplication 
//  operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: Java 1.6.0.0
////////////////////////////////////////////////////////////////////////

public class MultiplicationOperationElement : Element
{

    Element mLhs;
    Element mRhs;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMultiplicationOperationElement(this);
    }

    public Element getLhs() { return mLhs; }
    public void setLhs(Element lhs) { mLhs = lhs; }

    public Element getRhs() { return mRhs; }
    public void setRhs(Element rhs) { mRhs = rhs; }
}
