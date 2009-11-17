////////////////////////////////////////////////////////////////////////
// MatrixVariableDeclaration.cs: holds the data needed to represent matrix 
//  in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
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

}