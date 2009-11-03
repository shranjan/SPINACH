using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PlotFunctionElement : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitPlotFunctionElement(this);
    }

    private string functionName;
    public void setPlotFunction(string name)
    {
        functionName = name;
    }
    public string getPlotFunction()
    {
        return functionName;
    }

    private Element row;
    private Element col;

    public void setRow(Element a)
    { row = a; }
    public Element getRow()
    { return row; }

    public void setColumn(Element a)
    { col = a; }
    public Element getColumn()
    { return col; }

    private Element varData;
    public void setData(Element var)
    { varData = var; }
    public Element getData()
    { return varData; }

    private Element mode;
    public void setMode(Element m)
    { mode = m; }
    public Element getMode()
    { return mode; }

    private IntegerElement type;
    public void setPlotType(IntegerElement t)
    { type = t; }
    public IntegerElement getPlotType()
    { return type; }

    private Element title;
    public void setTitle(Element t)
    { title = t; }
    public Element getTitle()
    { return title; }

    private Element xFact;
    public void setXFact(Element m)
    { xFact = m; }
    public Element getXFact()
    { return xFact; }

    private Element yFact;
    public void setYFact(Element m)
    { yFact = m; }
    public Element getYFact()
    { return yFact; }

    private Element zFact;
    public void setZFact(Element m)
    { zFact = m; }
    public Element getZFact()
    { return zFact; }

    private Element xTitle;
    public void setXTitle(Element m)
    { xTitle = m; }
    public Element getXTitle()
    { return xTitle; }

    private Element yTitle;
    public void setYTitle(Element m)
    { yTitle = m; }
    public Element getYTitle()
    { return yTitle; }

    private Element zTitle;
    public void setZTitle(Element m)
    { zTitle = m; }
    public Element getZTitle()
    { return zTitle; }


    private string scaleMode;
    public void setScaleMode(string s)
    { scaleMode = s; }
    public string getScaleMode()
    { return scaleMode; }
}