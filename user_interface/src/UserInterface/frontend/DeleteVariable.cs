////////////////////////////////////////////////////////////////////////
// DeleteVariable.cs: holds the data needed to represent deletion of variables 
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
 * This DeleteVariable class holds the data for the deletion of variables.
 * 
 * Public Interface
 * ================
 * public VariableElement getVar()
 * public void setVar(VariableElement val)
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs DeleteVariable.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_Delete define: DeleteVariable.cs Element.cs
 */

using System;

public class DeleteVariable : Element
{

    VariableElement mVar;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitDeleteElement(this);
    }
    // get and set the variable elements
    public VariableElement getVar() { return mVar; }
    public void setVar(VariableElement val) { mVar = val; }

#if(Test_Delete)

    //-----------<Test Stub>--------
  static void main(string[] args)
  {
      Console.WriteLine("\nTesting the DeleteVariable class");
      Console.WriteLine("\n================================\n");
      DeleteVariable elem_del = new DeleteVariable();
      VariableElement var_elem = new VariableElement();
      string value = "a";
      var_elem.setText(value);
      elem_del.setVar(var_elem);
      VariableElement element = elem_del.getVar();
      Console.WriteLine("{0} The expression of class is: delete", element.getText());

  }
#endif
}