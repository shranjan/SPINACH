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
    public class Core 
    {
        InterpreterVisitor interp_visitor;
        
       // PrintVisitor print_visitor=new PrintVisitor(this);
        public delegate void errorcoremsg(int code, string errormsg);
        public event errorcoremsg errorcore_;

        public delegate void resultcore(string coremsg);
        public event resultcore rescore_;

        private int flag = -1;
 
        public void sendres(int code, string errormsg)
        {
            if (errorcore_ != null)
            {
                errorcore_(code, errormsg);
                flag = 1;
            }

        }

        public void result(string coremsg)
        {
            if (rescore_ != null)
                rescore_(coremsg);
        }
        //List<Element> elements;
        public Core(PlotReceiver r)
        {
           interp_visitor=new InterpreterVisitor();
            interp_visitor.errorcore_ += new InterpreterVisitor.errorcoremsg(sendres);
             interp_visitor.rescore_ += new InterpreterVisitor.resultcore(result);
             interp_visitor.setPlotObj(r);
        }
        public void setAST(List<Element> elements)
        {
            //  element = ele;
            for (int i = 0; i < elements.Count && flag!=1; i++)
            {
                Element curr = elements[i];
               // curr.Accept(print_visitor);
                curr.Accept(interp_visitor);
            }  
        }

        public void clearVarMap()
        {
            interp_visitor.clearMap();

        }


        }

}
