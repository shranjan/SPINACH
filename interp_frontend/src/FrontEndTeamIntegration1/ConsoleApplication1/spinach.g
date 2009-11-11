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
  :expr1{retval.ret = $expr1.ret;}| parallelfor{retval.ret = $parallelfor.ret;}
;

expr1 returns [Element ret]
   : expr2{retval.ret = $expr2.ret;}
    | matrixvardec { retval.ret = $matrixvardec.ret;}
     | structdec {retval.ret = $structdec.ret;}
     | structobjdec { retval.ret = $structobjdec.ret;}
     | functiondefination{retval.ret = $functiondefination.ret;}
      | plotfunctions{retval.ret = $plotfunctions.ret;};
 
expr2 returns [Element ret]
:  (el1=assignment {retval.ret = $el1.ret;}
  | el2=scalarvardec { retval.ret = $el2.ret;}
  | el3=vectorvardec { retval.ret = $el3.ret;} 
  | el4=deletionofvar { retval.ret = $el4.ret;} 
  | el5=print { retval.ret = $el5.ret; }
  | el6=ifelse{retval.ret = $el6.ret;}
  | el7=functioncall{retval.ret=$el7.ret;}
  | el8=forstatement{retval.ret = $el8.ret;}
  | el9=comment{retval.ret = $el9.ret;});

var_int_or_double_literal returns [Element ret]
  :  (variable { retval.ret = $variable.ret; } 
  |   int_literal {retval.ret = $int_literal.ret; }
  |   double_literal {retval.ret = $double_literal.ret;});

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

double_literal returns [DoubleElement ret]
@init {
	retval.ret = new DoubleElement();
	}
	: el1=DOUBLE_LITERAL {retval.ret.setText($el1.text);};

string_literal returns [StringElement ret]
@init {
 retval.ret = new StringElement();
}
 :('"'(el1=var_int_or_double_literal {retval.ret.setText($el1.ret);})*'"'{retval.ret.appendText();});

matrixvardec returns [MatrixVariableDeclaration ret]
@init {
	retval.ret = new MatrixVariableDeclaration();
	}
	:('Matrix' '<' VARTYPE { retval.ret.setType($VARTYPE.text);}'>' '['el1=int_literal { retval.ret.setRow($el1.ret);}']'
	'[' el2=int_literal { retval.ret.setColumn($el2.ret);}']'
	 (el3= variable { retval.ret.setVar($el3.ret);})
	 ASSIGNMENT
	 '['((el7=int_literal {retval.ret.addValue($el7.ret);} (','el5=int_literal {retval.ret.addValue($el5.ret);})*)|
	 (el4=double_literal {retval.ret.addValue($el4.ret);}
	 (','el6=double_literal {retval.ret.addValue($el6.ret);})*))']'{retval.ret.setValue();})
	 END_OF_STATEMENT;

vectorvardec returns [VectorVariableDeclaration ret]
@init {
	retval.ret = new VectorVariableDeclaration();
	}
	:('Vector' '<' VARTYPE { retval.ret.setType($VARTYPE.text);}'>' '['el1=int_literal {retval.ret.setRange($el1.ret);}']'
	 el2=variable {retval.ret.setText($el2.ret);} 
	 ASSIGNMENT 
	 '['((el3=int_literal {retval.ret.addValue($el3.ret);} (','el5=int_literal {retval.ret.addValue($el5.ret);})*)|
	 (el4=double_literal {retval.ret.addValue($el4.ret);}
	 (','el6=double_literal {retval.ret.addValue($el6.ret);})*))']'{retval.ret.setValue();})
	 END_OF_STATEMENT;

matrixelem returns [MatrixElement ret]
@init {
 retval.ret = new MatrixElement();
 }
 :(el1=variable {retval.ret.setVar($el1.ret);}'['el2=int_literal{retval.ret.setRow($el2.ret);}']'
 '['el3=int_literal{retval.ret.setColumn($el3.ret);}']');
 
vectorelem returns [VectorElement ret]
@init {
 retval.ret = new VectorElement();
 }
 :(el1=variable {retval.ret.setVar($el1.ret);}'['el2=int_literal {retval.ret.setRange($el2.ret);}']'); 

assignment returns [AssignmentOperationElement ret]
@init {
  retval.ret = new AssignmentOperationElement();
}
  : ((variable {retval.ret.setLhs($variable.ret); }
    | structassign {retval.ret.setLhs($structassign.ret);}
    |e12= vectorelem{retval.ret.setLhs($e12.ret);}
    | e11 = matrixelem{retval.ret.setLhs($e11.ret);})
    ASSIGNMENT 
    ( subtractive_exp{retval.ret.setRhs($subtractive_exp.ret);}| dotproduct{retval.ret.setRhs($dotproduct.ret);}
    | matrixtranspose {retval.ret.setRhs($matrixtranspose.ret);}|string_literal{retval.ret.setRhs($string_literal.ret);}
    ))
     END_OF_STATEMENT
    ;

additive_expression returns [AdditiveElement ret]
@init{
	retval.ret = new AdditiveElement();
}
	: ((e11 = multiplicative_expression{retval.ret.setLhs($e11.ret);}) ('+' e12 = multiplicative_expression{retval.ret.setRhs($e12.ret);})*)
	;

multiplicative_expression returns [MultiplicationElement ret]
@init{
	retval.ret = new MultiplicationElement();
}
	: (e11 = var_int_or_double_literal{retval.ret.setLhs($e11.ret);}
	   | e12= bracket_exp{retval.ret.setLhs($e12.ret);}
	   | el3 = matrixelem{retval.ret.setLhs($el3.ret);}
	   | el4 = vectorelem{retval.ret.setLhs($el4.ret);})
	   ('*'( e15 =var_int_or_double_literal{retval.ret.setRhs($e15.ret);}
	   | e16=  bracket_exp{retval.ret.setRhs($e16.ret);}
	   | el7 = vectorelem{retval.ret.setLhs($el7.ret);}
	   | el8 = matrixelem{retval.ret.setLhs($el8.ret);}))*
	  ;
        
    
bracket_exp returns [BracketElement ret]
@init{
	retval.ret = new BracketElement();
}
: '('subtractive_exp{retval.ret.setbracketexpression($subtractive_exp.ret);}')' ;





subtractive_exp returns [SubtractionElement ret]
@init{
	retval.ret = new SubtractionElement();
}
:    (e11 = additive_expression{retval.ret.setLhs($e11.ret);}  ('-' e12 = additive_expression{retval.ret.setRhs($e12.ret);})*)
	;
    
 
structdec returns [StructDeclaration ret]
@init {
retval.ret = new StructDeclaration();
}
: ('struct' variable { retval.ret.setName($variable.ret);}
'{' (el1=scalarvardec { retval.ret.setVarType($el1.ret);})+
'}')END_OF_STATEMENT; 

scalarvardec returns [ScalarVariableDeclaration ret]
@init {
	retval.ret = new ScalarVariableDeclaration();
	}	
	:((VARTYPE { retval.ret.setType($VARTYPE.text);}
	| STRINGTYPE { retval.ret.setType($STRINGTYPE.text);}) 
	variable { retval.ret.setVar($variable.ret);})END_OF_STATEMENT;
 

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

deletionofvar returns [DeleteVariable ret]
@init {
retval.ret = new DeleteVariable();
}
:('delete' el1=variable { retval.ret.setVar($el1.ret);})END_OF_STATEMENT;

print returns [PrintOperationElement ret]
@init {
  retval.ret = new PrintOperationElement();
}
  : 'print' var_int_or_double_literal {retval.ret.setChildElement($var_int_or_double_literal.ret); }
    END_OF_STATEMENT; 
    

parallelfor returns [ParallelForElement ret]
@init {
  retval.ret = new ParallelForElement();
}: 'parallelfor' r11 = range{retval.ret.RANGE = $range.ret;} LEFTPARANTHESIS  ((e11=expr2{retval.ret.ADDCODE =$e11.ret;})+(('SYNC'{retval.ret.syncfunction();} END_OF_STATEMENT)|{retval.ret.syncfunction();}))+ RIGHTPARANTHESIS
;

range returns[RangeElement ret]
@init{
  retval.ret= new RangeElement();
}:LEFTBRACE e11 = variable{retval.ret.RANGEVARIABLE = $e11.ret;} POINT e12 = int_literal{retval.ret.STARTINGRANGE = $e12.ret;} 'to' e13= int_literal{retval.ret.ENDINGRANGE = $e13.ret;} RIGHTBRACE;

//implement return statement
ifelse returns [IfStatementElement ret]
@init{
   retval.ret = new IfStatementElement();
}
:('if' LEFTBRACE (equality{retval.ret.CONDITION = $equality.ret;}|nonequality{retval.ret.CONDITION = $nonequality.ret;}|lessthan{retval.ret.CONDITION = $lessthan.ret;}
	|	lessthanequalto{retval.ret.CONDITION = $lessthanequalto.ret;}|greaterthan{retval.ret.CONDITION =$greaterthan.ret;}| greaterthanequalto{retval.ret.CONDITION = $greaterthanequalto.ret;}
) RIGHTBRACE LEFTPARANTHESIS ((e11 = ifloop{retval.ret.IFCODE = $e11.ret;})|)RIGHTPARANTHESIS)('else'  LEFTPARANTHESIS ((e12 =  ifloop{retval.ret.ELSECODE = $e12.ret;})|) RIGHTPARANTHESIS)? ;

ifloop returns [List<Element> ret]
@init
{
   retval.ret = new List<Element>();
}
: (expr{retval.ret.Add($expr.ret);}|functionreturn{retval.ret.Add($functionreturn.ret);})+
;


forstatement returns [ForStatementElement ret]
@init{
   retval.ret = new ForStatementElement();
}:'for'  r11=range{retval.ret.RANGE = $r11.ret;} LEFTPARANTHESIS (e11=expr1{retval.ret.ADDCODE =$e11.ret;})+ RIGHTPARANTHESIS;

   //vinit tasks
   functioncall returns [FunctionCallElement ret]
 @init{ retval.ret = new FunctionCallElement();
 }
  :variable{retval.ret.setfunctioncallname($variable.ret);}
  '('(el1=var_int_or_double_literal{retval.ret.setparameters($el1.ret);} (',' el2=var_int_or_double_literal{retval.ret.setparameters($el2.ret);})*)? ')'
  END_OF_STATEMENT
;
 
 
equality returns [EqualityOperationElement ret]
 
@init {
  retval.ret = new EqualityOperationElement();
}
 
: e11 = variable {retval.ret.setequalityLhs($e11.ret); }
     EQUALITYEXPRESSION
        var_int_or_double_literal {retval.ret.setequalityRhs($var_int_or_double_literal.ret); } 
     ;
    
    
nonequality returns [NonEqualityOperationElement ret]
 
@init {
  retval.ret = new NonEqualityOperationElement();
}
 
: e11 = variable {retval.ret.setnonequalityLhs($e11.ret); }
     NONEQUALITYEXPRESSION
   var_int_or_double_literal {retval.ret.setnonequalityRhs($var_int_or_double_literal.ret); } 
     ;    


functiondefination returns [FunctionElement ret]

@init{
retval.ret = new FunctionElement();
}
: (VARTYPE{retval.ret.setreturntype($VARTYPE.text);}
  variable {retval.ret.setfunctionname($variable.ret);}
  '('
 ((e11= arguments{retval.ret.setArguments($e11.ret);}(',' e12 =arguments{retval.ret.setArguments($e12.ret);})*)?)
 ')'
'{' (assignment{retval.ret.setBody($assignment.ret);}|functioncall{retval.ret.setBody($functioncall.ret);}| scalarvardec { retval.ret.setBody($scalarvardec.ret);}
  | vectorvardec { retval.ret.setBody($vectorvardec.ret);}
  | matrixvardec { retval.ret.setBody($matrixvardec.ret);}
  | deletionofvar { retval.ret.setBody($deletionofvar.ret);} | print { retval.ret.setBody($print.ret); }
  | ifelse{retval.ret.setBody($ifelse.ret);}| functionreturn{retval.ret.setBody($functionreturn.ret);}| parallelfor{retval.ret.setBody($parallelfor.ret);}| forstatement{retval.ret.setBody($forstatement.ret);})+
'}')|'void'{retval.ret.setreturntype("void");}
  variable {retval.ret.setfunctionname($variable.ret);}
  '('
 ((e11 = arguments{retval.ret.setArguments($e11.ret);}(',' e12=arguments{retval.ret.setArguments($e12.ret);})*)?)
 ')'
'{' (assignment{retval.ret.setBody($assignment.ret);}|functioncall{retval.ret.setBody($functioncall.ret);}| scalarvardec { retval.ret.setBody($scalarvardec.ret);}
  | vectorvardec { retval.ret.setBody($vectorvardec.ret);}
  | matrixvardec { retval.ret.setBody($matrixvardec.ret);}
  | deletionofvar { retval.ret.setBody($deletionofvar.ret);} | print { retval.ret.setBody($print.ret); }
  | ifelse{retval.ret.setBody($ifelse.ret);}| functionreturn{retval.ret.setBody($functionreturn.ret);}| parallelfor{retval.ret.setBody($parallelfor.ret);}| forstatement{retval.ret.setBody($forstatement.ret);})+
'}'
;
lessthan returns [LessThanElement ret]
@init{
	retval.ret = new LessThanElement();
}
: e11 = variable{retval.ret.setLessThanLhs($e11.ret);} LESSTHANEXPRESSION e12 =var_int_or_double_literal{retval.ret.setLessThanRhs($e12.ret);}
;

greaterthan returns [GreaterThanElement ret]
@init{
	retval.ret = new GreaterThanElement();
}
: e11 = variable{retval.ret.setGreaterThanLhs($e11.ret);} GREATERTHANEXPRESSION e12 =var_int_or_double_literal{retval.ret.setGreaterThanRhs($e12.ret);}
;

lessthanequalto returns [LessThanEqualToElement ret]
@init{
	retval.ret = new LessThanEqualToElement();
}
: e11 = variable{retval.ret.setLessThanEqualToLhs($variable.ret);} LESSTHANEQUALTOEXPRESSION e12 = var_int_or_double_literal{retval.ret.setLessThanEqualToRhs($e12.ret);}
;

greaterthanequalto returns [GreaterThanEqualToElement ret]
@init{
	retval.ret = new GreaterThanEqualToElement();
}
: e11 = variable{retval.ret.setGreaterThanEqualToLhs($e11.ret);} GREATERTHANEQUALTOEXPRESSION e12 = var_int_or_double_literal{retval.ret.setGreaterThanEqualToRhs($e12.ret);}
;
//In the function body according to this design it will return only one of the expression to function definition class. we need a list of all the valid SPINACH code inside the function body.
//program will return the list of all the valid spinach code but that will include everything including parallelfor. if we need to support everything in a function then use that else use the bodyloop function.


dotproduct returns [DotProductElement ret]
@init{
retval.ret = new DotProductElement ();
}
: e11 = variable {retval.ret.setLhs($e11.ret); } 'DOT' e12 = variable {retval.ret.setRhs($e12.ret); }
;
matrixtranspose returns [MatrixTranspose ret]

@init{
retval.ret = new MatrixTranspose();
}
: 'T' LEFTBRACE variable {retval.ret.setvariable($variable.ret); }')'
;

matrixreference returns [MatrixReference ret]
@init{ retval.ret = new MatrixReference();
}
:'Matrix' '<' (el1=VARTYPE{retval.ret.settype($el1.text);}'>' el2=variable {retval.ret.setvariable($el2.ret);})
;

vectorreference returns [VectorReference ret]
@init{ retval.ret = new VectorReference();
}
:'Vector' '<' (el1=VARTYPE{retval.ret.settype($el1.text);}'>' el2=variable {retval.ret.setvariable($el2.ret);})
;
arguments returns [Element ret]
: (scalarargument { retval.ret = $scalarargument.ret; }
| matrixreference {retval.ret = $matrixreference.ret; }
| vectorreference {retval.ret = $vectorreference.ret;});

//functiondeclaration returns [DeclarationElement ret]
//@init { retval.ret = new DeclarationElement();
//}
//:((e11 =VARTYPE{retval.ret.settype($e11.text);}) e12 =variable
//{retval.ret.setvariable($e12.ret); }
//|('Matrix''<' el1=VARTYPE {retval.ret.settype($el1.text);}'>'
//el2=variable {retval.ret.setvariable($el2.ret);}))
//;

scalarargument returns [ScalarArgument ret]
@init{retval.ret = new ScalarArgument();
}:
((e11 =VARTYPE{retval.ret.settype($e11.text);}) e12 =variable
{retval.ret.setvariable($e12.ret); })
;

comment returns [CommentElement ret]
@init{
retval.ret = new CommentElement();
}
:'//'var_int_or_double_literal*;



functionreturn returns [ReturnElement ret]
@init{
retval.ret = new ReturnElement();
}
:'return' (var_int_or_double_literal{retval.ret.setreturnvariable($var_int_or_double_literal.ret);}) END_OF_STATEMENT
;


 
 
plotfunctions returns [PlotFunctionElement ret]
@init { retval.ret = new PlotFunctionElement();
}
: ('subPlot'{retval.ret.setPlotFunction("subPlot");} '('
(el1 = int_literal {retval.ret.setRow($el1.ret);}) ','
(el2 = int_literal {retval.ret.setColumn($el2.ret);}) ','
(vll1 = variable {retval.ret.setData($vll1.ret);}) ','
(vll2 = string_literal {retval.ret.setTitle($vll2.ret);})','
(('1D'{retval.ret.setPlotType("1D");})|('2D'{retval.ret.setPlotType("2D");})|('3D'{retval.ret.setPlotType("3D");}(','(el3 = int_literal{retval.ret.setMode($el3.ret);}))?))
')'END_OF_STATEMENT)
| ('plot'{retval.ret.setPlotFunction("plot");} '('
(vll3= variable {retval.ret.setData($vll3.ret);}) ','
(vll4= string_literal {retval.ret.setTitle($vll4.ret);})','
(('1D'{retval.ret.setPlotType("1D");})|('2D'{retval.ret.setPlotType("2D");})|('3D'{retval.ret.setPlotType("3D");}(','(el3 = int_literal{retval.ret.setMode($el3.ret);}))?))
')'END_OF_STATEMENT)
| ('resetPlot''('')'{retval.ret.setPlotFunction("resetPlot");}END_OF_STATEMENT)
| ('setPlotAxis'{retval.ret.setPlotFunction("setPlotAxis");}'('
(ell2 =double_literal{retval.ret.setXFact($ell2.ret);})','
((ell3=double_literal{retval.ret.setYFact($ell3.ret);})',')
((el4=double_literal{retval.ret.setZFact($el4.ret);}))
')'END_OF_STATEMENT)
|('setPlotAxis'{retval.ret.setPlotFunction("setPlotAxis");}'('
(ell2 =double_literal{retval.ret.setXFact($ell2.ret);})','
((ell3=double_literal{retval.ret.setYFact($ell3.ret);}))
')'END_OF_STATEMENT)
|('setPlotAxis'{retval.ret.setPlotFunction("setPlotAxis");}'('
(ell2 =double_literal{retval.ret.setXFact($ell2.ret);})
')'END_OF_STATEMENT)
| ('setAxisTitle'{retval.ret.setPlotFunction("setAxisTitle");}'('
(vl1= string_literal{retval.ret.setXTitle($vl1.ret);})','
((vl2 =string_literal{retval.ret.setYTitle($vl2.ret);})',')
((vl3 =string_literal{retval.ret.setZTitle($vl3.ret);}))
')'END_OF_STATEMENT)
| ('setAxisTitle'{retval.ret.setPlotFunction("setAxisTitle");}'('
(vl1= string_literal{retval.ret.setXTitle($vl1.ret);})','
((vl2 =string_literal{retval.ret.setYTitle($vl2.ret);}))
')'END_OF_STATEMENT)
|('setAxisTitle'{retval.ret.setPlotFunction("setAxisTitle");}'('
(vl1= string_literal{retval.ret.setXTitle($vl1.ret);})
')'END_OF_STATEMENT)
|('setScaleMode''('{retval.ret.setPlotFunction("setScaleMode");}
SCALEMODE {retval.ret.setScaleMode($SCALEMODE.Text);}
')'
END_OF_STATEMENT)
;
/*
 * Lexer Rules
 */
 
END_OF_STATEMENT: ';';
SCALEMODE: 'log' | 'linear' ;
VARTYPE	: 'int' | 'double';
STRINGTYPE : 'string';	
DOT	:'.';
ASSIGNMENT: '=';
PLUS: '+';
MULTIPLY:'*';
VARIABLE: ('a'..'z' | 'A'..'Z' )+;
INT_LITERAL: ('0'..'9')+;
DOUBLE_LITERAL:(INT_LITERAL DOT INT_LITERAL);	
WHITESPACE : (' ' | '\t' | '\n' | '\r' )+ {$channel = HIDDEN; } ;
LEFTBRACE :'(';
RIGHTBRACE:')';
LEFTPARANTHESIS:'{';
RIGHTPARANTHESIS:'}';
POINT: '->';
EQUALITYEXPRESSION: '==';
NONEQUALITYEXPRESSION: '!='; 
LESSTHANEXPRESSION :'<';	
LESSTHANEQUALTOEXPRESSION:'<=';
GREATERTHANEXPRESSION :'>';	
GREATERTHANEQUALTOEXPRESSION:'>=';	