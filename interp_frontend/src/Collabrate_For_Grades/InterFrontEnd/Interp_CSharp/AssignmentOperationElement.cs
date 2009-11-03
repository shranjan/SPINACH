////////////////////////////////////////////////////////////////////////
// AssignmentOperationElement.cs: holds the data needed for an 
//  assignment operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class AssignmentOperationElement : Element {

  Element mLhs;
  //StructAssignDeclaration structLhs;
  Element mRhs;  

  public override void Accept(Visitor visitor){
    visitor.VisitAssignmentOperationElement(this);
  }

  public Element getLhs() { return mLhs; }
  public void setLhs(Element lhs) { mLhs = lhs; }
 // public StructAssignDeclaration getStructLhs() { return structLhs; }
  //public void setStructLhs(StructAssignDeclaration lhs) { structLhs = lhs; }
  public Element getRhs() { return mRhs; }
  public void setRhs(Element rhs) { mRhs = rhs; }
}
