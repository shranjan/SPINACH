////////////////////////////////////////////////////////////////////////
// Interp.g: creates a parser for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: antlr 3.0.1 parser generator - grammer input
////////////////////////////////////////////////////////////////////////

grammar vinitgrammer;

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
  | parallelfor {retval.ret = $parallelFor.ret};

parallelfor returns [ParallelForOperationElement ret]
@init {
	retval.ret = new ParallelForOperationElement();
}
   	:	'parallel_for' '(' pfargument ')'
   		'{' (assignment {retval.ret = $assignment.ret;})+ '}';
	

pfargument returns [pfargumentElement ret]
@init {
  retval.ret = new pfargumentElement();
}
  : variable {retval.ret.setLhs($variable.ret); }
    ASSIGNMENT 
       range{retval.ret = $range.ret;}
    | range{retval.ret = $range.ret;} 
     END_OF_STATEMENT; 

range returns [rangeElement ret]
@init {
	retval.ret = new rangeElement();
	}
	: (  el1=var_or_int_literal { retval.ret.setLow($el1.ret); } 
   	        '..' 
    	        el2=var_or_int_literal { retval.ret.setHigh($el2.ret); }
    	        );
 
 array returns [ArrayElement ret]
 @init {
 	retval.ret = new ArrayElement();
 	}
 	: variable'['INT_LITERAL']' {retval.ret.setLhs($variable.ret);}
 	  ASSIGNMENT
 	  (( '{'  elements {retval.ret.setRhs{$variable.ret};} '};')
 	  |( '{'  elements(','elements)+ {retval.ret.addtolist($int_literal.ret);}
 	   '};'))
 	   ;

elements returns [Element ret]
	: var_or_int_literal {retval.ret = $int_literal.ret;}
        ;
        
matrix returns [MatrixElement ret] 
@init {
	retval.ret = new MatrixElement();
	}
	: variable'['INT_LITERAL','INT_LITERAL']'{retval.ret.setLhs($varible.ret);}
	  ASSIGNMENT
	 // ('{' matrixElements {retval.ret.setMatrixElement($matrixElements.ret);}
	  '};')
	  ;  
        
	
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

function returns [FunctionElement ret]

@init{
	retval.ret = new FunctionElement();
	
}
	: TYPE{retval.ret.setreturntype($TYPE.Text)}
	  variable {retval.ret.setfunctionname($variable.ret)}
	 '(' (declaration{retval.ret.setArguments($declaration.ret)}(',' declaration{retval.ret.setArguments($declaration.ret)})*)*')'
	 '{' program {retval.ret.setBody($program.ret)}'}'
	  
		
		;
declaration returns [DeclerationElement ret]
 @init{ retval.ret = new DeclarationElement();
}
	:
	 TYPE{retval.ret.settype($TYPE.Text)} ' '  variable {retval.ret.setvariable($variable.ret) }
	;

print returns [PrintOperationElement ret]
@init {
  retval.ret = new PrintOperationElement();
}
  : 'print' var_or_int_literal {retval.ret.setChildElement($var_or_int_literal.ret); }
    END_OF_STATEMENT; 

/*
 * Lexer Rules
 */


END_OF_STATEMENT: ';';
ASSIGNMENT: '=';
TYPE	:'int';	
PLUS: '+';
VARIABLE: ('a'..'z' | 'A'..'Z' )+;
INT_LITERAL: ('0'..'9')+;
WHITESPACE : (' ' | '\t' | '\n' | '\r' )+ {$channel = HIDDEN; } ;

