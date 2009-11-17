////////////////////////////////////////////////////////////////////////
// AssignmentOperationElement.cs: holds the data needed for an 
//  assignment operation.
// 
// version: 1.0
// description: This class will get and set the left hand side and right hand side
//               of the assignment to hold the element
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
/*
 * Module Operations
 * =================
 * This AssignmentOperationElement class will set and get the left hand side and right hand side
 * of the assignment to hold the element.
 * 
 * Public Interface
 * ================
 * public VariableElement getLhs()
 * public void setLhs(Element lhs)
 * public Element getRhs()
 * public void setRhs(Element rhs)
 * public StructAssignDeclaration getStructLhs()
 * public void setStructLhs(StructAssignDeclaration lhs)
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs AssignmentOperationElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_Assignment define: AdditionOperationElement.cs Element.cs
 */

public class AssignmentOperationElement : Element {

  Element mLhs;
  Element mRhs;  

  public override void Accept(Visitor visitor){
    visitor.VisitAssignmentOperationElement(this);
  }
    //get and set the elements on the left hand side of the assignment
  public Element getLhs() { return mLhs; }
  public void setLhs(Element lhs) { mLhs = lhs; }
  //  //get and set the elements of structure on the left hand side of the assignment
  //public StructAssignDeclaration getStructLhs() { return structLhs; }
  //public void setStructLhs(StructAssignDeclaration lhs) { structLhs = lhs; }
    //get and set the elements on the right hand side of the assignment
  public Element getRhs() { return mRhs; }
  public void setRhs(Element rhs) { mRhs = rhs; }

#if(Test_Assignment)

    //-----------<Test Stub>--------
  static void main(string[] args)
  {
      Console.WriteLine("\nTesting the AssignmentOperationElement class");
      Console.WriteLine("\n==========================================\n");
      AssignmentOperationElement elem_assign = new AssignmentOperationElement();
      IntegerElement int_elem = new IntegerElement();
      VariableElement var_elem = new VariableElement();
      string lhsval = "a";
      string rhsval = "3";
      VariableElement lhs = var_elem;
      Element rhs = int_elem;
      int_elem.setText(rhsval);
      var_elem.setText(lhsval);
      elem_assign.setLhs(lhs);
      elem_assign.setRhs(rhs);
      var_elem=elem_assign.getLhs();
      int_elem = (IntegerElement)elem_assign.getRhs();
      Console.WriteLine("{0} The element at Lhs is:", int_elem.getText());
      Console.WriteLine("{0} The element at the rhs is:", var_elem.getText());

  }
#endif
}
