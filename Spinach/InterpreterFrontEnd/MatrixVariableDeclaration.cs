////////////////////////////////////////////////////////////////////////
// MatrixVariableDeclaration.cs: holds the data needed to represent matrix 
//  in the Interp language.
// 
// version: 1.0
// 
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
/*
 * Module Operations
 * =================
 * This MatrixVariableDeclaration class implementing the functions to hold the data
 * needed to represent the matrix.
 * 
 * Public Interface
 * ================
 * public VariableElement getVar()
 *  public void setVar(VariableElement var)
 *  public IntegerElement getRow()
 *  public void setRow(IntegerElement row) 
 *  public IntegerElement getColumn()
 *  public void setColumn(IntegerElement column)
 *  public String getType() 
 *  public void setType(String type)
 *  public int[,] getintValue() 
 *  public double[,] getdoubleValue()
 *  public void addValue(Element val)
 *  public void setValue()
 *  public void setintValueat(int r, int c,int value)
 *  public int getintValueat(int r, int c)
 *  public void setdoubleValueat(int r, int c, double value)
 *  public double getdoubleValueat(int r, int c)
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs IntegerElement.cs VariableElement.cs MatrixVariableDeclaration.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_Matrix define: MatrixVariableDeclaration.cs VariableElement.cs IntegerElement.cs Element.cs
 */


using System;
using System.Collections.Generic;

public class MatrixVariableDeclaration : Element
{

    VariableElement mVar;
    IntegerElement Row;
    IntegerElement Column;
    List<Element> mValue=new List<Element>();
    int[,] intMatrix;
    double[,] doubleMatrix;
    String mType;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixElement(this);
    }

    public VariableElement getVar() { return mVar; }
    public void setVar(VariableElement val) { mVar = val; }
    public String getType() { return mType; }
    public void setType(String type) { mType = type; }
    public IntegerElement getRow() { return Row; }
    public void setRow(IntegerElement r) { Row = r; }
    public IntegerElement getColumn() { return Column; }
    public void setColumn(IntegerElement c) { Column = c; }
    public int[,] getintValue() { return intMatrix; }
    public double[,] getdoubleValue() { return doubleMatrix; }
    public void addValue(Element val)
    {
        mValue.Add(val);
    }
    public void setValue()
    {
        try
        {
            int row = int.Parse(getRow().getText());
            int column = int.Parse(getColumn().getText());
            if (getType() == "int")
            {
                List<int> list = new List<int>();
                for (int i = 0; i < mValue.Count; i++)
                {
                    IntegerElement int_element = (IntegerElement)mValue[i];
                    int element = int.Parse(int_element.getText());
                    list.Add(element);
                }
                //mValue.Add(int.Parse(val.getText()));
                intMatrix = new int[row, column];
                int count = 0;
                if ((row * column) == list.Count)
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            intMatrix[i, j] = list[count];
                            count++;
                        }
                    }
                }
            }
            else if (getType() == "double")
            {
                List<double> list = new List<double>();
                for (int i = 0; i < mValue.Count; i++)
                {
                    DoubleElement double_element = (DoubleElement)mValue[i];
                    double element = double.Parse(double_element.getText());
                    list.Add(element);
                }
                //mValue.Add(int.Parse(val.getText()));
                doubleMatrix = new double[row, column];
                int count = 0;
                if ((row * column) == list.Count)
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            doubleMatrix[i, j] = list[count];
                            count++;
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            string s = e.Message;
        }
    }
    public void setintValueat(int r, int c,int value)
    {
        intMatrix.SetValue(value, r, c);    
    }
    public int getintValueat(int r, int c)
    {
        int val=(int)intMatrix.GetValue(r, c);
        return val;
    }
    public void setdoubleValueat(int r, int c, double value)
    {
        doubleMatrix.SetValue(value, r, c);
    }
    public double getdoubleValueat(int r, int c)
    {
        double val = (double)intMatrix.GetValue(r, c);
        return val;
    }
    public bool setIntMatrix(int[,] matrix)
    {
        try
        {
            int row = int.Parse(getRow().getText());
            int column = int.Parse(getColumn().getText());
            intMatrix = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < column; k++)
                {
                    intMatrix[i, k] = matrix[i, k];
                }
            }
            return true;
        }
        catch (Exception e)
        {
            string s = e.Message;
            return false;
        }
    }
    public bool setDoubleMatrix(double[,] matrix)
    {
        try
        {
            int row = int.Parse(getRow().getText());
            int column = int.Parse(getColumn().getText());
            doubleMatrix = new double[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < column; k++)
                {
                    doubleMatrix[i, k] = matrix[i, k];
                }
            }
            return true;
        }
        catch (Exception e)
        {
            string s = e.Message;
            return false;
        }
    }

#if(Test_Matrix)

    //-----------<Test Stub>--------
  static void main(string[] args)
  {
      Console.WriteLine("\nTesting the MatrixVariableDeclaration class");
      Console.WriteLine("\n===========================================\n");
      MatrixVariableDeclaration elem_mat = new MatrixVariableDeclaration();
      VariableElement elem_var = new VariableElement();
      IntegerElement elem_int = new IntegerElement();
      //List<Element> elementlist = new List<Element>();
      string var = "matrix";
      string row = "3";
      string column = "2";
      elem_var.setText(var);
      elem_mat.setVar(elem_var);
      elem_int.setText(row);
      elem_mat.setRow(elem_int);
      elem_int.setText(column);
      elem_mat.setColumn(elem_int);
      for (int i = 0; i < (int.Parse(row) * int.Parse(column)); i++)
      {
          elem_int.setText(i.ToString());
          elem_mat.addValue(elem_int);
      }
      string type = "int";
      elem_mat.setType(type);
      elem_mat.setValue();
      int[,] matrix = new int[int.Parse(row), int.Parse(column)];
      matrix = elem_mat.getintValue();
      Console.WriteLine("The name of the Matrix is:{0}", elem_mat.getVar().getText());
      Console.WriteLine("The Row and Column of the Matrix is:{0},{1}", elem_mat.getRow().getText(), elem_mat.getColumn().getText());
      Console.WriteLine("The type of matrix is:{0}", elem_mat.getType());
      for(int i=0;i<int.Parse(row);i++)
      {
          for (int j = 0; j < int.Parse(column); j++)
          {
              Console.WriteLine("The value of matrix is:{0}", matrix[i, j]);
          }
      }
      
  }
#endif
}