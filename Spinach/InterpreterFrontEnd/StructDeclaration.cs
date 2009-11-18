////////////////////////////////////////////////////////////////////////
// StructDeclaration.cs: holds the data needed to represent Structure 
//  in the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Deepak Goyal (dgoyal@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StructDeclaration : Element
{

    VariableElement mName;
    List<ScalarVariableDeclaration> mVar=new List<ScalarVariableDeclaration>();
    Hashtable hash = new Hashtable();
    //StructVariableDeclaration Vartype;
    //String mType;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitStructDeclaration(this);
    }

    public VariableElement getName() { return mName; }
    public void setName(VariableElement text) { mName = text; }
    public List<ScalarVariableDeclaration> getVarType() { return mVar; }
    public Hashtable getVar() { return hash; }
    public void setVarType(ScalarVariableDeclaration var) 
    {
   
        mVar.Add(var); 
    }
    public void setVar()
    {
        if(mVar.Count!=0)
        {
            for (int i = 0; i < mVar.Count; i++)
            {
                hash[mVar[i].getVar()] = null;
            }
        }
    }
    //public VariableElement getVar() { return mVar; }
    //public void setVar(VariableElement var) { mVar = var; }
    //public String getType() { return mType; }
    //public void setType(String type) { mType = type; }
}
