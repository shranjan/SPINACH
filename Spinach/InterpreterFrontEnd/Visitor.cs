////////////////////////////////////////////////////////////////////////
// Visitor.cs: declares all the abstract Visit functions that each
//  visitor must implement.  Also includes the VisitElement function
//  which alows visiting of an Element when its type is not known.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Srinivasan Sundararajan (ssunda04@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public abstract class Visitor {

  public abstract void VisitVariableElement(VariableElement element);
  public abstract void VisitStructDeclaration(StructDeclaration element);
  public abstract void VisitStructObject(StructObjectDeclaration element);
  public abstract void VisitStructAssignment(StructAssignDeclaration element);
  public abstract void VisitMatrixElement(MatrixVariableDeclaration element);
  public abstract void VisitIntegerElement(IntegerElement element);
  public abstract void VisitDoubleElement(DoubleElement element);
  public abstract void VisitAssignmentOperationElement(AssignmentOperationElement element);
  public abstract void VisitAdditionOperationElement(AdditiveElement element);
  public abstract void VisitMultiplicationElement(MultiplicationElement element);
  public abstract void VisitPrintOperationElement(PrintOperationElement element);
  public abstract void VisitParallelForElement(ParallelForElement element);
  public abstract void VisitForStatementElement(ForStatementElement element);
  public abstract void VisitIfStatementElement(IfStatementElement element);
 
  public abstract void VisitFunctionCallElement(FunctionCallElement element);
  public abstract void VisitFunctionElement(FunctionElement element);
 
 
  public abstract void VisitReturnElement(ReturnElement element);
  public abstract void VisitDeleteElement(DeleteVariable element);
  
  public abstract void VisitStructVar(ScalarVariableDeclaration element);
  public abstract void VisitVectorElement(VectorVariableDeclaration element);
  public abstract void VisitPlotFunctionElement(PlotFunctionElement element);
  
  public abstract void VisitSubtractionElement(SubtractionElement element);
  public abstract void VisitDotProductElement(DotProductElement element);
  public abstract void VisitMatrixTransposeElement(MatrixTranspose element);
  public abstract void VisitBracketElement(BracketElement element);
  public abstract void VisitCommentElement(CommentElement element);
  public abstract void VisitStringElement(StringElement element);
  public abstract void VisitVectorSingleElement(VectorElement element);
  public abstract void VisitMatrixSingleElement(MatrixElement element);
  public abstract void VisitMatrixReference(MatrixReference element);
  public abstract void VisitVectorReference(VectorReference element);
  public abstract void VisitScalarArgument(ScalarArgument element);

  public void VisitElement(Element element){
    if(element is IntegerElement){
      IntegerElement int_elem = (IntegerElement) element;
      VisitIntegerElement(int_elem);       
    } else if(element is VariableElement){
      VariableElement var_elem = (VariableElement) element;
      VisitVariableElement(var_elem);
    }
        else if(element is AdditiveElement){
      AdditiveElement add_elem = (AdditiveElement) element;
      VisitAdditionOperationElement(add_elem);
    } else if(element is MultiplicationElement){
        MultiplicationElement mult_elem = (MultiplicationElement)element;
        VisitMultiplicationElement(mult_elem);
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

    else if (element is ReturnElement)
    {
        ReturnElement _elem = (ReturnElement)element;
        VisitReturnElement(_elem);
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
    else if (element is BracketElement)
    {
        BracketElement bracket_elem = (BracketElement)element;
        VisitBracketElement(bracket_elem);
    }

    else if (element is SubtractionElement)
    {
        SubtractionElement sub_elem = (SubtractionElement)element;
        VisitSubtractionElement(sub_elem);
    }
    else if (element is DotProductElement)
    {
        DotProductElement dot_elem = (DotProductElement)element;
        VisitDotProductElement(dot_elem);
    }

    else if (element is MatrixTranspose)
    {
        MatrixTranspose transpose_elem = (MatrixTranspose)element;
        VisitMatrixTransposeElement(transpose_elem);
    }
    else if (element is CommentElement)
    {
        CommentElement _elem = (CommentElement)element;
        VisitCommentElement(_elem);
    }
    else if (element is StringElement)
    {
        StringElement _elem = (StringElement)element;
        VisitStringElement(_elem);
    }
    else if (element is VectorElement)
    {
        VectorElement _elem = (VectorElement)element;
        VisitVectorSingleElement(_elem);
    }
    else if (element is MatrixElement)
    {
        MatrixElement _elem = (MatrixElement)element;
        VisitMatrixSingleElement(_elem);
    }
    else if (element is MatrixReference)
    {
        MatrixReference MatRef_elem = (MatrixReference)element;
        VisitMatrixReference(MatRef_elem);
    }
    else if (element is VectorReference)
    {
        VectorReference VecRef_elem = (VectorReference)element;
        VisitVectorReference(VecRef_elem);
    }
  }

  protected Visitor() { }
}
