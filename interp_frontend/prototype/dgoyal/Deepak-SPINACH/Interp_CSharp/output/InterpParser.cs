// $ANTLR 3.1.2 C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g 2009-10-26 01:14:29

#define ANTLR_DEBUG

using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


using Antlr.Runtime.Debug;
using IOException = System.IO.IOException;

using Antlr.Runtime.Tree;

public class InterpParser : DebugParser 
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
		"VARIABLE", 
		"TYPE", 
		"WHITESPACE", 
		"PLUS", 
		"MULTIPLY", 
		"'('", 
		"')'", 
		"'['", 
		"']'", 
		"'Struct'", 
		"'{'", 
		"'}'", 
		"'.'", 
		"'print'"
    };

    public const int INT_LITERAL = 6;
    public const int T__20 = 20;
    public const int WHITESPACE = 9;
    public const int EOF = -1;
    public const int TYPE = 8;
    public const int T__19 = 19;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int T__18 = 18;
    public const int VARIABLE = 7;
    public const int T__17 = 17;
    public const int MULTIPLY = 11;
    public const int T__12 = 12;
    public const int T__14 = 14;
    public const int T__13 = 13;
    public const int PLUS = 10;
    public const int ASSIGNMENT = 4;
    public const int END_OF_STATEMENT = 5;

    // delegates
    // delegators

    public static readonly string[] ruleNames = new string[] {
        "invalidRule", "var_or_int_literal", "structobjdec", "assignment", 
        "int_literal", "structvardec", "variable", "print", "structassign", 
        "multiplication", "structdec", "expr", "matrixoperation", "addition", 
        "program"
    };
     
        private int ruleLevel = 0;
        public int RuleLevel {
    	get { return ruleLevel; }
        }
        public void IncRuleLevel() { ruleLevel++; }
        public void DecRuleLevel() { ruleLevel--; }
        public InterpParser(ITokenStream input)
            : this(input, DebugEventSocketProxy.DEFAULT_DEBUGGER_PORT, new RecognizerSharedState()) {
        }

        public InterpParser(ITokenStream input, int port, RecognizerSharedState state)
            : base(input, state) {
            InitializeCyclicDFAs();

            DebugEventSocketProxy proxy = new DebugEventSocketProxy(this, port, adaptor);
            DebugListener = proxy;
            TokenStream = new DebugTokenStream(input,proxy);
            try {
                proxy.Handshake();
            } catch (IOException ioe) {
                ReportError(ioe);
            }
            ITreeAdaptor adap = new CommonTreeAdaptor();
            TreeAdaptor = adap;
            proxy.TreeAdaptor = adap;
        }
    public InterpParser(ITokenStream input, IDebugEventListener dbg)
        : base(input, dbg) {
        InitializeCyclicDFAs();

         
        ITreeAdaptor adap = new CommonTreeAdaptor();
        TreeAdaptor = adap;

    }
    protected bool EvalPredicate(bool result, string predicate) 
    {
        dbg.SemanticPredicate(result, predicate);
        return result;
    }

    protected DebugTreeAdaptor adaptor;
    public ITreeAdaptor TreeAdaptor
    {
    	get { 
    		return this.adaptor;

    	}
    	set { this.adaptor = new DebugTreeAdaptor(dbg, value); }
    }


    override public string[] TokenNames {
		get { return InterpParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g"; }
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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:29:1: program returns [List<Element> ret] : ( expr )+ ;
    public InterpParser.program_return program() // throws RecognitionException [1]
    {   
        InterpParser.program_return retval = new InterpParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try {
        	dbg.EnterRule(GrammarFileName, "program");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(29, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:33:3: ( ( expr )+ )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:33:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(33,5);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:33:5: ( expr )+
            	int cnt1 = 0;
            	try { dbg.EnterSubRule(1);

            	do 
            	{
            	    int alt1 = 2;
            	    try { dbg.EnterDecision(1);

            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || LA1_0 == 16 || LA1_0 == 20) )
            	    {
            	        alt1 = 1;
            	    }


            	    } finally { dbg.ExitDecision(1); }

            	    switch (alt1) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);

            			    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:33:6: expr
            			    {
            			    	dbg.Location(33,6);
            			    	PushFollow(FOLLOW_expr_in_program74);
            			    	expr1 = expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1.Tree);
            			    	dbg.Location(33,11);
            			    	retval.ret.Add(((expr1 != null) ? expr1.ret : null)); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            dbg.RecognitionException(eee);

            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whinging that label 'loop1' has no statements
            	} finally { dbg.ExitSubRule(1); }


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
        dbg.Location(33, 43);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "program");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:34:1: expr returns [Element ret] : ( assignment | structdec | structobjdec | print );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.structdec_return structdec3 = null;

        InterpParser.structobjdec_return structobjdec4 = null;

        InterpParser.print_return print5 = null;



        try {
        	dbg.EnterRule(GrammarFileName, "expr");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(34, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:35:3: ( assignment | structdec | structobjdec | print )
            int alt2 = 4;
            try { dbg.EnterDecision(2);

            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                int LA2_1 = input.LA(2);

                if ( (LA2_1 == ASSIGNMENT || LA2_1 == 19) )
                {
                    alt2 = 1;
                }
                else if ( (LA2_1 == VARIABLE) )
                {
                    alt2 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("", 2, 1, input);

                    dbg.RecognitionException(nvae_d2s1);
                    throw nvae_d2s1;
                }
                }
                break;
            case 16:
            	{
                alt2 = 2;
                }
                break;
            case 20:
            	{
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    dbg.RecognitionException(nvae_d2s0);
            	    throw nvae_d2s0;
            }

            } finally { dbg.ExitDecision(2); }

            switch (alt2) 
            {
                case 1 :
                    dbg.EnterAlt(1);

                    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:35:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	dbg.Location(35,5);
                    	PushFollow(FOLLOW_assignment_in_expr92);
                    	assignment2 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment2.Tree);
                    	dbg.Location(35,16);
                    	retval.ret = ((assignment2 != null) ? assignment2.ret : null);

                    }
                    break;
                case 2 :
                    dbg.EnterAlt(2);

                    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:36:5: structdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	dbg.Location(36,5);
                    	PushFollow(FOLLOW_structdec_in_expr100);
                    	structdec3 = structdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structdec3.Tree);
                    	dbg.Location(36,15);
                    	retval.ret = ((structdec3 != null) ? structdec3.ret : null);

                    }
                    break;
                case 3 :
                    dbg.EnterAlt(3);

                    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:37:5: structobjdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	dbg.Location(37,5);
                    	PushFollow(FOLLOW_structobjdec_in_expr108);
                    	structobjdec4 = structobjdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structobjdec4.Tree);
                    	dbg.Location(37,18);
                    	 retval.ret = ((structobjdec4 != null) ? structobjdec4.ret : null);

                    }
                    break;
                case 4 :
                    dbg.EnterAlt(4);

                    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:38:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	dbg.Location(38,5);
                    	PushFollow(FOLLOW_print_in_expr116);
                    	print5 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print5.Tree);
                    	dbg.Location(38,11);
                    	 retval.ret = ((print5 != null) ? print5.ret : null); 

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
        dbg.Location(38, 39);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "expr");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:40:1: assignment returns [AssignmentOperationElement ret] : ( variable | structassign ) ASSIGNMENT ( var_or_int_literal | matrixoperation | addition | multiplication ) END_OF_STATEMENT ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT8 = null;
        IToken END_OF_STATEMENT13 = null;
        InterpParser.variable_return variable6 = null;

        InterpParser.structassign_return structassign7 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal9 = null;

        InterpParser.matrixoperation_return matrixoperation10 = null;

        InterpParser.addition_return addition11 = null;

        InterpParser.multiplication_return multiplication12 = null;


        object ASSIGNMENT8_tree=null;
        object END_OF_STATEMENT13_tree=null;


          retval.ret = new AssignmentOperationElement();

        try {
        	dbg.EnterRule(GrammarFileName, "assignment");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(40, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:44:3: ( ( variable | structassign ) ASSIGNMENT ( var_or_int_literal | matrixoperation | addition | multiplication ) END_OF_STATEMENT )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:44:5: ( variable | structassign ) ASSIGNMENT ( var_or_int_literal | matrixoperation | addition | multiplication ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(44,5);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:44:5: ( variable | structassign )
            	int alt3 = 2;
            	try { dbg.EnterSubRule(3);
            	try { dbg.EnterDecision(3);

            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == VARIABLE) )
            	{
            	    int LA3_1 = input.LA(2);

            	    if ( (LA3_1 == ASSIGNMENT) )
            	    {
            	        alt3 = 1;
            	    }
            	    else if ( (LA3_1 == 19) )
            	    {
            	        alt3 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d3s1 =
            	            new NoViableAltException("", 3, 1, input);

            	        dbg.RecognitionException(nvae_d3s1);
            	        throw nvae_d3s1;
            	    }
            	}
            	else 
            	{
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    dbg.RecognitionException(nvae_d3s0);
            	    throw nvae_d3s0;
            	}
            	} finally { dbg.ExitDecision(3); }

            	switch (alt3) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);

            	        // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:44:6: variable
            	        {
            	        	dbg.Location(44,6);
            	        	PushFollow(FOLLOW_variable_in_assignment138);
            	        	variable6 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable6.Tree);
            	        	dbg.Location(44,15);
            	        	retval.ret.setLhs(((variable6 != null) ? variable6.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        dbg.EnterAlt(2);

            	        // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:45:5: structassign
            	        {
            	        	dbg.Location(45,5);
            	        	PushFollow(FOLLOW_structassign_in_assignment146);
            	        	structassign7 = structassign();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structassign7.Tree);
            	        	dbg.Location(45,18);
            	        	retval.ret.setStructLhs(((structassign7 != null) ? structassign7.ret : null));

            	        }
            	        break;

            	}
            	} finally { dbg.ExitSubRule(3); }

            	dbg.Location(46,3);
            	ASSIGNMENT8=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment153); 
            		ASSIGNMENT8_tree = (object)adaptor.Create(ASSIGNMENT8);
            		adaptor.AddChild(root_0, ASSIGNMENT8_tree);

            	dbg.Location(47,5);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:47:5: ( var_or_int_literal | matrixoperation | addition | multiplication )
            	int alt4 = 4;
            	try { dbg.EnterSubRule(4);
            	try { dbg.EnterDecision(4);

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
            	        alt4 = 4;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt4 = 3;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d4s1 =
            	    	        new NoViableAltException("", 4, 1, input);

            	    	    dbg.RecognitionException(nvae_d4s1);
            	    	    throw nvae_d4s1;
            	    }

            	    }
            	    break;
            	case INT_LITERAL:
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
            	        alt4 = 4;
            	        }
            	        break;
            	    case PLUS:
            	    	{
            	        alt4 = 3;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d4s2 =
            	    	        new NoViableAltException("", 4, 2, input);

            	    	    dbg.RecognitionException(nvae_d4s2);
            	    	    throw nvae_d4s2;
            	    }

            	    }
            	    break;
            	case 12:
            		{
            	    alt4 = 2;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d4s0 =
            		        new NoViableAltException("", 4, 0, input);

            		    dbg.RecognitionException(nvae_d4s0);
            		    throw nvae_d4s0;
            	}

            	} finally { dbg.ExitDecision(4); }

            	switch (alt4) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);

            	        // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:47:6: var_or_int_literal
            	        {
            	        	dbg.Location(47,6);
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment161);
            	        	var_or_int_literal9 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal9.Tree);
            	        	dbg.Location(47,25);
            	        	retval.ret.setRhs(((var_or_int_literal9 != null) ? var_or_int_literal9.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        dbg.EnterAlt(2);

            	        // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:48:7: matrixoperation
            	        {
            	        	dbg.Location(48,7);
            	        	PushFollow(FOLLOW_matrixoperation_in_assignment171);
            	        	matrixoperation10 = matrixoperation();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixoperation10.Tree);
            	        	dbg.Location(48,23);
            	        	 retval.ret.setRhs(((matrixoperation10 != null) ? matrixoperation10.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        dbg.EnterAlt(3);

            	        // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:49:7: addition
            	        {
            	        	dbg.Location(49,7);
            	        	PushFollow(FOLLOW_addition_in_assignment182);
            	        	addition11 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition11.Tree);
            	        	dbg.Location(49,16);
            	        	retval.ret.setRhs(((addition11 != null) ? addition11.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        dbg.EnterAlt(4);

            	        // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:50:7: multiplication
            	        {
            	        	dbg.Location(50,7);
            	        	PushFollow(FOLLOW_multiplication_in_assignment192);
            	        	multiplication12 = multiplication();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, multiplication12.Tree);
            	        	dbg.Location(50,22);
            	        	retval.ret.setRhs(((multiplication12 != null) ? multiplication12.ret : null));

            	        }
            	        break;

            	}
            	} finally { dbg.ExitSubRule(4); }

            	dbg.Location(51,7);
            	END_OF_STATEMENT13=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment202); 
            		END_OF_STATEMENT13_tree = (object)adaptor.Create(END_OF_STATEMENT13);
            		adaptor.AddChild(root_0, END_OF_STATEMENT13_tree);


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
        dbg.Location(51, 23);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "assignment");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "assignment"

    public class var_or_int_literal_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "var_or_int_literal"
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:53:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable14 = null;

        InterpParser.int_literal_return int_literal15 = null;



        try {
        	dbg.EnterRule(GrammarFileName, "var_or_int_literal");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(53, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:54:3: ( ( variable | int_literal ) )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:54:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(54,6);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:54:6: ( variable | int_literal )
            	int alt5 = 2;
            	try { dbg.EnterSubRule(5);
            	try { dbg.EnterDecision(5);

            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == VARIABLE) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == INT_LITERAL) )
            	{
            	    alt5 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    dbg.RecognitionException(nvae_d5s0);
            	    throw nvae_d5s0;
            	}
            	} finally { dbg.ExitDecision(5); }

            	switch (alt5) 
            	{
            	    case 1 :
            	        dbg.EnterAlt(1);

            	        // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:54:7: variable
            	        {
            	        	dbg.Location(54,7);
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal218);
            	        	variable14 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable14.Tree);
            	        	dbg.Location(54,16);
            	        	 retval.ret = ((variable14 != null) ? variable14.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        dbg.EnterAlt(2);

            	        // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:55:7: int_literal
            	        {
            	        	dbg.Location(55,7);
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal229);
            	        	int_literal15 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal15.Tree);
            	        	dbg.Location(55,19);
            	        	retval.ret = ((int_literal15 != null) ? int_literal15.ret : null); 

            	        }
            	        break;

            	}
            	} finally { dbg.ExitSubRule(5); }


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
        dbg.Location(55, 53);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "var_or_int_literal");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "var_or_int_literal"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:57:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL16 = null;

        object INT_LITERAL16_tree=null;


          retval.ret = new IntegerElement();

        try {
        	dbg.EnterRule(GrammarFileName, "int_literal");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(57, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:61:3: ( INT_LITERAL )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:61:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(61,5);
            	INT_LITERAL16=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal253); 
            		INT_LITERAL16_tree = (object)adaptor.Create(INT_LITERAL16);
            		adaptor.AddChild(root_0, INT_LITERAL16_tree);

            	dbg.Location(61,17);
            	 retval.ret.setText(((INT_LITERAL16 != null) ? INT_LITERAL16.Text : null)); 

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
        dbg.Location(61, 59);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "int_literal");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "int_literal"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:63:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE17 = null;

        object VARIABLE17_tree=null;


          retval.ret = new VariableElement();

        try {
        	dbg.EnterRule(GrammarFileName, "variable");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(63, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:67:3: ( VARIABLE )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:67:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(67,5);
            	VARIABLE17=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable276); 
            		VARIABLE17_tree = (object)adaptor.Create(VARIABLE17);
            		adaptor.AddChild(root_0, VARIABLE17_tree);

            	dbg.Location(67,14);
            	retval.ret.setText(((VARIABLE17 != null) ? VARIABLE17.Text : null)); 

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
        dbg.Location(67, 52);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "variable");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "variable"

    public class matrixoperation_return : ParserRuleReturnScope
    {
        public MatrixOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixoperation"
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:69:1: matrixoperation returns [MatrixOperationElement ret] : ( '(' el1= int_literal ')' '(' el2= int_literal ')' '[' (el3= int_literal )+ ']' ) ;
    public InterpParser.matrixoperation_return matrixoperation() // throws RecognitionException [1]
    {   
        InterpParser.matrixoperation_return retval = new InterpParser.matrixoperation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal18 = null;
        IToken char_literal19 = null;
        IToken char_literal20 = null;
        IToken char_literal21 = null;
        IToken char_literal22 = null;
        IToken char_literal23 = null;
        InterpParser.int_literal_return el1 = null;

        InterpParser.int_literal_return el2 = null;

        InterpParser.int_literal_return el3 = null;


        object char_literal18_tree=null;
        object char_literal19_tree=null;
        object char_literal20_tree=null;
        object char_literal21_tree=null;
        object char_literal22_tree=null;
        object char_literal23_tree=null;


        	retval.ret = new MatrixOperationElement();
        	
        try {
        	dbg.EnterRule(GrammarFileName, "matrixoperation");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(69, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:73:2: ( ( '(' el1= int_literal ')' '(' el2= int_literal ')' '[' (el3= int_literal )+ ']' ) )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:73:3: ( '(' el1= int_literal ')' '(' el2= int_literal ')' '[' (el3= int_literal )+ ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(73,3);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:73:3: ( '(' el1= int_literal ')' '(' el2= int_literal ')' '[' (el3= int_literal )+ ']' )
            	dbg.EnterAlt(1);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:73:4: '(' el1= int_literal ')' '(' el2= int_literal ')' '[' (el3= int_literal )+ ']'
            	{
            		dbg.Location(73,4);
            		char_literal18=(IToken)Match(input,12,FOLLOW_12_in_matrixoperation299); 
            			char_literal18_tree = (object)adaptor.Create(char_literal18);
            			adaptor.AddChild(root_0, char_literal18_tree);

            		dbg.Location(73,10);
            		PushFollow(FOLLOW_int_literal_in_matrixoperation302);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		dbg.Location(73,23);
            		 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            		dbg.Location(73,54);
            		char_literal19=(IToken)Match(input,13,FOLLOW_13_in_matrixoperation305); 
            			char_literal19_tree = (object)adaptor.Create(char_literal19);
            			adaptor.AddChild(root_0, char_literal19_tree);

            		dbg.Location(74,2);
            		char_literal20=(IToken)Match(input,12,FOLLOW_12_in_matrixoperation308); 
            			char_literal20_tree = (object)adaptor.Create(char_literal20);
            			adaptor.AddChild(root_0, char_literal20_tree);

            		dbg.Location(74,9);
            		PushFollow(FOLLOW_int_literal_in_matrixoperation312);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		dbg.Location(74,22);
            		 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            		dbg.Location(74,56);
            		char_literal21=(IToken)Match(input,13,FOLLOW_13_in_matrixoperation315); 
            			char_literal21_tree = (object)adaptor.Create(char_literal21);
            			adaptor.AddChild(root_0, char_literal21_tree);

            		dbg.Location(75,2);
            		char_literal22=(IToken)Match(input,14,FOLLOW_14_in_matrixoperation318); 
            			char_literal22_tree = (object)adaptor.Create(char_literal22);
            			adaptor.AddChild(root_0, char_literal22_tree);

            		dbg.Location(75,5);
            		// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:75:5: (el3= int_literal )+
            		int cnt6 = 0;
            		try { dbg.EnterSubRule(6);

            		do 
            		{
            		    int alt6 = 2;
            		    try { dbg.EnterDecision(6);

            		    int LA6_0 = input.LA(1);

            		    if ( (LA6_0 == INT_LITERAL) )
            		    {
            		        alt6 = 1;
            		    }


            		    } finally { dbg.ExitDecision(6); }

            		    switch (alt6) 
            			{
            				case 1 :
            				    dbg.EnterAlt(1);

            				    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:75:6: el3= int_literal
            				    {
            				    	dbg.Location(75,9);
            				    	PushFollow(FOLLOW_int_literal_in_matrixoperation322);
            				    	el3 = int_literal();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el3.Tree);
            				    	dbg.Location(75,22);
            				    	 retval.ret.setValue(((el3 != null) ? el3.ret : null));

            				    }
            				    break;

            				default:
            				    if ( cnt6 >= 1 ) goto loop6;
            			            EarlyExitException eee6 =
            			                new EarlyExitException(6, input);
            			            dbg.RecognitionException(eee);

            			            throw eee6;
            		    }
            		    cnt6++;
            		} while (true);

            		loop6:
            			;	// Stops C# compiler whinging that label 'loop6' has no statements
            		} finally { dbg.ExitSubRule(6); }

            		dbg.Location(75,58);
            		char_literal23=(IToken)Match(input,15,FOLLOW_15_in_matrixoperation328); 
            			char_literal23_tree = (object)adaptor.Create(char_literal23);
            			adaptor.AddChild(root_0, char_literal23_tree);


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
        dbg.Location(75, 62);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "matrixoperation");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "matrixoperation"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:77:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal24 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal24_tree=null;


          retval.ret = new AdditionOperationElement();

        try {
        	dbg.EnterRule(GrammarFileName, "addition");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(77, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:81:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:81:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(81,8);
            	PushFollow(FOLLOW_var_or_int_literal_in_addition354);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	dbg.Location(81,28);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	dbg.Location(82,5);
            	char_literal24=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition363); 
            		char_literal24_tree = (object)adaptor.Create(char_literal24);
            		adaptor.AddChild(root_0, char_literal24_tree);

            	dbg.Location(83,8);
            	PushFollow(FOLLOW_var_or_int_literal_in_addition372);
            	el2 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	dbg.Location(83,28);
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
        dbg.Location(83, 60);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "addition");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:85:1: multiplication returns [MultiplicationOperationElement ret] : el1= var_or_int_literal '*' el2= var_or_int_literal ;
    public InterpParser.multiplication_return multiplication() // throws RecognitionException [1]
    {   
        InterpParser.multiplication_return retval = new InterpParser.multiplication_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal25 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal25_tree=null;


          retval.ret = new MultiplicationOperationElement();

        try {
        	dbg.EnterRule(GrammarFileName, "multiplication");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(85, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:89:3: (el1= var_or_int_literal '*' el2= var_or_int_literal )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:89:5: el1= var_or_int_literal '*' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(89,8);
            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication399);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	dbg.Location(89,28);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	dbg.Location(90,5);
            	char_literal25=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplication408); 
            		char_literal25_tree = (object)adaptor.Create(char_literal25);
            		adaptor.AddChild(root_0, char_literal25_tree);

            	dbg.Location(91,8);
            	PushFollow(FOLLOW_var_or_int_literal_in_multiplication417);
            	el2 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	dbg.Location(91,28);
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
        dbg.Location(91, 60);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "multiplication");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:93:1: structdec returns [StructDeclaration ret] : ( 'Struct' variable '{' (el1= structvardec )+ '}' ) END_OF_STATEMENT ;
    public InterpParser.structdec_return structdec() // throws RecognitionException [1]
    {   
        InterpParser.structdec_return retval = new InterpParser.structdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal26 = null;
        IToken char_literal28 = null;
        IToken char_literal29 = null;
        IToken END_OF_STATEMENT30 = null;
        InterpParser.structvardec_return el1 = null;

        InterpParser.variable_return variable27 = null;


        object string_literal26_tree=null;
        object char_literal28_tree=null;
        object char_literal29_tree=null;
        object END_OF_STATEMENT30_tree=null;


        	retval.ret = new StructDeclaration();
        	
        try {
        	dbg.EnterRule(GrammarFileName, "structdec");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(93, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:97:2: ( ( 'Struct' variable '{' (el1= structvardec )+ '}' ) END_OF_STATEMENT )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:97:4: ( 'Struct' variable '{' (el1= structvardec )+ '}' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(97,4);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:97:4: ( 'Struct' variable '{' (el1= structvardec )+ '}' )
            	dbg.EnterAlt(1);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:97:5: 'Struct' variable '{' (el1= structvardec )+ '}'
            	{
            		dbg.Location(97,5);
            		string_literal26=(IToken)Match(input,16,FOLLOW_16_in_structdec446); 
            			string_literal26_tree = (object)adaptor.Create(string_literal26);
            			adaptor.AddChild(root_0, string_literal26_tree);

            		dbg.Location(97,14);
            		PushFollow(FOLLOW_variable_in_structdec448);
            		variable27 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable27.Tree);
            		dbg.Location(97,23);
            		 retval.ret.setName(((variable27 != null) ? variable27.ret : null));
            		dbg.Location(98,2);
            		char_literal28=(IToken)Match(input,17,FOLLOW_17_in_structdec453); 
            			char_literal28_tree = (object)adaptor.Create(char_literal28);
            			adaptor.AddChild(root_0, char_literal28_tree);

            		dbg.Location(98,6);
            		// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:98:6: (el1= structvardec )+
            		int cnt7 = 0;
            		try { dbg.EnterSubRule(7);

            		do 
            		{
            		    int alt7 = 2;
            		    try { dbg.EnterDecision(7);

            		    int LA7_0 = input.LA(1);

            		    if ( (LA7_0 == TYPE) )
            		    {
            		        alt7 = 1;
            		    }


            		    } finally { dbg.ExitDecision(7); }

            		    switch (alt7) 
            			{
            				case 1 :
            				    dbg.EnterAlt(1);

            				    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:98:7: el1= structvardec
            				    {
            				    	dbg.Location(98,10);
            				    	PushFollow(FOLLOW_structvardec_in_structdec458);
            				    	el1 = structvardec();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	dbg.Location(98,24);
            				    	 retval.ret.setVarType(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    if ( cnt7 >= 1 ) goto loop7;
            			            EarlyExitException eee7 =
            			                new EarlyExitException(7, input);
            			            dbg.RecognitionException(eee);

            			            throw eee7;
            		    }
            		    cnt7++;
            		} while (true);

            		loop7:
            			;	// Stops C# compiler whinging that label 'loop7' has no statements
            		} finally { dbg.ExitSubRule(7); }

            		dbg.Location(99,2);
            		char_literal29=(IToken)Match(input,18,FOLLOW_18_in_structdec465); 
            			char_literal29_tree = (object)adaptor.Create(char_literal29);
            			adaptor.AddChild(root_0, char_literal29_tree);


            	}

            	dbg.Location(99,6);
            	END_OF_STATEMENT30=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec467); 
            		END_OF_STATEMENT30_tree = (object)adaptor.Create(END_OF_STATEMENT30);
            		adaptor.AddChild(root_0, END_OF_STATEMENT30_tree);


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
        dbg.Location(99, 22);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "structdec");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "structdec"

    public class structvardec_return : ParserRuleReturnScope
    {
        public StructVariableDeclaration ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "structvardec"
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:101:1: structvardec returns [StructVariableDeclaration ret] : ( TYPE WHITESPACE variable ';' ) ;
    public InterpParser.structvardec_return structvardec() // throws RecognitionException [1]
    {   
        InterpParser.structvardec_return retval = new InterpParser.structvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TYPE31 = null;
        IToken WHITESPACE32 = null;
        IToken char_literal34 = null;
        InterpParser.variable_return variable33 = null;


        object TYPE31_tree=null;
        object WHITESPACE32_tree=null;
        object char_literal34_tree=null;


        	retval.ret = new StructVariableDeclaration();
        	
        try {
        	dbg.EnterRule(GrammarFileName, "structvardec");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(101, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:105:2: ( ( TYPE WHITESPACE variable ';' ) )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:105:3: ( TYPE WHITESPACE variable ';' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(105,3);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:105:3: ( TYPE WHITESPACE variable ';' )
            	dbg.EnterAlt(1);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:105:4: TYPE WHITESPACE variable ';'
            	{
            		dbg.Location(105,4);
            		TYPE31=(IToken)Match(input,TYPE,FOLLOW_TYPE_in_structvardec487); 
            			TYPE31_tree = (object)adaptor.Create(TYPE31);
            			adaptor.AddChild(root_0, TYPE31_tree);

            		dbg.Location(105,9);
            		 retval.ret.setType(((TYPE31 != null) ? TYPE31.Text : null));
            		dbg.Location(106,2);
            		WHITESPACE32=(IToken)Match(input,WHITESPACE,FOLLOW_WHITESPACE_in_structvardec493); 
            			WHITESPACE32_tree = (object)adaptor.Create(WHITESPACE32);
            			adaptor.AddChild(root_0, WHITESPACE32_tree);

            		dbg.Location(106,13);
            		PushFollow(FOLLOW_variable_in_structvardec495);
            		variable33 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable33.Tree);
            		dbg.Location(106,22);
            		 retval.ret.setVar(((variable33 != null) ? variable33.ret : null));
            		dbg.Location(106,58);
            		char_literal34=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structvardec498); 
            			char_literal34_tree = (object)adaptor.Create(char_literal34);
            			adaptor.AddChild(root_0, char_literal34_tree);


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
        dbg.Location(106, 62);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "structvardec");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "structvardec"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:108:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
    public InterpParser.structobjdec_return structobjdec() // throws RecognitionException [1]
    {   
        InterpParser.structobjdec_return retval = new InterpParser.structobjdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT35 = null;
        InterpParser.variable_return el1 = null;

        InterpParser.variable_return el2 = null;


        object END_OF_STATEMENT35_tree=null;


        	retval.ret = new StructObjectDeclaration();
        	
        try {
        	dbg.EnterRule(GrammarFileName, "structobjdec");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(108, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:112:2: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:112:4: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(112,4);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:112:4: (el1= variable el2= variable )
            	dbg.EnterAlt(1);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:112:5: el1= variable el2= variable
            	{
            		dbg.Location(112,8);
            		PushFollow(FOLLOW_variable_in_structobjdec521);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		dbg.Location(112,18);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		dbg.Location(113,7);
            		PushFollow(FOLLOW_variable_in_structobjdec530);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		dbg.Location(113,17);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	dbg.Location(114,4);
            	END_OF_STATEMENT35=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec538); 
            		END_OF_STATEMENT35_tree = (object)adaptor.Create(END_OF_STATEMENT35);
            		adaptor.AddChild(root_0, END_OF_STATEMENT35_tree);


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
        dbg.Location(114, 20);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "structobjdec");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:116:1: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
    public InterpParser.structassign_return structassign() // throws RecognitionException [1]
    {   
        InterpParser.structassign_return retval = new InterpParser.structassign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal36 = null;
        InterpParser.variable_return el1 = null;

        InterpParser.variable_return el2 = null;


        object char_literal36_tree=null;


        	retval.ret = new StructAssignDeclaration();
        	
        try {
        	dbg.EnterRule(GrammarFileName, "structassign");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(116, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:120:2: ( (el1= variable '.' el2= variable ) )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:120:3: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(120,3);
            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:120:3: (el1= variable '.' el2= variable )
            	dbg.EnterAlt(1);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:120:4: el1= variable '.' el2= variable
            	{
            		dbg.Location(120,7);
            		PushFollow(FOLLOW_variable_in_structassign561);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		dbg.Location(120,17);
            		retval.ret.setName(((el1 != null) ? el1.ret : null));
            		dbg.Location(120,48);
            		char_literal36=(IToken)Match(input,19,FOLLOW_19_in_structassign564); 
            			char_literal36_tree = (object)adaptor.Create(char_literal36);
            			adaptor.AddChild(root_0, char_literal36_tree);

            		dbg.Location(120,54);
            		PushFollow(FOLLOW_variable_in_structassign567);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		dbg.Location(120,64);
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
        dbg.Location(120, 95);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "structassign");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "structassign"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:122:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal END_OF_STATEMENT ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal37 = null;
        IToken END_OF_STATEMENT39 = null;
        InterpParser.var_or_int_literal_return var_or_int_literal38 = null;


        object string_literal37_tree=null;
        object END_OF_STATEMENT39_tree=null;


          retval.ret = new PrintOperationElement();

        try {
        	dbg.EnterRule(GrammarFileName, "print");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(122, 1);

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:126:3: ( 'print' var_or_int_literal END_OF_STATEMENT )
            dbg.EnterAlt(1);

            // C:\\Documents and Settings\\Administrator\\Desktop\\SPINA\\Interp_CSharp\\Interp_CSharp\\Interp.g:126:5: 'print' var_or_int_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(126,5);
            	string_literal37=(IToken)Match(input,20,FOLLOW_20_in_print594); 
            		string_literal37_tree = (object)adaptor.Create(string_literal37);
            		adaptor.AddChild(root_0, string_literal37_tree);

            	dbg.Location(126,13);
            	PushFollow(FOLLOW_var_or_int_literal_in_print596);
            	var_or_int_literal38 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal38.Tree);
            	dbg.Location(126,32);
            	retval.ret.setChildElement(((var_or_int_literal38 != null) ? var_or_int_literal38.ret : null)); 
            	dbg.Location(127,5);
            	END_OF_STATEMENT39=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print604); 
            		END_OF_STATEMENT39_tree = (object)adaptor.Create(END_OF_STATEMENT39);
            		adaptor.AddChild(root_0, END_OF_STATEMENT39_tree);


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
        dbg.Location(127, 21);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "print");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "print"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_program74 = new BitSet(new ulong[]{0x0000000000110082UL});
    public static readonly BitSet FOLLOW_assignment_in_expr92 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr108 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment138 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment146 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment153 = new BitSet(new ulong[]{0x00000000000010C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_assignment161 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_matrixoperation_in_assignment171 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_addition_in_assignment182 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_multiplication_in_assignment192 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_matrixoperation299 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixoperation302 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_matrixoperation305 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_12_in_matrixoperation308 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixoperation312 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_matrixoperation315 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_14_in_matrixoperation318 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixoperation322 = new BitSet(new ulong[]{0x00000000000080C0UL});
    public static readonly BitSet FOLLOW_15_in_matrixoperation328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition354 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition363 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition372 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication399 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplication408 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_multiplication417 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_16_in_structdec446 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variable_in_structdec448 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_structdec453 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_structvardec_in_structdec458 = new BitSet(new ulong[]{0x0000000000040100UL});
    public static readonly BitSet FOLLOW_18_in_structdec465 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec467 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TYPE_in_structvardec487 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_WHITESPACE_in_structvardec493 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variable_in_structvardec495 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structvardec498 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec521 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec530 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign561 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_structassign564 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variable_in_structassign567 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_print594 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print596 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print604 = new BitSet(new ulong[]{0x0000000000000002UL});

}
