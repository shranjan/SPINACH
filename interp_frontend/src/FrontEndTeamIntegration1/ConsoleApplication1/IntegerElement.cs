///////////////////////////////////////////////////////////////////////
// IntegerElement.cs: holds the data needed to represent an Integer.
// 
// version: 1.0
//
// author: Deepak GOyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
/*
 * Module Operations
 * =================
 * This IntegerElement class holds the data which is needed to represent
 * an integer.
 * 
 * Public Interface
 * ================
 * public String getText()
 *  public void setText(String value)
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs IntegerElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_Integer define: IntegerElement.cs Element.cs
 */
   
using System;

public class IntegerElement : Element {

  String mText;  

  public override void Accept(Visitor visitor){
    visitor.VisitIntegerElement(this);
  }
    // get and set the integer value as string
  public String getText() { return mText; }
  public void setText(String value) { mText = value; }

#if(Test_Integer)

    //-----------<Test Stub>--------
  static void main(string[] args)
  {
      Console.WriteLine("\nTesting the IntegerElement class");
      Console.WriteLine("\n================================\n");
      IntegerElement int_elem = new IntegerElement();
      string val = "3";
      int_elem.setText(val);
      Console.WriteLine("{0} The Integer element is:", int_elem.getText());
  }
#endif
}
