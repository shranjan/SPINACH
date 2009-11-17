////////////////////////////////////////////////////////////////////////
// Element.cs: declares the Accept function that takes a visitor 
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public abstract class Element {

  public abstract void Accept(Visitor visitor);
}
