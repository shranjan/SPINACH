////////////////////////////////////////////////////////////////////////
// IfStatementElement.cs: Implements a vistor that interprets the 
//  If statement.
// 
// version: 1.0
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
/*
 * Module Operations
 * =================
 * This IfStatementElement class will set and get the Condition and the code
 * inside the if and else loop.
 * 
 * Public Interface
 * ================
 *  public Element CONDITION;
 *  public List<Element> IFCODE
 *  public List<Element> ELSECODE
 * 
 */
//
/*
 * Build Process
 * =============
 * Required Files:
 *   Element.cs IfStatementElement.cs
 * 
 * Compiler Command:
 *   csc /target:exe /Test_IF define: IfStatementElement.cs Element.cs
 */

//#define TEST_IF
using System;
using System.Collections.Generic;
using System.Collections;

public class IfStatementElement : Element
{
    //if condition element
    Element Condition;

    //List that contains If body
    List<Element> IfCode;

    //List that contains else Body
    List<Element> ElseCode;

    //Return Element
    ReturnElement returnElem;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitIfStatementElement(this);
    }

    //sets and gets the condition for if else.
    public Element CONDITION
    {
        get
        {
            return Condition;
        }
        set
        {
            Condition = value;
        }
    }

    //Sets and gets the if body.
    public List<Element> IFCODE
    {
        get
        {
            return IfCode;
        }
        set
        {
            IfCode = value;
        }
    }

    //Sets and gets the else body.
    public List<Element> ELSECODE
    {
        get
        {
            return ElseCode;
        }
        set
        {
            ElseCode = value;
        }
    }

    //Sets and gets the Return Element
    public ReturnElement IFSTATEMENTRETURN
    {
        get
        {
            return returnElem;
        }
        set
        {
            returnElem = value;
        }
    }

}



//TEST STUB
#if TEST_IF
class Test
{
        static void Main(String[] args)
    {
        Console.WriteLine("\nTesting the IfStatementElement class");
        Console.WriteLine("\n==========================================\n");
        EqualityOperationElement elem = new EqualityOperationElement();
        VariableElement var_elem = new VariableElement();
        var_elem.setText("a");
        elem.setequalityLhs(var_elem);
        IntegerElement int_elem = new IntegerElement();
        int_elem.setText("1");
        elem.setequalityRhs(int_elem);
        VariableElement elem2 = new VariableElement();
        elem2.setText("b");
        IfStatementElement if_elem = new IfStatementElement();
        if_elem.CONDITION= elem;
        ScalarVariableDeclaration scalar_elem = new ScalarVariableDeclaration();
        scalar_elem.setType("int");
        scalar_elem.setVar(var_elem);
        List<Element> Iflist = new List<Element>();
        Iflist.Add(scalar_elem);
        if_elem.IFCODE = Iflist;
        List<Element> ElseList = new List<Element>();
        ElseList.Add(int_elem);
        if_elem.ELSECODE = ElseList;
        ReturnElement elem_ret = new ReturnElement();
        VariableElement var_elem2 = new VariableElement();
        var_elem.setText("a");
        elem_ret.setreturnvariable(var_elem2);
        VariableElement var_elem1 = new VariableElement();
        var_elem1 = (VariableElement)elem_ret.getreturnvariable();
        Console.Write("IfStatement element " + var_elem1.GetType().ToString()+" "+ var_elem1.getText().ToString() + "\n");
        EqualityOperationElement eq_elem = new EqualityOperationElement();
        eq_elem = (EqualityOperationElement)if_elem.CONDITION;
        Console.Write("The condition has : "+eq_elem.ToString()+"->"+eq_elem.getequalityLhs()+" == "+eq_elem.getequalityRhs()+"\n");
        List<Element> elem_list = new List<Element>();
        elem_list = if_elem.IFCODE;
        for (int i = 0; i < elem_list.Count; i++)
        {
            Console.Write("The if loop list has " + elem_list[i].ToString() + "\n");
        }
        elem_list = if_elem.ELSECODE;
        for (int i = 0; i < elem_list.Count; i++)
        {
            Console.Write("The Else loop list has " + elem_list[i].ToString() + "\n");
        }
    }
}
#endif
