////////////////////////////////////////////////////////////////////////
// ParallelForElement.cs: Implements a vistor that interprets the 
//  parallelfor statement.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Srinivasan Sundararajan.
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Collections;


public class ParallelForElement : Element
{
    //The text inside the range.
    String rangeText;

    //The Range variable.
    String rangeVariable;

    //Starting Index.
    int StartingRange;

    //Ending Index.
    int EndingRange;

    //List that contains the code in the body of the loop.
    List<Element> CodeList;
    
    public override void Accept(Visitor visitor)
    {
        visitor.VisitParallelForElement(this);
    }

    //set and get the range text
    public String RANGETEXT
    {
        get
        {
            return rangeText;
        }
        set
        {
            rangeText = value;
            parseText(rangeText);
        }
    }


    //Set and get property for range variable.
    public String RANGEVAR
    {
        get
        {
            return rangeVariable;
        }
        set
        {
            rangeVariable= value;
        }
    }

    //Set and get property for starting range.
    public int STARTINGRANGE
    {
        get
        {
            return StartingRange;
        }
        set
        {
            StartingRange = value;
        }
    }

    //Set and get property for ending range.
    public int ENDINGRANGE
    {
        get
        {
            return EndingRange;
        }
        set
        {
            EndingRange = value;
        }
    }

    //adds the code inside the parallelfor loop to the list.
    public List<Element> CODELIST
    {
        set
        {
            CodeList = value;
        }
        get
        {
            return CodeList;
        }
    }

    //Parsing the whole text for getting range and code inside the loop.
    public void parseText(String input)
    {
        try
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    String str = "";
                    int j = i;
                    while (input[j] != '-')
                    {
                        str = str + input[j];
                        j++;
                    }
                    RANGEVAR = str;
                }
                 if (input[i] == '-')
                 {
                     String str = "";
                     int j = i;
                     while (input[j] != '.')
                     {
                         str = str + input[j];
                         j++;
                     }
                     STARTINGRANGE = Convert.ToInt16(str);
                 }
                 if (input[i] == '.')
                 {
                     if (input[i + 1] != '.')
                     {
                         String str = "";
                         int j = i;
                         while (input[j] != ')')
                         {
                             str = str + input[j];
                             j++;
                         }
                         ENDINGRANGE = Convert.ToInt16(str);
                     }
                 }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}