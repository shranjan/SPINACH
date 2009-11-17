///////////////////////////////////////////////////////////////////////
// MatrixElement.cs: holds the data needed to represent an Single Matrix Element.
// 
// version: 1.0
//
// author: Deepak GOyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
/*
 * Module Operations
 * =================
 * This MatrixElement class implementing the functions to hold the single
 * element of the matrix.
 * 
 * Public Interface
 * ================
 * public VariableElement getVar()
 *  public void setVar(VariableElement var)
 *  public IntegerElement getRow()
 *  public void setRow(IntegerElement row) 
 *  public IntegerElement getColumn()
 *  public void setColumn(IntegerElement column)
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs IntegerElement.cs VariableElement.cs MatrixElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_MatrixElement define: MatrixElement.cs VariableElement.cs IntegerElement.cs Element.cs
 */


using System;

public class MatrixElement : Element
{

    VariableElement mVar;
    Element mRow;
    Element mColumn;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixSingleElement(this);
    }

    //get and set the variable name of the matrix
    public VariableElement getVar() { return mVar; }
    public void setVar(VariableElement var) { mVar = var; }
    //get and set the row of the matrix
    public Element getRow() { return mRow; }
    public void setRow(Element row) { mRow = row; }
    //get and set the column of the matrix
    public Element getColumn() { return mColumn; }
    public void setColumn(Element column) { mColumn = column; }

#if(Test_MatrixElement)

    //-----------<Test Stub>--------
  static void main(string[] args)
  {
      Console.WriteLine("\nTesting the MatrixElement class");
      Console.WriteLine("\n================================\n");
      MatrixElement elem_mat = new MatrixElement();
      VariableElement elem_var = new VariableElement();
      IntegerElement elem_int = new IntegerElement();
      string var = "matrix";
      string row = "3";
      string column = "4";
      elem_var.setText(var);
      elem_mat.setVar(elem_var);
      elem_int.setText(row);
      elem_mat.setRow(elem_int);
      elem_int.setText(column);
      elem_mat.setColumn(elem_int);
      VariableElement varelement = elem_mat.getVar();
      IntegerElement rowelement = elem_mat.getRow();
      IntegerElement columnelement = elem_mat.getColumn();
      Console.WriteLine("The Matrix element is:{0},[{1}],[{2}]", varelement.getText(),rowelement.getText(),columnelement.getText());
  }
#endif
}
