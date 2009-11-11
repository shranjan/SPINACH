////////////////////////////////////////////////////////////////////////
// PrintVisitor.cs: demonstrates printing the syntax tree in a
//  difference source language than the input for the Interp language.
// 
// version: 1.0
// Description: part of the interpreter example for the visitor design
//  pattern.
// Language:    C++/CLI, Visual Studio 2008 .Net Framework 3.5             
// Platform:    Dell Inspiron 1525, Windows Vista Business, SP 1       
// Application: Pr#2, CSE 784, Spring 2009                              
// Authors:     Rajika Tandon (ratandon@syr.edu)
//              Sushma Thimmappa (skyasara@syr.edu)
//              Rucha Bapat (rmbapat@syr.edu)            
// Source:      Phil Pratt-Szeliga (pcpratts@syr.edu)
////////////////////////////////////////////////////////////////////////
/*
 * Module Operations
 * ================= 
 * This file provides functions to print the various functions (addition, multiplication,
 * matrices, for-loop) as well as variables/integers involved in the input.
 *
 * 
 * Public Interface
 * ================
 * PrintVisitor print_visitor = new PrintVisitor();  
 *                       // will create an instance of this class and allocate memory
 * 
 */
/*
 * Build Process
 * =============
 * Required Files:
 *   Front End Dlls
 * 
 * Maintenance History
 * ===================
 * ver 1.0 : 10 Nov 09
 *   - first release
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spinach
{
    public class PrintVisitor : Visitor
    {
        private Core interp;
        public PrintVisitor(Core interp)
        {
            this.interp = interp;
        }
        public enum datatypes
        {
            IntElement = 1,
            DoubleElement = 2,
            Matrix = 3,
            Struct = 4,
            MatrixElement = 5,
            Variable = 6,
            Strings = 7

        }
        private int GetTypeOfElement(Element elem)
        {
            if (elem is IntegerElement)
            {
                return (int)datatypes.IntElement;
            }
            else if (elem is DoubleElement)
            {
                return (int)datatypes.DoubleElement;
            }
            else if (elem is MatrixVariableDeclaration)
            {
                return (int)datatypes.Matrix;
            }
            else if (elem is StructAssignDeclaration)
            {
                return (int)datatypes.Struct;
            }
            else if (elem is MatrixElement)
            {
                return (int)datatypes.MatrixElement;
            }
            else if (elem is VariableElement)
            {
                if (interp.getMap().ContainsKey(((VariableElement)(elem)).getText()))
                {
                    int a = GetTypeOfElement(((Element)(interp.getMap()[((VariableElement)(elem)).getText()])));
                    return a;
                }
                else
                    return 0;
            }
            else if (elem is StringElement)
            {
                return (int)datatypes.Strings;
            }
            else if (elem is ScalarVariableDeclaration)
            {
                if (((ScalarVariableDeclaration)(elem)).getType() == "int")
                    return (int)datatypes.IntElement;
                else if (((ScalarVariableDeclaration)(elem)).getType() == "double")
                    return (int)datatypes.DoubleElement;
                else
                    return 0;
            }
            else
                return 0;
        }

        public override void VisitVariableElement(VariableElement element)
        {
            Console.Write("Value:");
            int a = 0;
            if (interp.getMap().ContainsKey(element.getText()))
                a = GetTypeOfElement((Element)(element));
            try
            {
                if (a == 1)
                    VisitIntegerElement((IntegerElement)(interp.getMap()[element.getText()]));
                else if (a == 2)
                    VisitDoubleElement((DoubleElement)(interp.getMap()[element.getText()]));
                else if (a == 3)
                    VisitMatrixElement((MatrixVariableDeclaration)(interp.getMap()[element.getText()]));
                else if (a == 4)
                    VisitStructObject((StructObjectDeclaration)(interp.getMap()[element.getText()]));
                else if (a == 7)
                    VisitStringElement((StringElement)(interp.getMap()[element.getText()]));
            }
            catch (Exception e)
            {
                e = new Exception();
                String s = e.Message;
            }
        }

        public override void VisitStructDeclaration(StructDeclaration element)
        {
            //throw new NotImplementedException();
            //struct s{int a;};
        }
        public override void VisitStructObject(StructObjectDeclaration element)
        {
            if (element != null)
            {
                Console.Write("Structure:" + element.getStructName().getText());
                Console.Write("Element:" + element.getObjName().getText());
                interp.sendres(114, "Structure:" + element.getStructName().getText());
                interp.sendres(114, "Element:" + element.getObjName().getText());
            }
            else
                Console.Write("Null Structure element\n");

        }
        public override void VisitStructAssignment(StructAssignDeclaration element)
        {
            //throw new NotImplementedException();
            //s1.a=10;
            if (element != null)
            {
                //
            }
        }
        public override void VisitDotProductElement(DotProductElement element)
        {
        }
        public override void VisitMatrixTransposeElement(MatrixTranspose element)
        {
        }

        
        public override void VisitBracketElement(BracketElement element)
        {
            //throw new NotImplementedException();
        }
        /*public override void VisitDeclarationElement(DeclarationElement element)
        {
            //throw new NotImplementedException();
        }*/

        //Delete  from symbol table
        public override void VisitDeleteElement(DeleteVariable element)
        {

        }

        public override void VisitCommentElement(CommentElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitMatrixReference(MatrixReference element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitMatrixSingleElement(MatrixElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitScalarArgument(ScalarArgument element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitStringElement(StringElement element)
        {
            //throw new NotImplementedException();
            Console.Write("String Value:" + element.getText());
            interp.sendres(114, "String Value:" + element.getText());
        }
        public override void VisitVectorReference(VectorReference element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitVectorSingleElement(VectorElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitDoubleElement(DoubleElement element)
        {
            if (element != null)
            {
                Console.Write("Double Value:" + element.getText());
                interp.sendres(114, "Double Value:" + element.getText());
            }
        }
        
        public override void VisitForStatementElement(ForStatementElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitFunctionCallElement(FunctionCallElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitIfStatementElement(IfStatementElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitFunctionElement(FunctionElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitMatrixElement(MatrixVariableDeclaration element)
        {
            //string variable_name = element.getVar().getText();
            string type = element.getType();
            int row = int.Parse(element.getRow().getText());
            int col = int.Parse(element.getColumn().getText());
            Console.Write("\nMatrix Type : ");
            Console.Write(type); Console.Write("\n");
            Console.Write(" Rows : "); Console.Write(row); Console.Write("\n");
            Console.Write(" Columns : "); Console.Write(col);
            interp.sendres(114,"\nMatrix Type : " + type + "\n" + "Rows:" + row.ToString() + "\n" + "Columns:" + col.ToString());
            string mat_type = element.getType();
            if (mat_type == "int")
            {
                int[,] elements = element.getintValue();
                Console.Write("\nMatrix Elements are : \n");
                interp.sendres(114, "\nMatrix Elements are : \n");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(elements[i, j]);
                        Console.Write("\t");
                        interp.sendres(114, elements[i,j].ToString() + "\t");
                    }
                    Console.Write("\n");
                    interp.sendres(114, "\n");
                }
            }
            else if (mat_type == "double")
            {
                double[,] elemenets = element.getdoubleValue();
                Console.Write("\n Matrix Elements are : \n");
                interp.sendres(114, "\nMatrix Elements are : \n");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(elemenets[i, j]);
                        interp.sendres(114, elemenets[i,j].ToString());
                        Console.Write("\t");
                        interp.sendres(114, "\t");
                    }
                    Console.Write("\n");
                    interp.sendres(114, "\n");
                }
            }
            Console.Write("\n");
            interp.sendres(114, "\n");

            //throw new NotImplementedException();
        }
        public override void VisitMultiplicationElement(MultiplicationElement element)
        {
        }
        
        public override void VisitParallelForElement(ParallelForElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitPlotFunctionElement(PlotFunctionElement element)
        {
        }
        
        public override void VisitReturnElement(ReturnElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitStructVar(ScalarVariableDeclaration element)
        {

        }

        public override void VisitSubtractionElement(SubtractionElement element)
        {
        }

        public override void VisitVectorElement(VectorVariableDeclaration element)
        {
            //throw new NotImplementedException();
        }

        //public override void VisitMatrixOperationElement(MatrixOperationElement element) { }
        public override void VisitIntegerElement(IntegerElement element)
        {
            Console.Write("Int Value:" + element.getText());
            interp.sendres(114, "Int Value:" + element.getText());
        }
        public override void VisitAssignmentOperationElement(AssignmentOperationElement element)
        {
        }


        public override void VisitAdditionOperationElement(AdditiveElement element)
        {
        }


        public override void VisitPrintOperationElement(PrintOperationElement element)
        {
            Console.Write("Printing..\n");
            VisitElement(element.getChildElement());
        }
    }

}
