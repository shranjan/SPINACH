////////////////////////////////////////////////////////////////////////
// VariableElement.cs: holds the data needed to represent variables 
//  in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;

public class MatrixOperationElement : Element
{

    IntegerElement mValue;
    IntegerElement Row;
    IntegerElement Column;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitMatrixElement(this);
    }

    public IntegerElement getValue() { return mValue; }
    public void setValue(IntegerElement val) { mValue = val; }
    public IntegerElement getRow() { return Row; }
    public void setRow(IntegerElement r) { Row = r; }
    public IntegerElement getColumn() { return Column; }
    public void setColumn(IntegerElement c) { Column = c; }

}