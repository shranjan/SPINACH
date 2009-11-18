////////////////////////////////////////////////////////////////////////
// IntegerElement.cs: holds the data needed to represent an Integer.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

public class StringElement : Element
{

    String mText;
    List<Element> strlist=new List<Element>();

    public override void Accept(Visitor visitor)
    {
        visitor.VisitStringElement(this);
    }

    public String getText() { return mText; }
    public void setText(Element value) 
    {
        strlist.Add(value);

    }
    public String appendText()
    {
        if (strlist.Count != 0)
        {
            for (int i = 0; i < strlist.Count; i++)
            {
                Element element = strlist[i];
                if (element is VariableElement)
                {
                    VariableElement var_elem = (VariableElement)element;
                    mText += var_elem.getText();
                }
                else if (element is IntegerElement)
                {
                    IntegerElement int_elem = (IntegerElement)element;
                    mText += int_elem.getText();
                }
                else if (element is DoubleElement)
                {
                    DoubleElement double_elem = (DoubleElement)element;
                    mText += double_elem.getText();
                }
            }
        }
        else
            mText = "";
        return mText;
    }
}
