////////////////////////////////////////////////////////////////////////
// Interp.g: creates a parser for the Interp language.
// 
// version: 1.0
// description: part of the interpreter example for the visitor design
//  pattern.
// author: phil pratt-szeliga (pcpratts@syr.edu)
// language: antlr 3.0.1 parser generator - grammer input
////////////////////////////////////////////////////////////////////////

grammar Interp;

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
  | structdec {retval.ret = $structdec.ret;}
  | structobjdec { retval.ret = $structobjdec.ret;}
  | print { retval.ret = $print.ret; };

assignment returns [AssignmentOperationElement ret]
@init {
  retval.ret = new AssignmentOperationElement();
}
  : (variable {retval.ret.setLhs($variable.ret); }
  | structassign {retval.ret.setStructLhs($structassign.ret);})
  ASSIGNMENT 
    (var_or_int_literal {retval.ret.setRhs($var_or_int_literal.ret); }
    | matrixoperation { retval.ret.setRhs($matrixoperation.ret);} 
    | addition {retval.ret.setRhs($addition.ret);}
    | multiplication {retval.ret.setRhs($multiplication.ret);}
    ) END_OF_STATEMENT;

var_or_int_literal returns [Element ret]
  :  (variable { retval.ret = $variable.ret; } 
  |   int_literal {retval.ret = $int_literal.ret; });
  
int_literal returns [IntegerElement ret]
@init {
  retval.ret = new IntegerElement();
}
  : INT_LITERAL { retval.ret.setText($INT_LITERAL.text); };
  
variable returns [VariableElement ret]
@init {
  retval.ret = new VariableElement();
}
  : VARIABLE {retval.ret.setText($VARIABLE.text); };   

matrixoperation returns [MatrixOperationElement ret]
@init {
	retval.ret = new MatrixOperationElement();
	}
	:('('el1=int_literal { retval.ret.setRow($el1.ret);}')'
	'(' el2=int_literal { retval.ret.setColumn($el2.ret);}')'
	'['(el3=int_literal { retval.ret.setValue($el3.ret);})+ ']');
		  
addition returns [AdditionOperationElement ret]
@init {
  retval.ret = new AdditionOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    '+' 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };
    
multiplication returns [MultiplicationOperationElement ret]
@init {
  retval.ret = new MultiplicationOperationElement();
}
  : el1=var_or_int_literal { retval.ret.setLhs($el1.ret); } 
    '*' 
    el2=var_or_int_literal { retval.ret.setRhs($el2.ret); };    
    
structdec returns [StructDeclaration ret]
@init {
	retval.ret = new StructDeclaration();
	}
	: ('Struct' el1=variable { retval.ret.setName($el1.ret);}
	'{'(TYPE { retval.ret.setType($TYPE.text);} el2=variable { retval.ret.setVar($el2.ret);}';')+
	'}')END_OF_STATEMENT; 
	
structobjdec returns [StructObjectDeclaration ret]
@init {
	retval.ret = new StructObjectDeclaration();
	}
	: (el1=variable { retval.ret.setStructName($el1.ret);}
	  el2=variable { retval.ret.setObjName($el2.ret);})
	  END_OF_STATEMENT;
	  
structassign returns [StructAssignDeclaration ret]
@init {
	retval.ret = new StructAssignDeclaration();
	}
	:(el1=variable {retval.ret.setName($el1.ret);}'.'el2=variable {retval.ret.setObj($el2.ret);});
		  	
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
PLUS: '+';
MULTIPLY: '*';
//OPENBRACKET	:	'(';
//CLOSEBRACKET :	')';
//SQUAREOPENBRACKET :	'[';
//SQUARECLOSEBRACKET :	']';
TYPE	:	('int'|'double');
VARIABLE: ('a'..'z' | 'A'..'Z' )+;
INT_LITERAL: ('0'..'9' | ',')+;
//ALPHA	:	(VARIABLE|INT_LITERAL | '('..')')+;
WHITESPACE : (' ' | '\t' | '\n' | '\r' )+ {$channel = HIDDEN; } ;

