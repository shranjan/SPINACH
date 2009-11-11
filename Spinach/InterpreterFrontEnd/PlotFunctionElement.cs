///////////////////////////////////////////////////////////////////////
// PlotFuctionElemetn.cs: holds plot function element properties.
// version: 1.0
// description: Interpreter Front End team Plot functions class, for plot syntax.
// author: Kuldeep Gandhi (kpgandhi@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
// Version:
// Versino 1.2 : Made changes for subPlot function: kg



/********************************************************************
 * Public Interface:
    public override void Accept(Visitor visitor)

    public void setPlotFunction(string name)
    public string getPlotFunction()

    public void setRow(IntegerElement a)
    public IntegerElement getRow()
    
    public void setData(VariableElement var)
    public VariableElement getData()
   
    public void setMode(IntegerElement m)
    public IntegerElement getMode()
   
    public void setPlotType(string t)
    public string getPlotType()
     
    public void setTitle(StringElement t)
    public StringElement getTitle()
    
    public void setXFact(DoubleElement m)
    public DoubleElement getXFact()
  
    public void setYFact(DoubleElement m)
    public DoubleElement getYFact()
       
    public void setZFact(DoubleElement m)
    public DoubleElement getZFact()
       
    public void setXTitle(StringElement m)
    public StringElement getXTitle()
  
    public void setYTitle(StringElement m)
    public String getYTitle()
    
    public void setZTitle(StringElement m)
    public StringElement getZTitle()
   
    public void setScaleMode(string s)
    public string getScaleMode()
    
 * ********************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PlotFunctionElement : Element
{


    private string functionName;
    private IntegerElement row;
    
    private VariableElement varData;
    private IntegerElement mode;
    private string type;
    private StringElement title;
    private DoubleElement xFact;
    private DoubleElement yFact;
    private DoubleElement zFact;
    private StringElement xTitle;
    private StringElement yTitle;
    private StringElement zTitle;
    private string scaleMode;


    public override void Accept(Visitor visitor)
    {
        visitor.VisitPlotFunctionElement(this);
    }

    public void setPlotFunction(string name)
    {
        functionName = name;
    }
    public string getPlotFunction()
    {
        return functionName;
    }



    public void setPeno(IntegerElement a)
    { row = a; }
    public IntegerElement getPeno()
    { return row; }

   


    public void setData(VariableElement var)
    { varData = var; }
    public VariableElement getData()
    { return varData; }


    public void setMode(IntegerElement m)
    { mode = m; }
    public IntegerElement getMode()
    { return mode; }


    public void setPlotType(string t)
    { type = t; }
    public string getPlotType()
    { return type; }


    public void setTitle(StringElement t)
    { title = t; }
    public StringElement getTitle()
    { return title; }


    public void setXFact(DoubleElement m)
    { xFact = m; }
    public DoubleElement getXFact()
    { return xFact; }


    public void setYFact(DoubleElement m)
    { yFact = m; }
    public DoubleElement getYFact()
    { return yFact; }


    public void setZFact(DoubleElement m)
    { zFact = m; }
    public DoubleElement getZFact()
    { return zFact; }


    public void setXTitle(StringElement m)
    { xTitle = m; }
    public StringElement getXTitle()
    { return xTitle; }


    public void setYTitle(StringElement m)
    { yTitle = m; }
    public StringElement getYTitle()
    { return yTitle; }


    public void setZTitle(StringElement m)
    { zTitle = m; }
    public StringElement getZTitle()
    { return zTitle; }



    public void setScaleMode(string s)
    { scaleMode = s; }
    public string getScaleMode()
    { return scaleMode; }
}

/// <summary>
/// --- TEST STUB.. NOT COMPLETE
/// </summary>

#if TEST_PLOTFUNCTIONS

class Test
{
    static void Main()
    {
        PlotFunctionElement plotElement = new PlotFunctionElement();
        IntegerElement row = new IntegerElement();
        row.setText("2");
        
        IntegerElement col = new IntegerElement();
        col.setText("2");
        VariableElement varElement = new VariableElement();
        varElement.setText("a");
        DoubleElement dblElement = new DoubleElement();

        plotElement.setPlotFunction("subPlot");
        plotElement.setRow(row);
        plotElement.setColumn(col);
        plotElement.setData(varElement);
        


    }

}
#endif