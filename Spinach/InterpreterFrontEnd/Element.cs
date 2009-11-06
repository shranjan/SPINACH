////////////////////////////////////////////////////////////////////////
// Element.cs: declares the Accept function that takes a visitor 
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
/*
 * Module Operations
 * =================
 * This Element class is the abstract class which declares the Accept function
 * that takes a visitor class object.
 * 
 * Public Interface
 * ================
 * public abstract void Accept(Visitor visitor)
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs 
 * 
 * Compiler Command:
 *   csc /target:exe / define: Element.cs
 */


public abstract class Element {

  public abstract void Accept(Visitor visitor);
}
