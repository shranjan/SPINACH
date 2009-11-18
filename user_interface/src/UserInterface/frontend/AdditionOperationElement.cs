////////////////////////////////////////////////////////////////////////
// AdditionOperationElement.java: holds the data needed for an addition 
//  operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: Java 1.6.0.0
////////////////////////////////////////////////////////////////////////

public class AdditionOperationElement : Element {

  Element mLhs;
  Element mRhs;  

  public override void Accept(Visitor visitor){
    visitor.VisitAdditionOperationElement(this);
  }

  public Element getLhs() { return mLhs; }
  public void setLhs(Element lhs) { mLhs = lhs; }

  public Element getRhs() { return mRhs; }
  public void setRhs(Element rhs) { mRhs = rhs; }
}
