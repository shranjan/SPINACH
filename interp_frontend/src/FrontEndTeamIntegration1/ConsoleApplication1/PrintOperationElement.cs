////////////////////////////////////////////////////////////////////////
// PrintOperationElement.cs: hold the data needed to implement the
//  'print' function in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////

public class PrintOperationElement : Element {

  Element mChildElement;

  public Element getChildElement() { return mChildElement; }
  public void setChildElement(Element value) { mChildElement = value; }

  public override void Accept(Visitor visitor){
    visitor.VisitPrintOperationElement(this);
  }
}
