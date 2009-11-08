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
  public abstract void VisitStructDeclaration(StructDeclaration element);
  public abstract void VisitStructObject(StructObjectDeclaration element);
  public abstract void VisitStructVar(ScalarVariableDeclaration element);
  public abstract void VisitStructAssignment(StructAssignDeclaration element);
  public abstract void VisitMatrixOperationElement(MatrixOperationElement element);
  public abstract void VisitMatrixElement(MatrixVariableDeclaration element);
  public abstract void VisitVectorElement(VectorVariableDeclaration element);
  public abstract void VisitDeleteElement(DeleteVariable element);
  public abstract void VisitIntegerElement(IntegerElement element);
  public abstract void VisitDoubleElement(DoubleElement element);
  public abstract void VisitAssignmentOperationElement(AssignmentOperationElement element);
  public abstract void VisitAdditionOperationElement(AdditionOperationElement element);
  public abstract void VisitMultiplicationOperationElement(MultiplicationOperationElement element);
  public abstract void VisitPrintOperationElement(PrintOperationElement element);
  public abstract void VisitParallelForElement(ParallelForElement element);
  public abstract void VisitForStatementElement(ForStatementElement element);
  public abstract void VisitIfStatementElement(IfStatementElement element);
  public abstract void VisitRangeElement(RangeElement element);
  public abstract void VisitFunctionCallElement(FunctionCallElement element);
  public abstract void VisitFunctionElement(FunctionElement element);
  public abstract void VisitDeclarationElement(DeclarationElement element);
  public abstract void VisitEqualityOperationElement(EqualityOperationElement element);
  public abstract void VisitReturnElement(ReturnElement element);
  public abstract void VisitNonEqualityOperationElement(NonEqualityOperationElement element);
  public abstract void VisitPlotFunctionElement(PlotFunctionElement element);
    

  public void VisitElement(Element element){
    if(element is IntegerElement){
      IntegerElement int_elem = (IntegerElement) element;
      VisitIntegerElement(int_elem);       
    } else if(element is VariableElement){
      VariableElement var_elem = (VariableElement) element;
      VisitVariableElement(var_elem);
    } else if(element is MatrixOperationElement){
        MatrixOperationElement matrix_elem = (MatrixOperationElement)element;
        VisitMatrixOperationElement(matrix_elem);
    } else if(element is AdditionOperationElement){
      AdditionOperationElement add_elem = (AdditionOperationElement) element;
      VisitAdditionOperationElement(add_elem);
    } else if(element is MultiplicationOperationElement){
        MultiplicationOperationElement mult_elem = (MultiplicationOperationElement)element;
        VisitMultiplicationOperationElement(mult_elem);
    } else if(element is AssignmentOperationElement){
      AssignmentOperationElement assign_elem = (AssignmentOperationElement) element;
      VisitAssignmentOperationElement(assign_elem);
    }else if (element is ParallelForElement){
        ParallelForElement parallel_elem = (ParallelForElement)element;
        VisitParallelForElement(parallel_elem);
    }else if (element is ForStatementElement){
        ForStatementElement for_elem = (ForStatementElement)element;
        VisitForStatementElement(for_elem);
    }else if (element is IfStatementElement){
        IfStatementElement if_elem = (IfStatementElement)element;
        VisitIfStatementElement(if_elem);
    }else if (element is RangeElement){
        RangeElement range_elem = (RangeElement)element;
        VisitRangeElement(range_elem);
    }
    else if (element is EqualityOperationElement)
    {
        EqualityOperationElement range_elem = (EqualityOperationElement)element;
        VisitEqualityOperationElement(range_elem);
    }
    else if (element is NonEqualityOperationElement)
    {
        NonEqualityOperationElement range_elem = (NonEqualityOperationElement)element;
        VisitNonEqualityOperationElement(range_elem);
    }
    else if (element is StructDeclaration)
    {
        StructDeclaration range_elem = (StructDeclaration)element;
        VisitStructDeclaration(range_elem);
    }
    else if (element is StructAssignDeclaration)
    {
        StructAssignDeclaration range_elem = (StructAssignDeclaration)element;
        VisitStructAssignment(range_elem);
    }
    else if (element is StructObjectDeclaration)
    {
        StructObjectDeclaration range_elem = (StructObjectDeclaration)element;
        VisitStructObject(range_elem);
    }
    else if (element is MatrixVariableDeclaration)
    {
        MatrixVariableDeclaration range_elem = (MatrixVariableDeclaration)element;
        VisitMatrixElement(range_elem);
    }
    else if (element is DeclarationElement)
    {
        DeclarationElement range_elem = (DeclarationElement)element;
        VisitDeclarationElement(range_elem);
    }
    else if (element is ReturnElement)
    {
        ReturnElement range_elem = (ReturnElement)element;
        VisitReturnElement(range_elem);
    }
    else if (element is DeleteVariable)
    {
        DeleteVariable range_elem = (DeleteVariable)element;
        VisitDeleteElement(range_elem);
    }
    else if (element is ScalarVariableDeclaration)
    {
        ScalarVariableDeclaration range_elem = (ScalarVariableDeclaration)element;
        VisitStructVar(range_elem);
    }
    else if (element is VectorVariableDeclaration)
    {
        VectorVariableDeclaration range_elem = (VectorVariableDeclaration)element;
        VisitVectorElement(range_elem);
    }
    else if (element is PrintOperationElement)
    {
        PrintOperationElement range_elem = (PrintOperationElement)element;
        VisitPrintOperationElement(range_elem);
    }
    else if (element is PlotFunctionElement)
    {
        PlotFunctionElement plot_elem = (PlotFunctionElement)element;
        VisitPlotFunctionElement(plot_elem);
    }
    else if (element is DoubleElement)
    {
        DoubleElement double_elem = (DoubleElement)element;
        VisitDoubleElement(double_elem);
    }
  }

  protected Visitor() { }
}
