// $ANTLR 3.1.2 C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g 2009-11-17 16:47:19


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public class spinachParser : Parser 
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"VARIABLE", 
		"INT_LITERAL", 
		"DOUBLE_LITERAL", 
		"VARTYPE", 
		"ASSIGNMENT", 
		"END_OF_STATEMENT", 
		"STRINGTYPE", 
		"LEFTBRACE", 
		"POINT", 
		"RIGHTBRACE", 
		"LEFTPARANTHESIS", 
		"RIGHTPARANTHESIS", 
		"SCALEMODE", 
		"DOT", 
		"PLUS", 
		"MULTIPLY", 
		"WHITESPACE", 
		"EQUALITYEXPRESSION", 
		"NONEQUALITYEXPRESSION", 
		"LESSTHANEXPRESSION", 
		"LESSTHANEQUALTOEXPRESSION", 
		"GREATERTHANEXPRESSION", 
		"GREATERTHANEQUALTOEXPRESSION", 
		"'\"'", 
		"'Matrix'", 
		"'['", 
		"']'", 
		"','", 
		"'Vector'", 
		"'-'", 
		"'struct'", 
		"'delete'", 
		"'print'", 
		"'parallelfor'", 
		"'to'", 
		"'SYNC'", 
		"'if'", 
		"'else'", 
		"'for'", 
		"'void'", 
		"'DOT'", 
		"'T'", 
		"'//'", 
		"'return'", 
		"'subPlot'", 
		"'1D'", 
		"'2D'", 
		"'3D'", 
		"'plot'", 
		"'resetPlot'", 
		"'setPlotAxis'", 
		"'setAxisTitle'", 
		"'setScaleMode'"
    };

    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int POINT = 12;
    public const int EQUALITYEXPRESSION = 21;
    public const int DOUBLE_LITERAL = 6;
    public const int EOF = -1;
    public const int NONEQUALITYEXPRESSION = 22;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int LEFTBRACE = 11;
    public const int T__53 = 53;
    public const int LESSTHANEQUALTOEXPRESSION = 24;
    public const int T__54 = 54;
    public const int MULTIPLY = 19;
    public const int PLUS = 18;
    public const int RIGHTBRACE = 13;
    public const int LESSTHANEXPRESSION = 23;
    public const int DOT = 17;
    public const int T__50 = 50;
    public const int END_OF_STATEMENT = 9;
    public const int RIGHTPARANTHESIS = 15;
    public const int GREATERTHANEQUALTOEXPRESSION = 26;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int SCALEMODE = 16;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int INT_LITERAL = 5;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int WHITESPACE = 20;
    public const int GREATERTHANEXPRESSION = 25;
    public const int VARTYPE = 7;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int VARIABLE = 4;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRINGTYPE = 10;
    public const int LEFTPARANTHESIS = 14;
    public const int ASSIGNMENT = 8;

    // delegates
    // delegators



        public spinachParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public spinachParser(ITokenStream input, RecognizerSharedState state)
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
		get { return spinachParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g"; }
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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:24:1: program returns [List<Element> ret] : ( expr )+ ;
    public spinachParser.program_return program() // throws RecognitionException [1]
    {   
        spinachParser.program_return retval = new spinachParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:28:3: ( ( expr )+ )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:28:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:28:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || LA1_0 == VARTYPE || LA1_0 == STRINGTYPE || LA1_0 == 28 || LA1_0 == 32 || (LA1_0 >= 34 && LA1_0 <= 37) || LA1_0 == 40 || (LA1_0 >= 42 && LA1_0 <= 43) || LA1_0 == 46 || LA1_0 == 48 || (LA1_0 >= 52 && LA1_0 <= 56)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:28:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program69);
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
            		;	// Stops C# compiler whinging that label 'loop1' has no statements


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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:32:1: expr returns [Element ret] : ( expr1 | parallelfor | structdec | functiondefination );
    public spinachParser.expr_return expr() // throws RecognitionException [1]
    {   
        spinachParser.expr_return retval = new spinachParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr12 = null;

        spinachParser.parallelfor_return parallelfor3 = null;

        spinachParser.structdec_return structdec4 = null;

        spinachParser.functiondefination_return functiondefination5 = null;



        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:33:3: ( expr1 | parallelfor | structdec | functiondefination )
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            case STRINGTYPE:
            case 28:
            case 32:
            case 35:
            case 36:
            case 40:
            case 42:
            case 46:
            case 48:
            case 52:
            case 53:
            case 54:
            case 55:
            case 56:
            	{
                alt2 = 1;
                }
                break;
            case VARTYPE:
            	{
                int LA2_2 = input.LA(2);

                if ( (LA2_2 == VARIABLE) )
                {
                    int LA2_6 = input.LA(3);

                    if ( (LA2_6 == END_OF_STATEMENT) )
                    {
                        alt2 = 1;
                    }
                    else if ( (LA2_6 == LEFTBRACE) )
                    {
                        alt2 = 4;
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s6 =
                            new NoViableAltException("", 2, 6, input);

                        throw nvae_d2s6;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d2s2 =
                        new NoViableAltException("", 2, 2, input);

                    throw nvae_d2s2;
                }
                }
                break;
            case 37:
            	{
                alt2 = 2;
                }
                break;
            case 34:
            	{
                alt2 = 3;
                }
                break;
            case 43:
            	{
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:33:4: expr1
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr1_in_expr96);
                    	expr12 = expr1();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr12.Tree);
                    	retval.ret = ((expr12 != null) ? expr12.ret : null);

                    }
                    break;
                case 2 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:33:37: parallelfor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallelfor_in_expr100);
                    	parallelfor3 = parallelfor();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, parallelfor3.Tree);
                    	retval.ret = ((parallelfor3 != null) ? parallelfor3.ret : null);

                    }
                    break;
                case 3 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:33:82: structdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structdec_in_expr104);
                    	structdec4 = structdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structdec4.Tree);
                    	retval.ret = ((structdec4 != null) ? structdec4.ret : null);

                    }
                    break;
                case 4 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:34:8: functiondefination
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functiondefination_in_expr115);
                    	functiondefination5 = functiondefination();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functiondefination5.Tree);
                    	retval.ret = ((functiondefination5 != null) ? functiondefination5.ret : null);

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

    public class expr1_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr1"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:37:1: expr1 returns [Element ret] : ( forexpr | print );
    public spinachParser.expr1_return expr1() // throws RecognitionException [1]
    {   
        spinachParser.expr1_return retval = new spinachParser.expr1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.forexpr_return forexpr6 = null;

        spinachParser.print_return print7 = null;



        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:38:4: ( forexpr | print )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == VARIABLE || LA3_0 == VARTYPE || LA3_0 == STRINGTYPE || LA3_0 == 28 || LA3_0 == 32 || LA3_0 == 35 || LA3_0 == 40 || LA3_0 == 42 || LA3_0 == 46 || LA3_0 == 48 || (LA3_0 >= 52 && LA3_0 <= 56)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 36) )
            {
                alt3 = 2;
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
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:38:5: forexpr
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forexpr_in_expr1131);
                    	forexpr6 = forexpr();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, forexpr6.Tree);
                    	retval.ret = ((forexpr6 != null) ? forexpr6.ret : null);

                    }
                    break;
                case 2 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:39:10: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr1143);
                    	print7 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print7.Tree);
                    	 retval.ret = ((print7 != null) ? print7.ret : null); 

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
    // $ANTLR end "expr1"

    public class forexpr_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forexpr"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:43:1: forexpr returns [Element ret] : ( expr2 | matrixvardec | plotfunctions | functioncall | vectorvardec );
    public spinachParser.forexpr_return forexpr() // throws RecognitionException [1]
    {   
        spinachParser.forexpr_return retval = new spinachParser.forexpr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr2_return expr28 = null;

        spinachParser.matrixvardec_return matrixvardec9 = null;

        spinachParser.plotfunctions_return plotfunctions10 = null;

        spinachParser.functioncall_return functioncall11 = null;

        spinachParser.vectorvardec_return vectorvardec12 = null;



        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:44:1: ( expr2 | matrixvardec | plotfunctions | functioncall | vectorvardec )
            int alt4 = 5;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                int LA4_1 = input.LA(2);

                if ( (LA4_1 == VARIABLE || LA4_1 == ASSIGNMENT || LA4_1 == DOT || LA4_1 == 29) )
                {
                    alt4 = 1;
                }
                else if ( (LA4_1 == LEFTBRACE) )
                {
                    alt4 = 4;
                }
                else 
                {
                    NoViableAltException nvae_d4s1 =
                        new NoViableAltException("", 4, 1, input);

                    throw nvae_d4s1;
                }
                }
                break;
            case VARTYPE:
            case STRINGTYPE:
            case 35:
            case 40:
            case 42:
            case 46:
            	{
                alt4 = 1;
                }
                break;
            case 28:
            	{
                alt4 = 2;
                }
                break;
            case 48:
            case 52:
            case 53:
            case 54:
            case 55:
            case 56:
            	{
                alt4 = 3;
                }
                break;
            case 32:
            	{
                alt4 = 5;
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
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:45:7: expr2
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr2_in_forexpr176);
                    	expr28 = expr2();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr28.Tree);
                    	retval.ret = ((expr28 != null) ? expr28.ret : null);

                    }
                    break;
                case 2 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:46:7: matrixvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixvardec_in_forexpr185);
                    	matrixvardec9 = matrixvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matrixvardec9.Tree);
                    	 retval.ret = ((matrixvardec9 != null) ? matrixvardec9.ret : null);

                    }
                    break;
                case 3 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:47:7: plotfunctions
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_plotfunctions_in_forexpr195);
                    	plotfunctions10 = plotfunctions();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, plotfunctions10.Tree);
                    	retval.ret = ((plotfunctions10 != null) ? plotfunctions10.ret : null);

                    }
                    break;
                case 4 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:48:7: functioncall
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functioncall_in_forexpr204);
                    	functioncall11 = functioncall();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functioncall11.Tree);
                    	retval.ret=((functioncall11 != null) ? functioncall11.ret : null);

                    }
                    break;
                case 5 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:49:7: vectorvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_vectorvardec_in_forexpr213);
                    	vectorvardec12 = vectorvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, vectorvardec12.Tree);
                    	 retval.ret = ((vectorvardec12 != null) ? vectorvardec12.ret : null);

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
    // $ANTLR end "forexpr"

    public class expr2_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expr2"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:52:1: expr2 returns [Element ret] : (el1= assignment | el4= ifelse | el5= forstatement | el6= comment | e12= scalarvardec | e13= deletionofvar | structobjdec ) ;
    public spinachParser.expr2_return expr2() // throws RecognitionException [1]
    {   
        spinachParser.expr2_return retval = new spinachParser.expr2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.assignment_return el1 = null;

        spinachParser.ifelse_return el4 = null;

        spinachParser.forstatement_return el5 = null;

        spinachParser.comment_return el6 = null;

        spinachParser.scalarvardec_return e12 = null;

        spinachParser.deletionofvar_return e13 = null;

        spinachParser.structobjdec_return structobjdec13 = null;



        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:53:1: ( (el1= assignment | el4= ifelse | el5= forstatement | el6= comment | e12= scalarvardec | e13= deletionofvar | structobjdec ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:53:4: (el1= assignment | el4= ifelse | el5= forstatement | el6= comment | e12= scalarvardec | e13= deletionofvar | structobjdec )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:53:4: (el1= assignment | el4= ifelse | el5= forstatement | el6= comment | e12= scalarvardec | e13= deletionofvar | structobjdec )
            	int alt5 = 7;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    int LA5_1 = input.LA(2);

            	    if ( (LA5_1 == ASSIGNMENT || LA5_1 == DOT || LA5_1 == 29) )
            	    {
            	        alt5 = 1;
            	    }
            	    else if ( (LA5_1 == VARIABLE) )
            	    {
            	        alt5 = 7;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d5s1 =
            	            new NoViableAltException("", 5, 1, input);

            	        throw nvae_d5s1;
            	    }
            	    }
            	    break;
            	case 40:
            		{
            	    alt5 = 2;
            	    }
            	    break;
            	case 42:
            		{
            	    alt5 = 3;
            	    }
            	    break;
            	case 46:
            		{
            	    alt5 = 4;
            	    }
            	    break;
            	case VARTYPE:
            	case STRINGTYPE:
            		{
            	    alt5 = 5;
            	    }
            	    break;
            	case 35:
            		{
            	    alt5 = 6;
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
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:53:5: el1= assignment
            	        {
            	        	PushFollow(FOLLOW_assignment_in_expr2233);
            	        	el1 = assignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret = ((el1 != null) ? el1.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:54:5: el4= ifelse
            	        {
            	        	PushFollow(FOLLOW_ifelse_in_expr2243);
            	        	el4 = ifelse();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	retval.ret = ((el4 != null) ? el4.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:55:5: el5= forstatement
            	        {
            	        	PushFollow(FOLLOW_forstatement_in_expr2253);
            	        	el5 = forstatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el5.Tree);
            	        	retval.ret = ((el5 != null) ? el5.ret : null);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:56:5: el6= comment
            	        {
            	        	PushFollow(FOLLOW_comment_in_expr2262);
            	        	el6 = comment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el6.Tree);
            	        	retval.ret = ((el6 != null) ? el6.ret : null);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:57:5: e12= scalarvardec
            	        {
            	        	PushFollow(FOLLOW_scalarvardec_in_expr2272);
            	        	e12 = scalarvardec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e12.Tree);
            	        	 retval.ret = ((e12 != null) ? e12.ret : null);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:58:5: e13= deletionofvar
            	        {
            	        	PushFollow(FOLLOW_deletionofvar_in_expr2284);
            	        	e13 = deletionofvar();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e13.Tree);
            	        	retval.ret = ((e13 != null) ? e13.ret : null);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:59:5: structobjdec
            	        {
            	        	PushFollow(FOLLOW_structobjdec_in_expr2291);
            	        	structobjdec13 = structobjdec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structobjdec13.Tree);
            	        	 retval.ret = ((structobjdec13 != null) ? structobjdec13.ret : null);

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
    // $ANTLR end "expr2"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:63:1: var_int_or_double_literal returns [Element ret] : ( int_literal | double_literal | varorstruct ) ;
    public spinachParser.var_int_or_double_literal_return var_int_or_double_literal() // throws RecognitionException [1]
    {   
        spinachParser.var_int_or_double_literal_return retval = new spinachParser.var_int_or_double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.int_literal_return int_literal14 = null;

        spinachParser.double_literal_return double_literal15 = null;

        spinachParser.varorstruct_return varorstruct16 = null;



        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:64:3: ( ( int_literal | double_literal | varorstruct ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:64:7: ( int_literal | double_literal | varorstruct )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:64:7: ( int_literal | double_literal | varorstruct )
            	int alt6 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case INT_LITERAL:
            		{
            	    alt6 = 1;
            	    }
            	    break;
            	case DOUBLE_LITERAL:
            		{
            	    alt6 = 2;
            	    }
            	    break;
            	case VARIABLE:
            		{
            	    alt6 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d6s0 =
            		        new NoViableAltException("", 6, 0, input);

            		    throw nvae_d6s0;
            	}

            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:64:8: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_int_or_double_literal316);
            	        	int_literal14 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal14.Tree);
            	        	retval.ret = ((int_literal14 != null) ? int_literal14.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:65:7: double_literal
            	        {
            	        	PushFollow(FOLLOW_double_literal_in_var_int_or_double_literal326);
            	        	double_literal15 = double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, double_literal15.Tree);
            	        	retval.ret = ((double_literal15 != null) ? double_literal15.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:66:5: varorstruct
            	        {
            	        	PushFollow(FOLLOW_varorstruct_in_var_int_or_double_literal334);
            	        	varorstruct16 = varorstruct();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, varorstruct16.Tree);
            	        	retval.ret = ((varorstruct16 != null) ? varorstruct16.ret : null);

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

    public class varorstruct_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "varorstruct"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:68:1: varorstruct returns [Element ret] : ( variable | structassign ) ;
    public spinachParser.varorstruct_return varorstruct() // throws RecognitionException [1]
    {   
        spinachParser.varorstruct_return retval = new spinachParser.varorstruct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.variable_return variable17 = null;

        spinachParser.structassign_return structassign18 = null;



        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:69:1: ( ( variable | structassign ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:69:3: ( variable | structassign )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:69:3: ( variable | structassign )
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == VARIABLE) )
            	{
            	    int LA7_1 = input.LA(2);

            	    if ( (LA7_1 == DOT) )
            	    {
            	        alt7 = 2;
            	    }
            	    else if ( (LA7_1 == EOF || (LA7_1 >= VARIABLE && LA7_1 <= VARTYPE) || (LA7_1 >= END_OF_STATEMENT && LA7_1 <= STRINGTYPE) || LA7_1 == RIGHTBRACE || LA7_1 == RIGHTPARANTHESIS || (LA7_1 >= PLUS && LA7_1 <= MULTIPLY) || (LA7_1 >= EQUALITYEXPRESSION && LA7_1 <= 28) || (LA7_1 >= 31 && LA7_1 <= 37) || (LA7_1 >= 39 && LA7_1 <= 40) || (LA7_1 >= 42 && LA7_1 <= 43) || (LA7_1 >= 46 && LA7_1 <= 48) || (LA7_1 >= 52 && LA7_1 <= 56)) )
            	    {
            	        alt7 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d7s1 =
            	            new NoViableAltException("", 7, 1, input);

            	        throw nvae_d7s1;
            	    }
            	}
            	else 
            	{
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:69:4: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_varorstruct349);
            	        	variable17 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable17.Tree);
            	        	retval.ret = ((variable17 != null) ? variable17.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:69:42: structassign
            	        {
            	        	PushFollow(FOLLOW_structassign_in_varorstruct352);
            	        	structassign18 = structassign();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structassign18.Tree);
            	        	retval.ret = ((structassign18 != null) ? structassign18.ret : null);

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
    // $ANTLR end "varorstruct"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:72:1: variable returns [VariableElement ret] : VARIABLE ;
    public spinachParser.variable_return variable() // throws RecognitionException [1]
    {   
        spinachParser.variable_return retval = new spinachParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE19 = null;

        object VARIABLE19_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:76:3: ( VARIABLE )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:76:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE19=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable374); 
            		VARIABLE19_tree = (object)adaptor.Create(VARIABLE19);
            		adaptor.AddChild(root_0, VARIABLE19_tree);

            	 retval.ret.setText(((VARIABLE19 != null) ? VARIABLE19.Text : null)); 

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:78:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public spinachParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        spinachParser.int_literal_return retval = new spinachParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL20 = null;

        object INT_LITERAL20_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:82:3: ( INT_LITERAL )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:82:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL20=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal395); 
            		INT_LITERAL20_tree = (object)adaptor.Create(INT_LITERAL20);
            		adaptor.AddChild(root_0, INT_LITERAL20_tree);

            	 retval.ret.setText(((INT_LITERAL20 != null) ? INT_LITERAL20.Text : null)); 

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:84:1: double_literal returns [DoubleElement ret] : el1= DOUBLE_LITERAL ;
    public spinachParser.double_literal_return double_literal() // throws RecognitionException [1]
    {   
        spinachParser.double_literal_return retval = new spinachParser.double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;

        object el1_tree=null;


        	retval.ret = new DoubleElement();
        	
        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:88:2: (el1= DOUBLE_LITERAL )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:88:4: el1= DOUBLE_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_double_literal417); 
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

    public class string_literal_return : ParserRuleReturnScope
    {
        public StringElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "string_literal"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:90:1: string_literal returns [StringElement ret] : ( '\"' (el1= var_int_or_double_literal )* '\"' ) ;
    public spinachParser.string_literal_return string_literal() // throws RecognitionException [1]
    {   
        spinachParser.string_literal_return retval = new spinachParser.string_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal21 = null;
        IToken char_literal22 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;


        object char_literal21_tree=null;
        object char_literal22_tree=null;


         retval.ret = new StringElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:94:2: ( ( '\"' (el1= var_int_or_double_literal )* '\"' ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:94:3: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:94:3: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:94:4: '\"' (el1= var_int_or_double_literal )* '\"'
            	{
            		char_literal21=(IToken)Match(input,27,FOLLOW_27_in_string_literal437); 
            			char_literal21_tree = (object)adaptor.Create(char_literal21);
            			adaptor.AddChild(root_0, char_literal21_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:94:7: (el1= var_int_or_double_literal )*
            		do 
            		{
            		    int alt8 = 2;
            		    int LA8_0 = input.LA(1);

            		    if ( ((LA8_0 >= VARIABLE && LA8_0 <= DOUBLE_LITERAL)) )
            		    {
            		        alt8 = 1;
            		    }


            		    switch (alt8) 
            			{
            				case 1 :
            				    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:94:8: el1= var_int_or_double_literal
            				    {
            				    	PushFollow(FOLLOW_var_int_or_double_literal_in_string_literal441);
            				    	el1 = var_int_or_double_literal();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	retval.ret.setText(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop8;
            		    }
            		} while (true);

            		loop8:
            			;	// Stops C# compiler whining that label 'loop8' has no statements

            		char_literal22=(IToken)Match(input,27,FOLLOW_27_in_string_literal446); 
            			char_literal22_tree = (object)adaptor.Create(char_literal22);
            			adaptor.AddChild(root_0, char_literal22_tree);

            		retval.ret.appendText();

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
    // $ANTLR end "string_literal"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:96:1: matrixvardec returns [MatrixVariableDeclaration ret] : ( 'Matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) ) END_OF_STATEMENT ;
    public spinachParser.matrixvardec_return matrixvardec() // throws RecognitionException [1]
    {   
        spinachParser.matrixvardec_return retval = new spinachParser.matrixvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el0 = null;
        IToken string_literal23 = null;
        IToken char_literal24 = null;
        IToken char_literal25 = null;
        IToken char_literal26 = null;
        IToken char_literal27 = null;
        IToken char_literal28 = null;
        IToken char_literal29 = null;
        IToken ASSIGNMENT30 = null;
        IToken char_literal31 = null;
        IToken char_literal32 = null;
        IToken char_literal33 = null;
        IToken char_literal34 = null;
        IToken char_literal35 = null;
        IToken char_literal36 = null;
        IToken char_literal37 = null;
        IToken char_literal38 = null;
        IToken END_OF_STATEMENT39 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;

        spinachParser.int_literal_return el7 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object el0_tree=null;
        object string_literal23_tree=null;
        object char_literal24_tree=null;
        object char_literal25_tree=null;
        object char_literal26_tree=null;
        object char_literal27_tree=null;
        object char_literal28_tree=null;
        object char_literal29_tree=null;
        object ASSIGNMENT30_tree=null;
        object char_literal31_tree=null;
        object char_literal32_tree=null;
        object char_literal33_tree=null;
        object char_literal34_tree=null;
        object char_literal35_tree=null;
        object char_literal36_tree=null;
        object char_literal37_tree=null;
        object char_literal38_tree=null;
        object END_OF_STATEMENT39_tree=null;


        	retval.ret = new MatrixVariableDeclaration();
        	
        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:100:2: ( ( 'Matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) ) END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:100:3: ( 'Matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:100:3: ( 'Matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:100:4: 'Matrix' '<' (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) )
            	{
            		string_literal23=(IToken)Match(input,28,FOLLOW_28_in_matrixvardec466); 
            			string_literal23_tree = (object)adaptor.Create(string_literal23);
            			adaptor.AddChild(root_0, string_literal23_tree);

            		char_literal24=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixvardec468); 
            			char_literal24_tree = (object)adaptor.Create(char_literal24);
            			adaptor.AddChild(root_0, char_literal24_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:101:2: (el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) )
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:101:3: el0= VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' )
            		{
            			el0=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixvardec475); 
            				el0_tree = (object)adaptor.Create(el0);
            				adaptor.AddChild(root_0, el0_tree);

            			 retval.ret.setType(((el0 != null) ? el0.Text : null));
            			char_literal25=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec477); 
            				char_literal25_tree = (object)adaptor.Create(char_literal25);
            				adaptor.AddChild(root_0, char_literal25_tree);

            			char_literal26=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec479); 
            				char_literal26_tree = (object)adaptor.Create(char_literal26);
            				adaptor.AddChild(root_0, char_literal26_tree);

            			PushFollow(FOLLOW_int_literal_in_matrixvardec482);
            			el1 = int_literal();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el1.Tree);
            			 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            			char_literal27=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec485); 
            				char_literal27_tree = (object)adaptor.Create(char_literal27);
            				adaptor.AddChild(root_0, char_literal27_tree);

            			char_literal28=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec488); 
            				char_literal28_tree = (object)adaptor.Create(char_literal28);
            				adaptor.AddChild(root_0, char_literal28_tree);

            			PushFollow(FOLLOW_int_literal_in_matrixvardec492);
            			el2 = int_literal();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el2.Tree);
            			 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            			char_literal29=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec495); 
            				char_literal29_tree = (object)adaptor.Create(char_literal29);
            				adaptor.AddChild(root_0, char_literal29_tree);

            			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:103:3: (el3= variable )
            			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:103:4: el3= variable
            			{
            				PushFollow(FOLLOW_variable_in_matrixvardec503);
            				el3 = variable();
            				state.followingStackPointer--;

            				adaptor.AddChild(root_0, el3.Tree);
            				 retval.ret.setVar(((el3 != null) ? el3.ret : null));

            			}

            			ASSIGNMENT30=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matrixvardec510); 
            				ASSIGNMENT30_tree = (object)adaptor.Create(ASSIGNMENT30);
            				adaptor.AddChild(root_0, ASSIGNMENT30_tree);

            			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:105:3: ( ( '[' ']' ) | ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' )
            			int alt11 = 3;
            			int LA11_0 = input.LA(1);

            			if ( (LA11_0 == 29) )
            			{
            			    switch ( input.LA(2) ) 
            			    {
            			    case 30:
            			    	{
            			        alt11 = 1;
            			        }
            			        break;
            			    case INT_LITERAL:
            			    	{
            			        alt11 = 2;
            			        }
            			        break;
            			    case DOUBLE_LITERAL:
            			    	{
            			        alt11 = 3;
            			        }
            			        break;
            			    	default:
            			    	    NoViableAltException nvae_d11s1 =
            			    	        new NoViableAltException("", 11, 1, input);

            			    	    throw nvae_d11s1;
            			    }

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
            			        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:105:4: ( '[' ']' )
            			        {
            			        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:105:4: ( '[' ']' )
            			        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:105:5: '[' ']'
            			        	{
            			        		char_literal31=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec516); 
            			        			char_literal31_tree = (object)adaptor.Create(char_literal31);
            			        			adaptor.AddChild(root_0, char_literal31_tree);

            			        		char_literal32=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec517); 
            			        			char_literal32_tree = (object)adaptor.Create(char_literal32);
            			        			adaptor.AddChild(root_0, char_literal32_tree);


            			        	}


            			        }
            			        break;
            			    case 2 :
            			        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:106:3: ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' )
            			        {
            			        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:106:3: ( '[' (el7= int_literal ( ',' el5= int_literal )* ) ']' )
            			        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:106:4: '[' (el7= int_literal ( ',' el5= int_literal )* ) ']'
            			        	{
            			        		char_literal33=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec524); 
            			        			char_literal33_tree = (object)adaptor.Create(char_literal33);
            			        			adaptor.AddChild(root_0, char_literal33_tree);

            			        		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:106:7: (el7= int_literal ( ',' el5= int_literal )* )
            			        		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:106:8: el7= int_literal ( ',' el5= int_literal )*
            			        		{
            			        			PushFollow(FOLLOW_int_literal_in_matrixvardec528);
            			        			el7 = int_literal();
            			        			state.followingStackPointer--;

            			        			adaptor.AddChild(root_0, el7.Tree);
            			        			retval.ret.addValue(((el7 != null) ? el7.ret : null));
            			        			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:106:57: ( ',' el5= int_literal )*
            			        			do 
            			        			{
            			        			    int alt9 = 2;
            			        			    int LA9_0 = input.LA(1);

            			        			    if ( (LA9_0 == 31) )
            			        			    {
            			        			        alt9 = 1;
            			        			    }


            			        			    switch (alt9) 
            			        				{
            			        					case 1 :
            			        					    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:106:58: ',' el5= int_literal
            			        					    {
            			        					    	char_literal34=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec533); 
            			        					    		char_literal34_tree = (object)adaptor.Create(char_literal34);
            			        					    		adaptor.AddChild(root_0, char_literal34_tree);

            			        					    	PushFollow(FOLLOW_int_literal_in_matrixvardec536);
            			        					    	el5 = int_literal();
            			        					    	state.followingStackPointer--;

            			        					    	adaptor.AddChild(root_0, el5.Tree);
            			        					    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            			        					    }
            			        					    break;

            			        					default:
            			        					    goto loop9;
            			        			    }
            			        			} while (true);

            			        			loop9:
            			        				;	// Stops C# compiler whining that label 'loop9' has no statements


            			        		}

            			        		char_literal35=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec542); 
            			        			char_literal35_tree = (object)adaptor.Create(char_literal35);
            			        			adaptor.AddChild(root_0, char_literal35_tree);


            			        	}


            			        }
            			        break;
            			    case 3 :
            			        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:107:4: ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']'
            			        {
            			        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:107:4: ( '[' el4= double_literal ( ',' el6= double_literal )* )
            			        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:107:5: '[' el4= double_literal ( ',' el6= double_literal )*
            			        	{
            			        		char_literal36=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec549); 
            			        			char_literal36_tree = (object)adaptor.Create(char_literal36);
            			        			adaptor.AddChild(root_0, char_literal36_tree);

            			        		PushFollow(FOLLOW_double_literal_in_matrixvardec552);
            			        		el4 = double_literal();
            			        		state.followingStackPointer--;

            			        		adaptor.AddChild(root_0, el4.Tree);
            			        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            			        		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:107:59: ( ',' el6= double_literal )*
            			        		do 
            			        		{
            			        		    int alt10 = 2;
            			        		    int LA10_0 = input.LA(1);

            			        		    if ( (LA10_0 == 31) )
            			        		    {
            			        		        alt10 = 1;
            			        		    }


            			        		    switch (alt10) 
            			        			{
            			        				case 1 :
            			        				    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:107:60: ',' el6= double_literal
            			        				    {
            			        				    	char_literal37=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec556); 
            			        				    		char_literal37_tree = (object)adaptor.Create(char_literal37);
            			        				    		adaptor.AddChild(root_0, char_literal37_tree);

            			        				    	PushFollow(FOLLOW_double_literal_in_matrixvardec559);
            			        				    	el6 = double_literal();
            			        				    	state.followingStackPointer--;

            			        				    	adaptor.AddChild(root_0, el6.Tree);
            			        				    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

            			        				    }
            			        				    break;

            			        				default:
            			        				    goto loop10;
            			        		    }
            			        		} while (true);

            			        		loop10:
            			        			;	// Stops C# compiler whining that label 'loop10' has no statements


            			        	}

            			        	char_literal38=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec565); 
            			        		char_literal38_tree = (object)adaptor.Create(char_literal38);
            			        		adaptor.AddChild(root_0, char_literal38_tree);


            			        }
            			        break;

            			}


            		}

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT39=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matrixvardec576); 
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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:111:1: vectorvardec returns [VectorVariableDeclaration ret] : ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) END_OF_STATEMENT ;
    public spinachParser.vectorvardec_return vectorvardec() // throws RecognitionException [1]
    {   
        spinachParser.vectorvardec_return retval = new spinachParser.vectorvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal40 = null;
        IToken char_literal41 = null;
        IToken VARTYPE42 = null;
        IToken char_literal43 = null;
        IToken char_literal44 = null;
        IToken char_literal45 = null;
        IToken ASSIGNMENT46 = null;
        IToken char_literal47 = null;
        IToken char_literal48 = null;
        IToken char_literal49 = null;
        IToken char_literal50 = null;
        IToken char_literal51 = null;
        IToken char_literal52 = null;
        IToken char_literal53 = null;
        IToken char_literal54 = null;
        IToken END_OF_STATEMENT55 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.variable_return el2 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal40_tree=null;
        object char_literal41_tree=null;
        object VARTYPE42_tree=null;
        object char_literal43_tree=null;
        object char_literal44_tree=null;
        object char_literal45_tree=null;
        object ASSIGNMENT46_tree=null;
        object char_literal47_tree=null;
        object char_literal48_tree=null;
        object char_literal49_tree=null;
        object char_literal50_tree=null;
        object char_literal51_tree=null;
        object char_literal52_tree=null;
        object char_literal53_tree=null;
        object char_literal54_tree=null;
        object END_OF_STATEMENT55_tree=null;


        	retval.ret = new VectorVariableDeclaration();
        	
        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:115:2: ( ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:115:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:115:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' ) )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:115:4: 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' )
            	{
            		string_literal40=(IToken)Match(input,32,FOLLOW_32_in_vectorvardec594); 
            			string_literal40_tree = (object)adaptor.Create(string_literal40);
            			adaptor.AddChild(root_0, string_literal40_tree);

            		char_literal41=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorvardec596); 
            			char_literal41_tree = (object)adaptor.Create(char_literal41);
            			adaptor.AddChild(root_0, char_literal41_tree);

            		VARTYPE42=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorvardec598); 
            			VARTYPE42_tree = (object)adaptor.Create(VARTYPE42);
            			adaptor.AddChild(root_0, VARTYPE42_tree);

            		 retval.ret.setType(((VARTYPE42 != null) ? VARTYPE42.Text : null));
            		char_literal43=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec601); 
            			char_literal43_tree = (object)adaptor.Create(char_literal43);
            			adaptor.AddChild(root_0, char_literal43_tree);

            		char_literal44=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec603); 
            			char_literal44_tree = (object)adaptor.Create(char_literal44);
            			adaptor.AddChild(root_0, char_literal44_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorvardec606);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setRange(((el1 != null) ? el1.ret : null));
            		char_literal45=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec609); 
            			char_literal45_tree = (object)adaptor.Create(char_literal45);
            			adaptor.AddChild(root_0, char_literal45_tree);

            		PushFollow(FOLLOW_variable_in_vectorvardec615);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setText(((el2 != null) ? el2.ret : null));
            		ASSIGNMENT46=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_vectorvardec622); 
            			ASSIGNMENT46_tree = (object)adaptor.Create(ASSIGNMENT46);
            			adaptor.AddChild(root_0, ASSIGNMENT46_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:118:3: ( ( '[' ']' ) | ( '[' el3= int_literal ( ',' el5= int_literal )* ']' ) | ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']' )
            		int alt14 = 3;
            		int LA14_0 = input.LA(1);

            		if ( (LA14_0 == 29) )
            		{
            		    switch ( input.LA(2) ) 
            		    {
            		    case 30:
            		    	{
            		        alt14 = 1;
            		        }
            		        break;
            		    case INT_LITERAL:
            		    	{
            		        alt14 = 2;
            		        }
            		        break;
            		    case DOUBLE_LITERAL:
            		    	{
            		        alt14 = 3;
            		        }
            		        break;
            		    	default:
            		    	    NoViableAltException nvae_d14s1 =
            		    	        new NoViableAltException("", 14, 1, input);

            		    	    throw nvae_d14s1;
            		    }

            		}
            		else 
            		{
            		    NoViableAltException nvae_d14s0 =
            		        new NoViableAltException("", 14, 0, input);

            		    throw nvae_d14s0;
            		}
            		switch (alt14) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:118:4: ( '[' ']' )
            		        {
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:118:4: ( '[' ']' )
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:118:5: '[' ']'
            		        	{
            		        		char_literal47=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec629); 
            		        			char_literal47_tree = (object)adaptor.Create(char_literal47);
            		        			adaptor.AddChild(root_0, char_literal47_tree);

            		        		char_literal48=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec630); 
            		        			char_literal48_tree = (object)adaptor.Create(char_literal48);
            		        			adaptor.AddChild(root_0, char_literal48_tree);


            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:119:3: ( '[' el3= int_literal ( ',' el5= int_literal )* ']' )
            		        {
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:119:3: ( '[' el3= int_literal ( ',' el5= int_literal )* ']' )
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:119:4: '[' el3= int_literal ( ',' el5= int_literal )* ']'
            		        	{
            		        		char_literal49=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec637); 
            		        			char_literal49_tree = (object)adaptor.Create(char_literal49);
            		        			adaptor.AddChild(root_0, char_literal49_tree);

            		        		PushFollow(FOLLOW_int_literal_in_vectorvardec640);
            		        		el3 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el3.Tree);
            		        		retval.ret.addValue(((el3 != null) ? el3.ret : null));
            		        		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:119:56: ( ',' el5= int_literal )*
            		        		do 
            		        		{
            		        		    int alt12 = 2;
            		        		    int LA12_0 = input.LA(1);

            		        		    if ( (LA12_0 == 31) )
            		        		    {
            		        		        alt12 = 1;
            		        		    }


            		        		    switch (alt12) 
            		        			{
            		        				case 1 :
            		        				    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:119:57: ',' el5= int_literal
            		        				    {
            		        				    	char_literal50=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec645); 
            		        				    		char_literal50_tree = (object)adaptor.Create(char_literal50);
            		        				    		adaptor.AddChild(root_0, char_literal50_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_vectorvardec648);
            		        				    	el5 = int_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el5.Tree);
            		        				    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop12;
            		        		    }
            		        		} while (true);

            		        		loop12:
            		        			;	// Stops C# compiler whining that label 'loop12' has no statements

            		        		char_literal51=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec653); 
            		        			char_literal51_tree = (object)adaptor.Create(char_literal51);
            		        			adaptor.AddChild(root_0, char_literal51_tree);


            		        	}


            		        }
            		        break;
            		    case 3 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:120:3: ( '[' el4= double_literal ( ',' el6= double_literal )* ) ']'
            		        {
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:120:3: ( '[' el4= double_literal ( ',' el6= double_literal )* )
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:120:4: '[' el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		char_literal52=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec660); 
            		        			char_literal52_tree = (object)adaptor.Create(char_literal52);
            		        			adaptor.AddChild(root_0, char_literal52_tree);

            		        		PushFollow(FOLLOW_double_literal_in_vectorvardec663);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:121:3: ( ',' el6= double_literal )*
            		        		do 
            		        		{
            		        		    int alt13 = 2;
            		        		    int LA13_0 = input.LA(1);

            		        		    if ( (LA13_0 == 31) )
            		        		    {
            		        		        alt13 = 1;
            		        		    }


            		        		    switch (alt13) 
            		        			{
            		        				case 1 :
            		        				    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:121:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal53=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec670); 
            		        				    		char_literal53_tree = (object)adaptor.Create(char_literal53);
            		        				    		adaptor.AddChild(root_0, char_literal53_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_vectorvardec673);
            		        				    	el6 = double_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el6.Tree);
            		        				    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop13;
            		        		    }
            		        		} while (true);

            		        		loop13:
            		        			;	// Stops C# compiler whining that label 'loop13' has no statements


            		        	}

            		        	char_literal54=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec679); 
            		        		char_literal54_tree = (object)adaptor.Create(char_literal54);
            		        		adaptor.AddChild(root_0, char_literal54_tree);


            		        }
            		        break;

            		}

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT55=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_vectorvardec686); 
            		END_OF_STATEMENT55_tree = (object)adaptor.Create(END_OF_STATEMENT55);
            		adaptor.AddChild(root_0, END_OF_STATEMENT55_tree);


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

    public class matrixelem_return : ParserRuleReturnScope
    {
        public MatrixElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixelem"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:124:1: matrixelem returns [MatrixElement ret] : (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' ) ;
    public spinachParser.matrixelem_return matrixelem() // throws RecognitionException [1]
    {   
        spinachParser.matrixelem_return retval = new spinachParser.matrixelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal56 = null;
        IToken char_literal57 = null;
        IToken char_literal58 = null;
        IToken char_literal59 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el4 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.variable_return el5 = null;


        object char_literal56_tree=null;
        object char_literal57_tree=null;
        object char_literal58_tree=null;
        object char_literal59_tree=null;


         retval.ret = new MatrixElement();
         
        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:128:2: ( (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:128:3: (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:128:3: (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:128:4: el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']'
            	{
            		PushFollow(FOLLOW_variable_in_matrixelem706);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal56=(IToken)Match(input,29,FOLLOW_29_in_matrixelem712); 
            			char_literal56_tree = (object)adaptor.Create(char_literal56);
            			adaptor.AddChild(root_0, char_literal56_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:129:6: (el2= int_literal | el4= variable )
            		int alt15 = 2;
            		int LA15_0 = input.LA(1);

            		if ( (LA15_0 == INT_LITERAL) )
            		{
            		    alt15 = 1;
            		}
            		else if ( (LA15_0 == VARIABLE) )
            		{
            		    alt15 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d15s0 =
            		        new NoViableAltException("", 15, 0, input);

            		    throw nvae_d15s0;
            		}
            		switch (alt15) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:129:7: el2= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_matrixelem716);
            		        	el2 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el2.Tree);
            		        	retval.ret.setRow(((el2 != null) ? el2.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:129:53: el4= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_matrixelem721);
            		        	el4 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el4.Tree);
            		        	retval.ret.setRow(((el4 != null) ? el4.ret : null));

            		        }
            		        break;

            		}

            		char_literal57=(IToken)Match(input,30,FOLLOW_30_in_matrixelem724); 
            			char_literal57_tree = (object)adaptor.Create(char_literal57);
            			adaptor.AddChild(root_0, char_literal57_tree);

            		char_literal58=(IToken)Match(input,29,FOLLOW_29_in_matrixelem727); 
            			char_literal58_tree = (object)adaptor.Create(char_literal58);
            			adaptor.AddChild(root_0, char_literal58_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:130:5: (el3= int_literal | el5= variable )
            		int alt16 = 2;
            		int LA16_0 = input.LA(1);

            		if ( (LA16_0 == INT_LITERAL) )
            		{
            		    alt16 = 1;
            		}
            		else if ( (LA16_0 == VARIABLE) )
            		{
            		    alt16 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d16s0 =
            		        new NoViableAltException("", 16, 0, input);

            		    throw nvae_d16s0;
            		}
            		switch (alt16) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:130:6: el3= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_matrixelem731);
            		        	el3 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el3.Tree);
            		        	retval.ret.setColumn(((el3 != null) ? el3.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:130:55: el5= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_matrixelem736);
            		        	el5 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el5.Tree);
            		        	retval.ret.setColumn(((el5 != null) ? el5.ret : null));

            		        }
            		        break;

            		}

            		char_literal59=(IToken)Match(input,30,FOLLOW_30_in_matrixelem739); 
            			char_literal59_tree = (object)adaptor.Create(char_literal59);
            			adaptor.AddChild(root_0, char_literal59_tree);


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
    // $ANTLR end "matrixelem"

    public class vectorelem_return : ParserRuleReturnScope
    {
        public VectorElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "vectorelem"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:132:1: vectorelem returns [VectorElement ret] : (el1= variable '[' (el2= int_literal | el3= variable ) ']' ) ;
    public spinachParser.vectorelem_return vectorelem() // throws RecognitionException [1]
    {   
        spinachParser.vectorelem_return retval = new spinachParser.vectorelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal60 = null;
        IToken char_literal61 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;


        object char_literal60_tree=null;
        object char_literal61_tree=null;


         retval.ret = new VectorElement();
         
        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:136:2: ( (el1= variable '[' (el2= int_literal | el3= variable ) ']' ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:136:3: (el1= variable '[' (el2= int_literal | el3= variable ) ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:136:3: (el1= variable '[' (el2= int_literal | el3= variable ) ']' )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:136:4: el1= variable '[' (el2= int_literal | el3= variable ) ']'
            	{
            		PushFollow(FOLLOW_variable_in_vectorelem761);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal60=(IToken)Match(input,29,FOLLOW_29_in_vectorelem767); 
            			char_literal60_tree = (object)adaptor.Create(char_literal60);
            			adaptor.AddChild(root_0, char_literal60_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:137:6: (el2= int_literal | el3= variable )
            		int alt17 = 2;
            		int LA17_0 = input.LA(1);

            		if ( (LA17_0 == INT_LITERAL) )
            		{
            		    alt17 = 1;
            		}
            		else if ( (LA17_0 == VARIABLE) )
            		{
            		    alt17 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d17s0 =
            		        new NoViableAltException("", 17, 0, input);

            		    throw nvae_d17s0;
            		}
            		switch (alt17) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:137:7: el2= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_vectorelem771);
            		        	el2 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el2.Tree);
            		        	retval.ret.setRange(((el2 != null) ? el2.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:137:56: el3= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_vectorelem777);
            		        	el3 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el3.Tree);
            		        	retval.ret.setRange(((el3 != null) ? el3.ret : null));

            		        }
            		        break;

            		}

            		char_literal61=(IToken)Match(input,30,FOLLOW_30_in_vectorelem780); 
            			char_literal61_tree = (object)adaptor.Create(char_literal61);
            			adaptor.AddChild(root_0, char_literal61_tree);


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
    // $ANTLR end "vectorelem"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:139:1: assignment returns [AssignmentOperationElement ret] : ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) ) ;
    public spinachParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        spinachParser.assignment_return retval = new spinachParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT64 = null;
        IToken END_OF_STATEMENT69 = null;
        spinachParser.vectorelem_return e12 = null;

        spinachParser.matrixelem_return e11 = null;

        spinachParser.variable_return variable62 = null;

        spinachParser.structassign_return structassign63 = null;

        spinachParser.subtractive_exp_return subtractive_exp65 = null;

        spinachParser.dotproduct_return dotproduct66 = null;

        spinachParser.matrixtranspose_return matrixtranspose67 = null;

        spinachParser.string_literal_return string_literal68 = null;

        spinachParser.functioncall_return functioncall70 = null;


        object ASSIGNMENT64_tree=null;
        object END_OF_STATEMENT69_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:143:3: ( ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:143:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:143:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:143:6: ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall )
            	{
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:143:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )
            		int alt18 = 4;
            		alt18 = dfa18.Predict(input);
            		switch (alt18) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:143:7: variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_assignment803);
            		        	variable62 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, variable62.Tree);
            		        	retval.ret.setLhs(((variable62 != null) ? variable62.ret : null)); 

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:144:7: structassign
            		        {
            		        	PushFollow(FOLLOW_structassign_in_assignment813);
            		        	structassign63 = structassign();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, structassign63.Tree);
            		        	retval.ret.setLhs(((structassign63 != null) ? structassign63.ret : null));

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:145:6: e12= vectorelem
            		        {
            		        	PushFollow(FOLLOW_vectorelem_in_assignment825);
            		        	e12 = vectorelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e12.Tree);
            		        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:146:7: e11= matrixelem
            		        {
            		        	PushFollow(FOLLOW_matrixelem_in_assignment838);
            		        	e11 = matrixelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e11.Tree);
            		        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		        }
            		        break;

            		}

            		ASSIGNMENT64=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment846); 
            			ASSIGNMENT64_tree = (object)adaptor.Create(ASSIGNMENT64);
            			adaptor.AddChild(root_0, ASSIGNMENT64_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:148:5: ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall )
            		int alt20 = 2;
            		int LA20_0 = input.LA(1);

            		if ( ((LA20_0 >= INT_LITERAL && LA20_0 <= DOUBLE_LITERAL) || LA20_0 == LEFTBRACE || LA20_0 == 27 || LA20_0 == 45) )
            		{
            		    alt20 = 1;
            		}
            		else if ( (LA20_0 == VARIABLE) )
            		{
            		    int LA20_2 = input.LA(2);

            		    if ( (LA20_2 == LEFTBRACE) )
            		    {
            		        alt20 = 2;
            		    }
            		    else if ( (LA20_2 == END_OF_STATEMENT || (LA20_2 >= DOT && LA20_2 <= MULTIPLY) || LA20_2 == 29 || LA20_2 == 33 || LA20_2 == 44) )
            		    {
            		        alt20 = 1;
            		    }
            		    else 
            		    {
            		        NoViableAltException nvae_d20s2 =
            		            new NoViableAltException("", 20, 2, input);

            		        throw nvae_d20s2;
            		    }
            		}
            		else 
            		{
            		    NoViableAltException nvae_d20s0 =
            		        new NoViableAltException("", 20, 0, input);

            		    throw nvae_d20s0;
            		}
            		switch (alt20) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:148:6: ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT
            		        {
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:148:6: ( subtractive_exp | dotproduct | matrixtranspose | string_literal )
            		        	int alt19 = 4;
            		        	switch ( input.LA(1) ) 
            		        	{
            		        	case INT_LITERAL:
            		        	case DOUBLE_LITERAL:
            		        	case LEFTBRACE:
            		        		{
            		        	    alt19 = 1;
            		        	    }
            		        	    break;
            		        	case VARIABLE:
            		        		{
            		        	    int LA19_2 = input.LA(2);

            		        	    if ( (LA19_2 == END_OF_STATEMENT || (LA19_2 >= DOT && LA19_2 <= MULTIPLY) || LA19_2 == 29 || LA19_2 == 33) )
            		        	    {
            		        	        alt19 = 1;
            		        	    }
            		        	    else if ( (LA19_2 == 44) )
            		        	    {
            		        	        alt19 = 2;
            		        	    }
            		        	    else 
            		        	    {
            		        	        NoViableAltException nvae_d19s2 =
            		        	            new NoViableAltException("", 19, 2, input);

            		        	        throw nvae_d19s2;
            		        	    }
            		        	    }
            		        	    break;
            		        	case 45:
            		        		{
            		        	    alt19 = 3;
            		        	    }
            		        	    break;
            		        	case 27:
            		        		{
            		        	    alt19 = 4;
            		        	    }
            		        	    break;
            		        		default:
            		        		    NoViableAltException nvae_d19s0 =
            		        		        new NoViableAltException("", 19, 0, input);

            		        		    throw nvae_d19s0;
            		        	}

            		        	switch (alt19) 
            		        	{
            		        	    case 1 :
            		        	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:148:8: subtractive_exp
            		        	        {
            		        	        	PushFollow(FOLLOW_subtractive_exp_in_assignment856);
            		        	        	subtractive_exp65 = subtractive_exp();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, subtractive_exp65.Tree);
            		        	        	retval.ret.setRhs(((subtractive_exp65 != null) ? subtractive_exp65.ret : null));

            		        	        }
            		        	        break;
            		        	    case 2 :
            		        	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:148:67: dotproduct
            		        	        {
            		        	        	PushFollow(FOLLOW_dotproduct_in_assignment860);
            		        	        	dotproduct66 = dotproduct();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, dotproduct66.Tree);
            		        	        	retval.ret.setRhs(((dotproduct66 != null) ? dotproduct66.ret : null));

            		        	        }
            		        	        break;
            		        	    case 3 :
            		        	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:149:7: matrixtranspose
            		        	        {
            		        	        	PushFollow(FOLLOW_matrixtranspose_in_assignment869);
            		        	        	matrixtranspose67 = matrixtranspose();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, matrixtranspose67.Tree);
            		        	        	retval.ret.setRhs(((matrixtranspose67 != null) ? matrixtranspose67.ret : null));

            		        	        }
            		        	        break;
            		        	    case 4 :
            		        	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:149:66: string_literal
            		        	        {
            		        	        	PushFollow(FOLLOW_string_literal_in_assignment873);
            		        	        	string_literal68 = string_literal();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, string_literal68.Tree);
            		        	        	retval.ret.setRhs(((string_literal68 != null) ? string_literal68.ret : null));

            		        	        }
            		        	        break;

            		        	}

            		        	END_OF_STATEMENT69=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment881); 
            		        		END_OF_STATEMENT69_tree = (object)adaptor.Create(END_OF_STATEMENT69);
            		        		adaptor.AddChild(root_0, END_OF_STATEMENT69_tree);


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:151:7: functioncall
            		        {
            		        	PushFollow(FOLLOW_functioncall_in_assignment889);
            		        	functioncall70 = functioncall();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, functioncall70.Tree);
            		        	retval.ret.setRhs(((functioncall70 != null) ? functioncall70.ret : null));

            		        }
            		        break;

            		}


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
    // $ANTLR end "assignment"

    public class additive_expression_return : ParserRuleReturnScope
    {
        public AdditiveElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "additive_expression"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:154:1: additive_expression returns [AdditiveElement ret] : ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) ;
    public spinachParser.additive_expression_return additive_expression() // throws RecognitionException [1]
    {   
        spinachParser.additive_expression_return retval = new spinachParser.additive_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal71 = null;
        spinachParser.multiplicative_expression_return e11 = null;

        spinachParser.additive_expression_return e12 = null;


        object char_literal71_tree=null;


        	retval.ret = new AdditiveElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:158:2: ( ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:158:4: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:158:4: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:158:5: (e11= multiplicative_expression ) ( '+' e12= additive_expression )*
            	{
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:158:5: (e11= multiplicative_expression )
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:158:6: e11= multiplicative_expression
            		{
            			PushFollow(FOLLOW_multiplicative_expression_in_additive_expression920);
            			e11 = multiplicative_expression();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, e11.Tree);
            			retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		}

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:158:69: ( '+' e12= additive_expression )*
            		do 
            		{
            		    int alt21 = 2;
            		    int LA21_0 = input.LA(1);

            		    if ( (LA21_0 == PLUS) )
            		    {
            		        alt21 = 1;
            		    }


            		    switch (alt21) 
            			{
            				case 1 :
            				    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:158:70: '+' e12= additive_expression
            				    {
            				    	char_literal71=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_additive_expression925); 
            				    		char_literal71_tree = (object)adaptor.Create(char_literal71);
            				    		adaptor.AddChild(root_0, char_literal71_tree);

            				    	PushFollow(FOLLOW_additive_expression_in_additive_expression931);
            				    	e12 = additive_expression();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop21;
            		    }
            		} while (true);

            		loop21:
            			;	// Stops C# compiler whining that label 'loop21' has no statements


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
    // $ANTLR end "additive_expression"

    public class multiplicative_expression_return : ParserRuleReturnScope
    {
        public MultiplicationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplicative_expression"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:161:1: multiplicative_expression returns [MultiplicationElement ret] : (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )* ;
    public spinachParser.multiplicative_expression_return multiplicative_expression() // throws RecognitionException [1]
    {   
        spinachParser.multiplicative_expression_return retval = new spinachParser.multiplicative_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal72 = null;
        spinachParser.var_int_or_double_literal_return e11 = null;

        spinachParser.bracket_exp_return e12 = null;

        spinachParser.matrixelem_return el3 = null;

        spinachParser.vectorelem_return el4 = null;

        spinachParser.multiplicative_expression_return el5 = null;


        object char_literal72_tree=null;


        	retval.ret = new MultiplicationElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:165:2: ( (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )* )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:165:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:165:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem )
            	int alt22 = 4;
            	alt22 = dfa22.Predict(input);
            	switch (alt22) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:165:5: e11= var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplicative_expression959);
            	        	e11 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e11.Tree);
            	        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:166:7: e12= bracket_exp
            	        {
            	        	PushFollow(FOLLOW_bracket_exp_in_multiplicative_expression971);
            	        	e12 = bracket_exp();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e12.Tree);
            	        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:167:7: el3= matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_multiplicative_expression984);
            	        	el3 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el3.Tree);
            	        	retval.ret.setLhs(((el3 != null) ? el3.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:168:7: el4= vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_multiplicative_expression997);
            	        	el4 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	retval.ret.setLhs(((el4 != null) ? el4.ret : null));

            	        }
            	        break;

            	}

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:169:5: ( '*' el5= multiplicative_expression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( (LA23_0 == MULTIPLY) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:169:6: '*' el5= multiplicative_expression
            			    {
            			    	char_literal72=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplicative_expression1006); 
            			    		char_literal72_tree = (object)adaptor.Create(char_literal72);
            			    		adaptor.AddChild(root_0, char_literal72_tree);

            			    	PushFollow(FOLLOW_multiplicative_expression_in_multiplicative_expression1016);
            			    	el5 = multiplicative_expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, el5.Tree);
            			    	retval.ret.setRhs(el5.ret);

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements


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
    // $ANTLR end "multiplicative_expression"

    public class bracket_exp_return : ParserRuleReturnScope
    {
        public BracketElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bracket_exp"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:176:1: bracket_exp returns [BracketElement ret] : '(' subtractive_exp ')' ;
    public spinachParser.bracket_exp_return bracket_exp() // throws RecognitionException [1]
    {   
        spinachParser.bracket_exp_return retval = new spinachParser.bracket_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal73 = null;
        IToken char_literal75 = null;
        spinachParser.subtractive_exp_return subtractive_exp74 = null;


        object char_literal73_tree=null;
        object char_literal75_tree=null;


        	retval.ret = new BracketElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:180:1: ( '(' subtractive_exp ')' )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:180:3: '(' subtractive_exp ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal73=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_bracket_exp1062); 
            		char_literal73_tree = (object)adaptor.Create(char_literal73);
            		adaptor.AddChild(root_0, char_literal73_tree);

            	PushFollow(FOLLOW_subtractive_exp_in_bracket_exp1063);
            	subtractive_exp74 = subtractive_exp();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, subtractive_exp74.Tree);
            	retval.ret.setbracketexpression(((subtractive_exp74 != null) ? subtractive_exp74.ret : null));
            	char_literal75=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_bracket_exp1065); 
            		char_literal75_tree = (object)adaptor.Create(char_literal75);
            		adaptor.AddChild(root_0, char_literal75_tree);


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
    // $ANTLR end "bracket_exp"

    public class subtractive_exp_return : ParserRuleReturnScope
    {
        public SubtractionElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "subtractive_exp"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:186:1: subtractive_exp returns [SubtractionElement ret] : (e11= additive_expression ( '-' e12= subtractive_exp )* ) ;
    public spinachParser.subtractive_exp_return subtractive_exp() // throws RecognitionException [1]
    {   
        spinachParser.subtractive_exp_return retval = new spinachParser.subtractive_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal76 = null;
        spinachParser.additive_expression_return e11 = null;

        spinachParser.subtractive_exp_return e12 = null;


        object char_literal76_tree=null;


        	retval.ret = new SubtractionElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:190:1: ( (e11= additive_expression ( '-' e12= subtractive_exp )* ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:190:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:190:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:190:7: e11= additive_expression ( '-' e12= subtractive_exp )*
            	{
            		PushFollow(FOLLOW_additive_expression_in_subtractive_exp1094);
            		e11 = additive_expression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, e11.Tree);
            		retval.ret.setLhs(((e11 != null) ? e11.ret : null));
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:190:64: ( '-' e12= subtractive_exp )*
            		do 
            		{
            		    int alt24 = 2;
            		    int LA24_0 = input.LA(1);

            		    if ( (LA24_0 == 33) )
            		    {
            		        alt24 = 1;
            		    }


            		    switch (alt24) 
            			{
            				case 1 :
            				    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:190:65: '-' e12= subtractive_exp
            				    {
            				    	char_literal76=(IToken)Match(input,33,FOLLOW_33_in_subtractive_exp1099); 
            				    		char_literal76_tree = (object)adaptor.Create(char_literal76);
            				    		adaptor.AddChild(root_0, char_literal76_tree);

            				    	PushFollow(FOLLOW_subtractive_exp_in_subtractive_exp1105);
            				    	e12 = subtractive_exp();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop24;
            		    }
            		} while (true);

            		loop24:
            			;	// Stops C# compiler whining that label 'loop24' has no statements


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
    // $ANTLR end "subtractive_exp"

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:194:1: structdec returns [StructDeclaration ret] : ( 'struct' variable ( ( '{' '}' ) | '{' (el1= scalarvardec )+ '}' ) ) END_OF_STATEMENT ;
    public spinachParser.structdec_return structdec() // throws RecognitionException [1]
    {   
        spinachParser.structdec_return retval = new spinachParser.structdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal77 = null;
        IToken char_literal79 = null;
        IToken char_literal80 = null;
        IToken char_literal81 = null;
        IToken char_literal82 = null;
        IToken END_OF_STATEMENT83 = null;
        spinachParser.scalarvardec_return el1 = null;

        spinachParser.variable_return variable78 = null;


        object string_literal77_tree=null;
        object char_literal79_tree=null;
        object char_literal80_tree=null;
        object char_literal81_tree=null;
        object char_literal82_tree=null;
        object END_OF_STATEMENT83_tree=null;


        retval.ret = new StructDeclaration();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:198:1: ( ( 'struct' variable ( ( '{' '}' ) | '{' (el1= scalarvardec )+ '}' ) ) END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:198:3: ( 'struct' variable ( ( '{' '}' ) | '{' (el1= scalarvardec )+ '}' ) ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:198:3: ( 'struct' variable ( ( '{' '}' ) | '{' (el1= scalarvardec )+ '}' ) )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:198:4: 'struct' variable ( ( '{' '}' ) | '{' (el1= scalarvardec )+ '}' )
            	{
            		string_literal77=(IToken)Match(input,34,FOLLOW_34_in_structdec1135); 
            			string_literal77_tree = (object)adaptor.Create(string_literal77);
            			adaptor.AddChild(root_0, string_literal77_tree);

            		PushFollow(FOLLOW_variable_in_structdec1137);
            		variable78 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable78.Tree);
            		 retval.ret.setName(((variable78 != null) ? variable78.ret : null));
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:199:1: ( ( '{' '}' ) | '{' (el1= scalarvardec )+ '}' )
            		int alt26 = 2;
            		int LA26_0 = input.LA(1);

            		if ( (LA26_0 == LEFTPARANTHESIS) )
            		{
            		    int LA26_1 = input.LA(2);

            		    if ( (LA26_1 == RIGHTPARANTHESIS) )
            		    {
            		        alt26 = 1;
            		    }
            		    else if ( (LA26_1 == VARTYPE || LA26_1 == STRINGTYPE) )
            		    {
            		        alt26 = 2;
            		    }
            		    else 
            		    {
            		        NoViableAltException nvae_d26s1 =
            		            new NoViableAltException("", 26, 1, input);

            		        throw nvae_d26s1;
            		    }
            		}
            		else 
            		{
            		    NoViableAltException nvae_d26s0 =
            		        new NoViableAltException("", 26, 0, input);

            		    throw nvae_d26s0;
            		}
            		switch (alt26) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:199:2: ( '{' '}' )
            		        {
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:199:2: ( '{' '}' )
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:199:3: '{' '}'
            		        	{
            		        		char_literal79=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_structdec1143); 
            		        			char_literal79_tree = (object)adaptor.Create(char_literal79);
            		        			adaptor.AddChild(root_0, char_literal79_tree);

            		        		char_literal80=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_structdec1144); 
            		        			char_literal80_tree = (object)adaptor.Create(char_literal80);
            		        			adaptor.AddChild(root_0, char_literal80_tree);


            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:200:1: '{' (el1= scalarvardec )+ '}'
            		        {
            		        	char_literal81=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_structdec1148); 
            		        		char_literal81_tree = (object)adaptor.Create(char_literal81);
            		        		adaptor.AddChild(root_0, char_literal81_tree);

            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:200:5: (el1= scalarvardec )+
            		        	int cnt25 = 0;
            		        	do 
            		        	{
            		        	    int alt25 = 2;
            		        	    int LA25_0 = input.LA(1);

            		        	    if ( (LA25_0 == VARTYPE || LA25_0 == STRINGTYPE) )
            		        	    {
            		        	        alt25 = 1;
            		        	    }


            		        	    switch (alt25) 
            		        		{
            		        			case 1 :
            		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:200:6: el1= scalarvardec
            		        			    {
            		        			    	PushFollow(FOLLOW_scalarvardec_in_structdec1153);
            		        			    	el1 = scalarvardec();
            		        			    	state.followingStackPointer--;

            		        			    	adaptor.AddChild(root_0, el1.Tree);
            		        			    	 retval.ret.setVarType(((el1 != null) ? el1.ret : null));

            		        			    }
            		        			    break;

            		        			default:
            		        			    if ( cnt25 >= 1 ) goto loop25;
            		        		            EarlyExitException eee25 =
            		        		                new EarlyExitException(25, input);
            		        		            throw eee25;
            		        	    }
            		        	    cnt25++;
            		        	} while (true);

            		        	loop25:
            		        		;	// Stops C# compiler whinging that label 'loop25' has no statements

            		        	char_literal82=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_structdec1158); 
            		        		char_literal82_tree = (object)adaptor.Create(char_literal82);
            		        		adaptor.AddChild(root_0, char_literal82_tree);


            		        }
            		        break;

            		}

            		retval.ret.setVar();

            	}

            	END_OF_STATEMENT83=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec1163); 
            		END_OF_STATEMENT83_tree = (object)adaptor.Create(END_OF_STATEMENT83);
            		adaptor.AddChild(root_0, END_OF_STATEMENT83_tree);


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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:203:1: scalarvardec returns [ScalarVariableDeclaration ret] : ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT ;
    public spinachParser.scalarvardec_return scalarvardec() // throws RecognitionException [1]
    {   
        spinachParser.scalarvardec_return retval = new spinachParser.scalarvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE84 = null;
        IToken STRINGTYPE85 = null;
        IToken END_OF_STATEMENT87 = null;
        spinachParser.variable_return variable86 = null;


        object VARTYPE84_tree=null;
        object STRINGTYPE85_tree=null;
        object END_OF_STATEMENT87_tree=null;


        	retval.ret = new ScalarVariableDeclaration();
        	
        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:207:2: ( ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:207:3: ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:207:3: ( ( VARTYPE | STRINGTYPE ) variable )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:207:4: ( VARTYPE | STRINGTYPE ) variable
            	{
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:207:4: ( VARTYPE | STRINGTYPE )
            		int alt27 = 2;
            		int LA27_0 = input.LA(1);

            		if ( (LA27_0 == VARTYPE) )
            		{
            		    alt27 = 1;
            		}
            		else if ( (LA27_0 == STRINGTYPE) )
            		{
            		    alt27 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d27s0 =
            		        new NoViableAltException("", 27, 0, input);

            		    throw nvae_d27s0;
            		}
            		switch (alt27) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:207:5: VARTYPE
            		        {
            		        	VARTYPE84=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarvardec1184); 
            		        		VARTYPE84_tree = (object)adaptor.Create(VARTYPE84);
            		        		adaptor.AddChild(root_0, VARTYPE84_tree);

            		        	 retval.ret.setType(((VARTYPE84 != null) ? VARTYPE84.Text : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:208:4: STRINGTYPE
            		        {
            		        	STRINGTYPE85=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_scalarvardec1191); 
            		        		STRINGTYPE85_tree = (object)adaptor.Create(STRINGTYPE85);
            		        		adaptor.AddChild(root_0, STRINGTYPE85_tree);

            		        	 retval.ret.setType(((STRINGTYPE85 != null) ? STRINGTYPE85.Text : null));

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_variable_in_scalarvardec1198);
            		variable86 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable86.Tree);
            		 retval.ret.setVar(((variable86 != null) ? variable86.ret : null));

            	}

            	END_OF_STATEMENT87=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_scalarvardec1202); 
            		END_OF_STATEMENT87_tree = (object)adaptor.Create(END_OF_STATEMENT87);
            		adaptor.AddChild(root_0, END_OF_STATEMENT87_tree);


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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:212:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
    public spinachParser.structobjdec_return structobjdec() // throws RecognitionException [1]
    {   
        spinachParser.structobjdec_return retval = new spinachParser.structobjdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT88 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object END_OF_STATEMENT88_tree=null;


        retval.ret = new StructObjectDeclaration();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:216:1: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:216:3: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:216:3: (el1= variable el2= variable )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:216:4: el1= variable el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structobjdec1224);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		PushFollow(FOLLOW_variable_in_structobjdec1231);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	END_OF_STATEMENT88=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec1237); 
            		END_OF_STATEMENT88_tree = (object)adaptor.Create(END_OF_STATEMENT88);
            		adaptor.AddChild(root_0, END_OF_STATEMENT88_tree);


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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:219:2: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
    public spinachParser.structassign_return structassign() // throws RecognitionException [1]
    {   
        spinachParser.structassign_return retval = new spinachParser.structassign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal89 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object char_literal89_tree=null;


        retval.ret = new StructAssignDeclaration();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:223:1: ( (el1= variable '.' el2= variable ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:223:2: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:223:2: (el1= variable '.' el2= variable )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:223:3: el1= variable '.' el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structassign1256);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setObjName(((el1 != null) ? el1.ret : null));
            		char_literal89=(IToken)Match(input,DOT,FOLLOW_DOT_in_structassign1259); 
            			char_literal89_tree = (object)adaptor.Create(char_literal89);
            			adaptor.AddChild(root_0, char_literal89_tree);

            		PushFollow(FOLLOW_variable_in_structassign1262);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setDataMember(((el2 != null) ? el2.ret : null));

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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:226:1: deletionofvar returns [DeleteVariable ret] : ( 'delete' el1= variable ) END_OF_STATEMENT ;
    public spinachParser.deletionofvar_return deletionofvar() // throws RecognitionException [1]
    {   
        spinachParser.deletionofvar_return retval = new spinachParser.deletionofvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal90 = null;
        IToken END_OF_STATEMENT91 = null;
        spinachParser.variable_return el1 = null;


        object string_literal90_tree=null;
        object END_OF_STATEMENT91_tree=null;


        retval.ret = new DeleteVariable();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:230:1: ( ( 'delete' el1= variable ) END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:230:2: ( 'delete' el1= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:230:2: ( 'delete' el1= variable )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:230:3: 'delete' el1= variable
            	{
            		string_literal90=(IToken)Match(input,35,FOLLOW_35_in_deletionofvar1283); 
            			string_literal90_tree = (object)adaptor.Create(string_literal90);
            			adaptor.AddChild(root_0, string_literal90_tree);

            		PushFollow(FOLLOW_variable_in_deletionofvar1287);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setVar(((el1 != null) ? el1.ret : null));

            	}

            	END_OF_STATEMENT91=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_deletionofvar1291); 
            		END_OF_STATEMENT91_tree = (object)adaptor.Create(END_OF_STATEMENT91);
            		adaptor.AddChild(root_0, END_OF_STATEMENT91_tree);


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
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:232:1: print returns [PrintOperationElement ret] : 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT ;
    public spinachParser.print_return print() // throws RecognitionException [1]
    {   
        spinachParser.print_return retval = new spinachParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal92 = null;
        IToken END_OF_STATEMENT97 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal93 = null;

        spinachParser.string_literal_return string_literal94 = null;

        spinachParser.vectorelem_return vectorelem95 = null;

        spinachParser.matrixelem_return matrixelem96 = null;


        object string_literal92_tree=null;
        object END_OF_STATEMENT97_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:236:3: ( 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:236:5: 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal92=(IToken)Match(input,36,FOLLOW_36_in_print1310); 
            		string_literal92_tree = (object)adaptor.Create(string_literal92);
            		adaptor.AddChild(root_0, string_literal92_tree);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:236:13: ( var_int_or_double_literal | string_literal | vectorelem | matrixelem )
            	int alt28 = 4;
            	alt28 = dfa28.Predict(input);
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:236:14: var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_print1313);
            	        	var_int_or_double_literal93 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_int_or_double_literal93.Tree);
            	        	retval.ret.setChildElement(((var_int_or_double_literal93 != null) ? var_int_or_double_literal93.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:237:6: string_literal
            	        {
            	        	PushFollow(FOLLOW_string_literal_in_print1322);
            	        	string_literal94 = string_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, string_literal94.Tree);
            	        	retval.ret.setChildElement(((string_literal94 != null) ? string_literal94.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:238:6: vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_print1330);
            	        	vectorelem95 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorelem95.Tree);
            	        	retval.ret.setChildElement(((vectorelem95 != null) ? vectorelem95.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:239:8: matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_print1341);
            	        	matrixelem96 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixelem96.Tree);
            	        	retval.ret.setChildElement(((matrixelem96 != null) ? matrixelem96.ret : null));

            	        }
            	        break;

            	}

            	END_OF_STATEMENT97=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print1355); 
            		END_OF_STATEMENT97_tree = (object)adaptor.Create(END_OF_STATEMENT97);
            		adaptor.AddChild(root_0, END_OF_STATEMENT97_tree);


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

    public class parallelfor_return : ParserRuleReturnScope
    {
        public ParallelForElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parallelfor"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:244:1: parallelfor returns [ParallelForElement ret] : 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS ;
    public spinachParser.parallelfor_return parallelfor() // throws RecognitionException [1]
    {   
        spinachParser.parallelfor_return retval = new spinachParser.parallelfor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal98 = null;
        IToken LEFTBRACE99 = null;
        IToken POINT100 = null;
        IToken string_literal101 = null;
        IToken RIGHTBRACE102 = null;
        IToken LEFTPARANTHESIS103 = null;
        IToken string_literal104 = null;
        IToken END_OF_STATEMENT105 = null;
        IToken RIGHTPARANTHESIS106 = null;
        spinachParser.variable_return r11 = null;

        spinachParser.int_literal_return r12 = null;

        spinachParser.int_literal_return r13 = null;

        spinachParser.expr2_return e11 = null;


        object string_literal98_tree=null;
        object LEFTBRACE99_tree=null;
        object POINT100_tree=null;
        object string_literal101_tree=null;
        object RIGHTBRACE102_tree=null;
        object LEFTPARANTHESIS103_tree=null;
        object string_literal104_tree=null;
        object END_OF_STATEMENT105_tree=null;
        object RIGHTPARANTHESIS106_tree=null;


          retval.ret = new ParallelForElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:2: ( 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:4: 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal98=(IToken)Match(input,37,FOLLOW_37_in_parallelfor1377); 
            		string_literal98_tree = (object)adaptor.Create(string_literal98);
            		adaptor.AddChild(root_0, string_literal98_tree);

            	LEFTBRACE99=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_parallelfor1378); 
            		LEFTBRACE99_tree = (object)adaptor.Create(LEFTBRACE99);
            		adaptor.AddChild(root_0, LEFTBRACE99_tree);

            	PushFollow(FOLLOW_variable_in_parallelfor1384);
            	r11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGEVARIABLE = ((r11 != null) ? r11.ret : null);
            	POINT100=(IToken)Match(input,POINT,FOLLOW_POINT_in_parallelfor1387); 
            		POINT100_tree = (object)adaptor.Create(POINT100);
            		adaptor.AddChild(root_0, POINT100_tree);

            	PushFollow(FOLLOW_int_literal_in_parallelfor1393);
            	r12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r12.Tree);
            	retval.ret.STARTINGRANGE = ((r12 != null) ? r12.ret : null);
            	string_literal101=(IToken)Match(input,38,FOLLOW_38_in_parallelfor1396); 
            		string_literal101_tree = (object)adaptor.Create(string_literal101);
            		adaptor.AddChild(root_0, string_literal101_tree);

            	PushFollow(FOLLOW_int_literal_in_parallelfor1401);
            	r13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r13.Tree);
            	retval.ret.ENDINGRANGE = ((r13 != null) ? r13.ret : null);
            	RIGHTBRACE102=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_parallelfor1404); 
            		RIGHTBRACE102_tree = (object)adaptor.Create(RIGHTBRACE102);
            		adaptor.AddChild(root_0, RIGHTBRACE102_tree);

            	LEFTPARANTHESIS103=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_parallelfor1406); 
            		LEFTPARANTHESIS103_tree = (object)adaptor.Create(LEFTPARANTHESIS103);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS103_tree);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:228: ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+
            	int cnt31 = 0;
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == VARIABLE || LA31_0 == VARTYPE || LA31_0 == STRINGTYPE || LA31_0 == 35 || LA31_0 == 40 || LA31_0 == 42 || LA31_0 == 46) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:229: (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    {
            			    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:229: (e11= expr2 )+
            			    	int cnt29 = 0;
            			    	do 
            			    	{
            			    	    int alt29 = 2;
            			    	    switch ( input.LA(1) ) 
            			    	    {
            			    	    case VARIABLE:
            			    	    	{
            			    	        alt29 = 1;
            			    	        }
            			    	        break;
            			    	    case 40:
            			    	    	{
            			    	        alt29 = 1;
            			    	        }
            			    	        break;
            			    	    case 42:
            			    	    	{
            			    	        alt29 = 1;
            			    	        }
            			    	        break;
            			    	    case 46:
            			    	    	{
            			    	        alt29 = 1;
            			    	        }
            			    	        break;
            			    	    case VARTYPE:
            			    	    	{
            			    	        alt29 = 1;
            			    	        }
            			    	        break;
            			    	    case STRINGTYPE:
            			    	    	{
            			    	        alt29 = 1;
            			    	        }
            			    	        break;
            			    	    case 35:
            			    	    	{
            			    	        alt29 = 1;
            			    	        }
            			    	        break;

            			    	    }

            			    	    switch (alt29) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:230: e11= expr2
            			    			    {
            			    			    	PushFollow(FOLLOW_expr2_in_parallelfor1413);
            			    			    	e11 = expr2();
            			    			    	state.followingStackPointer--;

            			    			    	adaptor.AddChild(root_0, e11.Tree);
            			    			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt29 >= 1 ) goto loop29;
            			    		            EarlyExitException eee29 =
            			    		                new EarlyExitException(29, input);
            			    		            throw eee29;
            			    	    }
            			    	    cnt29++;
            			    	} while (true);

            			    	loop29:
            			    		;	// Stops C# compiler whinging that label 'loop29' has no statements

            			    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:272: ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    	int alt30 = 2;
            			    	int LA30_0 = input.LA(1);

            			    	if ( (LA30_0 == 39) )
            			    	{
            			    	    alt30 = 1;
            			    	}
            			    	else if ( (LA30_0 == VARIABLE || LA30_0 == VARTYPE || LA30_0 == STRINGTYPE || LA30_0 == RIGHTPARANTHESIS || LA30_0 == 35 || LA30_0 == 40 || LA30_0 == 42 || LA30_0 == 46) )
            			    	{
            			    	    alt30 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d30s0 =
            			    	        new NoViableAltException("", 30, 0, input);

            			    	    throw nvae_d30s0;
            			    	}
            			    	switch (alt30) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:273: ( 'SYNC' END_OF_STATEMENT )
            			    	        {
            			    	        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:273: ( 'SYNC' END_OF_STATEMENT )
            			    	        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:274: 'SYNC' END_OF_STATEMENT
            			    	        	{
            			    	        		string_literal104=(IToken)Match(input,39,FOLLOW_39_in_parallelfor1419); 
            			    	        			string_literal104_tree = (object)adaptor.Create(string_literal104);
            			    	        			adaptor.AddChild(root_0, string_literal104_tree);

            			    	        		retval.ret.syncfunction();
            			    	        		END_OF_STATEMENT105=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_parallelfor1422); 
            			    	        			END_OF_STATEMENT105_tree = (object)adaptor.Create(END_OF_STATEMENT105);
            			    	        			adaptor.AddChild(root_0, END_OF_STATEMENT105_tree);


            			    	        	}


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:247:327: 
            			    	        {
            			    	        	retval.ret.syncfunction();

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt31 >= 1 ) goto loop31;
            		            EarlyExitException eee31 =
            		                new EarlyExitException(31, input);
            		            throw eee31;
            	    }
            	    cnt31++;
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whinging that label 'loop31' has no statements

            	RIGHTPARANTHESIS106=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_parallelfor1430); 
            		RIGHTPARANTHESIS106_tree = (object)adaptor.Create(RIGHTPARANTHESIS106);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS106_tree);


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
    // $ANTLR end "parallelfor"

    public class ifelse_return : ParserRuleReturnScope
    {
        public IfStatementElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifelse"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:250:1: ifelse returns [IfStatementElement ret] : ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? ;
    public spinachParser.ifelse_return ifelse() // throws RecognitionException [1]
    {   
        spinachParser.ifelse_return retval = new spinachParser.ifelse_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal107 = null;
        IToken LEFTBRACE108 = null;
        IToken string_literal110 = null;
        IToken string_literal111 = null;
        IToken char_literal112 = null;
        IToken string_literal113 = null;
        IToken char_literal114 = null;
        IToken string_literal115 = null;
        IToken RIGHTBRACE116 = null;
        IToken LEFTPARANTHESIS117 = null;
        IToken RIGHTPARANTHESIS118 = null;
        IToken string_literal119 = null;
        IToken LEFTPARANTHESIS120 = null;
        IToken RIGHTPARANTHESIS121 = null;
        spinachParser.var_int_or_double_literal_return e13 = null;

        spinachParser.string_literal_return e14 = null;

        spinachParser.ifloop_return e11 = null;

        spinachParser.ifloop_return e12 = null;

        spinachParser.varorstruct_return varorstruct109 = null;


        object string_literal107_tree=null;
        object LEFTBRACE108_tree=null;
        object string_literal110_tree=null;
        object string_literal111_tree=null;
        object char_literal112_tree=null;
        object string_literal113_tree=null;
        object char_literal114_tree=null;
        object string_literal115_tree=null;
        object RIGHTBRACE116_tree=null;
        object LEFTPARANTHESIS117_tree=null;
        object RIGHTPARANTHESIS118_tree=null;
        object string_literal119_tree=null;
        object LEFTPARANTHESIS120_tree=null;
        object RIGHTPARANTHESIS121_tree=null;


           retval.ret = new IfStatementElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:254:1: ( ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:254:2: ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:254:2: ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:254:3: 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS
            	{
            		string_literal107=(IToken)Match(input,40,FOLLOW_40_in_ifelse1447); 
            			string_literal107_tree = (object)adaptor.Create(string_literal107);
            			adaptor.AddChild(root_0, string_literal107_tree);

            		LEFTBRACE108=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_ifelse1449); 
            			LEFTBRACE108_tree = (object)adaptor.Create(LEFTBRACE108);
            			adaptor.AddChild(root_0, LEFTBRACE108_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:254:18: ( varorstruct )
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:254:19: varorstruct
            		{
            			PushFollow(FOLLOW_varorstruct_in_ifelse1452);
            			varorstruct109 = varorstruct();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, varorstruct109.Tree);
            			retval.ret.setLhs(((varorstruct109 != null) ? varorstruct109.ret : null));

            		}

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:254:69: ( '==' | '!=' | '<' | '<=' | '>' | '>=' )
            		int alt32 = 6;
            		switch ( input.LA(1) ) 
            		{
            		case EQUALITYEXPRESSION:
            			{
            		    alt32 = 1;
            		    }
            		    break;
            		case NONEQUALITYEXPRESSION:
            			{
            		    alt32 = 2;
            		    }
            		    break;
            		case LESSTHANEXPRESSION:
            			{
            		    alt32 = 3;
            		    }
            		    break;
            		case LESSTHANEQUALTOEXPRESSION:
            			{
            		    alt32 = 4;
            		    }
            		    break;
            		case GREATERTHANEXPRESSION:
            			{
            		    alt32 = 5;
            		    }
            		    break;
            		case GREATERTHANEQUALTOEXPRESSION:
            			{
            		    alt32 = 6;
            		    }
            		    break;
            			default:
            			    NoViableAltException nvae_d32s0 =
            			        new NoViableAltException("", 32, 0, input);

            			    throw nvae_d32s0;
            		}

            		switch (alt32) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:255:7: '=='
            		        {
            		        	string_literal110=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_ifelse1463); 
            		        		string_literal110_tree = (object)adaptor.Create(string_literal110);
            		        		adaptor.AddChild(root_0, string_literal110_tree);

            		        	 retval.ret.OP = "eq"; 

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:256:7: '!='
            		        {
            		        	string_literal111=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_ifelse1473); 
            		        		string_literal111_tree = (object)adaptor.Create(string_literal111);
            		        		adaptor.AddChild(root_0, string_literal111_tree);

            		        	 retval.ret.OP = "ne"; 

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:257:7: '<'
            		        {
            		        	char_literal112=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_ifelse1483); 
            		        		char_literal112_tree = (object)adaptor.Create(char_literal112);
            		        		adaptor.AddChild(root_0, char_literal112_tree);

            		        	 retval.ret.OP = "lt"; 

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:258:7: '<='
            		        {
            		        	string_literal113=(IToken)Match(input,LESSTHANEQUALTOEXPRESSION,FOLLOW_LESSTHANEQUALTOEXPRESSION_in_ifelse1494); 
            		        		string_literal113_tree = (object)adaptor.Create(string_literal113);
            		        		adaptor.AddChild(root_0, string_literal113_tree);

            		        	 retval.ret.OP = "le"; 

            		        }
            		        break;
            		    case 5 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:259:7: '>'
            		        {
            		        	char_literal114=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_ifelse1504); 
            		        		char_literal114_tree = (object)adaptor.Create(char_literal114);
            		        		adaptor.AddChild(root_0, char_literal114_tree);

            		        	 retval.ret.OP = "gt"; 

            		        }
            		        break;
            		    case 6 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:260:7: '>='
            		        {
            		        	string_literal115=(IToken)Match(input,GREATERTHANEQUALTOEXPRESSION,FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_ifelse1515); 
            		        		string_literal115_tree = (object)adaptor.Create(string_literal115);
            		        		adaptor.AddChild(root_0, string_literal115_tree);

            		        	 retval.ret.OP = "ge"; 

            		        }
            		        break;

            		}

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:1: (e13= var_int_or_double_literal | e14= string_literal )
            		int alt33 = 2;
            		int LA33_0 = input.LA(1);

            		if ( ((LA33_0 >= VARIABLE && LA33_0 <= DOUBLE_LITERAL)) )
            		{
            		    alt33 = 1;
            		}
            		else if ( (LA33_0 == 27) )
            		{
            		    alt33 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d33s0 =
            		        new NoViableAltException("", 33, 0, input);

            		    throw nvae_d33s0;
            		}
            		switch (alt33) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:2: e13= var_int_or_double_literal
            		        {
            		        	PushFollow(FOLLOW_var_int_or_double_literal_in_ifelse1528);
            		        	e13 = var_int_or_double_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e13.Tree);
            		        	retval.ret.setRhs(((e13 != null) ? e13.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:64: e14= string_literal
            		        {
            		        	PushFollow(FOLLOW_string_literal_in_ifelse1535);
            		        	e14 = string_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e14.Tree);
            		        	retval.ret.setRhs(((e14 != null) ? e14.ret : null));

            		        }
            		        break;

            		}

            		RIGHTBRACE116=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_ifelse1539); 
            			RIGHTBRACE116_tree = (object)adaptor.Create(RIGHTBRACE116);
            			adaptor.AddChild(root_0, RIGHTBRACE116_tree);

            		LEFTPARANTHESIS117=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1541); 
            			LEFTPARANTHESIS117_tree = (object)adaptor.Create(LEFTPARANTHESIS117);
            			adaptor.AddChild(root_0, LEFTPARANTHESIS117_tree);

            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:143: ( (e11= ifloop ) | )
            		int alt34 = 2;
            		int LA34_0 = input.LA(1);

            		if ( (LA34_0 == VARIABLE || LA34_0 == VARTYPE || LA34_0 == STRINGTYPE || LA34_0 == 28 || LA34_0 == 32 || (LA34_0 >= 35 && LA34_0 <= 36) || LA34_0 == 40 || LA34_0 == 42 || (LA34_0 >= 46 && LA34_0 <= 48) || (LA34_0 >= 52 && LA34_0 <= 56)) )
            		{
            		    alt34 = 1;
            		}
            		else if ( (LA34_0 == RIGHTPARANTHESIS) )
            		{
            		    alt34 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d34s0 =
            		        new NoViableAltException("", 34, 0, input);

            		    throw nvae_d34s0;
            		}
            		switch (alt34) 
            		{
            		    case 1 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:144: (e11= ifloop )
            		        {
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:144: (e11= ifloop )
            		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:145: e11= ifloop
            		        	{
            		        		PushFollow(FOLLOW_ifloop_in_ifelse1549);
            		        		e11 = ifloop();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, e11.Tree);
            		        		retval.ret.IFCODE = ((e11 != null) ? e11.ret : null);

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:190: 
            		        {
            		        }
            		        break;

            		}

            		RIGHTPARANTHESIS118=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1554); 
            			RIGHTPARANTHESIS118_tree = (object)adaptor.Create(RIGHTPARANTHESIS118);
            			adaptor.AddChild(root_0, RIGHTPARANTHESIS118_tree);


            	}

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:208: ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            	int alt36 = 2;
            	int LA36_0 = input.LA(1);

            	if ( (LA36_0 == 41) )
            	{
            	    alt36 = 1;
            	}
            	switch (alt36) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:209: 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS
            	        {
            	        	string_literal119=(IToken)Match(input,41,FOLLOW_41_in_ifelse1557); 
            	        		string_literal119_tree = (object)adaptor.Create(string_literal119);
            	        		adaptor.AddChild(root_0, string_literal119_tree);

            	        	LEFTPARANTHESIS120=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1560); 
            	        		LEFTPARANTHESIS120_tree = (object)adaptor.Create(LEFTPARANTHESIS120);
            	        		adaptor.AddChild(root_0, LEFTPARANTHESIS120_tree);

            	        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:233: ( (e12= ifloop ) | )
            	        	int alt35 = 2;
            	        	int LA35_0 = input.LA(1);

            	        	if ( (LA35_0 == VARIABLE || LA35_0 == VARTYPE || LA35_0 == STRINGTYPE || LA35_0 == 28 || LA35_0 == 32 || (LA35_0 >= 35 && LA35_0 <= 36) || LA35_0 == 40 || LA35_0 == 42 || (LA35_0 >= 46 && LA35_0 <= 48) || (LA35_0 >= 52 && LA35_0 <= 56)) )
            	        	{
            	        	    alt35 = 1;
            	        	}
            	        	else if ( (LA35_0 == RIGHTPARANTHESIS) )
            	        	{
            	        	    alt35 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    NoViableAltException nvae_d35s0 =
            	        	        new NoViableAltException("", 35, 0, input);

            	        	    throw nvae_d35s0;
            	        	}
            	        	switch (alt35) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:234: (e12= ifloop )
            	        	        {
            	        	        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:234: (e12= ifloop )
            	        	        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:235: e12= ifloop
            	        	        	{
            	        	        		PushFollow(FOLLOW_ifloop_in_ifelse1569);
            	        	        		e12 = ifloop();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, e12.Tree);
            	        	        		retval.ret.ELSECODE = ((e12 != null) ? e12.ret : null);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:262:283: 
            	        	        {
            	        	        }
            	        	        break;

            	        	}

            	        	RIGHTPARANTHESIS121=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1575); 
            	        		RIGHTPARANTHESIS121_tree = (object)adaptor.Create(RIGHTPARANTHESIS121);
            	        		adaptor.AddChild(root_0, RIGHTPARANTHESIS121_tree);


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
    // $ANTLR end "ifelse"

    public class ifloop_return : ParserRuleReturnScope
    {
        public List<Element> ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifloop"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:264:1: ifloop returns [List<Element> ret] : ( expr1 | functionreturn )+ ;
    public spinachParser.ifloop_return ifloop() // throws RecognitionException [1]
    {   
        spinachParser.ifloop_return retval = new spinachParser.ifloop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr1122 = null;

        spinachParser.functionreturn_return functionreturn123 = null;




           retval.ret = new List<Element>();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:269:1: ( ( expr1 | functionreturn )+ )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:269:3: ( expr1 | functionreturn )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:269:3: ( expr1 | functionreturn )+
            	int cnt37 = 0;
            	do 
            	{
            	    int alt37 = 3;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == VARIABLE || LA37_0 == VARTYPE || LA37_0 == STRINGTYPE || LA37_0 == 28 || LA37_0 == 32 || (LA37_0 >= 35 && LA37_0 <= 36) || LA37_0 == 40 || LA37_0 == 42 || LA37_0 == 46 || LA37_0 == 48 || (LA37_0 >= 52 && LA37_0 <= 56)) )
            	    {
            	        alt37 = 1;
            	    }
            	    else if ( (LA37_0 == 47) )
            	    {
            	        alt37 = 2;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:269:4: expr1
            			    {
            			    	PushFollow(FOLLOW_expr1_in_ifloop1596);
            			    	expr1122 = expr1();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1122.Tree);
            			    	retval.ret.Add(((expr1122 != null) ? expr1122.ret : null));

            			    }
            			    break;
            			case 2 :
            			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:269:39: functionreturn
            			    {
            			    	PushFollow(FOLLOW_functionreturn_in_ifloop1599);
            			    	functionreturn123 = functionreturn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, functionreturn123.Tree);
            			    	retval.ret.Add(((functionreturn123 != null) ? functionreturn123.ret : null));

            			    }
            			    break;

            			default:
            			    if ( cnt37 >= 1 ) goto loop37;
            		            EarlyExitException eee37 =
            		                new EarlyExitException(37, input);
            		            throw eee37;
            	    }
            	    cnt37++;
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whinging that label 'loop37' has no statements


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
    // $ANTLR end "ifloop"

    public class forstatement_return : ParserRuleReturnScope
    {
        public ForStatementElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forstatement"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:273:1: forstatement returns [ForStatementElement ret] : 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= forexpr )+ RIGHTPARANTHESIS ;
    public spinachParser.forstatement_return forstatement() // throws RecognitionException [1]
    {   
        spinachParser.forstatement_return retval = new spinachParser.forstatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal124 = null;
        IToken LEFTBRACE125 = null;
        IToken POINT126 = null;
        IToken string_literal127 = null;
        IToken RIGHTBRACE128 = null;
        IToken LEFTPARANTHESIS129 = null;
        IToken RIGHTPARANTHESIS130 = null;
        spinachParser.variable_return r11 = null;

        spinachParser.int_literal_return r12 = null;

        spinachParser.int_literal_return r13 = null;

        spinachParser.forexpr_return e11 = null;


        object string_literal124_tree=null;
        object LEFTBRACE125_tree=null;
        object POINT126_tree=null;
        object string_literal127_tree=null;
        object RIGHTBRACE128_tree=null;
        object LEFTPARANTHESIS129_tree=null;
        object RIGHTPARANTHESIS130_tree=null;


           retval.ret = new ForStatementElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:276:2: ( 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= forexpr )+ RIGHTPARANTHESIS )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:276:3: 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= forexpr )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal124=(IToken)Match(input,42,FOLLOW_42_in_forstatement1618); 
            		string_literal124_tree = (object)adaptor.Create(string_literal124);
            		adaptor.AddChild(root_0, string_literal124_tree);

            	LEFTBRACE125=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_forstatement1620); 
            		LEFTBRACE125_tree = (object)adaptor.Create(LEFTBRACE125);
            		adaptor.AddChild(root_0, LEFTBRACE125_tree);

            	PushFollow(FOLLOW_variable_in_forstatement1626);
            	r11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGEVARIABLE = ((r11 != null) ? r11.ret : null);
            	POINT126=(IToken)Match(input,POINT,FOLLOW_POINT_in_forstatement1629); 
            		POINT126_tree = (object)adaptor.Create(POINT126);
            		adaptor.AddChild(root_0, POINT126_tree);

            	PushFollow(FOLLOW_int_literal_in_forstatement1635);
            	r12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r12.Tree);
            	retval.ret.STARTINGRANGE = ((r12 != null) ? r12.ret : null);
            	string_literal127=(IToken)Match(input,38,FOLLOW_38_in_forstatement1638); 
            		string_literal127_tree = (object)adaptor.Create(string_literal127);
            		adaptor.AddChild(root_0, string_literal127_tree);

            	PushFollow(FOLLOW_int_literal_in_forstatement1643);
            	r13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r13.Tree);
            	retval.ret.ENDINGRANGE = ((r13 != null) ? r13.ret : null);
            	RIGHTBRACE128=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_forstatement1646); 
            		RIGHTBRACE128_tree = (object)adaptor.Create(RIGHTBRACE128);
            		adaptor.AddChild(root_0, RIGHTBRACE128_tree);

            	LEFTPARANTHESIS129=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_forstatement1648); 
            		LEFTPARANTHESIS129_tree = (object)adaptor.Create(LEFTPARANTHESIS129);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS129_tree);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:276:219: (e11= forexpr )+
            	int cnt38 = 0;
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == VARIABLE || LA38_0 == VARTYPE || LA38_0 == STRINGTYPE || LA38_0 == 28 || LA38_0 == 32 || LA38_0 == 35 || LA38_0 == 40 || LA38_0 == 42 || LA38_0 == 46 || LA38_0 == 48 || (LA38_0 >= 52 && LA38_0 <= 56)) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:276:220: e11= forexpr
            			    {
            			    	PushFollow(FOLLOW_forexpr_in_forstatement1653);
            			    	e11 = forexpr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e11.Tree);
            			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    }
            			    break;

            			default:
            			    if ( cnt38 >= 1 ) goto loop38;
            		            EarlyExitException eee38 =
            		                new EarlyExitException(38, input);
            		            throw eee38;
            	    }
            	    cnt38++;
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whinging that label 'loop38' has no statements

            	RIGHTPARANTHESIS130=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_forstatement1658); 
            		RIGHTPARANTHESIS130_tree = (object)adaptor.Create(RIGHTPARANTHESIS130);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS130_tree);


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
    // $ANTLR end "forstatement"

    public class functioncall_return : ParserRuleReturnScope
    {
        public FunctionCallElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functioncall"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:278:4: functioncall returns [FunctionCallElement ret] : variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT ;
    public spinachParser.functioncall_return functioncall() // throws RecognitionException [1]
    {   
        spinachParser.functioncall_return retval = new spinachParser.functioncall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal132 = null;
        IToken char_literal133 = null;
        IToken char_literal134 = null;
        IToken END_OF_STATEMENT135 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;

        spinachParser.string_literal_return e13 = null;

        spinachParser.var_int_or_double_literal_return el2 = null;

        spinachParser.variable_return variable131 = null;


        object char_literal132_tree=null;
        object char_literal133_tree=null;
        object char_literal134_tree=null;
        object END_OF_STATEMENT135_tree=null;

         retval.ret = new FunctionCallElement();
         
        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:281:3: ( variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:281:4: variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_functioncall1679);
            	variable131 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable131.Tree);
            	retval.ret.setfunctioncallname(((variable131 != null) ? variable131.ret : null));
            	char_literal132=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functioncall1684); 
            		char_literal132_tree = (object)adaptor.Create(char_literal132);
            		adaptor.AddChild(root_0, char_literal132_tree);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:6: ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( ((LA42_0 >= VARIABLE && LA42_0 <= DOUBLE_LITERAL) || LA42_0 == 27) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:7: (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )*
            	        {
            	        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:7: (el1= var_int_or_double_literal | e13= string_literal )
            	        	int alt39 = 2;
            	        	int LA39_0 = input.LA(1);

            	        	if ( ((LA39_0 >= VARIABLE && LA39_0 <= DOUBLE_LITERAL)) )
            	        	{
            	        	    alt39 = 1;
            	        	}
            	        	else if ( (LA39_0 == 27) )
            	        	{
            	        	    alt39 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    NoViableAltException nvae_d39s0 =
            	        	        new NoViableAltException("", 39, 0, input);

            	        	    throw nvae_d39s0;
            	        	}
            	        	switch (alt39) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:8: el1= var_int_or_double_literal
            	        	        {
            	        	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1689);
            	        	        	el1 = var_int_or_double_literal();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, el1.Tree);
            	        	        	retval.ret.setparameters(((el1 != null) ? el1.ret : null));

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:75: e13= string_literal
            	        	        {
            	        	        	PushFollow(FOLLOW_string_literal_in_functioncall1695);
            	        	        	e13 = string_literal();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, e13.Tree);
            	        	        	retval.ret.setparameters(((e13 != null) ? e13.ret : null));

            	        	        }
            	        	        break;

            	        	}

            	        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:133: ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )*
            	        	do 
            	        	{
            	        	    int alt41 = 2;
            	        	    int LA41_0 = input.LA(1);

            	        	    if ( (LA41_0 == 31) )
            	        	    {
            	        	        alt41 = 1;
            	        	    }


            	        	    switch (alt41) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:134: ',' (el2= var_int_or_double_literal | e13= string_literal )
            	        			    {
            	        			    	char_literal133=(IToken)Match(input,31,FOLLOW_31_in_functioncall1700); 
            	        			    		char_literal133_tree = (object)adaptor.Create(char_literal133);
            	        			    		adaptor.AddChild(root_0, char_literal133_tree);

            	        			    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:138: (el2= var_int_or_double_literal | e13= string_literal )
            	        			    	int alt40 = 2;
            	        			    	int LA40_0 = input.LA(1);

            	        			    	if ( ((LA40_0 >= VARIABLE && LA40_0 <= DOUBLE_LITERAL)) )
            	        			    	{
            	        			    	    alt40 = 1;
            	        			    	}
            	        			    	else if ( (LA40_0 == 27) )
            	        			    	{
            	        			    	    alt40 = 2;
            	        			    	}
            	        			    	else 
            	        			    	{
            	        			    	    NoViableAltException nvae_d40s0 =
            	        			    	        new NoViableAltException("", 40, 0, input);

            	        			    	    throw nvae_d40s0;
            	        			    	}
            	        			    	switch (alt40) 
            	        			    	{
            	        			    	    case 1 :
            	        			    	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:139: el2= var_int_or_double_literal
            	        			    	        {
            	        			    	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1705);
            	        			    	        	el2 = var_int_or_double_literal();
            	        			    	        	state.followingStackPointer--;

            	        			    	        	adaptor.AddChild(root_0, el2.Tree);
            	        			    	        	retval.ret.setparameters(((el2 != null) ? el2.ret : null));

            	        			    	        }
            	        			    	        break;
            	        			    	    case 2 :
            	        			    	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:282:206: e13= string_literal
            	        			    	        {
            	        			    	        	PushFollow(FOLLOW_string_literal_in_functioncall1711);
            	        			    	        	e13 = string_literal();
            	        			    	        	state.followingStackPointer--;

            	        			    	        	adaptor.AddChild(root_0, e13.Tree);
            	        			    	        	retval.ret.setparameters(((e13 != null) ? e13.ret : null));

            	        			    	        }
            	        			    	        break;

            	        			    	}


            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop41;
            	        	    }
            	        	} while (true);

            	        	loop41:
            	        		;	// Stops C# compiler whining that label 'loop41' has no statements


            	        }
            	        break;

            	}

            	char_literal134=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functioncall1719); 
            		char_literal134_tree = (object)adaptor.Create(char_literal134);
            		adaptor.AddChild(root_0, char_literal134_tree);

            	END_OF_STATEMENT135=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functioncall1723); 
            		END_OF_STATEMENT135_tree = (object)adaptor.Create(END_OF_STATEMENT135);
            		adaptor.AddChild(root_0, END_OF_STATEMENT135_tree);


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
    // $ANTLR end "functioncall"

    public class functiondefination_return : ParserRuleReturnScope
    {
        public FunctionElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functiondefination"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:290:1: functiondefination returns [FunctionElement ret] : ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' );
    public spinachParser.functiondefination_return functiondefination() // throws RecognitionException [1]
    {   
        spinachParser.functiondefination_return retval = new spinachParser.functiondefination_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE136 = null;
        IToken char_literal138 = null;
        IToken char_literal139 = null;
        IToken char_literal140 = null;
        IToken char_literal141 = null;
        IToken char_literal153 = null;
        IToken string_literal154 = null;
        IToken char_literal156 = null;
        IToken char_literal157 = null;
        IToken char_literal158 = null;
        IToken char_literal159 = null;
        IToken char_literal171 = null;
        spinachParser.arguments_return e11 = null;

        spinachParser.arguments_return e12 = null;

        spinachParser.variable_return variable137 = null;

        spinachParser.assignment_return assignment142 = null;

        spinachParser.functioncall_return functioncall143 = null;

        spinachParser.scalarvardec_return scalarvardec144 = null;

        spinachParser.vectorvardec_return vectorvardec145 = null;

        spinachParser.matrixvardec_return matrixvardec146 = null;

        spinachParser.deletionofvar_return deletionofvar147 = null;

        spinachParser.print_return print148 = null;

        spinachParser.ifelse_return ifelse149 = null;

        spinachParser.functionreturn_return functionreturn150 = null;

        spinachParser.parallelfor_return parallelfor151 = null;

        spinachParser.forstatement_return forstatement152 = null;

        spinachParser.variable_return variable155 = null;

        spinachParser.assignment_return assignment160 = null;

        spinachParser.functioncall_return functioncall161 = null;

        spinachParser.scalarvardec_return scalarvardec162 = null;

        spinachParser.vectorvardec_return vectorvardec163 = null;

        spinachParser.matrixvardec_return matrixvardec164 = null;

        spinachParser.deletionofvar_return deletionofvar165 = null;

        spinachParser.print_return print166 = null;

        spinachParser.ifelse_return ifelse167 = null;

        spinachParser.functionreturn_return functionreturn168 = null;

        spinachParser.parallelfor_return parallelfor169 = null;

        spinachParser.forstatement_return forstatement170 = null;


        object VARTYPE136_tree=null;
        object char_literal138_tree=null;
        object char_literal139_tree=null;
        object char_literal140_tree=null;
        object char_literal141_tree=null;
        object char_literal153_tree=null;
        object string_literal154_tree=null;
        object char_literal156_tree=null;
        object char_literal157_tree=null;
        object char_literal158_tree=null;
        object char_literal159_tree=null;
        object char_literal171_tree=null;


        retval.ret = new FunctionElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:295:1: ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
            int alt51 = 2;
            int LA51_0 = input.LA(1);

            if ( (LA51_0 == VARTYPE) )
            {
                alt51 = 1;
            }
            else if ( (LA51_0 == 43) )
            {
                alt51 = 2;
            }
            else 
            {
                NoViableAltException nvae_d51s0 =
                    new NoViableAltException("", 51, 0, input);

                throw nvae_d51s0;
            }
            switch (alt51) 
            {
                case 1 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:295:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:295:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:295:4: VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}'
                    	{
                    		VARTYPE136=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_functiondefination1750); 
                    			VARTYPE136_tree = (object)adaptor.Create(VARTYPE136);
                    			adaptor.AddChild(root_0, VARTYPE136_tree);

                    		retval.ret.setreturntype(((VARTYPE136 != null) ? VARTYPE136.Text : null));
                    		PushFollow(FOLLOW_variable_in_functiondefination1755);
                    		variable137 = variable();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, variable137.Tree);
                    		retval.ret.setfunctionname(((variable137 != null) ? variable137.ret : null));
                    		char_literal138=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1761); 
                    			char_literal138_tree = (object)adaptor.Create(char_literal138);
                    			adaptor.AddChild(root_0, char_literal138_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:298:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:298:3: (e11= arguments ( ',' e12= arguments )* )?
                    		{
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:298:3: (e11= arguments ( ',' e12= arguments )* )?
                    			int alt44 = 2;
                    			int LA44_0 = input.LA(1);

                    			if ( (LA44_0 == VARTYPE || LA44_0 == 28 || LA44_0 == 32) )
                    			{
                    			    alt44 = 1;
                    			}
                    			switch (alt44) 
                    			{
                    			    case 1 :
                    			        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:298:4: e11= arguments ( ',' e12= arguments )*
                    			        {
                    			        	PushFollow(FOLLOW_arguments_in_functiondefination1769);
                    			        	e11 = arguments();
                    			        	state.followingStackPointer--;

                    			        	adaptor.AddChild(root_0, e11.Tree);
                    			        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    			        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:298:54: ( ',' e12= arguments )*
                    			        	do 
                    			        	{
                    			        	    int alt43 = 2;
                    			        	    int LA43_0 = input.LA(1);

                    			        	    if ( (LA43_0 == 31) )
                    			        	    {
                    			        	        alt43 = 1;
                    			        	    }


                    			        	    switch (alt43) 
                    			        		{
                    			        			case 1 :
                    			        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:298:55: ',' e12= arguments
                    			        			    {
                    			        			    	char_literal139=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1772); 
                    			        			    		char_literal139_tree = (object)adaptor.Create(char_literal139);
                    			        			    		adaptor.AddChild(root_0, char_literal139_tree);

                    			        			    	PushFollow(FOLLOW_arguments_in_functiondefination1777);
                    			        			    	e12 = arguments();
                    			        			    	state.followingStackPointer--;

                    			        			    	adaptor.AddChild(root_0, e12.Tree);
                    			        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    			        			    }
                    			        			    break;

                    			        			default:
                    			        			    goto loop43;
                    			        	    }
                    			        	} while (true);

                    			        	loop43:
                    			        		;	// Stops C# compiler whining that label 'loop43' has no statements


                    			        }
                    			        break;

                    			}


                    		}

                    		char_literal140=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1786); 
                    			char_literal140_tree = (object)adaptor.Create(char_literal140);
                    			adaptor.AddChild(root_0, char_literal140_tree);

                    		char_literal141=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1788); 
                    			char_literal141_tree = (object)adaptor.Create(char_literal141);
                    			adaptor.AddChild(root_0, char_literal141_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:300:5: ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )?
                    		int alt46 = 2;
                    		int LA46_0 = input.LA(1);

                    		if ( (LA46_0 == VARIABLE || LA46_0 == VARTYPE || LA46_0 == STRINGTYPE || LA46_0 == 28 || LA46_0 == 32 || (LA46_0 >= 35 && LA46_0 <= 37) || LA46_0 == 40 || LA46_0 == 42 || LA46_0 == 47) )
                    		{
                    		    alt46 = 1;
                    		}
                    		switch (alt46) 
                    		{
                    		    case 1 :
                    		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:300:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    		        {
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:300:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    		        	int cnt45 = 0;
                    		        	do 
                    		        	{
                    		        	    int alt45 = 12;
                    		        	    alt45 = dfa45.Predict(input);
                    		        	    switch (alt45) 
                    		        		{
                    		        			case 1 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:300:7: assignment
                    		        			    {
                    		        			    	PushFollow(FOLLOW_assignment_in_functiondefination1792);
                    		        			    	assignment142 = assignment();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, assignment142.Tree);
                    		        			    	retval.ret.setBody(((assignment142 != null) ? assignment142.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 2 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:300:56: functioncall
                    		        			    {
                    		        			    	PushFollow(FOLLOW_functioncall_in_functiondefination1795);
                    		        			    	functioncall143 = functioncall();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, functioncall143.Tree);
                    		        			    	retval.ret.setBody(((functioncall143 != null) ? functioncall143.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 3 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:300:110: scalarvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1799);
                    		        			    	scalarvardec144 = scalarvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, scalarvardec144.Tree);
                    		        			    	 retval.ret.setBody(((scalarvardec144 != null) ? scalarvardec144.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 4 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:301:5: vectorvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1807);
                    		        			    	vectorvardec145 = vectorvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, vectorvardec145.Tree);
                    		        			    	 retval.ret.setBody(((vectorvardec145 != null) ? vectorvardec145.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 5 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:302:5: matrixvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1815);
                    		        			    	matrixvardec146 = matrixvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, matrixvardec146.Tree);
                    		        			    	 retval.ret.setBody(((matrixvardec146 != null) ? matrixvardec146.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 6 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:303:5: deletionofvar
                    		        			    {
                    		        			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1823);
                    		        			    	deletionofvar147 = deletionofvar();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, deletionofvar147.Tree);
                    		        			    	 retval.ret.setBody(((deletionofvar147 != null) ? deletionofvar147.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 7 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:303:64: print
                    		        			    {
                    		        			    	PushFollow(FOLLOW_print_in_functiondefination1829);
                    		        			    	print148 = print();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, print148.Tree);
                    		        			    	 retval.ret.setBody(((print148 != null) ? print148.ret : null)); 

                    		        			    }
                    		        			    break;
                    		        			case 8 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:304:5: ifelse
                    		        			    {
                    		        			    	PushFollow(FOLLOW_ifelse_in_functiondefination1837);
                    		        			    	ifelse149 = ifelse();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, ifelse149.Tree);
                    		        			    	retval.ret.setBody(((ifelse149 != null) ? ifelse149.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 9 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:304:47: functionreturn
                    		        			    {
                    		        			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1841);
                    		        			    	functionreturn150 = functionreturn();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, functionreturn150.Tree);
                    		        			    	retval.ret.setBody(((functionreturn150 != null) ? functionreturn150.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 10 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:304:105: parallelfor
                    		        			    {
                    		        			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1845);
                    		        			    	parallelfor151 = parallelfor();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, parallelfor151.Tree);
                    		        			    	retval.ret.setBody(((parallelfor151 != null) ? parallelfor151.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 11 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:304:157: forstatement
                    		        			    {
                    		        			    	PushFollow(FOLLOW_forstatement_in_functiondefination1849);
                    		        			    	forstatement152 = forstatement();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, forstatement152.Tree);
                    		        			    	retval.ret.setBody(((forstatement152 != null) ? forstatement152.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    if ( cnt45 >= 1 ) goto loop45;
                    		        		            EarlyExitException eee45 =
                    		        		                new EarlyExitException(45, input);
                    		        		            throw eee45;
                    		        	    }
                    		        	    cnt45++;
                    		        	} while (true);

                    		        	loop45:
                    		        		;	// Stops C# compiler whinging that label 'loop45' has no statements


                    		        }
                    		        break;

                    		}

                    		char_literal153=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1856); 
                    			char_literal153_tree = (object)adaptor.Create(char_literal153);
                    			adaptor.AddChild(root_0, char_literal153_tree);


                    	}


                    }
                    break;
                case 2 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:305:6: 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal154=(IToken)Match(input,43,FOLLOW_43_in_functiondefination1859); 
                    		string_literal154_tree = (object)adaptor.Create(string_literal154);
                    		adaptor.AddChild(root_0, string_literal154_tree);

                    	retval.ret.setreturntype("void");
                    	PushFollow(FOLLOW_variable_in_functiondefination1864);
                    	variable155 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable155.Tree);
                    	retval.ret.setfunctionname(((variable155 != null) ? variable155.ret : null));
                    	char_literal156=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1870); 
                    		char_literal156_tree = (object)adaptor.Create(char_literal156);
                    		adaptor.AddChild(root_0, char_literal156_tree);

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:308:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:308:3: (e11= arguments ( ',' e12= arguments )* )?
                    	{
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:308:3: (e11= arguments ( ',' e12= arguments )* )?
                    		int alt48 = 2;
                    		int LA48_0 = input.LA(1);

                    		if ( (LA48_0 == VARTYPE || LA48_0 == 28 || LA48_0 == 32) )
                    		{
                    		    alt48 = 1;
                    		}
                    		switch (alt48) 
                    		{
                    		    case 1 :
                    		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:308:4: e11= arguments ( ',' e12= arguments )*
                    		        {
                    		        	PushFollow(FOLLOW_arguments_in_functiondefination1879);
                    		        	e11 = arguments();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, e11.Tree);
                    		        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:308:55: ( ',' e12= arguments )*
                    		        	do 
                    		        	{
                    		        	    int alt47 = 2;
                    		        	    int LA47_0 = input.LA(1);

                    		        	    if ( (LA47_0 == 31) )
                    		        	    {
                    		        	        alt47 = 1;
                    		        	    }


                    		        	    switch (alt47) 
                    		        		{
                    		        			case 1 :
                    		        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:308:56: ',' e12= arguments
                    		        			    {
                    		        			    	char_literal157=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1882); 
                    		        			    		char_literal157_tree = (object)adaptor.Create(char_literal157);
                    		        			    		adaptor.AddChild(root_0, char_literal157_tree);

                    		        			    	PushFollow(FOLLOW_arguments_in_functiondefination1886);
                    		        			    	e12 = arguments();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, e12.Tree);
                    		        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    goto loop47;
                    		        	    }
                    		        	} while (true);

                    		        	loop47:
                    		        		;	// Stops C# compiler whining that label 'loop47' has no statements


                    		        }
                    		        break;

                    		}


                    	}

                    	char_literal158=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1895); 
                    		char_literal158_tree = (object)adaptor.Create(char_literal158);
                    		adaptor.AddChild(root_0, char_literal158_tree);

                    	char_literal159=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1897); 
                    		char_literal159_tree = (object)adaptor.Create(char_literal159);
                    		adaptor.AddChild(root_0, char_literal159_tree);

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:310:5: ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )?
                    	int alt50 = 2;
                    	int LA50_0 = input.LA(1);

                    	if ( (LA50_0 == VARIABLE || LA50_0 == VARTYPE || LA50_0 == STRINGTYPE || LA50_0 == 28 || LA50_0 == 32 || (LA50_0 >= 35 && LA50_0 <= 37) || LA50_0 == 40 || LA50_0 == 42 || LA50_0 == 47) )
                    	{
                    	    alt50 = 1;
                    	}
                    	switch (alt50) 
                    	{
                    	    case 1 :
                    	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:310:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    	        {
                    	        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:310:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    	        	int cnt49 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt49 = 12;
                    	        	    alt49 = dfa49.Predict(input);
                    	        	    switch (alt49) 
                    	        		{
                    	        			case 1 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:310:7: assignment
                    	        			    {
                    	        			    	PushFollow(FOLLOW_assignment_in_functiondefination1901);
                    	        			    	assignment160 = assignment();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, assignment160.Tree);
                    	        			    	retval.ret.setBody(((assignment160 != null) ? assignment160.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 2 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:310:56: functioncall
                    	        			    {
                    	        			    	PushFollow(FOLLOW_functioncall_in_functiondefination1904);
                    	        			    	functioncall161 = functioncall();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, functioncall161.Tree);
                    	        			    	retval.ret.setBody(((functioncall161 != null) ? functioncall161.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 3 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:310:110: scalarvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1908);
                    	        			    	scalarvardec162 = scalarvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, scalarvardec162.Tree);
                    	        			    	 retval.ret.setBody(((scalarvardec162 != null) ? scalarvardec162.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 4 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:311:5: vectorvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1916);
                    	        			    	vectorvardec163 = vectorvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, vectorvardec163.Tree);
                    	        			    	 retval.ret.setBody(((vectorvardec163 != null) ? vectorvardec163.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 5 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:312:5: matrixvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1924);
                    	        			    	matrixvardec164 = matrixvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, matrixvardec164.Tree);
                    	        			    	 retval.ret.setBody(((matrixvardec164 != null) ? matrixvardec164.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 6 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:313:5: deletionofvar
                    	        			    {
                    	        			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1932);
                    	        			    	deletionofvar165 = deletionofvar();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, deletionofvar165.Tree);
                    	        			    	 retval.ret.setBody(((deletionofvar165 != null) ? deletionofvar165.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 7 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:313:64: print
                    	        			    {
                    	        			    	PushFollow(FOLLOW_print_in_functiondefination1938);
                    	        			    	print166 = print();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, print166.Tree);
                    	        			    	 retval.ret.setBody(((print166 != null) ? print166.ret : null)); 

                    	        			    }
                    	        			    break;
                    	        			case 8 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:314:5: ifelse
                    	        			    {
                    	        			    	PushFollow(FOLLOW_ifelse_in_functiondefination1946);
                    	        			    	ifelse167 = ifelse();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, ifelse167.Tree);
                    	        			    	retval.ret.setBody(((ifelse167 != null) ? ifelse167.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 9 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:314:47: functionreturn
                    	        			    {
                    	        			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1950);
                    	        			    	functionreturn168 = functionreturn();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, functionreturn168.Tree);
                    	        			    	retval.ret.setBody(((functionreturn168 != null) ? functionreturn168.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 10 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:314:105: parallelfor
                    	        			    {
                    	        			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1954);
                    	        			    	parallelfor169 = parallelfor();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, parallelfor169.Tree);
                    	        			    	retval.ret.setBody(((parallelfor169 != null) ? parallelfor169.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 11 :
                    	        			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:314:157: forstatement
                    	        			    {
                    	        			    	PushFollow(FOLLOW_forstatement_in_functiondefination1958);
                    	        			    	forstatement170 = forstatement();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, forstatement170.Tree);
                    	        			    	retval.ret.setBody(((forstatement170 != null) ? forstatement170.ret : null));

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    if ( cnt49 >= 1 ) goto loop49;
                    	        		            EarlyExitException eee49 =
                    	        		                new EarlyExitException(49, input);
                    	        		            throw eee49;
                    	        	    }
                    	        	    cnt49++;
                    	        	} while (true);

                    	        	loop49:
                    	        		;	// Stops C# compiler whinging that label 'loop49' has no statements


                    	        }
                    	        break;

                    	}

                    	char_literal171=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1965); 
                    		char_literal171_tree = (object)adaptor.Create(char_literal171);
                    		adaptor.AddChild(root_0, char_literal171_tree);


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
    // $ANTLR end "functiondefination"

    public class dotproduct_return : ParserRuleReturnScope
    {
        public DotProductElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "dotproduct"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:319:1: dotproduct returns [DotProductElement ret] : e11= variable 'DOT' e12= variable ;
    public spinachParser.dotproduct_return dotproduct() // throws RecognitionException [1]
    {   
        spinachParser.dotproduct_return retval = new spinachParser.dotproduct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal172 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.variable_return e12 = null;


        object string_literal172_tree=null;


        retval.ret = new DotProductElement ();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:323:1: (e11= variable 'DOT' e12= variable )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:323:3: e11= variable 'DOT' e12= variable
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_dotproduct1987);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLhs(((e11 != null) ? e11.ret : null)); 
            	string_literal172=(IToken)Match(input,44,FOLLOW_44_in_dotproduct1991); 
            		string_literal172_tree = (object)adaptor.Create(string_literal172);
            		adaptor.AddChild(root_0, string_literal172_tree);

            	PushFollow(FOLLOW_variable_in_dotproduct1997);
            	e12 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.setRhs(((e12 != null) ? e12.ret : null)); 

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
    // $ANTLR end "dotproduct"

    public class matrixtranspose_return : ParserRuleReturnScope
    {
        public MatrixTranspose ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixtranspose"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:325:1: matrixtranspose returns [MatrixTranspose ret] : 'T' LEFTBRACE variable ')' ;
    public spinachParser.matrixtranspose_return matrixtranspose() // throws RecognitionException [1]
    {   
        spinachParser.matrixtranspose_return retval = new spinachParser.matrixtranspose_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal173 = null;
        IToken LEFTBRACE174 = null;
        IToken char_literal176 = null;
        spinachParser.variable_return variable175 = null;


        object char_literal173_tree=null;
        object LEFTBRACE174_tree=null;
        object char_literal176_tree=null;


        retval.ret = new MatrixTranspose();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:330:1: ( 'T' LEFTBRACE variable ')' )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:330:3: 'T' LEFTBRACE variable ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal173=(IToken)Match(input,45,FOLLOW_45_in_matrixtranspose2016); 
            		char_literal173_tree = (object)adaptor.Create(char_literal173);
            		adaptor.AddChild(root_0, char_literal173_tree);

            	LEFTBRACE174=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_matrixtranspose2018); 
            		LEFTBRACE174_tree = (object)adaptor.Create(LEFTBRACE174);
            		adaptor.AddChild(root_0, LEFTBRACE174_tree);

            	PushFollow(FOLLOW_variable_in_matrixtranspose2020);
            	variable175 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable175.Tree);
            	retval.ret.setvariable(((variable175 != null) ? variable175.ret : null)); 
            	char_literal176=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_matrixtranspose2023); 
            		char_literal176_tree = (object)adaptor.Create(char_literal176);
            		adaptor.AddChild(root_0, char_literal176_tree);


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
    // $ANTLR end "matrixtranspose"

    public class matrixreference_return : ParserRuleReturnScope
    {
        public MatrixReference ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "matrixreference"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:333:1: matrixreference returns [MatrixReference ret] : 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.matrixreference_return matrixreference() // throws RecognitionException [1]
    {   
        spinachParser.matrixreference_return retval = new spinachParser.matrixreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal177 = null;
        IToken char_literal178 = null;
        IToken char_literal179 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal177_tree=null;
        object char_literal178_tree=null;
        object char_literal179_tree=null;

         retval.ret = new MatrixReference();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:336:1: ( 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:336:2: 'Matrix' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal177=(IToken)Match(input,28,FOLLOW_28_in_matrixreference2039); 
            		string_literal177_tree = (object)adaptor.Create(string_literal177);
            		adaptor.AddChild(root_0, string_literal177_tree);

            	char_literal178=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixreference2041); 
            		char_literal178_tree = (object)adaptor.Create(char_literal178);
            		adaptor.AddChild(root_0, char_literal178_tree);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:336:15: (el1= VARTYPE '>' el2= variable )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:336:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixreference2046); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal179=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixreference2048); 
            			char_literal179_tree = (object)adaptor.Create(char_literal179);
            			adaptor.AddChild(root_0, char_literal179_tree);

            		PushFollow(FOLLOW_variable_in_matrixreference2052);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setvariable(((el2 != null) ? el2.ret : null));

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
    // $ANTLR end "matrixreference"

    public class vectorreference_return : ParserRuleReturnScope
    {
        public VectorReference ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "vectorreference"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:339:1: vectorreference returns [VectorReference ret] : 'Vector' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.vectorreference_return vectorreference() // throws RecognitionException [1]
    {   
        spinachParser.vectorreference_return retval = new spinachParser.vectorreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal180 = null;
        IToken char_literal181 = null;
        IToken char_literal182 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal180_tree=null;
        object char_literal181_tree=null;
        object char_literal182_tree=null;

         retval.ret = new VectorReference();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:342:1: ( 'Vector' '<' (el1= VARTYPE '>' el2= variable ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:342:2: 'Vector' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal180=(IToken)Match(input,32,FOLLOW_32_in_vectorreference2071); 
            		string_literal180_tree = (object)adaptor.Create(string_literal180);
            		adaptor.AddChild(root_0, string_literal180_tree);

            	char_literal181=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorreference2073); 
            		char_literal181_tree = (object)adaptor.Create(char_literal181);
            		adaptor.AddChild(root_0, char_literal181_tree);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:342:15: (el1= VARTYPE '>' el2= variable )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:342:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorreference2078); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal182=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2080); 
            			char_literal182_tree = (object)adaptor.Create(char_literal182);
            			adaptor.AddChild(root_0, char_literal182_tree);

            		PushFollow(FOLLOW_variable_in_vectorreference2084);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setvariable(((el2 != null) ? el2.ret : null));

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
    // $ANTLR end "vectorreference"

    public class arguments_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arguments"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:344:1: arguments returns [Element ret] : ( scalarargument | matrixreference | vectorreference ) ;
    public spinachParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        spinachParser.arguments_return retval = new spinachParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.scalarargument_return scalarargument183 = null;

        spinachParser.matrixreference_return matrixreference184 = null;

        spinachParser.vectorreference_return vectorreference185 = null;



        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:345:1: ( ( scalarargument | matrixreference | vectorreference ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:345:3: ( scalarargument | matrixreference | vectorreference )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:345:3: ( scalarargument | matrixreference | vectorreference )
            	int alt52 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARTYPE:
            		{
            	    alt52 = 1;
            	    }
            	    break;
            	case 28:
            		{
            	    alt52 = 2;
            	    }
            	    break;
            	case 32:
            		{
            	    alt52 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d52s0 =
            		        new NoViableAltException("", 52, 0, input);

            		    throw nvae_d52s0;
            	}

            	switch (alt52) 
            	{
            	    case 1 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:345:4: scalarargument
            	        {
            	        	PushFollow(FOLLOW_scalarargument_in_arguments2100);
            	        	scalarargument183 = scalarargument();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, scalarargument183.Tree);
            	        	 retval.ret = ((scalarargument183 != null) ? scalarargument183.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:346:3: matrixreference
            	        {
            	        	PushFollow(FOLLOW_matrixreference_in_arguments2106);
            	        	matrixreference184 = matrixreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixreference184.Tree);
            	        	retval.ret = ((matrixreference184 != null) ? matrixreference184.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:347:3: vectorreference
            	        {
            	        	PushFollow(FOLLOW_vectorreference_in_arguments2112);
            	        	vectorreference185 = vectorreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorreference185.Tree);
            	        	retval.ret = ((vectorreference185 != null) ? vectorreference185.ret : null);

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
    // $ANTLR end "arguments"

    public class scalarargument_return : ParserRuleReturnScope
    {
        public ScalarArgument ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "scalarargument"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:358:1: scalarargument returns [ScalarArgument ret] : ( (e11= VARTYPE ) e12= variable ) ;
    public spinachParser.scalarargument_return scalarargument() // throws RecognitionException [1]
    {   
        spinachParser.scalarargument_return retval = new spinachParser.scalarargument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken e11 = null;
        spinachParser.variable_return e12 = null;


        object e11_tree=null;

        retval.ret = new ScalarArgument();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:360:2: ( ( (e11= VARTYPE ) e12= variable ) )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:361:1: ( (e11= VARTYPE ) e12= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:361:1: ( (e11= VARTYPE ) e12= variable )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:361:2: (e11= VARTYPE ) e12= variable
            	{
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:361:2: (e11= VARTYPE )
            		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:361:3: e11= VARTYPE
            		{
            			e11=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarargument2144); 
            				e11_tree = (object)adaptor.Create(e11);
            				adaptor.AddChild(root_0, e11_tree);

            			retval.ret.settype(((e11 != null) ? e11.Text : null));

            		}

            		PushFollow(FOLLOW_variable_in_scalarargument2151);
            		e12 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, e12.Tree);
            		retval.ret.setvariable(((e12 != null) ? e12.ret : null)); 

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
    // $ANTLR end "scalarargument"

    public class comment_return : ParserRuleReturnScope
    {
        public CommentElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "comment"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:365:1: comment returns [CommentElement ret] : '//' ( var_int_or_double_literal )* ;
    public spinachParser.comment_return comment() // throws RecognitionException [1]
    {   
        spinachParser.comment_return retval = new spinachParser.comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal186 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal187 = null;


        object string_literal186_tree=null;


        retval.ret = new CommentElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:369:1: ( '//' ( var_int_or_double_literal )* )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:369:2: '//' ( var_int_or_double_literal )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal186=(IToken)Match(input,46,FOLLOW_46_in_comment2170); 
            		string_literal186_tree = (object)adaptor.Create(string_literal186);
            		adaptor.AddChild(root_0, string_literal186_tree);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:369:6: ( var_int_or_double_literal )*
            	do 
            	{
            	    int alt53 = 2;
            	    int LA53_0 = input.LA(1);

            	    if ( (LA53_0 == VARIABLE) )
            	    {
            	        switch ( input.LA(2) ) 
            	        {
            	        case VARIABLE:
            	        	{
            	            int LA53_4 = input.LA(3);

            	            if ( (LA53_4 == EOF || (LA53_4 >= VARIABLE && LA53_4 <= ASSIGNMENT) || (LA53_4 >= STRINGTYPE && LA53_4 <= LEFTBRACE) || LA53_4 == RIGHTPARANTHESIS || LA53_4 == DOT || (LA53_4 >= 28 && LA53_4 <= 29) || LA53_4 == 32 || (LA53_4 >= 34 && LA53_4 <= 37) || (LA53_4 >= 39 && LA53_4 <= 40) || (LA53_4 >= 42 && LA53_4 <= 43) || (LA53_4 >= 46 && LA53_4 <= 48) || (LA53_4 >= 52 && LA53_4 <= 56)) )
            	            {
            	                alt53 = 1;
            	            }


            	            }
            	            break;
            	        case DOT:
            	        	{
            	            int LA53_5 = input.LA(3);

            	            if ( (LA53_5 == VARIABLE) )
            	            {
            	                int LA53_6 = input.LA(4);

            	                if ( (LA53_6 == EOF || (LA53_6 >= VARIABLE && LA53_6 <= VARTYPE) || LA53_6 == STRINGTYPE || LA53_6 == RIGHTPARANTHESIS || LA53_6 == 28 || LA53_6 == 32 || (LA53_6 >= 34 && LA53_6 <= 37) || (LA53_6 >= 39 && LA53_6 <= 40) || (LA53_6 >= 42 && LA53_6 <= 43) || (LA53_6 >= 46 && LA53_6 <= 48) || (LA53_6 >= 52 && LA53_6 <= 56)) )
            	                {
            	                    alt53 = 1;
            	                }


            	            }


            	            }
            	            break;
            	        case EOF:
            	        case INT_LITERAL:
            	        case DOUBLE_LITERAL:
            	        case VARTYPE:
            	        case STRINGTYPE:
            	        case RIGHTPARANTHESIS:
            	        case 28:
            	        case 32:
            	        case 34:
            	        case 35:
            	        case 36:
            	        case 37:
            	        case 39:
            	        case 40:
            	        case 42:
            	        case 43:
            	        case 46:
            	        case 47:
            	        case 48:
            	        case 52:
            	        case 53:
            	        case 54:
            	        case 55:
            	        case 56:
            	        	{
            	            alt53 = 1;
            	            }
            	            break;

            	        }

            	    }
            	    else if ( ((LA53_0 >= INT_LITERAL && LA53_0 <= DOUBLE_LITERAL)) )
            	    {
            	        alt53 = 1;
            	    }


            	    switch (alt53) 
            		{
            			case 1 :
            			    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:369:6: var_int_or_double_literal
            			    {
            			    	PushFollow(FOLLOW_var_int_or_double_literal_in_comment2171);
            			    	var_int_or_double_literal187 = var_int_or_double_literal();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, var_int_or_double_literal187.Tree);

            			    }
            			    break;

            			default:
            			    goto loop53;
            	    }
            	} while (true);

            	loop53:
            		;	// Stops C# compiler whining that label 'loop53' has no statements


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
    // $ANTLR end "comment"

    public class functionreturn_return : ParserRuleReturnScope
    {
        public ReturnElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionreturn"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:373:1: functionreturn returns [ReturnElement ret] : 'return' ( var_int_or_double_literal ) END_OF_STATEMENT ;
    public spinachParser.functionreturn_return functionreturn() // throws RecognitionException [1]
    {   
        spinachParser.functionreturn_return retval = new spinachParser.functionreturn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal188 = null;
        IToken END_OF_STATEMENT190 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal189 = null;


        object string_literal188_tree=null;
        object END_OF_STATEMENT190_tree=null;


        retval.ret = new ReturnElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:377:1: ( 'return' ( var_int_or_double_literal ) END_OF_STATEMENT )
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:377:2: 'return' ( var_int_or_double_literal ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal188=(IToken)Match(input,47,FOLLOW_47_in_functionreturn2189); 
            		string_literal188_tree = (object)adaptor.Create(string_literal188);
            		adaptor.AddChild(root_0, string_literal188_tree);

            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:377:11: ( var_int_or_double_literal )
            	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:377:12: var_int_or_double_literal
            	{
            		PushFollow(FOLLOW_var_int_or_double_literal_in_functionreturn2192);
            		var_int_or_double_literal189 = var_int_or_double_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, var_int_or_double_literal189.Tree);
            		retval.ret.setreturnvariable(((var_int_or_double_literal189 != null) ? var_int_or_double_literal189.ret : null));

            	}

            	END_OF_STATEMENT190=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functionreturn2196); 
            		END_OF_STATEMENT190_tree = (object)adaptor.Create(END_OF_STATEMENT190);
            		adaptor.AddChild(root_0, END_OF_STATEMENT190_tree);


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
    // $ANTLR end "functionreturn"

    public class plotfunctions_return : ParserRuleReturnScope
    {
        public PlotFunctionElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "plotfunctions"
    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:383:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );
    public spinachParser.plotfunctions_return plotfunctions() // throws RecognitionException [1]
    {   
        spinachParser.plotfunctions_return retval = new spinachParser.plotfunctions_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal191 = null;
        IToken char_literal192 = null;
        IToken char_literal193 = null;
        IToken char_literal194 = null;
        IToken char_literal195 = null;
        IToken string_literal196 = null;
        IToken string_literal197 = null;
        IToken string_literal198 = null;
        IToken char_literal199 = null;
        IToken char_literal200 = null;
        IToken END_OF_STATEMENT201 = null;
        IToken string_literal202 = null;
        IToken char_literal203 = null;
        IToken char_literal204 = null;
        IToken char_literal205 = null;
        IToken string_literal206 = null;
        IToken string_literal207 = null;
        IToken string_literal208 = null;
        IToken char_literal209 = null;
        IToken char_literal210 = null;
        IToken END_OF_STATEMENT211 = null;
        IToken string_literal212 = null;
        IToken char_literal213 = null;
        IToken char_literal214 = null;
        IToken END_OF_STATEMENT215 = null;
        IToken string_literal216 = null;
        IToken char_literal217 = null;
        IToken char_literal218 = null;
        IToken char_literal219 = null;
        IToken char_literal220 = null;
        IToken END_OF_STATEMENT221 = null;
        IToken string_literal222 = null;
        IToken char_literal223 = null;
        IToken char_literal224 = null;
        IToken char_literal225 = null;
        IToken END_OF_STATEMENT226 = null;
        IToken string_literal227 = null;
        IToken char_literal228 = null;
        IToken char_literal229 = null;
        IToken END_OF_STATEMENT230 = null;
        IToken string_literal231 = null;
        IToken char_literal232 = null;
        IToken char_literal233 = null;
        IToken char_literal234 = null;
        IToken char_literal235 = null;
        IToken END_OF_STATEMENT236 = null;
        IToken string_literal237 = null;
        IToken char_literal238 = null;
        IToken char_literal239 = null;
        IToken char_literal240 = null;
        IToken END_OF_STATEMENT241 = null;
        IToken string_literal242 = null;
        IToken char_literal243 = null;
        IToken char_literal244 = null;
        IToken END_OF_STATEMENT245 = null;
        IToken string_literal246 = null;
        IToken char_literal247 = null;
        IToken SCALEMODE248 = null;
        IToken char_literal249 = null;
        IToken END_OF_STATEMENT250 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.variable_return vll1 = null;

        spinachParser.string_literal_return vll2 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.variable_return vll3 = null;

        spinachParser.string_literal_return vll4 = null;

        spinachParser.double_literal_return ell2 = null;

        spinachParser.double_literal_return ell3 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.string_literal_return vl1 = null;

        spinachParser.string_literal_return vl2 = null;

        spinachParser.string_literal_return vl3 = null;


        object string_literal191_tree=null;
        object char_literal192_tree=null;
        object char_literal193_tree=null;
        object char_literal194_tree=null;
        object char_literal195_tree=null;
        object string_literal196_tree=null;
        object string_literal197_tree=null;
        object string_literal198_tree=null;
        object char_literal199_tree=null;
        object char_literal200_tree=null;
        object END_OF_STATEMENT201_tree=null;
        object string_literal202_tree=null;
        object char_literal203_tree=null;
        object char_literal204_tree=null;
        object char_literal205_tree=null;
        object string_literal206_tree=null;
        object string_literal207_tree=null;
        object string_literal208_tree=null;
        object char_literal209_tree=null;
        object char_literal210_tree=null;
        object END_OF_STATEMENT211_tree=null;
        object string_literal212_tree=null;
        object char_literal213_tree=null;
        object char_literal214_tree=null;
        object END_OF_STATEMENT215_tree=null;
        object string_literal216_tree=null;
        object char_literal217_tree=null;
        object char_literal218_tree=null;
        object char_literal219_tree=null;
        object char_literal220_tree=null;
        object END_OF_STATEMENT221_tree=null;
        object string_literal222_tree=null;
        object char_literal223_tree=null;
        object char_literal224_tree=null;
        object char_literal225_tree=null;
        object END_OF_STATEMENT226_tree=null;
        object string_literal227_tree=null;
        object char_literal228_tree=null;
        object char_literal229_tree=null;
        object END_OF_STATEMENT230_tree=null;
        object string_literal231_tree=null;
        object char_literal232_tree=null;
        object char_literal233_tree=null;
        object char_literal234_tree=null;
        object char_literal235_tree=null;
        object END_OF_STATEMENT236_tree=null;
        object string_literal237_tree=null;
        object char_literal238_tree=null;
        object char_literal239_tree=null;
        object char_literal240_tree=null;
        object END_OF_STATEMENT241_tree=null;
        object string_literal242_tree=null;
        object char_literal243_tree=null;
        object char_literal244_tree=null;
        object END_OF_STATEMENT245_tree=null;
        object string_literal246_tree=null;
        object char_literal247_tree=null;
        object SCALEMODE248_tree=null;
        object char_literal249_tree=null;
        object END_OF_STATEMENT250_tree=null;

         retval.ret = new PlotFunctionElement();

        try 
    	{
            // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:386:1: ( ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) )
            int alt58 = 10;
            alt58 = dfa58.Predict(input);
            switch (alt58) 
            {
                case 1 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:386:3: ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:386:3: ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:386:4: 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal191=(IToken)Match(input,48,FOLLOW_48_in_plotfunctions2220); 
                    			string_literal191_tree = (object)adaptor.Create(string_literal191);
                    			adaptor.AddChild(root_0, string_literal191_tree);

                    		retval.ret.setPlotFunction("subPlot");
                    		char_literal192=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2223); 
                    			char_literal192_tree = (object)adaptor.Create(char_literal192);
                    			adaptor.AddChild(root_0, char_literal192_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:387:1: (el1= int_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:387:2: el1= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2230);
                    			el1 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el1.Tree);
                    			retval.ret.setPeno(((el1 != null) ? el1.ret : null));

                    		}

                    		char_literal193=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2235); 
                    			char_literal193_tree = (object)adaptor.Create(char_literal193);
                    			adaptor.AddChild(root_0, char_literal193_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:388:1: (vll1= variable )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:388:2: vll1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2242);
                    			vll1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll1.Tree);
                    			retval.ret.setData(((vll1 != null) ? vll1.ret : null));

                    		}

                    		char_literal194=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2247); 
                    			char_literal194_tree = (object)adaptor.Create(char_literal194);
                    			adaptor.AddChild(root_0, char_literal194_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:389:1: (vll2= string_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:389:2: vll2= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2254);
                    			vll2 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll2.Tree);
                    			retval.ret.setTitle(((vll2 != null) ? vll2.ret : null));

                    		}

                    		char_literal195=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2258); 
                    			char_literal195_tree = (object)adaptor.Create(char_literal195);
                    			adaptor.AddChild(root_0, char_literal195_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt55 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt55 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt55 = 2;
                    		    }
                    		    break;
                    		case 51:
                    			{
                    		    alt55 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d55s0 =
                    			        new NoViableAltException("", 55, 0, input);

                    			    throw nvae_d55s0;
                    		}

                    		switch (alt55) 
                    		{
                    		    case 1 :
                    		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:2: ( '1D' )
                    		        {
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:2: ( '1D' )
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:3: '1D'
                    		        	{
                    		        		string_literal196=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2262); 
                    		        			string_literal196_tree = (object)adaptor.Create(string_literal196);
                    		        			adaptor.AddChild(root_0, string_literal196_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:40: ( '2D' )
                    		        {
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:40: ( '2D' )
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:41: '2D'
                    		        	{
                    		        		string_literal197=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2267); 
                    		        			string_literal197_tree = (object)adaptor.Create(string_literal197);
                    		        			adaptor.AddChild(root_0, string_literal197_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal198=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2272); 
                    		        			string_literal198_tree = (object)adaptor.Create(string_literal198);
                    		        			adaptor.AddChild(root_0, string_literal198_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:114: ( ',' (el3= int_literal ) )?
                    		        		int alt54 = 2;
                    		        		int LA54_0 = input.LA(1);

                    		        		if ( (LA54_0 == 31) )
                    		        		{
                    		        		    alt54 = 1;
                    		        		}
                    		        		switch (alt54) 
                    		        		{
                    		        		    case 1 :
                    		        		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal199=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2275); 
                    		        		        		char_literal199_tree = (object)adaptor.Create(char_literal199);
                    		        		        		adaptor.AddChild(root_0, char_literal199_tree);

                    		        		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:118: (el3= int_literal )
                    		        		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:390:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2281);
                    		        		        		el3 = int_literal();
                    		        		        		state.followingStackPointer--;

                    		        		        		adaptor.AddChild(root_0, el3.Tree);
                    		        		        		retval.ret.setMode(((el3 != null) ? el3.ret : null));

                    		        		        	}


                    		        		        }
                    		        		        break;

                    		        		}


                    		        	}


                    		        }
                    		        break;

                    		}

                    		char_literal200=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2289); 
                    			char_literal200_tree = (object)adaptor.Create(char_literal200);
                    			adaptor.AddChild(root_0, char_literal200_tree);

                    		END_OF_STATEMENT201=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2290); 
                    			END_OF_STATEMENT201_tree = (object)adaptor.Create(END_OF_STATEMENT201);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT201_tree);


                    	}


                    }
                    break;
                case 2 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:392:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:392:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:392:4: 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal202=(IToken)Match(input,52,FOLLOW_52_in_plotfunctions2296); 
                    			string_literal202_tree = (object)adaptor.Create(string_literal202);
                    			adaptor.AddChild(root_0, string_literal202_tree);

                    		retval.ret.setPlotFunction("plot");
                    		char_literal203=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2299); 
                    			char_literal203_tree = (object)adaptor.Create(char_literal203);
                    			adaptor.AddChild(root_0, char_literal203_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:393:1: (vll3= variable )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:393:2: vll3= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2305);
                    			vll3 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll3.Tree);
                    			retval.ret.setData(((vll3 != null) ? vll3.ret : null));

                    		}

                    		char_literal204=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2310); 
                    			char_literal204_tree = (object)adaptor.Create(char_literal204);
                    			adaptor.AddChild(root_0, char_literal204_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:394:1: (vll4= string_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:394:2: vll4= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2316);
                    			vll4 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll4.Tree);
                    			retval.ret.setTitle(((vll4 != null) ? vll4.ret : null));

                    		}

                    		char_literal205=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2320); 
                    			char_literal205_tree = (object)adaptor.Create(char_literal205);
                    			adaptor.AddChild(root_0, char_literal205_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt57 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt57 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt57 = 2;
                    		    }
                    		    break;
                    		case 51:
                    			{
                    		    alt57 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d57s0 =
                    			        new NoViableAltException("", 57, 0, input);

                    			    throw nvae_d57s0;
                    		}

                    		switch (alt57) 
                    		{
                    		    case 1 :
                    		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:2: ( '1D' )
                    		        {
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:2: ( '1D' )
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:3: '1D'
                    		        	{
                    		        		string_literal206=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2324); 
                    		        			string_literal206_tree = (object)adaptor.Create(string_literal206);
                    		        			adaptor.AddChild(root_0, string_literal206_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:40: ( '2D' )
                    		        {
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:40: ( '2D' )
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:41: '2D'
                    		        	{
                    		        		string_literal207=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2329); 
                    		        			string_literal207_tree = (object)adaptor.Create(string_literal207);
                    		        			adaptor.AddChild(root_0, string_literal207_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal208=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2334); 
                    		        			string_literal208_tree = (object)adaptor.Create(string_literal208);
                    		        			adaptor.AddChild(root_0, string_literal208_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:114: ( ',' (el3= int_literal ) )?
                    		        		int alt56 = 2;
                    		        		int LA56_0 = input.LA(1);

                    		        		if ( (LA56_0 == 31) )
                    		        		{
                    		        		    alt56 = 1;
                    		        		}
                    		        		switch (alt56) 
                    		        		{
                    		        		    case 1 :
                    		        		        // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal209=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2337); 
                    		        		        		char_literal209_tree = (object)adaptor.Create(char_literal209);
                    		        		        		adaptor.AddChild(root_0, char_literal209_tree);

                    		        		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:118: (el3= int_literal )
                    		        		        	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:395:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2343);
                    		        		        		el3 = int_literal();
                    		        		        		state.followingStackPointer--;

                    		        		        		adaptor.AddChild(root_0, el3.Tree);
                    		        		        		retval.ret.setMode(((el3 != null) ? el3.ret : null));

                    		        		        	}


                    		        		        }
                    		        		        break;

                    		        		}


                    		        	}


                    		        }
                    		        break;

                    		}

                    		char_literal210=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2351); 
                    			char_literal210_tree = (object)adaptor.Create(char_literal210);
                    			adaptor.AddChild(root_0, char_literal210_tree);

                    		END_OF_STATEMENT211=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2352); 
                    			END_OF_STATEMENT211_tree = (object)adaptor.Create(END_OF_STATEMENT211);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT211_tree);


                    	}


                    }
                    break;
                case 3 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:397:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:397:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:397:4: 'resetPlot' '(' ')' END_OF_STATEMENT
                    	{
                    		string_literal212=(IToken)Match(input,53,FOLLOW_53_in_plotfunctions2358); 
                    			string_literal212_tree = (object)adaptor.Create(string_literal212);
                    			adaptor.AddChild(root_0, string_literal212_tree);

                    		char_literal213=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2359); 
                    			char_literal213_tree = (object)adaptor.Create(char_literal213);
                    			adaptor.AddChild(root_0, char_literal213_tree);

                    		char_literal214=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2360); 
                    			char_literal214_tree = (object)adaptor.Create(char_literal214);
                    			adaptor.AddChild(root_0, char_literal214_tree);

                    		retval.ret.setPlotFunction("resetPlot");
                    		END_OF_STATEMENT215=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2362); 
                    			END_OF_STATEMENT215_tree = (object)adaptor.Create(END_OF_STATEMENT215);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT215_tree);


                    	}


                    }
                    break;
                case 4 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:398:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:398:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:398:4: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal216=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2368); 
                    			string_literal216_tree = (object)adaptor.Create(string_literal216);
                    			adaptor.AddChild(root_0, string_literal216_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal217=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2370); 
                    			char_literal217_tree = (object)adaptor.Create(char_literal217);
                    			adaptor.AddChild(root_0, char_literal217_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:399:1: (ell2= double_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:399:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2376);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal218=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2379); 
                    			char_literal218_tree = (object)adaptor.Create(char_literal218);
                    			adaptor.AddChild(root_0, char_literal218_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:400:1: ( (ell3= double_literal ) ',' )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:400:2: (ell3= double_literal ) ','
                    		{
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:400:2: (ell3= double_literal )
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:400:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2385);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}

                    			char_literal219=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2388); 
                    				char_literal219_tree = (object)adaptor.Create(char_literal219);
                    				adaptor.AddChild(root_0, char_literal219_tree);


                    		}

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:401:1: ( (el4= double_literal ) )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:401:2: (el4= double_literal )
                    		{
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:401:2: (el4= double_literal )
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:401:3: el4= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2395);
                    				el4 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, el4.Tree);
                    				retval.ret.setZFact(((el4 != null) ? el4.ret : null));

                    			}


                    		}

                    		char_literal220=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2400); 
                    			char_literal220_tree = (object)adaptor.Create(char_literal220);
                    			adaptor.AddChild(root_0, char_literal220_tree);

                    		END_OF_STATEMENT221=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2401); 
                    			END_OF_STATEMENT221_tree = (object)adaptor.Create(END_OF_STATEMENT221);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT221_tree);


                    	}


                    }
                    break;
                case 5 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:403:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:403:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:403:3: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal222=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2406); 
                    			string_literal222_tree = (object)adaptor.Create(string_literal222);
                    			adaptor.AddChild(root_0, string_literal222_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal223=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2408); 
                    			char_literal223_tree = (object)adaptor.Create(char_literal223);
                    			adaptor.AddChild(root_0, char_literal223_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:404:1: (ell2= double_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:404:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2414);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal224=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2417); 
                    			char_literal224_tree = (object)adaptor.Create(char_literal224);
                    			adaptor.AddChild(root_0, char_literal224_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:405:1: ( (ell3= double_literal ) )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:405:2: (ell3= double_literal )
                    		{
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:405:2: (ell3= double_literal )
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:405:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2423);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}


                    		}

                    		char_literal225=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2428); 
                    			char_literal225_tree = (object)adaptor.Create(char_literal225);
                    			adaptor.AddChild(root_0, char_literal225_tree);

                    		END_OF_STATEMENT226=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2429); 
                    			END_OF_STATEMENT226_tree = (object)adaptor.Create(END_OF_STATEMENT226);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT226_tree);


                    	}


                    }
                    break;
                case 6 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:407:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:407:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:407:3: 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal227=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2434); 
                    			string_literal227_tree = (object)adaptor.Create(string_literal227);
                    			adaptor.AddChild(root_0, string_literal227_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal228=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2436); 
                    			char_literal228_tree = (object)adaptor.Create(char_literal228);
                    			adaptor.AddChild(root_0, char_literal228_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:408:1: (ell2= double_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:408:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2442);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal229=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2446); 
                    			char_literal229_tree = (object)adaptor.Create(char_literal229);
                    			adaptor.AddChild(root_0, char_literal229_tree);

                    		END_OF_STATEMENT230=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2447); 
                    			END_OF_STATEMENT230_tree = (object)adaptor.Create(END_OF_STATEMENT230);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT230_tree);


                    	}


                    }
                    break;
                case 7 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:410:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:410:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:410:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal231=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2453); 
                    			string_literal231_tree = (object)adaptor.Create(string_literal231);
                    			adaptor.AddChild(root_0, string_literal231_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal232=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2455); 
                    			char_literal232_tree = (object)adaptor.Create(char_literal232);
                    			adaptor.AddChild(root_0, char_literal232_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:411:1: (vl1= string_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:411:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2461);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal233=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2464); 
                    			char_literal233_tree = (object)adaptor.Create(char_literal233);
                    			adaptor.AddChild(root_0, char_literal233_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:412:1: ( (vl2= string_literal ) ',' )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:412:2: (vl2= string_literal ) ','
                    		{
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:412:2: (vl2= string_literal )
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:412:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2471);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}

                    			char_literal234=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2474); 
                    				char_literal234_tree = (object)adaptor.Create(char_literal234);
                    				adaptor.AddChild(root_0, char_literal234_tree);


                    		}

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:413:1: ( (vl3= string_literal ) )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:413:2: (vl3= string_literal )
                    		{
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:413:2: (vl3= string_literal )
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:413:3: vl3= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2482);
                    				vl3 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl3.Tree);
                    				retval.ret.setZTitle(((vl3 != null) ? vl3.ret : null));

                    			}


                    		}

                    		char_literal235=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2487); 
                    			char_literal235_tree = (object)adaptor.Create(char_literal235);
                    			adaptor.AddChild(root_0, char_literal235_tree);

                    		END_OF_STATEMENT236=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2488); 
                    			END_OF_STATEMENT236_tree = (object)adaptor.Create(END_OF_STATEMENT236);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT236_tree);


                    	}


                    }
                    break;
                case 8 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:415:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:415:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:415:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal237=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2494); 
                    			string_literal237_tree = (object)adaptor.Create(string_literal237);
                    			adaptor.AddChild(root_0, string_literal237_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal238=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2496); 
                    			char_literal238_tree = (object)adaptor.Create(char_literal238);
                    			adaptor.AddChild(root_0, char_literal238_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:416:1: (vl1= string_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:416:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2502);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal239=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2505); 
                    			char_literal239_tree = (object)adaptor.Create(char_literal239);
                    			adaptor.AddChild(root_0, char_literal239_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:417:1: ( (vl2= string_literal ) )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:417:2: (vl2= string_literal )
                    		{
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:417:2: (vl2= string_literal )
                    			// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:417:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2512);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}


                    		}

                    		char_literal240=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2517); 
                    			char_literal240_tree = (object)adaptor.Create(char_literal240);
                    			adaptor.AddChild(root_0, char_literal240_tree);

                    		END_OF_STATEMENT241=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2518); 
                    			END_OF_STATEMENT241_tree = (object)adaptor.Create(END_OF_STATEMENT241);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT241_tree);


                    	}


                    }
                    break;
                case 9 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:419:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:419:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:419:3: 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal242=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2523); 
                    			string_literal242_tree = (object)adaptor.Create(string_literal242);
                    			adaptor.AddChild(root_0, string_literal242_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal243=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2525); 
                    			char_literal243_tree = (object)adaptor.Create(char_literal243);
                    			adaptor.AddChild(root_0, char_literal243_tree);

                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:420:1: (vl1= string_literal )
                    		// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:420:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2531);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal244=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2535); 
                    			char_literal244_tree = (object)adaptor.Create(char_literal244);
                    			adaptor.AddChild(root_0, char_literal244_tree);

                    		END_OF_STATEMENT245=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2536); 
                    			END_OF_STATEMENT245_tree = (object)adaptor.Create(END_OF_STATEMENT245);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT245_tree);


                    	}


                    }
                    break;
                case 10 :
                    // C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:422:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:422:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    	// C:\\Documents and Settings\\Administrator\\Desktop\\Spinach\\InterpreterFrontEnd\\spinach.g:422:3: 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT
                    	{
                    		string_literal246=(IToken)Match(input,56,FOLLOW_56_in_plotfunctions2541); 
                    			string_literal246_tree = (object)adaptor.Create(string_literal246);
                    			adaptor.AddChild(root_0, string_literal246_tree);

                    		char_literal247=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2542); 
                    			char_literal247_tree = (object)adaptor.Create(char_literal247);
                    			adaptor.AddChild(root_0, char_literal247_tree);

                    		retval.ret.setPlotFunction("setScaleMode");
                    		SCALEMODE248=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_plotfunctions2545); 
                    			SCALEMODE248_tree = (object)adaptor.Create(SCALEMODE248);
                    			adaptor.AddChild(root_0, SCALEMODE248_tree);

                    		retval.ret.setScaleMode(SCALEMODE248.Text);
                    		char_literal249=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2549); 
                    			char_literal249_tree = (object)adaptor.Create(char_literal249);
                    			adaptor.AddChild(root_0, char_literal249_tree);

                    		END_OF_STATEMENT250=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2551); 
                    			END_OF_STATEMENT250_tree = (object)adaptor.Create(END_OF_STATEMENT250);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT250_tree);


                    	}


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
    // $ANTLR end "plotfunctions"

    // Delegated rules


   	protected DFA18 dfa18;
   	protected DFA22 dfa22;
   	protected DFA28 dfa28;
   	protected DFA45 dfa45;
   	protected DFA49 dfa49;
   	protected DFA58 dfa58;
	private void InitializeCyclicDFAs()
	{
    	this.dfa18 = new DFA18(this);
    	this.dfa22 = new DFA22(this);
    	this.dfa28 = new DFA28(this);
    	this.dfa45 = new DFA45(this);
    	this.dfa49 = new DFA49(this);
    	this.dfa58 = new DFA58(this);






	}

    const string DFA18_eotS =
        "\x0a\uffff";
    const string DFA18_eofS =
        "\x0a\uffff";
    const string DFA18_minS =
        "\x01\x04\x01\x08\x01\x04\x02\uffff\x02\x1e\x01\x08\x02\uffff";
    const string DFA18_maxS =
        "\x01\x04\x01\x1d\x01\x05\x02\uffff\x02\x1e\x01\x1d\x02\uffff";
    const string DFA18_acceptS =
        "\x03\uffff\x01\x01\x01\x02\x03\uffff\x01\x04\x01\x03";
    const string DFA18_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x01\x01",
            "\x01\x03\x08\uffff\x01\x04\x0b\uffff\x01\x02",
            "\x01\x06\x01\x05",
            "",
            "",
            "\x01\x07",
            "\x01\x07",
            "\x01\x09\x14\uffff\x01\x08",
            "",
            ""
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "143:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )"; }
        }

    }

    const string DFA22_eotS =
        "\x0a\uffff";
    const string DFA22_eofS =
        "\x0a\uffff";
    const string DFA22_minS =
        "\x01\x04\x01\uffff\x01\x09\x01\uffff\x01\x04\x02\x1e\x01\x09\x02"+
        "\uffff";
    const string DFA22_maxS =
        "\x01\x0b\x01\uffff\x01\x21\x01\uffff\x01\x05\x02\x1e\x01\x21\x02"+
        "\uffff";
    const string DFA22_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x04\uffff\x01\x03\x01\x04";
    const string DFA22_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA22_transitionS = {
            "\x01\x02\x02\x01\x04\uffff\x01\x03",
            "",
            "\x01\x01\x03\uffff\x01\x01\x03\uffff\x03\x01\x09\uffff\x01"+
            "\x04\x03\uffff\x01\x01",
            "",
            "\x01\x06\x01\x05",
            "\x01\x07",
            "\x01\x07",
            "\x01\x09\x03\uffff\x01\x09\x04\uffff\x02\x09\x09\uffff\x01"+
            "\x08\x03\uffff\x01\x09",
            "",
            ""
    };

    static readonly short[] DFA22_eot = DFA.UnpackEncodedString(DFA22_eotS);
    static readonly short[] DFA22_eof = DFA.UnpackEncodedString(DFA22_eofS);
    static readonly char[] DFA22_min = DFA.UnpackEncodedStringToUnsignedChars(DFA22_minS);
    static readonly char[] DFA22_max = DFA.UnpackEncodedStringToUnsignedChars(DFA22_maxS);
    static readonly short[] DFA22_accept = DFA.UnpackEncodedString(DFA22_acceptS);
    static readonly short[] DFA22_special = DFA.UnpackEncodedString(DFA22_specialS);
    static readonly short[][] DFA22_transition = DFA.UnpackEncodedStringArray(DFA22_transitionS);

    protected class DFA22 : DFA
    {
        public DFA22(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 22;
            this.eot = DFA22_eot;
            this.eof = DFA22_eof;
            this.min = DFA22_min;
            this.max = DFA22_max;
            this.accept = DFA22_accept;
            this.special = DFA22_special;
            this.transition = DFA22_transition;

        }

        override public string Description
        {
            get { return "165:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem )"; }
        }

    }

    const string DFA28_eotS =
        "\x0a\uffff";
    const string DFA28_eofS =
        "\x0a\uffff";
    const string DFA28_minS =
        "\x01\x04\x01\uffff\x01\x09\x01\uffff\x01\x04\x02\x1e\x01\x09\x02"+
        "\uffff";
    const string DFA28_maxS =
        "\x01\x1b\x01\uffff\x01\x1d\x01\uffff\x01\x05\x02\x1e\x01\x1d\x02"+
        "\uffff";
    const string DFA28_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x04\uffff\x01\x04\x01\x03";
    const string DFA28_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA28_transitionS = {
            "\x01\x02\x02\x01\x14\uffff\x01\x03",
            "",
            "\x01\x01\x07\uffff\x01\x01\x0b\uffff\x01\x04",
            "",
            "\x01\x06\x01\x05",
            "\x01\x07",
            "\x01\x07",
            "\x01\x09\x13\uffff\x01\x08",
            "",
            ""
    };

    static readonly short[] DFA28_eot = DFA.UnpackEncodedString(DFA28_eotS);
    static readonly short[] DFA28_eof = DFA.UnpackEncodedString(DFA28_eofS);
    static readonly char[] DFA28_min = DFA.UnpackEncodedStringToUnsignedChars(DFA28_minS);
    static readonly char[] DFA28_max = DFA.UnpackEncodedStringToUnsignedChars(DFA28_maxS);
    static readonly short[] DFA28_accept = DFA.UnpackEncodedString(DFA28_acceptS);
    static readonly short[] DFA28_special = DFA.UnpackEncodedString(DFA28_specialS);
    static readonly short[][] DFA28_transition = DFA.UnpackEncodedStringArray(DFA28_transitionS);

    protected class DFA28 : DFA
    {
        public DFA28(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 28;
            this.eot = DFA28_eot;
            this.eof = DFA28_eof;
            this.min = DFA28_min;
            this.max = DFA28_max;
            this.accept = DFA28_accept;
            this.special = DFA28_special;
            this.transition = DFA28_transition;

        }

        override public string Description
        {
            get { return "236:13: ( var_int_or_double_literal | string_literal | vectorelem | matrixelem )"; }
        }

    }

    const string DFA45_eotS =
        "\x0e\uffff";
    const string DFA45_eofS =
        "\x0e\uffff";
    const string DFA45_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA45_maxS =
        "\x01\x2f\x01\uffff\x01\x1d\x0b\uffff";
    const string DFA45_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x01\x01\x02";
    const string DFA45_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x04\uffff\x01"+
            "\x01\x0c\uffff\x01\x05\x03\uffff\x01\x04\x02\uffff\x01\x06\x01"+
            "\x07\x01\x0a\x02\uffff\x01\x08\x01\uffff\x01\x0b\x04\uffff\x01"+
            "\x09",
            "",
            "\x01\x0c\x02\uffff\x01\x0d\x05\uffff\x01\x0c\x0b\uffff\x01"+
            "\x0c",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA45_eot = DFA.UnpackEncodedString(DFA45_eotS);
    static readonly short[] DFA45_eof = DFA.UnpackEncodedString(DFA45_eofS);
    static readonly char[] DFA45_min = DFA.UnpackEncodedStringToUnsignedChars(DFA45_minS);
    static readonly char[] DFA45_max = DFA.UnpackEncodedStringToUnsignedChars(DFA45_maxS);
    static readonly short[] DFA45_accept = DFA.UnpackEncodedString(DFA45_acceptS);
    static readonly short[] DFA45_special = DFA.UnpackEncodedString(DFA45_specialS);
    static readonly short[][] DFA45_transition = DFA.UnpackEncodedStringArray(DFA45_transitionS);

    protected class DFA45 : DFA
    {
        public DFA45(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 45;
            this.eot = DFA45_eot;
            this.eof = DFA45_eof;
            this.min = DFA45_min;
            this.max = DFA45_max;
            this.accept = DFA45_accept;
            this.special = DFA45_special;
            this.transition = DFA45_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 300:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA49_eotS =
        "\x0e\uffff";
    const string DFA49_eofS =
        "\x0e\uffff";
    const string DFA49_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA49_maxS =
        "\x01\x2f\x01\uffff\x01\x1d\x0b\uffff";
    const string DFA49_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x02\x01\x01";
    const string DFA49_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA49_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x04\uffff\x01"+
            "\x01\x0c\uffff\x01\x05\x03\uffff\x01\x04\x02\uffff\x01\x06\x01"+
            "\x07\x01\x0a\x02\uffff\x01\x08\x01\uffff\x01\x0b\x04\uffff\x01"+
            "\x09",
            "",
            "\x01\x0d\x02\uffff\x01\x0c\x05\uffff\x01\x0d\x0b\uffff\x01"+
            "\x0d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA49_eot = DFA.UnpackEncodedString(DFA49_eotS);
    static readonly short[] DFA49_eof = DFA.UnpackEncodedString(DFA49_eofS);
    static readonly char[] DFA49_min = DFA.UnpackEncodedStringToUnsignedChars(DFA49_minS);
    static readonly char[] DFA49_max = DFA.UnpackEncodedStringToUnsignedChars(DFA49_maxS);
    static readonly short[] DFA49_accept = DFA.UnpackEncodedString(DFA49_acceptS);
    static readonly short[] DFA49_special = DFA.UnpackEncodedString(DFA49_specialS);
    static readonly short[][] DFA49_transition = DFA.UnpackEncodedStringArray(DFA49_transitionS);

    protected class DFA49 : DFA
    {
        public DFA49(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 310:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA58_eotS =
        "\x21\uffff";
    const string DFA58_eofS =
        "\x21\uffff";
    const string DFA58_minS =
        "\x01\x30\x03\uffff\x02\x0b\x01\uffff\x01\x06\x01\x1b\x01\x0d\x01"+
        "\x04\x01\x06\x01\uffff\x03\x04\x02\x0d\x01\x04\x01\x1b\x03\uffff"+
        "\x05\x04\x01\x0d\x01\x04\x02\uffff\x01\x04";
    const string DFA58_maxS =
        "\x01\x38\x03\uffff\x02\x0b\x01\uffff\x01\x06\x01\x1b\x01\x1f\x01"+
        "\x1b\x01\x06\x01\uffff\x03\x1b\x02\x1f\x01\x04\x01\x1b\x03\uffff"+
        "\x05\x1b\x01\x1f\x01\x04\x02\uffff\x01\x1b";
    const string DFA58_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x02\uffff\x01\x0a\x05\uffff"+
        "\x01\x06\x07\uffff\x01\x09\x01\x04\x01\x05\x07\uffff\x01\x08\x01"+
        "\x07\x01\uffff";
    const string DFA58_specialS =
        "\x21\uffff}>";
    static readonly string[] DFA58_transitionS = {
            "\x01\x01\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06",
            "",
            "",
            "",
            "\x01\x07",
            "\x01\x08",
            "",
            "\x01\x09",
            "\x01\x0a",
            "\x01\x0c\x11\uffff\x01\x0b",
            "\x01\x0f\x01\x0d\x01\x0e\x14\uffff\x01\x10",
            "\x01\x11",
            "",
            "\x01\x0f\x01\x0d\x01\x0e\x14\uffff\x01\x10",
            "\x01\x0f\x01\x0d\x01\x0e\x14\uffff\x01\x10",
            "\x01\x0f\x01\x0d\x01\x0e\x0a\uffff\x01\x12\x09\uffff\x01\x10",
            "\x01\x14\x11\uffff\x01\x13",
            "\x01\x16\x11\uffff\x01\x15",
            "\x01\x17",
            "\x01\x18",
            "",
            "",
            "",
            "\x01\x0f\x01\x0d\x01\x0e\x14\uffff\x01\x10",
            "\x01\x1b\x01\x19\x01\x1a\x14\uffff\x01\x1c",
            "\x01\x1b\x01\x19\x01\x1a\x14\uffff\x01\x1c",
            "\x01\x1b\x01\x19\x01\x1a\x14\uffff\x01\x1c",
            "\x01\x1b\x01\x19\x01\x1a\x0a\uffff\x01\x1d\x09\uffff\x01\x1c",
            "\x01\x1e\x11\uffff\x01\x1f",
            "\x01\x20",
            "",
            "",
            "\x01\x1b\x01\x19\x01\x1a\x14\uffff\x01\x1c"
    };

    static readonly short[] DFA58_eot = DFA.UnpackEncodedString(DFA58_eotS);
    static readonly short[] DFA58_eof = DFA.UnpackEncodedString(DFA58_eofS);
    static readonly char[] DFA58_min = DFA.UnpackEncodedStringToUnsignedChars(DFA58_minS);
    static readonly char[] DFA58_max = DFA.UnpackEncodedStringToUnsignedChars(DFA58_maxS);
    static readonly short[] DFA58_accept = DFA.UnpackEncodedString(DFA58_acceptS);
    static readonly short[] DFA58_special = DFA.UnpackEncodedString(DFA58_specialS);
    static readonly short[][] DFA58_transition = DFA.UnpackEncodedStringArray(DFA58_transitionS);

    protected class DFA58 : DFA
    {
        public DFA58(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 58;
            this.eot = DFA58_eot;
            this.eof = DFA58_eof;
            this.min = DFA58_min;
            this.max = DFA58_max;
            this.accept = DFA58_accept;
            this.special = DFA58_special;
            this.transition = DFA58_transition;

        }

        override public string Description
        {
            get { return "383:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program69 = new BitSet(new ulong[]{0x01F14D3D10000492UL});
    public static readonly BitSet FOLLOW_expr1_in_expr96 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallelfor_in_expr100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functiondefination_in_expr115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forexpr_in_expr1131 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr1143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr2_in_forexpr176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_forexpr185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_plotfunctions_in_forexpr195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_forexpr204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_forexpr213 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expr2233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifelse_in_expr2243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forstatement_in_expr2253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_expr2262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_expr2272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_expr2284 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr2291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_int_or_double_literal316 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_double_literal_in_var_int_or_double_literal326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varorstruct_in_var_int_or_double_literal334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_varorstruct349 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structassign_in_varorstruct352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_double_literal417 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_string_literal437 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_string_literal441 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_27_in_string_literal446 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixvardec466 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixvardec468 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixvardec475 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec477 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec479 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec482 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec485 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec488 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec492 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec495 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixvardec503 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matrixvardec510 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec516 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec517 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec524 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec528 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec533 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec536 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec542 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec549 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec552 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec556 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec559 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec565 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matrixvardec576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorvardec594 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorvardec596 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorvardec598 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec601 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec603 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec606 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec609 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorvardec615 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_vectorvardec622 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec629 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec630 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec637 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec640 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec645 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec648 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec653 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec660 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec663 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec670 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec673 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec679 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_vectorvardec686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem706 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem712 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem716 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem721 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem724 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem727 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem731 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem736 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem761 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorelem767 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorelem771 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem777 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorelem780 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment803 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment813 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_vectorelem_in_assignment825 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_matrixelem_in_assignment838 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment846 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_assignment856 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_dotproduct_in_assignment860 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixtranspose_in_assignment869 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_assignment873 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment881 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_assignment889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_additive_expression920 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additive_expression925 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_additive_expression_in_additive_expression931 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplicative_expression959 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_bracket_exp_in_multiplicative_expression971 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_matrixelem_in_multiplicative_expression984 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_vectorelem_in_multiplicative_expression997 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplicative_expression1006 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_multiplicative_expression1016 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_bracket_exp1062 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_bracket_exp1063 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_bracket_exp1065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expression_in_subtractive_exp1094 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_33_in_subtractive_exp1099 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_subtractive_exp1105 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_34_in_structdec1135 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structdec1137 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_structdec1143 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_structdec1144 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_structdec1148 = new BitSet(new ulong[]{0x0000000000000480UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_structdec1153 = new BitSet(new ulong[]{0x0000000000008480UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_structdec1158 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec1163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarvardec1184 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_scalarvardec1191 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarvardec1198 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_scalarvardec1202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1224 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1231 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec1237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1256 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_DOT_in_structassign1259 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_deletionofvar1283 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_deletionofvar1287 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_deletionofvar1291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_print1310 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_print1313 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_print1322 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_vectorelem_in_print1330 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixelem_in_print1341 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print1355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parallelfor1377 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_parallelfor1378 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_parallelfor1384 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_POINT_in_parallelfor1387 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallelfor1393 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_parallelfor1396 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallelfor1401 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_parallelfor1404 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_parallelfor1406 = new BitSet(new ulong[]{0x0000450800000490UL});
    public static readonly BitSet FOLLOW_expr2_in_parallelfor1413 = new BitSet(new ulong[]{0x0000458800008490UL});
    public static readonly BitSet FOLLOW_39_in_parallelfor1419 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_parallelfor1422 = new BitSet(new ulong[]{0x0000450800008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_parallelfor1430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_ifelse1447 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_ifelse1449 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_varorstruct_in_ifelse1452 = new BitSet(new ulong[]{0x0000000007E00000UL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_ifelse1463 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_ifelse1473 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_ifelse1483 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_LESSTHANEQUALTOEXPRESSION_in_ifelse1494 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_ifelse1504 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_ifelse1515 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_ifelse1528 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_ifelse1535 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_ifelse1539 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1541 = new BitSet(new ulong[]{0x01F1C51910008490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1549 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1554 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_ifelse1557 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1560 = new BitSet(new ulong[]{0x01F1C51910008490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1569 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr1_in_ifloop1596 = new BitSet(new ulong[]{0x01F1C51910000492UL});
    public static readonly BitSet FOLLOW_functionreturn_in_ifloop1599 = new BitSet(new ulong[]{0x01F1C51910000492UL});
    public static readonly BitSet FOLLOW_42_in_forstatement1618 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_forstatement1620 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_forstatement1626 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_POINT_in_forstatement1629 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_forstatement1635 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_forstatement1638 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_forstatement1643 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_forstatement1646 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_forstatement1648 = new BitSet(new ulong[]{0x01F1450910000490UL});
    public static readonly BitSet FOLLOW_forexpr_in_forstatement1653 = new BitSet(new ulong[]{0x01F1450910008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_forstatement1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_functioncall1679 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functioncall1684 = new BitSet(new ulong[]{0x0000200008002870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1689 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_functioncall1695 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functioncall1700 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1705 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_functioncall1711 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functioncall1719 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functioncall1723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_functiondefination1750 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1755 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1761 = new BitSet(new ulong[]{0x0000000110002080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1769 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1772 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1777 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1786 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1788 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1792 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1795 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1799 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1807 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1815 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1823 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1829 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1837 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1841 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1845 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1849 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1856 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_functiondefination1859 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1864 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1870 = new BitSet(new ulong[]{0x0000000110002080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1879 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1882 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1886 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1895 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1897 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1901 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1904 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1908 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1916 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1924 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1932 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1938 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1946 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1950 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1954 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1958 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1965 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct1987 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_dotproduct1991 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct1997 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_matrixtranspose2016 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_matrixtranspose2018 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixtranspose2020 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_matrixtranspose2023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixreference2039 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixreference2041 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixreference2046 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixreference2048 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixreference2052 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorreference2071 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorreference2073 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorreference2078 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2080 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorreference2084 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarargument_in_arguments2100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixreference_in_arguments2106 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorreference_in_arguments2112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarargument2144 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarargument2151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_comment2170 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_comment2171 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_47_in_functionreturn2189 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functionreturn2192 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functionreturn2196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_plotfunctions2220 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2223 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2230 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2235 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2242 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2247 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2254 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2258 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2262 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2267 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2272 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2275 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2281 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2289 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2290 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_plotfunctions2296 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2299 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2305 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2310 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2316 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2320 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2324 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2329 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2334 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2337 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2343 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2351 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2352 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_plotfunctions2358 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2359 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2360 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2368 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2370 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2376 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2379 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2385 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2388 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2395 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2400 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2401 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2406 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2408 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2414 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2417 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2423 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2428 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2434 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2436 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2442 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2446 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2453 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2455 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2461 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2464 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2471 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2474 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2482 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2487 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2494 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2496 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2502 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2505 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2512 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2517 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2523 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2525 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2531 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2535 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2536 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_plotfunctions2541 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2542 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_plotfunctions2545 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2549 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2551 = new BitSet(new ulong[]{0x0000000000000002UL});

}
