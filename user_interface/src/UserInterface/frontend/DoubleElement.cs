////////////////////////////////////////////////////////////////////////
// DoubleElement.cs: holds the data needed to represent double variables 
//  in the Interp language.
// 
// version: 1.0
// 
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
/*
 * Module Operations
 * =================
 * This DoubleElement class holds the data needed to represent double
 * variables in the interp language.
 * 
 * Public Interface
 * ================
 * public String getText() 
 * public void setText(String value)
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs DoubleElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_Double define: DoubleElement.cs Element.cs
 */


using System;

public class DoubleElement : Element
{

    String mText;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitDoubleElement(this);
    }
    //get and set the values 
    public String getText() { return mText; }
    public void setText(String value) { mText = value; }

#if(Test_Double)

    //-----------<Test Stub>--------
  static void main(string[] args)
  {
      Console.WriteLine("\nTesting the DoubleElement class");
      Console.WriteLine("\n================================\n");
      DoubleElement elem_double = new DoubleElement();
      string value = "3.21";
      elem_double.setText(value);
      Console.WriteLine("{0} The element of this class is:", elem_double.getText());

  }
#endif
}
