////////////////////////////////////////////////////////////////////////
// BracketElement.cs: holds the data needed for an 
//  bracket operation.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: vinit mehta
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
//#define TEST_Bracket
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class BracketElement :Element
    {
        Element bracketexpression;

        public override void Accept(Visitor visitor)
        {
            visitor.VisitBracketElement(this);
        }

        public Element getbracketexpression() { return bracketexpression; }
        public void setbracketexpression(Element mbracketexpression) { bracketexpression = mbracketexpression; }


    }

#if(TEST_Bracket)

    //---------------< test stub >--------------------------------------------
class test
{
    [STAThread]
    static void Main()
    {
        BracketElement brac = new BracketElement();
        VariableElement a =  new VariableElement();
        VariableElement b = new VariableElement();
        VariableElement c = new VariableElement();
        a.setText("subtraction expression");
        
        
        brac.setbracketexpression(a);
        Element e;
        e = (Element)brac.getbracketexpression();
      }       
        
 }   
#endif

