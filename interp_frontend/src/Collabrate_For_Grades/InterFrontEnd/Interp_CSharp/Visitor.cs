////////////////////////////////////////////////////////////////////////
// Visitor.cs: declares all the abstract Visit functions that each
//  visitor must implement.  Also includes the VisitElement function
//  which alows visiting of an Element when its type is not known.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public abstract class Visitor {

  public abstract void VisitVariableElement(VariableElement element);
  public abstract void VisitIntegerElement(IntegerElement element);
  public abstract void VisitAssignmentOperationElement(AssignmentOperationElement element);
  public abstract void VisitAdditionOperationElement(AdditionOperationElement element);
  public abstract void VisitPrintOperationElement(PrintOperationElement element);

  public void VisitElement(Element element){
    if(element is IntegerElement){
      IntegerElement int_elem = (IntegerElement) element;
      VisitIntegerElement(int_elem);       
    } else if(element is VariableElement){
      VariableElement var_elem = (VariableElement) element;
      VisitVariableElement(var_elem);
    } else if(element is AdditionOperationElement){
      AdditionOperationElement add_elem = (AdditionOperationElement) element;
      VisitAdditionOperationElement(add_elem);          
    } else if(element is AssignmentOperationElement){
      AssignmentOperationElement assign_elem = (AssignmentOperationElement) element;
      VisitAssignmentOperationElement(assign_elem);      
    }
  }

  protected Visitor() { }
}
