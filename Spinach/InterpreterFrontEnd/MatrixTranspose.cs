////////////////////////////////////////////////////////////////////////
// MatrixTranspose.cs: holds the data needed for an 
//  MatrixTranspose operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author:vinit mehta
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////



//#define TEST_MatrixTranspose
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//#define MatrixTranspose

 public class MatrixTranspose: Element
    {

        VariableElement variable;

        public override void Accept(Visitor visitor)
        {
            visitor.VisitMatrixTransposeElement(this);
        }

        public VariableElement getvariable() { return variable; }
        public void setvariable(VariableElement mvariableelement) { variable = mvariableelement; }


    }

#if(TEST_MatrixTranspose)
class test
{
    //---------------< test stub >--------------------------------------------

    
    static void Main()
    {
         MatrixTranspose tran = new  MatrixTranspose();
         VariableElement variable = new VariableElement();
         variable.setText("a");
            tran.setvariable(variable);
            VariableElement tr;
            tr = tran.getvariable();
        
    }  
} 
#endif