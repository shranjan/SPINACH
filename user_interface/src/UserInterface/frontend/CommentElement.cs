////////////////////////////////////////////////////////////////////////
// CommentElement.cs: class for comments
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: Srinivasan Sundararajan (ssunda04@syr.edu)
// language: C# .Net 3.5
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Collections;

public class CommentElement : Element
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitCommentElement(this);
    }
}
