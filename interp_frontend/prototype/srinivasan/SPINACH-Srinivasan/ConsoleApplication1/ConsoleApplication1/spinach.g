
////////////////////////////////////////////////////////////////////////
// Spinach.g: creates a parser for the Interp language.
// 
// version: 1.0
// description: parser for the spinach code
// author: Srinivasan Sundararajan (ssunda04@syr.edu)
// language: antlr 3.0.1 parser generator - grammer input
////////////////////////////////////////////////////////////////////////


grammar spinach;

options {
  language = 'CSharp';
  output=AST;
} 

@parser::header {
using System.Collections.Generic;
}

@lexer::header {
using System.Collections.Generic;
}

/*
 * Parser Rules
 */
program returns [List<Element> ret]
@init {
  retval.ret = new List<Element>();
}
  : (expr {retval.ret.Add($expr.ret); } )+;

expr returns [Element ret]
  : assignment {retval.ret = $assignment.ret;}
  | print { retval.ret = $print.ret; }
  | parallelfor{retval.ret = $parallelfor.ret;};
  
expr1 returns [Element ret]
  : assignment {retval.ret = $assignment.ret;}
  | print { retval.ret = $print.ret; };

assignment returns [AssignmentOperationElement ret]
@init {
  retval.ret = new AssignmentOperationElement();
}
  : variable {retval.ret.setLhs($variable.ret); }
    ASSIGNMENT 
    (var_or_int_literal {retval.ret.setRhs($var_or_int_literal.ret); } 
    | addition {retval.ret.setRhs($addition.ret); }
    ) END_OF_STATEMENT;

var_or_int_literal returns [Element ret]
  :  (variable { retval.ret = $variable.ret; } 
  |   int_literal {retval.ret = $int_literal.ret; } );

variable returns [VariableElement ret]
@init {
  retval.ret = new VariableElement();
}
  : VARIABLE { retval.ret.setText($VARIABLE.text); };

int_literal returns [IntegerElement ret]
@init {
  retval.ret = new IntegerElement();
}
  : INT_LITERAL { retval.ret.setText($INT_LITERAL.text); };

addition returns [AdditionOperationElement ret]
@init {
  retval.ret = new AdditionOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    '+' 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };

print returns [PrintOperationElement ret]
@init {
  retval.ret = new PrintOperationElement();
}
  : 'print' var_or_int_literal {retval.ret.setChildElement($var_or_int_literal.ret); }
    END_OF_STATEMENT; 
    
parallelfor returns [ParallelForElement ret]
@init {
  retval.ret = new ParallelForElement();
}: 'parallelfor' RANGE{retval.ret.RANGETEXT = $RANGE.text;} LEFTPARANTHESIS ((e11= bodyloop{retval.ret.CODE = $e11.ret;})+|) RIGHTPARANTHESIS
    END_OF_STATEMENT;

bodyloop returns [list<Element> ret]
@init{
   retval.ret = new List<Element>();
}
: (expr1{retval.ret.Add($expr1.ret);})+;

/*
 * Lexer Rules
 */
 
END_OF_STATEMENT: ';';
ASSIGNMENT: '=';
PLUS: '+';
MULTIPLY:'*';
VARIABLE: ('a'..'z' | 'A'..'Z' )+;
INT_LITERAL: ('0'..'9')+;
WHITESPACE : (' ' | '\t' | '\n' | '\r' )+ {$channel = HIDDEN; } ;
LEFTBRACE :'(';
RIGHTBRACE:')';	
LEFTPARANTHESIS:'{';
RIGHTPARANTHESIS:'}';	
DASH: '-';
DOT:'.';	
RANGE:LEFTBRACE VARIABLE DASH INT_LITERAL DOT DOT INT_LITERAL RIGHTBRACE;
