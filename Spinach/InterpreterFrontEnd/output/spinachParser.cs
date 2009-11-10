// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g 2009-11-09 22:36:04


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
		get { return "C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g"; }
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:24:1: program returns [List<Element> ret] : ( expr )+ ;
    public spinachParser.program_return program() // throws RecognitionException [1]
    {   
        spinachParser.program_return retval = new spinachParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:28:3: ( ( expr )+ )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:28:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:28:5: ( expr )+
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
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:28:6: expr
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:32:1: expr returns [Element ret] : ( expr1 | parallelfor | structdec | structobjdec | functiondefination );
    public spinachParser.expr_return expr() // throws RecognitionException [1]
    {   
        spinachParser.expr_return retval = new spinachParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr12 = null;

        spinachParser.parallelfor_return parallelfor3 = null;

        spinachParser.structdec_return structdec4 = null;

        spinachParser.structobjdec_return structobjdec5 = null;

        spinachParser.functiondefination_return functiondefination6 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:33:3: ( expr1 | parallelfor | structdec | structobjdec | functiondefination )
            int alt2 = 5;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                int LA2_1 = input.LA(2);

                if ( (LA2_1 == ASSIGNMENT || LA2_1 == LEFTBRACE || LA2_1 == DOT || LA2_1 == 29) )
                {
                    alt2 = 1;
                }
                else if ( (LA2_1 == VARIABLE) )
                {
                    alt2 = 4;
                }
                else 
                {
                    NoViableAltException nvae_d2s1 =
                        new NoViableAltException("", 2, 1, input);

                    throw nvae_d2s1;
                }
                }
                break;
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
                int LA2_3 = input.LA(2);

                if ( (LA2_3 == VARIABLE) )
                {
                    int LA2_8 = input.LA(3);

                    if ( (LA2_8 == END_OF_STATEMENT) )
                    {
                        alt2 = 1;
                    }
                    else if ( (LA2_8 == LEFTBRACE) )
                    {
                        alt2 = 5;
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s8 =
                            new NoViableAltException("", 2, 8, input);

                        throw nvae_d2s8;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d2s3 =
                        new NoViableAltException("", 2, 3, input);

                    throw nvae_d2s3;
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
                alt2 = 5;
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
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:33:4: expr1
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
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:33:37: parallelfor
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
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:33:82: structdec
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
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:34:8: structobjdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structobjdec_in_expr115);
                    	structobjdec5 = structobjdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structobjdec5.Tree);
                    	 retval.ret = ((structobjdec5 != null) ? structobjdec5.ret : null);

                    }
                    break;
                case 5 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:35:8: functiondefination
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functiondefination_in_expr126);
                    	functiondefination6 = functiondefination();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functiondefination6.Tree);
                    	retval.ret = ((functiondefination6 != null) ? functiondefination6.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:38:1: expr1 returns [Element ret] : ( expr2 | matrixvardec | plotfunctions | deletionofvar | print | functioncall | scalarvardec | vectorvardec );
    public spinachParser.expr1_return expr1() // throws RecognitionException [1]
    {   
        spinachParser.expr1_return retval = new spinachParser.expr1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr2_return expr27 = null;

        spinachParser.matrixvardec_return matrixvardec8 = null;

        spinachParser.plotfunctions_return plotfunctions9 = null;

        spinachParser.deletionofvar_return deletionofvar10 = null;

        spinachParser.print_return print11 = null;

        spinachParser.functioncall_return functioncall12 = null;

        spinachParser.scalarvardec_return scalarvardec13 = null;

        spinachParser.vectorvardec_return vectorvardec14 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:39:4: ( expr2 | matrixvardec | plotfunctions | deletionofvar | print | functioncall | scalarvardec | vectorvardec )
            int alt3 = 8;
            alt3 = dfa3.Predict(input);
            switch (alt3) 
            {
                case 1 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:39:6: expr2
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr2_in_expr1143);
                    	expr27 = expr2();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr27.Tree);
                    	retval.ret = ((expr27 != null) ? expr27.ret : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:40:7: matrixvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixvardec_in_expr1152);
                    	matrixvardec8 = matrixvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matrixvardec8.Tree);
                    	 retval.ret = ((matrixvardec8 != null) ? matrixvardec8.ret : null);

                    }
                    break;
                case 3 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:41:7: plotfunctions
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_plotfunctions_in_expr1162);
                    	plotfunctions9 = plotfunctions();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, plotfunctions9.Tree);
                    	retval.ret = ((plotfunctions9 != null) ? plotfunctions9.ret : null);

                    }
                    break;
                case 4 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:42:7: deletionofvar
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_deletionofvar_in_expr1171);
                    	deletionofvar10 = deletionofvar();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, deletionofvar10.Tree);
                    	retval.ret = ((deletionofvar10 != null) ? deletionofvar10.ret : null);

                    }
                    break;
                case 5 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:43:7: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr1182);
                    	print11 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print11.Tree);
                    	 retval.ret = ((print11 != null) ? print11.ret : null); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:44:7: functioncall
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functioncall_in_expr1192);
                    	functioncall12 = functioncall();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functioncall12.Tree);
                    	retval.ret=((functioncall12 != null) ? functioncall12.ret : null);

                    }
                    break;
                case 7 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:45:7: scalarvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scalarvardec_in_expr1201);
                    	scalarvardec13 = scalarvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, scalarvardec13.Tree);
                    	 retval.ret = ((scalarvardec13 != null) ? scalarvardec13.ret : null);

                    }
                    break;
                case 8 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:46:7: vectorvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_vectorvardec_in_expr1211);
                    	vectorvardec14 = vectorvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, vectorvardec14.Tree);
                    	 retval.ret = ((vectorvardec14 != null) ? vectorvardec14.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:48:1: expr2 returns [Element ret] : (el1= assignment | el4= ifelse | el5= forstatement | el6= comment ) ;
    public spinachParser.expr2_return expr2() // throws RecognitionException [1]
    {   
        spinachParser.expr2_return retval = new spinachParser.expr2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.assignment_return el1 = null;

        spinachParser.ifelse_return el4 = null;

        spinachParser.forstatement_return el5 = null;

        spinachParser.comment_return el6 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:49:1: ( (el1= assignment | el4= ifelse | el5= forstatement | el6= comment ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:49:4: (el1= assignment | el4= ifelse | el5= forstatement | el6= comment )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:49:4: (el1= assignment | el4= ifelse | el5= forstatement | el6= comment )
            	int alt4 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    alt4 = 1;
            	    }
            	    break;
            	case 40:
            		{
            	    alt4 = 2;
            	    }
            	    break;
            	case 42:
            		{
            	    alt4 = 3;
            	    }
            	    break;
            	case 46:
            		{
            	    alt4 = 4;
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
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:49:5: el1= assignment
            	        {
            	        	PushFollow(FOLLOW_assignment_in_expr2231);
            	        	el1 = assignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret = ((el1 != null) ? el1.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:50:5: el4= ifelse
            	        {
            	        	PushFollow(FOLLOW_ifelse_in_expr2241);
            	        	el4 = ifelse();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	retval.ret = ((el4 != null) ? el4.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:51:5: el5= forstatement
            	        {
            	        	PushFollow(FOLLOW_forstatement_in_expr2251);
            	        	el5 = forstatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el5.Tree);
            	        	retval.ret = ((el5 != null) ? el5.ret : null);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:52:5: el6= comment
            	        {
            	        	PushFollow(FOLLOW_comment_in_expr2260);
            	        	el6 = comment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el6.Tree);
            	        	retval.ret = ((el6 != null) ? el6.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:54:1: var_int_or_double_literal returns [Element ret] : ( int_literal | double_literal | varorstruct ) ;
    public spinachParser.var_int_or_double_literal_return var_int_or_double_literal() // throws RecognitionException [1]
    {   
        spinachParser.var_int_or_double_literal_return retval = new spinachParser.var_int_or_double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.int_literal_return int_literal15 = null;

        spinachParser.double_literal_return double_literal16 = null;

        spinachParser.varorstruct_return varorstruct17 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:55:3: ( ( int_literal | double_literal | varorstruct ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:55:7: ( int_literal | double_literal | varorstruct )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:55:7: ( int_literal | double_literal | varorstruct )
            	int alt5 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case INT_LITERAL:
            		{
            	    alt5 = 1;
            	    }
            	    break;
            	case DOUBLE_LITERAL:
            		{
            	    alt5 = 2;
            	    }
            	    break;
            	case VARIABLE:
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
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:55:8: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_int_or_double_literal279);
            	        	int_literal15 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal15.Tree);
            	        	retval.ret = ((int_literal15 != null) ? int_literal15.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:56:7: double_literal
            	        {
            	        	PushFollow(FOLLOW_double_literal_in_var_int_or_double_literal289);
            	        	double_literal16 = double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, double_literal16.Tree);
            	        	retval.ret = ((double_literal16 != null) ? double_literal16.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:57:5: varorstruct
            	        {
            	        	PushFollow(FOLLOW_varorstruct_in_var_int_or_double_literal297);
            	        	varorstruct17 = varorstruct();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, varorstruct17.Tree);
            	        	retval.ret = ((varorstruct17 != null) ? varorstruct17.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:59:1: varorstruct returns [Element ret] : ( variable | structassign ) ;
    public spinachParser.varorstruct_return varorstruct() // throws RecognitionException [1]
    {   
        spinachParser.varorstruct_return retval = new spinachParser.varorstruct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.variable_return variable18 = null;

        spinachParser.structassign_return structassign19 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:60:1: ( ( variable | structassign ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:60:3: ( variable | structassign )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:60:3: ( variable | structassign )
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == VARIABLE) )
            	{
            	    int LA6_1 = input.LA(2);

            	    if ( (LA6_1 == EOF || (LA6_1 >= VARIABLE && LA6_1 <= VARTYPE) || (LA6_1 >= END_OF_STATEMENT && LA6_1 <= STRINGTYPE) || LA6_1 == RIGHTBRACE || LA6_1 == RIGHTPARANTHESIS || (LA6_1 >= PLUS && LA6_1 <= MULTIPLY) || (LA6_1 >= EQUALITYEXPRESSION && LA6_1 <= 28) || (LA6_1 >= 31 && LA6_1 <= 37) || (LA6_1 >= 39 && LA6_1 <= 40) || (LA6_1 >= 42 && LA6_1 <= 43) || (LA6_1 >= 46 && LA6_1 <= 48) || (LA6_1 >= 52 && LA6_1 <= 56)) )
            	    {
            	        alt6 = 1;
            	    }
            	    else if ( (LA6_1 == DOT) )
            	    {
            	        alt6 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d6s1 =
            	            new NoViableAltException("", 6, 1, input);

            	        throw nvae_d6s1;
            	    }
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
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:60:4: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_varorstruct312);
            	        	variable18 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable18.Tree);
            	        	retval.ret = ((variable18 != null) ? variable18.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:60:42: structassign
            	        {
            	        	PushFollow(FOLLOW_structassign_in_varorstruct315);
            	        	structassign19 = structassign();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structassign19.Tree);
            	        	retval.ret = ((structassign19 != null) ? structassign19.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:63:1: variable returns [VariableElement ret] : VARIABLE ;
    public spinachParser.variable_return variable() // throws RecognitionException [1]
    {   
        spinachParser.variable_return retval = new spinachParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE20 = null;

        object VARIABLE20_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:67:3: ( VARIABLE )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:67:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE20=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable337); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:69:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public spinachParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        spinachParser.int_literal_return retval = new spinachParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL21 = null;

        object INT_LITERAL21_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:73:3: ( INT_LITERAL )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:73:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL21=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal358); 
            		INT_LITERAL21_tree = (object)adaptor.Create(INT_LITERAL21);
            		adaptor.AddChild(root_0, INT_LITERAL21_tree);

            	 retval.ret.setText(((INT_LITERAL21 != null) ? INT_LITERAL21.Text : null)); 

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:75:1: double_literal returns [DoubleElement ret] : el1= DOUBLE_LITERAL ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:79:2: (el1= DOUBLE_LITERAL )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:79:4: el1= DOUBLE_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_double_literal380); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:81:1: string_literal returns [StringElement ret] : ( '\"' (el1= var_int_or_double_literal )* '\"' ) ;
    public spinachParser.string_literal_return string_literal() // throws RecognitionException [1]
    {   
        spinachParser.string_literal_return retval = new spinachParser.string_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal22 = null;
        IToken char_literal23 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;


        object char_literal22_tree=null;
        object char_literal23_tree=null;


         retval.ret = new StringElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:85:2: ( ( '\"' (el1= var_int_or_double_literal )* '\"' ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:85:3: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:85:3: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:85:4: '\"' (el1= var_int_or_double_literal )* '\"'
            	{
            		char_literal22=(IToken)Match(input,27,FOLLOW_27_in_string_literal400); 
            			char_literal22_tree = (object)adaptor.Create(char_literal22);
            			adaptor.AddChild(root_0, char_literal22_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:85:7: (el1= var_int_or_double_literal )*
            		do 
            		{
            		    int alt7 = 2;
            		    int LA7_0 = input.LA(1);

            		    if ( ((LA7_0 >= VARIABLE && LA7_0 <= DOUBLE_LITERAL)) )
            		    {
            		        alt7 = 1;
            		    }


            		    switch (alt7) 
            			{
            				case 1 :
            				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:85:8: el1= var_int_or_double_literal
            				    {
            				    	PushFollow(FOLLOW_var_int_or_double_literal_in_string_literal404);
            				    	el1 = var_int_or_double_literal();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	retval.ret.setText(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop7;
            		    }
            		} while (true);

            		loop7:
            			;	// Stops C# compiler whining that label 'loop7' has no statements

            		char_literal23=(IToken)Match(input,27,FOLLOW_27_in_string_literal409); 
            			char_literal23_tree = (object)adaptor.Create(char_literal23);
            			adaptor.AddChild(root_0, char_literal23_tree);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:87:1: matrixvardec returns [MatrixVariableDeclaration ret] : ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT ;
    public spinachParser.matrixvardec_return matrixvardec() // throws RecognitionException [1]
    {   
        spinachParser.matrixvardec_return retval = new spinachParser.matrixvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal24 = null;
        IToken char_literal25 = null;
        IToken VARTYPE26 = null;
        IToken char_literal27 = null;
        IToken char_literal28 = null;
        IToken char_literal29 = null;
        IToken char_literal30 = null;
        IToken char_literal31 = null;
        IToken ASSIGNMENT32 = null;
        IToken char_literal33 = null;
        IToken char_literal34 = null;
        IToken char_literal35 = null;
        IToken char_literal36 = null;
        IToken END_OF_STATEMENT37 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;

        spinachParser.int_literal_return el7 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal24_tree=null;
        object char_literal25_tree=null;
        object VARTYPE26_tree=null;
        object char_literal27_tree=null;
        object char_literal28_tree=null;
        object char_literal29_tree=null;
        object char_literal30_tree=null;
        object char_literal31_tree=null;
        object ASSIGNMENT32_tree=null;
        object char_literal33_tree=null;
        object char_literal34_tree=null;
        object char_literal35_tree=null;
        object char_literal36_tree=null;
        object END_OF_STATEMENT37_tree=null;


        	retval.ret = new MatrixVariableDeclaration();
        	
        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:91:2: ( ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:91:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:91:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:91:4: 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']'
            	{
            		string_literal24=(IToken)Match(input,28,FOLLOW_28_in_matrixvardec429); 
            			string_literal24_tree = (object)adaptor.Create(string_literal24);
            			adaptor.AddChild(root_0, string_literal24_tree);

            		char_literal25=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixvardec431); 
            			char_literal25_tree = (object)adaptor.Create(char_literal25);
            			adaptor.AddChild(root_0, char_literal25_tree);

            		VARTYPE26=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixvardec433); 
            			VARTYPE26_tree = (object)adaptor.Create(VARTYPE26);
            			adaptor.AddChild(root_0, VARTYPE26_tree);

            		 retval.ret.setType(((VARTYPE26 != null) ? VARTYPE26.Text : null));
            		char_literal27=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec436); 
            			char_literal27_tree = (object)adaptor.Create(char_literal27);
            			adaptor.AddChild(root_0, char_literal27_tree);

            		char_literal28=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec438); 
            			char_literal28_tree = (object)adaptor.Create(char_literal28);
            			adaptor.AddChild(root_0, char_literal28_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec441);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            		char_literal29=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec444); 
            			char_literal29_tree = (object)adaptor.Create(char_literal29);
            			adaptor.AddChild(root_0, char_literal29_tree);

            		char_literal30=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec447); 
            			char_literal30_tree = (object)adaptor.Create(char_literal30);
            			adaptor.AddChild(root_0, char_literal30_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec451);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            		char_literal31=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec454); 
            			char_literal31_tree = (object)adaptor.Create(char_literal31);
            			adaptor.AddChild(root_0, char_literal31_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:93:3: (el3= variable )
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:93:4: el3= variable
            		{
            			PushFollow(FOLLOW_variable_in_matrixvardec462);
            			el3 = variable();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el3.Tree);
            			 retval.ret.setVar(((el3 != null) ? el3.ret : null));

            		}

            		ASSIGNMENT32=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matrixvardec469); 
            			ASSIGNMENT32_tree = (object)adaptor.Create(ASSIGNMENT32);
            			adaptor.AddChild(root_0, ASSIGNMENT32_tree);

            		char_literal33=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec473); 
            			char_literal33_tree = (object)adaptor.Create(char_literal33);
            			adaptor.AddChild(root_0, char_literal33_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:6: ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) )
            		int alt10 = 2;
            		int LA10_0 = input.LA(1);

            		if ( (LA10_0 == INT_LITERAL) )
            		{
            		    alt10 = 1;
            		}
            		else if ( (LA10_0 == DOUBLE_LITERAL) )
            		{
            		    alt10 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d10s0 =
            		        new NoViableAltException("", 10, 0, input);

            		    throw nvae_d10s0;
            		}
            		switch (alt10) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:7: (el7= int_literal ( ',' el5= int_literal )* )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:7: (el7= int_literal ( ',' el5= int_literal )* )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:8: el7= int_literal ( ',' el5= int_literal )*
            		        	{
            		        		PushFollow(FOLLOW_int_literal_in_matrixvardec478);
            		        		el7 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el7.Tree);
            		        		retval.ret.addValue(((el7 != null) ? el7.ret : null));
            		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:57: ( ',' el5= int_literal )*
            		        		do 
            		        		{
            		        		    int alt8 = 2;
            		        		    int LA8_0 = input.LA(1);

            		        		    if ( (LA8_0 == 31) )
            		        		    {
            		        		        alt8 = 1;
            		        		    }


            		        		    switch (alt8) 
            		        			{
            		        				case 1 :
            		        				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:58: ',' el5= int_literal
            		        				    {
            		        				    	char_literal34=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec483); 
            		        				    		char_literal34_tree = (object)adaptor.Create(char_literal34);
            		        				    		adaptor.AddChild(root_0, char_literal34_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_matrixvardec486);
            		        				    	el5 = int_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el5.Tree);
            		        				    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop8;
            		        		    }
            		        		} while (true);

            		        		loop8:
            		        			;	// Stops C# compiler whining that label 'loop8' has no statements


            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:96:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:96:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:96:4: el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		PushFollow(FOLLOW_double_literal_in_matrixvardec499);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:97:3: ( ',' el6= double_literal )*
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
            		        				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:97:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal35=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec506); 
            		        				    		char_literal35_tree = (object)adaptor.Create(char_literal35);
            		        				    		adaptor.AddChild(root_0, char_literal35_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_matrixvardec509);
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


            		        }
            		        break;

            		}

            		char_literal36=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec516); 
            			char_literal36_tree = (object)adaptor.Create(char_literal36);
            			adaptor.AddChild(root_0, char_literal36_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT37=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matrixvardec522); 
            		END_OF_STATEMENT37_tree = (object)adaptor.Create(END_OF_STATEMENT37);
            		adaptor.AddChild(root_0, END_OF_STATEMENT37_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:100:1: vectorvardec returns [VectorVariableDeclaration ret] : ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT ;
    public spinachParser.vectorvardec_return vectorvardec() // throws RecognitionException [1]
    {   
        spinachParser.vectorvardec_return retval = new spinachParser.vectorvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal38 = null;
        IToken char_literal39 = null;
        IToken VARTYPE40 = null;
        IToken char_literal41 = null;
        IToken char_literal42 = null;
        IToken char_literal43 = null;
        IToken ASSIGNMENT44 = null;
        IToken char_literal45 = null;
        IToken char_literal46 = null;
        IToken char_literal47 = null;
        IToken char_literal48 = null;
        IToken END_OF_STATEMENT49 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.variable_return el2 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal38_tree=null;
        object char_literal39_tree=null;
        object VARTYPE40_tree=null;
        object char_literal41_tree=null;
        object char_literal42_tree=null;
        object char_literal43_tree=null;
        object ASSIGNMENT44_tree=null;
        object char_literal45_tree=null;
        object char_literal46_tree=null;
        object char_literal47_tree=null;
        object char_literal48_tree=null;
        object END_OF_STATEMENT49_tree=null;


        	retval.ret = new VectorVariableDeclaration();
        	
        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:104:2: ( ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:104:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:104:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:104:4: 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']'
            	{
            		string_literal38=(IToken)Match(input,32,FOLLOW_32_in_vectorvardec540); 
            			string_literal38_tree = (object)adaptor.Create(string_literal38);
            			adaptor.AddChild(root_0, string_literal38_tree);

            		char_literal39=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorvardec542); 
            			char_literal39_tree = (object)adaptor.Create(char_literal39);
            			adaptor.AddChild(root_0, char_literal39_tree);

            		VARTYPE40=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorvardec544); 
            			VARTYPE40_tree = (object)adaptor.Create(VARTYPE40);
            			adaptor.AddChild(root_0, VARTYPE40_tree);

            		 retval.ret.setType(((VARTYPE40 != null) ? VARTYPE40.Text : null));
            		char_literal41=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec547); 
            			char_literal41_tree = (object)adaptor.Create(char_literal41);
            			adaptor.AddChild(root_0, char_literal41_tree);

            		char_literal42=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec549); 
            			char_literal42_tree = (object)adaptor.Create(char_literal42);
            			adaptor.AddChild(root_0, char_literal42_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorvardec552);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setRange(((el1 != null) ? el1.ret : null));
            		char_literal43=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec555); 
            			char_literal43_tree = (object)adaptor.Create(char_literal43);
            			adaptor.AddChild(root_0, char_literal43_tree);

            		PushFollow(FOLLOW_variable_in_vectorvardec561);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setText(((el2 != null) ? el2.ret : null));
            		ASSIGNMENT44=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_vectorvardec568); 
            			ASSIGNMENT44_tree = (object)adaptor.Create(ASSIGNMENT44);
            			adaptor.AddChild(root_0, ASSIGNMENT44_tree);

            		char_literal45=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec573); 
            			char_literal45_tree = (object)adaptor.Create(char_literal45);
            			adaptor.AddChild(root_0, char_literal45_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:6: ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) )
            		int alt13 = 2;
            		int LA13_0 = input.LA(1);

            		if ( (LA13_0 == INT_LITERAL) )
            		{
            		    alt13 = 1;
            		}
            		else if ( (LA13_0 == DOUBLE_LITERAL) )
            		{
            		    alt13 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d13s0 =
            		        new NoViableAltException("", 13, 0, input);

            		    throw nvae_d13s0;
            		}
            		switch (alt13) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:7: (el3= int_literal ( ',' el5= int_literal )* )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:7: (el3= int_literal ( ',' el5= int_literal )* )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:8: el3= int_literal ( ',' el5= int_literal )*
            		        	{
            		        		PushFollow(FOLLOW_int_literal_in_vectorvardec578);
            		        		el3 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el3.Tree);
            		        		retval.ret.addValue(((el3 != null) ? el3.ret : null));
            		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:57: ( ',' el5= int_literal )*
            		        		do 
            		        		{
            		        		    int alt11 = 2;
            		        		    int LA11_0 = input.LA(1);

            		        		    if ( (LA11_0 == 31) )
            		        		    {
            		        		        alt11 = 1;
            		        		    }


            		        		    switch (alt11) 
            		        			{
            		        				case 1 :
            		        				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:58: ',' el5= int_literal
            		        				    {
            		        				    	char_literal46=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec583); 
            		        				    		char_literal46_tree = (object)adaptor.Create(char_literal46);
            		        				    		adaptor.AddChild(root_0, char_literal46_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_vectorvardec586);
            		        				    	el5 = int_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el5.Tree);
            		        				    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop11;
            		        		    }
            		        		} while (true);

            		        		loop11:
            		        			;	// Stops C# compiler whining that label 'loop11' has no statements


            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:108:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:108:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:108:4: el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		PushFollow(FOLLOW_double_literal_in_vectorvardec599);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:109:3: ( ',' el6= double_literal )*
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
            		        				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:109:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal47=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec606); 
            		        				    		char_literal47_tree = (object)adaptor.Create(char_literal47);
            		        				    		adaptor.AddChild(root_0, char_literal47_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_vectorvardec609);
            		        				    	el6 = double_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el6.Tree);
            		        				    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop12;
            		        		    }
            		        		} while (true);

            		        		loop12:
            		        			;	// Stops C# compiler whining that label 'loop12' has no statements


            		        	}


            		        }
            		        break;

            		}

            		char_literal48=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec616); 
            			char_literal48_tree = (object)adaptor.Create(char_literal48);
            			adaptor.AddChild(root_0, char_literal48_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT49=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_vectorvardec622); 
            		END_OF_STATEMENT49_tree = (object)adaptor.Create(END_OF_STATEMENT49);
            		adaptor.AddChild(root_0, END_OF_STATEMENT49_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:112:1: matrixelem returns [MatrixElement ret] : (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' ) ;
    public spinachParser.matrixelem_return matrixelem() // throws RecognitionException [1]
    {   
        spinachParser.matrixelem_return retval = new spinachParser.matrixelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal50 = null;
        IToken char_literal51 = null;
        IToken char_literal52 = null;
        IToken char_literal53 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el4 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.variable_return el5 = null;


        object char_literal50_tree=null;
        object char_literal51_tree=null;
        object char_literal52_tree=null;
        object char_literal53_tree=null;


         retval.ret = new MatrixElement();
         
        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:116:2: ( (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:116:3: (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:116:3: (el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:116:4: el1= variable '[' (el2= int_literal | el4= variable ) ']' '[' (el3= int_literal | el5= variable ) ']'
            	{
            		PushFollow(FOLLOW_variable_in_matrixelem642);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal50=(IToken)Match(input,29,FOLLOW_29_in_matrixelem648); 
            			char_literal50_tree = (object)adaptor.Create(char_literal50);
            			adaptor.AddChild(root_0, char_literal50_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:117:6: (el2= int_literal | el4= variable )
            		int alt14 = 2;
            		int LA14_0 = input.LA(1);

            		if ( (LA14_0 == INT_LITERAL) )
            		{
            		    alt14 = 1;
            		}
            		else if ( (LA14_0 == VARIABLE) )
            		{
            		    alt14 = 2;
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:117:7: el2= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_matrixelem652);
            		        	el2 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el2.Tree);
            		        	retval.ret.setRow(((el2 != null) ? el2.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:117:53: el4= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_matrixelem657);
            		        	el4 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el4.Tree);
            		        	retval.ret.setRow(((el4 != null) ? el4.ret : null));

            		        }
            		        break;

            		}

            		char_literal51=(IToken)Match(input,30,FOLLOW_30_in_matrixelem660); 
            			char_literal51_tree = (object)adaptor.Create(char_literal51);
            			adaptor.AddChild(root_0, char_literal51_tree);

            		char_literal52=(IToken)Match(input,29,FOLLOW_29_in_matrixelem663); 
            			char_literal52_tree = (object)adaptor.Create(char_literal52);
            			adaptor.AddChild(root_0, char_literal52_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:118:5: (el3= int_literal | el5= variable )
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:118:6: el3= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_matrixelem667);
            		        	el3 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el3.Tree);
            		        	retval.ret.setColumn(((el3 != null) ? el3.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:118:55: el5= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_matrixelem672);
            		        	el5 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el5.Tree);
            		        	retval.ret.setColumn(((el5 != null) ? el5.ret : null));

            		        }
            		        break;

            		}

            		char_literal53=(IToken)Match(input,30,FOLLOW_30_in_matrixelem675); 
            			char_literal53_tree = (object)adaptor.Create(char_literal53);
            			adaptor.AddChild(root_0, char_literal53_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:120:1: vectorelem returns [VectorElement ret] : (el1= variable '[' (el2= int_literal | el3= variable ) ']' ) ;
    public spinachParser.vectorelem_return vectorelem() // throws RecognitionException [1]
    {   
        spinachParser.vectorelem_return retval = new spinachParser.vectorelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal54 = null;
        IToken char_literal55 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;


        object char_literal54_tree=null;
        object char_literal55_tree=null;


         retval.ret = new VectorElement();
         
        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:124:2: ( (el1= variable '[' (el2= int_literal | el3= variable ) ']' ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:124:3: (el1= variable '[' (el2= int_literal | el3= variable ) ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:124:3: (el1= variable '[' (el2= int_literal | el3= variable ) ']' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:124:4: el1= variable '[' (el2= int_literal | el3= variable ) ']'
            	{
            		PushFollow(FOLLOW_variable_in_vectorelem697);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal54=(IToken)Match(input,29,FOLLOW_29_in_vectorelem703); 
            			char_literal54_tree = (object)adaptor.Create(char_literal54);
            			adaptor.AddChild(root_0, char_literal54_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:125:6: (el2= int_literal | el3= variable )
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:125:7: el2= int_literal
            		        {
            		        	PushFollow(FOLLOW_int_literal_in_vectorelem707);
            		        	el2 = int_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el2.Tree);
            		        	retval.ret.setRange(((el2 != null) ? el2.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:125:56: el3= variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_vectorelem713);
            		        	el3 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, el3.Tree);
            		        	retval.ret.setRange(((el3 != null) ? el3.ret : null));

            		        }
            		        break;

            		}

            		char_literal55=(IToken)Match(input,30,FOLLOW_30_in_vectorelem716); 
            			char_literal55_tree = (object)adaptor.Create(char_literal55);
            			adaptor.AddChild(root_0, char_literal55_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:127:1: assignment returns [AssignmentOperationElement ret] : ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) ) ;
    public spinachParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        spinachParser.assignment_return retval = new spinachParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT58 = null;
        IToken END_OF_STATEMENT63 = null;
        spinachParser.vectorelem_return e12 = null;

        spinachParser.matrixelem_return e11 = null;

        spinachParser.variable_return variable56 = null;

        spinachParser.structassign_return structassign57 = null;

        spinachParser.subtractive_exp_return subtractive_exp59 = null;

        spinachParser.dotproduct_return dotproduct60 = null;

        spinachParser.matrixtranspose_return matrixtranspose61 = null;

        spinachParser.string_literal_return string_literal62 = null;

        spinachParser.functioncall_return functioncall64 = null;


        object ASSIGNMENT58_tree=null;
        object END_OF_STATEMENT63_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:131:3: ( ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:131:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:131:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:131:6: ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall )
            	{
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:131:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )
            		int alt17 = 4;
            		alt17 = dfa17.Predict(input);
            		switch (alt17) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:131:7: variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_assignment739);
            		        	variable56 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, variable56.Tree);
            		        	retval.ret.setLhs(((variable56 != null) ? variable56.ret : null)); 

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:132:7: structassign
            		        {
            		        	PushFollow(FOLLOW_structassign_in_assignment749);
            		        	structassign57 = structassign();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, structassign57.Tree);
            		        	retval.ret.setLhs(((structassign57 != null) ? structassign57.ret : null));

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:133:6: e12= vectorelem
            		        {
            		        	PushFollow(FOLLOW_vectorelem_in_assignment761);
            		        	e12 = vectorelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e12.Tree);
            		        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:134:7: e11= matrixelem
            		        {
            		        	PushFollow(FOLLOW_matrixelem_in_assignment774);
            		        	e11 = matrixelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e11.Tree);
            		        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		        }
            		        break;

            		}

            		ASSIGNMENT58=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment782); 
            			ASSIGNMENT58_tree = (object)adaptor.Create(ASSIGNMENT58);
            			adaptor.AddChild(root_0, ASSIGNMENT58_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:136:5: ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall )
            		int alt19 = 2;
            		int LA19_0 = input.LA(1);

            		if ( ((LA19_0 >= INT_LITERAL && LA19_0 <= DOUBLE_LITERAL) || LA19_0 == LEFTBRACE || LA19_0 == 27 || LA19_0 == 45) )
            		{
            		    alt19 = 1;
            		}
            		else if ( (LA19_0 == VARIABLE) )
            		{
            		    int LA19_2 = input.LA(2);

            		    if ( (LA19_2 == END_OF_STATEMENT || (LA19_2 >= DOT && LA19_2 <= MULTIPLY) || LA19_2 == 29 || LA19_2 == 33 || LA19_2 == 44) )
            		    {
            		        alt19 = 1;
            		    }
            		    else if ( (LA19_2 == LEFTBRACE) )
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
            		else 
            		{
            		    NoViableAltException nvae_d19s0 =
            		        new NoViableAltException("", 19, 0, input);

            		    throw nvae_d19s0;
            		}
            		switch (alt19) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:136:6: ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:136:6: ( subtractive_exp | dotproduct | matrixtranspose | string_literal )
            		        	int alt18 = 4;
            		        	switch ( input.LA(1) ) 
            		        	{
            		        	case INT_LITERAL:
            		        	case DOUBLE_LITERAL:
            		        	case LEFTBRACE:
            		        		{
            		        	    alt18 = 1;
            		        	    }
            		        	    break;
            		        	case VARIABLE:
            		        		{
            		        	    int LA18_2 = input.LA(2);

            		        	    if ( (LA18_2 == END_OF_STATEMENT || (LA18_2 >= DOT && LA18_2 <= MULTIPLY) || LA18_2 == 29 || LA18_2 == 33) )
            		        	    {
            		        	        alt18 = 1;
            		        	    }
            		        	    else if ( (LA18_2 == 44) )
            		        	    {
            		        	        alt18 = 2;
            		        	    }
            		        	    else 
            		        	    {
            		        	        NoViableAltException nvae_d18s2 =
            		        	            new NoViableAltException("", 18, 2, input);

            		        	        throw nvae_d18s2;
            		        	    }
            		        	    }
            		        	    break;
            		        	case 45:
            		        		{
            		        	    alt18 = 3;
            		        	    }
            		        	    break;
            		        	case 27:
            		        		{
            		        	    alt18 = 4;
            		        	    }
            		        	    break;
            		        		default:
            		        		    NoViableAltException nvae_d18s0 =
            		        		        new NoViableAltException("", 18, 0, input);

            		        		    throw nvae_d18s0;
            		        	}

            		        	switch (alt18) 
            		        	{
            		        	    case 1 :
            		        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:136:8: subtractive_exp
            		        	        {
            		        	        	PushFollow(FOLLOW_subtractive_exp_in_assignment792);
            		        	        	subtractive_exp59 = subtractive_exp();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, subtractive_exp59.Tree);
            		        	        	retval.ret.setRhs(((subtractive_exp59 != null) ? subtractive_exp59.ret : null));

            		        	        }
            		        	        break;
            		        	    case 2 :
            		        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:136:67: dotproduct
            		        	        {
            		        	        	PushFollow(FOLLOW_dotproduct_in_assignment796);
            		        	        	dotproduct60 = dotproduct();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, dotproduct60.Tree);
            		        	        	retval.ret.setRhs(((dotproduct60 != null) ? dotproduct60.ret : null));

            		        	        }
            		        	        break;
            		        	    case 3 :
            		        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:137:7: matrixtranspose
            		        	        {
            		        	        	PushFollow(FOLLOW_matrixtranspose_in_assignment805);
            		        	        	matrixtranspose61 = matrixtranspose();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, matrixtranspose61.Tree);
            		        	        	retval.ret.setRhs(((matrixtranspose61 != null) ? matrixtranspose61.ret : null));

            		        	        }
            		        	        break;
            		        	    case 4 :
            		        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:137:66: string_literal
            		        	        {
            		        	        	PushFollow(FOLLOW_string_literal_in_assignment809);
            		        	        	string_literal62 = string_literal();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, string_literal62.Tree);
            		        	        	retval.ret.setRhs(((string_literal62 != null) ? string_literal62.ret : null));

            		        	        }
            		        	        break;

            		        	}

            		        	END_OF_STATEMENT63=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment817); 
            		        		END_OF_STATEMENT63_tree = (object)adaptor.Create(END_OF_STATEMENT63);
            		        		adaptor.AddChild(root_0, END_OF_STATEMENT63_tree);


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:139:7: functioncall
            		        {
            		        	PushFollow(FOLLOW_functioncall_in_assignment825);
            		        	functioncall64 = functioncall();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, functioncall64.Tree);
            		        	retval.ret.setRhs(((functioncall64 != null) ? functioncall64.ret : null));

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:142:1: additive_expression returns [AdditiveElement ret] : ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) ;
    public spinachParser.additive_expression_return additive_expression() // throws RecognitionException [1]
    {   
        spinachParser.additive_expression_return retval = new spinachParser.additive_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal65 = null;
        spinachParser.multiplicative_expression_return e11 = null;

        spinachParser.additive_expression_return e12 = null;


        object char_literal65_tree=null;


        	retval.ret = new AdditiveElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:2: ( ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:4: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:4: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:5: (e11= multiplicative_expression ) ( '+' e12= additive_expression )*
            	{
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:5: (e11= multiplicative_expression )
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:6: e11= multiplicative_expression
            		{
            			PushFollow(FOLLOW_multiplicative_expression_in_additive_expression856);
            			e11 = multiplicative_expression();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, e11.Tree);
            			retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		}

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:69: ( '+' e12= additive_expression )*
            		do 
            		{
            		    int alt20 = 2;
            		    int LA20_0 = input.LA(1);

            		    if ( (LA20_0 == PLUS) )
            		    {
            		        alt20 = 1;
            		    }


            		    switch (alt20) 
            			{
            				case 1 :
            				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:70: '+' e12= additive_expression
            				    {
            				    	char_literal65=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_additive_expression861); 
            				    		char_literal65_tree = (object)adaptor.Create(char_literal65);
            				    		adaptor.AddChild(root_0, char_literal65_tree);

            				    	PushFollow(FOLLOW_additive_expression_in_additive_expression867);
            				    	e12 = additive_expression();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop20;
            		    }
            		} while (true);

            		loop20:
            			;	// Stops C# compiler whining that label 'loop20' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:149:1: multiplicative_expression returns [MultiplicationElement ret] : (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )* ;
    public spinachParser.multiplicative_expression_return multiplicative_expression() // throws RecognitionException [1]
    {   
        spinachParser.multiplicative_expression_return retval = new spinachParser.multiplicative_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal66 = null;
        spinachParser.var_int_or_double_literal_return e11 = null;

        spinachParser.bracket_exp_return e12 = null;

        spinachParser.matrixelem_return el3 = null;

        spinachParser.vectorelem_return el4 = null;

        spinachParser.multiplicative_expression_return el5 = null;


        object char_literal66_tree=null;


        	retval.ret = new MultiplicationElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:153:2: ( (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )* )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:153:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:153:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem )
            	int alt21 = 4;
            	alt21 = dfa21.Predict(input);
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:153:5: e11= var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplicative_expression895);
            	        	e11 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e11.Tree);
            	        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:154:7: e12= bracket_exp
            	        {
            	        	PushFollow(FOLLOW_bracket_exp_in_multiplicative_expression907);
            	        	e12 = bracket_exp();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e12.Tree);
            	        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:155:7: el3= matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_multiplicative_expression920);
            	        	el3 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el3.Tree);
            	        	retval.ret.setLhs(((el3 != null) ? el3.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:156:7: el4= vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_multiplicative_expression933);
            	        	el4 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	retval.ret.setLhs(((el4 != null) ? el4.ret : null));

            	        }
            	        break;

            	}

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:157:5: ( '*' el5= multiplicative_expression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == MULTIPLY) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:157:6: '*' el5= multiplicative_expression
            			    {
            			    	char_literal66=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplicative_expression942); 
            			    		char_literal66_tree = (object)adaptor.Create(char_literal66);
            			    		adaptor.AddChild(root_0, char_literal66_tree);

            			    	PushFollow(FOLLOW_multiplicative_expression_in_multiplicative_expression964);
            			    	el5 = multiplicative_expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, el5.Tree);
            			    	retval.ret.setRhs(el5.ret);

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:168:1: bracket_exp returns [BracketElement ret] : '(' subtractive_exp ')' ;
    public spinachParser.bracket_exp_return bracket_exp() // throws RecognitionException [1]
    {   
        spinachParser.bracket_exp_return retval = new spinachParser.bracket_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal67 = null;
        IToken char_literal69 = null;
        spinachParser.subtractive_exp_return subtractive_exp68 = null;


        object char_literal67_tree=null;
        object char_literal69_tree=null;


        	retval.ret = new BracketElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:172:1: ( '(' subtractive_exp ')' )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:172:3: '(' subtractive_exp ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal67=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_bracket_exp1010); 
            		char_literal67_tree = (object)adaptor.Create(char_literal67);
            		adaptor.AddChild(root_0, char_literal67_tree);

            	PushFollow(FOLLOW_subtractive_exp_in_bracket_exp1011);
            	subtractive_exp68 = subtractive_exp();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, subtractive_exp68.Tree);
            	retval.ret.setbracketexpression(((subtractive_exp68 != null) ? subtractive_exp68.ret : null));
            	char_literal69=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_bracket_exp1013); 
            		char_literal69_tree = (object)adaptor.Create(char_literal69);
            		adaptor.AddChild(root_0, char_literal69_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:178:1: subtractive_exp returns [SubtractionElement ret] : (e11= additive_expression ( '-' e12= subtractive_exp )* ) ;
    public spinachParser.subtractive_exp_return subtractive_exp() // throws RecognitionException [1]
    {   
        spinachParser.subtractive_exp_return retval = new spinachParser.subtractive_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal70 = null;
        spinachParser.additive_expression_return e11 = null;

        spinachParser.subtractive_exp_return e12 = null;


        object char_literal70_tree=null;


        	retval.ret = new SubtractionElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:182:1: ( (e11= additive_expression ( '-' e12= subtractive_exp )* ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:182:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:182:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:182:7: e11= additive_expression ( '-' e12= subtractive_exp )*
            	{
            		PushFollow(FOLLOW_additive_expression_in_subtractive_exp1042);
            		e11 = additive_expression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, e11.Tree);
            		retval.ret.setLhs(((e11 != null) ? e11.ret : null));
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:182:64: ( '-' e12= subtractive_exp )*
            		do 
            		{
            		    int alt23 = 2;
            		    int LA23_0 = input.LA(1);

            		    if ( (LA23_0 == 33) )
            		    {
            		        alt23 = 1;
            		    }


            		    switch (alt23) 
            			{
            				case 1 :
            				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:182:65: '-' e12= subtractive_exp
            				    {
            				    	char_literal70=(IToken)Match(input,33,FOLLOW_33_in_subtractive_exp1047); 
            				    		char_literal70_tree = (object)adaptor.Create(char_literal70);
            				    		adaptor.AddChild(root_0, char_literal70_tree);

            				    	PushFollow(FOLLOW_subtractive_exp_in_subtractive_exp1053);
            				    	e12 = subtractive_exp();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop23;
            		    }
            		} while (true);

            		loop23:
            			;	// Stops C# compiler whining that label 'loop23' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:186:1: structdec returns [StructDeclaration ret] : ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT ;
    public spinachParser.structdec_return structdec() // throws RecognitionException [1]
    {   
        spinachParser.structdec_return retval = new spinachParser.structdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal71 = null;
        IToken char_literal73 = null;
        IToken char_literal74 = null;
        IToken END_OF_STATEMENT75 = null;
        spinachParser.scalarvardec_return el1 = null;

        spinachParser.variable_return variable72 = null;


        object string_literal71_tree=null;
        object char_literal73_tree=null;
        object char_literal74_tree=null;
        object END_OF_STATEMENT75_tree=null;


        retval.ret = new StructDeclaration();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:190:1: ( ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:190:3: ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:190:3: ( 'struct' variable '{' (el1= scalarvardec )+ '}' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:190:4: 'struct' variable '{' (el1= scalarvardec )+ '}'
            	{
            		string_literal71=(IToken)Match(input,34,FOLLOW_34_in_structdec1083); 
            			string_literal71_tree = (object)adaptor.Create(string_literal71);
            			adaptor.AddChild(root_0, string_literal71_tree);

            		PushFollow(FOLLOW_variable_in_structdec1085);
            		variable72 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable72.Tree);
            		 retval.ret.setName(((variable72 != null) ? variable72.ret : null));
            		char_literal73=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_structdec1089); 
            			char_literal73_tree = (object)adaptor.Create(char_literal73);
            			adaptor.AddChild(root_0, char_literal73_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:191:5: (el1= scalarvardec )+
            		int cnt24 = 0;
            		do 
            		{
            		    int alt24 = 2;
            		    int LA24_0 = input.LA(1);

            		    if ( (LA24_0 == VARTYPE || LA24_0 == STRINGTYPE) )
            		    {
            		        alt24 = 1;
            		    }


            		    switch (alt24) 
            			{
            				case 1 :
            				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:191:6: el1= scalarvardec
            				    {
            				    	PushFollow(FOLLOW_scalarvardec_in_structdec1094);
            				    	el1 = scalarvardec();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	 retval.ret.setVarType(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    if ( cnt24 >= 1 ) goto loop24;
            			            EarlyExitException eee24 =
            			                new EarlyExitException(24, input);
            			            throw eee24;
            		    }
            		    cnt24++;
            		} while (true);

            		loop24:
            			;	// Stops C# compiler whining that label 'loop24' has no statements

            		char_literal74=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_structdec1100); 
            			char_literal74_tree = (object)adaptor.Create(char_literal74);
            			adaptor.AddChild(root_0, char_literal74_tree);


            	}

            	END_OF_STATEMENT75=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec1102); 
            		END_OF_STATEMENT75_tree = (object)adaptor.Create(END_OF_STATEMENT75);
            		adaptor.AddChild(root_0, END_OF_STATEMENT75_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:194:1: scalarvardec returns [ScalarVariableDeclaration ret] : ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT ;
    public spinachParser.scalarvardec_return scalarvardec() // throws RecognitionException [1]
    {   
        spinachParser.scalarvardec_return retval = new spinachParser.scalarvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE76 = null;
        IToken STRINGTYPE77 = null;
        IToken END_OF_STATEMENT79 = null;
        spinachParser.variable_return variable78 = null;


        object VARTYPE76_tree=null;
        object STRINGTYPE77_tree=null;
        object END_OF_STATEMENT79_tree=null;


        	retval.ret = new ScalarVariableDeclaration();
        	
        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:198:2: ( ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:198:3: ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:198:3: ( ( VARTYPE | STRINGTYPE ) variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:198:4: ( VARTYPE | STRINGTYPE ) variable
            	{
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:198:4: ( VARTYPE | STRINGTYPE )
            		int alt25 = 2;
            		int LA25_0 = input.LA(1);

            		if ( (LA25_0 == VARTYPE) )
            		{
            		    alt25 = 1;
            		}
            		else if ( (LA25_0 == STRINGTYPE) )
            		{
            		    alt25 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d25s0 =
            		        new NoViableAltException("", 25, 0, input);

            		    throw nvae_d25s0;
            		}
            		switch (alt25) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:198:5: VARTYPE
            		        {
            		        	VARTYPE76=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarvardec1123); 
            		        		VARTYPE76_tree = (object)adaptor.Create(VARTYPE76);
            		        		adaptor.AddChild(root_0, VARTYPE76_tree);

            		        	 retval.ret.setType(((VARTYPE76 != null) ? VARTYPE76.Text : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:199:4: STRINGTYPE
            		        {
            		        	STRINGTYPE77=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_scalarvardec1130); 
            		        		STRINGTYPE77_tree = (object)adaptor.Create(STRINGTYPE77);
            		        		adaptor.AddChild(root_0, STRINGTYPE77_tree);

            		        	 retval.ret.setType(((STRINGTYPE77 != null) ? STRINGTYPE77.Text : null));

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_variable_in_scalarvardec1137);
            		variable78 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable78.Tree);
            		 retval.ret.setVar(((variable78 != null) ? variable78.ret : null));

            	}

            	END_OF_STATEMENT79=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_scalarvardec1141); 
            		END_OF_STATEMENT79_tree = (object)adaptor.Create(END_OF_STATEMENT79);
            		adaptor.AddChild(root_0, END_OF_STATEMENT79_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:203:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
    public spinachParser.structobjdec_return structobjdec() // throws RecognitionException [1]
    {   
        spinachParser.structobjdec_return retval = new spinachParser.structobjdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT80 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object END_OF_STATEMENT80_tree=null;


        retval.ret = new StructObjectDeclaration();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:207:1: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:207:3: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:207:3: (el1= variable el2= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:207:4: el1= variable el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structobjdec1163);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		PushFollow(FOLLOW_variable_in_structobjdec1170);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	END_OF_STATEMENT80=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec1176); 
            		END_OF_STATEMENT80_tree = (object)adaptor.Create(END_OF_STATEMENT80);
            		adaptor.AddChild(root_0, END_OF_STATEMENT80_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:210:2: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
    public spinachParser.structassign_return structassign() // throws RecognitionException [1]
    {   
        spinachParser.structassign_return retval = new spinachParser.structassign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal81 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object char_literal81_tree=null;


        retval.ret = new StructAssignDeclaration();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:214:1: ( (el1= variable '.' el2= variable ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:214:2: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:214:2: (el1= variable '.' el2= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:214:3: el1= variable '.' el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structassign1195);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setObjName(((el1 != null) ? el1.ret : null));
            		char_literal81=(IToken)Match(input,DOT,FOLLOW_DOT_in_structassign1198); 
            			char_literal81_tree = (object)adaptor.Create(char_literal81);
            			adaptor.AddChild(root_0, char_literal81_tree);

            		PushFollow(FOLLOW_variable_in_structassign1201);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:217:1: deletionofvar returns [DeleteVariable ret] : ( 'delete' el1= variable ) END_OF_STATEMENT ;
    public spinachParser.deletionofvar_return deletionofvar() // throws RecognitionException [1]
    {   
        spinachParser.deletionofvar_return retval = new spinachParser.deletionofvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal82 = null;
        IToken END_OF_STATEMENT83 = null;
        spinachParser.variable_return el1 = null;


        object string_literal82_tree=null;
        object END_OF_STATEMENT83_tree=null;


        retval.ret = new DeleteVariable();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:221:1: ( ( 'delete' el1= variable ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:221:2: ( 'delete' el1= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:221:2: ( 'delete' el1= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:221:3: 'delete' el1= variable
            	{
            		string_literal82=(IToken)Match(input,35,FOLLOW_35_in_deletionofvar1222); 
            			string_literal82_tree = (object)adaptor.Create(string_literal82);
            			adaptor.AddChild(root_0, string_literal82_tree);

            		PushFollow(FOLLOW_variable_in_deletionofvar1226);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setVar(((el1 != null) ? el1.ret : null));

            	}

            	END_OF_STATEMENT83=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_deletionofvar1230); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:223:1: print returns [PrintOperationElement ret] : 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT ;
    public spinachParser.print_return print() // throws RecognitionException [1]
    {   
        spinachParser.print_return retval = new spinachParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal84 = null;
        IToken END_OF_STATEMENT89 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal85 = null;

        spinachParser.string_literal_return string_literal86 = null;

        spinachParser.vectorelem_return vectorelem87 = null;

        spinachParser.matrixelem_return matrixelem88 = null;


        object string_literal84_tree=null;
        object END_OF_STATEMENT89_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:227:3: ( 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:227:5: 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal84=(IToken)Match(input,36,FOLLOW_36_in_print1249); 
            		string_literal84_tree = (object)adaptor.Create(string_literal84);
            		adaptor.AddChild(root_0, string_literal84_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:227:13: ( var_int_or_double_literal | string_literal | vectorelem | matrixelem )
            	int alt26 = 4;
            	alt26 = dfa26.Predict(input);
            	switch (alt26) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:227:14: var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_print1252);
            	        	var_int_or_double_literal85 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_int_or_double_literal85.Tree);
            	        	retval.ret.setChildElement(((var_int_or_double_literal85 != null) ? var_int_or_double_literal85.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:228:6: string_literal
            	        {
            	        	PushFollow(FOLLOW_string_literal_in_print1261);
            	        	string_literal86 = string_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, string_literal86.Tree);
            	        	retval.ret.setChildElement(((string_literal86 != null) ? string_literal86.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:229:6: vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_print1269);
            	        	vectorelem87 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorelem87.Tree);
            	        	retval.ret.setChildElement(((vectorelem87 != null) ? vectorelem87.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:230:8: matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_print1280);
            	        	matrixelem88 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixelem88.Tree);
            	        	retval.ret.setChildElement(((matrixelem88 != null) ? matrixelem88.ret : null));

            	        }
            	        break;

            	}

            	END_OF_STATEMENT89=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print1294); 
            		END_OF_STATEMENT89_tree = (object)adaptor.Create(END_OF_STATEMENT89);
            		adaptor.AddChild(root_0, END_OF_STATEMENT89_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:1: parallelfor returns [ParallelForElement ret] : 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS ;
    public spinachParser.parallelfor_return parallelfor() // throws RecognitionException [1]
    {   
        spinachParser.parallelfor_return retval = new spinachParser.parallelfor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal90 = null;
        IToken LEFTBRACE91 = null;
        IToken POINT92 = null;
        IToken string_literal93 = null;
        IToken RIGHTBRACE94 = null;
        IToken LEFTPARANTHESIS95 = null;
        IToken string_literal96 = null;
        IToken END_OF_STATEMENT97 = null;
        IToken RIGHTPARANTHESIS98 = null;
        spinachParser.variable_return r11 = null;

        spinachParser.int_literal_return r12 = null;

        spinachParser.int_literal_return r13 = null;

        spinachParser.expr2_return e11 = null;


        object string_literal90_tree=null;
        object LEFTBRACE91_tree=null;
        object POINT92_tree=null;
        object string_literal93_tree=null;
        object RIGHTBRACE94_tree=null;
        object LEFTPARANTHESIS95_tree=null;
        object string_literal96_tree=null;
        object END_OF_STATEMENT97_tree=null;
        object RIGHTPARANTHESIS98_tree=null;


          retval.ret = new ParallelForElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:2: ( 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:4: 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal90=(IToken)Match(input,37,FOLLOW_37_in_parallelfor1316); 
            		string_literal90_tree = (object)adaptor.Create(string_literal90);
            		adaptor.AddChild(root_0, string_literal90_tree);

            	LEFTBRACE91=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_parallelfor1317); 
            		LEFTBRACE91_tree = (object)adaptor.Create(LEFTBRACE91);
            		adaptor.AddChild(root_0, LEFTBRACE91_tree);

            	PushFollow(FOLLOW_variable_in_parallelfor1323);
            	r11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGEVARIABLE = ((r11 != null) ? r11.ret : null);
            	POINT92=(IToken)Match(input,POINT,FOLLOW_POINT_in_parallelfor1326); 
            		POINT92_tree = (object)adaptor.Create(POINT92);
            		adaptor.AddChild(root_0, POINT92_tree);

            	PushFollow(FOLLOW_int_literal_in_parallelfor1332);
            	r12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r12.Tree);
            	retval.ret.STARTINGRANGE = ((r12 != null) ? r12.ret : null);
            	string_literal93=(IToken)Match(input,38,FOLLOW_38_in_parallelfor1335); 
            		string_literal93_tree = (object)adaptor.Create(string_literal93);
            		adaptor.AddChild(root_0, string_literal93_tree);

            	PushFollow(FOLLOW_int_literal_in_parallelfor1340);
            	r13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r13.Tree);
            	retval.ret.ENDINGRANGE = ((r13 != null) ? r13.ret : null);
            	RIGHTBRACE94=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_parallelfor1343); 
            		RIGHTBRACE94_tree = (object)adaptor.Create(RIGHTBRACE94);
            		adaptor.AddChild(root_0, RIGHTBRACE94_tree);

            	LEFTPARANTHESIS95=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_parallelfor1345); 
            		LEFTPARANTHESIS95_tree = (object)adaptor.Create(LEFTPARANTHESIS95);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS95_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:228: ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+
            	int cnt29 = 0;
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == VARIABLE || LA29_0 == 40 || LA29_0 == 42 || LA29_0 == 46) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:229: (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    {
            			    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:229: (e11= expr2 )+
            			    	int cnt27 = 0;
            			    	do 
            			    	{
            			    	    int alt27 = 2;
            			    	    switch ( input.LA(1) ) 
            			    	    {
            			    	    case VARIABLE:
            			    	    	{
            			    	        alt27 = 1;
            			    	        }
            			    	        break;
            			    	    case 40:
            			    	    	{
            			    	        alt27 = 1;
            			    	        }
            			    	        break;
            			    	    case 42:
            			    	    	{
            			    	        alt27 = 1;
            			    	        }
            			    	        break;
            			    	    case 46:
            			    	    	{
            			    	        alt27 = 1;
            			    	        }
            			    	        break;

            			    	    }

            			    	    switch (alt27) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:230: e11= expr2
            			    			    {
            			    			    	PushFollow(FOLLOW_expr2_in_parallelfor1352);
            			    			    	e11 = expr2();
            			    			    	state.followingStackPointer--;

            			    			    	adaptor.AddChild(root_0, e11.Tree);
            			    			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt27 >= 1 ) goto loop27;
            			    		            EarlyExitException eee27 =
            			    		                new EarlyExitException(27, input);
            			    		            throw eee27;
            			    	    }
            			    	    cnt27++;
            			    	} while (true);

            			    	loop27:
            			    		;	// Stops C# compiler whining that label 'loop27' has no statements

            			    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:272: ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    	int alt28 = 2;
            			    	int LA28_0 = input.LA(1);

            			    	if ( (LA28_0 == 39) )
            			    	{
            			    	    alt28 = 1;
            			    	}
            			    	else if ( (LA28_0 == VARIABLE || LA28_0 == RIGHTPARANTHESIS || LA28_0 == 40 || LA28_0 == 42 || LA28_0 == 46) )
            			    	{
            			    	    alt28 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d28s0 =
            			    	        new NoViableAltException("", 28, 0, input);

            			    	    throw nvae_d28s0;
            			    	}
            			    	switch (alt28) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:273: ( 'SYNC' END_OF_STATEMENT )
            			    	        {
            			    	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:273: ( 'SYNC' END_OF_STATEMENT )
            			    	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:274: 'SYNC' END_OF_STATEMENT
            			    	        	{
            			    	        		string_literal96=(IToken)Match(input,39,FOLLOW_39_in_parallelfor1358); 
            			    	        			string_literal96_tree = (object)adaptor.Create(string_literal96);
            			    	        			adaptor.AddChild(root_0, string_literal96_tree);

            			    	        		retval.ret.syncfunction();
            			    	        		END_OF_STATEMENT97=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_parallelfor1361); 
            			    	        			END_OF_STATEMENT97_tree = (object)adaptor.Create(END_OF_STATEMENT97);
            			    	        			adaptor.AddChild(root_0, END_OF_STATEMENT97_tree);


            			    	        	}


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:327: 
            			    	        {
            			    	        	retval.ret.syncfunction();

            			    	        }
            			    	        break;

            			    	}


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
            		;	// Stops C# compiler whining that label 'loop29' has no statements

            	RIGHTPARANTHESIS98=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_parallelfor1369); 
            		RIGHTPARANTHESIS98_tree = (object)adaptor.Create(RIGHTPARANTHESIS98);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS98_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:241:1: ifelse returns [IfStatementElement ret] : ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? ;
    public spinachParser.ifelse_return ifelse() // throws RecognitionException [1]
    {   
        spinachParser.ifelse_return retval = new spinachParser.ifelse_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal99 = null;
        IToken LEFTBRACE100 = null;
        IToken string_literal102 = null;
        IToken string_literal103 = null;
        IToken char_literal104 = null;
        IToken string_literal105 = null;
        IToken char_literal106 = null;
        IToken string_literal107 = null;
        IToken RIGHTBRACE108 = null;
        IToken LEFTPARANTHESIS109 = null;
        IToken RIGHTPARANTHESIS110 = null;
        IToken string_literal111 = null;
        IToken LEFTPARANTHESIS112 = null;
        IToken RIGHTPARANTHESIS113 = null;
        spinachParser.var_int_or_double_literal_return e13 = null;

        spinachParser.string_literal_return e14 = null;

        spinachParser.ifloop_return e11 = null;

        spinachParser.ifloop_return e12 = null;

        spinachParser.varorstruct_return varorstruct101 = null;


        object string_literal99_tree=null;
        object LEFTBRACE100_tree=null;
        object string_literal102_tree=null;
        object string_literal103_tree=null;
        object char_literal104_tree=null;
        object string_literal105_tree=null;
        object char_literal106_tree=null;
        object string_literal107_tree=null;
        object RIGHTBRACE108_tree=null;
        object LEFTPARANTHESIS109_tree=null;
        object RIGHTPARANTHESIS110_tree=null;
        object string_literal111_tree=null;
        object LEFTPARANTHESIS112_tree=null;
        object RIGHTPARANTHESIS113_tree=null;


           retval.ret = new IfStatementElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:245:1: ( ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:245:2: ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:245:2: ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:245:3: 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS
            	{
            		string_literal99=(IToken)Match(input,40,FOLLOW_40_in_ifelse1386); 
            			string_literal99_tree = (object)adaptor.Create(string_literal99);
            			adaptor.AddChild(root_0, string_literal99_tree);

            		LEFTBRACE100=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_ifelse1388); 
            			LEFTBRACE100_tree = (object)adaptor.Create(LEFTBRACE100);
            			adaptor.AddChild(root_0, LEFTBRACE100_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:245:18: ( varorstruct )
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:245:19: varorstruct
            		{
            			PushFollow(FOLLOW_varorstruct_in_ifelse1391);
            			varorstruct101 = varorstruct();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, varorstruct101.Tree);
            			retval.ret.setLhs(((varorstruct101 != null) ? varorstruct101.ret : null));

            		}

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:245:69: ( '==' | '!=' | '<' | '<=' | '>' | '>=' )
            		int alt30 = 6;
            		switch ( input.LA(1) ) 
            		{
            		case EQUALITYEXPRESSION:
            			{
            		    alt30 = 1;
            		    }
            		    break;
            		case NONEQUALITYEXPRESSION:
            			{
            		    alt30 = 2;
            		    }
            		    break;
            		case LESSTHANEXPRESSION:
            			{
            		    alt30 = 3;
            		    }
            		    break;
            		case LESSTHANEQUALTOEXPRESSION:
            			{
            		    alt30 = 4;
            		    }
            		    break;
            		case GREATERTHANEXPRESSION:
            			{
            		    alt30 = 5;
            		    }
            		    break;
            		case GREATERTHANEQUALTOEXPRESSION:
            			{
            		    alt30 = 6;
            		    }
            		    break;
            			default:
            			    NoViableAltException nvae_d30s0 =
            			        new NoViableAltException("", 30, 0, input);

            			    throw nvae_d30s0;
            		}

            		switch (alt30) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:246:7: '=='
            		        {
            		        	string_literal102=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_ifelse1402); 
            		        		string_literal102_tree = (object)adaptor.Create(string_literal102);
            		        		adaptor.AddChild(root_0, string_literal102_tree);

            		        	 retval.ret.OP = "eq"; 

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:247:7: '!='
            		        {
            		        	string_literal103=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_ifelse1412); 
            		        		string_literal103_tree = (object)adaptor.Create(string_literal103);
            		        		adaptor.AddChild(root_0, string_literal103_tree);

            		        	 retval.ret.OP = "ne"; 

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:248:7: '<'
            		        {
            		        	char_literal104=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_ifelse1422); 
            		        		char_literal104_tree = (object)adaptor.Create(char_literal104);
            		        		adaptor.AddChild(root_0, char_literal104_tree);

            		        	 retval.ret.OP = "lt"; 

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:249:7: '<='
            		        {
            		        	string_literal105=(IToken)Match(input,LESSTHANEQUALTOEXPRESSION,FOLLOW_LESSTHANEQUALTOEXPRESSION_in_ifelse1433); 
            		        		string_literal105_tree = (object)adaptor.Create(string_literal105);
            		        		adaptor.AddChild(root_0, string_literal105_tree);

            		        	 retval.ret.OP = "le"; 

            		        }
            		        break;
            		    case 5 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:7: '>'
            		        {
            		        	char_literal106=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_ifelse1443); 
            		        		char_literal106_tree = (object)adaptor.Create(char_literal106);
            		        		adaptor.AddChild(root_0, char_literal106_tree);

            		        	 retval.ret.OP = "gt"; 

            		        }
            		        break;
            		    case 6 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:251:7: '>='
            		        {
            		        	string_literal107=(IToken)Match(input,GREATERTHANEQUALTOEXPRESSION,FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_ifelse1454); 
            		        		string_literal107_tree = (object)adaptor.Create(string_literal107);
            		        		adaptor.AddChild(root_0, string_literal107_tree);

            		        	 retval.ret.OP = "ge"; 

            		        }
            		        break;

            		}

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:1: (e13= var_int_or_double_literal | e14= string_literal )
            		int alt31 = 2;
            		int LA31_0 = input.LA(1);

            		if ( ((LA31_0 >= VARIABLE && LA31_0 <= DOUBLE_LITERAL)) )
            		{
            		    alt31 = 1;
            		}
            		else if ( (LA31_0 == 27) )
            		{
            		    alt31 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d31s0 =
            		        new NoViableAltException("", 31, 0, input);

            		    throw nvae_d31s0;
            		}
            		switch (alt31) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:2: e13= var_int_or_double_literal
            		        {
            		        	PushFollow(FOLLOW_var_int_or_double_literal_in_ifelse1467);
            		        	e13 = var_int_or_double_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e13.Tree);
            		        	retval.ret.setRhs(((e13 != null) ? e13.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:64: e14= string_literal
            		        {
            		        	PushFollow(FOLLOW_string_literal_in_ifelse1474);
            		        	e14 = string_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e14.Tree);
            		        	retval.ret.setRhs(((e14 != null) ? e14.ret : null));

            		        }
            		        break;

            		}

            		RIGHTBRACE108=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_ifelse1478); 
            			RIGHTBRACE108_tree = (object)adaptor.Create(RIGHTBRACE108);
            			adaptor.AddChild(root_0, RIGHTBRACE108_tree);

            		LEFTPARANTHESIS109=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1480); 
            			LEFTPARANTHESIS109_tree = (object)adaptor.Create(LEFTPARANTHESIS109);
            			adaptor.AddChild(root_0, LEFTPARANTHESIS109_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:143: ( (e11= ifloop ) | )
            		int alt32 = 2;
            		int LA32_0 = input.LA(1);

            		if ( (LA32_0 == VARIABLE || LA32_0 == VARTYPE || LA32_0 == STRINGTYPE || LA32_0 == 28 || LA32_0 == 32 || (LA32_0 >= 35 && LA32_0 <= 36) || LA32_0 == 40 || LA32_0 == 42 || (LA32_0 >= 46 && LA32_0 <= 48) || (LA32_0 >= 52 && LA32_0 <= 56)) )
            		{
            		    alt32 = 1;
            		}
            		else if ( (LA32_0 == RIGHTPARANTHESIS) )
            		{
            		    alt32 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d32s0 =
            		        new NoViableAltException("", 32, 0, input);

            		    throw nvae_d32s0;
            		}
            		switch (alt32) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:144: (e11= ifloop )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:144: (e11= ifloop )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:145: e11= ifloop
            		        	{
            		        		PushFollow(FOLLOW_ifloop_in_ifelse1488);
            		        		e11 = ifloop();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, e11.Tree);
            		        		retval.ret.IFCODE = ((e11 != null) ? e11.ret : null);

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:190: 
            		        {
            		        }
            		        break;

            		}

            		RIGHTPARANTHESIS110=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1493); 
            			RIGHTPARANTHESIS110_tree = (object)adaptor.Create(RIGHTPARANTHESIS110);
            			adaptor.AddChild(root_0, RIGHTPARANTHESIS110_tree);


            	}

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:208: ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == 41) )
            	{
            	    alt34 = 1;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:209: 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS
            	        {
            	        	string_literal111=(IToken)Match(input,41,FOLLOW_41_in_ifelse1496); 
            	        		string_literal111_tree = (object)adaptor.Create(string_literal111);
            	        		adaptor.AddChild(root_0, string_literal111_tree);

            	        	LEFTPARANTHESIS112=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1499); 
            	        		LEFTPARANTHESIS112_tree = (object)adaptor.Create(LEFTPARANTHESIS112);
            	        		adaptor.AddChild(root_0, LEFTPARANTHESIS112_tree);

            	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:233: ( (e12= ifloop ) | )
            	        	int alt33 = 2;
            	        	int LA33_0 = input.LA(1);

            	        	if ( (LA33_0 == VARIABLE || LA33_0 == VARTYPE || LA33_0 == STRINGTYPE || LA33_0 == 28 || LA33_0 == 32 || (LA33_0 >= 35 && LA33_0 <= 36) || LA33_0 == 40 || LA33_0 == 42 || (LA33_0 >= 46 && LA33_0 <= 48) || (LA33_0 >= 52 && LA33_0 <= 56)) )
            	        	{
            	        	    alt33 = 1;
            	        	}
            	        	else if ( (LA33_0 == RIGHTPARANTHESIS) )
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
            	        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:234: (e12= ifloop )
            	        	        {
            	        	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:234: (e12= ifloop )
            	        	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:235: e12= ifloop
            	        	        	{
            	        	        		PushFollow(FOLLOW_ifloop_in_ifelse1508);
            	        	        		e12 = ifloop();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, e12.Tree);
            	        	        		retval.ret.ELSECODE = ((e12 != null) ? e12.ret : null);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:253:283: 
            	        	        {
            	        	        }
            	        	        break;

            	        	}

            	        	RIGHTPARANTHESIS113=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1514); 
            	        		RIGHTPARANTHESIS113_tree = (object)adaptor.Create(RIGHTPARANTHESIS113);
            	        		adaptor.AddChild(root_0, RIGHTPARANTHESIS113_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:255:1: ifloop returns [List<Element> ret] : ( expr1 | functionreturn )+ ;
    public spinachParser.ifloop_return ifloop() // throws RecognitionException [1]
    {   
        spinachParser.ifloop_return retval = new spinachParser.ifloop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr1114 = null;

        spinachParser.functionreturn_return functionreturn115 = null;




           retval.ret = new List<Element>();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:260:1: ( ( expr1 | functionreturn )+ )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:260:3: ( expr1 | functionreturn )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:260:3: ( expr1 | functionreturn )+
            	int cnt35 = 0;
            	do 
            	{
            	    int alt35 = 3;
            	    int LA35_0 = input.LA(1);

            	    if ( (LA35_0 == VARIABLE || LA35_0 == VARTYPE || LA35_0 == STRINGTYPE || LA35_0 == 28 || LA35_0 == 32 || (LA35_0 >= 35 && LA35_0 <= 36) || LA35_0 == 40 || LA35_0 == 42 || LA35_0 == 46 || LA35_0 == 48 || (LA35_0 >= 52 && LA35_0 <= 56)) )
            	    {
            	        alt35 = 1;
            	    }
            	    else if ( (LA35_0 == 47) )
            	    {
            	        alt35 = 2;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:260:4: expr1
            			    {
            			    	PushFollow(FOLLOW_expr1_in_ifloop1535);
            			    	expr1114 = expr1();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1114.Tree);
            			    	retval.ret.Add(((expr1114 != null) ? expr1114.ret : null));

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:260:39: functionreturn
            			    {
            			    	PushFollow(FOLLOW_functionreturn_in_ifloop1538);
            			    	functionreturn115 = functionreturn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, functionreturn115.Tree);
            			    	retval.ret.Add(((functionreturn115 != null) ? functionreturn115.ret : null));

            			    }
            			    break;

            			default:
            			    if ( cnt35 >= 1 ) goto loop35;
            		            EarlyExitException eee35 =
            		                new EarlyExitException(35, input);
            		            throw eee35;
            	    }
            	    cnt35++;
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:264:1: forstatement returns [ForStatementElement ret] : 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= expr2 )+ RIGHTPARANTHESIS ;
    public spinachParser.forstatement_return forstatement() // throws RecognitionException [1]
    {   
        spinachParser.forstatement_return retval = new spinachParser.forstatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal116 = null;
        IToken LEFTBRACE117 = null;
        IToken POINT118 = null;
        IToken string_literal119 = null;
        IToken RIGHTBRACE120 = null;
        IToken LEFTPARANTHESIS121 = null;
        IToken RIGHTPARANTHESIS122 = null;
        spinachParser.variable_return r11 = null;

        spinachParser.int_literal_return r12 = null;

        spinachParser.int_literal_return r13 = null;

        spinachParser.expr2_return e11 = null;


        object string_literal116_tree=null;
        object LEFTBRACE117_tree=null;
        object POINT118_tree=null;
        object string_literal119_tree=null;
        object RIGHTBRACE120_tree=null;
        object LEFTPARANTHESIS121_tree=null;
        object RIGHTPARANTHESIS122_tree=null;


           retval.ret = new ForStatementElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:267:2: ( 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= expr2 )+ RIGHTPARANTHESIS )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:267:3: 'for' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= expr2 )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal116=(IToken)Match(input,42,FOLLOW_42_in_forstatement1557); 
            		string_literal116_tree = (object)adaptor.Create(string_literal116);
            		adaptor.AddChild(root_0, string_literal116_tree);

            	LEFTBRACE117=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_forstatement1559); 
            		LEFTBRACE117_tree = (object)adaptor.Create(LEFTBRACE117);
            		adaptor.AddChild(root_0, LEFTBRACE117_tree);

            	PushFollow(FOLLOW_variable_in_forstatement1565);
            	r11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGEVARIABLE = ((r11 != null) ? r11.ret : null);
            	POINT118=(IToken)Match(input,POINT,FOLLOW_POINT_in_forstatement1568); 
            		POINT118_tree = (object)adaptor.Create(POINT118);
            		adaptor.AddChild(root_0, POINT118_tree);

            	PushFollow(FOLLOW_int_literal_in_forstatement1574);
            	r12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r12.Tree);
            	retval.ret.STARTINGRANGE = ((r12 != null) ? r12.ret : null);
            	string_literal119=(IToken)Match(input,38,FOLLOW_38_in_forstatement1577); 
            		string_literal119_tree = (object)adaptor.Create(string_literal119);
            		adaptor.AddChild(root_0, string_literal119_tree);

            	PushFollow(FOLLOW_int_literal_in_forstatement1582);
            	r13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r13.Tree);
            	retval.ret.ENDINGRANGE = ((r13 != null) ? r13.ret : null);
            	RIGHTBRACE120=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_forstatement1585); 
            		RIGHTBRACE120_tree = (object)adaptor.Create(RIGHTBRACE120);
            		adaptor.AddChild(root_0, RIGHTBRACE120_tree);

            	LEFTPARANTHESIS121=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_forstatement1587); 
            		LEFTPARANTHESIS121_tree = (object)adaptor.Create(LEFTPARANTHESIS121);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS121_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:267:219: (e11= expr2 )+
            	int cnt36 = 0;
            	do 
            	{
            	    int alt36 = 2;
            	    int LA36_0 = input.LA(1);

            	    if ( (LA36_0 == VARIABLE || LA36_0 == 40 || LA36_0 == 42 || LA36_0 == 46) )
            	    {
            	        alt36 = 1;
            	    }


            	    switch (alt36) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:267:220: e11= expr2
            			    {
            			    	PushFollow(FOLLOW_expr2_in_forstatement1592);
            			    	e11 = expr2();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e11.Tree);
            			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    }
            			    break;

            			default:
            			    if ( cnt36 >= 1 ) goto loop36;
            		            EarlyExitException eee36 =
            		                new EarlyExitException(36, input);
            		            throw eee36;
            	    }
            	    cnt36++;
            	} while (true);

            	loop36:
            		;	// Stops C# compiler whining that label 'loop36' has no statements

            	RIGHTPARANTHESIS122=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_forstatement1597); 
            		RIGHTPARANTHESIS122_tree = (object)adaptor.Create(RIGHTPARANTHESIS122);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS122_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:269:4: functioncall returns [FunctionCallElement ret] : variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT ;
    public spinachParser.functioncall_return functioncall() // throws RecognitionException [1]
    {   
        spinachParser.functioncall_return retval = new spinachParser.functioncall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal124 = null;
        IToken char_literal125 = null;
        IToken char_literal126 = null;
        IToken END_OF_STATEMENT127 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;

        spinachParser.string_literal_return e13 = null;

        spinachParser.var_int_or_double_literal_return el2 = null;

        spinachParser.variable_return variable123 = null;


        object char_literal124_tree=null;
        object char_literal125_tree=null;
        object char_literal126_tree=null;
        object END_OF_STATEMENT127_tree=null;

         retval.ret = new FunctionCallElement();
         
        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:272:3: ( variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:272:4: variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_functioncall1618);
            	variable123 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable123.Tree);
            	retval.ret.setfunctioncallname(((variable123 != null) ? variable123.ret : null));
            	char_literal124=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functioncall1623); 
            		char_literal124_tree = (object)adaptor.Create(char_literal124);
            		adaptor.AddChild(root_0, char_literal124_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:6: ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( ((LA40_0 >= VARIABLE && LA40_0 <= DOUBLE_LITERAL) || LA40_0 == 27) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:7: (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )*
            	        {
            	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:7: (el1= var_int_or_double_literal | e13= string_literal )
            	        	int alt37 = 2;
            	        	int LA37_0 = input.LA(1);

            	        	if ( ((LA37_0 >= VARIABLE && LA37_0 <= DOUBLE_LITERAL)) )
            	        	{
            	        	    alt37 = 1;
            	        	}
            	        	else if ( (LA37_0 == 27) )
            	        	{
            	        	    alt37 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    NoViableAltException nvae_d37s0 =
            	        	        new NoViableAltException("", 37, 0, input);

            	        	    throw nvae_d37s0;
            	        	}
            	        	switch (alt37) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:8: el1= var_int_or_double_literal
            	        	        {
            	        	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1628);
            	        	        	el1 = var_int_or_double_literal();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, el1.Tree);
            	        	        	retval.ret.setparameters(((el1 != null) ? el1.ret : null));

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:75: e13= string_literal
            	        	        {
            	        	        	PushFollow(FOLLOW_string_literal_in_functioncall1634);
            	        	        	e13 = string_literal();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, e13.Tree);
            	        	        	retval.ret.setparameters(((e13 != null) ? e13.ret : null));

            	        	        }
            	        	        break;

            	        	}

            	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:133: ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )*
            	        	do 
            	        	{
            	        	    int alt39 = 2;
            	        	    int LA39_0 = input.LA(1);

            	        	    if ( (LA39_0 == 31) )
            	        	    {
            	        	        alt39 = 1;
            	        	    }


            	        	    switch (alt39) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:134: ',' (el2= var_int_or_double_literal | e13= string_literal )
            	        			    {
            	        			    	char_literal125=(IToken)Match(input,31,FOLLOW_31_in_functioncall1639); 
            	        			    		char_literal125_tree = (object)adaptor.Create(char_literal125);
            	        			    		adaptor.AddChild(root_0, char_literal125_tree);

            	        			    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:138: (el2= var_int_or_double_literal | e13= string_literal )
            	        			    	int alt38 = 2;
            	        			    	int LA38_0 = input.LA(1);

            	        			    	if ( ((LA38_0 >= VARIABLE && LA38_0 <= DOUBLE_LITERAL)) )
            	        			    	{
            	        			    	    alt38 = 1;
            	        			    	}
            	        			    	else if ( (LA38_0 == 27) )
            	        			    	{
            	        			    	    alt38 = 2;
            	        			    	}
            	        			    	else 
            	        			    	{
            	        			    	    NoViableAltException nvae_d38s0 =
            	        			    	        new NoViableAltException("", 38, 0, input);

            	        			    	    throw nvae_d38s0;
            	        			    	}
            	        			    	switch (alt38) 
            	        			    	{
            	        			    	    case 1 :
            	        			    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:139: el2= var_int_or_double_literal
            	        			    	        {
            	        			    	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1644);
            	        			    	        	el2 = var_int_or_double_literal();
            	        			    	        	state.followingStackPointer--;

            	        			    	        	adaptor.AddChild(root_0, el2.Tree);
            	        			    	        	retval.ret.setparameters(((el2 != null) ? el2.ret : null));

            	        			    	        }
            	        			    	        break;
            	        			    	    case 2 :
            	        			    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:273:206: e13= string_literal
            	        			    	        {
            	        			    	        	PushFollow(FOLLOW_string_literal_in_functioncall1650);
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
            	        			    goto loop39;
            	        	    }
            	        	} while (true);

            	        	loop39:
            	        		;	// Stops C# compiler whining that label 'loop39' has no statements


            	        }
            	        break;

            	}

            	char_literal126=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functioncall1658); 
            		char_literal126_tree = (object)adaptor.Create(char_literal126);
            		adaptor.AddChild(root_0, char_literal126_tree);

            	END_OF_STATEMENT127=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functioncall1662); 
            		END_OF_STATEMENT127_tree = (object)adaptor.Create(END_OF_STATEMENT127);
            		adaptor.AddChild(root_0, END_OF_STATEMENT127_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:281:1: functiondefination returns [FunctionElement ret] : ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' );
    public spinachParser.functiondefination_return functiondefination() // throws RecognitionException [1]
    {   
        spinachParser.functiondefination_return retval = new spinachParser.functiondefination_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE128 = null;
        IToken char_literal130 = null;
        IToken char_literal131 = null;
        IToken char_literal132 = null;
        IToken char_literal133 = null;
        IToken char_literal145 = null;
        IToken string_literal146 = null;
        IToken char_literal148 = null;
        IToken char_literal149 = null;
        IToken char_literal150 = null;
        IToken char_literal151 = null;
        IToken char_literal163 = null;
        spinachParser.arguments_return e11 = null;

        spinachParser.arguments_return e12 = null;

        spinachParser.variable_return variable129 = null;

        spinachParser.assignment_return assignment134 = null;

        spinachParser.functioncall_return functioncall135 = null;

        spinachParser.scalarvardec_return scalarvardec136 = null;

        spinachParser.vectorvardec_return vectorvardec137 = null;

        spinachParser.matrixvardec_return matrixvardec138 = null;

        spinachParser.deletionofvar_return deletionofvar139 = null;

        spinachParser.print_return print140 = null;

        spinachParser.ifelse_return ifelse141 = null;

        spinachParser.functionreturn_return functionreturn142 = null;

        spinachParser.parallelfor_return parallelfor143 = null;

        spinachParser.forstatement_return forstatement144 = null;

        spinachParser.variable_return variable147 = null;

        spinachParser.assignment_return assignment152 = null;

        spinachParser.functioncall_return functioncall153 = null;

        spinachParser.scalarvardec_return scalarvardec154 = null;

        spinachParser.vectorvardec_return vectorvardec155 = null;

        spinachParser.matrixvardec_return matrixvardec156 = null;

        spinachParser.deletionofvar_return deletionofvar157 = null;

        spinachParser.print_return print158 = null;

        spinachParser.ifelse_return ifelse159 = null;

        spinachParser.functionreturn_return functionreturn160 = null;

        spinachParser.parallelfor_return parallelfor161 = null;

        spinachParser.forstatement_return forstatement162 = null;


        object VARTYPE128_tree=null;
        object char_literal130_tree=null;
        object char_literal131_tree=null;
        object char_literal132_tree=null;
        object char_literal133_tree=null;
        object char_literal145_tree=null;
        object string_literal146_tree=null;
        object char_literal148_tree=null;
        object char_literal149_tree=null;
        object char_literal150_tree=null;
        object char_literal151_tree=null;
        object char_literal163_tree=null;


        retval.ret = new FunctionElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:1: ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
            int alt49 = 2;
            int LA49_0 = input.LA(1);

            if ( (LA49_0 == VARTYPE) )
            {
                alt49 = 1;
            }
            else if ( (LA49_0 == 43) )
            {
                alt49 = 2;
            }
            else 
            {
                NoViableAltException nvae_d49s0 =
                    new NoViableAltException("", 49, 0, input);

                throw nvae_d49s0;
            }
            switch (alt49) 
            {
                case 1 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:4: VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}'
                    	{
                    		VARTYPE128=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_functiondefination1689); 
                    			VARTYPE128_tree = (object)adaptor.Create(VARTYPE128);
                    			adaptor.AddChild(root_0, VARTYPE128_tree);

                    		retval.ret.setreturntype(((VARTYPE128 != null) ? VARTYPE128.Text : null));
                    		PushFollow(FOLLOW_variable_in_functiondefination1694);
                    		variable129 = variable();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, variable129.Tree);
                    		retval.ret.setfunctionname(((variable129 != null) ? variable129.ret : null));
                    		char_literal130=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1700); 
                    			char_literal130_tree = (object)adaptor.Create(char_literal130);
                    			adaptor.AddChild(root_0, char_literal130_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:289:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:289:3: (e11= arguments ( ',' e12= arguments )* )?
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:289:3: (e11= arguments ( ',' e12= arguments )* )?
                    			int alt42 = 2;
                    			int LA42_0 = input.LA(1);

                    			if ( (LA42_0 == VARTYPE || LA42_0 == 28 || LA42_0 == 32) )
                    			{
                    			    alt42 = 1;
                    			}
                    			switch (alt42) 
                    			{
                    			    case 1 :
                    			        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:289:4: e11= arguments ( ',' e12= arguments )*
                    			        {
                    			        	PushFollow(FOLLOW_arguments_in_functiondefination1708);
                    			        	e11 = arguments();
                    			        	state.followingStackPointer--;

                    			        	adaptor.AddChild(root_0, e11.Tree);
                    			        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    			        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:289:54: ( ',' e12= arguments )*
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
                    			        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:289:55: ',' e12= arguments
                    			        			    {
                    			        			    	char_literal131=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1711); 
                    			        			    		char_literal131_tree = (object)adaptor.Create(char_literal131);
                    			        			    		adaptor.AddChild(root_0, char_literal131_tree);

                    			        			    	PushFollow(FOLLOW_arguments_in_functiondefination1716);
                    			        			    	e12 = arguments();
                    			        			    	state.followingStackPointer--;

                    			        			    	adaptor.AddChild(root_0, e12.Tree);
                    			        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

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


                    		}

                    		char_literal132=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1725); 
                    			char_literal132_tree = (object)adaptor.Create(char_literal132);
                    			adaptor.AddChild(root_0, char_literal132_tree);

                    		char_literal133=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1727); 
                    			char_literal133_tree = (object)adaptor.Create(char_literal133);
                    			adaptor.AddChild(root_0, char_literal133_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:291:5: ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )?
                    		int alt44 = 2;
                    		int LA44_0 = input.LA(1);

                    		if ( (LA44_0 == VARIABLE || LA44_0 == VARTYPE || LA44_0 == STRINGTYPE || LA44_0 == 28 || LA44_0 == 32 || (LA44_0 >= 35 && LA44_0 <= 37) || LA44_0 == 40 || LA44_0 == 42 || LA44_0 == 47) )
                    		{
                    		    alt44 = 1;
                    		}
                    		switch (alt44) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:291:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:291:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    		        	int cnt43 = 0;
                    		        	do 
                    		        	{
                    		        	    int alt43 = 12;
                    		        	    alt43 = dfa43.Predict(input);
                    		        	    switch (alt43) 
                    		        		{
                    		        			case 1 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:291:7: assignment
                    		        			    {
                    		        			    	PushFollow(FOLLOW_assignment_in_functiondefination1731);
                    		        			    	assignment134 = assignment();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, assignment134.Tree);
                    		        			    	retval.ret.setBody(((assignment134 != null) ? assignment134.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 2 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:291:56: functioncall
                    		        			    {
                    		        			    	PushFollow(FOLLOW_functioncall_in_functiondefination1734);
                    		        			    	functioncall135 = functioncall();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, functioncall135.Tree);
                    		        			    	retval.ret.setBody(((functioncall135 != null) ? functioncall135.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 3 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:291:110: scalarvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1738);
                    		        			    	scalarvardec136 = scalarvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, scalarvardec136.Tree);
                    		        			    	 retval.ret.setBody(((scalarvardec136 != null) ? scalarvardec136.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 4 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:292:5: vectorvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1746);
                    		        			    	vectorvardec137 = vectorvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, vectorvardec137.Tree);
                    		        			    	 retval.ret.setBody(((vectorvardec137 != null) ? vectorvardec137.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 5 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:293:5: matrixvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1754);
                    		        			    	matrixvardec138 = matrixvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, matrixvardec138.Tree);
                    		        			    	 retval.ret.setBody(((matrixvardec138 != null) ? matrixvardec138.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 6 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:294:5: deletionofvar
                    		        			    {
                    		        			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1762);
                    		        			    	deletionofvar139 = deletionofvar();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, deletionofvar139.Tree);
                    		        			    	 retval.ret.setBody(((deletionofvar139 != null) ? deletionofvar139.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 7 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:294:64: print
                    		        			    {
                    		        			    	PushFollow(FOLLOW_print_in_functiondefination1768);
                    		        			    	print140 = print();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, print140.Tree);
                    		        			    	 retval.ret.setBody(((print140 != null) ? print140.ret : null)); 

                    		        			    }
                    		        			    break;
                    		        			case 8 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:295:5: ifelse
                    		        			    {
                    		        			    	PushFollow(FOLLOW_ifelse_in_functiondefination1776);
                    		        			    	ifelse141 = ifelse();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, ifelse141.Tree);
                    		        			    	retval.ret.setBody(((ifelse141 != null) ? ifelse141.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 9 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:295:47: functionreturn
                    		        			    {
                    		        			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1780);
                    		        			    	functionreturn142 = functionreturn();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, functionreturn142.Tree);
                    		        			    	retval.ret.setBody(((functionreturn142 != null) ? functionreturn142.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 10 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:295:105: parallelfor
                    		        			    {
                    		        			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1784);
                    		        			    	parallelfor143 = parallelfor();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, parallelfor143.Tree);
                    		        			    	retval.ret.setBody(((parallelfor143 != null) ? parallelfor143.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 11 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:295:157: forstatement
                    		        			    {
                    		        			    	PushFollow(FOLLOW_forstatement_in_functiondefination1788);
                    		        			    	forstatement144 = forstatement();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, forstatement144.Tree);
                    		        			    	retval.ret.setBody(((forstatement144 != null) ? forstatement144.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    if ( cnt43 >= 1 ) goto loop43;
                    		        		            EarlyExitException eee43 =
                    		        		                new EarlyExitException(43, input);
                    		        		            throw eee43;
                    		        	    }
                    		        	    cnt43++;
                    		        	} while (true);

                    		        	loop43:
                    		        		;	// Stops C# compiler whining that label 'loop43' has no statements


                    		        }
                    		        break;

                    		}

                    		char_literal145=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1795); 
                    			char_literal145_tree = (object)adaptor.Create(char_literal145);
                    			adaptor.AddChild(root_0, char_literal145_tree);


                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:296:6: 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal146=(IToken)Match(input,43,FOLLOW_43_in_functiondefination1798); 
                    		string_literal146_tree = (object)adaptor.Create(string_literal146);
                    		adaptor.AddChild(root_0, string_literal146_tree);

                    	retval.ret.setreturntype("void");
                    	PushFollow(FOLLOW_variable_in_functiondefination1803);
                    	variable147 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable147.Tree);
                    	retval.ret.setfunctionname(((variable147 != null) ? variable147.ret : null));
                    	char_literal148=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1809); 
                    		char_literal148_tree = (object)adaptor.Create(char_literal148);
                    		adaptor.AddChild(root_0, char_literal148_tree);

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:299:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:299:3: (e11= arguments ( ',' e12= arguments )* )?
                    	{
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:299:3: (e11= arguments ( ',' e12= arguments )* )?
                    		int alt46 = 2;
                    		int LA46_0 = input.LA(1);

                    		if ( (LA46_0 == VARTYPE || LA46_0 == 28 || LA46_0 == 32) )
                    		{
                    		    alt46 = 1;
                    		}
                    		switch (alt46) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:299:4: e11= arguments ( ',' e12= arguments )*
                    		        {
                    		        	PushFollow(FOLLOW_arguments_in_functiondefination1818);
                    		        	e11 = arguments();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, e11.Tree);
                    		        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:299:55: ( ',' e12= arguments )*
                    		        	do 
                    		        	{
                    		        	    int alt45 = 2;
                    		        	    int LA45_0 = input.LA(1);

                    		        	    if ( (LA45_0 == 31) )
                    		        	    {
                    		        	        alt45 = 1;
                    		        	    }


                    		        	    switch (alt45) 
                    		        		{
                    		        			case 1 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:299:56: ',' e12= arguments
                    		        			    {
                    		        			    	char_literal149=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1821); 
                    		        			    		char_literal149_tree = (object)adaptor.Create(char_literal149);
                    		        			    		adaptor.AddChild(root_0, char_literal149_tree);

                    		        			    	PushFollow(FOLLOW_arguments_in_functiondefination1825);
                    		        			    	e12 = arguments();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, e12.Tree);
                    		        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    goto loop45;
                    		        	    }
                    		        	} while (true);

                    		        	loop45:
                    		        		;	// Stops C# compiler whining that label 'loop45' has no statements


                    		        }
                    		        break;

                    		}


                    	}

                    	char_literal150=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1834); 
                    		char_literal150_tree = (object)adaptor.Create(char_literal150);
                    		adaptor.AddChild(root_0, char_literal150_tree);

                    	char_literal151=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1836); 
                    		char_literal151_tree = (object)adaptor.Create(char_literal151);
                    		adaptor.AddChild(root_0, char_literal151_tree);

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:301:5: ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )?
                    	int alt48 = 2;
                    	int LA48_0 = input.LA(1);

                    	if ( (LA48_0 == VARIABLE || LA48_0 == VARTYPE || LA48_0 == STRINGTYPE || LA48_0 == 28 || LA48_0 == 32 || (LA48_0 >= 35 && LA48_0 <= 37) || LA48_0 == 40 || LA48_0 == 42 || LA48_0 == 47) )
                    	{
                    	    alt48 = 1;
                    	}
                    	switch (alt48) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:301:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    	        {
                    	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:301:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    	        	int cnt47 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt47 = 12;
                    	        	    alt47 = dfa47.Predict(input);
                    	        	    switch (alt47) 
                    	        		{
                    	        			case 1 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:301:7: assignment
                    	        			    {
                    	        			    	PushFollow(FOLLOW_assignment_in_functiondefination1840);
                    	        			    	assignment152 = assignment();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, assignment152.Tree);
                    	        			    	retval.ret.setBody(((assignment152 != null) ? assignment152.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 2 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:301:56: functioncall
                    	        			    {
                    	        			    	PushFollow(FOLLOW_functioncall_in_functiondefination1843);
                    	        			    	functioncall153 = functioncall();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, functioncall153.Tree);
                    	        			    	retval.ret.setBody(((functioncall153 != null) ? functioncall153.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 3 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:301:110: scalarvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1847);
                    	        			    	scalarvardec154 = scalarvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, scalarvardec154.Tree);
                    	        			    	 retval.ret.setBody(((scalarvardec154 != null) ? scalarvardec154.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 4 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:302:5: vectorvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1855);
                    	        			    	vectorvardec155 = vectorvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, vectorvardec155.Tree);
                    	        			    	 retval.ret.setBody(((vectorvardec155 != null) ? vectorvardec155.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 5 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:303:5: matrixvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1863);
                    	        			    	matrixvardec156 = matrixvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, matrixvardec156.Tree);
                    	        			    	 retval.ret.setBody(((matrixvardec156 != null) ? matrixvardec156.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 6 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:304:5: deletionofvar
                    	        			    {
                    	        			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1871);
                    	        			    	deletionofvar157 = deletionofvar();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, deletionofvar157.Tree);
                    	        			    	 retval.ret.setBody(((deletionofvar157 != null) ? deletionofvar157.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 7 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:304:64: print
                    	        			    {
                    	        			    	PushFollow(FOLLOW_print_in_functiondefination1877);
                    	        			    	print158 = print();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, print158.Tree);
                    	        			    	 retval.ret.setBody(((print158 != null) ? print158.ret : null)); 

                    	        			    }
                    	        			    break;
                    	        			case 8 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:305:5: ifelse
                    	        			    {
                    	        			    	PushFollow(FOLLOW_ifelse_in_functiondefination1885);
                    	        			    	ifelse159 = ifelse();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, ifelse159.Tree);
                    	        			    	retval.ret.setBody(((ifelse159 != null) ? ifelse159.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 9 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:305:47: functionreturn
                    	        			    {
                    	        			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1889);
                    	        			    	functionreturn160 = functionreturn();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, functionreturn160.Tree);
                    	        			    	retval.ret.setBody(((functionreturn160 != null) ? functionreturn160.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 10 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:305:105: parallelfor
                    	        			    {
                    	        			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1893);
                    	        			    	parallelfor161 = parallelfor();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, parallelfor161.Tree);
                    	        			    	retval.ret.setBody(((parallelfor161 != null) ? parallelfor161.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 11 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:305:157: forstatement
                    	        			    {
                    	        			    	PushFollow(FOLLOW_forstatement_in_functiondefination1897);
                    	        			    	forstatement162 = forstatement();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, forstatement162.Tree);
                    	        			    	retval.ret.setBody(((forstatement162 != null) ? forstatement162.ret : null));

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    if ( cnt47 >= 1 ) goto loop47;
                    	        		            EarlyExitException eee47 =
                    	        		                new EarlyExitException(47, input);
                    	        		            throw eee47;
                    	        	    }
                    	        	    cnt47++;
                    	        	} while (true);

                    	        	loop47:
                    	        		;	// Stops C# compiler whining that label 'loop47' has no statements


                    	        }
                    	        break;

                    	}

                    	char_literal163=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1904); 
                    		char_literal163_tree = (object)adaptor.Create(char_literal163);
                    		adaptor.AddChild(root_0, char_literal163_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:310:1: dotproduct returns [DotProductElement ret] : e11= variable 'DOT' e12= variable ;
    public spinachParser.dotproduct_return dotproduct() // throws RecognitionException [1]
    {   
        spinachParser.dotproduct_return retval = new spinachParser.dotproduct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal164 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.variable_return e12 = null;


        object string_literal164_tree=null;


        retval.ret = new DotProductElement ();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:314:1: (e11= variable 'DOT' e12= variable )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:314:3: e11= variable 'DOT' e12= variable
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_dotproduct1926);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLhs(((e11 != null) ? e11.ret : null)); 
            	string_literal164=(IToken)Match(input,44,FOLLOW_44_in_dotproduct1930); 
            		string_literal164_tree = (object)adaptor.Create(string_literal164);
            		adaptor.AddChild(root_0, string_literal164_tree);

            	PushFollow(FOLLOW_variable_in_dotproduct1936);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:316:1: matrixtranspose returns [MatrixTranspose ret] : 'T' LEFTBRACE variable ')' ;
    public spinachParser.matrixtranspose_return matrixtranspose() // throws RecognitionException [1]
    {   
        spinachParser.matrixtranspose_return retval = new spinachParser.matrixtranspose_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal165 = null;
        IToken LEFTBRACE166 = null;
        IToken char_literal168 = null;
        spinachParser.variable_return variable167 = null;


        object char_literal165_tree=null;
        object LEFTBRACE166_tree=null;
        object char_literal168_tree=null;


        retval.ret = new MatrixTranspose();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:321:1: ( 'T' LEFTBRACE variable ')' )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:321:3: 'T' LEFTBRACE variable ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal165=(IToken)Match(input,45,FOLLOW_45_in_matrixtranspose1955); 
            		char_literal165_tree = (object)adaptor.Create(char_literal165);
            		adaptor.AddChild(root_0, char_literal165_tree);

            	LEFTBRACE166=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_matrixtranspose1957); 
            		LEFTBRACE166_tree = (object)adaptor.Create(LEFTBRACE166);
            		adaptor.AddChild(root_0, LEFTBRACE166_tree);

            	PushFollow(FOLLOW_variable_in_matrixtranspose1959);
            	variable167 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable167.Tree);
            	retval.ret.setvariable(((variable167 != null) ? variable167.ret : null)); 
            	char_literal168=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_matrixtranspose1962); 
            		char_literal168_tree = (object)adaptor.Create(char_literal168);
            		adaptor.AddChild(root_0, char_literal168_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:324:1: matrixreference returns [MatrixReference ret] : 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.matrixreference_return matrixreference() // throws RecognitionException [1]
    {   
        spinachParser.matrixreference_return retval = new spinachParser.matrixreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal169 = null;
        IToken char_literal170 = null;
        IToken char_literal171 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal169_tree=null;
        object char_literal170_tree=null;
        object char_literal171_tree=null;

         retval.ret = new MatrixReference();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:327:1: ( 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:327:2: 'Matrix' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal169=(IToken)Match(input,28,FOLLOW_28_in_matrixreference1978); 
            		string_literal169_tree = (object)adaptor.Create(string_literal169);
            		adaptor.AddChild(root_0, string_literal169_tree);

            	char_literal170=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixreference1980); 
            		char_literal170_tree = (object)adaptor.Create(char_literal170);
            		adaptor.AddChild(root_0, char_literal170_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:327:15: (el1= VARTYPE '>' el2= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:327:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixreference1985); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal171=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixreference1987); 
            			char_literal171_tree = (object)adaptor.Create(char_literal171);
            			adaptor.AddChild(root_0, char_literal171_tree);

            		PushFollow(FOLLOW_variable_in_matrixreference1991);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:330:1: vectorreference returns [VectorReference ret] : 'Vector' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.vectorreference_return vectorreference() // throws RecognitionException [1]
    {   
        spinachParser.vectorreference_return retval = new spinachParser.vectorreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal172 = null;
        IToken char_literal173 = null;
        IToken char_literal174 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal172_tree=null;
        object char_literal173_tree=null;
        object char_literal174_tree=null;

         retval.ret = new VectorReference();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:333:1: ( 'Vector' '<' (el1= VARTYPE '>' el2= variable ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:333:2: 'Vector' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal172=(IToken)Match(input,32,FOLLOW_32_in_vectorreference2010); 
            		string_literal172_tree = (object)adaptor.Create(string_literal172);
            		adaptor.AddChild(root_0, string_literal172_tree);

            	char_literal173=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorreference2012); 
            		char_literal173_tree = (object)adaptor.Create(char_literal173);
            		adaptor.AddChild(root_0, char_literal173_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:333:15: (el1= VARTYPE '>' el2= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:333:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorreference2017); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal174=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2019); 
            			char_literal174_tree = (object)adaptor.Create(char_literal174);
            			adaptor.AddChild(root_0, char_literal174_tree);

            		PushFollow(FOLLOW_variable_in_vectorreference2023);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:335:1: arguments returns [Element ret] : ( scalarargument | matrixreference | vectorreference ) ;
    public spinachParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        spinachParser.arguments_return retval = new spinachParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.scalarargument_return scalarargument175 = null;

        spinachParser.matrixreference_return matrixreference176 = null;

        spinachParser.vectorreference_return vectorreference177 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:336:1: ( ( scalarargument | matrixreference | vectorreference ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:336:3: ( scalarargument | matrixreference | vectorreference )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:336:3: ( scalarargument | matrixreference | vectorreference )
            	int alt50 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARTYPE:
            		{
            	    alt50 = 1;
            	    }
            	    break;
            	case 28:
            		{
            	    alt50 = 2;
            	    }
            	    break;
            	case 32:
            		{
            	    alt50 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d50s0 =
            		        new NoViableAltException("", 50, 0, input);

            		    throw nvae_d50s0;
            	}

            	switch (alt50) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:336:4: scalarargument
            	        {
            	        	PushFollow(FOLLOW_scalarargument_in_arguments2039);
            	        	scalarargument175 = scalarargument();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, scalarargument175.Tree);
            	        	 retval.ret = ((scalarargument175 != null) ? scalarargument175.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:337:3: matrixreference
            	        {
            	        	PushFollow(FOLLOW_matrixreference_in_arguments2045);
            	        	matrixreference176 = matrixreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixreference176.Tree);
            	        	retval.ret = ((matrixreference176 != null) ? matrixreference176.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:338:3: vectorreference
            	        {
            	        	PushFollow(FOLLOW_vectorreference_in_arguments2051);
            	        	vectorreference177 = vectorreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorreference177.Tree);
            	        	retval.ret = ((vectorreference177 != null) ? vectorreference177.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:349:1: scalarargument returns [ScalarArgument ret] : ( (e11= VARTYPE ) e12= variable ) ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:351:2: ( ( (e11= VARTYPE ) e12= variable ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:352:1: ( (e11= VARTYPE ) e12= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:352:1: ( (e11= VARTYPE ) e12= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:352:2: (e11= VARTYPE ) e12= variable
            	{
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:352:2: (e11= VARTYPE )
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:352:3: e11= VARTYPE
            		{
            			e11=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarargument2083); 
            				e11_tree = (object)adaptor.Create(e11);
            				adaptor.AddChild(root_0, e11_tree);

            			retval.ret.settype(((e11 != null) ? e11.Text : null));

            		}

            		PushFollow(FOLLOW_variable_in_scalarargument2090);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:356:1: comment returns [CommentElement ret] : '//' ( var_int_or_double_literal )* ;
    public spinachParser.comment_return comment() // throws RecognitionException [1]
    {   
        spinachParser.comment_return retval = new spinachParser.comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal178 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal179 = null;


        object string_literal178_tree=null;


        retval.ret = new CommentElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:360:1: ( '//' ( var_int_or_double_literal )* )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:360:2: '//' ( var_int_or_double_literal )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal178=(IToken)Match(input,46,FOLLOW_46_in_comment2109); 
            		string_literal178_tree = (object)adaptor.Create(string_literal178);
            		adaptor.AddChild(root_0, string_literal178_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:360:6: ( var_int_or_double_literal )*
            	do 
            	{
            	    int alt51 = 2;
            	    int LA51_0 = input.LA(1);

            	    if ( (LA51_0 == VARIABLE) )
            	    {
            	        switch ( input.LA(2) ) 
            	        {
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
            	            alt51 = 1;
            	            }
            	            break;
            	        case VARIABLE:
            	        	{
            	            int LA51_4 = input.LA(3);

            	            if ( (LA51_4 == EOF || (LA51_4 >= VARIABLE && LA51_4 <= ASSIGNMENT) || (LA51_4 >= STRINGTYPE && LA51_4 <= LEFTBRACE) || LA51_4 == RIGHTPARANTHESIS || LA51_4 == DOT || (LA51_4 >= 28 && LA51_4 <= 29) || LA51_4 == 32 || (LA51_4 >= 34 && LA51_4 <= 37) || (LA51_4 >= 39 && LA51_4 <= 40) || (LA51_4 >= 42 && LA51_4 <= 43) || (LA51_4 >= 46 && LA51_4 <= 48) || (LA51_4 >= 52 && LA51_4 <= 56)) )
            	            {
            	                alt51 = 1;
            	            }


            	            }
            	            break;
            	        case DOT:
            	        	{
            	            int LA51_5 = input.LA(3);

            	            if ( (LA51_5 == VARIABLE) )
            	            {
            	                int LA51_6 = input.LA(4);

            	                if ( (LA51_6 == EOF || (LA51_6 >= VARIABLE && LA51_6 <= VARTYPE) || LA51_6 == STRINGTYPE || LA51_6 == RIGHTPARANTHESIS || LA51_6 == 28 || LA51_6 == 32 || (LA51_6 >= 34 && LA51_6 <= 37) || (LA51_6 >= 39 && LA51_6 <= 40) || (LA51_6 >= 42 && LA51_6 <= 43) || (LA51_6 >= 46 && LA51_6 <= 48) || (LA51_6 >= 52 && LA51_6 <= 56)) )
            	                {
            	                    alt51 = 1;
            	                }


            	            }


            	            }
            	            break;

            	        }

            	    }
            	    else if ( ((LA51_0 >= INT_LITERAL && LA51_0 <= DOUBLE_LITERAL)) )
            	    {
            	        alt51 = 1;
            	    }


            	    switch (alt51) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:360:6: var_int_or_double_literal
            			    {
            			    	PushFollow(FOLLOW_var_int_or_double_literal_in_comment2110);
            			    	var_int_or_double_literal179 = var_int_or_double_literal();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, var_int_or_double_literal179.Tree);

            			    }
            			    break;

            			default:
            			    goto loop51;
            	    }
            	} while (true);

            	loop51:
            		;	// Stops C# compiler whining that label 'loop51' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:364:1: functionreturn returns [ReturnElement ret] : 'return' ( var_int_or_double_literal ) END_OF_STATEMENT ;
    public spinachParser.functionreturn_return functionreturn() // throws RecognitionException [1]
    {   
        spinachParser.functionreturn_return retval = new spinachParser.functionreturn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal180 = null;
        IToken END_OF_STATEMENT182 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal181 = null;


        object string_literal180_tree=null;
        object END_OF_STATEMENT182_tree=null;


        retval.ret = new ReturnElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:368:1: ( 'return' ( var_int_or_double_literal ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:368:2: 'return' ( var_int_or_double_literal ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal180=(IToken)Match(input,47,FOLLOW_47_in_functionreturn2128); 
            		string_literal180_tree = (object)adaptor.Create(string_literal180);
            		adaptor.AddChild(root_0, string_literal180_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:368:11: ( var_int_or_double_literal )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:368:12: var_int_or_double_literal
            	{
            		PushFollow(FOLLOW_var_int_or_double_literal_in_functionreturn2131);
            		var_int_or_double_literal181 = var_int_or_double_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, var_int_or_double_literal181.Tree);
            		retval.ret.setreturnvariable(((var_int_or_double_literal181 != null) ? var_int_or_double_literal181.ret : null));

            	}

            	END_OF_STATEMENT182=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functionreturn2135); 
            		END_OF_STATEMENT182_tree = (object)adaptor.Create(END_OF_STATEMENT182);
            		adaptor.AddChild(root_0, END_OF_STATEMENT182_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:374:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );
    public spinachParser.plotfunctions_return plotfunctions() // throws RecognitionException [1]
    {   
        spinachParser.plotfunctions_return retval = new spinachParser.plotfunctions_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal183 = null;
        IToken char_literal184 = null;
        IToken char_literal185 = null;
        IToken char_literal186 = null;
        IToken char_literal187 = null;
        IToken string_literal188 = null;
        IToken string_literal189 = null;
        IToken string_literal190 = null;
        IToken char_literal191 = null;
        IToken char_literal192 = null;
        IToken END_OF_STATEMENT193 = null;
        IToken string_literal194 = null;
        IToken char_literal195 = null;
        IToken char_literal196 = null;
        IToken char_literal197 = null;
        IToken string_literal198 = null;
        IToken string_literal199 = null;
        IToken string_literal200 = null;
        IToken char_literal201 = null;
        IToken char_literal202 = null;
        IToken END_OF_STATEMENT203 = null;
        IToken string_literal204 = null;
        IToken char_literal205 = null;
        IToken char_literal206 = null;
        IToken END_OF_STATEMENT207 = null;
        IToken string_literal208 = null;
        IToken char_literal209 = null;
        IToken char_literal210 = null;
        IToken char_literal211 = null;
        IToken char_literal212 = null;
        IToken END_OF_STATEMENT213 = null;
        IToken string_literal214 = null;
        IToken char_literal215 = null;
        IToken char_literal216 = null;
        IToken char_literal217 = null;
        IToken END_OF_STATEMENT218 = null;
        IToken string_literal219 = null;
        IToken char_literal220 = null;
        IToken char_literal221 = null;
        IToken END_OF_STATEMENT222 = null;
        IToken string_literal223 = null;
        IToken char_literal224 = null;
        IToken char_literal225 = null;
        IToken char_literal226 = null;
        IToken char_literal227 = null;
        IToken END_OF_STATEMENT228 = null;
        IToken string_literal229 = null;
        IToken char_literal230 = null;
        IToken char_literal231 = null;
        IToken char_literal232 = null;
        IToken END_OF_STATEMENT233 = null;
        IToken string_literal234 = null;
        IToken char_literal235 = null;
        IToken char_literal236 = null;
        IToken END_OF_STATEMENT237 = null;
        IToken string_literal238 = null;
        IToken char_literal239 = null;
        IToken SCALEMODE240 = null;
        IToken char_literal241 = null;
        IToken END_OF_STATEMENT242 = null;
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


        object string_literal183_tree=null;
        object char_literal184_tree=null;
        object char_literal185_tree=null;
        object char_literal186_tree=null;
        object char_literal187_tree=null;
        object string_literal188_tree=null;
        object string_literal189_tree=null;
        object string_literal190_tree=null;
        object char_literal191_tree=null;
        object char_literal192_tree=null;
        object END_OF_STATEMENT193_tree=null;
        object string_literal194_tree=null;
        object char_literal195_tree=null;
        object char_literal196_tree=null;
        object char_literal197_tree=null;
        object string_literal198_tree=null;
        object string_literal199_tree=null;
        object string_literal200_tree=null;
        object char_literal201_tree=null;
        object char_literal202_tree=null;
        object END_OF_STATEMENT203_tree=null;
        object string_literal204_tree=null;
        object char_literal205_tree=null;
        object char_literal206_tree=null;
        object END_OF_STATEMENT207_tree=null;
        object string_literal208_tree=null;
        object char_literal209_tree=null;
        object char_literal210_tree=null;
        object char_literal211_tree=null;
        object char_literal212_tree=null;
        object END_OF_STATEMENT213_tree=null;
        object string_literal214_tree=null;
        object char_literal215_tree=null;
        object char_literal216_tree=null;
        object char_literal217_tree=null;
        object END_OF_STATEMENT218_tree=null;
        object string_literal219_tree=null;
        object char_literal220_tree=null;
        object char_literal221_tree=null;
        object END_OF_STATEMENT222_tree=null;
        object string_literal223_tree=null;
        object char_literal224_tree=null;
        object char_literal225_tree=null;
        object char_literal226_tree=null;
        object char_literal227_tree=null;
        object END_OF_STATEMENT228_tree=null;
        object string_literal229_tree=null;
        object char_literal230_tree=null;
        object char_literal231_tree=null;
        object char_literal232_tree=null;
        object END_OF_STATEMENT233_tree=null;
        object string_literal234_tree=null;
        object char_literal235_tree=null;
        object char_literal236_tree=null;
        object END_OF_STATEMENT237_tree=null;
        object string_literal238_tree=null;
        object char_literal239_tree=null;
        object SCALEMODE240_tree=null;
        object char_literal241_tree=null;
        object END_OF_STATEMENT242_tree=null;

         retval.ret = new PlotFunctionElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:377:1: ( ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) )
            int alt56 = 10;
            alt56 = dfa56.Predict(input);
            switch (alt56) 
            {
                case 1 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:377:3: ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:377:3: ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:377:4: 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal183=(IToken)Match(input,48,FOLLOW_48_in_plotfunctions2159); 
                    			string_literal183_tree = (object)adaptor.Create(string_literal183);
                    			adaptor.AddChild(root_0, string_literal183_tree);

                    		retval.ret.setPlotFunction("subPlot");
                    		char_literal184=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2162); 
                    			char_literal184_tree = (object)adaptor.Create(char_literal184);
                    			adaptor.AddChild(root_0, char_literal184_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:378:1: (el1= int_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:378:2: el1= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2169);
                    			el1 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el1.Tree);
                    			retval.ret.setPeno(((el1 != null) ? el1.ret : null));

                    		}

                    		char_literal185=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2174); 
                    			char_literal185_tree = (object)adaptor.Create(char_literal185);
                    			adaptor.AddChild(root_0, char_literal185_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:1: (vll1= variable )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:2: vll1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2181);
                    			vll1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll1.Tree);
                    			retval.ret.setData(((vll1 != null) ? vll1.ret : null));

                    		}

                    		char_literal186=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2186); 
                    			char_literal186_tree = (object)adaptor.Create(char_literal186);
                    			adaptor.AddChild(root_0, char_literal186_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:380:1: (vll2= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:380:2: vll2= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2193);
                    			vll2 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll2.Tree);
                    			retval.ret.setTitle(((vll2 != null) ? vll2.ret : null));

                    		}

                    		char_literal187=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2197); 
                    			char_literal187_tree = (object)adaptor.Create(char_literal187);
                    			adaptor.AddChild(root_0, char_literal187_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt53 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt53 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt53 = 2;
                    		    }
                    		    break;
                    		case 51:
                    			{
                    		    alt53 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d53s0 =
                    			        new NoViableAltException("", 53, 0, input);

                    			    throw nvae_d53s0;
                    		}

                    		switch (alt53) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:2: ( '1D' )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:2: ( '1D' )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:3: '1D'
                    		        	{
                    		        		string_literal188=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2201); 
                    		        			string_literal188_tree = (object)adaptor.Create(string_literal188);
                    		        			adaptor.AddChild(root_0, string_literal188_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:40: ( '2D' )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:40: ( '2D' )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:41: '2D'
                    		        	{
                    		        		string_literal189=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2206); 
                    		        			string_literal189_tree = (object)adaptor.Create(string_literal189);
                    		        			adaptor.AddChild(root_0, string_literal189_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal190=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2211); 
                    		        			string_literal190_tree = (object)adaptor.Create(string_literal190);
                    		        			adaptor.AddChild(root_0, string_literal190_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:114: ( ',' (el3= int_literal ) )?
                    		        		int alt52 = 2;
                    		        		int LA52_0 = input.LA(1);

                    		        		if ( (LA52_0 == 31) )
                    		        		{
                    		        		    alt52 = 1;
                    		        		}
                    		        		switch (alt52) 
                    		        		{
                    		        		    case 1 :
                    		        		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal191=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2214); 
                    		        		        		char_literal191_tree = (object)adaptor.Create(char_literal191);
                    		        		        		adaptor.AddChild(root_0, char_literal191_tree);

                    		        		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:118: (el3= int_literal )
                    		        		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2220);
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

                    		char_literal192=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2228); 
                    			char_literal192_tree = (object)adaptor.Create(char_literal192);
                    			adaptor.AddChild(root_0, char_literal192_tree);

                    		END_OF_STATEMENT193=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2229); 
                    			END_OF_STATEMENT193_tree = (object)adaptor.Create(END_OF_STATEMENT193);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT193_tree);


                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:383:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:383:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:383:4: 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal194=(IToken)Match(input,52,FOLLOW_52_in_plotfunctions2235); 
                    			string_literal194_tree = (object)adaptor.Create(string_literal194);
                    			adaptor.AddChild(root_0, string_literal194_tree);

                    		retval.ret.setPlotFunction("plot");
                    		char_literal195=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2238); 
                    			char_literal195_tree = (object)adaptor.Create(char_literal195);
                    			adaptor.AddChild(root_0, char_literal195_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:1: (vll3= variable )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:2: vll3= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2244);
                    			vll3 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll3.Tree);
                    			retval.ret.setData(((vll3 != null) ? vll3.ret : null));

                    		}

                    		char_literal196=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2249); 
                    			char_literal196_tree = (object)adaptor.Create(char_literal196);
                    			adaptor.AddChild(root_0, char_literal196_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:385:1: (vll4= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:385:2: vll4= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2255);
                    			vll4 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll4.Tree);
                    			retval.ret.setTitle(((vll4 != null) ? vll4.ret : null));

                    		}

                    		char_literal197=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2259); 
                    			char_literal197_tree = (object)adaptor.Create(char_literal197);
                    			adaptor.AddChild(root_0, char_literal197_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
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
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:2: ( '1D' )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:2: ( '1D' )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:3: '1D'
                    		        	{
                    		        		string_literal198=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2263); 
                    		        			string_literal198_tree = (object)adaptor.Create(string_literal198);
                    		        			adaptor.AddChild(root_0, string_literal198_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:40: ( '2D' )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:40: ( '2D' )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:41: '2D'
                    		        	{
                    		        		string_literal199=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2268); 
                    		        			string_literal199_tree = (object)adaptor.Create(string_literal199);
                    		        			adaptor.AddChild(root_0, string_literal199_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal200=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2273); 
                    		        			string_literal200_tree = (object)adaptor.Create(string_literal200);
                    		        			adaptor.AddChild(root_0, string_literal200_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:114: ( ',' (el3= int_literal ) )?
                    		        		int alt54 = 2;
                    		        		int LA54_0 = input.LA(1);

                    		        		if ( (LA54_0 == 31) )
                    		        		{
                    		        		    alt54 = 1;
                    		        		}
                    		        		switch (alt54) 
                    		        		{
                    		        		    case 1 :
                    		        		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal201=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2276); 
                    		        		        		char_literal201_tree = (object)adaptor.Create(char_literal201);
                    		        		        		adaptor.AddChild(root_0, char_literal201_tree);

                    		        		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:118: (el3= int_literal )
                    		        		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2282);
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

                    		char_literal202=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2290); 
                    			char_literal202_tree = (object)adaptor.Create(char_literal202);
                    			adaptor.AddChild(root_0, char_literal202_tree);

                    		END_OF_STATEMENT203=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2291); 
                    			END_OF_STATEMENT203_tree = (object)adaptor.Create(END_OF_STATEMENT203);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT203_tree);


                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:388:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:388:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:388:4: 'resetPlot' '(' ')' END_OF_STATEMENT
                    	{
                    		string_literal204=(IToken)Match(input,53,FOLLOW_53_in_plotfunctions2297); 
                    			string_literal204_tree = (object)adaptor.Create(string_literal204);
                    			adaptor.AddChild(root_0, string_literal204_tree);

                    		char_literal205=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2298); 
                    			char_literal205_tree = (object)adaptor.Create(char_literal205);
                    			adaptor.AddChild(root_0, char_literal205_tree);

                    		char_literal206=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2299); 
                    			char_literal206_tree = (object)adaptor.Create(char_literal206);
                    			adaptor.AddChild(root_0, char_literal206_tree);

                    		retval.ret.setPlotFunction("resetPlot");
                    		END_OF_STATEMENT207=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2301); 
                    			END_OF_STATEMENT207_tree = (object)adaptor.Create(END_OF_STATEMENT207);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT207_tree);


                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:389:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:389:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:389:4: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal208=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2307); 
                    			string_literal208_tree = (object)adaptor.Create(string_literal208);
                    			adaptor.AddChild(root_0, string_literal208_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal209=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2309); 
                    			char_literal209_tree = (object)adaptor.Create(char_literal209);
                    			adaptor.AddChild(root_0, char_literal209_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:390:1: (ell2= double_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:390:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2315);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal210=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2318); 
                    			char_literal210_tree = (object)adaptor.Create(char_literal210);
                    			adaptor.AddChild(root_0, char_literal210_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:391:1: ( (ell3= double_literal ) ',' )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:391:2: (ell3= double_literal ) ','
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:391:2: (ell3= double_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:391:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2324);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}

                    			char_literal211=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2327); 
                    				char_literal211_tree = (object)adaptor.Create(char_literal211);
                    				adaptor.AddChild(root_0, char_literal211_tree);


                    		}

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:392:1: ( (el4= double_literal ) )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:392:2: (el4= double_literal )
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:392:2: (el4= double_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:392:3: el4= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2334);
                    				el4 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, el4.Tree);
                    				retval.ret.setZFact(((el4 != null) ? el4.ret : null));

                    			}


                    		}

                    		char_literal212=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2339); 
                    			char_literal212_tree = (object)adaptor.Create(char_literal212);
                    			adaptor.AddChild(root_0, char_literal212_tree);

                    		END_OF_STATEMENT213=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2340); 
                    			END_OF_STATEMENT213_tree = (object)adaptor.Create(END_OF_STATEMENT213);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT213_tree);


                    	}


                    }
                    break;
                case 5 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:394:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:394:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:394:3: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal214=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2345); 
                    			string_literal214_tree = (object)adaptor.Create(string_literal214);
                    			adaptor.AddChild(root_0, string_literal214_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal215=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2347); 
                    			char_literal215_tree = (object)adaptor.Create(char_literal215);
                    			adaptor.AddChild(root_0, char_literal215_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:395:1: (ell2= double_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:395:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2353);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal216=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2356); 
                    			char_literal216_tree = (object)adaptor.Create(char_literal216);
                    			adaptor.AddChild(root_0, char_literal216_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:396:1: ( (ell3= double_literal ) )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:396:2: (ell3= double_literal )
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:396:2: (ell3= double_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:396:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2362);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}


                    		}

                    		char_literal217=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2367); 
                    			char_literal217_tree = (object)adaptor.Create(char_literal217);
                    			adaptor.AddChild(root_0, char_literal217_tree);

                    		END_OF_STATEMENT218=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2368); 
                    			END_OF_STATEMENT218_tree = (object)adaptor.Create(END_OF_STATEMENT218);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT218_tree);


                    	}


                    }
                    break;
                case 6 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:398:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:398:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:398:3: 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal219=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2373); 
                    			string_literal219_tree = (object)adaptor.Create(string_literal219);
                    			adaptor.AddChild(root_0, string_literal219_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal220=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2375); 
                    			char_literal220_tree = (object)adaptor.Create(char_literal220);
                    			adaptor.AddChild(root_0, char_literal220_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:399:1: (ell2= double_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:399:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2381);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal221=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2385); 
                    			char_literal221_tree = (object)adaptor.Create(char_literal221);
                    			adaptor.AddChild(root_0, char_literal221_tree);

                    		END_OF_STATEMENT222=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2386); 
                    			END_OF_STATEMENT222_tree = (object)adaptor.Create(END_OF_STATEMENT222);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT222_tree);


                    	}


                    }
                    break;
                case 7 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:401:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:401:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:401:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal223=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2392); 
                    			string_literal223_tree = (object)adaptor.Create(string_literal223);
                    			adaptor.AddChild(root_0, string_literal223_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal224=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2394); 
                    			char_literal224_tree = (object)adaptor.Create(char_literal224);
                    			adaptor.AddChild(root_0, char_literal224_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:402:1: (vl1= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:402:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2400);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal225=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2403); 
                    			char_literal225_tree = (object)adaptor.Create(char_literal225);
                    			adaptor.AddChild(root_0, char_literal225_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:403:1: ( (vl2= string_literal ) ',' )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:403:2: (vl2= string_literal ) ','
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:403:2: (vl2= string_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:403:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2410);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}

                    			char_literal226=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2413); 
                    				char_literal226_tree = (object)adaptor.Create(char_literal226);
                    				adaptor.AddChild(root_0, char_literal226_tree);


                    		}

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:404:1: ( (vl3= string_literal ) )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:404:2: (vl3= string_literal )
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:404:2: (vl3= string_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:404:3: vl3= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2421);
                    				vl3 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl3.Tree);
                    				retval.ret.setZTitle(((vl3 != null) ? vl3.ret : null));

                    			}


                    		}

                    		char_literal227=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2426); 
                    			char_literal227_tree = (object)adaptor.Create(char_literal227);
                    			adaptor.AddChild(root_0, char_literal227_tree);

                    		END_OF_STATEMENT228=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2427); 
                    			END_OF_STATEMENT228_tree = (object)adaptor.Create(END_OF_STATEMENT228);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT228_tree);


                    	}


                    }
                    break;
                case 8 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:406:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:406:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:406:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal229=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2433); 
                    			string_literal229_tree = (object)adaptor.Create(string_literal229);
                    			adaptor.AddChild(root_0, string_literal229_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal230=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2435); 
                    			char_literal230_tree = (object)adaptor.Create(char_literal230);
                    			adaptor.AddChild(root_0, char_literal230_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:407:1: (vl1= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:407:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2441);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal231=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2444); 
                    			char_literal231_tree = (object)adaptor.Create(char_literal231);
                    			adaptor.AddChild(root_0, char_literal231_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:408:1: ( (vl2= string_literal ) )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:408:2: (vl2= string_literal )
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:408:2: (vl2= string_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:408:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2451);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}


                    		}

                    		char_literal232=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2456); 
                    			char_literal232_tree = (object)adaptor.Create(char_literal232);
                    			adaptor.AddChild(root_0, char_literal232_tree);

                    		END_OF_STATEMENT233=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2457); 
                    			END_OF_STATEMENT233_tree = (object)adaptor.Create(END_OF_STATEMENT233);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT233_tree);


                    	}


                    }
                    break;
                case 9 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:410:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:410:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:410:3: 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal234=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2462); 
                    			string_literal234_tree = (object)adaptor.Create(string_literal234);
                    			adaptor.AddChild(root_0, string_literal234_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal235=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2464); 
                    			char_literal235_tree = (object)adaptor.Create(char_literal235);
                    			adaptor.AddChild(root_0, char_literal235_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:411:1: (vl1= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:411:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2470);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal236=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2474); 
                    			char_literal236_tree = (object)adaptor.Create(char_literal236);
                    			adaptor.AddChild(root_0, char_literal236_tree);

                    		END_OF_STATEMENT237=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2475); 
                    			END_OF_STATEMENT237_tree = (object)adaptor.Create(END_OF_STATEMENT237);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT237_tree);


                    	}


                    }
                    break;
                case 10 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:413:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:413:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:413:3: 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT
                    	{
                    		string_literal238=(IToken)Match(input,56,FOLLOW_56_in_plotfunctions2480); 
                    			string_literal238_tree = (object)adaptor.Create(string_literal238);
                    			adaptor.AddChild(root_0, string_literal238_tree);

                    		char_literal239=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2481); 
                    			char_literal239_tree = (object)adaptor.Create(char_literal239);
                    			adaptor.AddChild(root_0, char_literal239_tree);

                    		retval.ret.setPlotFunction("setScaleMode");
                    		SCALEMODE240=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_plotfunctions2484); 
                    			SCALEMODE240_tree = (object)adaptor.Create(SCALEMODE240);
                    			adaptor.AddChild(root_0, SCALEMODE240_tree);

                    		retval.ret.setScaleMode(SCALEMODE240.Text);
                    		char_literal241=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2488); 
                    			char_literal241_tree = (object)adaptor.Create(char_literal241);
                    			adaptor.AddChild(root_0, char_literal241_tree);

                    		END_OF_STATEMENT242=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2490); 
                    			END_OF_STATEMENT242_tree = (object)adaptor.Create(END_OF_STATEMENT242);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT242_tree);


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


   	protected DFA3 dfa3;
   	protected DFA17 dfa17;
   	protected DFA21 dfa21;
   	protected DFA26 dfa26;
   	protected DFA43 dfa43;
   	protected DFA47 dfa47;
   	protected DFA56 dfa56;
	private void InitializeCyclicDFAs()
	{
    	this.dfa3 = new DFA3(this);
    	this.dfa17 = new DFA17(this);
    	this.dfa21 = new DFA21(this);
    	this.dfa26 = new DFA26(this);
    	this.dfa43 = new DFA43(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa56 = new DFA56(this);







	}

    const string DFA3_eotS =
        "\x0a\uffff";
    const string DFA3_eofS =
        "\x0a\uffff";
    const string DFA3_minS =
        "\x01\x04\x01\x08\x08\uffff";
    const string DFA3_maxS =
        "\x01\x38\x01\x1d\x08\uffff";
    const string DFA3_acceptS =
        "\x02\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x07\x01"+
        "\x08\x01\x06";
    const string DFA3_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x01\x01\x02\uffff\x01\x07\x02\uffff\x01\x07\x11\uffff\x01"+
            "\x03\x03\uffff\x01\x08\x02\uffff\x01\x05\x01\x06\x03\uffff\x01"+
            "\x02\x01\uffff\x01\x02\x03\uffff\x01\x02\x01\uffff\x01\x04\x03"+
            "\uffff\x05\x04",
            "\x01\x02\x02\uffff\x01\x09\x05\uffff\x01\x02\x0b\uffff\x01"+
            "\x02",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
    static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
    static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
    static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
    static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
    static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
    static readonly short[][] DFA3_transition = DFA.UnpackEncodedStringArray(DFA3_transitionS);

    protected class DFA3 : DFA
    {
        public DFA3(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;

        }

        override public string Description
        {
            get { return "38:1: expr1 returns [Element ret] : ( expr2 | matrixvardec | plotfunctions | deletionofvar | print | functioncall | scalarvardec | vectorvardec );"; }
        }

    }

    const string DFA17_eotS =
        "\x0a\uffff";
    const string DFA17_eofS =
        "\x0a\uffff";
    const string DFA17_minS =
        "\x01\x04\x01\x08\x01\x04\x02\uffff\x02\x1e\x01\x08\x02\uffff";
    const string DFA17_maxS =
        "\x01\x04\x01\x1d\x01\x05\x02\uffff\x02\x1e\x01\x1d\x02\uffff";
    const string DFA17_acceptS =
        "\x03\uffff\x01\x02\x01\x01\x03\uffff\x01\x04\x01\x03";
    const string DFA17_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x01\x01",
            "\x01\x04\x08\uffff\x01\x03\x0b\uffff\x01\x02",
            "\x01\x06\x01\x05",
            "",
            "",
            "\x01\x07",
            "\x01\x07",
            "\x01\x09\x14\uffff\x01\x08",
            "",
            ""
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "131:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )"; }
        }

    }

    const string DFA21_eotS =
        "\x0a\uffff";
    const string DFA21_eofS =
        "\x0a\uffff";
    const string DFA21_minS =
        "\x01\x04\x01\uffff\x01\x09\x01\uffff\x01\x04\x02\x1e\x01\x09\x02"+
        "\uffff";
    const string DFA21_maxS =
        "\x01\x0b\x01\uffff\x01\x21\x01\uffff\x01\x05\x02\x1e\x01\x21\x02"+
        "\uffff";
    const string DFA21_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x04\uffff\x01\x03\x01\x04";
    const string DFA21_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA21_transitionS = {
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

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "153:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem )"; }
        }

    }

    const string DFA26_eotS =
        "\x0a\uffff";
    const string DFA26_eofS =
        "\x0a\uffff";
    const string DFA26_minS =
        "\x01\x04\x01\uffff\x01\x09\x01\uffff\x01\x04\x02\x1e\x01\x09\x02"+
        "\uffff";
    const string DFA26_maxS =
        "\x01\x1b\x01\uffff\x01\x1d\x01\uffff\x01\x05\x02\x1e\x01\x1d\x02"+
        "\uffff";
    const string DFA26_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x02\x04\uffff\x01\x04\x01\x03";
    const string DFA26_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA26_transitionS = {
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

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "227:13: ( var_int_or_double_literal | string_literal | vectorelem | matrixelem )"; }
        }

    }

    const string DFA43_eotS =
        "\x0e\uffff";
    const string DFA43_eofS =
        "\x0e\uffff";
    const string DFA43_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA43_maxS =
        "\x01\x2f\x01\uffff\x01\x1d\x0b\uffff";
    const string DFA43_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x01\x01\x02";
    const string DFA43_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA43_transitionS = {
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

    static readonly short[] DFA43_eot = DFA.UnpackEncodedString(DFA43_eotS);
    static readonly short[] DFA43_eof = DFA.UnpackEncodedString(DFA43_eofS);
    static readonly char[] DFA43_min = DFA.UnpackEncodedStringToUnsignedChars(DFA43_minS);
    static readonly char[] DFA43_max = DFA.UnpackEncodedStringToUnsignedChars(DFA43_maxS);
    static readonly short[] DFA43_accept = DFA.UnpackEncodedString(DFA43_acceptS);
    static readonly short[] DFA43_special = DFA.UnpackEncodedString(DFA43_specialS);
    static readonly short[][] DFA43_transition = DFA.UnpackEncodedStringArray(DFA43_transitionS);

    protected class DFA43 : DFA
    {
        public DFA43(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 43;
            this.eot = DFA43_eot;
            this.eof = DFA43_eof;
            this.min = DFA43_min;
            this.max = DFA43_max;
            this.accept = DFA43_accept;
            this.special = DFA43_special;
            this.transition = DFA43_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 291:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA47_eotS =
        "\x0e\uffff";
    const string DFA47_eofS =
        "\x0e\uffff";
    const string DFA47_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA47_maxS =
        "\x01\x2f\x01\uffff\x01\x1d\x0b\uffff";
    const string DFA47_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x02\x01\x01";
    const string DFA47_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA47_transitionS = {
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

    static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
    static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
    static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
    static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
    static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
    static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
    static readonly short[][] DFA47_transition = DFA.UnpackEncodedStringArray(DFA47_transitionS);

    protected class DFA47 : DFA
    {
        public DFA47(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 47;
            this.eot = DFA47_eot;
            this.eof = DFA47_eof;
            this.min = DFA47_min;
            this.max = DFA47_max;
            this.accept = DFA47_accept;
            this.special = DFA47_special;
            this.transition = DFA47_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 301:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA56_eotS =
        "\x21\uffff";
    const string DFA56_eofS =
        "\x21\uffff";
    const string DFA56_minS =
        "\x01\x30\x03\uffff\x02\x0b\x01\uffff\x01\x06\x01\x1b\x01\x0d\x01"+
        "\x04\x01\x06\x01\uffff\x03\x04\x02\x0d\x01\x04\x01\uffff\x01\x1b"+
        "\x02\uffff\x05\x04\x01\x0d\x01\x04\x02\uffff\x01\x04";
    const string DFA56_maxS =
        "\x01\x38\x03\uffff\x02\x0b\x01\uffff\x01\x06\x01\x1b\x01\x1f\x01"+
        "\x1b\x01\x06\x01\uffff\x03\x1b\x02\x1f\x01\x04\x01\uffff\x01\x1b"+
        "\x02\uffff\x05\x1b\x01\x1f\x01\x04\x02\uffff\x01\x1b";
    const string DFA56_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x02\uffff\x01\x0a\x05\uffff"+
        "\x01\x06\x06\uffff\x01\x09\x01\uffff\x01\x05\x01\x04\x07\uffff\x01"+
        "\x07\x01\x08\x01\uffff";
    const string DFA56_specialS =
        "\x21\uffff}>";
    static readonly string[] DFA56_transitionS = {
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
            "\x01\x13\x11\uffff\x01\x14",
            "\x01\x15\x11\uffff\x01\x16",
            "\x01\x17",
            "",
            "\x01\x18",
            "",
            "",
            "\x01\x0f\x01\x0d\x01\x0e\x14\uffff\x01\x10",
            "\x01\x1b\x01\x19\x01\x1a\x14\uffff\x01\x1c",
            "\x01\x1b\x01\x19\x01\x1a\x14\uffff\x01\x1c",
            "\x01\x1b\x01\x19\x01\x1a\x14\uffff\x01\x1c",
            "\x01\x1b\x01\x19\x01\x1a\x0a\uffff\x01\x1d\x09\uffff\x01\x1c",
            "\x01\x1f\x11\uffff\x01\x1e",
            "\x01\x20",
            "",
            "",
            "\x01\x1b\x01\x19\x01\x1a\x14\uffff\x01\x1c"
    };

    static readonly short[] DFA56_eot = DFA.UnpackEncodedString(DFA56_eotS);
    static readonly short[] DFA56_eof = DFA.UnpackEncodedString(DFA56_eofS);
    static readonly char[] DFA56_min = DFA.UnpackEncodedStringToUnsignedChars(DFA56_minS);
    static readonly char[] DFA56_max = DFA.UnpackEncodedStringToUnsignedChars(DFA56_maxS);
    static readonly short[] DFA56_accept = DFA.UnpackEncodedString(DFA56_acceptS);
    static readonly short[] DFA56_special = DFA.UnpackEncodedString(DFA56_specialS);
    static readonly short[][] DFA56_transition = DFA.UnpackEncodedStringArray(DFA56_transitionS);

    protected class DFA56 : DFA
    {
        public DFA56(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 56;
            this.eot = DFA56_eot;
            this.eof = DFA56_eof;
            this.min = DFA56_min;
            this.max = DFA56_max;
            this.accept = DFA56_accept;
            this.special = DFA56_special;
            this.transition = DFA56_transition;

        }

        override public string Description
        {
            get { return "374:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program69 = new BitSet(new ulong[]{0x01F14D3D10000492UL});
    public static readonly BitSet FOLLOW_expr1_in_expr96 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallelfor_in_expr100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functiondefination_in_expr126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr2_in_expr1143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_expr1152 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_plotfunctions_in_expr1162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_expr1171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr1182 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_expr1192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_expr1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_expr1211 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expr2231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifelse_in_expr2241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forstatement_in_expr2251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_expr2260 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_int_or_double_literal279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_double_literal_in_var_int_or_double_literal289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varorstruct_in_var_int_or_double_literal297 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_varorstruct312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structassign_in_varorstruct315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal358 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_double_literal380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_string_literal400 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_string_literal404 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_27_in_string_literal409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixvardec429 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixvardec431 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixvardec433 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec436 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec438 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec441 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec444 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec447 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec451 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec454 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixvardec462 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matrixvardec469 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec473 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec478 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec483 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec486 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec499 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec506 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec509 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec516 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matrixvardec522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorvardec540 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorvardec542 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorvardec544 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec547 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec549 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec552 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec555 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorvardec561 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_vectorvardec568 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec573 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec578 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec583 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec586 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec599 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec606 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec609 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec616 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_vectorvardec622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem642 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem648 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem652 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem657 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem660 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem663 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem667 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem672 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem675 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem697 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorelem703 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorelem707 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem713 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorelem716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment739 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment749 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_vectorelem_in_assignment761 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_matrixelem_in_assignment774 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment782 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_assignment792 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_dotproduct_in_assignment796 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixtranspose_in_assignment805 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_assignment809 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_assignment825 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_additive_expression856 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additive_expression861 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_additive_expression_in_additive_expression867 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplicative_expression895 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_bracket_exp_in_multiplicative_expression907 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_matrixelem_in_multiplicative_expression920 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_vectorelem_in_multiplicative_expression933 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplicative_expression942 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_multiplicative_expression964 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_bracket_exp1010 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_bracket_exp1011 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_bracket_exp1013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expression_in_subtractive_exp1042 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_33_in_subtractive_exp1047 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_subtractive_exp1053 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_34_in_structdec1083 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structdec1085 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_structdec1089 = new BitSet(new ulong[]{0x0000000000000480UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_structdec1094 = new BitSet(new ulong[]{0x0000000000008480UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_structdec1100 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec1102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarvardec1123 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_scalarvardec1130 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarvardec1137 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_scalarvardec1141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1163 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1170 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec1176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1195 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_DOT_in_structassign1198 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_deletionofvar1222 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_deletionofvar1226 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_deletionofvar1230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_print1249 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_print1252 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_print1261 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_vectorelem_in_print1269 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixelem_in_print1280 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print1294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parallelfor1316 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_parallelfor1317 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_parallelfor1323 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_POINT_in_parallelfor1326 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallelfor1332 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_parallelfor1335 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallelfor1340 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_parallelfor1343 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_parallelfor1345 = new BitSet(new ulong[]{0x0000450000000010UL});
    public static readonly BitSet FOLLOW_expr2_in_parallelfor1352 = new BitSet(new ulong[]{0x0000458000008010UL});
    public static readonly BitSet FOLLOW_39_in_parallelfor1358 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_parallelfor1361 = new BitSet(new ulong[]{0x0000450000008010UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_parallelfor1369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_ifelse1386 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_ifelse1388 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_varorstruct_in_ifelse1391 = new BitSet(new ulong[]{0x0000000007E00000UL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_ifelse1402 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_ifelse1412 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_ifelse1422 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_LESSTHANEQUALTOEXPRESSION_in_ifelse1433 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_ifelse1443 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_ifelse1454 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_ifelse1467 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_ifelse1474 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_ifelse1478 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1480 = new BitSet(new ulong[]{0x01F1C51910008490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1488 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1493 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_ifelse1496 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1499 = new BitSet(new ulong[]{0x01F1C51910008490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1508 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr1_in_ifloop1535 = new BitSet(new ulong[]{0x01F1C51910000492UL});
    public static readonly BitSet FOLLOW_functionreturn_in_ifloop1538 = new BitSet(new ulong[]{0x01F1C51910000492UL});
    public static readonly BitSet FOLLOW_42_in_forstatement1557 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_forstatement1559 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_forstatement1565 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_POINT_in_forstatement1568 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_forstatement1574 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_forstatement1577 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_forstatement1582 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_forstatement1585 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_forstatement1587 = new BitSet(new ulong[]{0x0000450000000010UL});
    public static readonly BitSet FOLLOW_expr2_in_forstatement1592 = new BitSet(new ulong[]{0x0000450000008010UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_forstatement1597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_functioncall1618 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functioncall1623 = new BitSet(new ulong[]{0x0000200008002870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1628 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_functioncall1634 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functioncall1639 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1644 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_functioncall1650 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functioncall1658 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functioncall1662 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_functiondefination1689 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1694 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1700 = new BitSet(new ulong[]{0x0000000110002080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1708 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1711 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1716 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1725 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1727 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1731 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1734 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1738 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1746 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1754 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1762 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1768 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1776 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1780 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1784 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1788 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_functiondefination1798 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1803 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1809 = new BitSet(new ulong[]{0x0000000110002080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1818 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1821 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1825 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1834 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1836 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1840 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1843 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1847 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1855 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1863 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1871 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1877 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1885 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1889 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1893 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1897 = new BitSet(new ulong[]{0x01F1C53910008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1904 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct1926 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_dotproduct1930 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct1936 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_matrixtranspose1955 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_matrixtranspose1957 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixtranspose1959 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_matrixtranspose1962 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixreference1978 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixreference1980 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixreference1985 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixreference1987 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixreference1991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorreference2010 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorreference2012 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorreference2017 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2019 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorreference2023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarargument_in_arguments2039 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixreference_in_arguments2045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorreference_in_arguments2051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarargument2083 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarargument2090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_comment2109 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_comment2110 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_47_in_functionreturn2128 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functionreturn2131 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functionreturn2135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_plotfunctions2159 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2162 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2169 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2174 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2181 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2186 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2193 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2197 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2201 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2206 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2211 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2214 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2220 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2228 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_plotfunctions2235 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2238 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2244 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2249 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2255 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2259 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2263 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2268 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2273 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2276 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2282 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2290 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_plotfunctions2297 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2298 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2299 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2307 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2309 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2315 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2318 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2324 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2327 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2334 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2339 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2345 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2347 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2353 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2356 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2362 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2367 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2373 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2375 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2381 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2385 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2386 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2392 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2394 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2400 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2403 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2410 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2413 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2421 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2426 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2427 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2433 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2435 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2441 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2444 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2451 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2456 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2462 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2464 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2470 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2474 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_plotfunctions2480 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2481 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_plotfunctions2484 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2488 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2490 = new BitSet(new ulong[]{0x0000000000000002UL});

}
