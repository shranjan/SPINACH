////////////////////////////////////////////////////////////////////////
// VectorVariableDeclaration.cs: holds the data needed to represent matrix 
//  in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

public class VectorVariableDeclaration : Element
{

    VariableElement mText;
    IntegerElement mRange;
    String mType;
    List<Element> mValue=new List<Element>();
    List<int> intlist;
    List<double> doublelist;
    bool errorflag;
    //IntegerElement Column;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitVectorElement(this);
    }

    public VariableElement getText() { return mText; }
    public void setText(VariableElement val) { mText = val; }
    public String getType() { return mType; }
    public void setType(String type) { mType = type; } 
    public IntegerElement getRange() { return mRange; }
    public void setRange(IntegerElement val) { mRange = val; }
    //public IntegerElement getColumn() { return Column; }
    //public void setColumn(IntegerElement c) { Column = c; }
    public List<int> getintValue() { return intlist; }
    public List<double> getdoubleValue() { return doublelist; }
    public void addValue(Element val)
    {
        mValue.Add(val);
    }
    public List<Element> getList()
    {
        return mValue;
    }
    public void setValue()
    {
        try
        {
            errorflag = false;
            if (getType() == "int")
            {
                intlist = new List<int>();
                if (mValue.Count != 0)
                {
                    if (int.Parse(getRange().getText()) == mValue.Count)
                    {
                        for (int i = 0; i < mValue.Count; i++)
                        {
                            if (mValue[i] is IntegerElement)
                            {
                                IntegerElement int_element = (IntegerElement)mValue[i];
                                int element = int.Parse(int_element.getText());
                                intlist.Add(element);
                            }
                            else
                            {
                                errorflag = true;
                                intlist.Clear();
                                break;
                            }

                        }
                    }
                }
            }
            else if (getType() == "double")
            {
                doublelist = new List<double>();
                if (mValue.Count != 0)
                {
                    if (int.Parse(getRange().getText()) == mValue.Count)
                    {
                        for (int i = 0; i < mValue.Count; i++)
                        {
                            if (mValue[i] is DoubleElement)
                            {
                                DoubleElement int_element = (DoubleElement)mValue[i];
                                double element = double.Parse(int_element.getText());
                                doublelist.Add(element);
                            }
                            else
                            {
                                errorflag = true;
                                doublelist.Clear();
                                break;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            string s = e.Message;
            errorflag = true;
        }
    }
    public void setintValueat(int loc, int value)
    {
        intlist[loc]=value;
    }
    public int getintValueat(int loc)
    {
        
        return intlist[loc];
    }
    public void setdoubleValueat(int loc,double value)
    {
        doublelist[loc] = value;
    }
    public double getdoubleValueat(int loc)
    {
        return doublelist[loc];
    }
    public bool setIntVector(List<int> vector)
    {
        try
        {
            int range = int.Parse(getRange().getText());
            intlist = new List<int>();
            for (int i = 0; i < range; i++)
            {
                intlist.Add(vector[i]);
            }
            return true;
        }
        catch (Exception e)
        {
            string s = e.Message;
            return false;
        }
    }
    public bool setDoubleVector(List<double> vector)
    {
        try
        {
            int range = int.Parse(getRange().getText());
            doublelist = new List<double>();
            for (int i = 0; i < range; i++)
            {
                doublelist.Add(vector[i]);
            }
            return true;
        }
        catch (Exception e)
        {
            string s = e.Message;
            return false;
        }
    }
}