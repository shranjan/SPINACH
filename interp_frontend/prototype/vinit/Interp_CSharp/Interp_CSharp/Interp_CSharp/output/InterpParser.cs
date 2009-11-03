// $ANTLR 3.2 Sep 23, 2009 12:02:23 H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g 2009-10-26 20:47:03

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
		"VARIABLE", 
		"INT_LITERAL", 
		"TYPE", 
		"PLUS", 
		"WHITESPACE", 
		"'print'", 
		"'('", 
		"','", 
		"')'", 
		"'{'", 
		"'}'"
    };

    public const int INT_LITERAL = 7;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int VARIABLE = 6;
    public const int T__12 = 12;
    public const int T__11 = 11;
    public const int T__14 = 14;
    public const int T__13 = 13;
    public const int WHITESPACE = 10;
    public const int PLUS = 9;
    public const int ASSIGNMENT = 4;
    public const int EOF = -1;
    public const int END_OF_STATEMENT = 5;
    public const int TYPE = 8;

    // delegates
    // delegators

    public static readonly string[] ruleNames = new string[] {
        "invalidRule", "assignment", "print", "var_or_int_literal", "expr", 
        "f1unction", "program", "addition", "int_literal", "declaration1", 
        "variable"
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
            InitializeCyclicDFAs(dbg);

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
        InitializeCyclicDFAs(dbg);

         
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
		get { return "H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g"; }
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
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:41:1: program returns [List<Element> ret] : ( expr )+ ;
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
        	dbg.Location(41, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:49:3: ( ( expr )+ )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:49:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(49,5);
            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:49:5: ( expr )+
            	int cnt1 = 0;
            	try { dbg.EnterSubRule(1);

            	do 
            	{
            	    int alt1 = 2;
            	    try { dbg.EnterDecision(1);

            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || LA1_0 == 11) )
            	    {
            	        alt1 = 1;
            	    }


            	    } finally { dbg.ExitDecision(1); }

            	    switch (alt1) 
            		{
            			case 1 :
            			    dbg.EnterAlt(1);

            			    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:49:6: expr
            			    {
            			    	dbg.Location(49,6);
            			    	PushFollow(FOLLOW_expr_in_program91);
            			    	expr1 = expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1.Tree);
            			    	dbg.Location(49,11);
            			    	retval.ret.Add(((expr1 != null) ? expr1.ret : null)); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            dbg.RecognitionException(eee1);

            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements
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
        dbg.Location(49, 43);

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
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:53:1: expr returns [Element ret] : ( assignment | print );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.print_return print3 = null;



        try {
        	dbg.EnterRule(GrammarFileName, "expr");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(53, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:56:3: ( assignment | print )
            int alt2 = 2;
            try { dbg.EnterDecision(2);

            int LA2_0 = input.LA(1);

            if ( (LA2_0 == VARIABLE) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 11) )
            {
                alt2 = 2;
            }
            else 
            {
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

                    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:56:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	dbg.Location(56,5);
                    	PushFollow(FOLLOW_assignment_in_expr115);
                    	assignment2 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment2.Tree);
                    	dbg.Location(56,16);
                    	retval.ret = ((assignment2 != null) ? assignment2.ret : null);

                    }
                    break;
                case 2 :
                    dbg.EnterAlt(2);

                    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:57:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	dbg.Location(57,5);
                    	PushFollow(FOLLOW_print_in_expr123);
                    	print3 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print3.Tree);
                    	dbg.Location(57,11);
                    	 retval.ret = ((print3 != null) ? print3.ret : null); 

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
        dbg.Location(57, 39);

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
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:62:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT ;
    public InterpParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        InterpParser.assignment_return retval = new InterpParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT5 = null;
        IToken END_OF_STATEMENT8 = null;
        InterpParser.variable_return variable4 = null;

        InterpParser.var_or_int_literal_return var_or_int_literal6 = null;

        InterpParser.addition_return addition7 = null;


        object ASSIGNMENT5_tree=null;
        object END_OF_STATEMENT8_tree=null;


          

        retval.ret = new AssignmentOperationElement();



        try {
        	dbg.EnterRule(GrammarFileName, "assignment");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(62, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:73:3: ( variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:73:5: variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(73,5);
            	PushFollow(FOLLOW_variable_in_assignment151);
            	variable4 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable4.Tree);
            	dbg.Location(73,14);
            	retval.ret.setLhs(((variable4 != null) ? variable4.ret : null)); 
            	dbg.Location(75,3);
            	ASSIGNMENT5=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment162); 
            		ASSIGNMENT5_tree = (object)adaptor.Create(ASSIGNMENT5);
            		adaptor.AddChild(root_0, ASSIGNMENT5_tree);

            	dbg.Location(77,4);
            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:77:4: ( var_or_int_literal | addition )
            	int alt3 = 2;
            	try { dbg.EnterSubRule(3);
            	try { dbg.EnterDecision(3);

            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == VARIABLE) )
            	{
            	    int LA3_1 = input.LA(2);

            	    if ( (LA3_1 == END_OF_STATEMENT) )
            	    {
            	        alt3 = 1;
            	    }
            	    else if ( (LA3_1 == PLUS) )
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
            	else if ( (LA3_0 == INT_LITERAL) )
            	{
            	    int LA3_2 = input.LA(2);

            	    if ( (LA3_2 == PLUS) )
            	    {
            	        alt3 = 2;
            	    }
            	    else if ( (LA3_2 == END_OF_STATEMENT) )
            	    {
            	        alt3 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d3s2 =
            	            new NoViableAltException("", 3, 2, input);

            	        dbg.RecognitionException(nvae_d3s2);
            	        throw nvae_d3s2;
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

            	        // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:77:5: var_or_int_literal
            	        {
            	        	dbg.Location(77,5);
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment173);
            	        	var_or_int_literal6 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal6.Tree);
            	        	dbg.Location(77,24);
            	        	retval.ret.setRhs(((var_or_int_literal6 != null) ? var_or_int_literal6.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        dbg.EnterAlt(2);

            	        // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:78:7: addition
            	        {
            	        	dbg.Location(78,7);
            	        	PushFollow(FOLLOW_addition_in_assignment184);
            	        	addition7 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition7.Tree);
            	        	dbg.Location(78,16);
            	        	retval.ret.setRhs(((addition7 != null) ? addition7.ret : null)); 

            	        }
            	        break;

            	}
            	} finally { dbg.ExitSubRule(3); }

            	dbg.Location(79,7);
            	END_OF_STATEMENT8=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment194); 
            		END_OF_STATEMENT8_tree = (object)adaptor.Create(END_OF_STATEMENT8);
            		adaptor.AddChild(root_0, END_OF_STATEMENT8_tree);


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
        dbg.Location(79, 23);

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
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:83:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable9 = null;

        InterpParser.int_literal_return int_literal10 = null;



        try {
        	dbg.EnterRule(GrammarFileName, "var_or_int_literal");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(83, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:85:3: ( ( variable | int_literal ) )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:85:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(85,6);
            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:85:6: ( variable | int_literal )
            	int alt4 = 2;
            	try { dbg.EnterSubRule(4);
            	try { dbg.EnterDecision(4);

            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == VARIABLE) )
            	{
            	    alt4 = 1;
            	}
            	else if ( (LA4_0 == INT_LITERAL) )
            	{
            	    alt4 = 2;
            	}
            	else 
            	{
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

            	        // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:85:7: variable
            	        {
            	        	dbg.Location(85,7);
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal214);
            	        	variable9 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable9.Tree);
            	        	dbg.Location(85,16);
            	        	 retval.ret = ((variable9 != null) ? variable9.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        dbg.EnterAlt(2);

            	        // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:87:4: int_literal
            	        {
            	        	dbg.Location(87,4);
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal227);
            	        	int_literal10 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal10.Tree);
            	        	dbg.Location(87,16);
            	        	retval.ret = ((int_literal10 != null) ? int_literal10.ret : null); 

            	        }
            	        break;

            	}
            	} finally { dbg.ExitSubRule(4); }


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
        dbg.Location(87, 51);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "var_or_int_literal");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "var_or_int_literal"

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
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:91:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE11 = null;

        object VARIABLE11_tree=null;


          retval.ret = new VariableElement();

        try {
        	dbg.EnterRule(GrammarFileName, "variable");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(91, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:99:3: ( VARIABLE )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:99:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(99,5);
            	VARIABLE11=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable257); 
            		VARIABLE11_tree = (object)adaptor.Create(VARIABLE11);
            		adaptor.AddChild(root_0, VARIABLE11_tree);

            	dbg.Location(99,14);
            	 retval.ret.setText(((VARIABLE11 != null) ? VARIABLE11.Text : null)); 

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
        dbg.Location(99, 53);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "variable");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "variable"

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
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:103:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL12 = null;

        object INT_LITERAL12_tree=null;


          retval.ret = new IntegerElement();

        try {
        	dbg.EnterRule(GrammarFileName, "int_literal");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(103, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:111:2: ( INT_LITERAL )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:111:4: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(111,4);
            	INT_LITERAL12=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal285); 
            		INT_LITERAL12_tree = (object)adaptor.Create(INT_LITERAL12);
            		adaptor.AddChild(root_0, INT_LITERAL12_tree);

            	dbg.Location(111,16);
            	 retval.ret.setText(((INT_LITERAL12 != null) ? INT_LITERAL12.Text : null)); 

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
        dbg.Location(111, 58);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "int_literal");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "int_literal"

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
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:115:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public InterpParser.addition_return addition() // throws RecognitionException [1]
    {   
        InterpParser.addition_return retval = new InterpParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal13 = null;
        InterpParser.var_or_int_literal_return el1 = null;

        InterpParser.var_or_int_literal_return el2 = null;


        object char_literal13_tree=null;


          retval.ret = new AdditionOperationElement();

        try {
        	dbg.EnterRule(GrammarFileName, "addition");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(115, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:123:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:123:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(123,8);
            	PushFollow(FOLLOW_var_or_int_literal_in_addition315);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	dbg.Location(123,28);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	dbg.Location(125,3);
            	char_literal13=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition327); 
            		char_literal13_tree = (object)adaptor.Create(char_literal13);
            		adaptor.AddChild(root_0, char_literal13_tree);

            	dbg.Location(127,8);
            	PushFollow(FOLLOW_var_or_int_literal_in_addition341);
            	el2 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el2.Tree);
            	dbg.Location(127,28);
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
        dbg.Location(127, 60);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "addition");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "addition"

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
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:131:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal END_OF_STATEMENT ;
    public InterpParser.print_return print() // throws RecognitionException [1]
    {   
        InterpParser.print_return retval = new InterpParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal14 = null;
        IToken END_OF_STATEMENT16 = null;
        InterpParser.var_or_int_literal_return var_or_int_literal15 = null;


        object string_literal14_tree=null;
        object END_OF_STATEMENT16_tree=null;


          retval.ret = new PrintOperationElement();

        try {
        	dbg.EnterRule(GrammarFileName, "print");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(131, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:139:2: ( 'print' var_or_int_literal END_OF_STATEMENT )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:139:4: 'print' var_or_int_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(139,4);
            	string_literal14=(IToken)Match(input,11,FOLLOW_11_in_print369); 
            		string_literal14_tree = (object)adaptor.Create(string_literal14);
            		adaptor.AddChild(root_0, string_literal14_tree);

            	dbg.Location(139,12);
            	PushFollow(FOLLOW_var_or_int_literal_in_print371);
            	var_or_int_literal15 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal15.Tree);
            	dbg.Location(139,31);
            	retval.ret.setChildElement(((var_or_int_literal15 != null) ? var_or_int_literal15.ret : null)); 
            	dbg.Location(141,4);
            	END_OF_STATEMENT16=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print381); 
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
        dbg.Location(141, 20);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "print");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "print"

    public class f1unction_return : ParserRuleReturnScope
    {
        public FunctionElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "f1unction"
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:143:1: f1unction returns [FunctionElement ret] : TYPE variable '(' ( declaration1 ( ',' declaration1 )* ) ')' '{' assignment '}' ;
    public InterpParser.f1unction_return f1unction() // throws RecognitionException [1]
    {   
        InterpParser.f1unction_return retval = new InterpParser.f1unction_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TYPE17 = null;
        IToken char_literal19 = null;
        IToken char_literal21 = null;
        IToken char_literal23 = null;
        IToken char_literal24 = null;
        IToken char_literal26 = null;
        InterpParser.variable_return variable18 = null;

        InterpParser.declaration1_return declaration120 = null;

        InterpParser.declaration1_return declaration122 = null;

        InterpParser.assignment_return assignment25 = null;


        object TYPE17_tree=null;
        object char_literal19_tree=null;
        object char_literal21_tree=null;
        object char_literal23_tree=null;
        object char_literal24_tree=null;
        object char_literal26_tree=null;


        	retval.ret = new FunctionElement();
        	

        try {
        	dbg.EnterRule(GrammarFileName, "f1unction");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(143, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:149:2: ( TYPE variable '(' ( declaration1 ( ',' declaration1 )* ) ')' '{' assignment '}' )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:149:4: TYPE variable '(' ( declaration1 ( ',' declaration1 )* ) ')' '{' assignment '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(149,4);
            	TYPE17=(IToken)Match(input,TYPE,FOLLOW_TYPE_in_f1unction399); 
            		TYPE17_tree = (object)adaptor.Create(TYPE17);
            		adaptor.AddChild(root_0, TYPE17_tree);

            	dbg.Location(149,8);
            	retval.ret.setreturntype(((TYPE17 != null) ? TYPE17.Text : null));
            	dbg.Location(150,5);
            	PushFollow(FOLLOW_variable_in_f1unction406);
            	variable18 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable18.Tree);
            	dbg.Location(150,14);
            	retval.ret.setfunctionname(((variable18 != null) ? variable18.ret : null));
            	dbg.Location(151,3);
            	char_literal19=(IToken)Match(input,12,FOLLOW_12_in_f1unction412); 
            		char_literal19_tree = (object)adaptor.Create(char_literal19);
            		adaptor.AddChild(root_0, char_literal19_tree);

            	dbg.Location(151,7);
            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:151:7: ( declaration1 ( ',' declaration1 )* )
            	dbg.EnterAlt(1);

            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:151:8: declaration1 ( ',' declaration1 )*
            	{
            		dbg.Location(151,8);
            		PushFollow(FOLLOW_declaration1_in_f1unction415);
            		declaration120 = declaration1();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, declaration120.Tree);
            		dbg.Location(151,20);
            		retval.ret.setArguments(((declaration120 != null) ? declaration120.ret : null));
            		dbg.Location(151,65);
            		// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:151:65: ( ',' declaration1 )*
            		try { dbg.EnterSubRule(5);

            		do 
            		{
            		    int alt5 = 2;
            		    try { dbg.EnterDecision(5);

            		    int LA5_0 = input.LA(1);

            		    if ( (LA5_0 == 13) )
            		    {
            		        alt5 = 1;
            		    }


            		    } finally { dbg.ExitDecision(5); }

            		    switch (alt5) 
            			{
            				case 1 :
            				    dbg.EnterAlt(1);

            				    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:151:66: ',' declaration1
            				    {
            				    	dbg.Location(151,66);
            				    	char_literal21=(IToken)Match(input,13,FOLLOW_13_in_f1unction418); 
            				    		char_literal21_tree = (object)adaptor.Create(char_literal21);
            				    		adaptor.AddChild(root_0, char_literal21_tree);

            				    	dbg.Location(151,70);
            				    	PushFollow(FOLLOW_declaration1_in_f1unction420);
            				    	declaration122 = declaration1();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, declaration122.Tree);
            				    	dbg.Location(151,82);
            				    	retval.ret.setArguments(((declaration120 != null) ? declaration120.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop5;
            		    }
            		} while (true);

            		loop5:
            			;	// Stops C# compiler whining that label 'loop5' has no statements
            		} finally { dbg.ExitSubRule(5); }


            	}

            	dbg.Location(151,130);
            	char_literal23=(IToken)Match(input,14,FOLLOW_14_in_f1unction425); 
            		char_literal23_tree = (object)adaptor.Create(char_literal23);
            		adaptor.AddChild(root_0, char_literal23_tree);

            	dbg.Location(152,3);
            	char_literal24=(IToken)Match(input,15,FOLLOW_15_in_f1unction429); 
            		char_literal24_tree = (object)adaptor.Create(char_literal24);
            		adaptor.AddChild(root_0, char_literal24_tree);

            	dbg.Location(152,7);
            	PushFollow(FOLLOW_assignment_in_f1unction431);
            	assignment25 = assignment();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, assignment25.Tree);
            	dbg.Location(152,17);
            	retval.ret.setBody(((assignment25 != null) ? assignment25.ret : null));
            	dbg.Location(152,55);
            	char_literal26=(IToken)Match(input,16,FOLLOW_16_in_f1unction433); 
            		char_literal26_tree = (object)adaptor.Create(char_literal26);
            		adaptor.AddChild(root_0, char_literal26_tree);


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
        dbg.Location(155, 3);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "f1unction");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "f1unction"

    public class declaration1_return : ParserRuleReturnScope
    {
        public DeclerationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "declaration1"
    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:156:1: declaration1 returns [DeclerationElement ret] : ( TYPE VARIABLE ) ;
    public InterpParser.declaration1_return declaration1() // throws RecognitionException [1]
    {   
        InterpParser.declaration1_return retval = new InterpParser.declaration1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TYPE27 = null;
        IToken VARIABLE28 = null;

        object TYPE27_tree=null;
        object VARIABLE28_tree=null;

         retval.ret = new DeclerationElement();

        try {
        	dbg.EnterRule(GrammarFileName, "declaration1");
        	if ( RuleLevel==0 ) {dbg.Commence();}
        	IncRuleLevel();
        	dbg.Location(156, 1);

        try 
    	{
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:159:2: ( ( TYPE VARIABLE ) )
            dbg.EnterAlt(1);

            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:159:3: ( TYPE VARIABLE )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	dbg.Location(159,3);
            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:159:3: ( TYPE VARIABLE )
            	dbg.EnterAlt(1);

            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:159:4: TYPE VARIABLE
            	{
            		dbg.Location(159,4);
            		TYPE27=(IToken)Match(input,TYPE,FOLLOW_TYPE_in_declaration1461); 
            			TYPE27_tree = (object)adaptor.Create(TYPE27);
            			adaptor.AddChild(root_0, TYPE27_tree);

            		dbg.Location(159,8);
            		retval.ret.settype(((TYPE27 != null) ? TYPE27.Text : null));
            		dbg.Location(159,42);
            		VARIABLE28=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_declaration1464); 
            			VARIABLE28_tree = (object)adaptor.Create(VARIABLE28);
            			adaptor.AddChild(root_0, VARIABLE28_tree);

            		dbg.Location(159,50);
            		retval.ret.setvariable(((VARIABLE28 != null) ? VARIABLE28.Text : null)); 

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
        dbg.Location(160, 2);

        }
        finally {
            dbg.ExitRule(GrammarFileName, "declaration1");
            DecRuleLevel();
            if ( RuleLevel==0 ) {dbg.Terminate();}
        }

        return retval;
    }
    // $ANTLR end "declaration1"

    // Delegated rules


	private void InitializeCyclicDFAs(IDebugEventListener dbg)
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_program91 = new BitSet(new ulong[]{0x0000000000000842UL});
    public static readonly BitSet FOLLOW_assignment_in_expr115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment151 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment162 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_assignment173 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_addition_in_assignment184 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal227 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition315 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition327 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_11_in_print369 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print371 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TYPE_in_f1unction399 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_variable_in_f1unction406 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_12_in_f1unction412 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_declaration1_in_f1unction415 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_13_in_f1unction418 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_declaration1_in_f1unction420 = new BitSet(new ulong[]{0x0000000000006000UL});
    public static readonly BitSet FOLLOW_14_in_f1unction425 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_15_in_f1unction429 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_assignment_in_f1unction431 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_16_in_f1unction433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TYPE_in_declaration1461 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_declaration1464 = new BitSet(new ulong[]{0x0000000000000002UL});

}
