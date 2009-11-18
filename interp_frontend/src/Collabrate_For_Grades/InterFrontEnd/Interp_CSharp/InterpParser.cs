// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-11-03 18:50:11


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public class InterpParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ASSIGNMENT", 
		"END_OF_STATEMENT", 
		"INT_LITERAL", 
		"DOUBLE_LITERAL", 
		"VARIABLE", 
		"VARTYPE", 
		"STRINGTYPE", 
		"PLUS", 
		"MULTIPLY", 
		"WHITESPACE", 
		"'Matrix'", 
		"'<'", 
		"'>'", 
		"'['", 
		"']'", 
		"','", 
		"'Vector'", 
		"'Struct'", 
		"'{'", 
		"'}'", 
		"'.'", 
		"'delete'", 
		"'print'"
    };

    public const int INT_LITERAL = 6;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int DOUBLE_LITERAL = 7;
    public const int WHITESPACE = 13;
    public const int EOF = -1;
    public const int VARTYPE = 9;
    public const int T__19 = 19;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int VARIABLE = 8;
    public const int T__18 = 18;
    public const int T__17 = 17;
    public const int MULTIPLY = 12;
    public const int T__14 = 14;
    public const int STRINGTYPE = 10;
    public const int PLUS = 11;
    public const int ASSIGNMENT = 4;
    public const int END_OF_STATEMENT = 5;

    // delegates
    // delegators



        public InterpParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public InterpParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
       }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return InterpParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Interp.g"; }
    }


    public class program_return : ParserRuleReturnScope
    {
        public List<Element> ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "program"
    // Interp.g:29:1: program returns [List<Element> ret] : ( expr )+ ;
    public InterpParser.program_return program() // throws RecognitionException [1]
    {   
        InterpParser.program_return retval = new InterpParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // Interp.g:33:3: ( ( expr )+ )
            // Interp.g:33:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:33:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= VARIABLE && LA1_0 <= STRINGTYPE) || LA1_0 == 14 || (LA1_0 >= 20 && LA1_0 <= 21) || (LA1_0 >= 25 && LA1_0 <= 26)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Interp.g:33:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program74);
            			    	expr1 = expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1.Tree);
            			    	retval.ret.Add(((expr1 != null) ? expr1.ret : null)); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "program"

    public class expr_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr"
    // Interp.g:34:1: expr returns [Element ret] : ( assignment | scalarvardec | vectorvardec | matrixvardec | deletionofvar | structdec | structobjdec | print );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.scalarvardec_return scalarvardec3 = null;

        InterpParser.vectorvardec_return vectorvardec4 = null;

        InterpParser.matrixvardec_return matrixvardec5 = null;

        InterpParser.deletionofvar_return deletionofvar6 = null;

        InterpParser.structdec_return structdec7 = null;

        InterpParser.structobjdec_return structobjdec8 = null;

        InterpParser.print_return print9 = null;



        try 
    	{
            // Interp.g:35:3: ( assignment | scalarvardec | vectorvardec | matrixvardec | deletionofvar | structdec | structobjdec | print )
            int alt2 = 8;
            alt2 = dfa2.Predict(input);
            switch (alt2) 
            {
                case 1 :
                    // Interp.g:35:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expr92);
                    	assignment2 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment2.Tree);
                    	retval.ret = ((assignment2 != null) ? assignment2.ret : null);

                    }
                    break;
                case 2 :
                    // Interp.g:36:5: scalarvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scalarvardec_in_expr100);
                    	scalarvardec3 = scalarvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, scalarvardec3.Tree);
                    	 retval.ret = ((scalarvardec3 != null) ? scalarvardec3.ret : null);

                    }
                    break;
                case 3 :
                    // Interp.g:37:5: vectorvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_vectorvardec_in_expr108);
                    	vectorvardec4 = vectorvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, vectorvardec4.Tree);
                    	 retval.ret = ((vectorvardec4 != null) ? vectorvardec4.ret : null);

                    }
                    break;
                case 4 :
                    // Interp.g:38:5: matrixvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixvardec_in_expr116);
                    	matrixvardec5 = matrixvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matrixvardec5.Tree);
                    	 retval.ret = ((matrixvardec5 != null) ? matrixvardec5.ret : null);

                    }
                    break;
                case 5 :
                    // Interp.g:39:5: deletionofvar
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_deletionofvar_in_expr124);
                    	deletionofvar6 = deletionofvar();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, deletionofvar6.Tree);
                    	 retval.ret = ((deletionofvar6 != null) ? deletionofvar6.ret : null);

                    }
                    break;
                case 6 :
                    // Interp.g:40:5: structdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structdec_in_expr132);
                    	structdec7 = structdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structdec7.Tree);
                    	retval.ret = ((structdec7 != null) ? structdec7.ret : null);

                    }
                    break;
                case 7 :
                    // Interp.g:41:5: structobjdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structobjdec_in_expr140);
                    	structobjdec8 = structobjdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structobjdec8.Tree);
                    	 retval.ret = ((structobjdec8 != null) ? structobjdec8.ret : null);

                    }
                    break;
                case 8 :
                    // Interp.g:42:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr148);
                    	print9 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print9.Tree);
                    	 retval.ret = ((print9 != null) ? print9.ret : null); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class assignment_return : ParserRuleReturnScope
    {
        public AssignmentOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // Interp.g:44:1: assignment returns [AssignmentOperationElement ret] : ( variable | structassign ) ASSIGNMENT ( var_int_or_double_literal | addition | multiplication ) END_OF_STATEMENT ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT12 = null;
        IToken END_OF_STATEMENT16 = null;
        InterpParser.variable_return variable10 = null;

        InterpParser.structassign_return structassign11 = null;

        InterpParser.var_int_or_double_literal_return var_int_or_double_literal13 = null;

        InterpParser.addition_return addition14 = null;

        InterpParser.multiplication_return multiplication15 = null;


        object ASSIGNMENT12_tree=null;
        object END_OF_STATEMENT16_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // Interp.g:48:3: ( ( variable | structassign ) ASSIGNMENT ( var_int_or_double_literal | addition | multiplication ) END_OF_STATEMENT )
            // Interp.g:48:5: ( variable | structassign ) ASSIGNMENT ( var_int_or_double_literal | addition | multiplication ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:48:5: ( variable | structassign )
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == VARIABLE) )
            	{
            	    int LA3_1 = input.LA(2);

            	    if ( (LA3_1 == 24) )
            	    {
            	        alt3 = 2;
            	    }
            	    else if ( (LA3_1 == ASSIGNMENT) )
            	    {
            	        alt3 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d3s1 =
            	            new NoViableAltException("", 3, 1, input);

            	        throw nvae_d3s1;
            	    }
            	}
            	else 
            	{
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Interp.g:48:6: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_assignment170);
            	        	variable10 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable10.Tree);
            	        	retval.ret.setLhs(((variable10 != null) ? variable10.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:49:5: structassign
            	        {
            	        	PushFollow(FOLLOW_structassign_in_assignment178);
            	        	structassign11 = structassign();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structassign11.Tree);
            	        	retval.ret.setStructLhs(((structassign11 != null) ? structassign11.ret : null));

            	        }
            	        break;

            	}

            	ASSIGNMENT12=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment185); 
            		ASSIGNMENT12_tree = (object)adaptor.Create(ASSIGNMENT12);
            		adaptor.AddChild(root_0, ASSIGNMENT12_tree);

            	// Interp.g:51:5: ( var_int_or_double_literal | addition | multiplication )
            	int alt4 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case END_OF_STATEMENT:
            	    	{
            	        alt4 = 1;
            	        }
            	        break;
            	    case MULTIPLY:
            	    	{
            	        alt4 = 3;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt4 = 2;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d4s1 =
            	    	        new NoViableAltException("", 4, 1, input);

            	    	    throw nvae_d4s1;
            	    }

            	    }
            	    break;
            	case INT_LITERAL:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case PLUS:
            	    	{
            	        alt4 = 2;
            	        }
            	        break;
            	    case END_OF_STATEMENT:
            	    	{
            	        alt4 = 1;
            	        }
            	        break;
            	    case MULTIPLY:
            	    	{
            	        alt4 = 3;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d4s2 =
            	    	        new NoViableAltException("", 4, 2, input);

            	    	    throw nvae_d4s2;
            	    }

            	    }
            	    break;
            	case DOUBLE_LITERAL:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case MULTIPLY:
            	    	{
            	        alt4 = 3;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt4 = 2;
            	        }
            	        break;
            	    case END_OF_STATEMENT:
            	    	{
            	        alt4 = 1;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d4s3 =
            	    	        new NoViableAltException("", 4, 3, input);

            	    	    throw nvae_d4s3;
            	    }

            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d4s0 =
            		        new NoViableAltException("", 4, 0, input);

            		    throw nvae_d4s0;
            	}

            	switch (alt4) 
            	{
            	    case 1 :
            	        // Interp.g:51:6: var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_assignment193);
            	        	var_int_or_double_literal13 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_int_or_double_literal13.Tree);
            	        	retval.ret.setRhs(((var_int_or_double_literal13 != null) ? var_int_or_double_literal13.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:52:7: addition
            	        {
            	        	PushFollow(FOLLOW_addition_in_assignment203);
            	        	addition14 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition14.Tree);
            	        	retval.ret.setRhs(((addition14 != null) ? addition14.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // Interp.g:53:7: multiplication
            	        {
            	        	PushFollow(FOLLOW_multiplication_in_assignment213);
            	        	multiplication15 = multiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, multiplication15.Tree);
            	        	retval.ret.setRhs(((multiplication15 != null) ? multiplication15.ret : null));

            	        }
            	        break;

            	}

            	END_OF_STATEMENT16=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment223); 
            		END_OF_STATEMENT16_tree = (object)adaptor.Create(END_OF_STATEMENT16);
            		adaptor.AddChild(root_0, END_OF_STATEMENT16_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class var_int_or_double_literal_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "var_int_or_double_literal"
    // Interp.g:56:1: var_int_or_double_literal returns [Element ret] : ( variable | int_literal | double_literal ) ;
    public InterpParser.var_int_or_double_literal_return var_int_or_double_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_int_or_double_literal_return retval = new InterpParser.var_int_or_double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable17 = null;

        InterpParser.int_literal_return int_literal18 = null;

        InterpParser.double_literal_return double_literal19 = null;



        try 
    	{
            // Interp.g:57:3: ( ( variable | int_literal | double_literal ) )
            // Interp.g:57:6: ( variable | int_literal | double_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:57:6: ( variable | int_literal | double_literal )
            	int alt5 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    alt5 = 1;
            	    }
            	    break;
            	case INT_LITERAL:
            		{
            	    alt5 = 2;
            	    }
            	    break;
            	case DOUBLE_LITERAL:
            		{
            	    alt5 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d5s0 =
            		        new NoViableAltException("", 5, 0, input);

            		    throw nvae_d5s0;
            	}

            	switch (alt5) 
            	{
            	    case 1 :
            	        // Interp.g:57:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_int_or_double_literal239);
            	        	variable17 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable17.Tree);
            	        	 retval.ret = ((variable17 != null) ? variable17.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:58:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_int_or_double_literal250);
            	        	int_literal18 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal18.Tree);
            	        	retval.ret = ((int_literal18 != null) ? int_literal18.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // Interp.g:59:7: double_literal
            	        {
            	        	PushFollow(FOLLOW_double_literal_in_var_int_or_double_literal260);
            	        	double_literal19 = double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, double_literal19.Tree);
            	        	retval.ret = ((double_literal19 != null) ? double_literal19.ret : null);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "var_int_or_double_literal"

    public class int_literal_return : ParserRuleReturnScope
    {
        public IntegerElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "int_literal"
    // Interp.g:61:1: int_literal returns [IntegerElement ret] : el1= INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;

        object el1_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // Interp.g:65:3: (el1= INT_LITERAL )
            // Interp.g:65:5: el1= INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal286); 
            		el1_tree = (object)adaptor.Create(el1);
            		adaptor.AddChild(root_0, el1_tree);

            	 retval.ret.setText(((el1 != null) ? el1.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "int_literal"

    public class double_literal_return : ParserRuleReturnScope
    {
        public DoubleElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "double_literal"
    // Interp.g:67:1: double_literal returns [DoubleElement ret] : el1= DOUBLE_LITERAL ;
    public InterpParser.double_literal_return double_literal() // throws RecognitionException [1]
    {   
        InterpParser.double_literal_return retval = new InterpParser.double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;

        object el1_tree=null;


        	retval.ret = new DoubleElement();
        	
        try 
    	{
            // Interp.g:71:2: (el1= DOUBLE_LITERAL )
            // Interp.g:72:3: el1= DOUBLE_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_double_literal310); 
            		el1_tree = (object)adaptor.Create(el1);
            		adaptor.AddChild(root_0, el1_tree);

            	retval.ret.setText(((el1 != null) ? el1.Text : null));

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "double_literal"

    public class variable_return : ParserRuleReturnScope
    {
        public VariableElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variable"
    // Interp.g:74:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE20 = null;

        object VARIABLE20_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // Interp.g:78:3: ( VARIABLE )
            // Interp.g:78:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE20=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable334); 
            		VARIABLE20_tree = (object)adaptor.Create(VARIABLE20);
            		adaptor.AddChild(root_0, VARIABLE20_tree);

            	retval.ret.setText(((VARIABLE20 != null) ? VARIABLE20.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class matrixvardec_return : ParserRuleReturnScope
    {
        public MatrixVariableDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixvardec"
    // Interp.g:80:1: matrixvardec returns [MatrixVariableDeclaration ret] : ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']' ) END_OF_STATEMENT ;
    public InterpParser.matrixvardec_return matrixvardec() // throws RecognitionException [1]
    {   
        InterpParser.matrixvardec_return retval = new InterpParser.matrixvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal21 = null;
        IToken char_literal22 = null;
        IToken VARTYPE23 = null;
        IToken char_literal24 = null;
        IToken char_literal25 = null;
        IToken char_literal26 = null;
        IToken char_literal27 = null;
        IToken char_literal28 = null;
        IToken ASSIGNMENT29 = null;
        IToken char_literal30 = null;
        IToken char_literal31 = null;
        IToken char_literal32 = null;
        IToken char_literal33 = null;
        IToken END_OF_STATEMENT34 = null;
        InterpParser.int_literal_return el1 = null;

        InterpParser.int_literal_return el2 = null;

        InterpParser.variable_return el3 = null;

        InterpParser.int_literal_return el4 = null;

        InterpParser.double_literal_return el5 = null;

        InterpParser.int_literal_return el6 = null;

        InterpParser.double_literal_return el7 = null;


        object string_literal21_tree=null;
        object char_literal22_tree=null;
        object VARTYPE23_tree=null;
        object char_literal24_tree=null;
        object char_literal25_tree=null;
        object char_literal26_tree=null;
        object char_literal27_tree=null;
        object char_literal28_tree=null;
        object ASSIGNMENT29_tree=null;
        object char_literal30_tree=null;
        object char_literal31_tree=null;
        object char_literal32_tree=null;
        object char_literal33_tree=null;
        object END_OF_STATEMENT34_tree=null;


        	retval.ret = new MatrixVariableDeclaration();
        	
        try 
    	{
            // Interp.g:84:2: ( ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']' ) END_OF_STATEMENT )
            // Interp.g:84:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:84:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']' )
            	// Interp.g:84:4: 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']'
            	{
            		string_literal21=(IToken)Match(input,14,FOLLOW_14_in_matrixvardec357); 
            			string_literal21_tree = (object)adaptor.Create(string_literal21);
            			adaptor.AddChild(root_0, string_literal21_tree);

            		char_literal22=(IToken)Match(input,15,FOLLOW_15_in_matrixvardec359); 
            			char_literal22_tree = (object)adaptor.Create(char_literal22);
            			adaptor.AddChild(root_0, char_literal22_tree);

            		VARTYPE23=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixvardec361); 
            			VARTYPE23_tree = (object)adaptor.Create(VARTYPE23);
            			adaptor.AddChild(root_0, VARTYPE23_tree);

            		 retval.ret.setType(((VARTYPE23 != null) ? VARTYPE23.Text : null));
            		char_literal24=(IToken)Match(input,16,FOLLOW_16_in_matrixvardec364); 
            			char_literal24_tree = (object)adaptor.Create(char_literal24);
            			adaptor.AddChild(root_0, char_literal24_tree);

            		char_literal25=(IToken)Match(input,17,FOLLOW_17_in_matrixvardec366); 
            			char_literal25_tree = (object)adaptor.Create(char_literal25);
            			adaptor.AddChild(root_0, char_literal25_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec369);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            		char_literal26=(IToken)Match(input,18,FOLLOW_18_in_matrixvardec372); 
            			char_literal26_tree = (object)adaptor.Create(char_literal26);
            			adaptor.AddChild(root_0, char_literal26_tree);

            		char_literal27=(IToken)Match(input,17,FOLLOW_17_in_matrixvardec375); 
            			char_literal27_tree = (object)adaptor.Create(char_literal27);
            			adaptor.AddChild(root_0, char_literal27_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec379);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            		char_literal28=(IToken)Match(input,18,FOLLOW_18_in_matrixvardec382); 
            			char_literal28_tree = (object)adaptor.Create(char_literal28);
            			adaptor.AddChild(root_0, char_literal28_tree);

            		// Interp.g:86:3: (el3= variable )
            		// Interp.g:86:4: el3= variable
            		{
            			PushFollow(FOLLOW_variable_in_matrixvardec390);
            			el3 = variable();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el3.Tree);
            			 retval.ret.setVar(((el3 != null) ? el3.ret : null));

            		}

            		ASSIGNMENT29=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matrixvardec397); 
            			ASSIGNMENT29_tree = (object)adaptor.Create(ASSIGNMENT29);
            			adaptor.AddChild(root_0, ASSIGNMENT29_tree);

            		char_literal30=(IToken)Match(input,17,FOLLOW_17_in_matrixvardec401); 
            			char_literal30_tree = (object)adaptor.Create(char_literal30);
            			adaptor.AddChild(root_0, char_literal30_tree);

            		// Interp.g:88:6: ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* )
            		// Interp.g:88:7: (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )*
            		{
            			// Interp.g:88:7: (el4= int_literal | el5= double_literal )
            			int alt6 = 2;
            			int LA6_0 = input.LA(1);

            			if ( (LA6_0 == INT_LITERAL) )
            			{
            			    alt6 = 1;
            			}
            			else if ( (LA6_0 == DOUBLE_LITERAL) )
            			{
            			    alt6 = 2;
            			}
            			else 
            			{
            			    NoViableAltException nvae_d6s0 =
            			        new NoViableAltException("", 6, 0, input);

            			    throw nvae_d6s0;
            			}
            			switch (alt6) 
            			{
            			    case 1 :
            			        // Interp.g:88:8: el4= int_literal
            			        {
            			        	PushFollow(FOLLOW_int_literal_in_matrixvardec406);
            			        	el4 = int_literal();
            			        	state.followingStackPointer--;

            			        	adaptor.AddChild(root_0, el4.Tree);
            			        	retval.ret.addValue(((el4 != null) ? el4.ret : null));

            			        }
            			        break;
            			    case 2 :
            			        // Interp.g:88:57: el5= double_literal
            			        {
            			        	PushFollow(FOLLOW_double_literal_in_matrixvardec412);
            			        	el5 = double_literal();
            			        	state.followingStackPointer--;

            			        	adaptor.AddChild(root_0, el5.Tree);
            			        	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            			        }
            			        break;

            			}

            			// Interp.g:89:3: ( ',' el6= int_literal | ',' el7= double_literal )*
            			do 
            			{
            			    int alt7 = 3;
            			    int LA7_0 = input.LA(1);

            			    if ( (LA7_0 == 19) )
            			    {
            			        int LA7_2 = input.LA(2);

            			        if ( (LA7_2 == INT_LITERAL) )
            			        {
            			            alt7 = 1;
            			        }
            			        else if ( (LA7_2 == DOUBLE_LITERAL) )
            			        {
            			            alt7 = 2;
            			        }


            			    }


            			    switch (alt7) 
            				{
            					case 1 :
            					    // Interp.g:89:4: ',' el6= int_literal
            					    {
            					    	char_literal31=(IToken)Match(input,19,FOLLOW_19_in_matrixvardec420); 
            					    		char_literal31_tree = (object)adaptor.Create(char_literal31);
            					    		adaptor.AddChild(root_0, char_literal31_tree);

            					    	PushFollow(FOLLOW_int_literal_in_matrixvardec423);
            					    	el6 = int_literal();
            					    	state.followingStackPointer--;

            					    	adaptor.AddChild(root_0, el6.Tree);
            					    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

            					    }
            					    break;
            					case 2 :
            					    // Interp.g:89:56: ',' el7= double_literal
            					    {
            					    	char_literal32=(IToken)Match(input,19,FOLLOW_19_in_matrixvardec427); 
            					    		char_literal32_tree = (object)adaptor.Create(char_literal32);
            					    		adaptor.AddChild(root_0, char_literal32_tree);

            					    	PushFollow(FOLLOW_double_literal_in_matrixvardec430);
            					    	el7 = double_literal();
            					    	state.followingStackPointer--;

            					    	adaptor.AddChild(root_0, el7.Tree);
            					    	retval.ret.addValue(((el7 != null) ? el7.ret : null));

            					    }
            					    break;

            					default:
            					    goto loop7;
            			    }
            			} while (true);

            			loop7:
            				;	// Stops C# compiler whining that label 'loop7' has no statements


            		}

            		char_literal33=(IToken)Match(input,18,FOLLOW_18_in_matrixvardec436); 
            			char_literal33_tree = (object)adaptor.Create(char_literal33);
            			adaptor.AddChild(root_0, char_literal33_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT34=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matrixvardec442); 
            		END_OF_STATEMENT34_tree = (object)adaptor.Create(END_OF_STATEMENT34);
            		adaptor.AddChild(root_0, END_OF_STATEMENT34_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "matrixvardec"

    public class vectorvardec_return : ParserRuleReturnScope
    {
        public VectorVariableDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "vectorvardec"
    // Interp.g:92:1: vectorvardec returns [VectorVariableDeclaration ret] : ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']' ) END_OF_STATEMENT ;
    public InterpParser.vectorvardec_return vectorvardec() // throws RecognitionException [1]
    {   
        InterpParser.vectorvardec_return retval = new InterpParser.vectorvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal35 = null;
        IToken char_literal36 = null;
        IToken VARTYPE37 = null;
        IToken char_literal38 = null;
        IToken char_literal39 = null;
        IToken char_literal40 = null;
        IToken ASSIGNMENT41 = null;
        IToken char_literal42 = null;
        IToken char_literal43 = null;
        IToken char_literal44 = null;
        IToken char_literal45 = null;
        IToken END_OF_STATEMENT46 = null;
        InterpParser.int_literal_return el1 = null;

        InterpParser.variable_return el2 = null;

        InterpParser.int_literal_return el3 = null;

        InterpParser.double_literal_return el4 = null;

        InterpParser.int_literal_return el5 = null;

        InterpParser.double_literal_return el6 = null;


        object string_literal35_tree=null;
        object char_literal36_tree=null;
        object VARTYPE37_tree=null;
        object char_literal38_tree=null;
        object char_literal39_tree=null;
        object char_literal40_tree=null;
        object ASSIGNMENT41_tree=null;
        object char_literal42_tree=null;
        object char_literal43_tree=null;
        object char_literal44_tree=null;
        object char_literal45_tree=null;
        object END_OF_STATEMENT46_tree=null;


        	retval.ret = new VectorVariableDeclaration();
        	
        try 
    	{
            // Interp.g:96:2: ( ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']' ) END_OF_STATEMENT )
            // Interp.g:96:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:96:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']' )
            	// Interp.g:96:4: 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']'
            	{
            		string_literal35=(IToken)Match(input,20,FOLLOW_20_in_vectorvardec460); 
            			string_literal35_tree = (object)adaptor.Create(string_literal35);
            			adaptor.AddChild(root_0, string_literal35_tree);

            		char_literal36=(IToken)Match(input,15,FOLLOW_15_in_vectorvardec462); 
            			char_literal36_tree = (object)adaptor.Create(char_literal36);
            			adaptor.AddChild(root_0, char_literal36_tree);

            		VARTYPE37=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorvardec464); 
            			VARTYPE37_tree = (object)adaptor.Create(VARTYPE37);
            			adaptor.AddChild(root_0, VARTYPE37_tree);

            		 retval.ret.setType(((VARTYPE37 != null) ? VARTYPE37.Text : null));
            		char_literal38=(IToken)Match(input,16,FOLLOW_16_in_vectorvardec467); 
            			char_literal38_tree = (object)adaptor.Create(char_literal38);
            			adaptor.AddChild(root_0, char_literal38_tree);

            		char_literal39=(IToken)Match(input,17,FOLLOW_17_in_vectorvardec469); 
            			char_literal39_tree = (object)adaptor.Create(char_literal39);
            			adaptor.AddChild(root_0, char_literal39_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorvardec472);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setRange(((el1 != null) ? el1.ret : null));
            		char_literal40=(IToken)Match(input,18,FOLLOW_18_in_vectorvardec475); 
            			char_literal40_tree = (object)adaptor.Create(char_literal40);
            			adaptor.AddChild(root_0, char_literal40_tree);

            		PushFollow(FOLLOW_variable_in_vectorvardec481);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setText(((el2 != null) ? el2.ret : null));
            		ASSIGNMENT41=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_vectorvardec488); 
            			ASSIGNMENT41_tree = (object)adaptor.Create(ASSIGNMENT41);
            			adaptor.AddChild(root_0, ASSIGNMENT41_tree);

            		char_literal42=(IToken)Match(input,17,FOLLOW_17_in_vectorvardec493); 
            			char_literal42_tree = (object)adaptor.Create(char_literal42);
            			adaptor.AddChild(root_0, char_literal42_tree);

            		// Interp.g:99:6: ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* )
            		// Interp.g:99:7: (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )*
            		{
            			// Interp.g:99:7: (el3= int_literal | el4= double_literal )
            			int alt8 = 2;
            			int LA8_0 = input.LA(1);

            			if ( (LA8_0 == INT_LITERAL) )
            			{
            			    alt8 = 1;
            			}
            			else if ( (LA8_0 == DOUBLE_LITERAL) )
            			{
            			    alt8 = 2;
            			}
            			else 
            			{
            			    NoViableAltException nvae_d8s0 =
            			        new NoViableAltException("", 8, 0, input);

            			    throw nvae_d8s0;
            			}
            			switch (alt8) 
            			{
            			    case 1 :
            			        // Interp.g:99:8: el3= int_literal
            			        {
            			        	PushFollow(FOLLOW_int_literal_in_vectorvardec498);
            			        	el3 = int_literal();
            			        	state.followingStackPointer--;

            			        	adaptor.AddChild(root_0, el3.Tree);
            			        	retval.ret.addValue(((el3 != null) ? el3.ret : null));

            			        }
            			        break;
            			    case 2 :
            			        // Interp.g:99:57: el4= double_literal
            			        {
            			        	PushFollow(FOLLOW_double_literal_in_vectorvardec504);
            			        	el4 = double_literal();
            			        	state.followingStackPointer--;

            			        	adaptor.AddChild(root_0, el4.Tree);
            			        	retval.ret.addValue(((el4 != null) ? el4.ret : null));

            			        }
            			        break;

            			}

            			// Interp.g:100:3: ( ',' el5= int_literal | ',' el6= double_literal )*
            			do 
            			{
            			    int alt9 = 3;
            			    int LA9_0 = input.LA(1);

            			    if ( (LA9_0 == 19) )
            			    {
            			        int LA9_2 = input.LA(2);

            			        if ( (LA9_2 == DOUBLE_LITERAL) )
            			        {
            			            alt9 = 2;
            			        }
            			        else if ( (LA9_2 == INT_LITERAL) )
            			        {
            			            alt9 = 1;
            			        }


            			    }


            			    switch (alt9) 
            				{
            					case 1 :
            					    // Interp.g:100:4: ',' el5= int_literal
            					    {
            					    	char_literal43=(IToken)Match(input,19,FOLLOW_19_in_vectorvardec512); 
            					    		char_literal43_tree = (object)adaptor.Create(char_literal43);
            					    		adaptor.AddChild(root_0, char_literal43_tree);

            					    	PushFollow(FOLLOW_int_literal_in_vectorvardec515);
            					    	el5 = int_literal();
            					    	state.followingStackPointer--;

            					    	adaptor.AddChild(root_0, el5.Tree);
            					    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            					    }
            					    break;
            					case 2 :
            					    // Interp.g:100:56: ',' el6= double_literal
            					    {
            					    	char_literal44=(IToken)Match(input,19,FOLLOW_19_in_vectorvardec519); 
            					    		char_literal44_tree = (object)adaptor.Create(char_literal44);
            					    		adaptor.AddChild(root_0, char_literal44_tree);

            					    	PushFollow(FOLLOW_double_literal_in_vectorvardec522);
            					    	el6 = double_literal();
            					    	state.followingStackPointer--;

            					    	adaptor.AddChild(root_0, el6.Tree);
            					    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

            					    }
            					    break;

            					default:
            					    goto loop9;
            			    }
            			} while (true);

            			loop9:
            				;	// Stops C# compiler whining that label 'loop9' has no statements


            		}

            		char_literal45=(IToken)Match(input,18,FOLLOW_18_in_vectorvardec528); 
            			char_literal45_tree = (object)adaptor.Create(char_literal45);
            			adaptor.AddChild(root_0, char_literal45_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT46=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_vectorvardec534); 
            		END_OF_STATEMENT46_tree = (object)adaptor.Create(END_OF_STATEMENT46);
            		adaptor.AddChild(root_0, END_OF_STATEMENT46_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "vectorvardec"

    public class addition_return : ParserRuleReturnScope
    {
        public AdditionOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "addition"
    // Interp.g:103:1: addition returns [AdditionOperationElement ret] : el1= var_int_or_double_literal '+' el2= var_int_or_double_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal47 = null;
        InterpParser.var_int_or_double_literal_return el1 = null;

        InterpParser.var_int_or_double_literal_return el2 = null;


        object char_literal47_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // Interp.g:107:3: (el1= var_int_or_double_literal '+' el2= var_int_or_double_literal )
            // Interp.g:107:5: el1= var_int_or_double_literal '+' el2= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_int_or_double_literal_in_addition561);
            	el1 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal47=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition570); 
            		char_literal47_tree = (object)adaptor.Create(char_literal47);
            		adaptor.AddChild(root_0, char_literal47_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_addition579);
            	el2 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "addition"

    public class multiplication_return : ParserRuleReturnScope
    {
        public MultiplicationOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplication"
    // Interp.g:111:1: multiplication returns [MultiplicationOperationElement ret] : el1= var_int_or_double_literal '*' el2= var_int_or_double_literal ;
    public InterpParser.multiplication_return multiplication() // throws RecognitionException [1]
    {   
        InterpParser.multiplication_return retval = new InterpParser.multiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal48 = null;
        InterpParser.var_int_or_double_literal_return el1 = null;

        InterpParser.var_int_or_double_literal_return el2 = null;


        object char_literal48_tree=null;


          retval.ret = new MultiplicationOperationElement();

        try 
    	{
            // Interp.g:115:3: (el1= var_int_or_double_literal '*' el2= var_int_or_double_literal )
            // Interp.g:115:5: el1= var_int_or_double_literal '*' el2= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplication606);
            	el1 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal48=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplication615); 
            		char_literal48_tree = (object)adaptor.Create(char_literal48);
            		adaptor.AddChild(root_0, char_literal48_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplication624);
            	el2 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	 retval.ret.setRhs(((el2 != null) ? el2.ret : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplication"

    public class structdec_return : ParserRuleReturnScope
    {
        public StructDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structdec"
    // Interp.g:119:1: structdec returns [StructDeclaration ret] : ( 'Struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT ;
    public InterpParser.structdec_return structdec() // throws RecognitionException [1]
    {   
        InterpParser.structdec_return retval = new InterpParser.structdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal49 = null;
        IToken char_literal51 = null;
        IToken char_literal52 = null;
        IToken END_OF_STATEMENT53 = null;
        InterpParser.scalarvardec_return el1 = null;

        InterpParser.variable_return variable50 = null;


        object string_literal49_tree=null;
        object char_literal51_tree=null;
        object char_literal52_tree=null;
        object END_OF_STATEMENT53_tree=null;


        	retval.ret = new StructDeclaration();
        	
        try 
    	{
            // Interp.g:123:2: ( ( 'Struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT )
            // Interp.g:123:4: ( 'Struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:123:4: ( 'Struct' variable '{' (el1= scalarvardec )+ '}' )
            	// Interp.g:123:5: 'Struct' variable '{' (el1= scalarvardec )+ '}'
            	{
            		string_literal49=(IToken)Match(input,21,FOLLOW_21_in_structdec653); 
            			string_literal49_tree = (object)adaptor.Create(string_literal49);
            			adaptor.AddChild(root_0, string_literal49_tree);

            		PushFollow(FOLLOW_variable_in_structdec655);
            		variable50 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable50.Tree);
            		 retval.ret.setName(((variable50 != null) ? variable50.ret : null));
            		char_literal51=(IToken)Match(input,22,FOLLOW_22_in_structdec660); 
            			char_literal51_tree = (object)adaptor.Create(char_literal51);
            			adaptor.AddChild(root_0, char_literal51_tree);

            		// Interp.g:124:6: (el1= scalarvardec )+
            		int cnt10 = 0;
            		do 
            		{
            		    int alt10 = 2;
            		    int LA10_0 = input.LA(1);

            		    if ( ((LA10_0 >= VARTYPE && LA10_0 <= STRINGTYPE)) )
            		    {
            		        alt10 = 1;
            		    }


            		    switch (alt10) 
            			{
            				case 1 :
            				    // Interp.g:124:7: el1= scalarvardec
            				    {
            				    	PushFollow(FOLLOW_scalarvardec_in_structdec665);
            				    	el1 = scalarvardec();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	 retval.ret.setVarType(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    if ( cnt10 >= 1 ) goto loop10;
            			            EarlyExitException eee10 =
            			                new EarlyExitException(10, input);
            			            throw eee10;
            		    }
            		    cnt10++;
            		} while (true);

            		loop10:
            			;	// Stops C# compiler whining that label 'loop10' has no statements

            		char_literal52=(IToken)Match(input,23,FOLLOW_23_in_structdec672); 
            			char_literal52_tree = (object)adaptor.Create(char_literal52);
            			adaptor.AddChild(root_0, char_literal52_tree);


            	}

            	END_OF_STATEMENT53=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec674); 
            		END_OF_STATEMENT53_tree = (object)adaptor.Create(END_OF_STATEMENT53);
            		adaptor.AddChild(root_0, END_OF_STATEMENT53_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "structdec"

    public class scalarvardec_return : ParserRuleReturnScope
    {
        public ScalarVariableDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "scalarvardec"
    // Interp.g:127:1: scalarvardec returns [ScalarVariableDeclaration ret] : ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT ;
    public InterpParser.scalarvardec_return scalarvardec() // throws RecognitionException [1]
    {   
        InterpParser.scalarvardec_return retval = new InterpParser.scalarvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE54 = null;
        IToken STRINGTYPE55 = null;
        IToken END_OF_STATEMENT57 = null;
        InterpParser.variable_return variable56 = null;


        object VARTYPE54_tree=null;
        object STRINGTYPE55_tree=null;
        object END_OF_STATEMENT57_tree=null;


        	retval.ret = new ScalarVariableDeclaration();
        	
        try 
    	{
            // Interp.g:131:2: ( ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT )
            // Interp.g:131:3: ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:131:3: ( ( VARTYPE | STRINGTYPE ) variable )
            	// Interp.g:131:4: ( VARTYPE | STRINGTYPE ) variable
            	{
            		// Interp.g:131:4: ( VARTYPE | STRINGTYPE )
            		int alt11 = 2;
            		int LA11_0 = input.LA(1);

            		if ( (LA11_0 == VARTYPE) )
            		{
            		    alt11 = 1;
            		}
            		else if ( (LA11_0 == STRINGTYPE) )
            		{
            		    alt11 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d11s0 =
            		        new NoViableAltException("", 11, 0, input);

            		    throw nvae_d11s0;
            		}
            		switch (alt11) 
            		{
            		    case 1 :
            		        // Interp.g:131:5: VARTYPE
            		        {
            		        	VARTYPE54=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarvardec695); 
            		        		VARTYPE54_tree = (object)adaptor.Create(VARTYPE54);
            		        		adaptor.AddChild(root_0, VARTYPE54_tree);

            		        	 retval.ret.setType(((VARTYPE54 != null) ? VARTYPE54.Text : null));

            		        }
            		        break;
            		    case 2 :
            		        // Interp.g:132:4: STRINGTYPE
            		        {
            		        	STRINGTYPE55=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_scalarvardec702); 
            		        		STRINGTYPE55_tree = (object)adaptor.Create(STRINGTYPE55);
            		        		adaptor.AddChild(root_0, STRINGTYPE55_tree);

            		        	 retval.ret.setType(((STRINGTYPE55 != null) ? STRINGTYPE55.Text : null));

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_variable_in_scalarvardec709);
            		variable56 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable56.Tree);
            		 retval.ret.setVar(((variable56 != null) ? variable56.ret : null));

            	}

            	END_OF_STATEMENT57=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_scalarvardec713); 
            		END_OF_STATEMENT57_tree = (object)adaptor.Create(END_OF_STATEMENT57);
            		adaptor.AddChild(root_0, END_OF_STATEMENT57_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "scalarvardec"

    public class structobjdec_return : ParserRuleReturnScope
    {
        public StructObjectDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structobjdec"
    // Interp.g:135:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
    public InterpParser.structobjdec_return structobjdec() // throws RecognitionException [1]
    {   
        InterpParser.structobjdec_return retval = new InterpParser.structobjdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT58 = null;
        InterpParser.variable_return el1 = null;

        InterpParser.variable_return el2 = null;


        object END_OF_STATEMENT58_tree=null;


        	retval.ret = new StructObjectDeclaration();
        	
        try 
    	{
            // Interp.g:139:2: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            // Interp.g:139:4: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:139:4: (el1= variable el2= variable )
            	// Interp.g:139:5: el1= variable el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structobjdec735);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		PushFollow(FOLLOW_variable_in_structobjdec744);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	END_OF_STATEMENT58=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec752); 
            		END_OF_STATEMENT58_tree = (object)adaptor.Create(END_OF_STATEMENT58);
            		adaptor.AddChild(root_0, END_OF_STATEMENT58_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "structobjdec"

    public class structassign_return : ParserRuleReturnScope
    {
        public StructAssignDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structassign"
    // Interp.g:143:1: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
    public InterpParser.structassign_return structassign() // throws RecognitionException [1]
    {   
        InterpParser.structassign_return retval = new InterpParser.structassign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal59 = null;
        InterpParser.variable_return el1 = null;

        InterpParser.variable_return el2 = null;


        object char_literal59_tree=null;


        	retval.ret = new StructAssignDeclaration();
        	
        try 
    	{
            // Interp.g:147:2: ( (el1= variable '.' el2= variable ) )
            // Interp.g:147:3: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:147:3: (el1= variable '.' el2= variable )
            	// Interp.g:147:4: el1= variable '.' el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structassign775);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setName(((el1 != null) ? el1.ret : null));
            		char_literal59=(IToken)Match(input,24,FOLLOW_24_in_structassign778); 
            			char_literal59_tree = (object)adaptor.Create(char_literal59);
            			adaptor.AddChild(root_0, char_literal59_tree);

            		PushFollow(FOLLOW_variable_in_structassign781);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setObj(((el2 != null) ? el2.ret : null));

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "structassign"

    public class deletionofvar_return : ParserRuleReturnScope
    {
        public DeleteVariable ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "deletionofvar"
    // Interp.g:149:1: deletionofvar returns [DeleteVariable ret] : ( 'delete' el1= variable ) END_OF_STATEMENT ;
    public InterpParser.deletionofvar_return deletionofvar() // throws RecognitionException [1]
    {   
        InterpParser.deletionofvar_return retval = new InterpParser.deletionofvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal60 = null;
        IToken END_OF_STATEMENT61 = null;
        InterpParser.variable_return el1 = null;


        object string_literal60_tree=null;
        object END_OF_STATEMENT61_tree=null;


        	retval.ret = new DeleteVariable();
        	
        try 
    	{
            // Interp.g:153:2: ( ( 'delete' el1= variable ) END_OF_STATEMENT )
            // Interp.g:153:3: ( 'delete' el1= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:153:3: ( 'delete' el1= variable )
            	// Interp.g:153:4: 'delete' el1= variable
            	{
            		string_literal60=(IToken)Match(input,25,FOLLOW_25_in_deletionofvar802); 
            			string_literal60_tree = (object)adaptor.Create(string_literal60);
            			adaptor.AddChild(root_0, string_literal60_tree);

            		PushFollow(FOLLOW_variable_in_deletionofvar806);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setVar(((el1 != null) ? el1.ret : null));

            	}

            	END_OF_STATEMENT61=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_deletionofvar810); 
            		END_OF_STATEMENT61_tree = (object)adaptor.Create(END_OF_STATEMENT61);
            		adaptor.AddChild(root_0, END_OF_STATEMENT61_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "deletionofvar"

    public class print_return : ParserRuleReturnScope
    {
        public PrintOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "print"
    // Interp.g:155:1: print returns [PrintOperationElement ret] : 'print' var_int_or_double_literal END_OF_STATEMENT ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal62 = null;
        IToken END_OF_STATEMENT64 = null;
        InterpParser.var_int_or_double_literal_return var_int_or_double_literal63 = null;


        object string_literal62_tree=null;
        object END_OF_STATEMENT64_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // Interp.g:159:3: ( 'print' var_int_or_double_literal END_OF_STATEMENT )
            // Interp.g:159:5: 'print' var_int_or_double_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal62=(IToken)Match(input,26,FOLLOW_26_in_print835); 
            		string_literal62_tree = (object)adaptor.Create(string_literal62);
            		adaptor.AddChild(root_0, string_literal62_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_print837);
            	var_int_or_double_literal63 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal63.Tree);
            	retval.ret.setChildElement(((var_int_or_double_literal63 != null) ? var_int_or_double_literal63.ret : null)); 
            	END_OF_STATEMENT64=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print845); 
            		END_OF_STATEMENT64_tree = (object)adaptor.Create(END_OF_STATEMENT64);
            		adaptor.AddChild(root_0, END_OF_STATEMENT64_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "print"

    // Delegated rules


   	protected DFA2 dfa2;
	private void InitializeCyclicDFAs()
	{
    	this.dfa2 = new DFA2(this);
	}

    const string DFA2_eotS =
        "\x0a\uffff";
    const string DFA2_eofS =
        "\x0a\uffff";
    const string DFA2_minS =
        "\x01\x08\x01\x04\x08\uffff";
    const string DFA2_maxS =
        "\x01\x1a\x01\x18\x08\uffff";
    const string DFA2_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\x07\x01\x01";
    const string DFA2_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA2_transitionS = {
            "\x01\x01\x02\x02\x03\uffff\x01\x04\x05\uffff\x01\x03\x01\x06"+
            "\x03\uffff\x01\x05\x01\x07",
            "\x01\x09\x03\uffff\x01\x08\x0f\uffff\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA2_eot = DFA.UnpackEncodedString(DFA2_eotS);
    static readonly short[] DFA2_eof = DFA.UnpackEncodedString(DFA2_eofS);
    static readonly char[] DFA2_min = DFA.UnpackEncodedStringToUnsignedChars(DFA2_minS);
    static readonly char[] DFA2_max = DFA.UnpackEncodedStringToUnsignedChars(DFA2_maxS);
    static readonly short[] DFA2_accept = DFA.UnpackEncodedString(DFA2_acceptS);
    static readonly short[] DFA2_special = DFA.UnpackEncodedString(DFA2_specialS);
    static readonly short[][] DFA2_transition = DFA.UnpackEncodedStringArray(DFA2_transitionS);

    protected class DFA2 : DFA
    {
        public DFA2(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 2;
            this.eot = DFA2_eot;
            this.eof = DFA2_eof;
            this.min = DFA2_min;
            this.max = DFA2_max;
            this.accept = DFA2_accept;
            this.special = DFA2_special;
            this.transition = DFA2_transition;

        }

        override public string Description
        {
            get { return "34:1: expr returns [Element ret] : ( assignment | scalarvardec | vectorvardec | matrixvardec | deletionofvar | structdec | structobjdec | print );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program74 = new BitSet(new ulong[]{0x0000000006304702UL});
    public static readonly BitSet FOLLOW_assignment_in_expr92 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_expr100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_expr108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_expr116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_expr124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr140 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment170 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment178 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment185 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_assignment193 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_addition_in_assignment203 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_multiplication_in_assignment213 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_int_or_double_literal239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_int_or_double_literal250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_double_literal_in_var_int_or_double_literal260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal286 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_double_literal310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_14_in_matrixvardec357 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_15_in_matrixvardec359 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixvardec361 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_16_in_matrixvardec364 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_matrixvardec366 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec369 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_matrixvardec372 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_matrixvardec375 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec379 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_matrixvardec382 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_variable_in_matrixvardec390 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matrixvardec397 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_matrixvardec401 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec406 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec412 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_19_in_matrixvardec420 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec423 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_19_in_matrixvardec427 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec430 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_18_in_matrixvardec436 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matrixvardec442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_vectorvardec460 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_15_in_vectorvardec462 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorvardec464 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_16_in_vectorvardec467 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_vectorvardec469 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec472 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_vectorvardec475 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_variable_in_vectorvardec481 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_vectorvardec488 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_vectorvardec493 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec498 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec504 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_19_in_vectorvardec512 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec515 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_19_in_vectorvardec519 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec522 = new BitSet(new ulong[]{0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_18_in_vectorvardec528 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_vectorvardec534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_addition561 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition570 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_addition579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplication606 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplication615 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplication624 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_structdec653 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_variable_in_structdec655 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_structdec660 = new BitSet(new ulong[]{0x0000000000000600UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_structdec665 = new BitSet(new ulong[]{0x0000000000800600UL});
    public static readonly BitSet FOLLOW_23_in_structdec672 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarvardec695 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_scalarvardec702 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_variable_in_scalarvardec709 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_scalarvardec713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec735 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec744 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec752 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign775 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_structassign778 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_variable_in_structassign781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_deletionofvar802 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_variable_in_deletionofvar806 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_deletionofvar810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_print835 = new BitSet(new ulong[]{0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_print837 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print845 = new BitSet(new ulong[]{0x0000000000000002UL});

}
