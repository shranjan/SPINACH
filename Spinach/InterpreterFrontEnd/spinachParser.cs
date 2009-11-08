// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 spinach.g 2009-11-07 22:37:18


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
		"LEFTPARANTHESIS", 
		"RIGHTPARANTHESIS", 
		"LEFTBRACE", 
		"POINT", 
		"RIGHTBRACE", 
		"EQUALITYEXPRESSION", 
		"NONEQUALITYEXPRESSION", 
		"LESSTHANEXPRESSION", 
		"GREATERTHANEXPRESSION", 
		"LESSTHANEQUALTOEXPRESSION", 
		"GREATERTHANEQUALTOEXPRESSION", 
		"SCALEMODE", 
		"DOT", 
		"PLUS", 
		"MULTIPLY", 
		"WHITESPACE", 
		"'\"'", 
		"'//'", 
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
		"'SYNC'", 
		"'to'", 
		"'if'", 
		"'else'", 
		"'for'", 
		"'void'", 
		"'DOT'", 
		"'T'", 
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
    public const int POINT = 14;
    public const int EQUALITYEXPRESSION = 16;
    public const int DOUBLE_LITERAL = 6;
    public const int EOF = -1;
    public const int NONEQUALITYEXPRESSION = 17;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int LEFTBRACE = 13;
    public const int T__53 = 53;
    public const int LESSTHANEQUALTOEXPRESSION = 20;
    public const int T__54 = 54;
    public const int MULTIPLY = 25;
    public const int PLUS = 24;
    public const int RIGHTBRACE = 15;
    public const int DOT = 23;
    public const int LESSTHANEXPRESSION = 18;
    public const int T__50 = 50;
    public const int END_OF_STATEMENT = 9;
    public const int RIGHTPARANTHESIS = 12;
    public const int GREATERTHANEQUALTOEXPRESSION = 21;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int SCALEMODE = 22;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int INT_LITERAL = 5;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int WHITESPACE = 26;
    public const int GREATERTHANEXPRESSION = 19;
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
    public const int LEFTPARANTHESIS = 11;
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
		get { return "spinach.g"; }
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
    // spinach.g:19:1: program returns [List<Element> ret] : ( expr )+ ;
    public spinachParser.program_return program() // throws RecognitionException [1]
    {   
        spinachParser.program_return retval = new spinachParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // spinach.g:23:3: ( ( expr )+ )
            // spinach.g:23:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:23:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || LA1_0 == VARTYPE || LA1_0 == STRINGTYPE || (LA1_0 >= 28 && LA1_0 <= 29) || LA1_0 == 33 || (LA1_0 >= 35 && LA1_0 <= 38) || LA1_0 == 41 || (LA1_0 >= 43 && LA1_0 <= 44) || LA1_0 == 48 || (LA1_0 >= 52 && LA1_0 <= 56)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // spinach.g:23:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program64);
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
    // spinach.g:27:1: expr returns [Element ret] : ( expr1 | structdec | functiondefination );
    public spinachParser.expr_return expr() // throws RecognitionException [1]
    {   
        spinachParser.expr_return retval = new spinachParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr12 = null;

        spinachParser.structdec_return structdec3 = null;

        spinachParser.functiondefination_return functiondefination4 = null;



        try 
    	{
            // spinach.g:28:3: ( expr1 | structdec | functiondefination )
            int alt2 = 3;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            case STRINGTYPE:
            case 28:
            case 29:
            case 33:
            case 36:
            case 37:
            case 38:
            case 41:
            case 43:
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
                    int LA2_5 = input.LA(3);

                    if ( (LA2_5 == END_OF_STATEMENT) )
                    {
                        alt2 = 1;
                    }
                    else if ( (LA2_5 == LEFTBRACE) )
                    {
                        alt2 = 3;
                    }
                    else 
                    {
                        NoViableAltException nvae_d2s5 =
                            new NoViableAltException("", 2, 5, input);

                        throw nvae_d2s5;
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
            case 35:
            	{
                alt2 = 2;
                }
                break;
            case 44:
            	{
                alt2 = 3;
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
                    // spinach.g:28:4: expr1
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr1_in_expr90);
                    	expr12 = expr1();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr12.Tree);
                    	retval.ret = ((expr12 != null) ? expr12.ret : null);

                    }
                    break;
                case 2 :
                    // spinach.g:28:37: structdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structdec_in_expr94);
                    	structdec3 = structdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structdec3.Tree);
                    	retval.ret = ((structdec3 != null) ? structdec3.ret : null);

                    }
                    break;
                case 3 :
                    // spinach.g:29:8: functiondefination
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functiondefination_in_expr110);
                    	functiondefination4 = functiondefination();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functiondefination4.Tree);
                    	retval.ret = ((functiondefination4 != null) ? functiondefination4.ret : null);

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
    // spinach.g:32:1: expr1 returns [Element ret] : ( matrixvardec | structobjdec | plotfunctions | parallelfor | expr2 );
    public spinachParser.expr1_return expr1() // throws RecognitionException [1]
    {   
        spinachParser.expr1_return retval = new spinachParser.expr1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.matrixvardec_return matrixvardec5 = null;

        spinachParser.structobjdec_return structobjdec6 = null;

        spinachParser.plotfunctions_return plotfunctions7 = null;

        spinachParser.parallelfor_return parallelfor8 = null;

        spinachParser.expr2_return expr29 = null;



        try 
    	{
            // spinach.g:33:1: ( matrixvardec | structobjdec | plotfunctions | parallelfor | expr2 )
            int alt3 = 5;
            switch ( input.LA(1) ) 
            {
            case 29:
            	{
                alt3 = 1;
                }
                break;
            case VARIABLE:
            	{
                int LA3_2 = input.LA(2);

                if ( (LA3_2 == ASSIGNMENT || LA3_2 == LEFTBRACE || LA3_2 == DOT || LA3_2 == 30) )
                {
                    alt3 = 5;
                }
                else if ( (LA3_2 == VARIABLE) )
                {
                    alt3 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d3s2 =
                        new NoViableAltException("", 3, 2, input);

                    throw nvae_d3s2;
                }
                }
                break;
            case 48:
            case 52:
            case 53:
            case 54:
            case 55:
            case 56:
            	{
                alt3 = 3;
                }
                break;
            case 38:
            	{
                alt3 = 4;
                }
                break;
            case VARTYPE:
            case STRINGTYPE:
            case 28:
            case 33:
            case 36:
            case 37:
            case 41:
            case 43:
            	{
                alt3 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // spinach.g:33:3: matrixvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixvardec_in_expr1124);
                    	matrixvardec5 = matrixvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matrixvardec5.Tree);
                    	 retval.ret = ((matrixvardec5 != null) ? matrixvardec5.ret : null);

                    }
                    break;
                case 2 :
                    // spinach.g:34:5: structobjdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structobjdec_in_expr1133);
                    	structobjdec6 = structobjdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structobjdec6.Tree);
                    	 retval.ret = ((structobjdec6 != null) ? structobjdec6.ret : null);

                    }
                    break;
                case 3 :
                    // spinach.g:35:5: plotfunctions
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_plotfunctions_in_expr1141);
                    	plotfunctions7 = plotfunctions();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, plotfunctions7.Tree);
                    	retval.ret = ((plotfunctions7 != null) ? plotfunctions7.ret : null);

                    }
                    break;
                case 4 :
                    // spinach.g:36:5: parallelfor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallelfor_in_expr1148);
                    	parallelfor8 = parallelfor();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, parallelfor8.Tree);
                    	retval.ret = ((parallelfor8 != null) ? parallelfor8.ret : null);

                    }
                    break;
                case 5 :
                    // spinach.g:37:5: expr2
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr2_in_expr1156);
                    	expr29 = expr2();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr29.Tree);
                    	retval.ret = ((expr29 != null) ? expr29.ret : null);

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
    // spinach.g:40:1: expr2 returns [Element ret] : (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment ) ;
    public spinachParser.expr2_return expr2() // throws RecognitionException [1]
    {   
        spinachParser.expr2_return retval = new spinachParser.expr2_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.assignment_return el1 = null;

        spinachParser.scalarvardec_return el2 = null;

        spinachParser.vectorvardec_return el3 = null;

        spinachParser.deletionofvar_return el4 = null;

        spinachParser.print_return el5 = null;

        spinachParser.ifelse_return el6 = null;

        spinachParser.functioncall_return el7 = null;

        spinachParser.forstatement_return el8 = null;

        spinachParser.comment_return el9 = null;



        try 
    	{
            // spinach.g:40:29: ( (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment ) )
            // spinach.g:41:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:41:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )
            	int alt4 = 9;
            	alt4 = dfa4.Predict(input);
            	switch (alt4) 
            	{
            	    case 1 :
            	        // spinach.g:41:5: el1= assignment
            	        {
            	        	PushFollow(FOLLOW_assignment_in_expr2176);
            	        	el1 = assignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret = ((el1 != null) ? el1.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:42:5: el2= scalarvardec
            	        {
            	        	PushFollow(FOLLOW_scalarvardec_in_expr2186);
            	        	el2 = scalarvardec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el2.Tree);
            	        	 retval.ret = ((el2 != null) ? el2.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:43:5: el3= vectorvardec
            	        {
            	        	PushFollow(FOLLOW_vectorvardec_in_expr2196);
            	        	el3 = vectorvardec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el3.Tree);
            	        	 retval.ret = ((el3 != null) ? el3.ret : null);

            	        }
            	        break;
            	    case 4 :
            	        // spinach.g:44:5: el4= deletionofvar
            	        {
            	        	PushFollow(FOLLOW_deletionofvar_in_expr2207);
            	        	el4 = deletionofvar();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	 retval.ret = ((el4 != null) ? el4.ret : null);

            	        }
            	        break;
            	    case 5 :
            	        // spinach.g:45:5: el5= print
            	        {
            	        	PushFollow(FOLLOW_print_in_expr2218);
            	        	el5 = print();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el5.Tree);
            	        	 retval.ret = ((el5 != null) ? el5.ret : null); 

            	        }
            	        break;
            	    case 6 :
            	        // spinach.g:46:5: el6= ifelse
            	        {
            	        	PushFollow(FOLLOW_ifelse_in_expr2228);
            	        	el6 = ifelse();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el6.Tree);
            	        	retval.ret = ((el6 != null) ? el6.ret : null);

            	        }
            	        break;
            	    case 7 :
            	        // spinach.g:47:5: el7= functioncall
            	        {
            	        	PushFollow(FOLLOW_functioncall_in_expr2237);
            	        	el7 = functioncall();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el7.Tree);
            	        	retval.ret=((el7 != null) ? el7.ret : null);

            	        }
            	        break;
            	    case 8 :
            	        // spinach.g:48:5: el8= forstatement
            	        {
            	        	PushFollow(FOLLOW_forstatement_in_expr2246);
            	        	el8 = forstatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el8.Tree);
            	        	retval.ret = ((el8 != null) ? el8.ret : null);

            	        }
            	        break;
            	    case 9 :
            	        // spinach.g:49:5: el9= comment
            	        {
            	        	PushFollow(FOLLOW_comment_in_expr2255);
            	        	el9 = comment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el9.Tree);
            	        	retval.ret = ((el9 != null) ? el9.ret : null);

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
    // spinach.g:52:1: string_literal returns [StringElement ret] : ( '\"' (el1= var_int_or_double_literal )* '\"' ) ;
    public spinachParser.string_literal_return string_literal() // throws RecognitionException [1]
    {   
        spinachParser.string_literal_return retval = new spinachParser.string_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal10 = null;
        IToken char_literal11 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;


        object char_literal10_tree=null;
        object char_literal11_tree=null;


         retval.ret = new StringElement();

        try 
    	{
            // spinach.g:56:2: ( ( '\"' (el1= var_int_or_double_literal )* '\"' ) )
            // spinach.g:57:2: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:57:2: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            	// spinach.g:57:3: '\"' (el1= var_int_or_double_literal )* '\"'
            	{
            		char_literal10=(IToken)Match(input,27,FOLLOW_27_in_string_literal278); 
            			char_literal10_tree = (object)adaptor.Create(char_literal10);
            			adaptor.AddChild(root_0, char_literal10_tree);

            		// spinach.g:57:6: (el1= var_int_or_double_literal )*
            		do 
            		{
            		    int alt5 = 2;
            		    int LA5_0 = input.LA(1);

            		    if ( ((LA5_0 >= VARIABLE && LA5_0 <= DOUBLE_LITERAL)) )
            		    {
            		        alt5 = 1;
            		    }


            		    switch (alt5) 
            			{
            				case 1 :
            				    // spinach.g:57:7: el1= var_int_or_double_literal
            				    {
            				    	PushFollow(FOLLOW_var_int_or_double_literal_in_string_literal282);
            				    	el1 = var_int_or_double_literal();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	retval.ret.setText(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop5;
            		    }
            		} while (true);

            		loop5:
            			;	// Stops C# compiler whining that label 'loop5' has no statements

            		char_literal11=(IToken)Match(input,27,FOLLOW_27_in_string_literal287); 
            			char_literal11_tree = (object)adaptor.Create(char_literal11);
            			adaptor.AddChild(root_0, char_literal11_tree);

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
    // spinach.g:60:1: comment returns [CommentElement ret] : '//' ( var_int_or_double_literal )* ;
    public spinachParser.comment_return comment() // throws RecognitionException [1]
    {   
        spinachParser.comment_return retval = new spinachParser.comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal12 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal13 = null;


        object string_literal12_tree=null;


        retval.ret = new CommentElement();

        try 
    	{
            // spinach.g:64:1: ( '//' ( var_int_or_double_literal )* )
            // spinach.g:64:2: '//' ( var_int_or_double_literal )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal12=(IToken)Match(input,28,FOLLOW_28_in_comment306); 
            		string_literal12_tree = (object)adaptor.Create(string_literal12);
            		adaptor.AddChild(root_0, string_literal12_tree);

            	// spinach.g:64:6: ( var_int_or_double_literal )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == VARIABLE) )
            	    {
            	        int LA6_2 = input.LA(2);

            	        if ( (LA6_2 == VARIABLE) )
            	        {
            	            int LA6_4 = input.LA(3);

            	            if ( (LA6_4 == EOF || (LA6_4 >= VARIABLE && LA6_4 <= ASSIGNMENT) || LA6_4 == STRINGTYPE || (LA6_4 >= RIGHTPARANTHESIS && LA6_4 <= LEFTBRACE) || LA6_4 == DOT || (LA6_4 >= 28 && LA6_4 <= 30) || LA6_4 == 33 || (LA6_4 >= 35 && LA6_4 <= 39) || LA6_4 == 41 || (LA6_4 >= 43 && LA6_4 <= 44) || (LA6_4 >= 47 && LA6_4 <= 48) || (LA6_4 >= 52 && LA6_4 <= 56)) )
            	            {
            	                alt6 = 1;
            	            }


            	        }
            	        else if ( (LA6_2 == EOF || (LA6_2 >= INT_LITERAL && LA6_2 <= VARTYPE) || LA6_2 == STRINGTYPE || LA6_2 == RIGHTPARANTHESIS || (LA6_2 >= 28 && LA6_2 <= 29) || LA6_2 == 33 || (LA6_2 >= 35 && LA6_2 <= 39) || LA6_2 == 41 || (LA6_2 >= 43 && LA6_2 <= 44) || (LA6_2 >= 47 && LA6_2 <= 48) || (LA6_2 >= 52 && LA6_2 <= 56)) )
            	        {
            	            alt6 = 1;
            	        }


            	    }
            	    else if ( ((LA6_0 >= INT_LITERAL && LA6_0 <= DOUBLE_LITERAL)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // spinach.g:64:6: var_int_or_double_literal
            			    {
            			    	PushFollow(FOLLOW_var_int_or_double_literal_in_comment307);
            			    	var_int_or_double_literal13 = var_int_or_double_literal();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, var_int_or_double_literal13.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


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
    // spinach.g:67:1: var_int_or_double_literal returns [Element ret] : ( variable | int_literal | double_literal ) ;
    public spinachParser.var_int_or_double_literal_return var_int_or_double_literal() // throws RecognitionException [1]
    {   
        spinachParser.var_int_or_double_literal_return retval = new spinachParser.var_int_or_double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.variable_return variable14 = null;

        spinachParser.int_literal_return int_literal15 = null;

        spinachParser.double_literal_return double_literal16 = null;



        try 
    	{
            // spinach.g:68:3: ( ( variable | int_literal | double_literal ) )
            // spinach.g:68:6: ( variable | int_literal | double_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:68:6: ( variable | int_literal | double_literal )
            	int alt7 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    alt7 = 1;
            	    }
            	    break;
            	case INT_LITERAL:
            		{
            	    alt7 = 2;
            	    }
            	    break;
            	case DOUBLE_LITERAL:
            		{
            	    alt7 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d7s0 =
            		        new NoViableAltException("", 7, 0, input);

            		    throw nvae_d7s0;
            	}

            	switch (alt7) 
            	{
            	    case 1 :
            	        // spinach.g:68:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_int_or_double_literal325);
            	        	variable14 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable14.Tree);
            	        	 retval.ret = ((variable14 != null) ? variable14.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:69:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_int_or_double_literal336);
            	        	int_literal15 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal15.Tree);
            	        	retval.ret = ((int_literal15 != null) ? int_literal15.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:70:7: double_literal
            	        {
            	        	PushFollow(FOLLOW_double_literal_in_var_int_or_double_literal346);
            	        	double_literal16 = double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, double_literal16.Tree);
            	        	retval.ret = ((double_literal16 != null) ? double_literal16.ret : null);

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
    // spinach.g:72:1: variable returns [VariableElement ret] : VARIABLE ;
    public spinachParser.variable_return variable() // throws RecognitionException [1]
    {   
        spinachParser.variable_return retval = new spinachParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE17 = null;

        object VARIABLE17_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // spinach.g:76:3: ( VARIABLE )
            // spinach.g:76:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE17=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable368); 
            		VARIABLE17_tree = (object)adaptor.Create(VARIABLE17);
            		adaptor.AddChild(root_0, VARIABLE17_tree);

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
    // spinach.g:78:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public spinachParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        spinachParser.int_literal_return retval = new spinachParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL18 = null;

        object INT_LITERAL18_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // spinach.g:82:3: ( INT_LITERAL )
            // spinach.g:82:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL18=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal389); 
            		INT_LITERAL18_tree = (object)adaptor.Create(INT_LITERAL18);
            		adaptor.AddChild(root_0, INT_LITERAL18_tree);

            	 retval.ret.setText(((INT_LITERAL18 != null) ? INT_LITERAL18.Text : null)); 

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
    // spinach.g:84:1: double_literal returns [DoubleElement ret] : el1= DOUBLE_LITERAL ;
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
            // spinach.g:88:2: (el1= DOUBLE_LITERAL )
            // spinach.g:88:4: el1= DOUBLE_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_double_literal411); 
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
    // spinach.g:92:1: matrixvardec returns [MatrixVariableDeclaration ret] : ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT ;
    public spinachParser.matrixvardec_return matrixvardec() // throws RecognitionException [1]
    {   
        spinachParser.matrixvardec_return retval = new spinachParser.matrixvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal19 = null;
        IToken char_literal20 = null;
        IToken VARTYPE21 = null;
        IToken char_literal22 = null;
        IToken char_literal23 = null;
        IToken char_literal24 = null;
        IToken char_literal25 = null;
        IToken char_literal26 = null;
        IToken ASSIGNMENT27 = null;
        IToken char_literal28 = null;
        IToken char_literal29 = null;
        IToken char_literal30 = null;
        IToken char_literal31 = null;
        IToken END_OF_STATEMENT32 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;

        spinachParser.int_literal_return el7 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal19_tree=null;
        object char_literal20_tree=null;
        object VARTYPE21_tree=null;
        object char_literal22_tree=null;
        object char_literal23_tree=null;
        object char_literal24_tree=null;
        object char_literal25_tree=null;
        object char_literal26_tree=null;
        object ASSIGNMENT27_tree=null;
        object char_literal28_tree=null;
        object char_literal29_tree=null;
        object char_literal30_tree=null;
        object char_literal31_tree=null;
        object END_OF_STATEMENT32_tree=null;


        	retval.ret = new MatrixVariableDeclaration();
        	
        try 
    	{
            // spinach.g:96:2: ( ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT )
            // spinach.g:96:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:96:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' )
            	// spinach.g:96:4: 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']'
            	{
            		string_literal19=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec433); 
            			string_literal19_tree = (object)adaptor.Create(string_literal19);
            			adaptor.AddChild(root_0, string_literal19_tree);

            		char_literal20=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixvardec435); 
            			char_literal20_tree = (object)adaptor.Create(char_literal20);
            			adaptor.AddChild(root_0, char_literal20_tree);

            		VARTYPE21=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixvardec437); 
            			VARTYPE21_tree = (object)adaptor.Create(VARTYPE21);
            			adaptor.AddChild(root_0, VARTYPE21_tree);

            		 retval.ret.setType(((VARTYPE21 != null) ? VARTYPE21.Text : null));
            		char_literal22=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec440); 
            			char_literal22_tree = (object)adaptor.Create(char_literal22);
            			adaptor.AddChild(root_0, char_literal22_tree);

            		char_literal23=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec442); 
            			char_literal23_tree = (object)adaptor.Create(char_literal23);
            			adaptor.AddChild(root_0, char_literal23_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec445);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            		char_literal24=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec448); 
            			char_literal24_tree = (object)adaptor.Create(char_literal24);
            			adaptor.AddChild(root_0, char_literal24_tree);

            		char_literal25=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec451); 
            			char_literal25_tree = (object)adaptor.Create(char_literal25);
            			adaptor.AddChild(root_0, char_literal25_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec455);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            		char_literal26=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec458); 
            			char_literal26_tree = (object)adaptor.Create(char_literal26);
            			adaptor.AddChild(root_0, char_literal26_tree);

            		// spinach.g:98:3: (el3= variable )
            		// spinach.g:98:4: el3= variable
            		{
            			PushFollow(FOLLOW_variable_in_matrixvardec466);
            			el3 = variable();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el3.Tree);
            			 retval.ret.setVar(((el3 != null) ? el3.ret : null));

            		}

            		ASSIGNMENT27=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matrixvardec473); 
            			ASSIGNMENT27_tree = (object)adaptor.Create(ASSIGNMENT27);
            			adaptor.AddChild(root_0, ASSIGNMENT27_tree);

            		char_literal28=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec477); 
            			char_literal28_tree = (object)adaptor.Create(char_literal28);
            			adaptor.AddChild(root_0, char_literal28_tree);

            		// spinach.g:100:6: ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) )
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
            		        // spinach.g:100:7: (el7= int_literal ( ',' el5= int_literal )* )
            		        {
            		        	// spinach.g:100:7: (el7= int_literal ( ',' el5= int_literal )* )
            		        	// spinach.g:100:8: el7= int_literal ( ',' el5= int_literal )*
            		        	{
            		        		PushFollow(FOLLOW_int_literal_in_matrixvardec482);
            		        		el7 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el7.Tree);
            		        		retval.ret.addValue(((el7 != null) ? el7.ret : null));
            		        		// spinach.g:100:57: ( ',' el5= int_literal )*
            		        		do 
            		        		{
            		        		    int alt8 = 2;
            		        		    int LA8_0 = input.LA(1);

            		        		    if ( (LA8_0 == 32) )
            		        		    {
            		        		        alt8 = 1;
            		        		    }


            		        		    switch (alt8) 
            		        			{
            		        				case 1 :
            		        				    // spinach.g:100:58: ',' el5= int_literal
            		        				    {
            		        				    	char_literal29=(IToken)Match(input,32,FOLLOW_32_in_matrixvardec487); 
            		        				    		char_literal29_tree = (object)adaptor.Create(char_literal29);
            		        				    		adaptor.AddChild(root_0, char_literal29_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_matrixvardec490);
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
            		        // spinach.g:101:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        {
            		        	// spinach.g:101:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        	// spinach.g:101:4: el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		PushFollow(FOLLOW_double_literal_in_matrixvardec503);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// spinach.g:102:3: ( ',' el6= double_literal )*
            		        		do 
            		        		{
            		        		    int alt9 = 2;
            		        		    int LA9_0 = input.LA(1);

            		        		    if ( (LA9_0 == 32) )
            		        		    {
            		        		        alt9 = 1;
            		        		    }


            		        		    switch (alt9) 
            		        			{
            		        				case 1 :
            		        				    // spinach.g:102:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal30=(IToken)Match(input,32,FOLLOW_32_in_matrixvardec510); 
            		        				    		char_literal30_tree = (object)adaptor.Create(char_literal30);
            		        				    		adaptor.AddChild(root_0, char_literal30_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_matrixvardec513);
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

            		char_literal31=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec520); 
            			char_literal31_tree = (object)adaptor.Create(char_literal31);
            			adaptor.AddChild(root_0, char_literal31_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT32=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matrixvardec526); 
            		END_OF_STATEMENT32_tree = (object)adaptor.Create(END_OF_STATEMENT32);
            		adaptor.AddChild(root_0, END_OF_STATEMENT32_tree);


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
    // spinach.g:105:1: vectorvardec returns [VectorVariableDeclaration ret] : ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT ;
    public spinachParser.vectorvardec_return vectorvardec() // throws RecognitionException [1]
    {   
        spinachParser.vectorvardec_return retval = new spinachParser.vectorvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal33 = null;
        IToken char_literal34 = null;
        IToken VARTYPE35 = null;
        IToken char_literal36 = null;
        IToken char_literal37 = null;
        IToken char_literal38 = null;
        IToken ASSIGNMENT39 = null;
        IToken char_literal40 = null;
        IToken char_literal41 = null;
        IToken char_literal42 = null;
        IToken char_literal43 = null;
        IToken END_OF_STATEMENT44 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.variable_return el2 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal33_tree=null;
        object char_literal34_tree=null;
        object VARTYPE35_tree=null;
        object char_literal36_tree=null;
        object char_literal37_tree=null;
        object char_literal38_tree=null;
        object ASSIGNMENT39_tree=null;
        object char_literal40_tree=null;
        object char_literal41_tree=null;
        object char_literal42_tree=null;
        object char_literal43_tree=null;
        object END_OF_STATEMENT44_tree=null;


        	retval.ret = new VectorVariableDeclaration();
        	
        try 
    	{
            // spinach.g:109:2: ( ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT )
            // spinach.g:109:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:109:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' )
            	// spinach.g:109:4: 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']'
            	{
            		string_literal33=(IToken)Match(input,33,FOLLOW_33_in_vectorvardec544); 
            			string_literal33_tree = (object)adaptor.Create(string_literal33);
            			adaptor.AddChild(root_0, string_literal33_tree);

            		char_literal34=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorvardec546); 
            			char_literal34_tree = (object)adaptor.Create(char_literal34);
            			adaptor.AddChild(root_0, char_literal34_tree);

            		VARTYPE35=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorvardec548); 
            			VARTYPE35_tree = (object)adaptor.Create(VARTYPE35);
            			adaptor.AddChild(root_0, VARTYPE35_tree);

            		 retval.ret.setType(((VARTYPE35 != null) ? VARTYPE35.Text : null));
            		char_literal36=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec551); 
            			char_literal36_tree = (object)adaptor.Create(char_literal36);
            			adaptor.AddChild(root_0, char_literal36_tree);

            		char_literal37=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec553); 
            			char_literal37_tree = (object)adaptor.Create(char_literal37);
            			adaptor.AddChild(root_0, char_literal37_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorvardec556);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setRange(((el1 != null) ? el1.ret : null));
            		char_literal38=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec559); 
            			char_literal38_tree = (object)adaptor.Create(char_literal38);
            			adaptor.AddChild(root_0, char_literal38_tree);

            		PushFollow(FOLLOW_variable_in_vectorvardec565);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setText(((el2 != null) ? el2.ret : null));
            		ASSIGNMENT39=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_vectorvardec572); 
            			ASSIGNMENT39_tree = (object)adaptor.Create(ASSIGNMENT39);
            			adaptor.AddChild(root_0, ASSIGNMENT39_tree);

            		char_literal40=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec577); 
            			char_literal40_tree = (object)adaptor.Create(char_literal40);
            			adaptor.AddChild(root_0, char_literal40_tree);

            		// spinach.g:112:6: ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) )
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
            		        // spinach.g:112:7: (el3= int_literal ( ',' el5= int_literal )* )
            		        {
            		        	// spinach.g:112:7: (el3= int_literal ( ',' el5= int_literal )* )
            		        	// spinach.g:112:8: el3= int_literal ( ',' el5= int_literal )*
            		        	{
            		        		PushFollow(FOLLOW_int_literal_in_vectorvardec582);
            		        		el3 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el3.Tree);
            		        		retval.ret.addValue(((el3 != null) ? el3.ret : null));
            		        		// spinach.g:112:57: ( ',' el5= int_literal )*
            		        		do 
            		        		{
            		        		    int alt11 = 2;
            		        		    int LA11_0 = input.LA(1);

            		        		    if ( (LA11_0 == 32) )
            		        		    {
            		        		        alt11 = 1;
            		        		    }


            		        		    switch (alt11) 
            		        			{
            		        				case 1 :
            		        				    // spinach.g:112:58: ',' el5= int_literal
            		        				    {
            		        				    	char_literal41=(IToken)Match(input,32,FOLLOW_32_in_vectorvardec587); 
            		        				    		char_literal41_tree = (object)adaptor.Create(char_literal41);
            		        				    		adaptor.AddChild(root_0, char_literal41_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_vectorvardec590);
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
            		        // spinach.g:113:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        {
            		        	// spinach.g:113:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        	// spinach.g:113:4: el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		PushFollow(FOLLOW_double_literal_in_vectorvardec603);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// spinach.g:114:3: ( ',' el6= double_literal )*
            		        		do 
            		        		{
            		        		    int alt12 = 2;
            		        		    int LA12_0 = input.LA(1);

            		        		    if ( (LA12_0 == 32) )
            		        		    {
            		        		        alt12 = 1;
            		        		    }


            		        		    switch (alt12) 
            		        			{
            		        				case 1 :
            		        				    // spinach.g:114:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal42=(IToken)Match(input,32,FOLLOW_32_in_vectorvardec610); 
            		        				    		char_literal42_tree = (object)adaptor.Create(char_literal42);
            		        				    		adaptor.AddChild(root_0, char_literal42_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_vectorvardec613);
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

            		char_literal43=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec620); 
            			char_literal43_tree = (object)adaptor.Create(char_literal43);
            			adaptor.AddChild(root_0, char_literal43_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT44=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_vectorvardec626); 
            		END_OF_STATEMENT44_tree = (object)adaptor.Create(END_OF_STATEMENT44);
            		adaptor.AddChild(root_0, END_OF_STATEMENT44_tree);


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
    // spinach.g:117:1: matrixelem returns [MatrixElement ret] : (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' ) ;
    public spinachParser.matrixelem_return matrixelem() // throws RecognitionException [1]
    {   
        spinachParser.matrixelem_return retval = new spinachParser.matrixelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal45 = null;
        IToken char_literal46 = null;
        IToken char_literal47 = null;
        IToken char_literal48 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.int_literal_return el3 = null;


        object char_literal45_tree=null;
        object char_literal46_tree=null;
        object char_literal47_tree=null;
        object char_literal48_tree=null;


         retval.ret = new MatrixElement();
         
        try 
    	{
            // spinach.g:121:2: ( (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' ) )
            // spinach.g:121:3: (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:121:3: (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' )
            	// spinach.g:121:4: el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']'
            	{
            		PushFollow(FOLLOW_variable_in_matrixelem646);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal45=(IToken)Match(input,30,FOLLOW_30_in_matrixelem649); 
            			char_literal45_tree = (object)adaptor.Create(char_literal45);
            			adaptor.AddChild(root_0, char_literal45_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixelem652);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setRow(((el2 != null) ? el2.ret : null));
            		char_literal46=(IToken)Match(input,31,FOLLOW_31_in_matrixelem654); 
            			char_literal46_tree = (object)adaptor.Create(char_literal46);
            			adaptor.AddChild(root_0, char_literal46_tree);

            		char_literal47=(IToken)Match(input,30,FOLLOW_30_in_matrixelem657); 
            			char_literal47_tree = (object)adaptor.Create(char_literal47);
            			adaptor.AddChild(root_0, char_literal47_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixelem660);
            		el3 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el3.Tree);
            		retval.ret.setColumn(((el3 != null) ? el3.ret : null));
            		char_literal48=(IToken)Match(input,31,FOLLOW_31_in_matrixelem662); 
            			char_literal48_tree = (object)adaptor.Create(char_literal48);
            			adaptor.AddChild(root_0, char_literal48_tree);


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
    // spinach.g:124:1: vectorelem returns [VectorElement ret] : (el1= variable '[' el2= int_literal ']' ) ;
    public spinachParser.vectorelem_return vectorelem() // throws RecognitionException [1]
    {   
        spinachParser.vectorelem_return retval = new spinachParser.vectorelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal49 = null;
        IToken char_literal50 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;


        object char_literal49_tree=null;
        object char_literal50_tree=null;


         retval.ret = new VectorElement();
         
        try 
    	{
            // spinach.g:128:2: ( (el1= variable '[' el2= int_literal ']' ) )
            // spinach.g:128:3: (el1= variable '[' el2= int_literal ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:128:3: (el1= variable '[' el2= int_literal ']' )
            	// spinach.g:128:4: el1= variable '[' el2= int_literal ']'
            	{
            		PushFollow(FOLLOW_variable_in_vectorelem684);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal49=(IToken)Match(input,30,FOLLOW_30_in_vectorelem687); 
            			char_literal49_tree = (object)adaptor.Create(char_literal49);
            			adaptor.AddChild(root_0, char_literal49_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorelem690);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setRange(((el2 != null) ? el2.ret : null));
            		char_literal50=(IToken)Match(input,31,FOLLOW_31_in_vectorelem693); 
            			char_literal50_tree = (object)adaptor.Create(char_literal50);
            			adaptor.AddChild(root_0, char_literal50_tree);


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
    // spinach.g:130:1: assignment returns [AssignmentOperationElement ret] : ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal | functioncall ) ) END_OF_STATEMENT ;
    public spinachParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        spinachParser.assignment_return retval = new spinachParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT53 = null;
        IToken END_OF_STATEMENT59 = null;
        spinachParser.vectorelem_return e12 = null;

        spinachParser.matrixelem_return e11 = null;

        spinachParser.variable_return variable51 = null;

        spinachParser.structassign_return structassign52 = null;

        spinachParser.subtractive_exp_return subtractive_exp54 = null;

        spinachParser.dotproduct_return dotproduct55 = null;

        spinachParser.matrixtranspose_return matrixtranspose56 = null;

        spinachParser.string_literal_return string_literal57 = null;

        spinachParser.functioncall_return functioncall58 = null;


        object ASSIGNMENT53_tree=null;
        object END_OF_STATEMENT59_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // spinach.g:134:3: ( ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal | functioncall ) ) END_OF_STATEMENT )
            // spinach.g:134:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal | functioncall ) ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:134:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal | functioncall ) )
            	// spinach.g:134:6: ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal | functioncall )
            	{
            		// spinach.g:134:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )
            		int alt14 = 4;
            		int LA14_0 = input.LA(1);

            		if ( (LA14_0 == VARIABLE) )
            		{
            		    switch ( input.LA(2) ) 
            		    {
            		    case 30:
            		    	{
            		        int LA14_2 = input.LA(3);

            		        if ( (LA14_2 == INT_LITERAL) )
            		        {
            		            int LA14_5 = input.LA(4);

            		            if ( (LA14_5 == 31) )
            		            {
            		                int LA14_6 = input.LA(5);

            		                if ( (LA14_6 == 30) )
            		                {
            		                    alt14 = 4;
            		                }
            		                else if ( (LA14_6 == ASSIGNMENT) )
            		                {
            		                    alt14 = 3;
            		                }
            		                else 
            		                {
            		                    NoViableAltException nvae_d14s6 =
            		                        new NoViableAltException("", 14, 6, input);

            		                    throw nvae_d14s6;
            		                }
            		            }
            		            else 
            		            {
            		                NoViableAltException nvae_d14s5 =
            		                    new NoViableAltException("", 14, 5, input);

            		                throw nvae_d14s5;
            		            }
            		        }
            		        else 
            		        {
            		            NoViableAltException nvae_d14s2 =
            		                new NoViableAltException("", 14, 2, input);

            		            throw nvae_d14s2;
            		        }
            		        }
            		        break;
            		    case ASSIGNMENT:
            		    	{
            		        alt14 = 1;
            		        }
            		        break;
            		    case DOT:
            		    	{
            		        alt14 = 2;
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
            		        // spinach.g:134:7: variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_assignment716);
            		        	variable51 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, variable51.Tree);
            		        	retval.ret.setLhs(((variable51 != null) ? variable51.ret : null)); 

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:135:7: structassign
            		        {
            		        	PushFollow(FOLLOW_structassign_in_assignment726);
            		        	structassign52 = structassign();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, structassign52.Tree);
            		        	retval.ret.setLhs(((structassign52 != null) ? structassign52.ret : null));

            		        }
            		        break;
            		    case 3 :
            		        // spinach.g:136:6: e12= vectorelem
            		        {
            		        	PushFollow(FOLLOW_vectorelem_in_assignment738);
            		        	e12 = vectorelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e12.Tree);
            		        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            		        }
            		        break;
            		    case 4 :
            		        // spinach.g:137:7: e11= matrixelem
            		        {
            		        	PushFollow(FOLLOW_matrixelem_in_assignment751);
            		        	e11 = matrixelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e11.Tree);
            		        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		        }
            		        break;

            		}

            		ASSIGNMENT53=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment759); 
            			ASSIGNMENT53_tree = (object)adaptor.Create(ASSIGNMENT53);
            			adaptor.AddChild(root_0, ASSIGNMENT53_tree);

            		// spinach.g:139:5: ( subtractive_exp | dotproduct | matrixtranspose | string_literal | functioncall )
            		int alt15 = 5;
            		switch ( input.LA(1) ) 
            		{
            		case VARIABLE:
            			{
            		    switch ( input.LA(2) ) 
            		    {
            		    case END_OF_STATEMENT:
            		    case PLUS:
            		    case MULTIPLY:
            		    case 30:
            		    case 34:
            		    	{
            		        alt15 = 1;
            		        }
            		        break;
            		    case LEFTBRACE:
            		    	{
            		        alt15 = 5;
            		        }
            		        break;
            		    case 45:
            		    	{
            		        alt15 = 2;
            		        }
            		        break;
            		    	default:
            		    	    NoViableAltException nvae_d15s1 =
            		    	        new NoViableAltException("", 15, 1, input);

            		    	    throw nvae_d15s1;
            		    }

            		    }
            		    break;
            		case INT_LITERAL:
            		case DOUBLE_LITERAL:
            		case LEFTBRACE:
            			{
            		    alt15 = 1;
            		    }
            		    break;
            		case 46:
            			{
            		    alt15 = 3;
            		    }
            		    break;
            		case 27:
            			{
            		    alt15 = 4;
            		    }
            		    break;
            			default:
            			    NoViableAltException nvae_d15s0 =
            			        new NoViableAltException("", 15, 0, input);

            			    throw nvae_d15s0;
            		}

            		switch (alt15) 
            		{
            		    case 1 :
            		        // spinach.g:139:7: subtractive_exp
            		        {
            		        	PushFollow(FOLLOW_subtractive_exp_in_assignment768);
            		        	subtractive_exp54 = subtractive_exp();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, subtractive_exp54.Tree);
            		        	retval.ret.setRhs(((subtractive_exp54 != null) ? subtractive_exp54.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:139:66: dotproduct
            		        {
            		        	PushFollow(FOLLOW_dotproduct_in_assignment772);
            		        	dotproduct55 = dotproduct();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, dotproduct55.Tree);
            		        	retval.ret.setRhs(((dotproduct55 != null) ? dotproduct55.ret : null));

            		        }
            		        break;
            		    case 3 :
            		        // spinach.g:140:7: matrixtranspose
            		        {
            		        	PushFollow(FOLLOW_matrixtranspose_in_assignment781);
            		        	matrixtranspose56 = matrixtranspose();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, matrixtranspose56.Tree);
            		        	retval.ret.setRhs(((matrixtranspose56 != null) ? matrixtranspose56.ret : null));

            		        }
            		        break;
            		    case 4 :
            		        // spinach.g:140:66: string_literal
            		        {
            		        	PushFollow(FOLLOW_string_literal_in_assignment785);
            		        	string_literal57 = string_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, string_literal57.Tree);
            		        	retval.ret.setRhs(((string_literal57 != null) ? string_literal57.ret : null));

            		        }
            		        break;
            		    case 5 :
            		        // spinach.g:140:123: functioncall
            		        {
            		        	PushFollow(FOLLOW_functioncall_in_assignment789);
            		        	functioncall58 = functioncall();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, functioncall58.Tree);
            		        	retval.ret.setRhs(((functioncall58 != null) ? functioncall58.ret : null));

            		        }
            		        break;

            		}


            	}

            	END_OF_STATEMENT59=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment804); 
            		END_OF_STATEMENT59_tree = (object)adaptor.Create(END_OF_STATEMENT59);
            		adaptor.AddChild(root_0, END_OF_STATEMENT59_tree);


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
    // spinach.g:145:1: additive_expression returns [AdditiveElement ret] : ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) ;
    public spinachParser.additive_expression_return additive_expression() // throws RecognitionException [1]
    {   
        spinachParser.additive_expression_return retval = new spinachParser.additive_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal60 = null;
        spinachParser.multiplicative_expression_return e11 = null;

        spinachParser.additive_expression_return e12 = null;


        object char_literal60_tree=null;


                retval.ret = new AdditiveElement();

        try 
    	{
            // spinach.g:149:9: ( ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) )
            // spinach.g:149:11: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:149:11: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            	// spinach.g:149:12: (e11= multiplicative_expression ) ( '+' e12= additive_expression )*
            	{
            		// spinach.g:149:12: (e11= multiplicative_expression )
            		// spinach.g:149:13: e11= multiplicative_expression
            		{
            			PushFollow(FOLLOW_multiplicative_expression_in_additive_expression839);
            			e11 = multiplicative_expression();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, e11.Tree);
            			retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		}

            		// spinach.g:150:1: ( '+' e12= additive_expression )*
            		do 
            		{
            		    int alt16 = 2;
            		    int LA16_0 = input.LA(1);

            		    if ( (LA16_0 == PLUS) )
            		    {
            		        alt16 = 1;
            		    }


            		    switch (alt16) 
            			{
            				case 1 :
            				    // spinach.g:150:2: '+' e12= additive_expression
            				    {
            				    	char_literal60=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_additive_expression844); 
            				    		char_literal60_tree = (object)adaptor.Create(char_literal60);
            				    		adaptor.AddChild(root_0, char_literal60_tree);

            				    	PushFollow(FOLLOW_additive_expression_in_additive_expression850);
            				    	e12 = additive_expression();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop16;
            		    }
            		} while (true);

            		loop16:
            			;	// Stops C# compiler whining that label 'loop16' has no statements


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
    // spinach.g:153:1: multiplicative_expression returns [MultiplicationElement ret] : (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )* ;
    public spinachParser.multiplicative_expression_return multiplicative_expression() // throws RecognitionException [1]
    {   
        spinachParser.multiplicative_expression_return retval = new spinachParser.multiplicative_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal61 = null;
        spinachParser.var_int_or_double_literal_return e11 = null;

        spinachParser.bracket_exp_return e12 = null;

        spinachParser.matrixelem_return el3 = null;

        spinachParser.vectorelem_return el4 = null;

        spinachParser.multiplicative_expression_return el5 = null;


        object char_literal61_tree=null;


                retval.ret = new MultiplicationElement();

        try 
    	{
            // spinach.g:157:9: ( (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )* )
            // spinach.g:157:11: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:157:11: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem )
            	int alt17 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    int LA17_1 = input.LA(2);

            	    if ( (LA17_1 == 30) )
            	    {
            	        int LA17_4 = input.LA(3);

            	        if ( (LA17_4 == INT_LITERAL) )
            	        {
            	            int LA17_5 = input.LA(4);

            	            if ( (LA17_5 == 31) )
            	            {
            	                int LA17_6 = input.LA(5);

            	                if ( (LA17_6 == 30) )
            	                {
            	                    alt17 = 3;
            	                }
            	                else if ( (LA17_6 == END_OF_STATEMENT || LA17_6 == RIGHTBRACE || (LA17_6 >= PLUS && LA17_6 <= MULTIPLY) || LA17_6 == 34) )
            	                {
            	                    alt17 = 4;
            	                }
            	                else 
            	                {
            	                    NoViableAltException nvae_d17s6 =
            	                        new NoViableAltException("", 17, 6, input);

            	                    throw nvae_d17s6;
            	                }
            	            }
            	            else 
            	            {
            	                NoViableAltException nvae_d17s5 =
            	                    new NoViableAltException("", 17, 5, input);

            	                throw nvae_d17s5;
            	            }
            	        }
            	        else 
            	        {
            	            NoViableAltException nvae_d17s4 =
            	                new NoViableAltException("", 17, 4, input);

            	            throw nvae_d17s4;
            	        }
            	    }
            	    else if ( (LA17_1 == END_OF_STATEMENT || LA17_1 == RIGHTBRACE || (LA17_1 >= PLUS && LA17_1 <= MULTIPLY) || LA17_1 == 34) )
            	    {
            	        alt17 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d17s1 =
            	            new NoViableAltException("", 17, 1, input);

            	        throw nvae_d17s1;
            	    }
            	    }
            	    break;
            	case INT_LITERAL:
            	case DOUBLE_LITERAL:
            		{
            	    alt17 = 1;
            	    }
            	    break;
            	case LEFTBRACE:
            		{
            	    alt17 = 2;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d17s0 =
            		        new NoViableAltException("", 17, 0, input);

            		    throw nvae_d17s0;
            	}

            	switch (alt17) 
            	{
            	    case 1 :
            	        // spinach.g:157:12: e11= var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplicative_expression892);
            	        	e11 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e11.Tree);
            	        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:158:14: e12= bracket_exp
            	        {
            	        	PushFollow(FOLLOW_bracket_exp_in_multiplicative_expression911);
            	        	e12 = bracket_exp();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e12.Tree);
            	        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:159:14: el3= matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_multiplicative_expression931);
            	        	el3 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el3.Tree);
            	        	retval.ret.setLhs(((el3 != null) ? el3.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        // spinach.g:160:14: el4= vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_multiplicative_expression951);
            	        	el4 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	retval.ret.setLhs(((el4 != null) ? el4.ret : null));

            	        }
            	        break;

            	}

            	// spinach.g:161:12: ( '*' el5= multiplicative_expression )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == MULTIPLY) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // spinach.g:161:13: '*' el5= multiplicative_expression
            			    {
            			    	char_literal61=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplicative_expression967); 
            			    		char_literal61_tree = (object)adaptor.Create(char_literal61);
            			    		adaptor.AddChild(root_0, char_literal61_tree);

            			    	PushFollow(FOLLOW_multiplicative_expression_in_multiplicative_expression1024);
            			    	el5 = multiplicative_expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, el5.Tree);
            			    	retval.ret.setRhs(el5.ret);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


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
    // spinach.g:172:1: bracket_exp returns [BracketElement ret] : '(' subtractive_exp ')' ;
    public spinachParser.bracket_exp_return bracket_exp() // throws RecognitionException [1]
    {   
        spinachParser.bracket_exp_return retval = new spinachParser.bracket_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal62 = null;
        IToken char_literal64 = null;
        spinachParser.subtractive_exp_return subtractive_exp63 = null;


        object char_literal62_tree=null;
        object char_literal64_tree=null;


                retval.ret = new BracketElement();

        try 
    	{
            // spinach.g:176:1: ( '(' subtractive_exp ')' )
            // spinach.g:176:3: '(' subtractive_exp ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal62=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_bracket_exp1068); 
            		char_literal62_tree = (object)adaptor.Create(char_literal62);
            		adaptor.AddChild(root_0, char_literal62_tree);

            	PushFollow(FOLLOW_subtractive_exp_in_bracket_exp1069);
            	subtractive_exp63 = subtractive_exp();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, subtractive_exp63.Tree);
            	retval.ret.setbracketexpression
            	(((subtractive_exp63 != null) ? subtractive_exp63.ret : null));
            	char_literal64=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_bracket_exp1071); 
            		char_literal64_tree = (object)adaptor.Create(char_literal64);
            		adaptor.AddChild(root_0, char_literal64_tree);


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
    // spinach.g:183:1: subtractive_exp returns [SubtractionElement ret] : (e11= additive_expression ( '-' e12= subtractive_exp )* ) ;
    public spinachParser.subtractive_exp_return subtractive_exp() // throws RecognitionException [1]
    {   
        spinachParser.subtractive_exp_return retval = new spinachParser.subtractive_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal65 = null;
        spinachParser.additive_expression_return e11 = null;

        spinachParser.subtractive_exp_return e12 = null;


        object char_literal65_tree=null;


                retval.ret = new SubtractionElement();

        try 
    	{
            // spinach.g:187:1: ( (e11= additive_expression ( '-' e12= subtractive_exp )* ) )
            // spinach.g:187:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:187:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            	// spinach.g:187:7: e11= additive_expression ( '-' e12= subtractive_exp )*
            	{
            		PushFollow(FOLLOW_additive_expression_in_subtractive_exp1100);
            		e11 = additive_expression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, e11.Tree);
            		retval.ret.setLhs(((e11 != null) ? e11.ret : null));
            		// spinach.g:187:64: ( '-' e12= subtractive_exp )*
            		do 
            		{
            		    int alt19 = 2;
            		    int LA19_0 = input.LA(1);

            		    if ( (LA19_0 == 34) )
            		    {
            		        alt19 = 1;
            		    }


            		    switch (alt19) 
            			{
            				case 1 :
            				    // spinach.g:187:65: '-' e12= subtractive_exp
            				    {
            				    	char_literal65=(IToken)Match(input,34,FOLLOW_34_in_subtractive_exp1105); 
            				    		char_literal65_tree = (object)adaptor.Create(char_literal65);
            				    		adaptor.AddChild(root_0, char_literal65_tree);

            				    	PushFollow(FOLLOW_subtractive_exp_in_subtractive_exp1111);
            				    	e12 = subtractive_exp();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop19;
            		    }
            		} while (true);

            		loop19:
            			;	// Stops C# compiler whining that label 'loop19' has no statements


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
    // spinach.g:191:1: structdec returns [StructDeclaration ret] : ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT ;
    public spinachParser.structdec_return structdec() // throws RecognitionException [1]
    {   
        spinachParser.structdec_return retval = new spinachParser.structdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal66 = null;
        IToken char_literal68 = null;
        IToken char_literal69 = null;
        IToken END_OF_STATEMENT70 = null;
        spinachParser.scalarvardec_return el1 = null;

        spinachParser.variable_return variable67 = null;


        object string_literal66_tree=null;
        object char_literal68_tree=null;
        object char_literal69_tree=null;
        object END_OF_STATEMENT70_tree=null;


        retval.ret = new StructDeclaration();

        try 
    	{
            // spinach.g:195:1: ( ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT )
            // spinach.g:195:3: ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:195:3: ( 'struct' variable '{' (el1= scalarvardec )+ '}' )
            	// spinach.g:195:4: 'struct' variable '{' (el1= scalarvardec )+ '}'
            	{
            		string_literal66=(IToken)Match(input,35,FOLLOW_35_in_structdec1143); 
            			string_literal66_tree = (object)adaptor.Create(string_literal66);
            			adaptor.AddChild(root_0, string_literal66_tree);

            		PushFollow(FOLLOW_variable_in_structdec1145);
            		variable67 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable67.Tree);
            		 retval.ret.setName(((variable67 != null) ? variable67.ret : null));
            		char_literal68=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_structdec1149); 
            			char_literal68_tree = (object)adaptor.Create(char_literal68);
            			adaptor.AddChild(root_0, char_literal68_tree);

            		// spinach.g:196:5: (el1= scalarvardec )+
            		int cnt20 = 0;
            		do 
            		{
            		    int alt20 = 2;
            		    int LA20_0 = input.LA(1);

            		    if ( (LA20_0 == VARTYPE || LA20_0 == STRINGTYPE) )
            		    {
            		        alt20 = 1;
            		    }


            		    switch (alt20) 
            			{
            				case 1 :
            				    // spinach.g:196:6: el1= scalarvardec
            				    {
            				    	PushFollow(FOLLOW_scalarvardec_in_structdec1154);
            				    	el1 = scalarvardec();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	 retval.ret.setVarType(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    if ( cnt20 >= 1 ) goto loop20;
            			            EarlyExitException eee20 =
            			                new EarlyExitException(20, input);
            			            throw eee20;
            		    }
            		    cnt20++;
            		} while (true);

            		loop20:
            			;	// Stops C# compiler whining that label 'loop20' has no statements

            		char_literal69=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_structdec1160); 
            			char_literal69_tree = (object)adaptor.Create(char_literal69);
            			adaptor.AddChild(root_0, char_literal69_tree);


            	}

            	END_OF_STATEMENT70=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec1162); 
            		END_OF_STATEMENT70_tree = (object)adaptor.Create(END_OF_STATEMENT70);
            		adaptor.AddChild(root_0, END_OF_STATEMENT70_tree);


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
    // spinach.g:199:1: scalarvardec returns [ScalarVariableDeclaration ret] : ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT ;
    public spinachParser.scalarvardec_return scalarvardec() // throws RecognitionException [1]
    {   
        spinachParser.scalarvardec_return retval = new spinachParser.scalarvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE71 = null;
        IToken STRINGTYPE72 = null;
        IToken END_OF_STATEMENT74 = null;
        spinachParser.variable_return variable73 = null;


        object VARTYPE71_tree=null;
        object STRINGTYPE72_tree=null;
        object END_OF_STATEMENT74_tree=null;


        	retval.ret = new ScalarVariableDeclaration();
        	
        try 
    	{
            // spinach.g:203:2: ( ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT )
            // spinach.g:203:3: ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:203:3: ( ( VARTYPE | STRINGTYPE ) variable )
            	// spinach.g:203:4: ( VARTYPE | STRINGTYPE ) variable
            	{
            		// spinach.g:203:4: ( VARTYPE | STRINGTYPE )
            		int alt21 = 2;
            		int LA21_0 = input.LA(1);

            		if ( (LA21_0 == VARTYPE) )
            		{
            		    alt21 = 1;
            		}
            		else if ( (LA21_0 == STRINGTYPE) )
            		{
            		    alt21 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d21s0 =
            		        new NoViableAltException("", 21, 0, input);

            		    throw nvae_d21s0;
            		}
            		switch (alt21) 
            		{
            		    case 1 :
            		        // spinach.g:203:5: VARTYPE
            		        {
            		        	VARTYPE71=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarvardec1183); 
            		        		VARTYPE71_tree = (object)adaptor.Create(VARTYPE71);
            		        		adaptor.AddChild(root_0, VARTYPE71_tree);

            		        	 retval.ret.setType(((VARTYPE71 != null) ? VARTYPE71.Text : null));

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:204:4: STRINGTYPE
            		        {
            		        	STRINGTYPE72=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_scalarvardec1190); 
            		        		STRINGTYPE72_tree = (object)adaptor.Create(STRINGTYPE72);
            		        		adaptor.AddChild(root_0, STRINGTYPE72_tree);

            		        	 retval.ret.setType(((STRINGTYPE72 != null) ? STRINGTYPE72.Text : null));

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_variable_in_scalarvardec1197);
            		variable73 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable73.Tree);
            		 retval.ret.setVar(((variable73 != null) ? variable73.ret : null));

            	}

            	END_OF_STATEMENT74=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_scalarvardec1201); 
            		END_OF_STATEMENT74_tree = (object)adaptor.Create(END_OF_STATEMENT74);
            		adaptor.AddChild(root_0, END_OF_STATEMENT74_tree);


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
    // spinach.g:208:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
    public spinachParser.structobjdec_return structobjdec() // throws RecognitionException [1]
    {   
        spinachParser.structobjdec_return retval = new spinachParser.structobjdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT75 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object END_OF_STATEMENT75_tree=null;


        retval.ret = new StructObjectDeclaration();

        try 
    	{
            // spinach.g:212:1: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            // spinach.g:212:3: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:212:3: (el1= variable el2= variable )
            	// spinach.g:212:4: el1= variable el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structobjdec1223);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		PushFollow(FOLLOW_variable_in_structobjdec1230);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	END_OF_STATEMENT75=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec1236); 
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
    // spinach.g:216:1: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
    public spinachParser.structassign_return structassign() // throws RecognitionException [1]
    {   
        spinachParser.structassign_return retval = new spinachParser.structassign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal76 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object char_literal76_tree=null;


        retval.ret = new StructAssignDeclaration();

        try 
    	{
            // spinach.g:220:1: ( (el1= variable '.' el2= variable ) )
            // spinach.g:220:2: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:220:2: (el1= variable '.' el2= variable )
            	// spinach.g:220:3: el1= variable '.' el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structassign1256);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setName(((el1 != null) ? el1.ret : null));
            		char_literal76=(IToken)Match(input,DOT,FOLLOW_DOT_in_structassign1259); 
            			char_literal76_tree = (object)adaptor.Create(char_literal76);
            			adaptor.AddChild(root_0, char_literal76_tree);

            		PushFollow(FOLLOW_variable_in_structassign1262);
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
    // spinach.g:222:1: deletionofvar returns [DeleteVariable ret] : ( 'delete' el1= variable ) END_OF_STATEMENT ;
    public spinachParser.deletionofvar_return deletionofvar() // throws RecognitionException [1]
    {   
        spinachParser.deletionofvar_return retval = new spinachParser.deletionofvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal77 = null;
        IToken END_OF_STATEMENT78 = null;
        spinachParser.variable_return el1 = null;


        object string_literal77_tree=null;
        object END_OF_STATEMENT78_tree=null;


        retval.ret = new DeleteVariable();

        try 
    	{
            // spinach.g:226:1: ( ( 'delete' el1= variable ) END_OF_STATEMENT )
            // spinach.g:226:2: ( 'delete' el1= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:226:2: ( 'delete' el1= variable )
            	// spinach.g:226:3: 'delete' el1= variable
            	{
            		string_literal77=(IToken)Match(input,36,FOLLOW_36_in_deletionofvar1282); 
            			string_literal77_tree = (object)adaptor.Create(string_literal77);
            			adaptor.AddChild(root_0, string_literal77_tree);

            		PushFollow(FOLLOW_variable_in_deletionofvar1286);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setVar(((el1 != null) ? el1.ret : null));

            	}

            	END_OF_STATEMENT78=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_deletionofvar1290); 
            		END_OF_STATEMENT78_tree = (object)adaptor.Create(END_OF_STATEMENT78);
            		adaptor.AddChild(root_0, END_OF_STATEMENT78_tree);


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
    // spinach.g:228:1: print returns [PrintOperationElement ret] : 'print' var_int_or_double_literal END_OF_STATEMENT ;
    public spinachParser.print_return print() // throws RecognitionException [1]
    {   
        spinachParser.print_return retval = new spinachParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal79 = null;
        IToken END_OF_STATEMENT81 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal80 = null;


        object string_literal79_tree=null;
        object END_OF_STATEMENT81_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // spinach.g:232:3: ( 'print' var_int_or_double_literal END_OF_STATEMENT )
            // spinach.g:232:5: 'print' var_int_or_double_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal79=(IToken)Match(input,37,FOLLOW_37_in_print1309); 
            		string_literal79_tree = (object)adaptor.Create(string_literal79);
            		adaptor.AddChild(root_0, string_literal79_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_print1311);
            	var_int_or_double_literal80 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal80.Tree);
            	retval.ret.setChildElement(((var_int_or_double_literal80 != null) ? var_int_or_double_literal80.ret : null)); 
            	END_OF_STATEMENT81=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print1319); 
            		END_OF_STATEMENT81_tree = (object)adaptor.Create(END_OF_STATEMENT81);
            		adaptor.AddChild(root_0, END_OF_STATEMENT81_tree);


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
    // spinach.g:236:1: parallelfor returns [ParallelForElement ret] : 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS ;
    public spinachParser.parallelfor_return parallelfor() // throws RecognitionException [1]
    {   
        spinachParser.parallelfor_return retval = new spinachParser.parallelfor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal82 = null;
        IToken LEFTPARANTHESIS83 = null;
        IToken string_literal84 = null;
        IToken END_OF_STATEMENT85 = null;
        IToken RIGHTPARANTHESIS86 = null;
        spinachParser.range_return r11 = null;

        spinachParser.expr2_return e11 = null;


        object string_literal82_tree=null;
        object LEFTPARANTHESIS83_tree=null;
        object string_literal84_tree=null;
        object END_OF_STATEMENT85_tree=null;
        object RIGHTPARANTHESIS86_tree=null;


          retval.ret = new ParallelForElement();

        try 
    	{
            // spinach.g:239:2: ( 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS )
            // spinach.g:239:4: 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal82=(IToken)Match(input,38,FOLLOW_38_in_parallelfor1341); 
            		string_literal82_tree = (object)adaptor.Create(string_literal82);
            		adaptor.AddChild(root_0, string_literal82_tree);

            	PushFollow(FOLLOW_range_in_parallelfor1347);
            	r11 = range();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGE = ((r11 != null) ? r11.ret : null);
            	LEFTPARANTHESIS83=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_parallelfor1350); 
            		LEFTPARANTHESIS83_tree = (object)adaptor.Create(LEFTPARANTHESIS83);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS83_tree);

            	// spinach.g:239:79: ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+
            	int cnt24 = 0;
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == VARIABLE || LA24_0 == VARTYPE || LA24_0 == STRINGTYPE || LA24_0 == 28 || LA24_0 == 33 || (LA24_0 >= 36 && LA24_0 <= 37) || LA24_0 == 41 || LA24_0 == 43) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // spinach.g:239:80: (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    {
            			    	// spinach.g:239:80: (e11= expr2 )+
            			    	int cnt22 = 0;
            			    	do 
            			    	{
            			    	    int alt22 = 2;
            			    	    alt22 = dfa22.Predict(input);
            			    	    switch (alt22) 
            			    		{
            			    			case 1 :
            			    			    // spinach.g:239:81: e11= expr2
            			    			    {
            			    			    	PushFollow(FOLLOW_expr2_in_parallelfor1357);
            			    			    	e11 = expr2();
            			    			    	state.followingStackPointer--;

            			    			    	adaptor.AddChild(root_0, e11.Tree);
            			    			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt22 >= 1 ) goto loop22;
            			    		            EarlyExitException eee22 =
            			    		                new EarlyExitException(22, input);
            			    		            throw eee22;
            			    	    }
            			    	    cnt22++;
            			    	} while (true);

            			    	loop22:
            			    		;	// Stops C# compiler whining that label 'loop22' has no statements

            			    	// spinach.g:239:123: ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    	int alt23 = 2;
            			    	int LA23_0 = input.LA(1);

            			    	if ( (LA23_0 == 39) )
            			    	{
            			    	    alt23 = 1;
            			    	}
            			    	else if ( (LA23_0 == VARIABLE || LA23_0 == VARTYPE || LA23_0 == STRINGTYPE || LA23_0 == RIGHTPARANTHESIS || LA23_0 == 28 || LA23_0 == 33 || (LA23_0 >= 36 && LA23_0 <= 37) || LA23_0 == 41 || LA23_0 == 43) )
            			    	{
            			    	    alt23 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d23s0 =
            			    	        new NoViableAltException("", 23, 0, input);

            			    	    throw nvae_d23s0;
            			    	}
            			    	switch (alt23) 
            			    	{
            			    	    case 1 :
            			    	        // spinach.g:239:124: ( 'SYNC' END_OF_STATEMENT )
            			    	        {
            			    	        	// spinach.g:239:124: ( 'SYNC' END_OF_STATEMENT )
            			    	        	// spinach.g:239:125: 'SYNC' END_OF_STATEMENT
            			    	        	{
            			    	        		string_literal84=(IToken)Match(input,39,FOLLOW_39_in_parallelfor1363); 
            			    	        			string_literal84_tree = (object)adaptor.Create(string_literal84);
            			    	        			adaptor.AddChild(root_0, string_literal84_tree);

            			    	        		retval.ret.syncfunction();
            			    	        		END_OF_STATEMENT85=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_parallelfor1366); 
            			    	        			END_OF_STATEMENT85_tree = (object)adaptor.Create(END_OF_STATEMENT85);
            			    	        			adaptor.AddChild(root_0, END_OF_STATEMENT85_tree);


            			    	        	}


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // spinach.g:239:178: 
            			    	        {
            			    	        	retval.ret.syncfunction();

            			    	        }
            			    	        break;

            			    	}


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

            	RIGHTPARANTHESIS86=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_parallelfor1374); 
            		RIGHTPARANTHESIS86_tree = (object)adaptor.Create(RIGHTPARANTHESIS86);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS86_tree);


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

    public class range_return : ParserRuleReturnScope
    {
        public RangeElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "range"
    // spinach.g:242:1: range returns [RangeElement ret] : LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE ;
    public spinachParser.range_return range() // throws RecognitionException [1]
    {   
        spinachParser.range_return retval = new spinachParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LEFTBRACE87 = null;
        IToken POINT88 = null;
        IToken string_literal89 = null;
        IToken RIGHTBRACE90 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.int_literal_return e12 = null;

        spinachParser.int_literal_return e13 = null;


        object LEFTBRACE87_tree=null;
        object POINT88_tree=null;
        object string_literal89_tree=null;
        object RIGHTBRACE90_tree=null;


          retval.ret= new RangeElement();

        try 
    	{
            // spinach.g:245:2: ( LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE )
            // spinach.g:245:3: LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LEFTBRACE87=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_range1388); 
            		LEFTBRACE87_tree = (object)adaptor.Create(LEFTBRACE87);
            		adaptor.AddChild(root_0, LEFTBRACE87_tree);

            	PushFollow(FOLLOW_variable_in_range1394);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.RANGEVARIABLE = ((e11 != null) ? e11.ret : null);
            	POINT88=(IToken)Match(input,POINT,FOLLOW_POINT_in_range1397); 
            		POINT88_tree = (object)adaptor.Create(POINT88);
            		adaptor.AddChild(root_0, POINT88_tree);

            	PushFollow(FOLLOW_int_literal_in_range1403);
            	e12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.STARTINGRANGE = ((e12 != null) ? e12.ret : null);
            	string_literal89=(IToken)Match(input,40,FOLLOW_40_in_range1406); 
            		string_literal89_tree = (object)adaptor.Create(string_literal89);
            		adaptor.AddChild(root_0, string_literal89_tree);

            	PushFollow(FOLLOW_int_literal_in_range1411);
            	e13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e13.Tree);
            	retval.ret.ENDINGRANGE = ((e13 != null) ? e13.ret : null);
            	RIGHTBRACE90=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_range1414); 
            		RIGHTBRACE90_tree = (object)adaptor.Create(RIGHTBRACE90);
            		adaptor.AddChild(root_0, RIGHTBRACE90_tree);


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
    // $ANTLR end "range"

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
    // spinach.g:248:1: ifelse returns [IfStatementElement ret] : ( 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? ;
    public spinachParser.ifelse_return ifelse() // throws RecognitionException [1]
    {   
        spinachParser.ifelse_return retval = new spinachParser.ifelse_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal91 = null;
        IToken LEFTBRACE92 = null;
        IToken RIGHTBRACE99 = null;
        IToken LEFTPARANTHESIS100 = null;
        IToken RIGHTPARANTHESIS101 = null;
        IToken string_literal102 = null;
        IToken LEFTPARANTHESIS103 = null;
        IToken RIGHTPARANTHESIS104 = null;
        spinachParser.ifloop_return e11 = null;

        spinachParser.ifloop_return e12 = null;

        spinachParser.equality_return equality93 = null;

        spinachParser.nonequality_return nonequality94 = null;

        spinachParser.lessthan_return lessthan95 = null;

        spinachParser.lessthanequalto_return lessthanequalto96 = null;

        spinachParser.greaterthan_return greaterthan97 = null;

        spinachParser.greaterthanequalto_return greaterthanequalto98 = null;


        object string_literal91_tree=null;
        object LEFTBRACE92_tree=null;
        object RIGHTBRACE99_tree=null;
        object LEFTPARANTHESIS100_tree=null;
        object RIGHTPARANTHESIS101_tree=null;
        object string_literal102_tree=null;
        object LEFTPARANTHESIS103_tree=null;
        object RIGHTPARANTHESIS104_tree=null;


           retval.ret = new IfStatementElement();

        try 
    	{
            // spinach.g:252:1: ( ( 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? )
            // spinach.g:252:2: ( 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:252:2: ( 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS )
            	// spinach.g:252:3: 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS
            	{
            		string_literal91=(IToken)Match(input,41,FOLLOW_41_in_ifelse1431); 
            			string_literal91_tree = (object)adaptor.Create(string_literal91);
            			adaptor.AddChild(root_0, string_literal91_tree);

            		LEFTBRACE92=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_ifelse1433); 
            			LEFTBRACE92_tree = (object)adaptor.Create(LEFTBRACE92);
            			adaptor.AddChild(root_0, LEFTBRACE92_tree);

            		// spinach.g:252:18: ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto )
            		int alt25 = 6;
            		int LA25_0 = input.LA(1);

            		if ( (LA25_0 == VARIABLE) )
            		{
            		    switch ( input.LA(2) ) 
            		    {
            		    case EQUALITYEXPRESSION:
            		    	{
            		        alt25 = 1;
            		        }
            		        break;
            		    case NONEQUALITYEXPRESSION:
            		    	{
            		        alt25 = 2;
            		        }
            		        break;
            		    case LESSTHANEQUALTOEXPRESSION:
            		    	{
            		        alt25 = 4;
            		        }
            		        break;
            		    case LESSTHANEXPRESSION:
            		    	{
            		        alt25 = 3;
            		        }
            		        break;
            		    case GREATERTHANEQUALTOEXPRESSION:
            		    	{
            		        alt25 = 6;
            		        }
            		        break;
            		    case GREATERTHANEXPRESSION:
            		    	{
            		        alt25 = 5;
            		        }
            		        break;
            		    	default:
            		    	    NoViableAltException nvae_d25s1 =
            		    	        new NoViableAltException("", 25, 1, input);

            		    	    throw nvae_d25s1;
            		    }

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
            		        // spinach.g:252:19: equality
            		        {
            		        	PushFollow(FOLLOW_equality_in_ifelse1436);
            		        	equality93 = equality();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, equality93.Tree);
            		        	retval.ret.CONDITION = ((equality93 != null) ? equality93.ret : null);

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:252:67: nonequality
            		        {
            		        	PushFollow(FOLLOW_nonequality_in_ifelse1439);
            		        	nonequality94 = nonequality();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, nonequality94.Tree);
            		        	retval.ret.CONDITION = ((nonequality94 != null) ? nonequality94.ret : null);

            		        }
            		        break;
            		    case 3 :
            		        // spinach.g:252:121: lessthan
            		        {
            		        	PushFollow(FOLLOW_lessthan_in_ifelse1442);
            		        	lessthan95 = lessthan();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, lessthan95.Tree);
            		        	retval.ret.CONDITION = ((lessthan95 != null) ? lessthan95.ret : null);

            		        }
            		        break;
            		    case 4 :
            		        // spinach.g:253:4: lessthanequalto
            		        {
            		        	PushFollow(FOLLOW_lessthanequalto_in_ifelse1448);
            		        	lessthanequalto96 = lessthanequalto();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, lessthanequalto96.Tree);
            		        	retval.ret.CONDITION = ((lessthanequalto96 != null) ? lessthanequalto96.ret : null);

            		        }
            		        break;
            		    case 5 :
            		        // spinach.g:253:66: greaterthan
            		        {
            		        	PushFollow(FOLLOW_greaterthan_in_ifelse1451);
            		        	greaterthan97 = greaterthan();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, greaterthan97.Tree);
            		        	retval.ret.CONDITION =((greaterthan97 != null) ? greaterthan97.ret : null);

            		        }
            		        break;
            		    case 6 :
            		        // spinach.g:253:120: greaterthanequalto
            		        {
            		        	PushFollow(FOLLOW_greaterthanequalto_in_ifelse1455);
            		        	greaterthanequalto98 = greaterthanequalto();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, greaterthanequalto98.Tree);
            		        	retval.ret.CONDITION = ((greaterthanequalto98 != null) ? greaterthanequalto98.ret : null);

            		        }
            		        break;

            		}

            		RIGHTBRACE99=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_ifelse1460); 
            			RIGHTBRACE99_tree = (object)adaptor.Create(RIGHTBRACE99);
            			adaptor.AddChild(root_0, RIGHTBRACE99_tree);

            		LEFTPARANTHESIS100=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1462); 
            			LEFTPARANTHESIS100_tree = (object)adaptor.Create(LEFTPARANTHESIS100);
            			adaptor.AddChild(root_0, LEFTPARANTHESIS100_tree);

            		// spinach.g:254:30: ( (e11= ifloop ) | )
            		int alt26 = 2;
            		int LA26_0 = input.LA(1);

            		if ( (LA26_0 == VARIABLE || LA26_0 == VARTYPE || LA26_0 == STRINGTYPE || (LA26_0 >= 28 && LA26_0 <= 29) || LA26_0 == 33 || (LA26_0 >= 36 && LA26_0 <= 38) || LA26_0 == 41 || LA26_0 == 43 || (LA26_0 >= 47 && LA26_0 <= 48) || (LA26_0 >= 52 && LA26_0 <= 56)) )
            		{
            		    alt26 = 1;
            		}
            		else if ( (LA26_0 == RIGHTPARANTHESIS) )
            		{
            		    alt26 = 2;
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
            		        // spinach.g:254:31: (e11= ifloop )
            		        {
            		        	// spinach.g:254:31: (e11= ifloop )
            		        	// spinach.g:254:32: e11= ifloop
            		        	{
            		        		PushFollow(FOLLOW_ifloop_in_ifelse1470);
            		        		e11 = ifloop();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, e11.Tree);
            		        		retval.ret.IFCODE = ((e11 != null) ? e11.ret : null);

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:254:77: 
            		        {
            		        }
            		        break;

            		}

            		RIGHTPARANTHESIS101=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1475); 
            			RIGHTPARANTHESIS101_tree = (object)adaptor.Create(RIGHTPARANTHESIS101);
            			adaptor.AddChild(root_0, RIGHTPARANTHESIS101_tree);


            	}

            	// spinach.g:254:95: ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == 42) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // spinach.g:254:96: 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS
            	        {
            	        	string_literal102=(IToken)Match(input,42,FOLLOW_42_in_ifelse1478); 
            	        		string_literal102_tree = (object)adaptor.Create(string_literal102);
            	        		adaptor.AddChild(root_0, string_literal102_tree);

            	        	LEFTPARANTHESIS103=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1481); 
            	        		LEFTPARANTHESIS103_tree = (object)adaptor.Create(LEFTPARANTHESIS103);
            	        		adaptor.AddChild(root_0, LEFTPARANTHESIS103_tree);

            	        	// spinach.g:254:120: ( (e12= ifloop ) | )
            	        	int alt27 = 2;
            	        	int LA27_0 = input.LA(1);

            	        	if ( (LA27_0 == VARIABLE || LA27_0 == VARTYPE || LA27_0 == STRINGTYPE || (LA27_0 >= 28 && LA27_0 <= 29) || LA27_0 == 33 || (LA27_0 >= 36 && LA27_0 <= 38) || LA27_0 == 41 || LA27_0 == 43 || (LA27_0 >= 47 && LA27_0 <= 48) || (LA27_0 >= 52 && LA27_0 <= 56)) )
            	        	{
            	        	    alt27 = 1;
            	        	}
            	        	else if ( (LA27_0 == RIGHTPARANTHESIS) )
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
            	        	        // spinach.g:254:121: (e12= ifloop )
            	        	        {
            	        	        	// spinach.g:254:121: (e12= ifloop )
            	        	        	// spinach.g:254:122: e12= ifloop
            	        	        	{
            	        	        		PushFollow(FOLLOW_ifloop_in_ifelse1490);
            	        	        		e12 = ifloop();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, e12.Tree);
            	        	        		retval.ret.ELSECODE = ((e12 != null) ? e12.ret : null);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // spinach.g:254:170: 
            	        	        {
            	        	        }
            	        	        break;

            	        	}

            	        	RIGHTPARANTHESIS104=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1496); 
            	        		RIGHTPARANTHESIS104_tree = (object)adaptor.Create(RIGHTPARANTHESIS104);
            	        		adaptor.AddChild(root_0, RIGHTPARANTHESIS104_tree);


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
    // spinach.g:256:1: ifloop returns [List<Element> ret] : ( expr1 | functionreturn )+ ;
    public spinachParser.ifloop_return ifloop() // throws RecognitionException [1]
    {   
        spinachParser.ifloop_return retval = new spinachParser.ifloop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr1105 = null;

        spinachParser.functionreturn_return functionreturn106 = null;




           retval.ret = new List<Element>();

        try 
    	{
            // spinach.g:261:1: ( ( expr1 | functionreturn )+ )
            // spinach.g:261:3: ( expr1 | functionreturn )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:261:3: ( expr1 | functionreturn )+
            	int cnt29 = 0;
            	do 
            	{
            	    int alt29 = 3;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == VARIABLE || LA29_0 == VARTYPE || LA29_0 == STRINGTYPE || (LA29_0 >= 28 && LA29_0 <= 29) || LA29_0 == 33 || (LA29_0 >= 36 && LA29_0 <= 38) || LA29_0 == 41 || LA29_0 == 43 || LA29_0 == 48 || (LA29_0 >= 52 && LA29_0 <= 56)) )
            	    {
            	        alt29 = 1;
            	    }
            	    else if ( (LA29_0 == 47) )
            	    {
            	        alt29 = 2;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // spinach.g:261:4: expr1
            			    {
            			    	PushFollow(FOLLOW_expr1_in_ifloop1517);
            			    	expr1105 = expr1();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr1105.Tree);
            			    	retval.ret.Add(((expr1105 != null) ? expr1105.ret : null));

            			    }
            			    break;
            			case 2 :
            			    // spinach.g:261:39: functionreturn
            			    {
            			    	PushFollow(FOLLOW_functionreturn_in_ifloop1520);
            			    	functionreturn106 = functionreturn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, functionreturn106.Tree);
            			    	retval.ret.Add(((functionreturn106 != null) ? functionreturn106.ret : null));

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
    // spinach.g:265:1: forstatement returns [ForStatementElement ret] : 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS ;
    public spinachParser.forstatement_return forstatement() // throws RecognitionException [1]
    {   
        spinachParser.forstatement_return retval = new spinachParser.forstatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal107 = null;
        IToken LEFTPARANTHESIS108 = null;
        IToken RIGHTPARANTHESIS109 = null;
        spinachParser.range_return r11 = null;

        spinachParser.expr1_return e11 = null;


        object string_literal107_tree=null;
        object LEFTPARANTHESIS108_tree=null;
        object RIGHTPARANTHESIS109_tree=null;


           retval.ret = new ForStatementElement();

        try 
    	{
            // spinach.g:268:2: ( 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS )
            // spinach.g:268:3: 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal107=(IToken)Match(input,43,FOLLOW_43_in_forstatement1539); 
            		string_literal107_tree = (object)adaptor.Create(string_literal107);
            		adaptor.AddChild(root_0, string_literal107_tree);

            	PushFollow(FOLLOW_range_in_forstatement1544);
            	r11 = range();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGE = ((r11 != null) ? r11.ret : null);
            	LEFTPARANTHESIS108=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_forstatement1547); 
            		LEFTPARANTHESIS108_tree = (object)adaptor.Create(LEFTPARANTHESIS108);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS108_tree);

            	// spinach.g:268:66: (e11= expr1 )+
            	int cnt30 = 0;
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == VARIABLE || LA30_0 == VARTYPE || LA30_0 == STRINGTYPE || (LA30_0 >= 28 && LA30_0 <= 29) || LA30_0 == 33 || (LA30_0 >= 36 && LA30_0 <= 38) || LA30_0 == 41 || LA30_0 == 43 || LA30_0 == 48 || (LA30_0 >= 52 && LA30_0 <= 56)) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // spinach.g:268:67: e11= expr1
            			    {
            			    	PushFollow(FOLLOW_expr1_in_forstatement1552);
            			    	e11 = expr1();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e11.Tree);
            			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    }
            			    break;

            			default:
            			    if ( cnt30 >= 1 ) goto loop30;
            		            EarlyExitException eee30 =
            		                new EarlyExitException(30, input);
            		            throw eee30;
            	    }
            	    cnt30++;
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements

            	RIGHTPARANTHESIS109=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_forstatement1557); 
            		RIGHTPARANTHESIS109_tree = (object)adaptor.Create(RIGHTPARANTHESIS109);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS109_tree);


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
    // spinach.g:271:4: functioncall returns [FunctionCallElement ret] : variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT ;
    public spinachParser.functioncall_return functioncall() // throws RecognitionException [1]
    {   
        spinachParser.functioncall_return retval = new spinachParser.functioncall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal111 = null;
        IToken char_literal112 = null;
        IToken char_literal113 = null;
        IToken END_OF_STATEMENT114 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;

        spinachParser.var_int_or_double_literal_return el2 = null;

        spinachParser.variable_return variable110 = null;


        object char_literal111_tree=null;
        object char_literal112_tree=null;
        object char_literal113_tree=null;
        object END_OF_STATEMENT114_tree=null;

         retval.ret = new FunctionCallElement();
         
        try 
    	{
            // spinach.g:274:3: ( variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT )
            // spinach.g:274:4: variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_functioncall1582);
            	variable110 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable110.Tree);
            	retval.ret.setfunctioncallname(((variable110 != null) ? variable110.ret : null));
            	char_literal111=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functioncall1587); 
            		char_literal111_tree = (object)adaptor.Create(char_literal111);
            		adaptor.AddChild(root_0, char_literal111_tree);

            	// spinach.g:275:6: (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )?
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( ((LA32_0 >= VARIABLE && LA32_0 <= DOUBLE_LITERAL)) )
            	{
            	    alt32 = 1;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // spinach.g:275:7: el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )*
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1591);
            	        	el1 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret.setparameters(((el1 != null) ? el1.ret : null));
            	        	// spinach.g:275:74: ( ',' el2= var_int_or_double_literal )*
            	        	do 
            	        	{
            	        	    int alt31 = 2;
            	        	    int LA31_0 = input.LA(1);

            	        	    if ( (LA31_0 == 32) )
            	        	    {
            	        	        alt31 = 1;
            	        	    }


            	        	    switch (alt31) 
            	        		{
            	        			case 1 :
            	        			    // spinach.g:275:75: ',' el2= var_int_or_double_literal
            	        			    {
            	        			    	char_literal112=(IToken)Match(input,32,FOLLOW_32_in_functioncall1595); 
            	        			    		char_literal112_tree = (object)adaptor.Create(char_literal112);
            	        			    		adaptor.AddChild(root_0, char_literal112_tree);

            	        			    	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1599);
            	        			    	el2 = var_int_or_double_literal();
            	        			    	state.followingStackPointer--;

            	        			    	adaptor.AddChild(root_0, el2.Tree);
            	        			    	retval.ret.setparameters(((el2 != null) ? el2.ret : null));

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop31;
            	        	    }
            	        	} while (true);

            	        	loop31:
            	        		;	// Stops C# compiler whining that label 'loop31' has no statements


            	        }
            	        break;

            	}

            	char_literal113=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functioncall1606); 
            		char_literal113_tree = (object)adaptor.Create(char_literal113);
            		adaptor.AddChild(root_0, char_literal113_tree);

            	END_OF_STATEMENT114=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functioncall1610); 
            		END_OF_STATEMENT114_tree = (object)adaptor.Create(END_OF_STATEMENT114);
            		adaptor.AddChild(root_0, END_OF_STATEMENT114_tree);


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

    public class equality_return : ParserRuleReturnScope
    {
        public EqualityOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "equality"
    // spinach.g:280:1: equality returns [EqualityOperationElement ret] : e11= variable EQUALITYEXPRESSION var_int_or_double_literal ;
    public spinachParser.equality_return equality() // throws RecognitionException [1]
    {   
        spinachParser.equality_return retval = new spinachParser.equality_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQUALITYEXPRESSION115 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return var_int_or_double_literal116 = null;


        object EQUALITYEXPRESSION115_tree=null;


          retval.ret = new EqualityOperationElement();

        try 
    	{
            // spinach.g:286:1: (e11= variable EQUALITYEXPRESSION var_int_or_double_literal )
            // spinach.g:286:3: e11= variable EQUALITYEXPRESSION var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_equality1639);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setequalityLhs(((e11 != null) ? e11.ret : null)); 
            	EQUALITYEXPRESSION115=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_equality1648); 
            		EQUALITYEXPRESSION115_tree = (object)adaptor.Create(EQUALITYEXPRESSION115);
            		adaptor.AddChild(root_0, EQUALITYEXPRESSION115_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_equality1658);
            	var_int_or_double_literal116 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal116.Tree);
            	retval.ret.setequalityRhs(((var_int_or_double_literal116 != null) ? var_int_or_double_literal116.ret : null)); 

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
    // $ANTLR end "equality"

    public class nonequality_return : ParserRuleReturnScope
    {
        public NonEqualityOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "nonequality"
    // spinach.g:292:1: nonequality returns [NonEqualityOperationElement ret] : e11= variable NONEQUALITYEXPRESSION var_int_or_double_literal ;
    public spinachParser.nonequality_return nonequality() // throws RecognitionException [1]
    {   
        spinachParser.nonequality_return retval = new spinachParser.nonequality_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NONEQUALITYEXPRESSION117 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return var_int_or_double_literal118 = null;


        object NONEQUALITYEXPRESSION117_tree=null;


          retval.ret = new NonEqualityOperationElement();

        try 
    	{
            // spinach.g:298:1: (e11= variable NONEQUALITYEXPRESSION var_int_or_double_literal )
            // spinach.g:298:3: e11= variable NONEQUALITYEXPRESSION var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_nonequality1701);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setnonequalityLhs(((e11 != null) ? e11.ret : null)); 
            	NONEQUALITYEXPRESSION117=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_nonequality1710); 
            		NONEQUALITYEXPRESSION117_tree = (object)adaptor.Create(NONEQUALITYEXPRESSION117);
            		adaptor.AddChild(root_0, NONEQUALITYEXPRESSION117_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_nonequality1715);
            	var_int_or_double_literal118 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal118.Tree);
            	retval.ret.setnonequalityRhs(((var_int_or_double_literal118 != null) ? var_int_or_double_literal118.ret : null)); 

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
    // $ANTLR end "nonequality"

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
    // spinach.g:304:1: functiondefination returns [FunctionElement ret] : ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' );
    public spinachParser.functiondefination_return functiondefination() // throws RecognitionException [1]
    {   
        spinachParser.functiondefination_return retval = new spinachParser.functiondefination_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE119 = null;
        IToken char_literal121 = null;
        IToken char_literal122 = null;
        IToken char_literal123 = null;
        IToken char_literal124 = null;
        IToken char_literal136 = null;
        IToken string_literal137 = null;
        IToken char_literal139 = null;
        IToken char_literal140 = null;
        IToken char_literal141 = null;
        IToken char_literal142 = null;
        IToken char_literal154 = null;
        spinachParser.arguments_return e11 = null;

        spinachParser.arguments_return e12 = null;

        spinachParser.variable_return variable120 = null;

        spinachParser.assignment_return assignment125 = null;

        spinachParser.functioncall_return functioncall126 = null;

        spinachParser.scalarvardec_return scalarvardec127 = null;

        spinachParser.vectorvardec_return vectorvardec128 = null;

        spinachParser.matrixvardec_return matrixvardec129 = null;

        spinachParser.deletionofvar_return deletionofvar130 = null;

        spinachParser.print_return print131 = null;

        spinachParser.ifelse_return ifelse132 = null;

        spinachParser.functionreturn_return functionreturn133 = null;

        spinachParser.parallelfor_return parallelfor134 = null;

        spinachParser.forstatement_return forstatement135 = null;

        spinachParser.variable_return variable138 = null;

        spinachParser.assignment_return assignment143 = null;

        spinachParser.functioncall_return functioncall144 = null;

        spinachParser.scalarvardec_return scalarvardec145 = null;

        spinachParser.vectorvardec_return vectorvardec146 = null;

        spinachParser.matrixvardec_return matrixvardec147 = null;

        spinachParser.deletionofvar_return deletionofvar148 = null;

        spinachParser.print_return print149 = null;

        spinachParser.ifelse_return ifelse150 = null;

        spinachParser.functionreturn_return functionreturn151 = null;

        spinachParser.parallelfor_return parallelfor152 = null;

        spinachParser.forstatement_return forstatement153 = null;


        object VARTYPE119_tree=null;
        object char_literal121_tree=null;
        object char_literal122_tree=null;
        object char_literal123_tree=null;
        object char_literal124_tree=null;
        object char_literal136_tree=null;
        object string_literal137_tree=null;
        object char_literal139_tree=null;
        object char_literal140_tree=null;
        object char_literal141_tree=null;
        object char_literal142_tree=null;
        object char_literal154_tree=null;


        retval.ret = new FunctionElement();

        try 
    	{
            // spinach.g:309:1: ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' )
            int alt39 = 2;
            int LA39_0 = input.LA(1);

            if ( (LA39_0 == VARTYPE) )
            {
                alt39 = 1;
            }
            else if ( (LA39_0 == 44) )
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
                    // spinach.g:309:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:309:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' )
                    	// spinach.g:309:4: VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}'
                    	{
                    		VARTYPE119=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_functiondefination1747); 
                    			VARTYPE119_tree = (object)adaptor.Create(VARTYPE119);
                    			adaptor.AddChild(root_0, VARTYPE119_tree);

                    		retval.ret.setreturntype(((VARTYPE119 != null) ? VARTYPE119.Text : null));
                    		PushFollow(FOLLOW_variable_in_functiondefination1752);
                    		variable120 = variable();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, variable120.Tree);
                    		retval.ret.setfunctionname(((variable120 != null) ? variable120.ret : null));
                    		char_literal121=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1758); 
                    			char_literal121_tree = (object)adaptor.Create(char_literal121);
                    			adaptor.AddChild(root_0, char_literal121_tree);

                    		// spinach.g:312:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    		// spinach.g:312:3: (e11= arguments ( ',' e12= arguments )* )?
                    		{
                    			// spinach.g:312:3: (e11= arguments ( ',' e12= arguments )* )?
                    			int alt34 = 2;
                    			int LA34_0 = input.LA(1);

                    			if ( (LA34_0 == VARTYPE || LA34_0 == 29 || LA34_0 == 33) )
                    			{
                    			    alt34 = 1;
                    			}
                    			switch (alt34) 
                    			{
                    			    case 1 :
                    			        // spinach.g:312:4: e11= arguments ( ',' e12= arguments )*
                    			        {
                    			        	PushFollow(FOLLOW_arguments_in_functiondefination1766);
                    			        	e11 = arguments();
                    			        	state.followingStackPointer--;

                    			        	adaptor.AddChild(root_0, e11.Tree);
                    			        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    			        	// spinach.g:312:54: ( ',' e12= arguments )*
                    			        	do 
                    			        	{
                    			        	    int alt33 = 2;
                    			        	    int LA33_0 = input.LA(1);

                    			        	    if ( (LA33_0 == 32) )
                    			        	    {
                    			        	        alt33 = 1;
                    			        	    }


                    			        	    switch (alt33) 
                    			        		{
                    			        			case 1 :
                    			        			    // spinach.g:312:55: ',' e12= arguments
                    			        			    {
                    			        			    	char_literal122=(IToken)Match(input,32,FOLLOW_32_in_functiondefination1769); 
                    			        			    		char_literal122_tree = (object)adaptor.Create(char_literal122);
                    			        			    		adaptor.AddChild(root_0, char_literal122_tree);

                    			        			    	PushFollow(FOLLOW_arguments_in_functiondefination1774);
                    			        			    	e12 = arguments();
                    			        			    	state.followingStackPointer--;

                    			        			    	adaptor.AddChild(root_0, e12.Tree);
                    			        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    			        			    }
                    			        			    break;

                    			        			default:
                    			        			    goto loop33;
                    			        	    }
                    			        	} while (true);

                    			        	loop33:
                    			        		;	// Stops C# compiler whining that label 'loop33' has no statements


                    			        }
                    			        break;

                    			}


                    		}

                    		char_literal123=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1783); 
                    			char_literal123_tree = (object)adaptor.Create(char_literal123);
                    			adaptor.AddChild(root_0, char_literal123_tree);

                    		char_literal124=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1785); 
                    			char_literal124_tree = (object)adaptor.Create(char_literal124);
                    			adaptor.AddChild(root_0, char_literal124_tree);

                    		// spinach.g:314:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    		int cnt35 = 0;
                    		do 
                    		{
                    		    int alt35 = 12;
                    		    alt35 = dfa35.Predict(input);
                    		    switch (alt35) 
                    			{
                    				case 1 :
                    				    // spinach.g:314:6: assignment
                    				    {
                    				    	PushFollow(FOLLOW_assignment_in_functiondefination1788);
                    				    	assignment125 = assignment();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, assignment125.Tree);
                    				    	retval.ret.setBody(((assignment125 != null) ? assignment125.ret : null));

                    				    }
                    				    break;
                    				case 2 :
                    				    // spinach.g:314:55: functioncall
                    				    {
                    				    	PushFollow(FOLLOW_functioncall_in_functiondefination1791);
                    				    	functioncall126 = functioncall();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, functioncall126.Tree);
                    				    	retval.ret.setBody(((functioncall126 != null) ? functioncall126.ret : null));

                    				    }
                    				    break;
                    				case 3 :
                    				    // spinach.g:314:109: scalarvardec
                    				    {
                    				    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1795);
                    				    	scalarvardec127 = scalarvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, scalarvardec127.Tree);
                    				    	 retval.ret.setBody(((scalarvardec127 != null) ? scalarvardec127.ret : null));

                    				    }
                    				    break;
                    				case 4 :
                    				    // spinach.g:315:5: vectorvardec
                    				    {
                    				    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1803);
                    				    	vectorvardec128 = vectorvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, vectorvardec128.Tree);
                    				    	 retval.ret.setBody(((vectorvardec128 != null) ? vectorvardec128.ret : null));

                    				    }
                    				    break;
                    				case 5 :
                    				    // spinach.g:316:5: matrixvardec
                    				    {
                    				    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1811);
                    				    	matrixvardec129 = matrixvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, matrixvardec129.Tree);
                    				    	 retval.ret.setBody(((matrixvardec129 != null) ? matrixvardec129.ret : null));

                    				    }
                    				    break;
                    				case 6 :
                    				    // spinach.g:317:5: deletionofvar
                    				    {
                    				    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1819);
                    				    	deletionofvar130 = deletionofvar();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, deletionofvar130.Tree);
                    				    	 retval.ret.setBody(((deletionofvar130 != null) ? deletionofvar130.ret : null));

                    				    }
                    				    break;
                    				case 7 :
                    				    // spinach.g:317:64: print
                    				    {
                    				    	PushFollow(FOLLOW_print_in_functiondefination1825);
                    				    	print131 = print();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, print131.Tree);
                    				    	 retval.ret.setBody(((print131 != null) ? print131.ret : null)); 

                    				    }
                    				    break;
                    				case 8 :
                    				    // spinach.g:318:5: ifelse
                    				    {
                    				    	PushFollow(FOLLOW_ifelse_in_functiondefination1833);
                    				    	ifelse132 = ifelse();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, ifelse132.Tree);
                    				    	retval.ret.setBody(((ifelse132 != null) ? ifelse132.ret : null));

                    				    }
                    				    break;
                    				case 9 :
                    				    // spinach.g:318:47: functionreturn
                    				    {
                    				    	PushFollow(FOLLOW_functionreturn_in_functiondefination1837);
                    				    	functionreturn133 = functionreturn();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, functionreturn133.Tree);
                    				    	retval.ret.setBody(((functionreturn133 != null) ? functionreturn133.ret : null));

                    				    }
                    				    break;
                    				case 10 :
                    				    // spinach.g:318:105: parallelfor
                    				    {
                    				    	PushFollow(FOLLOW_parallelfor_in_functiondefination1841);
                    				    	parallelfor134 = parallelfor();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, parallelfor134.Tree);
                    				    	retval.ret.setBody(((parallelfor134 != null) ? parallelfor134.ret : null));

                    				    }
                    				    break;
                    				case 11 :
                    				    // spinach.g:318:157: forstatement
                    				    {
                    				    	PushFollow(FOLLOW_forstatement_in_functiondefination1845);
                    				    	forstatement135 = forstatement();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, forstatement135.Tree);
                    				    	retval.ret.setBody(((forstatement135 != null) ? forstatement135.ret : null));

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

                    		char_literal136=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1850); 
                    			char_literal136_tree = (object)adaptor.Create(char_literal136);
                    			adaptor.AddChild(root_0, char_literal136_tree);


                    	}


                    }
                    break;
                case 2 :
                    // spinach.g:319:6: 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal137=(IToken)Match(input,44,FOLLOW_44_in_functiondefination1853); 
                    		string_literal137_tree = (object)adaptor.Create(string_literal137);
                    		adaptor.AddChild(root_0, string_literal137_tree);

                    	retval.ret.setreturntype("void");
                    	PushFollow(FOLLOW_variable_in_functiondefination1858);
                    	variable138 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable138.Tree);
                    	retval.ret.setfunctionname(((variable138 != null) ? variable138.ret : null));
                    	char_literal139=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1864); 
                    		char_literal139_tree = (object)adaptor.Create(char_literal139);
                    		adaptor.AddChild(root_0, char_literal139_tree);

                    	// spinach.g:322:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    	// spinach.g:322:3: (e11= arguments ( ',' e12= arguments )* )?
                    	{
                    		// spinach.g:322:3: (e11= arguments ( ',' e12= arguments )* )?
                    		int alt37 = 2;
                    		int LA37_0 = input.LA(1);

                    		if ( (LA37_0 == VARTYPE || LA37_0 == 29 || LA37_0 == 33) )
                    		{
                    		    alt37 = 1;
                    		}
                    		switch (alt37) 
                    		{
                    		    case 1 :
                    		        // spinach.g:322:4: e11= arguments ( ',' e12= arguments )*
                    		        {
                    		        	PushFollow(FOLLOW_arguments_in_functiondefination1873);
                    		        	e11 = arguments();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, e11.Tree);
                    		        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    		        	// spinach.g:322:55: ( ',' e12= arguments )*
                    		        	do 
                    		        	{
                    		        	    int alt36 = 2;
                    		        	    int LA36_0 = input.LA(1);

                    		        	    if ( (LA36_0 == 32) )
                    		        	    {
                    		        	        alt36 = 1;
                    		        	    }


                    		        	    switch (alt36) 
                    		        		{
                    		        			case 1 :
                    		        			    // spinach.g:322:56: ',' e12= arguments
                    		        			    {
                    		        			    	char_literal140=(IToken)Match(input,32,FOLLOW_32_in_functiondefination1876); 
                    		        			    		char_literal140_tree = (object)adaptor.Create(char_literal140);
                    		        			    		adaptor.AddChild(root_0, char_literal140_tree);

                    		        			    	PushFollow(FOLLOW_arguments_in_functiondefination1880);
                    		        			    	e12 = arguments();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, e12.Tree);
                    		        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    goto loop36;
                    		        	    }
                    		        	} while (true);

                    		        	loop36:
                    		        		;	// Stops C# compiler whining that label 'loop36' has no statements


                    		        }
                    		        break;

                    		}


                    	}

                    	char_literal141=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1889); 
                    		char_literal141_tree = (object)adaptor.Create(char_literal141);
                    		adaptor.AddChild(root_0, char_literal141_tree);

                    	char_literal142=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1891); 
                    		char_literal142_tree = (object)adaptor.Create(char_literal142);
                    		adaptor.AddChild(root_0, char_literal142_tree);

                    	// spinach.g:324:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    	int cnt38 = 0;
                    	do 
                    	{
                    	    int alt38 = 12;
                    	    alt38 = dfa38.Predict(input);
                    	    switch (alt38) 
                    		{
                    			case 1 :
                    			    // spinach.g:324:6: assignment
                    			    {
                    			    	PushFollow(FOLLOW_assignment_in_functiondefination1894);
                    			    	assignment143 = assignment();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, assignment143.Tree);
                    			    	retval.ret.setBody(((assignment143 != null) ? assignment143.ret : null));

                    			    }
                    			    break;
                    			case 2 :
                    			    // spinach.g:324:55: functioncall
                    			    {
                    			    	PushFollow(FOLLOW_functioncall_in_functiondefination1897);
                    			    	functioncall144 = functioncall();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, functioncall144.Tree);
                    			    	retval.ret.setBody(((functioncall144 != null) ? functioncall144.ret : null));

                    			    }
                    			    break;
                    			case 3 :
                    			    // spinach.g:324:109: scalarvardec
                    			    {
                    			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1901);
                    			    	scalarvardec145 = scalarvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, scalarvardec145.Tree);
                    			    	 retval.ret.setBody(((scalarvardec145 != null) ? scalarvardec145.ret : null));

                    			    }
                    			    break;
                    			case 4 :
                    			    // spinach.g:325:5: vectorvardec
                    			    {
                    			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1909);
                    			    	vectorvardec146 = vectorvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, vectorvardec146.Tree);
                    			    	 retval.ret.setBody(((vectorvardec146 != null) ? vectorvardec146.ret : null));

                    			    }
                    			    break;
                    			case 5 :
                    			    // spinach.g:326:5: matrixvardec
                    			    {
                    			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1917);
                    			    	matrixvardec147 = matrixvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, matrixvardec147.Tree);
                    			    	 retval.ret.setBody(((matrixvardec147 != null) ? matrixvardec147.ret : null));

                    			    }
                    			    break;
                    			case 6 :
                    			    // spinach.g:327:5: deletionofvar
                    			    {
                    			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1925);
                    			    	deletionofvar148 = deletionofvar();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, deletionofvar148.Tree);
                    			    	 retval.ret.setBody(((deletionofvar148 != null) ? deletionofvar148.ret : null));

                    			    }
                    			    break;
                    			case 7 :
                    			    // spinach.g:327:64: print
                    			    {
                    			    	PushFollow(FOLLOW_print_in_functiondefination1931);
                    			    	print149 = print();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, print149.Tree);
                    			    	 retval.ret.setBody(((print149 != null) ? print149.ret : null)); 

                    			    }
                    			    break;
                    			case 8 :
                    			    // spinach.g:328:5: ifelse
                    			    {
                    			    	PushFollow(FOLLOW_ifelse_in_functiondefination1939);
                    			    	ifelse150 = ifelse();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, ifelse150.Tree);
                    			    	retval.ret.setBody(((ifelse150 != null) ? ifelse150.ret : null));

                    			    }
                    			    break;
                    			case 9 :
                    			    // spinach.g:328:47: functionreturn
                    			    {
                    			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1943);
                    			    	functionreturn151 = functionreturn();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, functionreturn151.Tree);
                    			    	retval.ret.setBody(((functionreturn151 != null) ? functionreturn151.ret : null));

                    			    }
                    			    break;
                    			case 10 :
                    			    // spinach.g:328:105: parallelfor
                    			    {
                    			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1947);
                    			    	parallelfor152 = parallelfor();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, parallelfor152.Tree);
                    			    	retval.ret.setBody(((parallelfor152 != null) ? parallelfor152.ret : null));

                    			    }
                    			    break;
                    			case 11 :
                    			    // spinach.g:328:157: forstatement
                    			    {
                    			    	PushFollow(FOLLOW_forstatement_in_functiondefination1951);
                    			    	forstatement153 = forstatement();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, forstatement153.Tree);
                    			    	retval.ret.setBody(((forstatement153 != null) ? forstatement153.ret : null));

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
                    		;	// Stops C# compiler whining that label 'loop38' has no statements

                    	char_literal154=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1956); 
                    		char_literal154_tree = (object)adaptor.Create(char_literal154);
                    		adaptor.AddChild(root_0, char_literal154_tree);


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

    public class lessthan_return : ParserRuleReturnScope
    {
        public LessThanElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lessthan"
    // spinach.g:331:1: lessthan returns [LessThanElement ret] : e11= variable LESSTHANEXPRESSION e12= var_int_or_double_literal ;
    public spinachParser.lessthan_return lessthan() // throws RecognitionException [1]
    {   
        spinachParser.lessthan_return retval = new spinachParser.lessthan_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSTHANEXPRESSION155 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return e12 = null;


        object LESSTHANEXPRESSION155_tree=null;


        	retval.ret = new LessThanElement();

        try 
    	{
            // spinach.g:335:1: (e11= variable LESSTHANEXPRESSION e12= var_int_or_double_literal )
            // spinach.g:335:3: e11= variable LESSTHANEXPRESSION e12= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_lessthan1976);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLessThanLhs(((e11 != null) ? e11.ret : null));
            	LESSTHANEXPRESSION155=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_lessthan1979); 
            		LESSTHANEXPRESSION155_tree = (object)adaptor.Create(LESSTHANEXPRESSION155);
            		adaptor.AddChild(root_0, LESSTHANEXPRESSION155_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_lessthan1984);
            	e12 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.setLessThanRhs(((e12 != null) ? e12.ret : null));

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
    // $ANTLR end "lessthan"

    public class greaterthan_return : ParserRuleReturnScope
    {
        public GreaterThanElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "greaterthan"
    // spinach.g:338:1: greaterthan returns [GreaterThanElement ret] : e11= variable GREATERTHANEXPRESSION e12= var_int_or_double_literal ;
    public spinachParser.greaterthan_return greaterthan() // throws RecognitionException [1]
    {   
        spinachParser.greaterthan_return retval = new spinachParser.greaterthan_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken GREATERTHANEXPRESSION156 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return e12 = null;


        object GREATERTHANEXPRESSION156_tree=null;


        	retval.ret = new GreaterThanElement();

        try 
    	{
            // spinach.g:342:1: (e11= variable GREATERTHANEXPRESSION e12= var_int_or_double_literal )
            // spinach.g:342:3: e11= variable GREATERTHANEXPRESSION e12= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_greaterthan2006);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setGreaterThanLhs(((e11 != null) ? e11.ret : null));
            	GREATERTHANEXPRESSION156=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_greaterthan2009); 
            		GREATERTHANEXPRESSION156_tree = (object)adaptor.Create(GREATERTHANEXPRESSION156);
            		adaptor.AddChild(root_0, GREATERTHANEXPRESSION156_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_greaterthan2014);
            	e12 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.setGreaterThanRhs(((e12 != null) ? e12.ret : null));

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
    // $ANTLR end "greaterthan"

    public class lessthanequalto_return : ParserRuleReturnScope
    {
        public LessThanEqualToElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lessthanequalto"
    // spinach.g:345:1: lessthanequalto returns [LessThanEqualToElement ret] : e11= variable LESSTHANEQUALTOEXPRESSION e12= var_int_or_double_literal ;
    public spinachParser.lessthanequalto_return lessthanequalto() // throws RecognitionException [1]
    {   
        spinachParser.lessthanequalto_return retval = new spinachParser.lessthanequalto_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSTHANEQUALTOEXPRESSION157 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return e12 = null;


        object LESSTHANEQUALTOEXPRESSION157_tree=null;


        	retval.ret = new LessThanEqualToElement();

        try 
    	{
            // spinach.g:349:1: (e11= variable LESSTHANEQUALTOEXPRESSION e12= var_int_or_double_literal )
            // spinach.g:349:3: e11= variable LESSTHANEQUALTOEXPRESSION e12= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_lessthanequalto2036);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLessThanEqualToLhs(((e11 != null) ? e11.ret : null));
            	LESSTHANEQUALTOEXPRESSION157=(IToken)Match(input,LESSTHANEQUALTOEXPRESSION,FOLLOW_LESSTHANEQUALTOEXPRESSION_in_lessthanequalto2039); 
            		LESSTHANEQUALTOEXPRESSION157_tree = (object)adaptor.Create(LESSTHANEQUALTOEXPRESSION157);
            		adaptor.AddChild(root_0, LESSTHANEQUALTOEXPRESSION157_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_lessthanequalto2045);
            	e12 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.setLessThanEqualToRhs(((e12 != null) ? e12.ret : null));

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
    // $ANTLR end "lessthanequalto"

    public class greaterthanequalto_return : ParserRuleReturnScope
    {
        public GreaterThanEqualToElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "greaterthanequalto"
    // spinach.g:352:1: greaterthanequalto returns [GreaterThanEqualToElement ret] : e11= variable GREATERTHANEQUALTOEXPRESSION e12= var_int_or_double_literal ;
    public spinachParser.greaterthanequalto_return greaterthanequalto() // throws RecognitionException [1]
    {   
        spinachParser.greaterthanequalto_return retval = new spinachParser.greaterthanequalto_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken GREATERTHANEQUALTOEXPRESSION158 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return e12 = null;


        object GREATERTHANEQUALTOEXPRESSION158_tree=null;


        	retval.ret = new GreaterThanEqualToElement();

        try 
    	{
            // spinach.g:356:1: (e11= variable GREATERTHANEQUALTOEXPRESSION e12= var_int_or_double_literal )
            // spinach.g:356:3: e11= variable GREATERTHANEQUALTOEXPRESSION e12= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_greaterthanequalto2067);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setGreaterThanEqualToLhs(((e11 != null) ? e11.ret : null));
            	GREATERTHANEQUALTOEXPRESSION158=(IToken)Match(input,GREATERTHANEQUALTOEXPRESSION,FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_greaterthanequalto2070); 
            		GREATERTHANEQUALTOEXPRESSION158_tree = (object)adaptor.Create(GREATERTHANEQUALTOEXPRESSION158);
            		adaptor.AddChild(root_0, GREATERTHANEQUALTOEXPRESSION158_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_greaterthanequalto2076);
            	e12 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.setGreaterThanEqualToRhs(((e12 != null) ? e12.ret : null));

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
    // $ANTLR end "greaterthanequalto"

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
    // spinach.g:360:1: dotproduct returns [DotProductElement ret] : e11= variable 'DOT' e12= variable ;
    public spinachParser.dotproduct_return dotproduct() // throws RecognitionException [1]
    {   
        spinachParser.dotproduct_return retval = new spinachParser.dotproduct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal159 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.variable_return e12 = null;


        object string_literal159_tree=null;


        retval.ret = new DotProductElement ();

        try 
    	{
            // spinach.g:364:1: (e11= variable 'DOT' e12= variable )
            // spinach.g:364:3: e11= variable 'DOT' e12= variable
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_dotproduct2099);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLhs(((e11 != null) ? e11.ret : null)); 
            	string_literal159=(IToken)Match(input,45,FOLLOW_45_in_dotproduct2103); 
            		string_literal159_tree = (object)adaptor.Create(string_literal159);
            		adaptor.AddChild(root_0, string_literal159_tree);

            	PushFollow(FOLLOW_variable_in_dotproduct2109);
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
    // spinach.g:366:1: matrixtranspose returns [MatrixTranspose ret] : 'T' LEFTBRACE variable ')' ;
    public spinachParser.matrixtranspose_return matrixtranspose() // throws RecognitionException [1]
    {   
        spinachParser.matrixtranspose_return retval = new spinachParser.matrixtranspose_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal160 = null;
        IToken LEFTBRACE161 = null;
        IToken char_literal163 = null;
        spinachParser.variable_return variable162 = null;


        object char_literal160_tree=null;
        object LEFTBRACE161_tree=null;
        object char_literal163_tree=null;


        retval.ret = new MatrixTranspose();

        try 
    	{
            // spinach.g:371:1: ( 'T' LEFTBRACE variable ')' )
            // spinach.g:371:3: 'T' LEFTBRACE variable ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal160=(IToken)Match(input,46,FOLLOW_46_in_matrixtranspose2128); 
            		char_literal160_tree = (object)adaptor.Create(char_literal160);
            		adaptor.AddChild(root_0, char_literal160_tree);

            	LEFTBRACE161=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_matrixtranspose2130); 
            		LEFTBRACE161_tree = (object)adaptor.Create(LEFTBRACE161);
            		adaptor.AddChild(root_0, LEFTBRACE161_tree);

            	PushFollow(FOLLOW_variable_in_matrixtranspose2132);
            	variable162 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable162.Tree);
            	retval.ret.setvariable(((variable162 != null) ? variable162.ret : null)); 
            	char_literal163=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_matrixtranspose2135); 
            		char_literal163_tree = (object)adaptor.Create(char_literal163);
            		adaptor.AddChild(root_0, char_literal163_tree);


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
    // spinach.g:374:1: matrixreference returns [MatrixReference ret] : 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.matrixreference_return matrixreference() // throws RecognitionException [1]
    {   
        spinachParser.matrixreference_return retval = new spinachParser.matrixreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal164 = null;
        IToken char_literal165 = null;
        IToken char_literal166 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal164_tree=null;
        object char_literal165_tree=null;
        object char_literal166_tree=null;

         retval.ret = new MatrixReference();

        try 
    	{
            // spinach.g:377:1: ( 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) )
            // spinach.g:377:2: 'Matrix' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal164=(IToken)Match(input,29,FOLLOW_29_in_matrixreference2151); 
            		string_literal164_tree = (object)adaptor.Create(string_literal164);
            		adaptor.AddChild(root_0, string_literal164_tree);

            	char_literal165=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixreference2153); 
            		char_literal165_tree = (object)adaptor.Create(char_literal165);
            		adaptor.AddChild(root_0, char_literal165_tree);

            	// spinach.g:377:15: (el1= VARTYPE '>' el2= variable )
            	// spinach.g:377:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixreference2158); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal166=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixreference2160); 
            			char_literal166_tree = (object)adaptor.Create(char_literal166);
            			adaptor.AddChild(root_0, char_literal166_tree);

            		PushFollow(FOLLOW_variable_in_matrixreference2164);
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
    // spinach.g:380:1: vectorreference returns [VectorReference ret] : 'Vector' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.vectorreference_return vectorreference() // throws RecognitionException [1]
    {   
        spinachParser.vectorreference_return retval = new spinachParser.vectorreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal167 = null;
        IToken char_literal168 = null;
        IToken char_literal169 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal167_tree=null;
        object char_literal168_tree=null;
        object char_literal169_tree=null;

         retval.ret = new VectorReference();

        try 
    	{
            // spinach.g:383:1: ( 'Vector' '<' (el1= VARTYPE '>' el2= variable ) )
            // spinach.g:383:2: 'Vector' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal167=(IToken)Match(input,33,FOLLOW_33_in_vectorreference2183); 
            		string_literal167_tree = (object)adaptor.Create(string_literal167);
            		adaptor.AddChild(root_0, string_literal167_tree);

            	char_literal168=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorreference2185); 
            		char_literal168_tree = (object)adaptor.Create(char_literal168);
            		adaptor.AddChild(root_0, char_literal168_tree);

            	// spinach.g:383:15: (el1= VARTYPE '>' el2= variable )
            	// spinach.g:383:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorreference2190); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal169=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2192); 
            			char_literal169_tree = (object)adaptor.Create(char_literal169);
            			adaptor.AddChild(root_0, char_literal169_tree);

            		PushFollow(FOLLOW_variable_in_vectorreference2196);
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
    // spinach.g:385:1: arguments returns [Element ret] : ( scalarargument | matrixreference | vectorreference ) ;
    public spinachParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        spinachParser.arguments_return retval = new spinachParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.scalarargument_return scalarargument170 = null;

        spinachParser.matrixreference_return matrixreference171 = null;

        spinachParser.vectorreference_return vectorreference172 = null;



        try 
    	{
            // spinach.g:386:1: ( ( scalarargument | matrixreference | vectorreference ) )
            // spinach.g:386:3: ( scalarargument | matrixreference | vectorreference )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:386:3: ( scalarargument | matrixreference | vectorreference )
            	int alt40 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARTYPE:
            		{
            	    alt40 = 1;
            	    }
            	    break;
            	case 29:
            		{
            	    alt40 = 2;
            	    }
            	    break;
            	case 33:
            		{
            	    alt40 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d40s0 =
            		        new NoViableAltException("", 40, 0, input);

            		    throw nvae_d40s0;
            	}

            	switch (alt40) 
            	{
            	    case 1 :
            	        // spinach.g:386:4: scalarargument
            	        {
            	        	PushFollow(FOLLOW_scalarargument_in_arguments2212);
            	        	scalarargument170 = scalarargument();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, scalarargument170.Tree);
            	        	 retval.ret = ((scalarargument170 != null) ? scalarargument170.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:387:3: matrixreference
            	        {
            	        	PushFollow(FOLLOW_matrixreference_in_arguments2218);
            	        	matrixreference171 = matrixreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixreference171.Tree);
            	        	retval.ret = ((matrixreference171 != null) ? matrixreference171.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:388:3: vectorreference
            	        {
            	        	PushFollow(FOLLOW_vectorreference_in_arguments2224);
            	        	vectorreference172 = vectorreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorreference172.Tree);
            	        	retval.ret = ((vectorreference172 != null) ? vectorreference172.ret : null);

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
    // spinach.g:391:1: scalarargument returns [ScalarArgument ret] : ( (e11= VARTYPE ) e12= variable ) ;
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
            // spinach.g:393:2: ( ( (e11= VARTYPE ) e12= variable ) )
            // spinach.g:394:1: ( (e11= VARTYPE ) e12= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:394:1: ( (e11= VARTYPE ) e12= variable )
            	// spinach.g:394:2: (e11= VARTYPE ) e12= variable
            	{
            		// spinach.g:394:2: (e11= VARTYPE )
            		// spinach.g:394:3: e11= VARTYPE
            		{
            			e11=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarargument2248); 
            				e11_tree = (object)adaptor.Create(e11);
            				adaptor.AddChild(root_0, e11_tree);

            			retval.ret.settype(((e11 != null) ? e11.Text : null));

            		}

            		PushFollow(FOLLOW_variable_in_scalarargument2255);
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
    // spinach.g:401:1: functionreturn returns [ReturnElement ret] : 'return' ( var_int_or_double_literal ) END_OF_STATEMENT ;
    public spinachParser.functionreturn_return functionreturn() // throws RecognitionException [1]
    {   
        spinachParser.functionreturn_return retval = new spinachParser.functionreturn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal173 = null;
        IToken END_OF_STATEMENT175 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal174 = null;


        object string_literal173_tree=null;
        object END_OF_STATEMENT175_tree=null;


        retval.ret = new ReturnElement();

        try 
    	{
            // spinach.g:405:1: ( 'return' ( var_int_or_double_literal ) END_OF_STATEMENT )
            // spinach.g:405:2: 'return' ( var_int_or_double_literal ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal173=(IToken)Match(input,47,FOLLOW_47_in_functionreturn2277); 
            		string_literal173_tree = (object)adaptor.Create(string_literal173);
            		adaptor.AddChild(root_0, string_literal173_tree);

            	// spinach.g:405:11: ( var_int_or_double_literal )
            	// spinach.g:405:12: var_int_or_double_literal
            	{
            		PushFollow(FOLLOW_var_int_or_double_literal_in_functionreturn2280);
            		var_int_or_double_literal174 = var_int_or_double_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, var_int_or_double_literal174.Tree);
            		retval.ret.setreturnvariable(((var_int_or_double_literal174 != null) ? var_int_or_double_literal174.ret : null));

            	}

            	END_OF_STATEMENT175=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functionreturn2284); 
            		END_OF_STATEMENT175_tree = (object)adaptor.Create(END_OF_STATEMENT175);
            		adaptor.AddChild(root_0, END_OF_STATEMENT175_tree);


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
    // spinach.g:411:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );
    public spinachParser.plotfunctions_return plotfunctions() // throws RecognitionException [1]
    {   
        spinachParser.plotfunctions_return retval = new spinachParser.plotfunctions_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal176 = null;
        IToken char_literal177 = null;
        IToken char_literal178 = null;
        IToken char_literal179 = null;
        IToken char_literal180 = null;
        IToken char_literal181 = null;
        IToken string_literal182 = null;
        IToken string_literal183 = null;
        IToken string_literal184 = null;
        IToken char_literal185 = null;
        IToken char_literal186 = null;
        IToken END_OF_STATEMENT187 = null;
        IToken string_literal188 = null;
        IToken char_literal189 = null;
        IToken char_literal190 = null;
        IToken char_literal191 = null;
        IToken string_literal192 = null;
        IToken string_literal193 = null;
        IToken string_literal194 = null;
        IToken char_literal195 = null;
        IToken char_literal196 = null;
        IToken END_OF_STATEMENT197 = null;
        IToken string_literal198 = null;
        IToken char_literal199 = null;
        IToken char_literal200 = null;
        IToken END_OF_STATEMENT201 = null;
        IToken string_literal202 = null;
        IToken char_literal203 = null;
        IToken char_literal204 = null;
        IToken char_literal205 = null;
        IToken char_literal206 = null;
        IToken END_OF_STATEMENT207 = null;
        IToken string_literal208 = null;
        IToken char_literal209 = null;
        IToken char_literal210 = null;
        IToken char_literal211 = null;
        IToken END_OF_STATEMENT212 = null;
        IToken string_literal213 = null;
        IToken char_literal214 = null;
        IToken char_literal215 = null;
        IToken END_OF_STATEMENT216 = null;
        IToken string_literal217 = null;
        IToken char_literal218 = null;
        IToken char_literal219 = null;
        IToken char_literal220 = null;
        IToken char_literal221 = null;
        IToken END_OF_STATEMENT222 = null;
        IToken string_literal223 = null;
        IToken char_literal224 = null;
        IToken char_literal225 = null;
        IToken char_literal226 = null;
        IToken END_OF_STATEMENT227 = null;
        IToken string_literal228 = null;
        IToken char_literal229 = null;
        IToken char_literal230 = null;
        IToken END_OF_STATEMENT231 = null;
        IToken string_literal232 = null;
        IToken char_literal233 = null;
        IToken SCALEMODE234 = null;
        IToken char_literal235 = null;
        IToken END_OF_STATEMENT236 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.int_literal_return el2 = null;

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


        object string_literal176_tree=null;
        object char_literal177_tree=null;
        object char_literal178_tree=null;
        object char_literal179_tree=null;
        object char_literal180_tree=null;
        object char_literal181_tree=null;
        object string_literal182_tree=null;
        object string_literal183_tree=null;
        object string_literal184_tree=null;
        object char_literal185_tree=null;
        object char_literal186_tree=null;
        object END_OF_STATEMENT187_tree=null;
        object string_literal188_tree=null;
        object char_literal189_tree=null;
        object char_literal190_tree=null;
        object char_literal191_tree=null;
        object string_literal192_tree=null;
        object string_literal193_tree=null;
        object string_literal194_tree=null;
        object char_literal195_tree=null;
        object char_literal196_tree=null;
        object END_OF_STATEMENT197_tree=null;
        object string_literal198_tree=null;
        object char_literal199_tree=null;
        object char_literal200_tree=null;
        object END_OF_STATEMENT201_tree=null;
        object string_literal202_tree=null;
        object char_literal203_tree=null;
        object char_literal204_tree=null;
        object char_literal205_tree=null;
        object char_literal206_tree=null;
        object END_OF_STATEMENT207_tree=null;
        object string_literal208_tree=null;
        object char_literal209_tree=null;
        object char_literal210_tree=null;
        object char_literal211_tree=null;
        object END_OF_STATEMENT212_tree=null;
        object string_literal213_tree=null;
        object char_literal214_tree=null;
        object char_literal215_tree=null;
        object END_OF_STATEMENT216_tree=null;
        object string_literal217_tree=null;
        object char_literal218_tree=null;
        object char_literal219_tree=null;
        object char_literal220_tree=null;
        object char_literal221_tree=null;
        object END_OF_STATEMENT222_tree=null;
        object string_literal223_tree=null;
        object char_literal224_tree=null;
        object char_literal225_tree=null;
        object char_literal226_tree=null;
        object END_OF_STATEMENT227_tree=null;
        object string_literal228_tree=null;
        object char_literal229_tree=null;
        object char_literal230_tree=null;
        object END_OF_STATEMENT231_tree=null;
        object string_literal232_tree=null;
        object char_literal233_tree=null;
        object SCALEMODE234_tree=null;
        object char_literal235_tree=null;
        object END_OF_STATEMENT236_tree=null;

         retval.ret = new PlotFunctionElement();

        try 
    	{
            // spinach.g:414:1: ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) )
            int alt45 = 10;
            alt45 = dfa45.Predict(input);
            switch (alt45) 
            {
                case 1 :
                    // spinach.g:414:3: ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:414:3: ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:414:4: 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal176=(IToken)Match(input,48,FOLLOW_48_in_plotfunctions2308); 
                    			string_literal176_tree = (object)adaptor.Create(string_literal176);
                    			adaptor.AddChild(root_0, string_literal176_tree);

                    		retval.ret.setPlotFunction("subPlot");
                    		char_literal177=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2311); 
                    			char_literal177_tree = (object)adaptor.Create(char_literal177);
                    			adaptor.AddChild(root_0, char_literal177_tree);

                    		// spinach.g:415:1: (el1= int_literal )
                    		// spinach.g:415:2: el1= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2318);
                    			el1 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el1.Tree);
                    			retval.ret.setRow(((el1 != null) ? el1.ret : null));

                    		}

                    		char_literal178=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2323); 
                    			char_literal178_tree = (object)adaptor.Create(char_literal178);
                    			adaptor.AddChild(root_0, char_literal178_tree);

                    		// spinach.g:416:1: (el2= int_literal )
                    		// spinach.g:416:2: el2= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2330);
                    			el2 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el2.Tree);
                    			retval.ret.setColumn(((el2 != null) ? el2.ret : null));

                    		}

                    		char_literal179=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2335); 
                    			char_literal179_tree = (object)adaptor.Create(char_literal179);
                    			adaptor.AddChild(root_0, char_literal179_tree);

                    		// spinach.g:417:1: (vll1= variable )
                    		// spinach.g:417:2: vll1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2342);
                    			vll1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll1.Tree);
                    			retval.ret.setData(((vll1 != null) ? vll1.ret : null));

                    		}

                    		char_literal180=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2347); 
                    			char_literal180_tree = (object)adaptor.Create(char_literal180);
                    			adaptor.AddChild(root_0, char_literal180_tree);

                    		// spinach.g:418:1: (vll2= string_literal )
                    		// spinach.g:418:2: vll2= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2354);
                    			vll2 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll2.Tree);
                    			retval.ret.setTitle(((vll2 != null) ? vll2.ret : null));

                    		}

                    		char_literal181=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2358); 
                    			char_literal181_tree = (object)adaptor.Create(char_literal181);
                    			adaptor.AddChild(root_0, char_literal181_tree);

                    		// spinach.g:419:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt42 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt42 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt42 = 2;
                    		    }
                    		    break;
                    		case 51:
                    			{
                    		    alt42 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d42s0 =
                    			        new NoViableAltException("", 42, 0, input);

                    			    throw nvae_d42s0;
                    		}

                    		switch (alt42) 
                    		{
                    		    case 1 :
                    		        // spinach.g:419:2: ( '1D' )
                    		        {
                    		        	// spinach.g:419:2: ( '1D' )
                    		        	// spinach.g:419:3: '1D'
                    		        	{
                    		        		string_literal182=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2362); 
                    		        			string_literal182_tree = (object)adaptor.Create(string_literal182);
                    		        			adaptor.AddChild(root_0, string_literal182_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // spinach.g:419:40: ( '2D' )
                    		        {
                    		        	// spinach.g:419:40: ( '2D' )
                    		        	// spinach.g:419:41: '2D'
                    		        	{
                    		        		string_literal183=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2367); 
                    		        			string_literal183_tree = (object)adaptor.Create(string_literal183);
                    		        			adaptor.AddChild(root_0, string_literal183_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // spinach.g:419:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// spinach.g:419:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// spinach.g:419:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal184=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2372); 
                    		        			string_literal184_tree = (object)adaptor.Create(string_literal184);
                    		        			adaptor.AddChild(root_0, string_literal184_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// spinach.g:419:114: ( ',' (el3= int_literal ) )?
                    		        		int alt41 = 2;
                    		        		int LA41_0 = input.LA(1);

                    		        		if ( (LA41_0 == 32) )
                    		        		{
                    		        		    alt41 = 1;
                    		        		}
                    		        		switch (alt41) 
                    		        		{
                    		        		    case 1 :
                    		        		        // spinach.g:419:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal185=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2375); 
                    		        		        		char_literal185_tree = (object)adaptor.Create(char_literal185);
                    		        		        		adaptor.AddChild(root_0, char_literal185_tree);

                    		        		        	// spinach.g:419:118: (el3= int_literal )
                    		        		        	// spinach.g:419:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2381);
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

                    		char_literal186=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2389); 
                    			char_literal186_tree = (object)adaptor.Create(char_literal186);
                    			adaptor.AddChild(root_0, char_literal186_tree);

                    		END_OF_STATEMENT187=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2390); 
                    			END_OF_STATEMENT187_tree = (object)adaptor.Create(END_OF_STATEMENT187);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT187_tree);


                    	}


                    }
                    break;
                case 2 :
                    // spinach.g:421:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:421:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:421:4: 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal188=(IToken)Match(input,52,FOLLOW_52_in_plotfunctions2396); 
                    			string_literal188_tree = (object)adaptor.Create(string_literal188);
                    			adaptor.AddChild(root_0, string_literal188_tree);

                    		retval.ret.setPlotFunction("plot");
                    		char_literal189=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2399); 
                    			char_literal189_tree = (object)adaptor.Create(char_literal189);
                    			adaptor.AddChild(root_0, char_literal189_tree);

                    		// spinach.g:422:1: (vll3= variable )
                    		// spinach.g:422:2: vll3= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2405);
                    			vll3 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll3.Tree);
                    			retval.ret.setData(((vll3 != null) ? vll3.ret : null));

                    		}

                    		char_literal190=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2410); 
                    			char_literal190_tree = (object)adaptor.Create(char_literal190);
                    			adaptor.AddChild(root_0, char_literal190_tree);

                    		// spinach.g:423:1: (vll4= string_literal )
                    		// spinach.g:423:2: vll4= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2416);
                    			vll4 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll4.Tree);
                    			retval.ret.setTitle(((vll4 != null) ? vll4.ret : null));

                    		}

                    		char_literal191=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2420); 
                    			char_literal191_tree = (object)adaptor.Create(char_literal191);
                    			adaptor.AddChild(root_0, char_literal191_tree);

                    		// spinach.g:424:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt44 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt44 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt44 = 2;
                    		    }
                    		    break;
                    		case 51:
                    			{
                    		    alt44 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d44s0 =
                    			        new NoViableAltException("", 44, 0, input);

                    			    throw nvae_d44s0;
                    		}

                    		switch (alt44) 
                    		{
                    		    case 1 :
                    		        // spinach.g:424:2: ( '1D' )
                    		        {
                    		        	// spinach.g:424:2: ( '1D' )
                    		        	// spinach.g:424:3: '1D'
                    		        	{
                    		        		string_literal192=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2424); 
                    		        			string_literal192_tree = (object)adaptor.Create(string_literal192);
                    		        			adaptor.AddChild(root_0, string_literal192_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // spinach.g:424:40: ( '2D' )
                    		        {
                    		        	// spinach.g:424:40: ( '2D' )
                    		        	// spinach.g:424:41: '2D'
                    		        	{
                    		        		string_literal193=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2429); 
                    		        			string_literal193_tree = (object)adaptor.Create(string_literal193);
                    		        			adaptor.AddChild(root_0, string_literal193_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // spinach.g:424:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// spinach.g:424:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// spinach.g:424:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal194=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2434); 
                    		        			string_literal194_tree = (object)adaptor.Create(string_literal194);
                    		        			adaptor.AddChild(root_0, string_literal194_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// spinach.g:424:114: ( ',' (el3= int_literal ) )?
                    		        		int alt43 = 2;
                    		        		int LA43_0 = input.LA(1);

                    		        		if ( (LA43_0 == 32) )
                    		        		{
                    		        		    alt43 = 1;
                    		        		}
                    		        		switch (alt43) 
                    		        		{
                    		        		    case 1 :
                    		        		        // spinach.g:424:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal195=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2437); 
                    		        		        		char_literal195_tree = (object)adaptor.Create(char_literal195);
                    		        		        		adaptor.AddChild(root_0, char_literal195_tree);

                    		        		        	// spinach.g:424:118: (el3= int_literal )
                    		        		        	// spinach.g:424:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2443);
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

                    		char_literal196=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2451); 
                    			char_literal196_tree = (object)adaptor.Create(char_literal196);
                    			adaptor.AddChild(root_0, char_literal196_tree);

                    		END_OF_STATEMENT197=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2452); 
                    			END_OF_STATEMENT197_tree = (object)adaptor.Create(END_OF_STATEMENT197);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT197_tree);


                    	}


                    }
                    break;
                case 3 :
                    // spinach.g:426:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:426:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    	// spinach.g:426:4: 'resetPlot' '(' ')' END_OF_STATEMENT
                    	{
                    		string_literal198=(IToken)Match(input,53,FOLLOW_53_in_plotfunctions2458); 
                    			string_literal198_tree = (object)adaptor.Create(string_literal198);
                    			adaptor.AddChild(root_0, string_literal198_tree);

                    		char_literal199=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2459); 
                    			char_literal199_tree = (object)adaptor.Create(char_literal199);
                    			adaptor.AddChild(root_0, char_literal199_tree);

                    		char_literal200=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2460); 
                    			char_literal200_tree = (object)adaptor.Create(char_literal200);
                    			adaptor.AddChild(root_0, char_literal200_tree);

                    		retval.ret.setPlotFunction("resetPlot");
                    		END_OF_STATEMENT201=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2462); 
                    			END_OF_STATEMENT201_tree = (object)adaptor.Create(END_OF_STATEMENT201);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT201_tree);


                    	}


                    }
                    break;
                case 4 :
                    // spinach.g:427:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:427:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:427:4: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal202=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2468); 
                    			string_literal202_tree = (object)adaptor.Create(string_literal202);
                    			adaptor.AddChild(root_0, string_literal202_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal203=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2470); 
                    			char_literal203_tree = (object)adaptor.Create(char_literal203);
                    			adaptor.AddChild(root_0, char_literal203_tree);

                    		// spinach.g:428:1: (ell2= double_literal )
                    		// spinach.g:428:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2476);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal204=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2479); 
                    			char_literal204_tree = (object)adaptor.Create(char_literal204);
                    			adaptor.AddChild(root_0, char_literal204_tree);

                    		// spinach.g:429:1: ( (ell3= double_literal ) ',' )
                    		// spinach.g:429:2: (ell3= double_literal ) ','
                    		{
                    			// spinach.g:429:2: (ell3= double_literal )
                    			// spinach.g:429:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2485);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}

                    			char_literal205=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2488); 
                    				char_literal205_tree = (object)adaptor.Create(char_literal205);
                    				adaptor.AddChild(root_0, char_literal205_tree);


                    		}

                    		// spinach.g:430:1: ( (el4= double_literal ) )
                    		// spinach.g:430:2: (el4= double_literal )
                    		{
                    			// spinach.g:430:2: (el4= double_literal )
                    			// spinach.g:430:3: el4= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2495);
                    				el4 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, el4.Tree);
                    				retval.ret.setZFact(((el4 != null) ? el4.ret : null));

                    			}


                    		}

                    		char_literal206=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2500); 
                    			char_literal206_tree = (object)adaptor.Create(char_literal206);
                    			adaptor.AddChild(root_0, char_literal206_tree);

                    		END_OF_STATEMENT207=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2501); 
                    			END_OF_STATEMENT207_tree = (object)adaptor.Create(END_OF_STATEMENT207);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT207_tree);


                    	}


                    }
                    break;
                case 5 :
                    // spinach.g:432:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:432:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:432:3: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal208=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2506); 
                    			string_literal208_tree = (object)adaptor.Create(string_literal208);
                    			adaptor.AddChild(root_0, string_literal208_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal209=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2508); 
                    			char_literal209_tree = (object)adaptor.Create(char_literal209);
                    			adaptor.AddChild(root_0, char_literal209_tree);

                    		// spinach.g:433:1: (ell2= double_literal )
                    		// spinach.g:433:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2514);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal210=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2517); 
                    			char_literal210_tree = (object)adaptor.Create(char_literal210);
                    			adaptor.AddChild(root_0, char_literal210_tree);

                    		// spinach.g:434:1: ( (ell3= double_literal ) )
                    		// spinach.g:434:2: (ell3= double_literal )
                    		{
                    			// spinach.g:434:2: (ell3= double_literal )
                    			// spinach.g:434:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2523);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}


                    		}

                    		char_literal211=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2528); 
                    			char_literal211_tree = (object)adaptor.Create(char_literal211);
                    			adaptor.AddChild(root_0, char_literal211_tree);

                    		END_OF_STATEMENT212=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2529); 
                    			END_OF_STATEMENT212_tree = (object)adaptor.Create(END_OF_STATEMENT212);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT212_tree);


                    	}


                    }
                    break;
                case 6 :
                    // spinach.g:436:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:436:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    	// spinach.g:436:3: 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal213=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2534); 
                    			string_literal213_tree = (object)adaptor.Create(string_literal213);
                    			adaptor.AddChild(root_0, string_literal213_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal214=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2536); 
                    			char_literal214_tree = (object)adaptor.Create(char_literal214);
                    			adaptor.AddChild(root_0, char_literal214_tree);

                    		// spinach.g:437:1: (ell2= double_literal )
                    		// spinach.g:437:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2542);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal215=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2546); 
                    			char_literal215_tree = (object)adaptor.Create(char_literal215);
                    			adaptor.AddChild(root_0, char_literal215_tree);

                    		END_OF_STATEMENT216=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2547); 
                    			END_OF_STATEMENT216_tree = (object)adaptor.Create(END_OF_STATEMENT216);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT216_tree);


                    	}


                    }
                    break;
                case 7 :
                    // spinach.g:439:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:439:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:439:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal217=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2553); 
                    			string_literal217_tree = (object)adaptor.Create(string_literal217);
                    			adaptor.AddChild(root_0, string_literal217_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal218=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2555); 
                    			char_literal218_tree = (object)adaptor.Create(char_literal218);
                    			adaptor.AddChild(root_0, char_literal218_tree);

                    		// spinach.g:440:1: (vl1= string_literal )
                    		// spinach.g:440:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2561);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal219=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2564); 
                    			char_literal219_tree = (object)adaptor.Create(char_literal219);
                    			adaptor.AddChild(root_0, char_literal219_tree);

                    		// spinach.g:441:1: ( (vl2= string_literal ) ',' )
                    		// spinach.g:441:2: (vl2= string_literal ) ','
                    		{
                    			// spinach.g:441:2: (vl2= string_literal )
                    			// spinach.g:441:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2571);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}

                    			char_literal220=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2574); 
                    				char_literal220_tree = (object)adaptor.Create(char_literal220);
                    				adaptor.AddChild(root_0, char_literal220_tree);


                    		}

                    		// spinach.g:442:1: ( (vl3= string_literal ) )
                    		// spinach.g:442:2: (vl3= string_literal )
                    		{
                    			// spinach.g:442:2: (vl3= string_literal )
                    			// spinach.g:442:3: vl3= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2582);
                    				vl3 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl3.Tree);
                    				retval.ret.setZTitle(((vl3 != null) ? vl3.ret : null));

                    			}


                    		}

                    		char_literal221=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2587); 
                    			char_literal221_tree = (object)adaptor.Create(char_literal221);
                    			adaptor.AddChild(root_0, char_literal221_tree);

                    		END_OF_STATEMENT222=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2588); 
                    			END_OF_STATEMENT222_tree = (object)adaptor.Create(END_OF_STATEMENT222);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT222_tree);


                    	}


                    }
                    break;
                case 8 :
                    // spinach.g:444:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:444:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:444:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal223=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2594); 
                    			string_literal223_tree = (object)adaptor.Create(string_literal223);
                    			adaptor.AddChild(root_0, string_literal223_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal224=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2596); 
                    			char_literal224_tree = (object)adaptor.Create(char_literal224);
                    			adaptor.AddChild(root_0, char_literal224_tree);

                    		// spinach.g:445:1: (vl1= string_literal )
                    		// spinach.g:445:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2602);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal225=(IToken)Match(input,32,FOLLOW_32_in_plotfunctions2605); 
                    			char_literal225_tree = (object)adaptor.Create(char_literal225);
                    			adaptor.AddChild(root_0, char_literal225_tree);

                    		// spinach.g:446:1: ( (vl2= string_literal ) )
                    		// spinach.g:446:2: (vl2= string_literal )
                    		{
                    			// spinach.g:446:2: (vl2= string_literal )
                    			// spinach.g:446:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2612);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}


                    		}

                    		char_literal226=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2617); 
                    			char_literal226_tree = (object)adaptor.Create(char_literal226);
                    			adaptor.AddChild(root_0, char_literal226_tree);

                    		END_OF_STATEMENT227=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2618); 
                    			END_OF_STATEMENT227_tree = (object)adaptor.Create(END_OF_STATEMENT227);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT227_tree);


                    	}


                    }
                    break;
                case 9 :
                    // spinach.g:448:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:448:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    	// spinach.g:448:3: 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal228=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2623); 
                    			string_literal228_tree = (object)adaptor.Create(string_literal228);
                    			adaptor.AddChild(root_0, string_literal228_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal229=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2625); 
                    			char_literal229_tree = (object)adaptor.Create(char_literal229);
                    			adaptor.AddChild(root_0, char_literal229_tree);

                    		// spinach.g:449:1: (vl1= string_literal )
                    		// spinach.g:449:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2631);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal230=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2635); 
                    			char_literal230_tree = (object)adaptor.Create(char_literal230);
                    			adaptor.AddChild(root_0, char_literal230_tree);

                    		END_OF_STATEMENT231=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2636); 
                    			END_OF_STATEMENT231_tree = (object)adaptor.Create(END_OF_STATEMENT231);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT231_tree);


                    	}


                    }
                    break;
                case 10 :
                    // spinach.g:451:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:451:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    	// spinach.g:451:3: 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT
                    	{
                    		string_literal232=(IToken)Match(input,56,FOLLOW_56_in_plotfunctions2641); 
                    			string_literal232_tree = (object)adaptor.Create(string_literal232);
                    			adaptor.AddChild(root_0, string_literal232_tree);

                    		char_literal233=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2642); 
                    			char_literal233_tree = (object)adaptor.Create(char_literal233);
                    			adaptor.AddChild(root_0, char_literal233_tree);

                    		retval.ret.setPlotFunction("setScaleMode");
                    		SCALEMODE234=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_plotfunctions2645); 
                    			SCALEMODE234_tree = (object)adaptor.Create(SCALEMODE234);
                    			adaptor.AddChild(root_0, SCALEMODE234_tree);

                    		retval.ret.setScaleMode(SCALEMODE234.Text);
                    		char_literal235=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2649); 
                    			char_literal235_tree = (object)adaptor.Create(char_literal235);
                    			adaptor.AddChild(root_0, char_literal235_tree);

                    		END_OF_STATEMENT236=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2651); 
                    			END_OF_STATEMENT236_tree = (object)adaptor.Create(END_OF_STATEMENT236);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT236_tree);


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


   	protected DFA4 dfa4;
   	protected DFA22 dfa22;
   	protected DFA35 dfa35;
   	protected DFA38 dfa38;
   	protected DFA45 dfa45;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
    	this.dfa22 = new DFA22(this);
    	this.dfa35 = new DFA35(this);
    	this.dfa38 = new DFA38(this);
    	this.dfa45 = new DFA45(this);





	}

    const string DFA4_eotS =
        "\x0b\uffff";
    const string DFA4_eofS =
        "\x0b\uffff";
    const string DFA4_minS =
        "\x01\x04\x01\x08\x09\uffff";
    const string DFA4_maxS =
        "\x01\x2b\x01\x1e\x09\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\x09\x01\x01\x01\x07";
    const string DFA4_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x02\uffff\x01\x02\x02\uffff\x01\x02\x11\uffff\x01"+
            "\x08\x04\uffff\x01\x03\x02\uffff\x01\x04\x01\x05\x03\uffff\x01"+
            "\x06\x01\uffff\x01\x07",
            "\x01\x09\x04\uffff\x01\x0a\x09\uffff\x01\x09\x06\uffff\x01"+
            "\x09",
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

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "41:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )"; }
        }

    }

    const string DFA22_eotS =
        "\x0b\uffff";
    const string DFA22_eofS =
        "\x0b\uffff";
    const string DFA22_minS =
        "\x01\x04\x0a\uffff";
    const string DFA22_maxS =
        "\x01\x2b\x0a\uffff";
    const string DFA22_acceptS =
        "\x01\uffff\x01\x02\x09\x01";
    const string DFA22_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA22_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x04\x01\uffff\x01"+
            "\x01\x0f\uffff\x01\x0a\x04\uffff\x01\x05\x02\uffff\x01\x06\x01"+
            "\x07\x01\uffff\x01\x01\x01\uffff\x01\x08\x01\uffff\x01\x09",
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
            get { return "()+ loopback of 239:80: (e11= expr2 )+"; }
        }

    }

    const string DFA35_eotS =
        "\x0e\uffff";
    const string DFA35_eofS =
        "\x0e\uffff";
    const string DFA35_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA35_maxS =
        "\x01\x2f\x01\uffff\x01\x1e\x0b\uffff";
    const string DFA35_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x02\x01\x01";
    const string DFA35_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x01\x10\uffff\x01\x05\x03\uffff\x01\x04\x02\uffff\x01\x06\x01"+
            "\x07\x01\x0a\x02\uffff\x01\x08\x01\uffff\x01\x0b\x03\uffff\x01"+
            "\x09",
            "",
            "\x01\x0d\x04\uffff\x01\x0c\x09\uffff\x01\x0d\x06\uffff\x01"+
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

    static readonly short[] DFA35_eot = DFA.UnpackEncodedString(DFA35_eotS);
    static readonly short[] DFA35_eof = DFA.UnpackEncodedString(DFA35_eofS);
    static readonly char[] DFA35_min = DFA.UnpackEncodedStringToUnsignedChars(DFA35_minS);
    static readonly char[] DFA35_max = DFA.UnpackEncodedStringToUnsignedChars(DFA35_maxS);
    static readonly short[] DFA35_accept = DFA.UnpackEncodedString(DFA35_acceptS);
    static readonly short[] DFA35_special = DFA.UnpackEncodedString(DFA35_specialS);
    static readonly short[][] DFA35_transition = DFA.UnpackEncodedStringArray(DFA35_transitionS);

    protected class DFA35 : DFA
    {
        public DFA35(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 35;
            this.eot = DFA35_eot;
            this.eof = DFA35_eof;
            this.min = DFA35_min;
            this.max = DFA35_max;
            this.accept = DFA35_accept;
            this.special = DFA35_special;
            this.transition = DFA35_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 314:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA38_eotS =
        "\x0e\uffff";
    const string DFA38_eofS =
        "\x0e\uffff";
    const string DFA38_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA38_maxS =
        "\x01\x2f\x01\uffff\x01\x1e\x0b\uffff";
    const string DFA38_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x01\x01\x02";
    const string DFA38_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA38_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x01\x10\uffff\x01\x05\x03\uffff\x01\x04\x02\uffff\x01\x06\x01"+
            "\x07\x01\x0a\x02\uffff\x01\x08\x01\uffff\x01\x0b\x03\uffff\x01"+
            "\x09",
            "",
            "\x01\x0c\x04\uffff\x01\x0d\x09\uffff\x01\x0c\x06\uffff\x01"+
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

    static readonly short[] DFA38_eot = DFA.UnpackEncodedString(DFA38_eotS);
    static readonly short[] DFA38_eof = DFA.UnpackEncodedString(DFA38_eofS);
    static readonly char[] DFA38_min = DFA.UnpackEncodedStringToUnsignedChars(DFA38_minS);
    static readonly char[] DFA38_max = DFA.UnpackEncodedStringToUnsignedChars(DFA38_maxS);
    static readonly short[] DFA38_accept = DFA.UnpackEncodedString(DFA38_acceptS);
    static readonly short[] DFA38_special = DFA.UnpackEncodedString(DFA38_specialS);
    static readonly short[][] DFA38_transition = DFA.UnpackEncodedStringArray(DFA38_transitionS);

    protected class DFA38 : DFA
    {
        public DFA38(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 38;
            this.eot = DFA38_eot;
            this.eof = DFA38_eof;
            this.min = DFA38_min;
            this.max = DFA38_max;
            this.accept = DFA38_accept;
            this.special = DFA38_special;
            this.transition = DFA38_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 324:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA45_eotS =
        "\x1d\uffff";
    const string DFA45_eofS =
        "\x1d\uffff";
    const string DFA45_minS =
        "\x01\x30\x03\uffff\x02\x0d\x01\uffff\x01\x06\x01\x1b\x01\x0f\x01"+
        "\x04\x01\uffff\x01\x06\x03\x04\x02\x0f\x01\x1b\x03\uffff\x04\x04"+
        "\x01\x0f\x02\uffff";
    const string DFA45_maxS =
        "\x01\x38\x03\uffff\x02\x0d\x01\uffff\x01\x06\x01\x1b\x01\x20\x01"+
        "\x1b\x01\uffff\x01\x06\x03\x1b\x02\x20\x01\x1b\x03\uffff\x04\x1b"+
        "\x01\x20\x02\uffff";
    const string DFA45_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x02\uffff\x01\x0a\x04\uffff"+
        "\x01\x06\x07\uffff\x01\x09\x01\x05\x01\x04\x05\uffff\x01\x07\x01"+
        "\x08";
    const string DFA45_specialS =
        "\x1d\uffff}>";
    static readonly string[] DFA45_transitionS = {
            "\x01\x01\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06",
            "",
            "",
            "",
            "\x01\x07",
            "\x01\x08",
            "",
            "\x01\x09",
            "\x01\x0a",
            "\x01\x0b\x10\uffff\x01\x0c",
            "\x01\x0d\x01\x0e\x01\x0f\x14\uffff\x01\x10",
            "",
            "\x01\x11",
            "\x01\x0d\x01\x0e\x01\x0f\x14\uffff\x01\x10",
            "\x01\x0d\x01\x0e\x01\x0f\x14\uffff\x01\x10",
            "\x01\x0d\x01\x0e\x01\x0f\x14\uffff\x01\x10",
            "\x01\x13\x10\uffff\x01\x12",
            "\x01\x14\x10\uffff\x01\x15",
            "\x01\x16",
            "",
            "",
            "",
            "\x01\x17\x01\x18\x01\x19\x14\uffff\x01\x1a",
            "\x01\x17\x01\x18\x01\x19\x14\uffff\x01\x1a",
            "\x01\x17\x01\x18\x01\x19\x14\uffff\x01\x1a",
            "\x01\x17\x01\x18\x01\x19\x14\uffff\x01\x1a",
            "\x01\x1c\x10\uffff\x01\x1b",
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
            get { return "411:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program64 = new BitSet(new ulong[]{0x01F11A7A30000492UL});
    public static readonly BitSet FOLLOW_expr1_in_expr90 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr94 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functiondefination_in_expr110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_expr1124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr1133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_plotfunctions_in_expr1141 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallelfor_in_expr1148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr2_in_expr1156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expr2176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_expr2186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_expr2196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_expr2207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr2218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifelse_in_expr2228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_expr2237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forstatement_in_expr2246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_expr2255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_string_literal278 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_string_literal282 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_27_in_string_literal287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_comment306 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_comment307 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_variable_in_var_int_or_double_literal325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_int_or_double_literal336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_double_literal_in_var_int_or_double_literal346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable368 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_double_literal411 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec433 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixvardec435 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixvardec437 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec440 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec442 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec445 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec448 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec451 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec455 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec458 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixvardec466 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matrixvardec473 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec477 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec482 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_32_in_matrixvardec487 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec490 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec503 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_32_in_matrixvardec510 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec513 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec520 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matrixvardec526 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_vectorvardec544 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorvardec546 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorvardec548 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec551 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec553 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec556 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec559 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorvardec565 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_vectorvardec572 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec577 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec582 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_32_in_vectorvardec587 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec590 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec603 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_32_in_vectorvardec610 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec613 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec620 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_vectorvardec626 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem646 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem649 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem652 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixelem654 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem657 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem660 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixelem662 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem684 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorelem687 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorelem690 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorelem693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment716 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment726 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_vectorelem_in_assignment738 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_matrixelem_in_assignment751 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment759 = new BitSet(new ulong[]{0x0000400008002070UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_assignment768 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_dotproduct_in_assignment772 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixtranspose_in_assignment781 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_assignment785 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_functioncall_in_assignment789 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_additive_expression839 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additive_expression844 = new BitSet(new ulong[]{0x0000000000002070UL});
    public static readonly BitSet FOLLOW_additive_expression_in_additive_expression850 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplicative_expression892 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_bracket_exp_in_multiplicative_expression911 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_matrixelem_in_multiplicative_expression931 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_vectorelem_in_multiplicative_expression951 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplicative_expression967 = new BitSet(new ulong[]{0x0000000000002070UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_multiplicative_expression1024 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_bracket_exp1068 = new BitSet(new ulong[]{0x0000000000002070UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_bracket_exp1069 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_bracket_exp1071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expression_in_subtractive_exp1100 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_34_in_subtractive_exp1105 = new BitSet(new ulong[]{0x0000000000002070UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_subtractive_exp1111 = new BitSet(new ulong[]{0x0000000400000002UL});
    public static readonly BitSet FOLLOW_35_in_structdec1143 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structdec1145 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_structdec1149 = new BitSet(new ulong[]{0x0000000000000480UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_structdec1154 = new BitSet(new ulong[]{0x0000000000001480UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_structdec1160 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec1162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarvardec1183 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_scalarvardec1190 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarvardec1197 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_scalarvardec1201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1223 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1230 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec1236 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1256 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_DOT_in_structassign1259 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_deletionofvar1282 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_deletionofvar1286 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_deletionofvar1290 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_print1309 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_print1311 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print1319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parallelfor1341 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_range_in_parallelfor1347 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_parallelfor1350 = new BitSet(new ulong[]{0x01F10A7230000490UL});
    public static readonly BitSet FOLLOW_expr2_in_parallelfor1357 = new BitSet(new ulong[]{0x01F10AF230001490UL});
    public static readonly BitSet FOLLOW_39_in_parallelfor1363 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_parallelfor1366 = new BitSet(new ulong[]{0x01F10A7230001490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_parallelfor1374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_range1388 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_range1394 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_POINT_in_range1397 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_range1403 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_range1406 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_range1411 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_range1414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_ifelse1431 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_ifelse1433 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_equality_in_ifelse1436 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_nonequality_in_ifelse1439 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_lessthan_in_ifelse1442 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_lessthanequalto_in_ifelse1448 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_greaterthan_in_ifelse1451 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_greaterthanequalto_in_ifelse1455 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_ifelse1460 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1462 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1470 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1475 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_42_in_ifelse1478 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1481 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1490 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr1_in_ifloop1517 = new BitSet(new ulong[]{0x01F18A7230000492UL});
    public static readonly BitSet FOLLOW_functionreturn_in_ifloop1520 = new BitSet(new ulong[]{0x01F18A7230000492UL});
    public static readonly BitSet FOLLOW_43_in_forstatement1539 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_range_in_forstatement1544 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_forstatement1547 = new BitSet(new ulong[]{0x01F10A7230000490UL});
    public static readonly BitSet FOLLOW_expr1_in_forstatement1552 = new BitSet(new ulong[]{0x01F10A7230001490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_forstatement1557 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_functioncall1582 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functioncall1587 = new BitSet(new ulong[]{0x0000000000008070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1591 = new BitSet(new ulong[]{0x0000000100008000UL});
    public static readonly BitSet FOLLOW_32_in_functioncall1595 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1599 = new BitSet(new ulong[]{0x0000000100008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functioncall1606 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functioncall1610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_equality1639 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_equality1648 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_equality1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_nonequality1701 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_nonequality1710 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_nonequality1715 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_functiondefination1747 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1752 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1758 = new BitSet(new ulong[]{0x0000000220008080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1766 = new BitSet(new ulong[]{0x0000000100008000UL});
    public static readonly BitSet FOLLOW_32_in_functiondefination1769 = new BitSet(new ulong[]{0x0000000220000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1774 = new BitSet(new ulong[]{0x0000000100008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1783 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1785 = new BitSet(new ulong[]{0x01F18A7230000490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1788 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1791 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1795 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1803 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1811 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1819 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1825 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1833 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1837 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1841 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1845 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_functiondefination1853 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1858 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1864 = new BitSet(new ulong[]{0x0000000220008080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1873 = new BitSet(new ulong[]{0x0000000100008000UL});
    public static readonly BitSet FOLLOW_32_in_functiondefination1876 = new BitSet(new ulong[]{0x0000000220000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1880 = new BitSet(new ulong[]{0x0000000100008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1889 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1891 = new BitSet(new ulong[]{0x01F18A7230000490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1894 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1897 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1901 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1909 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1917 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1925 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1931 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1939 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1943 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1947 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1951 = new BitSet(new ulong[]{0x01F18A7230001490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1956 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lessthan1976 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_lessthan1979 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_lessthan1984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_greaterthan2006 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_greaterthan2009 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_greaterthan2014 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lessthanequalto2036 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_LESSTHANEQUALTOEXPRESSION_in_lessthanequalto2039 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_lessthanequalto2045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_greaterthanequalto2067 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_greaterthanequalto2070 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_greaterthanequalto2076 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct2099 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_dotproduct2103 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct2109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_matrixtranspose2128 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_matrixtranspose2130 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixtranspose2132 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_matrixtranspose2135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_matrixreference2151 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixreference2153 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixreference2158 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixreference2160 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixreference2164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_vectorreference2183 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorreference2185 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorreference2190 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2192 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorreference2196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarargument_in_arguments2212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixreference_in_arguments2218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorreference_in_arguments2224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarargument2248 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarargument2255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_functionreturn2277 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functionreturn2280 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functionreturn2284 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_plotfunctions2308 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2311 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2318 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2323 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2330 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2335 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2342 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2347 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2354 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2358 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2362 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2367 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2372 = new BitSet(new ulong[]{0x0000000100008000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2375 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2381 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2389 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_plotfunctions2396 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2399 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2405 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2410 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2416 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2420 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2424 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2429 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2434 = new BitSet(new ulong[]{0x0000000100008000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2437 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2443 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2451 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2452 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_plotfunctions2458 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2459 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2460 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2468 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2470 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2476 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2479 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2485 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2488 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2495 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2500 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2506 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2508 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2514 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2517 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2523 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2528 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2534 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2536 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2542 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2546 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2553 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2555 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2561 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2564 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2571 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2574 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2582 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2587 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2594 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2596 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2602 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_plotfunctions2605 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2612 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2617 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2618 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2623 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2625 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2631 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2635 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2636 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_plotfunctions2641 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2642 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_plotfunctions2645 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2649 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2651 = new BitSet(new ulong[]{0x0000000000000002UL});

}
