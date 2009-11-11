
////////////////////////////////////////////////////////////////////////
// Core.cs: Implements a vistor that interprets the syntax tree.
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
 * This file provides functionalities which interprets the tree, according to the 
 * elements present in it, i.e. it invokes addition functionality if it encounters
 * a '+' symbol, multiplication functionality if '*' symbol is encontered, etc. 
 * Similarly,it invokes variable, integer, assignment, matrix assignment, print and 
 * for loop functionalities as and when these are encountered. The functionalities 
 * associated with these various operations, will further go into the tree to evaluate 
 * them.
 * 
 * Public Interface
 * ================
 * Core interp_visitor = new Core();  
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
using System.Collections;
using System.Threading;

namespace Spinach
{
    public class InterpreterVisitor : Visitor
    {
        PlotReceiver p;
        public delegate void errorcoremsg(int code, string errormsg);
        public event errorcoremsg errorcore_;

        public delegate void resultcore(string coremsg);
        public event resultcore rescore_;

        public void sendres(int code, string errormsg)
        {
            if (errorcore_ != null)
                errorcore_(code, errormsg);

        }

        public void result(string coremsg)
        {
            if (rescore_ != null)
                rescore_(coremsg);
        }

        public void setPlotObj(PlotReceiver pr)
        {
            p = pr;
        }
 
        Hashtable mVariableMap;
        Stack<int> mStack;
        Stack<Object> mat_stack;
        List<int> mList;
        List<int> rcList;
        
       // PrintVisitor print_visitor=new PrintVisitor(this);
        //List<Element> elements;

  
        public Hashtable getMap()
        {
            return mVariableMap;
        }
        public enum datatypes
        {
            IntElement = 1,
            DoubleElement = 2,
            Matrix = 3,
            Struct = 4,
            MatrixElement = 5,
            Variable = 6,
            Strings = 7,
            Subtraction = 8

        }
        //Error codes: 110-120
        public InterpreterVisitor()
        {
            mVariableMap = new Hashtable();
            mStack = new Stack<int>();
            mList = new List<int>();
            rcList = new List<int>();
            mat_stack = new Stack<Object>();
        }

        public Object getTopOfStack_Matrix()
        {
            Object result = mat_stack.Peek();
            mat_stack.Pop();
            return result;
        }

        public bool map_contains_matrix(string key)
        {
            int flag = 0;
            for (int i = 0; i < mVariableMap.Count; i++)
            {
                if (mVariableMap.ContainsKey(key))
                    flag = 1;
            }
            if (flag == 1)
                return true;
            else
                return false;
        }

        public override void VisitVariableElement(VariableElement element)
        {
            if (map_contains_matrix(element.getText()))
            {
                mat_stack.Push(mVariableMap[element.getText()]);
            }
        }
        public override void VisitStructDeclaration(StructDeclaration element)
        {
            //throw new NotImplementedException();
            //struct s{int a;};
            if (element != null)
            {
                if (mVariableMap.ContainsKey(element.getName()))
                {
                    sendres(112, "Variable declared\n");
                    Console.Write("Variable declared\n");
                }
                else
                    mVariableMap.Add(element.getName(), element);
            }
            else
                Console.Write("Null Structure element\n");
        }
        public override void VisitStructObject(StructObjectDeclaration element)
        {
            //throw new NotImplementedException();
            //s s1;
            if (element != null)
            {
                if (mVariableMap.ContainsKey(element.getStructName().getText()))
                {
                    Object name = mVariableMap[element.getStructName().getText()];
                    if (GetTypeOfElement((Element)(name)) == 4)
                    {
                        StructDeclaration temp = (StructDeclaration)name;
                        if (temp != null)
                        {
                            StructDeclaration obj = new StructDeclaration();
                            List<ScalarVariableDeclaration> l1 = new List<ScalarVariableDeclaration>();
                            l1 = temp.getVarType();
                            for (int i = 0; i < l1.Count; i++)
                                obj.setVarType(l1[i]);
                            obj.setName(element.getObjName());
                            mVariableMap.Add(element.getObjName().getText(), obj);
                        }
                        else
                        {
                            Console.Write("Variable name used\n");
                            sendres(112, "Variable name used\n");
                                               }
                    }
                    else
                    
                        Console.Write("Object not of type struct\n");
                }
            }
            else
                Console.Write("Null struct object\n");
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
            if (element.getvariable() != null)
            {
                VisitElement(element.getvariable());
                Object obj_rhs = getTopOfStack_Matrix();
                //Object result = new Object();
                MatrixVariableDeclaration mat = (MatrixVariableDeclaration)(obj_rhs);
                MatrixVariableDeclaration transpose = new MatrixVariableDeclaration();
                int rhs_type = GetTypeOfElement((Element)obj_rhs);
                if (rhs_type == 3)
                {
                    if (mat.getType() == "int")
                    {
                        int[,] mat_elem = mat.getintValue();

                        int row = int.Parse(((IntegerElement)(mat.getRow())).getText());
                        int col = int.Parse(((IntegerElement)(mat.getColumn())).getText());
                        int[,] trans_elem = new int[col, row];
                        transpose.setRow(mat.getColumn());
                        transpose.setColumn(mat.getRow());
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                                trans_elem[j, i] = mat_elem[i, j];
                        }
                        Console.Write("\n");
                        transpose.setIntMatrix(trans_elem);
                        int[,] trans = transpose.getintValue();
                        int trans_row = int.Parse(((IntegerElement)(transpose.getRow())).getText());
                        int trans_col = int.Parse(((IntegerElement)(transpose.getColumn())).getText());
                        Console.Write("Transpose of the given matrix is : \n\n");
                        //result("Transpose of the matrix\n");

                        for (int i = 0; i < trans_row; i++)
                        {
                            for (int j = 0; j < trans_col; j++)
                            {
                                Console.Write("\t" + trans[i, j]);
                          //      result("\t" + trans[i, j].ToString());
                            }
                            Console.Write("\n");
                            //result("\n");

                        }
                    }
                    else if (mat.getType() == "double")
                    {
                        double[,] mat_elem = mat.getdoubleValue();

                        int row = int.Parse(((IntegerElement)(mat.getRow())).getText());
                        int col = int.Parse(((IntegerElement)(mat.getColumn())).getText());
                        double[,] trans_elem = new double[col, row];
                        transpose.setRow(mat.getColumn());
                        transpose.setColumn(mat.getRow());
                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                                trans_elem[j, i] = mat_elem[i, j];
                        }
                        Console.Write("\n");
                        //result("\n");

                        transpose.setDoubleMatrix(trans_elem);
                        double[,] trans = transpose.getdoubleValue();
                        int trans_row = int.Parse(((IntegerElement)(transpose.getRow())).getText());
                        int trans_col = int.Parse(((IntegerElement)(transpose.getColumn())).getText());
                        //result( "Transpose of the given matrix\n");
                        Console.Write("Transpose of the given matrix is : \n\n");
                        for (int i = 0; i < trans_row; i++)
                        {
                            for (int j = 0; j < trans_col; j++)
                            {
                                Console.Write("\t" + trans[i, j]);
                          //      result( "\t" + trans[i, j].ToString());

                            }
                            Console.Write("\n");
                            //result("\n");
                        }
                    }
                    Object result = (Object)(transpose);
                    mat_stack.Push(result);

                }
            }
            else
            {
                Console.Write("Matrix needs to be decalred first.. try again.. ");
                sendres(112, "Matrix needs to be declared first.. try again..\n");
            }
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
            if (mVariableMap.ContainsKey(element.getVar().getText()))
            {
                mVariableMap.Remove(element.getVar().getText());
            }
            else
            {
                Console.Write("Variable not declared, cannot be deleted\n");
                sendres(112, "Variable not declared, cannot be deleted\n");
            }
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
            mat_stack.Push(element);
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
            mat_stack.Push(element);
        }

        public override void VisitForStatementElement(ForStatementElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitFunctionCallElement(FunctionCallElement element)
        {
            //throw new NotImplementedException();
        }
        /*
        public override void VisitIfStatementElement(IfStatementElement element)
        {
            //throw new NotImplementedException();
        }
        */
        public override void VisitFunctionElement(FunctionElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitMatrixElement(MatrixVariableDeclaration element)
        {
            string variable_name = element.getVar().getText();
            string type = element.getType();
            if (mVariableMap.Count == 0)
                mVariableMap.Add(variable_name, element);
            else
            {
                if (mVariableMap.Contains(variable_name))
                {
                    Console.Write(" \nSemantic Error.. ");
                    sendres(112, "\nSemantic Error...\n");
                    Console.Write("\n The matrix name you entered is already existing.. try again..");
                    sendres(112, "\n The matrix name you entered is already existing.. try again..");
                    return;
                }
                else
                {
                    mVariableMap.Add(variable_name, element);
                }
            }
            int row = int.Parse(element.getRow().getText());
            int col = int.Parse(element.getColumn().getText());
            Console.Write("\n Matrix name : ");
            Console.Write(variable_name);
            Console.Write("\nMatrix Type : ");
            Console.Write(type); Console.Write("\n");
            Console.Write(" Rows : "); Console.Write(row); Console.Write("\n");
            Console.Write(" Columns : "); Console.Write(col);
            string mat_type = element.getType();
            if (mat_type == "int")
            {
                int[,] elements = element.getintValue();
                Console.Write("\nMatrix Elements are : \n");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(elements[i, j]);
                        Console.Write("\t");
                    }
                    Console.Write("\n");
                }
            }
            else if (mat_type == "double")
            {
                double[,] elemenets = element.getdoubleValue();
                Console.Write("\n Matrix Elements are : \n");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(elemenets[i, j]);
                        Console.Write("\t");
                    }
                    Console.Write("\n");
                }
            }
            Console.Write("\n");

            //throw new NotImplementedException();
        }
        public override void VisitMultiplicationElement(MultiplicationElement element)
        {
            if (element.getRhs() == null)
            {
                Element var_name = element.getLhs();
                VisitElement(var_name);
            }
            else
            {
                VisitElement(element.getLhs());
                VisitElement(element.getRhs());

                if (mat_stack.Count >= 2)
                {
                    Object obj_rhs = getTopOfStack_Matrix();
                    Object obj_lhs = getTopOfStack_Matrix();
                    int rhs_type = GetTypeOfElement((Element)obj_rhs);
                    int lhs_type = GetTypeOfElement((Element)obj_lhs);
                    if (rhs_type == 3 && lhs_type == 3) // check whether both are matrices or not
                    {

                        MatrixVariableDeclaration stk_rhs = (MatrixVariableDeclaration)(obj_rhs);
                        MatrixVariableDeclaration stk_lhs = (MatrixVariableDeclaration)(obj_lhs);
                        MatrixVariableDeclaration final = new MatrixVariableDeclaration();
                        //Object output = new Object();
                        if (stk_lhs.getType() == stk_rhs.getType())
                        {
                            IntegerElement lRow = (IntegerElement)(stk_lhs.getRow());
                            IntegerElement lCol = (IntegerElement)(stk_lhs.getColumn());
                            IntegerElement rRow = (IntegerElement)(stk_rhs.getRow());
                            IntegerElement rCol = (IntegerElement)(stk_rhs.getColumn());
                            int lhs_row = int.Parse(((IntegerElement)(stk_lhs.getRow())).getText());
                            int lhs_col = int.Parse(((IntegerElement)(stk_lhs.getColumn())).getText());
                            int rhs_row = int.Parse(((IntegerElement)(stk_rhs.getRow())).getText());
                            int rhs_col = int.Parse(((IntegerElement)(stk_rhs.getColumn())).getText());
                            if (lhs_col == rhs_row)
                            {
                                final.setRow(lRow);
                                final.setColumn(rCol);
                                final.setType(stk_lhs.getType());
                                Console.Write("Multiplication..\n");
                                string mat_type = stk_lhs.getType();
                                if (mat_type == "int")
                                {
                                    int[,] lhs_elem = stk_lhs.getintValue();
                                    int[,] rhs_elem = stk_rhs.getintValue();
                                    int[,] result = new int[lhs_row, rhs_col];
                                    for (int i = 0; i < lhs_row; i++)
                                    {
                                        for (int j = 0; j < rhs_col; j++)
                                        {
                                            for (int k = 0; k < lhs_col; k++)
                                            {
                                                int res = lhs_elem[i, k] * rhs_elem[k, j];
                                                result[i, j] = result[i, j] + res;
                                            }
                                        }
                                    }
                                    bool mat_set = final.setIntMatrix(result);
                                    int[,] output = final.getintValue();
                                    int row = int.Parse(((IntegerElement)(final.getRow())).getText());
                                    int col = int.Parse(((IntegerElement)(final.getColumn())).getText());
                                    for (int i = 0; i < row; i++)
                                    {
                                        for (int j = 0; j < col; j++)
                                        {
                                            Console.Write("\t" + output[i, j]);
                                        }
                                        Console.Write("\n");
                                    }
                                    Object final_output = (Object)(final);
                                    mat_stack.Push(final_output);
                                }
                                else if (mat_type == "double")
                                {
                                    double[,] lhs_elem = stk_lhs.getdoubleValue();
                                    double[,] rhs_elem = stk_rhs.getdoubleValue();
                                    double[,] result = new double[lhs_row, rhs_col];
                                    for (int i = 0; i < lhs_row; i++)
                                    {
                                        for (int j = 0; j < rhs_col; j++)
                                        {
                                            for (int k = 0; k < lhs_col; k++)
                                            {
                                                double res = lhs_elem[i, k] * rhs_elem[k, j];
                                                result[i, j] = result[i, j] + res;
                                            }
                                        }
                                    }
                                    bool mat_set = final.setDoubleMatrix(result);
                                    double[,] output = final.getdoubleValue();
                                    int row = int.Parse(((IntegerElement)(final.getRow())).getText());
                                    int col = int.Parse(((IntegerElement)(final.getColumn())).getText());
                                    for (int i = 0; i < row; i++)
                                    {
                                        for (int j = 0; j < col; j++)
                                        {
                                            Console.Write("\t" + output[i, j]);
                                        }
                                        Console.Write("\n");
                                    }
                                    Object final_output = (Object)(final);
                                    mat_stack.Push(final_output);
                                }

                            }
                            else
                            {
                                Console.Write("Matrix dimensions does not match for multiplication.. try again.. \n");
                                sendres(112, "Matrix dimensions does not match for multiplication.. try again.. \n");
                            }
                        }
                        else
                        {
                            Console.Write("Matrix types are different.. try again.. ");
                            sendres(112, "Matrix types are different.. try again..\n");
                        }
                    }
                    else if (lhs_type == (int)datatypes.DoubleElement && rhs_type == (int)datatypes.DoubleElement)
                        PerformDoubleMultiplication(obj_rhs, obj_lhs);
                    else if (lhs_type == (int)datatypes.IntElement && rhs_type == (int)datatypes.IntElement)
                        PerformIntMultiplication(obj_rhs, obj_lhs);
                    else
                    {
                        Console.Write("Scalar and Matrix cannot be multiplied.. \n");
                        sendres(112, "Scalar and Matrix cannot be multiplied.. ..\n");
                    }
                }

            }
            //throw new NotImplementedException();
        }

        private void PerformIntMultiplication(Object obj_rhs, Object obj_lhs)
        {
            IntegerElement stk_rhs = (IntegerElement)(obj_rhs);
            IntegerElement stk_lhs = (IntegerElement)(obj_lhs);
            IntegerElement final = new IntegerElement();
            if (stk_lhs != null && stk_rhs != null)
            {
                int temp_lhs = int.Parse(stk_lhs.getText());
                int temp_rhs = int.Parse(stk_rhs.getText());
                final.setText((temp_lhs * temp_rhs).ToString());
                Object result = (Object)(final);
                mat_stack.Push(result);
                Console.Write("Product: " + final.getText());
            }
        }

        private void PerformDoubleMultiplication(Object obj_rhs, Object obj_lhs)
        {
            DoubleElement stk_rhs = (DoubleElement)(obj_rhs);
            DoubleElement stk_lhs = (DoubleElement)(obj_lhs);
            DoubleElement final = new DoubleElement();
            if (stk_lhs != null && stk_rhs != null)
            {
                double temp_lhs = double.Parse(stk_lhs.getText());
                double temp_rhs = double.Parse(stk_rhs.getText());
                final.setText((temp_lhs * temp_rhs).ToString());
                Object result = (Object)(final);
                mat_stack.Push(result);
                Console.Write("Product: " + final.getText());
            }
        }

        public override void VisitParallelForElement(ParallelForElement element)
        {
            //throw new NotImplementedException();
        }

        private Plot convert_Ele_to_plot(PlotFunctionElement p)
        {
            Plot p1 = new Plot();
            p1.Command = p.getPlotFunction();
            p1.PaneNum = p.getPeno().getText() == null ? 0 : int.Parse(p.getPeno().getText());
            if (mVariableMap.ContainsKey(p.getData().getText()))
            {
                double[,] temp = ((MatrixVariableDeclaration)(mVariableMap[p.getData().getText()])).getdoubleValue();
                p1.Data = p.getData().getText() == null ? null :temp;
            }
            p1.Mode = p.getMode().getText() == null ? 0 : int.Parse(p.getMode().getText());
            p1.Dimensions = p.getPlotType() == null ? 0 : p.getPlotType() == "2D" ? 2 : 3;
            p1.PlotTitle = p.getTitle().getText() == null ? "" : p.getTitle().getText();
            p1.X_Fact = p.getXFact().getText() == null ? 1.0 : double.Parse(p.getXFact().getText());
            p1.Y_Fact = p.getYFact().getText() == null ? 1.0 : double.Parse(p.getYFact().getText());
            p1.Z_Fact = p.getZFact().getText() == null ? 1.0 : double.Parse(p.getZFact().getText());
            p1.X_Axis_Title = p.getXTitle().getText() == null ? "" : p.getXTitle().getText();
            p1.Y_Axis_Title = p.getYTitle().getText() == null ? "" : p.getYTitle().getText();
            p1.Z_Axis_Title = p.getZTitle().getText() == null ? "" : p.getZTitle().getText();
            p1.ScaleMode = p.getScaleMode() == null ? 1 : (p.getScaleMode() == "linear") ? 1 : 2;
            return (p1);
        }
        public override void VisitPlotFunctionElement(PlotFunctionElement element)
        {
            if (mVariableMap.ContainsKey(element.getData().getText()))
            {
             //   double[,] temp = ((MatrixVariableDeclaration)(mVariableMap[element.getData().getText()])).getdoubleValue();
                if (element.getPlotFunction() == "subPlot")
                {
                    int pane = int.Parse(element.getPeno().getText()); //.getPane().getText());
                    string plotType = element.getPlotType();

                    if (pane >= 4 || pane <= 0)
                    {
                        Console.Write("pane no. is not valid.. it lies between 1 to 4.. Try again..");
                        sendres(112, "pane no. is not valid.. it lies between 1 to 4.. Try again..");
                        return;
                    }
                    else if (plotType == "2D" || plotType == "1D")
                    {
                        if ((IntegerElement)(element.getMode()) != null)
                        {
                            Console.Write("Invalid argumenet.. Mode is not required.. Try again.. ");
                            sendres(112, "Invalid argumenet.. Mode is not required.... Try again..");
                            return;
                        }
                    }
                    else if (plotType == "3D")
                    {
                        int mode = int.Parse(((IntegerElement)(element.getMode())).getText());
                        if (mode > 3 || mode <= 0)
                        {
                            Console.Write("Invalid mode.. Give the input between 1..3 ");
                            sendres(112, "Invalid mode.. Give the input between 1..3 ");
                            return;
                        }
                    }
                }
                else if (element.getPlotFunction() == "plot")
                {
                    string plotType = element.getPlotType();
                    string data = element.getData().getText();
                    if (plotType == "1D" || plotType == "2D")
                    {
                        if ((IntegerElement)(element.getMode()) != null)
                        {
                            Console.Write("Invalid argumenet.. Mode is not required.. Try again.. ");
                            sendres(112, "Invalid argumenet.. Mode is not required.. Try again.. ");
                            return;
                        }
                    }
                    else if (plotType == "3D")
                    {
                        int mode = int.Parse(((IntegerElement)(element.getMode())).getText());
                        if (mode >= 3 || mode <= 0)
                        {
                            Console.Write("Invalid mode.. Give the input between 1..3 ");
                            sendres(112, "Invalid mode.. Give the input between 1..3 ");
                            return;
                        }

                    }
                }
                else if (element.getPlotFunction() == "setScaleMode")
                {
                    string scaleMode = element.getScaleMode();
                    if (scaleMode != "log" || scaleMode != "linear")
                    {
                        Console.Write("Invalid scale mode.. it should be either 'linear' or 'log'");
                        sendres(112, "Invalid scale mode.. it should be either 'linear' or 'log'");
                        return;
                    }

                    Plot pr = new Plot();
                    pr = convert_Ele_to_plot(element);
                    p.writetolist(pr);
                }
                else
                {
                    Console.Write("Plot data not declared.. Try again..");
                    sendres(112, "Plot data not declared.. Try again..");
                    return;
                }

            }
        }

        public override void VisitReturnElement(ReturnElement element)
        {
            //throw new NotImplementedException();
        }
        public override void VisitStructVar(ScalarVariableDeclaration element)
        {
            //throw new NotImplementedException();
            string int_name = (element.getVar()).getText();
            if (mVariableMap.Count == 0)
                mVariableMap.Add(int_name, element);
            else
            {
                if (map_contains_matrix(int_name))
                {
                    Console.Write("Semantic Error Int Already Declared\n");
                    sendres(112, "Semantic Error Int Already Declared\n");
                }
                else
                    mVariableMap.Add(int_name, element);
            }
        }

        public override void VisitSubtractionElement(SubtractionElement element)
        {
            if (element.getRhs() == null)
                VisitElement(element.getLhs());
            else
            {
                VisitElement(element.getLhs());
                VisitElement(element.getRhs());
                if (mat_stack.Count >= 2)
                {
                    Object obj_rhs = getTopOfStack_Matrix();
                    Object obj_lhs = getTopOfStack_Matrix();
                    int rhs_type = GetTypeOfElement((Element)obj_rhs);
                    int lhs_type = GetTypeOfElement((Element)obj_lhs);
                    if (rhs_type == 3 && lhs_type == 3) // check whether both are matrices or not
                    {
                        MatrixVariableDeclaration stk_rhs = (MatrixVariableDeclaration)(obj_rhs);
                        MatrixVariableDeclaration stk_lhs = (MatrixVariableDeclaration)(obj_lhs);
                        MatrixVariableDeclaration final = new MatrixVariableDeclaration();
                        if (stk_lhs != null && stk_rhs != null)
                        {
                            if (stk_lhs.getType() == stk_rhs.getType())
                            {
                                IntegerElement lRow = (IntegerElement)(stk_lhs.getRow());
                                IntegerElement lCol = (IntegerElement)(stk_lhs.getColumn());
                                IntegerElement rRow = (IntegerElement)(stk_rhs.getRow());
                                IntegerElement rCol = (IntegerElement)(stk_rhs.getColumn());
                                int lhs_row = int.Parse(((IntegerElement)(stk_lhs.getRow())).getText());
                                int lhs_col = int.Parse(((IntegerElement)(stk_lhs.getColumn())).getText());
                                int rhs_row = int.Parse(((IntegerElement)(stk_rhs.getRow())).getText());
                                int rhs_col = int.Parse(((IntegerElement)(stk_rhs.getColumn())).getText());
                                if (lhs_row == rhs_row && lhs_col == rhs_col)
                                {
                                    final.setRow(lRow);
                                    final.setColumn(lCol);
                                    final.setType(stk_lhs.getType());
                                    Console.Write("Subtraction..\n");
                                    Console.Write(element.getLhs().GetType());
                                    string mat_type = stk_lhs.getType();
                                    if (mat_type == "int")
                                    {
                                        int[,] rhs_elements = stk_rhs.getintValue();
                                        int[,] lhs_elements = stk_lhs.getintValue();
                                        int[,] output = new int[lhs_row, lhs_col];
                                        for (int i = 0; i < lhs_row; i++)
                                        {
                                            for (int j = 0; j < lhs_col; j++)
                                            {
                                                output[i, j] = lhs_elements[i, j] - rhs_elements[i, j];
                                                Console.Write(output[i, j]);
                                                Console.Write("\t");
                                            }
                                            Console.Write("\n");
                                        }
                                        bool mat_set = final.setIntMatrix(output);
                                    }
                                    else if (mat_type == "double")
                                    {
                                        double[,] rhs_elements = stk_rhs.getdoubleValue();
                                        double[,] lhs_elements = stk_lhs.getdoubleValue();
                                        double[,] output = new double[lhs_row, lhs_col];
                                        for (int i = 0; i < lhs_row; i++)
                                        {
                                            for (int j = 0; j < lhs_col; j++)
                                            {
                                                output[i, j] = lhs_elements[i, j] - rhs_elements[i, j];
                                                Console.Write(output[i, j]);
                                                Console.Write("\t");
                                            }
                                            Console.Write("\n");
                                        }
                                        bool mat_set = final.setDoubleMatrix(output);
                                    }
                                    Object result = (Object)(final);
                                    mat_stack.Push(result);
                                }
                            }
                            else
                            {
                                Console.Write("Matrix dimensions does not match.. try again.. \n");
                                sendres(112, "Matrix dimensions does not match.. try again.. \n");
                            }
                        }
                    }
                    else if (lhs_type == 2 && rhs_type == 2)
                    {
                        //Double
                        PerformDoubleSubtraction(obj_rhs, obj_lhs);

                    }
                    else if (lhs_type == 1 && rhs_type == 1)
                    {
                        //Int
                        PerformIntSubtraction(obj_rhs, obj_lhs);
                    }
                    else
                    {
                        Console.Write("Scalar and matrix subtraction not possible\n");
                        sendres(112, "Scalar and matrix subtraction not possible\n");
                    }
                }
                else
                {
                    Console.Write("Matrix types are different.. try again.. ");
                    sendres(112, "Matrix types are different.. try again.. ");
                }
            }
        }

        private void PerformDoubleSubtraction(Object obj_rhs, Object obj_lhs)
        {
            DoubleElement stk_rhs = (DoubleElement)(obj_rhs);
            DoubleElement stk_lhs = (DoubleElement)(obj_lhs);
            DoubleElement final = new DoubleElement();
            if (stk_lhs != null && stk_rhs != null)
            {
                double temp_lhs = double.Parse(stk_lhs.getText());
                double temp_rhs = double.Parse(stk_rhs.getText());
                final.setText((temp_lhs - temp_rhs).ToString());
                Object result = (Object)(final);
                mat_stack.Push(result);
                Console.Write("Difference: " + final.getText());
            }

        }

        private void PerformIntSubtraction(Object obj_rhs, Object obj_lhs)
        {
            IntegerElement stk_rhs = (IntegerElement)(obj_rhs);
            IntegerElement stk_lhs = (IntegerElement)(obj_lhs);
            IntegerElement final = new IntegerElement();
            if (stk_lhs != null && stk_rhs != null)
            {
                int temp_lhs = int.Parse(stk_lhs.getText());
                int temp_rhs = int.Parse(stk_rhs.getText());
                final.setText((temp_lhs - temp_rhs).ToString());
                Object result = (Object)(final);
                mat_stack.Push(result);
                Console.Write("Difference: " + final.getText());
            }

        }
        public override void VisitVectorElement(VectorVariableDeclaration element)
        {
            //throw new NotImplementedException();
        }

        //public override void VisitMatrixOperationElement(MatrixOperationElement element) { }
        public override void VisitIntegerElement(IntegerElement element)
        {
            mat_stack.Push(element);

        }
        public override void VisitAssignmentOperationElement(AssignmentOperationElement element)
        {
            StructAssignDeclaration temp;
            StructDeclaration structTemp;
            int flag = -1;

            //Handle struct
            if (GetTypeOfElement(element.getLhs()) == 4)
            {
                temp = (StructAssignDeclaration)(element.getLhs());
                if (mVariableMap.ContainsKey(temp.getObjName())) //getName()))
                {
                    structTemp = (StructDeclaration)mVariableMap[temp.getObjName()]; //.getName()];
                    flag = 1;
                }
                Element rhs = element.getRhs();
                VisitElement(rhs);
                if (mat_stack.Count > 0 && flag == 1)
                {
                    Object obj = getTopOfStack_Matrix();
                    temp.setObjName((Element)(obj));  //.setObj((Element)(obj));
                }
            }
            else if (GetTypeOfElement(element.getLhs()) == 5)
            {
                HandleSingleMatrixElement(element);
            }
            else if (mVariableMap.ContainsKey(((VariableElement)(element.getLhs())).getText()))
            {
                string var_name = ((VariableElement)(element.getLhs())).getText();
                Element rhs = element.getRhs();
                VisitElement(rhs);

                if (mat_stack.Count > 0 && flag == -1)
                {
                    Object obj = getTopOfStack_Matrix();
                    if (GetTypeOfElement(element.getLhs()) == GetTypeOfElement(((Element)obj)))
                    {
                        /*if ((GetTypeOfElement(element.getLhs()) == 3))
                        {
                            MatrixVariableDeclaration tempmat = ((MatrixVariableDeclaration)((mVariableMap[((VariableElement)(element.getLhs())).getText()])));
                            if (tempmat.getType() == (((MatrixVariableDeclaration)(((Element)obj))).getType()))
                            {
                                if (tempmat.getRow() == (((MatrixVariableDeclaration)(((Element)obj))).getRow()) && tempmat.getColumn() == (((MatrixVariableDeclaration)(((Element)obj))).getColumn()))
                                {
                                    mVariableMap.Remove(var_name);
                                    mVariableMap.Add(var_name, obj);
                                }
                                else
                                    Console.Write("Rows and columns of matrices do not match\n");
                            }
                            else
                                Console.Write("Matrices are of different types\n");
                        }
                        else
                        {*/
                        mVariableMap.Remove(var_name);
                        mVariableMap.Add(var_name, obj);
                        //}
                    }
                    else
                    {
                        Console.Write("Datatypes mismatch\n");
                        sendres(112, "Datatypes mismatch\n");
                    }
                }
                else
                {
                    Console.Write("Variable not found");
                    sendres(112, "Variable not found");
                }
            }
            else
            {
                Console.Write("Variable not declared");
                sendres(112, "Variable not declared");
            }
        }

        //Set the single matrix element
        public void HandleSingleMatrixElement(AssignmentOperationElement element)
        {            
            MatrixElement temp = (MatrixElement)(element.getLhs());
            MatrixVariableDeclaration matTemp = null;
            int row = int.Parse(((IntegerElement)(temp.getRow())).getText());
            int col = int.Parse(((IntegerElement)(temp.getColumn())).getText());
            int mflag = -1;
            if (mVariableMap.ContainsKey(temp.getVar().getText()))
            {
                matTemp = (MatrixVariableDeclaration)mVariableMap[temp.getVar().getText()];
                mflag = 1;//Matrix entry found
            }
            else
            {
                Console.Write("Matrix not declared yet\n");
                sendres(112, "Matrix not declared yet\n");
            }
            Element rhs = element.getRhs();
            VisitElement(rhs);
            if (matTemp != null)
            {
                if (mat_stack.Count > 0 && mflag == 1 && matTemp.getType() == "int")
                {
                    Object obj = getTopOfStack_Matrix();
                    int val = int.Parse(((IntegerElement)(obj)).getText());
                    if (row < int.Parse(matTemp.getRow().getText()) && col < int.Parse(matTemp.getColumn().getText()))
                        matTemp.setintValueat(row, col, val);
                    else
                    {
                        Console.Write("Range out of bound\n");
                        sendres(112, "Range out of bound\n");
                    }
                }
                else if (mat_stack.Count > 0 && mflag == 1 && matTemp.getType() == "double")
                {
                    Object obj = getTopOfStack_Matrix();
                    double val = double.Parse(((DoubleElement)(obj)).getText());
                    matTemp.setdoubleValueat(row, col, val);
                }
            }
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
                if (mVariableMap.ContainsKey(((VariableElement)(elem)).getText()))
                {
                    int a = GetTypeOfElement(((Element)(mVariableMap[((VariableElement)(elem)).getText()])));
                    return a;
                }
                else
                    return 0;
            }
            /*else if (elem is SubtractionElement)
            {
                return (int)datatypes.Subtraction;
            }*/
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
        public override void VisitAdditionOperationElement(AdditiveElement element)
        {
            if (element.getRhs() == null)
            {
                VisitElement(element.getLhs());
            }
            else
            {
                VisitElement(element.getLhs());
                VisitElement(element.getRhs());
                if (mat_stack.Count >= 2)
                {
                    Object obj_rhs = getTopOfStack_Matrix();
                    Object obj_lhs = getTopOfStack_Matrix();
                    int rhs_type = GetTypeOfElement((Element)obj_rhs);
                    int lhs_type = GetTypeOfElement((Element)obj_lhs);
                    if (rhs_type == 3 && lhs_type == 3)
                    {
                        MatrixVariableDeclaration stk_rhs = (MatrixVariableDeclaration)(obj_rhs);
                        MatrixVariableDeclaration stk_lhs = (MatrixVariableDeclaration)(obj_lhs);
                        MatrixVariableDeclaration final = new MatrixVariableDeclaration();
                        if (stk_lhs != null && stk_rhs != null)
                        {
                            if (stk_lhs.getType() == stk_rhs.getType())
                            {
                                IntegerElement lRow = (IntegerElement)(stk_lhs.getRow());
                                IntegerElement lCol = (IntegerElement)(stk_lhs.getColumn());
                                IntegerElement rRow = (IntegerElement)(stk_rhs.getRow());
                                IntegerElement rCol = (IntegerElement)(stk_rhs.getColumn());

                                int lhs_row = int.Parse(((IntegerElement)(stk_lhs.getRow())).getText());
                                int lhs_col = int.Parse(((IntegerElement)(stk_lhs.getColumn())).getText());
                                int rhs_row = int.Parse(((IntegerElement)(stk_rhs.getRow())).getText());
                                int rhs_col = int.Parse(((IntegerElement)(stk_rhs.getColumn())).getText());
                                if (lhs_row == rhs_row && lhs_col == rhs_col)
                                {
                                    final.setRow(lRow);
                                    final.setColumn(lCol);
                                    final.setType(stk_lhs.getType());

                                    Console.Write("Addition..\n");
                                    Console.Write(element.getLhs().GetType());
                                    string mat_type = stk_lhs.getType();
                                    if (mat_type == "int")
                                    {
                                        int[,] rhs_elements = stk_rhs.getintValue();
                                        int[,] lhs_elements = stk_lhs.getintValue();
                                        int[,] output = new int[lhs_row, lhs_col];
                                        for (int i = 0; i < lhs_row; i++)
                                        {
                                            for (int j = 0; j < lhs_col; j++)
                                            {
                                                output[i, j] = lhs_elements[i, j] + rhs_elements[i, j];
                                                Console.Write(output[i, j]);
                                                Console.Write("\t");
                                            }
                                            Console.Write("\n");
                                        }
                                        bool mat_set = final.setIntMatrix(output);
                                    }
                                    else if (mat_type == "double")
                                    {
                                        double[,] rhs_elements = stk_rhs.getdoubleValue();
                                        double[,] lhs_elements = stk_lhs.getdoubleValue();
                                        // int[,] result = new int[lhs_row, lhs_col];
                                        double[,] output = new double[lhs_row, lhs_col];
                                        for (int i = 0; i < lhs_row; i++)
                                        {
                                            for (int j = 0; j < lhs_col; j++)
                                            {
                                                output[i, j] = lhs_elements[i, j] + rhs_elements[i, j];
                                                Console.Write(output[i, j]);
                                                Console.Write("\t");
                                            }
                                            Console.Write("\n");
                                        }
                                        bool mat_set = final.setDoubleMatrix(output);
                                    }
                                    Object result = (Object)(final);
                                    mat_stack.Push(result);
                                }
                                // addition
                            }
                            else
                            {
                                Console.Write("Matrix dimensions does not match.. try again.. \n");
                            }
                        }
                    }
                    else if (lhs_type == 2 && rhs_type == 2)
                    {
                        //Double
                        PerformDoubleAddition(obj_rhs, obj_lhs);

                    }
                    else if (lhs_type == 1 && rhs_type == 1)
                    {
                        //Int
                        PerformIntAddition(obj_rhs, obj_lhs);
                    }
                    else
                    {
                        Console.Write("Scalar and matrix addition not possible\n");
                        sendres(112, "Scalar and matrix addition not possible\n");
                    }
                }
                else
                {
                    Console.Write("Matrix types are different.. try again.. ");
                    sendres(112, "Matrix types are different.. try again.. ");
                }
            }
        }

        private void PerformIntAddition(Object obj_rhs, Object obj_lhs)
        {
            IntegerElement stk_rhs = (IntegerElement)(obj_rhs);
            IntegerElement stk_lhs = (IntegerElement)(obj_lhs);
            IntegerElement final = new IntegerElement();
            if (stk_lhs != null && stk_rhs != null)
            {
                int temp_lhs = int.Parse(stk_lhs.getText());
                int temp_rhs = int.Parse(stk_rhs.getText());
                final.setText((temp_lhs + temp_rhs).ToString());
                Object result = (Object)(final);
                mat_stack.Push(result);
                Console.Write("Sum: " + final.getText());
            }
        }

        private void PerformDoubleAddition(Object obj_rhs, Object obj_lhs)
        {
            DoubleElement stk_rhs = (DoubleElement)(obj_rhs);
            DoubleElement stk_lhs = (DoubleElement)(obj_lhs);
            DoubleElement final = new DoubleElement();
            if (stk_lhs != null && stk_rhs != null)
            {
                double temp_lhs = double.Parse(stk_lhs.getText());
                double temp_rhs = double.Parse(stk_rhs.getText());
                final.setText((temp_lhs + temp_rhs).ToString());
                Object result = (Object)(final);
                mat_stack.Push(result);
                Console.Write("Sum: " + final.getText());
            }
        }

        public override void VisitPrintOperationElement(PrintOperationElement element)
        {
            Console.Write("Printing..\n");
            VisitElement(element.getChildElement());
            if (mVariableMap.ContainsKey(((VariableElement)(element.getChildElement())).getText()))
            {
                if (mat_stack.Count > 0)
                {
                    Object obj = getTopOfStack_Matrix();
                    int a = GetTypeOfElement((Element)obj);
                    if (a == 1)
                        result("Int Value:" + ((IntegerElement)element.getChildElement()).getText());
                    else if (a == 2)
                        result("Double Value:" + ((DoubleElement)element.getChildElement()).getText());
                    else if (a == 3)
                    {
                        MatrixVariableDeclaration elem = (MatrixVariableDeclaration)(element.getChildElement());
                        string type = elem.getType();
                        int row = int.Parse(elem.getRow().getText());
                        int col = int.Parse(elem.getColumn().getText());
                        Console.Write("\nMatrix Type : ");
                        Console.Write(type); Console.Write("\n");
                        Console.Write(" Rows : "); Console.Write(row); Console.Write("\n");
                        Console.Write(" Columns : "); Console.Write(col);
                        result("\nMatrix Type : " + type + "\n" + "Rows:" + row.ToString() + "\n" + "Columns:" + col.ToString());
                        string mat_type = elem.getType();
                        if (mat_type == "int")
                        {
                            int[,] elements = elem.getintValue();
                            Console.Write("\nMatrix Elements are : \n");
                            result("\nMatrix Elements are : \n");
                            for (int i = 0; i < row; i++)
                            {
                                for (int j = 0; j < col; j++)
                                {
                                    Console.Write(elements[i, j]);
                                    Console.Write("\t");
                                    result(elements[i, j].ToString() + "\t");
                                }
                                Console.Write("\n");
                                result("\n");
                            }
                        }
                        else if (mat_type == "double")
                        {
                            double[,] elemenets = elem.getdoubleValue();
                            Console.Write("\n Matrix Elements are : \n");
                            result("\nMatrix Elements are : \n");
                            for (int i = 0; i < row; i++)
                            {
                                for (int j = 0; j < col; j++)
                                {
                                    Console.Write(elemenets[i, j]);
                                    result(elemenets[i, j].ToString());
                                    Console.Write("\t");
                                    result("\t");
                                }
                                Console.Write("\n");
                                result("\n");
                            }
                        }
                        Console.Write("\n");
                        result("\n");

                    }
                    else if (a == 7)
                    {
                        result("String Value:" + ((StringElement)(element.getChildElement())).getText());
                    }

                }
            }
            else sendres(112, "Variable not declared\n");
        }

        public String getIfElement(Element element)
        {
            if (element is IntegerElement)
            {
                IntegerElement int_elem = (IntegerElement)element;
                return int_elem.getText();
            }
            else if (element is VariableElement)
            {
                VariableElement var_elem = (VariableElement)element;
                return var_elem.getText();
            }
            else if (element is DoubleElement)
            {
                DoubleElement double_elem = (DoubleElement)element;
                return double_elem.getText();
            }
            else
                return null;
            /*else if (element is StructAssignDeclaration)
            {
                StructAssignDeclaration range_elem = (StructAssignDeclaration)element;
                return range_elem.;
            }*/
        }


        public override void VisitIfStatementElement(IfStatementElement element)
        {
            String lhs = getIfElement(element.getLhs()); //.getConditionLhs());
            String rhs = getIfElement(element.getRhs()); //.getConditionRhs());

            if (lhs == null || rhs == null)
            { Console.WriteLine("\n Variable not allowed. "); return; }

            if (mVariableMap.ContainsKey(lhs) == false || mVariableMap.ContainsKey(rhs) == false)
                Console.WriteLine("\n Invalid Comparison.");

            if (
                 (element.OP == "eq" && String.Compare(lhs, rhs) == 0) ||
                 (element.OP == "ne" && String.Compare(lhs, rhs) != 0) ||
                 (element.OP == "lt" && String.Compare(lhs, rhs) < 0) ||
                 (element.OP == "le" && String.Compare(lhs, rhs) <= 0) ||
                 (element.OP == "gt" && String.Compare(lhs, rhs) < 0) ||
                 (element.OP == "ge" && String.Compare(lhs, rhs) >= 0)
               )
            {
                Console.WriteLine("\n Loop condition true - entered true. ");
            }
            else
            {
                if (element.ELSECODE.Count != 0)
                { Console.WriteLine("\n Loop condition false - entered else. "); }
            }

            //throw new NotImplementedException();
        }

    }
}
