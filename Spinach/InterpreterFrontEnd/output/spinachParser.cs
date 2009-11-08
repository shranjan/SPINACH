// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g 2009-11-08 18:42:56


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:22:1: program returns [List<Element> ret] : ( expr )+ ;
    public spinachParser.program_return program() // throws RecognitionException [1]
    {   
        spinachParser.program_return retval = new spinachParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:26:3: ( ( expr )+ )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:26:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:26:5: ( expr )+
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
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:26:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program67);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:30:1: expr returns [Element ret] : ( expr1 | parallelfor );
    public spinachParser.expr_return expr() // throws RecognitionException [1]
    {   
        spinachParser.expr_return retval = new spinachParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr12 = null;

        spinachParser.parallelfor_return parallelfor3 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:31:3: ( expr1 | parallelfor )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == VARIABLE || LA2_0 == VARTYPE || LA2_0 == STRINGTYPE || LA2_0 == 28 || LA2_0 == 32 || (LA2_0 >= 34 && LA2_0 <= 36) || LA2_0 == 40 || (LA2_0 >= 42 && LA2_0 <= 43) || LA2_0 == 46 || LA2_0 == 48 || (LA2_0 >= 52 && LA2_0 <= 56)) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 37) )
            {
                alt2 = 2;
            }
            else 
            {
                NoViableAltException nvae_d2s0 =
                    new NoViableAltException("", 2, 0, input);

                throw nvae_d2s0;
            }
            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:31:4: expr1
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr1_in_expr94);
                    	expr12 = expr1();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr12.Tree);
                    	retval.ret = ((expr12 != null) ? expr12.ret : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:31:37: parallelfor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallelfor_in_expr98);
                    	parallelfor3 = parallelfor();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, parallelfor3.Tree);
                    	retval.ret = ((parallelfor3 != null) ? parallelfor3.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:34:1: expr1 returns [Element ret] : ( expr2 | matrixvardec | structdec | structobjdec | functiondefination | plotfunctions );
    public spinachParser.expr1_return expr1() // throws RecognitionException [1]
    {   
        spinachParser.expr1_return retval = new spinachParser.expr1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr2_return expr24 = null;

        spinachParser.matrixvardec_return matrixvardec5 = null;

        spinachParser.structdec_return structdec6 = null;

        spinachParser.structobjdec_return structobjdec7 = null;

        spinachParser.functiondefination_return functiondefination8 = null;

        spinachParser.plotfunctions_return plotfunctions9 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:35:4: ( expr2 | matrixvardec | structdec | structobjdec | functiondefination | plotfunctions )
            int alt3 = 6;
            alt3 = dfa3.Predict(input);
            switch (alt3) 
            {
                case 1 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:35:6: expr2
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr2_in_expr1115);
                    	expr24 = expr2();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr24.Tree);
                    	retval.ret = ((expr24 != null) ? expr24.ret : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:36:7: matrixvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixvardec_in_expr1124);
                    	matrixvardec5 = matrixvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matrixvardec5.Tree);
                    	 retval.ret = ((matrixvardec5 != null) ? matrixvardec5.ret : null);

                    }
                    break;
                case 3 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:37:8: structdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structdec_in_expr1135);
                    	structdec6 = structdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structdec6.Tree);
                    	retval.ret = ((structdec6 != null) ? structdec6.ret : null);

                    }
                    break;
                case 4 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:38:8: structobjdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structobjdec_in_expr1146);
                    	structobjdec7 = structobjdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structobjdec7.Tree);
                    	 retval.ret = ((structobjdec7 != null) ? structobjdec7.ret : null);

                    }
                    break;
                case 5 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:39:8: functiondefination
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functiondefination_in_expr1157);
                    	functiondefination8 = functiondefination();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functiondefination8.Tree);
                    	retval.ret = ((functiondefination8 != null) ? functiondefination8.ret : null);

                    }
                    break;
                case 6 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:40:9: plotfunctions
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_plotfunctions_in_expr1168);
                    	plotfunctions9 = plotfunctions();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, plotfunctions9.Tree);
                    	retval.ret = ((plotfunctions9 != null) ? plotfunctions9.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:42:1: expr2 returns [Element ret] : (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment ) ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:43:1: ( (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:43:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:43:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )
            	int alt4 = 9;
            	alt4 = dfa4.Predict(input);
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:43:5: el1= assignment
            	        {
            	        	PushFollow(FOLLOW_assignment_in_expr2186);
            	        	el1 = assignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret = ((el1 != null) ? el1.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:44:5: el2= scalarvardec
            	        {
            	        	PushFollow(FOLLOW_scalarvardec_in_expr2196);
            	        	el2 = scalarvardec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el2.Tree);
            	        	 retval.ret = ((el2 != null) ? el2.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:45:5: el3= vectorvardec
            	        {
            	        	PushFollow(FOLLOW_vectorvardec_in_expr2206);
            	        	el3 = vectorvardec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el3.Tree);
            	        	 retval.ret = ((el3 != null) ? el3.ret : null);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:46:5: el4= deletionofvar
            	        {
            	        	PushFollow(FOLLOW_deletionofvar_in_expr2217);
            	        	el4 = deletionofvar();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	 retval.ret = ((el4 != null) ? el4.ret : null);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:47:5: el5= print
            	        {
            	        	PushFollow(FOLLOW_print_in_expr2228);
            	        	el5 = print();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el5.Tree);
            	        	 retval.ret = ((el5 != null) ? el5.ret : null); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:48:5: el6= ifelse
            	        {
            	        	PushFollow(FOLLOW_ifelse_in_expr2238);
            	        	el6 = ifelse();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el6.Tree);
            	        	retval.ret = ((el6 != null) ? el6.ret : null);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:49:5: el7= functioncall
            	        {
            	        	PushFollow(FOLLOW_functioncall_in_expr2247);
            	        	el7 = functioncall();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el7.Tree);
            	        	retval.ret=((el7 != null) ? el7.ret : null);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:50:5: el8= forstatement
            	        {
            	        	PushFollow(FOLLOW_forstatement_in_expr2256);
            	        	el8 = forstatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el8.Tree);
            	        	retval.ret = ((el8 != null) ? el8.ret : null);

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:51:5: el9= comment
            	        {
            	        	PushFollow(FOLLOW_comment_in_expr2265);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:53:1: var_int_or_double_literal returns [Element ret] : ( int_literal | double_literal | varorstruct ) ;
    public spinachParser.var_int_or_double_literal_return var_int_or_double_literal() // throws RecognitionException [1]
    {   
        spinachParser.var_int_or_double_literal_return retval = new spinachParser.var_int_or_double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.int_literal_return int_literal10 = null;

        spinachParser.double_literal_return double_literal11 = null;

        spinachParser.varorstruct_return varorstruct12 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:54:3: ( ( int_literal | double_literal | varorstruct ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:54:7: ( int_literal | double_literal | varorstruct )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:54:7: ( int_literal | double_literal | varorstruct )
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
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:54:8: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_int_or_double_literal284);
            	        	int_literal10 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal10.Tree);
            	        	retval.ret = ((int_literal10 != null) ? int_literal10.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:55:7: double_literal
            	        {
            	        	PushFollow(FOLLOW_double_literal_in_var_int_or_double_literal294);
            	        	double_literal11 = double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, double_literal11.Tree);
            	        	retval.ret = ((double_literal11 != null) ? double_literal11.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:56:5: varorstruct
            	        {
            	        	PushFollow(FOLLOW_varorstruct_in_var_int_or_double_literal302);
            	        	varorstruct12 = varorstruct();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, varorstruct12.Tree);
            	        	retval.ret = ((varorstruct12 != null) ? varorstruct12.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:58:1: varorstruct returns [Element ret] : ( variable | structassign ) ;
    public spinachParser.varorstruct_return varorstruct() // throws RecognitionException [1]
    {   
        spinachParser.varorstruct_return retval = new spinachParser.varorstruct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.variable_return variable13 = null;

        spinachParser.structassign_return structassign14 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:59:1: ( ( variable | structassign ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:59:3: ( variable | structassign )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:59:3: ( variable | structassign )
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == VARIABLE) )
            	{
            	    int LA6_1 = input.LA(2);

            	    if ( (LA6_1 == DOT) )
            	    {
            	        alt6 = 2;
            	    }
            	    else if ( (LA6_1 == EOF || (LA6_1 >= VARIABLE && LA6_1 <= VARTYPE) || (LA6_1 >= END_OF_STATEMENT && LA6_1 <= STRINGTYPE) || LA6_1 == RIGHTBRACE || LA6_1 == RIGHTPARANTHESIS || (LA6_1 >= PLUS && LA6_1 <= MULTIPLY) || (LA6_1 >= EQUALITYEXPRESSION && LA6_1 <= 28) || (LA6_1 >= 31 && LA6_1 <= 37) || (LA6_1 >= 39 && LA6_1 <= 40) || (LA6_1 >= 42 && LA6_1 <= 43) || (LA6_1 >= 46 && LA6_1 <= 48) || (LA6_1 >= 52 && LA6_1 <= 56)) )
            	    {
            	        alt6 = 1;
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
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:59:4: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_varorstruct317);
            	        	variable13 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable13.Tree);
            	        	retval.ret = ((variable13 != null) ? variable13.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:59:42: structassign
            	        {
            	        	PushFollow(FOLLOW_structassign_in_varorstruct320);
            	        	structassign14 = structassign();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structassign14.Tree);
            	        	retval.ret = ((structassign14 != null) ? structassign14.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:62:1: variable returns [VariableElement ret] : VARIABLE ;
    public spinachParser.variable_return variable() // throws RecognitionException [1]
    {   
        spinachParser.variable_return retval = new spinachParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE15 = null;

        object VARIABLE15_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:66:3: ( VARIABLE )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:66:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE15=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable342); 
            		VARIABLE15_tree = (object)adaptor.Create(VARIABLE15);
            		adaptor.AddChild(root_0, VARIABLE15_tree);

            	 retval.ret.setText(((VARIABLE15 != null) ? VARIABLE15.Text : null)); 

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:68:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public spinachParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        spinachParser.int_literal_return retval = new spinachParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL16 = null;

        object INT_LITERAL16_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:72:3: ( INT_LITERAL )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:72:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL16=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal363); 
            		INT_LITERAL16_tree = (object)adaptor.Create(INT_LITERAL16);
            		adaptor.AddChild(root_0, INT_LITERAL16_tree);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:74:1: double_literal returns [DoubleElement ret] : el1= DOUBLE_LITERAL ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:78:2: (el1= DOUBLE_LITERAL )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:78:4: el1= DOUBLE_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_double_literal385); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:80:1: string_literal returns [StringElement ret] : ( '\"' (el1= var_int_or_double_literal )* '\"' ) ;
    public spinachParser.string_literal_return string_literal() // throws RecognitionException [1]
    {   
        spinachParser.string_literal_return retval = new spinachParser.string_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal17 = null;
        IToken char_literal18 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;


        object char_literal17_tree=null;
        object char_literal18_tree=null;


         retval.ret = new StringElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:84:2: ( ( '\"' (el1= var_int_or_double_literal )* '\"' ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:84:3: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:84:3: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:84:4: '\"' (el1= var_int_or_double_literal )* '\"'
            	{
            		char_literal17=(IToken)Match(input,27,FOLLOW_27_in_string_literal405); 
            			char_literal17_tree = (object)adaptor.Create(char_literal17);
            			adaptor.AddChild(root_0, char_literal17_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:84:7: (el1= var_int_or_double_literal )*
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
            				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:84:8: el1= var_int_or_double_literal
            				    {
            				    	PushFollow(FOLLOW_var_int_or_double_literal_in_string_literal409);
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

            		char_literal18=(IToken)Match(input,27,FOLLOW_27_in_string_literal414); 
            			char_literal18_tree = (object)adaptor.Create(char_literal18);
            			adaptor.AddChild(root_0, char_literal18_tree);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:86:1: matrixvardec returns [MatrixVariableDeclaration ret] : ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:90:2: ( ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:90:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:90:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:90:4: 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']'
            	{
            		string_literal19=(IToken)Match(input,28,FOLLOW_28_in_matrixvardec434); 
            			string_literal19_tree = (object)adaptor.Create(string_literal19);
            			adaptor.AddChild(root_0, string_literal19_tree);

            		char_literal20=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixvardec436); 
            			char_literal20_tree = (object)adaptor.Create(char_literal20);
            			adaptor.AddChild(root_0, char_literal20_tree);

            		VARTYPE21=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixvardec438); 
            			VARTYPE21_tree = (object)adaptor.Create(VARTYPE21);
            			adaptor.AddChild(root_0, VARTYPE21_tree);

            		 retval.ret.setType(((VARTYPE21 != null) ? VARTYPE21.Text : null));
            		char_literal22=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec441); 
            			char_literal22_tree = (object)adaptor.Create(char_literal22);
            			adaptor.AddChild(root_0, char_literal22_tree);

            		char_literal23=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec443); 
            			char_literal23_tree = (object)adaptor.Create(char_literal23);
            			adaptor.AddChild(root_0, char_literal23_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec446);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            		char_literal24=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec449); 
            			char_literal24_tree = (object)adaptor.Create(char_literal24);
            			adaptor.AddChild(root_0, char_literal24_tree);

            		char_literal25=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec452); 
            			char_literal25_tree = (object)adaptor.Create(char_literal25);
            			adaptor.AddChild(root_0, char_literal25_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec456);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            		char_literal26=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec459); 
            			char_literal26_tree = (object)adaptor.Create(char_literal26);
            			adaptor.AddChild(root_0, char_literal26_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:92:3: (el3= variable )
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:92:4: el3= variable
            		{
            			PushFollow(FOLLOW_variable_in_matrixvardec467);
            			el3 = variable();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el3.Tree);
            			 retval.ret.setVar(((el3 != null) ? el3.ret : null));

            		}

            		ASSIGNMENT27=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matrixvardec474); 
            			ASSIGNMENT27_tree = (object)adaptor.Create(ASSIGNMENT27);
            			adaptor.AddChild(root_0, ASSIGNMENT27_tree);

            		char_literal28=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec478); 
            			char_literal28_tree = (object)adaptor.Create(char_literal28);
            			adaptor.AddChild(root_0, char_literal28_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:94:6: ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) )
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:94:7: (el7= int_literal ( ',' el5= int_literal )* )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:94:7: (el7= int_literal ( ',' el5= int_literal )* )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:94:8: el7= int_literal ( ',' el5= int_literal )*
            		        	{
            		        		PushFollow(FOLLOW_int_literal_in_matrixvardec483);
            		        		el7 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el7.Tree);
            		        		retval.ret.addValue(((el7 != null) ? el7.ret : null));
            		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:94:57: ( ',' el5= int_literal )*
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
            		        				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:94:58: ',' el5= int_literal
            		        				    {
            		        				    	char_literal29=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec488); 
            		        				    		char_literal29_tree = (object)adaptor.Create(char_literal29);
            		        				    		adaptor.AddChild(root_0, char_literal29_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_matrixvardec491);
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:95:4: el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		PushFollow(FOLLOW_double_literal_in_matrixvardec504);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:96:3: ( ',' el6= double_literal )*
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
            		        				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:96:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal30=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec511); 
            		        				    		char_literal30_tree = (object)adaptor.Create(char_literal30);
            		        				    		adaptor.AddChild(root_0, char_literal30_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_matrixvardec514);
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

            		char_literal31=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec521); 
            			char_literal31_tree = (object)adaptor.Create(char_literal31);
            			adaptor.AddChild(root_0, char_literal31_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT32=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matrixvardec527); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:99:1: vectorvardec returns [VectorVariableDeclaration ret] : ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:103:2: ( ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:103:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:103:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:103:4: 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']'
            	{
            		string_literal33=(IToken)Match(input,32,FOLLOW_32_in_vectorvardec545); 
            			string_literal33_tree = (object)adaptor.Create(string_literal33);
            			adaptor.AddChild(root_0, string_literal33_tree);

            		char_literal34=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorvardec547); 
            			char_literal34_tree = (object)adaptor.Create(char_literal34);
            			adaptor.AddChild(root_0, char_literal34_tree);

            		VARTYPE35=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorvardec549); 
            			VARTYPE35_tree = (object)adaptor.Create(VARTYPE35);
            			adaptor.AddChild(root_0, VARTYPE35_tree);

            		 retval.ret.setType(((VARTYPE35 != null) ? VARTYPE35.Text : null));
            		char_literal36=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec552); 
            			char_literal36_tree = (object)adaptor.Create(char_literal36);
            			adaptor.AddChild(root_0, char_literal36_tree);

            		char_literal37=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec554); 
            			char_literal37_tree = (object)adaptor.Create(char_literal37);
            			adaptor.AddChild(root_0, char_literal37_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorvardec557);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setRange(((el1 != null) ? el1.ret : null));
            		char_literal38=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec560); 
            			char_literal38_tree = (object)adaptor.Create(char_literal38);
            			adaptor.AddChild(root_0, char_literal38_tree);

            		PushFollow(FOLLOW_variable_in_vectorvardec566);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setText(((el2 != null) ? el2.ret : null));
            		ASSIGNMENT39=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_vectorvardec573); 
            			ASSIGNMENT39_tree = (object)adaptor.Create(ASSIGNMENT39);
            			adaptor.AddChild(root_0, ASSIGNMENT39_tree);

            		char_literal40=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec578); 
            			char_literal40_tree = (object)adaptor.Create(char_literal40);
            			adaptor.AddChild(root_0, char_literal40_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:106:6: ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) )
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:106:7: (el3= int_literal ( ',' el5= int_literal )* )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:106:7: (el3= int_literal ( ',' el5= int_literal )* )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:106:8: el3= int_literal ( ',' el5= int_literal )*
            		        	{
            		        		PushFollow(FOLLOW_int_literal_in_vectorvardec583);
            		        		el3 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el3.Tree);
            		        		retval.ret.addValue(((el3 != null) ? el3.ret : null));
            		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:106:57: ( ',' el5= int_literal )*
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
            		        				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:106:58: ',' el5= int_literal
            		        				    {
            		        				    	char_literal41=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec588); 
            		        				    		char_literal41_tree = (object)adaptor.Create(char_literal41);
            		        				    		adaptor.AddChild(root_0, char_literal41_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_vectorvardec591);
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:107:4: el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		PushFollow(FOLLOW_double_literal_in_vectorvardec604);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:108:3: ( ',' el6= double_literal )*
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
            		        				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:108:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal42=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec611); 
            		        				    		char_literal42_tree = (object)adaptor.Create(char_literal42);
            		        				    		adaptor.AddChild(root_0, char_literal42_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_vectorvardec614);
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

            		char_literal43=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec621); 
            			char_literal43_tree = (object)adaptor.Create(char_literal43);
            			adaptor.AddChild(root_0, char_literal43_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT44=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_vectorvardec627); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:111:1: matrixelem returns [MatrixElement ret] : (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' ) ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:115:2: ( (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:115:3: (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:115:3: (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:115:4: el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']'
            	{
            		PushFollow(FOLLOW_variable_in_matrixelem647);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal45=(IToken)Match(input,29,FOLLOW_29_in_matrixelem650); 
            			char_literal45_tree = (object)adaptor.Create(char_literal45);
            			adaptor.AddChild(root_0, char_literal45_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixelem653);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setRow(((el2 != null) ? el2.ret : null));
            		char_literal46=(IToken)Match(input,30,FOLLOW_30_in_matrixelem655); 
            			char_literal46_tree = (object)adaptor.Create(char_literal46);
            			adaptor.AddChild(root_0, char_literal46_tree);

            		char_literal47=(IToken)Match(input,29,FOLLOW_29_in_matrixelem658); 
            			char_literal47_tree = (object)adaptor.Create(char_literal47);
            			adaptor.AddChild(root_0, char_literal47_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixelem661);
            		el3 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el3.Tree);
            		retval.ret.setColumn(((el3 != null) ? el3.ret : null));
            		char_literal48=(IToken)Match(input,30,FOLLOW_30_in_matrixelem663); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:118:1: vectorelem returns [VectorElement ret] : (el1= variable '[' el2= int_literal ']' ) ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:122:2: ( (el1= variable '[' el2= int_literal ']' ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:122:3: (el1= variable '[' el2= int_literal ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:122:3: (el1= variable '[' el2= int_literal ']' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:122:4: el1= variable '[' el2= int_literal ']'
            	{
            		PushFollow(FOLLOW_variable_in_vectorelem685);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal49=(IToken)Match(input,29,FOLLOW_29_in_vectorelem688); 
            			char_literal49_tree = (object)adaptor.Create(char_literal49);
            			adaptor.AddChild(root_0, char_literal49_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorelem691);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setRange(((el2 != null) ? el2.ret : null));
            		char_literal50=(IToken)Match(input,30,FOLLOW_30_in_vectorelem694); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:124:1: assignment returns [AssignmentOperationElement ret] : ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) ) ;
    public spinachParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        spinachParser.assignment_return retval = new spinachParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT53 = null;
        IToken END_OF_STATEMENT58 = null;
        spinachParser.vectorelem_return e12 = null;

        spinachParser.matrixelem_return e11 = null;

        spinachParser.variable_return variable51 = null;

        spinachParser.structassign_return structassign52 = null;

        spinachParser.subtractive_exp_return subtractive_exp54 = null;

        spinachParser.dotproduct_return dotproduct55 = null;

        spinachParser.matrixtranspose_return matrixtranspose56 = null;

        spinachParser.string_literal_return string_literal57 = null;

        spinachParser.functioncall_return functioncall59 = null;


        object ASSIGNMENT53_tree=null;
        object END_OF_STATEMENT58_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:128:3: ( ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:128:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:128:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall ) )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:128:6: ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall )
            	{
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:128:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )
            		int alt14 = 4;
            		int LA14_0 = input.LA(1);

            		if ( (LA14_0 == VARIABLE) )
            		{
            		    switch ( input.LA(2) ) 
            		    {
            		    case DOT:
            		    	{
            		        alt14 = 2;
            		        }
            		        break;
            		    case 29:
            		    	{
            		        int LA14_3 = input.LA(3);

            		        if ( (LA14_3 == INT_LITERAL) )
            		        {
            		            int LA14_5 = input.LA(4);

            		            if ( (LA14_5 == 30) )
            		            {
            		                int LA14_6 = input.LA(5);

            		                if ( (LA14_6 == 29) )
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
            		            NoViableAltException nvae_d14s3 =
            		                new NoViableAltException("", 14, 3, input);

            		            throw nvae_d14s3;
            		        }
            		        }
            		        break;
            		    case ASSIGNMENT:
            		    	{
            		        alt14 = 1;
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:128:7: variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_assignment717);
            		        	variable51 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, variable51.Tree);
            		        	retval.ret.setLhs(((variable51 != null) ? variable51.ret : null)); 

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:129:7: structassign
            		        {
            		        	PushFollow(FOLLOW_structassign_in_assignment727);
            		        	structassign52 = structassign();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, structassign52.Tree);
            		        	retval.ret.setLhs(((structassign52 != null) ? structassign52.ret : null));

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:130:6: e12= vectorelem
            		        {
            		        	PushFollow(FOLLOW_vectorelem_in_assignment739);
            		        	e12 = vectorelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e12.Tree);
            		        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:131:7: e11= matrixelem
            		        {
            		        	PushFollow(FOLLOW_matrixelem_in_assignment752);
            		        	e11 = matrixelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e11.Tree);
            		        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		        }
            		        break;

            		}

            		ASSIGNMENT53=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment760); 
            			ASSIGNMENT53_tree = (object)adaptor.Create(ASSIGNMENT53);
            			adaptor.AddChild(root_0, ASSIGNMENT53_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:133:5: ( ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT | functioncall )
            		int alt16 = 2;
            		int LA16_0 = input.LA(1);

            		if ( ((LA16_0 >= INT_LITERAL && LA16_0 <= DOUBLE_LITERAL) || LA16_0 == LEFTBRACE || LA16_0 == 27 || LA16_0 == 45) )
            		{
            		    alt16 = 1;
            		}
            		else if ( (LA16_0 == VARIABLE) )
            		{
            		    int LA16_2 = input.LA(2);

            		    if ( (LA16_2 == END_OF_STATEMENT || (LA16_2 >= DOT && LA16_2 <= MULTIPLY) || LA16_2 == 29 || LA16_2 == 33 || LA16_2 == 44) )
            		    {
            		        alt16 = 1;
            		    }
            		    else if ( (LA16_2 == LEFTBRACE) )
            		    {
            		        alt16 = 2;
            		    }
            		    else 
            		    {
            		        NoViableAltException nvae_d16s2 =
            		            new NoViableAltException("", 16, 2, input);

            		        throw nvae_d16s2;
            		    }
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:133:6: ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) END_OF_STATEMENT
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:133:6: ( subtractive_exp | dotproduct | matrixtranspose | string_literal )
            		        	int alt15 = 4;
            		        	switch ( input.LA(1) ) 
            		        	{
            		        	case INT_LITERAL:
            		        	case DOUBLE_LITERAL:
            		        	case LEFTBRACE:
            		        		{
            		        	    alt15 = 1;
            		        	    }
            		        	    break;
            		        	case VARIABLE:
            		        		{
            		        	    int LA15_2 = input.LA(2);

            		        	    if ( (LA15_2 == END_OF_STATEMENT || (LA15_2 >= DOT && LA15_2 <= MULTIPLY) || LA15_2 == 29 || LA15_2 == 33) )
            		        	    {
            		        	        alt15 = 1;
            		        	    }
            		        	    else if ( (LA15_2 == 44) )
            		        	    {
            		        	        alt15 = 2;
            		        	    }
            		        	    else 
            		        	    {
            		        	        NoViableAltException nvae_d15s2 =
            		        	            new NoViableAltException("", 15, 2, input);

            		        	        throw nvae_d15s2;
            		        	    }
            		        	    }
            		        	    break;
            		        	case 45:
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
            		        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:133:8: subtractive_exp
            		        	        {
            		        	        	PushFollow(FOLLOW_subtractive_exp_in_assignment770);
            		        	        	subtractive_exp54 = subtractive_exp();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, subtractive_exp54.Tree);
            		        	        	retval.ret.setRhs(((subtractive_exp54 != null) ? subtractive_exp54.ret : null));

            		        	        }
            		        	        break;
            		        	    case 2 :
            		        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:133:67: dotproduct
            		        	        {
            		        	        	PushFollow(FOLLOW_dotproduct_in_assignment774);
            		        	        	dotproduct55 = dotproduct();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, dotproduct55.Tree);
            		        	        	retval.ret.setRhs(((dotproduct55 != null) ? dotproduct55.ret : null));

            		        	        }
            		        	        break;
            		        	    case 3 :
            		        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:134:7: matrixtranspose
            		        	        {
            		        	        	PushFollow(FOLLOW_matrixtranspose_in_assignment783);
            		        	        	matrixtranspose56 = matrixtranspose();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, matrixtranspose56.Tree);
            		        	        	retval.ret.setRhs(((matrixtranspose56 != null) ? matrixtranspose56.ret : null));

            		        	        }
            		        	        break;
            		        	    case 4 :
            		        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:134:66: string_literal
            		        	        {
            		        	        	PushFollow(FOLLOW_string_literal_in_assignment787);
            		        	        	string_literal57 = string_literal();
            		        	        	state.followingStackPointer--;

            		        	        	adaptor.AddChild(root_0, string_literal57.Tree);
            		        	        	retval.ret.setRhs(((string_literal57 != null) ? string_literal57.ret : null));

            		        	        }
            		        	        break;

            		        	}

            		        	END_OF_STATEMENT58=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment795); 
            		        		END_OF_STATEMENT58_tree = (object)adaptor.Create(END_OF_STATEMENT58);
            		        		adaptor.AddChild(root_0, END_OF_STATEMENT58_tree);


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:136:7: functioncall
            		        {
            		        	PushFollow(FOLLOW_functioncall_in_assignment803);
            		        	functioncall59 = functioncall();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, functioncall59.Tree);
            		        	retval.ret.setRhs(((functioncall59 != null) ? functioncall59.ret : null));

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:139:1: additive_expression returns [AdditiveElement ret] : ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:143:2: ( ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:143:4: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:143:4: ( (e11= multiplicative_expression ) ( '+' e12= additive_expression )* )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:143:5: (e11= multiplicative_expression ) ( '+' e12= additive_expression )*
            	{
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:143:5: (e11= multiplicative_expression )
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:143:6: e11= multiplicative_expression
            		{
            			PushFollow(FOLLOW_multiplicative_expression_in_additive_expression834);
            			e11 = multiplicative_expression();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, e11.Tree);
            			retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		}

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:143:69: ( '+' e12= additive_expression )*
            		do 
            		{
            		    int alt17 = 2;
            		    int LA17_0 = input.LA(1);

            		    if ( (LA17_0 == PLUS) )
            		    {
            		        alt17 = 1;
            		    }


            		    switch (alt17) 
            			{
            				case 1 :
            				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:143:70: '+' e12= additive_expression
            				    {
            				    	char_literal60=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_additive_expression839); 
            				    		char_literal60_tree = (object)adaptor.Create(char_literal60);
            				    		adaptor.AddChild(root_0, char_literal60_tree);

            				    	PushFollow(FOLLOW_additive_expression_in_additive_expression845);
            				    	e12 = additive_expression();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop17;
            		    }
            		} while (true);

            		loop17:
            			;	// Stops C# compiler whining that label 'loop17' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:146:1: multiplicative_expression returns [MultiplicationElement ret] : (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )* ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:150:2: ( (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )* )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:150:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' el5= multiplicative_expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:150:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem )
            	int alt18 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case INT_LITERAL:
            	case DOUBLE_LITERAL:
            		{
            	    alt18 = 1;
            	    }
            	    break;
            	case VARIABLE:
            		{
            	    int LA18_2 = input.LA(2);

            	    if ( (LA18_2 == END_OF_STATEMENT || LA18_2 == RIGHTBRACE || (LA18_2 >= DOT && LA18_2 <= MULTIPLY) || LA18_2 == 33) )
            	    {
            	        alt18 = 1;
            	    }
            	    else if ( (LA18_2 == 29) )
            	    {
            	        int LA18_4 = input.LA(3);

            	        if ( (LA18_4 == INT_LITERAL) )
            	        {
            	            int LA18_5 = input.LA(4);

            	            if ( (LA18_5 == 30) )
            	            {
            	                int LA18_6 = input.LA(5);

            	                if ( (LA18_6 == 29) )
            	                {
            	                    alt18 = 3;
            	                }
            	                else if ( (LA18_6 == END_OF_STATEMENT || LA18_6 == RIGHTBRACE || (LA18_6 >= PLUS && LA18_6 <= MULTIPLY) || LA18_6 == 33) )
            	                {
            	                    alt18 = 4;
            	                }
            	                else 
            	                {
            	                    NoViableAltException nvae_d18s6 =
            	                        new NoViableAltException("", 18, 6, input);

            	                    throw nvae_d18s6;
            	                }
            	            }
            	            else 
            	            {
            	                NoViableAltException nvae_d18s5 =
            	                    new NoViableAltException("", 18, 5, input);

            	                throw nvae_d18s5;
            	            }
            	        }
            	        else 
            	        {
            	            NoViableAltException nvae_d18s4 =
            	                new NoViableAltException("", 18, 4, input);

            	            throw nvae_d18s4;
            	        }
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d18s2 =
            	            new NoViableAltException("", 18, 2, input);

            	        throw nvae_d18s2;
            	    }
            	    }
            	    break;
            	case LEFTBRACE:
            		{
            	    alt18 = 2;
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
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:150:5: e11= var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplicative_expression873);
            	        	e11 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e11.Tree);
            	        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:151:7: e12= bracket_exp
            	        {
            	        	PushFollow(FOLLOW_bracket_exp_in_multiplicative_expression885);
            	        	e12 = bracket_exp();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e12.Tree);
            	        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:152:7: el3= matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_multiplicative_expression898);
            	        	el3 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el3.Tree);
            	        	retval.ret.setLhs(((el3 != null) ? el3.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:153:7: el4= vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_multiplicative_expression911);
            	        	el4 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	retval.ret.setLhs(((el4 != null) ? el4.ret : null));

            	        }
            	        break;

            	}

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:154:5: ( '*' el5= multiplicative_expression )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == MULTIPLY) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:154:6: '*' el5= multiplicative_expression
            			    {
            			    	char_literal61=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplicative_expression920); 
            			    		char_literal61_tree = (object)adaptor.Create(char_literal61);
            			    		adaptor.AddChild(root_0, char_literal61_tree);

            			    	PushFollow(FOLLOW_multiplicative_expression_in_multiplicative_expression942);
            			    	el5 = multiplicative_expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, el5.Tree);
            			    	retval.ret.setRhs(el5.ret);

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:165:1: bracket_exp returns [BracketElement ret] : '(' subtractive_exp ')' ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:169:1: ( '(' subtractive_exp ')' )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:169:3: '(' subtractive_exp ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal62=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_bracket_exp988); 
            		char_literal62_tree = (object)adaptor.Create(char_literal62);
            		adaptor.AddChild(root_0, char_literal62_tree);

            	PushFollow(FOLLOW_subtractive_exp_in_bracket_exp989);
            	subtractive_exp63 = subtractive_exp();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, subtractive_exp63.Tree);
            	retval.ret.setbracketexpression(((subtractive_exp63 != null) ? subtractive_exp63.ret : null));
            	char_literal64=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_bracket_exp991); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:175:1: subtractive_exp returns [SubtractionElement ret] : (e11= additive_expression ( '-' e12= subtractive_exp )* ) ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:179:1: ( (e11= additive_expression ( '-' e12= subtractive_exp )* ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:179:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:179:6: (e11= additive_expression ( '-' e12= subtractive_exp )* )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:179:7: e11= additive_expression ( '-' e12= subtractive_exp )*
            	{
            		PushFollow(FOLLOW_additive_expression_in_subtractive_exp1020);
            		e11 = additive_expression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, e11.Tree);
            		retval.ret.setLhs(((e11 != null) ? e11.ret : null));
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:179:64: ( '-' e12= subtractive_exp )*
            		do 
            		{
            		    int alt20 = 2;
            		    int LA20_0 = input.LA(1);

            		    if ( (LA20_0 == 33) )
            		    {
            		        alt20 = 1;
            		    }


            		    switch (alt20) 
            			{
            				case 1 :
            				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:179:65: '-' e12= subtractive_exp
            				    {
            				    	char_literal65=(IToken)Match(input,33,FOLLOW_33_in_subtractive_exp1025); 
            				    		char_literal65_tree = (object)adaptor.Create(char_literal65);
            				    		adaptor.AddChild(root_0, char_literal65_tree);

            				    	PushFollow(FOLLOW_subtractive_exp_in_subtractive_exp1031);
            				    	e12 = subtractive_exp();
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:183:1: structdec returns [StructDeclaration ret] : ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:187:1: ( ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:187:3: ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:187:3: ( 'struct' variable '{' (el1= scalarvardec )+ '}' )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:187:4: 'struct' variable '{' (el1= scalarvardec )+ '}'
            	{
            		string_literal66=(IToken)Match(input,34,FOLLOW_34_in_structdec1061); 
            			string_literal66_tree = (object)adaptor.Create(string_literal66);
            			adaptor.AddChild(root_0, string_literal66_tree);

            		PushFollow(FOLLOW_variable_in_structdec1063);
            		variable67 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable67.Tree);
            		 retval.ret.setName(((variable67 != null) ? variable67.ret : null));
            		char_literal68=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_structdec1067); 
            			char_literal68_tree = (object)adaptor.Create(char_literal68);
            			adaptor.AddChild(root_0, char_literal68_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:188:5: (el1= scalarvardec )+
            		int cnt21 = 0;
            		do 
            		{
            		    int alt21 = 2;
            		    int LA21_0 = input.LA(1);

            		    if ( (LA21_0 == VARTYPE || LA21_0 == STRINGTYPE) )
            		    {
            		        alt21 = 1;
            		    }


            		    switch (alt21) 
            			{
            				case 1 :
            				    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:188:6: el1= scalarvardec
            				    {
            				    	PushFollow(FOLLOW_scalarvardec_in_structdec1072);
            				    	el1 = scalarvardec();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	 retval.ret.setVarType(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    if ( cnt21 >= 1 ) goto loop21;
            			            EarlyExitException eee21 =
            			                new EarlyExitException(21, input);
            			            throw eee21;
            		    }
            		    cnt21++;
            		} while (true);

            		loop21:
            			;	// Stops C# compiler whining that label 'loop21' has no statements

            		char_literal69=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_structdec1078); 
            			char_literal69_tree = (object)adaptor.Create(char_literal69);
            			adaptor.AddChild(root_0, char_literal69_tree);


            	}

            	END_OF_STATEMENT70=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec1080); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:191:1: scalarvardec returns [ScalarVariableDeclaration ret] : ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:195:2: ( ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:195:3: ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:195:3: ( ( VARTYPE | STRINGTYPE ) variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:195:4: ( VARTYPE | STRINGTYPE ) variable
            	{
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:195:4: ( VARTYPE | STRINGTYPE )
            		int alt22 = 2;
            		int LA22_0 = input.LA(1);

            		if ( (LA22_0 == VARTYPE) )
            		{
            		    alt22 = 1;
            		}
            		else if ( (LA22_0 == STRINGTYPE) )
            		{
            		    alt22 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d22s0 =
            		        new NoViableAltException("", 22, 0, input);

            		    throw nvae_d22s0;
            		}
            		switch (alt22) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:195:5: VARTYPE
            		        {
            		        	VARTYPE71=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarvardec1101); 
            		        		VARTYPE71_tree = (object)adaptor.Create(VARTYPE71);
            		        		adaptor.AddChild(root_0, VARTYPE71_tree);

            		        	 retval.ret.setType(((VARTYPE71 != null) ? VARTYPE71.Text : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:196:4: STRINGTYPE
            		        {
            		        	STRINGTYPE72=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_scalarvardec1108); 
            		        		STRINGTYPE72_tree = (object)adaptor.Create(STRINGTYPE72);
            		        		adaptor.AddChild(root_0, STRINGTYPE72_tree);

            		        	 retval.ret.setType(((STRINGTYPE72 != null) ? STRINGTYPE72.Text : null));

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_variable_in_scalarvardec1115);
            		variable73 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable73.Tree);
            		 retval.ret.setVar(((variable73 != null) ? variable73.ret : null));

            	}

            	END_OF_STATEMENT74=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_scalarvardec1119); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:200:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:204:1: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:204:3: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:204:3: (el1= variable el2= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:204:4: el1= variable el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structobjdec1141);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		PushFollow(FOLLOW_variable_in_structobjdec1148);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	END_OF_STATEMENT75=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec1154); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:208:1: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:212:1: ( (el1= variable '.' el2= variable ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:212:2: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:212:2: (el1= variable '.' el2= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:212:3: el1= variable '.' el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structassign1174);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setName(((el1 != null) ? el1.ret : null));
            		char_literal76=(IToken)Match(input,DOT,FOLLOW_DOT_in_structassign1177); 
            			char_literal76_tree = (object)adaptor.Create(char_literal76);
            			adaptor.AddChild(root_0, char_literal76_tree);

            		PushFollow(FOLLOW_variable_in_structassign1180);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:214:1: deletionofvar returns [DeleteVariable ret] : ( 'delete' el1= variable ) END_OF_STATEMENT ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:218:1: ( ( 'delete' el1= variable ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:218:2: ( 'delete' el1= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:218:2: ( 'delete' el1= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:218:3: 'delete' el1= variable
            	{
            		string_literal77=(IToken)Match(input,35,FOLLOW_35_in_deletionofvar1200); 
            			string_literal77_tree = (object)adaptor.Create(string_literal77);
            			adaptor.AddChild(root_0, string_literal77_tree);

            		PushFollow(FOLLOW_variable_in_deletionofvar1204);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setVar(((el1 != null) ? el1.ret : null));

            	}

            	END_OF_STATEMENT78=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_deletionofvar1208); 
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:220:1: print returns [PrintOperationElement ret] : 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT ;
    public spinachParser.print_return print() // throws RecognitionException [1]
    {   
        spinachParser.print_return retval = new spinachParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal79 = null;
        IToken END_OF_STATEMENT84 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal80 = null;

        spinachParser.string_literal_return string_literal81 = null;

        spinachParser.vectorelem_return vectorelem82 = null;

        spinachParser.matrixelem_return matrixelem83 = null;


        object string_literal79_tree=null;
        object END_OF_STATEMENT84_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:224:3: ( 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:224:5: 'print' ( var_int_or_double_literal | string_literal | vectorelem | matrixelem ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal79=(IToken)Match(input,36,FOLLOW_36_in_print1227); 
            		string_literal79_tree = (object)adaptor.Create(string_literal79);
            		adaptor.AddChild(root_0, string_literal79_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:224:13: ( var_int_or_double_literal | string_literal | vectorelem | matrixelem )
            	int alt23 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case INT_LITERAL:
            	case DOUBLE_LITERAL:
            		{
            	    alt23 = 1;
            	    }
            	    break;
            	case VARIABLE:
            		{
            	    int LA23_2 = input.LA(2);

            	    if ( (LA23_2 == 29) )
            	    {
            	        int LA23_4 = input.LA(3);

            	        if ( (LA23_4 == INT_LITERAL) )
            	        {
            	            int LA23_5 = input.LA(4);

            	            if ( (LA23_5 == 30) )
            	            {
            	                int LA23_6 = input.LA(5);

            	                if ( (LA23_6 == 29) )
            	                {
            	                    alt23 = 4;
            	                }
            	                else if ( (LA23_6 == END_OF_STATEMENT) )
            	                {
            	                    alt23 = 3;
            	                }
            	                else 
            	                {
            	                    NoViableAltException nvae_d23s6 =
            	                        new NoViableAltException("", 23, 6, input);

            	                    throw nvae_d23s6;
            	                }
            	            }
            	            else 
            	            {
            	                NoViableAltException nvae_d23s5 =
            	                    new NoViableAltException("", 23, 5, input);

            	                throw nvae_d23s5;
            	            }
            	        }
            	        else 
            	        {
            	            NoViableAltException nvae_d23s4 =
            	                new NoViableAltException("", 23, 4, input);

            	            throw nvae_d23s4;
            	        }
            	    }
            	    else if ( (LA23_2 == END_OF_STATEMENT || LA23_2 == DOT) )
            	    {
            	        alt23 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d23s2 =
            	            new NoViableAltException("", 23, 2, input);

            	        throw nvae_d23s2;
            	    }
            	    }
            	    break;
            	case 27:
            		{
            	    alt23 = 2;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d23s0 =
            		        new NoViableAltException("", 23, 0, input);

            		    throw nvae_d23s0;
            	}

            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:224:14: var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_print1230);
            	        	var_int_or_double_literal80 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_int_or_double_literal80.Tree);
            	        	retval.ret.setChildElement(((var_int_or_double_literal80 != null) ? var_int_or_double_literal80.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:225:6: string_literal
            	        {
            	        	PushFollow(FOLLOW_string_literal_in_print1239);
            	        	string_literal81 = string_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, string_literal81.Tree);
            	        	retval.ret.setChildElement(((string_literal81 != null) ? string_literal81.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:226:6: vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_print1247);
            	        	vectorelem82 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorelem82.Tree);
            	        	retval.ret.setChildElement(((vectorelem82 != null) ? vectorelem82.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:227:8: matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_print1258);
            	        	matrixelem83 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixelem83.Tree);
            	        	retval.ret.setChildElement(((matrixelem83 != null) ? matrixelem83.ret : null));

            	        }
            	        break;

            	}

            	END_OF_STATEMENT84=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print1272); 
            		END_OF_STATEMENT84_tree = (object)adaptor.Create(END_OF_STATEMENT84);
            		adaptor.AddChild(root_0, END_OF_STATEMENT84_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:232:1: parallelfor returns [ParallelForElement ret] : 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS ;
    public spinachParser.parallelfor_return parallelfor() // throws RecognitionException [1]
    {   
        spinachParser.parallelfor_return retval = new spinachParser.parallelfor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal85 = null;
        IToken LEFTBRACE86 = null;
        IToken POINT87 = null;
        IToken string_literal88 = null;
        IToken RIGHTBRACE89 = null;
        IToken LEFTPARANTHESIS90 = null;
        IToken string_literal91 = null;
        IToken END_OF_STATEMENT92 = null;
        IToken RIGHTPARANTHESIS93 = null;
        spinachParser.variable_return r11 = null;

        spinachParser.int_literal_return r12 = null;

        spinachParser.int_literal_return r13 = null;

        spinachParser.expr2_return e11 = null;


        object string_literal85_tree=null;
        object LEFTBRACE86_tree=null;
        object POINT87_tree=null;
        object string_literal88_tree=null;
        object RIGHTBRACE89_tree=null;
        object LEFTPARANTHESIS90_tree=null;
        object string_literal91_tree=null;
        object END_OF_STATEMENT92_tree=null;
        object RIGHTPARANTHESIS93_tree=null;


          retval.ret = new ParallelForElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:2: ( 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:4: 'parallelfor' LEFTBRACE r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal85=(IToken)Match(input,37,FOLLOW_37_in_parallelfor1294); 
            		string_literal85_tree = (object)adaptor.Create(string_literal85);
            		adaptor.AddChild(root_0, string_literal85_tree);

            	LEFTBRACE86=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_parallelfor1295); 
            		LEFTBRACE86_tree = (object)adaptor.Create(LEFTBRACE86);
            		adaptor.AddChild(root_0, LEFTBRACE86_tree);

            	PushFollow(FOLLOW_variable_in_parallelfor1301);
            	r11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGEVARIABLE = ((r11 != null) ? r11.ret : null);
            	POINT87=(IToken)Match(input,POINT,FOLLOW_POINT_in_parallelfor1304); 
            		POINT87_tree = (object)adaptor.Create(POINT87);
            		adaptor.AddChild(root_0, POINT87_tree);

            	PushFollow(FOLLOW_int_literal_in_parallelfor1310);
            	r12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r12.Tree);
            	retval.ret.STARTINGRANGE = ((r12 != null) ? r12.ret : null);
            	string_literal88=(IToken)Match(input,38,FOLLOW_38_in_parallelfor1313); 
            		string_literal88_tree = (object)adaptor.Create(string_literal88);
            		adaptor.AddChild(root_0, string_literal88_tree);

            	PushFollow(FOLLOW_int_literal_in_parallelfor1318);
            	r13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r13.Tree);
            	retval.ret.ENDINGRANGE = ((r13 != null) ? r13.ret : null);
            	RIGHTBRACE89=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_parallelfor1321); 
            		RIGHTBRACE89_tree = (object)adaptor.Create(RIGHTBRACE89);
            		adaptor.AddChild(root_0, RIGHTBRACE89_tree);

            	LEFTPARANTHESIS90=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_parallelfor1323); 
            		LEFTPARANTHESIS90_tree = (object)adaptor.Create(LEFTPARANTHESIS90);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS90_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:228: ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+
            	int cnt26 = 0;
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( (LA26_0 == VARIABLE || LA26_0 == VARTYPE || LA26_0 == STRINGTYPE || LA26_0 == 32 || (LA26_0 >= 35 && LA26_0 <= 36) || LA26_0 == 40 || LA26_0 == 42 || LA26_0 == 46) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:229: (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    {
            			    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:229: (e11= expr2 )+
            			    	int cnt24 = 0;
            			    	do 
            			    	{
            			    	    int alt24 = 2;
            			    	    alt24 = dfa24.Predict(input);
            			    	    switch (alt24) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:230: e11= expr2
            			    			    {
            			    			    	PushFollow(FOLLOW_expr2_in_parallelfor1330);
            			    			    	e11 = expr2();
            			    			    	state.followingStackPointer--;

            			    			    	adaptor.AddChild(root_0, e11.Tree);
            			    			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

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

            			    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:272: ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    	int alt25 = 2;
            			    	int LA25_0 = input.LA(1);

            			    	if ( (LA25_0 == 39) )
            			    	{
            			    	    alt25 = 1;
            			    	}
            			    	else if ( (LA25_0 == VARIABLE || LA25_0 == VARTYPE || LA25_0 == STRINGTYPE || LA25_0 == RIGHTPARANTHESIS || LA25_0 == 32 || (LA25_0 >= 35 && LA25_0 <= 36) || LA25_0 == 40 || LA25_0 == 42 || LA25_0 == 46) )
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
            			    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:273: ( 'SYNC' END_OF_STATEMENT )
            			    	        {
            			    	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:273: ( 'SYNC' END_OF_STATEMENT )
            			    	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:274: 'SYNC' END_OF_STATEMENT
            			    	        	{
            			    	        		string_literal91=(IToken)Match(input,39,FOLLOW_39_in_parallelfor1336); 
            			    	        			string_literal91_tree = (object)adaptor.Create(string_literal91);
            			    	        			adaptor.AddChild(root_0, string_literal91_tree);

            			    	        		retval.ret.syncfunction();
            			    	        		END_OF_STATEMENT92=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_parallelfor1339); 
            			    	        			END_OF_STATEMENT92_tree = (object)adaptor.Create(END_OF_STATEMENT92);
            			    	        			adaptor.AddChild(root_0, END_OF_STATEMENT92_tree);


            			    	        	}


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:235:327: 
            			    	        {
            			    	        	retval.ret.syncfunction();

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt26 >= 1 ) goto loop26;
            		            EarlyExitException eee26 =
            		                new EarlyExitException(26, input);
            		            throw eee26;
            	    }
            	    cnt26++;
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements

            	RIGHTPARANTHESIS93=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_parallelfor1347); 
            		RIGHTPARANTHESIS93_tree = (object)adaptor.Create(RIGHTPARANTHESIS93);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS93_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:238:1: ifelse returns [IfStatementElement ret] : ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? ;
    public spinachParser.ifelse_return ifelse() // throws RecognitionException [1]
    {   
        spinachParser.ifelse_return retval = new spinachParser.ifelse_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal94 = null;
        IToken LEFTBRACE95 = null;
        IToken string_literal97 = null;
        IToken string_literal98 = null;
        IToken char_literal99 = null;
        IToken string_literal100 = null;
        IToken char_literal101 = null;
        IToken string_literal102 = null;
        IToken RIGHTBRACE103 = null;
        IToken LEFTPARANTHESIS104 = null;
        IToken RIGHTPARANTHESIS105 = null;
        IToken string_literal106 = null;
        IToken LEFTPARANTHESIS107 = null;
        IToken RIGHTPARANTHESIS108 = null;
        spinachParser.var_int_or_double_literal_return e13 = null;

        spinachParser.string_literal_return e14 = null;

        spinachParser.ifloop_return e11 = null;

        spinachParser.ifloop_return e12 = null;

        spinachParser.varorstruct_return varorstruct96 = null;


        object string_literal94_tree=null;
        object LEFTBRACE95_tree=null;
        object string_literal97_tree=null;
        object string_literal98_tree=null;
        object char_literal99_tree=null;
        object string_literal100_tree=null;
        object char_literal101_tree=null;
        object string_literal102_tree=null;
        object RIGHTBRACE103_tree=null;
        object LEFTPARANTHESIS104_tree=null;
        object RIGHTPARANTHESIS105_tree=null;
        object string_literal106_tree=null;
        object LEFTPARANTHESIS107_tree=null;
        object RIGHTPARANTHESIS108_tree=null;


           retval.ret = new IfStatementElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:242:1: ( ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:242:2: ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:242:2: ( 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:242:3: 'if' LEFTBRACE ( varorstruct ) ( '==' | '!=' | '<' | '<=' | '>' | '>=' ) (e13= var_int_or_double_literal | e14= string_literal ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS
            	{
            		string_literal94=(IToken)Match(input,40,FOLLOW_40_in_ifelse1364); 
            			string_literal94_tree = (object)adaptor.Create(string_literal94);
            			adaptor.AddChild(root_0, string_literal94_tree);

            		LEFTBRACE95=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_ifelse1366); 
            			LEFTBRACE95_tree = (object)adaptor.Create(LEFTBRACE95);
            			adaptor.AddChild(root_0, LEFTBRACE95_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:242:18: ( varorstruct )
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:242:19: varorstruct
            		{
            			PushFollow(FOLLOW_varorstruct_in_ifelse1369);
            			varorstruct96 = varorstruct();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, varorstruct96.Tree);
            			retval.ret.setLhs(((varorstruct96 != null) ? varorstruct96.ret : null));

            		}

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:242:69: ( '==' | '!=' | '<' | '<=' | '>' | '>=' )
            		int alt27 = 6;
            		switch ( input.LA(1) ) 
            		{
            		case EQUALITYEXPRESSION:
            			{
            		    alt27 = 1;
            		    }
            		    break;
            		case NONEQUALITYEXPRESSION:
            			{
            		    alt27 = 2;
            		    }
            		    break;
            		case LESSTHANEXPRESSION:
            			{
            		    alt27 = 3;
            		    }
            		    break;
            		case LESSTHANEQUALTOEXPRESSION:
            			{
            		    alt27 = 4;
            		    }
            		    break;
            		case GREATERTHANEXPRESSION:
            			{
            		    alt27 = 5;
            		    }
            		    break;
            		case GREATERTHANEQUALTOEXPRESSION:
            			{
            		    alt27 = 6;
            		    }
            		    break;
            			default:
            			    NoViableAltException nvae_d27s0 =
            			        new NoViableAltException("", 27, 0, input);

            			    throw nvae_d27s0;
            		}

            		switch (alt27) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:243:7: '=='
            		        {
            		        	string_literal97=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_ifelse1380); 
            		        		string_literal97_tree = (object)adaptor.Create(string_literal97);
            		        		adaptor.AddChild(root_0, string_literal97_tree);

            		        	 retval.ret.OP = "eq"; 

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:244:7: '!='
            		        {
            		        	string_literal98=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_ifelse1390); 
            		        		string_literal98_tree = (object)adaptor.Create(string_literal98);
            		        		adaptor.AddChild(root_0, string_literal98_tree);

            		        	 retval.ret.OP = "ne"; 

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:245:7: '<'
            		        {
            		        	char_literal99=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_ifelse1400); 
            		        		char_literal99_tree = (object)adaptor.Create(char_literal99);
            		        		adaptor.AddChild(root_0, char_literal99_tree);

            		        	 retval.ret.OP = "lt"; 

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:246:7: '<='
            		        {
            		        	string_literal100=(IToken)Match(input,LESSTHANEQUALTOEXPRESSION,FOLLOW_LESSTHANEQUALTOEXPRESSION_in_ifelse1411); 
            		        		string_literal100_tree = (object)adaptor.Create(string_literal100);
            		        		adaptor.AddChild(root_0, string_literal100_tree);

            		        	 retval.ret.OP = "le"; 

            		        }
            		        break;
            		    case 5 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:247:7: '>'
            		        {
            		        	char_literal101=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_ifelse1421); 
            		        		char_literal101_tree = (object)adaptor.Create(char_literal101);
            		        		adaptor.AddChild(root_0, char_literal101_tree);

            		        	 retval.ret.OP = "gt"; 

            		        }
            		        break;
            		    case 6 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:248:7: '>='
            		        {
            		        	string_literal102=(IToken)Match(input,GREATERTHANEQUALTOEXPRESSION,FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_ifelse1432); 
            		        		string_literal102_tree = (object)adaptor.Create(string_literal102);
            		        		adaptor.AddChild(root_0, string_literal102_tree);

            		        	 retval.ret.OP = "ge"; 

            		        }
            		        break;

            		}

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:1: (e13= var_int_or_double_literal | e14= string_literal )
            		int alt28 = 2;
            		int LA28_0 = input.LA(1);

            		if ( ((LA28_0 >= VARIABLE && LA28_0 <= DOUBLE_LITERAL)) )
            		{
            		    alt28 = 1;
            		}
            		else if ( (LA28_0 == 27) )
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
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:2: e13= var_int_or_double_literal
            		        {
            		        	PushFollow(FOLLOW_var_int_or_double_literal_in_ifelse1445);
            		        	e13 = var_int_or_double_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e13.Tree);
            		        	retval.ret.setRhs(((e13 != null) ? e13.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:64: e14= string_literal
            		        {
            		        	PushFollow(FOLLOW_string_literal_in_ifelse1452);
            		        	e14 = string_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e14.Tree);
            		        	retval.ret.setRhs(((e14 != null) ? e14.ret : null));

            		        }
            		        break;

            		}

            		RIGHTBRACE103=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_ifelse1456); 
            			RIGHTBRACE103_tree = (object)adaptor.Create(RIGHTBRACE103);
            			adaptor.AddChild(root_0, RIGHTBRACE103_tree);

            		LEFTPARANTHESIS104=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1458); 
            			LEFTPARANTHESIS104_tree = (object)adaptor.Create(LEFTPARANTHESIS104);
            			adaptor.AddChild(root_0, LEFTPARANTHESIS104_tree);

            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:143: ( (e11= ifloop ) | )
            		int alt29 = 2;
            		int LA29_0 = input.LA(1);

            		if ( (LA29_0 == VARIABLE || LA29_0 == VARTYPE || LA29_0 == STRINGTYPE || LA29_0 == 28 || LA29_0 == 32 || (LA29_0 >= 34 && LA29_0 <= 37) || LA29_0 == 40 || (LA29_0 >= 42 && LA29_0 <= 43) || (LA29_0 >= 46 && LA29_0 <= 48) || (LA29_0 >= 52 && LA29_0 <= 56)) )
            		{
            		    alt29 = 1;
            		}
            		else if ( (LA29_0 == RIGHTPARANTHESIS) )
            		{
            		    alt29 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d29s0 =
            		        new NoViableAltException("", 29, 0, input);

            		    throw nvae_d29s0;
            		}
            		switch (alt29) 
            		{
            		    case 1 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:144: (e11= ifloop )
            		        {
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:144: (e11= ifloop )
            		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:145: e11= ifloop
            		        	{
            		        		PushFollow(FOLLOW_ifloop_in_ifelse1466);
            		        		e11 = ifloop();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, e11.Tree);
            		        		retval.ret.IFCODE = ((e11 != null) ? e11.ret : null);

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:190: 
            		        {
            		        }
            		        break;

            		}

            		RIGHTPARANTHESIS105=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1471); 
            			RIGHTPARANTHESIS105_tree = (object)adaptor.Create(RIGHTPARANTHESIS105);
            			adaptor.AddChild(root_0, RIGHTPARANTHESIS105_tree);


            	}

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:208: ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == 41) )
            	{
            	    alt31 = 1;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:209: 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS
            	        {
            	        	string_literal106=(IToken)Match(input,41,FOLLOW_41_in_ifelse1474); 
            	        		string_literal106_tree = (object)adaptor.Create(string_literal106);
            	        		adaptor.AddChild(root_0, string_literal106_tree);

            	        	LEFTPARANTHESIS107=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1477); 
            	        		LEFTPARANTHESIS107_tree = (object)adaptor.Create(LEFTPARANTHESIS107);
            	        		adaptor.AddChild(root_0, LEFTPARANTHESIS107_tree);

            	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:233: ( (e12= ifloop ) | )
            	        	int alt30 = 2;
            	        	int LA30_0 = input.LA(1);

            	        	if ( (LA30_0 == VARIABLE || LA30_0 == VARTYPE || LA30_0 == STRINGTYPE || LA30_0 == 28 || LA30_0 == 32 || (LA30_0 >= 34 && LA30_0 <= 37) || LA30_0 == 40 || (LA30_0 >= 42 && LA30_0 <= 43) || (LA30_0 >= 46 && LA30_0 <= 48) || (LA30_0 >= 52 && LA30_0 <= 56)) )
            	        	{
            	        	    alt30 = 1;
            	        	}
            	        	else if ( (LA30_0 == RIGHTPARANTHESIS) )
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
            	        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:234: (e12= ifloop )
            	        	        {
            	        	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:234: (e12= ifloop )
            	        	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:235: e12= ifloop
            	        	        	{
            	        	        		PushFollow(FOLLOW_ifloop_in_ifelse1486);
            	        	        		e12 = ifloop();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, e12.Tree);
            	        	        		retval.ret.ELSECODE = ((e12 != null) ? e12.ret : null);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:250:283: 
            	        	        {
            	        	        }
            	        	        break;

            	        	}

            	        	RIGHTPARANTHESIS108=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1492); 
            	        		RIGHTPARANTHESIS108_tree = (object)adaptor.Create(RIGHTPARANTHESIS108);
            	        		adaptor.AddChild(root_0, RIGHTPARANTHESIS108_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:252:1: ifloop returns [List<Element> ret] : ( expr | functionreturn )+ ;
    public spinachParser.ifloop_return ifloop() // throws RecognitionException [1]
    {   
        spinachParser.ifloop_return retval = new spinachParser.ifloop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr_return expr109 = null;

        spinachParser.functionreturn_return functionreturn110 = null;




           retval.ret = new List<Element>();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:257:1: ( ( expr | functionreturn )+ )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:257:3: ( expr | functionreturn )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:257:3: ( expr | functionreturn )+
            	int cnt32 = 0;
            	do 
            	{
            	    int alt32 = 3;
            	    int LA32_0 = input.LA(1);

            	    if ( (LA32_0 == VARIABLE || LA32_0 == VARTYPE || LA32_0 == STRINGTYPE || LA32_0 == 28 || LA32_0 == 32 || (LA32_0 >= 34 && LA32_0 <= 37) || LA32_0 == 40 || (LA32_0 >= 42 && LA32_0 <= 43) || LA32_0 == 46 || LA32_0 == 48 || (LA32_0 >= 52 && LA32_0 <= 56)) )
            	    {
            	        alt32 = 1;
            	    }
            	    else if ( (LA32_0 == 47) )
            	    {
            	        alt32 = 2;
            	    }


            	    switch (alt32) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:257:4: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_ifloop1513);
            			    	expr109 = expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr109.Tree);
            			    	retval.ret.Add(((expr109 != null) ? expr109.ret : null));

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:257:37: functionreturn
            			    {
            			    	PushFollow(FOLLOW_functionreturn_in_ifloop1516);
            			    	functionreturn110 = functionreturn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, functionreturn110.Tree);
            			    	retval.ret.Add(((functionreturn110 != null) ? functionreturn110.ret : null));

            			    }
            			    break;

            			default:
            			    if ( cnt32 >= 1 ) goto loop32;
            		            EarlyExitException eee32 =
            		                new EarlyExitException(32, input);
            		            throw eee32;
            	    }
            	    cnt32++;
            	} while (true);

            	loop32:
            		;	// Stops C# compiler whining that label 'loop32' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:261:1: forstatement returns [ForStatementElement ret] : 'for' r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS ;
    public spinachParser.forstatement_return forstatement() // throws RecognitionException [1]
    {   
        spinachParser.forstatement_return retval = new spinachParser.forstatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal111 = null;
        IToken POINT112 = null;
        IToken string_literal113 = null;
        IToken RIGHTBRACE114 = null;
        IToken LEFTPARANTHESIS115 = null;
        IToken RIGHTPARANTHESIS116 = null;
        spinachParser.variable_return r11 = null;

        spinachParser.int_literal_return r12 = null;

        spinachParser.int_literal_return r13 = null;

        spinachParser.expr1_return e11 = null;


        object string_literal111_tree=null;
        object POINT112_tree=null;
        object string_literal113_tree=null;
        object RIGHTBRACE114_tree=null;
        object LEFTPARANTHESIS115_tree=null;
        object RIGHTPARANTHESIS116_tree=null;


           retval.ret = new ForStatementElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:264:2: ( 'for' r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:264:3: 'for' r11= variable POINT r12= int_literal 'to' r13= int_literal RIGHTBRACE LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal111=(IToken)Match(input,42,FOLLOW_42_in_forstatement1535); 
            		string_literal111_tree = (object)adaptor.Create(string_literal111);
            		adaptor.AddChild(root_0, string_literal111_tree);

            	PushFollow(FOLLOW_variable_in_forstatement1541);
            	r11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGEVARIABLE = ((r11 != null) ? r11.ret : null);
            	POINT112=(IToken)Match(input,POINT,FOLLOW_POINT_in_forstatement1544); 
            		POINT112_tree = (object)adaptor.Create(POINT112);
            		adaptor.AddChild(root_0, POINT112_tree);

            	PushFollow(FOLLOW_int_literal_in_forstatement1550);
            	r12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r12.Tree);
            	retval.ret.STARTINGRANGE = ((r12 != null) ? r12.ret : null);
            	string_literal113=(IToken)Match(input,38,FOLLOW_38_in_forstatement1553); 
            		string_literal113_tree = (object)adaptor.Create(string_literal113);
            		adaptor.AddChild(root_0, string_literal113_tree);

            	PushFollow(FOLLOW_int_literal_in_forstatement1558);
            	r13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r13.Tree);
            	retval.ret.ENDINGRANGE = ((r13 != null) ? r13.ret : null);
            	RIGHTBRACE114=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_forstatement1561); 
            		RIGHTBRACE114_tree = (object)adaptor.Create(RIGHTBRACE114);
            		adaptor.AddChild(root_0, RIGHTBRACE114_tree);

            	LEFTPARANTHESIS115=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_forstatement1563); 
            		LEFTPARANTHESIS115_tree = (object)adaptor.Create(LEFTPARANTHESIS115);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS115_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:264:209: (e11= expr1 )+
            	int cnt33 = 0;
            	do 
            	{
            	    int alt33 = 2;
            	    int LA33_0 = input.LA(1);

            	    if ( (LA33_0 == VARIABLE || LA33_0 == VARTYPE || LA33_0 == STRINGTYPE || LA33_0 == 28 || LA33_0 == 32 || (LA33_0 >= 34 && LA33_0 <= 36) || LA33_0 == 40 || (LA33_0 >= 42 && LA33_0 <= 43) || LA33_0 == 46 || LA33_0 == 48 || (LA33_0 >= 52 && LA33_0 <= 56)) )
            	    {
            	        alt33 = 1;
            	    }


            	    switch (alt33) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:264:210: e11= expr1
            			    {
            			    	PushFollow(FOLLOW_expr1_in_forstatement1568);
            			    	e11 = expr1();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e11.Tree);
            			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    }
            			    break;

            			default:
            			    if ( cnt33 >= 1 ) goto loop33;
            		            EarlyExitException eee33 =
            		                new EarlyExitException(33, input);
            		            throw eee33;
            	    }
            	    cnt33++;
            	} while (true);

            	loop33:
            		;	// Stops C# compiler whining that label 'loop33' has no statements

            	RIGHTPARANTHESIS116=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_forstatement1573); 
            		RIGHTPARANTHESIS116_tree = (object)adaptor.Create(RIGHTPARANTHESIS116);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS116_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:266:4: functioncall returns [FunctionCallElement ret] : variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT ;
    public spinachParser.functioncall_return functioncall() // throws RecognitionException [1]
    {   
        spinachParser.functioncall_return retval = new spinachParser.functioncall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal118 = null;
        IToken char_literal119 = null;
        IToken char_literal120 = null;
        IToken END_OF_STATEMENT121 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;

        spinachParser.string_literal_return e13 = null;

        spinachParser.var_int_or_double_literal_return el2 = null;

        spinachParser.variable_return variable117 = null;


        object char_literal118_tree=null;
        object char_literal119_tree=null;
        object char_literal120_tree=null;
        object END_OF_STATEMENT121_tree=null;

         retval.ret = new FunctionCallElement();
         
        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:269:3: ( variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:269:4: variable '(' ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )? ')' END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_functioncall1594);
            	variable117 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable117.Tree);
            	retval.ret.setfunctioncallname(((variable117 != null) ? variable117.ret : null));
            	char_literal118=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functioncall1599); 
            		char_literal118_tree = (object)adaptor.Create(char_literal118);
            		adaptor.AddChild(root_0, char_literal118_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:6: ( (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )* )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( ((LA37_0 >= VARIABLE && LA37_0 <= DOUBLE_LITERAL) || LA37_0 == 27) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:7: (el1= var_int_or_double_literal | e13= string_literal ) ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )*
            	        {
            	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:7: (el1= var_int_or_double_literal | e13= string_literal )
            	        	int alt34 = 2;
            	        	int LA34_0 = input.LA(1);

            	        	if ( ((LA34_0 >= VARIABLE && LA34_0 <= DOUBLE_LITERAL)) )
            	        	{
            	        	    alt34 = 1;
            	        	}
            	        	else if ( (LA34_0 == 27) )
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
            	        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:8: el1= var_int_or_double_literal
            	        	        {
            	        	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1604);
            	        	        	el1 = var_int_or_double_literal();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, el1.Tree);
            	        	        	retval.ret.setparameters(((el1 != null) ? el1.ret : null));

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:75: e13= string_literal
            	        	        {
            	        	        	PushFollow(FOLLOW_string_literal_in_functioncall1610);
            	        	        	e13 = string_literal();
            	        	        	state.followingStackPointer--;

            	        	        	adaptor.AddChild(root_0, e13.Tree);
            	        	        	retval.ret.setparameters(((e13 != null) ? e13.ret : null));

            	        	        }
            	        	        break;

            	        	}

            	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:133: ( ',' (el2= var_int_or_double_literal | e13= string_literal ) )*
            	        	do 
            	        	{
            	        	    int alt36 = 2;
            	        	    int LA36_0 = input.LA(1);

            	        	    if ( (LA36_0 == 31) )
            	        	    {
            	        	        alt36 = 1;
            	        	    }


            	        	    switch (alt36) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:134: ',' (el2= var_int_or_double_literal | e13= string_literal )
            	        			    {
            	        			    	char_literal119=(IToken)Match(input,31,FOLLOW_31_in_functioncall1615); 
            	        			    		char_literal119_tree = (object)adaptor.Create(char_literal119);
            	        			    		adaptor.AddChild(root_0, char_literal119_tree);

            	        			    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:138: (el2= var_int_or_double_literal | e13= string_literal )
            	        			    	int alt35 = 2;
            	        			    	int LA35_0 = input.LA(1);

            	        			    	if ( ((LA35_0 >= VARIABLE && LA35_0 <= DOUBLE_LITERAL)) )
            	        			    	{
            	        			    	    alt35 = 1;
            	        			    	}
            	        			    	else if ( (LA35_0 == 27) )
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
            	        			    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:139: el2= var_int_or_double_literal
            	        			    	        {
            	        			    	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1620);
            	        			    	        	el2 = var_int_or_double_literal();
            	        			    	        	state.followingStackPointer--;

            	        			    	        	adaptor.AddChild(root_0, el2.Tree);
            	        			    	        	retval.ret.setparameters(((el2 != null) ? el2.ret : null));

            	        			    	        }
            	        			    	        break;
            	        			    	    case 2 :
            	        			    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:270:206: e13= string_literal
            	        			    	        {
            	        			    	        	PushFollow(FOLLOW_string_literal_in_functioncall1626);
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
            	        			    goto loop36;
            	        	    }
            	        	} while (true);

            	        	loop36:
            	        		;	// Stops C# compiler whining that label 'loop36' has no statements


            	        }
            	        break;

            	}

            	char_literal120=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functioncall1634); 
            		char_literal120_tree = (object)adaptor.Create(char_literal120);
            		adaptor.AddChild(root_0, char_literal120_tree);

            	END_OF_STATEMENT121=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functioncall1638); 
            		END_OF_STATEMENT121_tree = (object)adaptor.Create(END_OF_STATEMENT121);
            		adaptor.AddChild(root_0, END_OF_STATEMENT121_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:278:1: functiondefination returns [FunctionElement ret] : ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' );
    public spinachParser.functiondefination_return functiondefination() // throws RecognitionException [1]
    {   
        spinachParser.functiondefination_return retval = new spinachParser.functiondefination_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE122 = null;
        IToken char_literal124 = null;
        IToken char_literal125 = null;
        IToken char_literal126 = null;
        IToken char_literal127 = null;
        IToken char_literal139 = null;
        IToken string_literal140 = null;
        IToken char_literal142 = null;
        IToken char_literal143 = null;
        IToken char_literal144 = null;
        IToken char_literal145 = null;
        IToken char_literal157 = null;
        spinachParser.arguments_return e11 = null;

        spinachParser.arguments_return e12 = null;

        spinachParser.variable_return variable123 = null;

        spinachParser.assignment_return assignment128 = null;

        spinachParser.functioncall_return functioncall129 = null;

        spinachParser.scalarvardec_return scalarvardec130 = null;

        spinachParser.vectorvardec_return vectorvardec131 = null;

        spinachParser.matrixvardec_return matrixvardec132 = null;

        spinachParser.deletionofvar_return deletionofvar133 = null;

        spinachParser.print_return print134 = null;

        spinachParser.ifelse_return ifelse135 = null;

        spinachParser.functionreturn_return functionreturn136 = null;

        spinachParser.parallelfor_return parallelfor137 = null;

        spinachParser.forstatement_return forstatement138 = null;

        spinachParser.variable_return variable141 = null;

        spinachParser.assignment_return assignment146 = null;

        spinachParser.functioncall_return functioncall147 = null;

        spinachParser.scalarvardec_return scalarvardec148 = null;

        spinachParser.vectorvardec_return vectorvardec149 = null;

        spinachParser.matrixvardec_return matrixvardec150 = null;

        spinachParser.deletionofvar_return deletionofvar151 = null;

        spinachParser.print_return print152 = null;

        spinachParser.ifelse_return ifelse153 = null;

        spinachParser.functionreturn_return functionreturn154 = null;

        spinachParser.parallelfor_return parallelfor155 = null;

        spinachParser.forstatement_return forstatement156 = null;


        object VARTYPE122_tree=null;
        object char_literal124_tree=null;
        object char_literal125_tree=null;
        object char_literal126_tree=null;
        object char_literal127_tree=null;
        object char_literal139_tree=null;
        object string_literal140_tree=null;
        object char_literal142_tree=null;
        object char_literal143_tree=null;
        object char_literal144_tree=null;
        object char_literal145_tree=null;
        object char_literal157_tree=null;


        retval.ret = new FunctionElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:283:1: ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
            int alt46 = 2;
            int LA46_0 = input.LA(1);

            if ( (LA46_0 == VARTYPE) )
            {
                alt46 = 1;
            }
            else if ( (LA46_0 == 43) )
            {
                alt46 = 2;
            }
            else 
            {
                NoViableAltException nvae_d46s0 =
                    new NoViableAltException("", 46, 0, input);

                throw nvae_d46s0;
            }
            switch (alt46) 
            {
                case 1 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:283:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:283:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}' )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:283:4: VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}'
                    	{
                    		VARTYPE122=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_functiondefination1665); 
                    			VARTYPE122_tree = (object)adaptor.Create(VARTYPE122);
                    			adaptor.AddChild(root_0, VARTYPE122_tree);

                    		retval.ret.setreturntype(((VARTYPE122 != null) ? VARTYPE122.Text : null));
                    		PushFollow(FOLLOW_variable_in_functiondefination1670);
                    		variable123 = variable();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, variable123.Tree);
                    		retval.ret.setfunctionname(((variable123 != null) ? variable123.ret : null));
                    		char_literal124=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1676); 
                    			char_literal124_tree = (object)adaptor.Create(char_literal124);
                    			adaptor.AddChild(root_0, char_literal124_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:3: (e11= arguments ( ',' e12= arguments )* )?
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:3: (e11= arguments ( ',' e12= arguments )* )?
                    			int alt39 = 2;
                    			int LA39_0 = input.LA(1);

                    			if ( (LA39_0 == VARTYPE || LA39_0 == 28 || LA39_0 == 32) )
                    			{
                    			    alt39 = 1;
                    			}
                    			switch (alt39) 
                    			{
                    			    case 1 :
                    			        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:4: e11= arguments ( ',' e12= arguments )*
                    			        {
                    			        	PushFollow(FOLLOW_arguments_in_functiondefination1684);
                    			        	e11 = arguments();
                    			        	state.followingStackPointer--;

                    			        	adaptor.AddChild(root_0, e11.Tree);
                    			        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    			        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:54: ( ',' e12= arguments )*
                    			        	do 
                    			        	{
                    			        	    int alt38 = 2;
                    			        	    int LA38_0 = input.LA(1);

                    			        	    if ( (LA38_0 == 31) )
                    			        	    {
                    			        	        alt38 = 1;
                    			        	    }


                    			        	    switch (alt38) 
                    			        		{
                    			        			case 1 :
                    			        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:286:55: ',' e12= arguments
                    			        			    {
                    			        			    	char_literal125=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1687); 
                    			        			    		char_literal125_tree = (object)adaptor.Create(char_literal125);
                    			        			    		adaptor.AddChild(root_0, char_literal125_tree);

                    			        			    	PushFollow(FOLLOW_arguments_in_functiondefination1692);
                    			        			    	e12 = arguments();
                    			        			    	state.followingStackPointer--;

                    			        			    	adaptor.AddChild(root_0, e12.Tree);
                    			        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    			        			    }
                    			        			    break;

                    			        			default:
                    			        			    goto loop38;
                    			        	    }
                    			        	} while (true);

                    			        	loop38:
                    			        		;	// Stops C# compiler whining that label 'loop38' has no statements


                    			        }
                    			        break;

                    			}


                    		}

                    		char_literal126=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1701); 
                    			char_literal126_tree = (object)adaptor.Create(char_literal126);
                    			adaptor.AddChild(root_0, char_literal126_tree);

                    		char_literal127=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1703); 
                    			char_literal127_tree = (object)adaptor.Create(char_literal127);
                    			adaptor.AddChild(root_0, char_literal127_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:288:5: ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )?
                    		int alt41 = 2;
                    		int LA41_0 = input.LA(1);

                    		if ( (LA41_0 == VARIABLE || LA41_0 == VARTYPE || LA41_0 == STRINGTYPE || LA41_0 == 28 || LA41_0 == 32 || (LA41_0 >= 35 && LA41_0 <= 37) || LA41_0 == 40 || LA41_0 == 42 || LA41_0 == 47) )
                    		{
                    		    alt41 = 1;
                    		}
                    		switch (alt41) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:288:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:288:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    		        	int cnt40 = 0;
                    		        	do 
                    		        	{
                    		        	    int alt40 = 12;
                    		        	    alt40 = dfa40.Predict(input);
                    		        	    switch (alt40) 
                    		        		{
                    		        			case 1 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:288:7: assignment
                    		        			    {
                    		        			    	PushFollow(FOLLOW_assignment_in_functiondefination1707);
                    		        			    	assignment128 = assignment();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, assignment128.Tree);
                    		        			    	retval.ret.setBody(((assignment128 != null) ? assignment128.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 2 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:288:56: functioncall
                    		        			    {
                    		        			    	PushFollow(FOLLOW_functioncall_in_functiondefination1710);
                    		        			    	functioncall129 = functioncall();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, functioncall129.Tree);
                    		        			    	retval.ret.setBody(((functioncall129 != null) ? functioncall129.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 3 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:288:110: scalarvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1714);
                    		        			    	scalarvardec130 = scalarvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, scalarvardec130.Tree);
                    		        			    	 retval.ret.setBody(((scalarvardec130 != null) ? scalarvardec130.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 4 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:289:5: vectorvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1722);
                    		        			    	vectorvardec131 = vectorvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, vectorvardec131.Tree);
                    		        			    	 retval.ret.setBody(((vectorvardec131 != null) ? vectorvardec131.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 5 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:290:5: matrixvardec
                    		        			    {
                    		        			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1730);
                    		        			    	matrixvardec132 = matrixvardec();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, matrixvardec132.Tree);
                    		        			    	 retval.ret.setBody(((matrixvardec132 != null) ? matrixvardec132.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 6 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:291:5: deletionofvar
                    		        			    {
                    		        			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1738);
                    		        			    	deletionofvar133 = deletionofvar();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, deletionofvar133.Tree);
                    		        			    	 retval.ret.setBody(((deletionofvar133 != null) ? deletionofvar133.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 7 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:291:64: print
                    		        			    {
                    		        			    	PushFollow(FOLLOW_print_in_functiondefination1744);
                    		        			    	print134 = print();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, print134.Tree);
                    		        			    	 retval.ret.setBody(((print134 != null) ? print134.ret : null)); 

                    		        			    }
                    		        			    break;
                    		        			case 8 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:292:5: ifelse
                    		        			    {
                    		        			    	PushFollow(FOLLOW_ifelse_in_functiondefination1752);
                    		        			    	ifelse135 = ifelse();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, ifelse135.Tree);
                    		        			    	retval.ret.setBody(((ifelse135 != null) ? ifelse135.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 9 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:292:47: functionreturn
                    		        			    {
                    		        			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1756);
                    		        			    	functionreturn136 = functionreturn();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, functionreturn136.Tree);
                    		        			    	retval.ret.setBody(((functionreturn136 != null) ? functionreturn136.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 10 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:292:105: parallelfor
                    		        			    {
                    		        			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1760);
                    		        			    	parallelfor137 = parallelfor();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, parallelfor137.Tree);
                    		        			    	retval.ret.setBody(((parallelfor137 != null) ? parallelfor137.ret : null));

                    		        			    }
                    		        			    break;
                    		        			case 11 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:292:157: forstatement
                    		        			    {
                    		        			    	PushFollow(FOLLOW_forstatement_in_functiondefination1764);
                    		        			    	forstatement138 = forstatement();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, forstatement138.Tree);
                    		        			    	retval.ret.setBody(((forstatement138 != null) ? forstatement138.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    if ( cnt40 >= 1 ) goto loop40;
                    		        		            EarlyExitException eee40 =
                    		        		                new EarlyExitException(40, input);
                    		        		            throw eee40;
                    		        	    }
                    		        	    cnt40++;
                    		        	} while (true);

                    		        	loop40:
                    		        		;	// Stops C# compiler whining that label 'loop40' has no statements


                    		        }
                    		        break;

                    		}

                    		char_literal139=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1771); 
                    			char_literal139_tree = (object)adaptor.Create(char_literal139);
                    			adaptor.AddChild(root_0, char_literal139_tree);


                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:293:6: 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )? '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal140=(IToken)Match(input,43,FOLLOW_43_in_functiondefination1774); 
                    		string_literal140_tree = (object)adaptor.Create(string_literal140);
                    		adaptor.AddChild(root_0, string_literal140_tree);

                    	retval.ret.setreturntype("void");
                    	PushFollow(FOLLOW_variable_in_functiondefination1779);
                    	variable141 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable141.Tree);
                    	retval.ret.setfunctionname(((variable141 != null) ? variable141.ret : null));
                    	char_literal142=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1785); 
                    		char_literal142_tree = (object)adaptor.Create(char_literal142);
                    		adaptor.AddChild(root_0, char_literal142_tree);

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:296:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:296:3: (e11= arguments ( ',' e12= arguments )* )?
                    	{
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:296:3: (e11= arguments ( ',' e12= arguments )* )?
                    		int alt43 = 2;
                    		int LA43_0 = input.LA(1);

                    		if ( (LA43_0 == VARTYPE || LA43_0 == 28 || LA43_0 == 32) )
                    		{
                    		    alt43 = 1;
                    		}
                    		switch (alt43) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:296:4: e11= arguments ( ',' e12= arguments )*
                    		        {
                    		        	PushFollow(FOLLOW_arguments_in_functiondefination1794);
                    		        	e11 = arguments();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, e11.Tree);
                    		        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:296:55: ( ',' e12= arguments )*
                    		        	do 
                    		        	{
                    		        	    int alt42 = 2;
                    		        	    int LA42_0 = input.LA(1);

                    		        	    if ( (LA42_0 == 31) )
                    		        	    {
                    		        	        alt42 = 1;
                    		        	    }


                    		        	    switch (alt42) 
                    		        		{
                    		        			case 1 :
                    		        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:296:56: ',' e12= arguments
                    		        			    {
                    		        			    	char_literal143=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1797); 
                    		        			    		char_literal143_tree = (object)adaptor.Create(char_literal143);
                    		        			    		adaptor.AddChild(root_0, char_literal143_tree);

                    		        			    	PushFollow(FOLLOW_arguments_in_functiondefination1801);
                    		        			    	e12 = arguments();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, e12.Tree);
                    		        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    goto loop42;
                    		        	    }
                    		        	} while (true);

                    		        	loop42:
                    		        		;	// Stops C# compiler whining that label 'loop42' has no statements


                    		        }
                    		        break;

                    		}


                    	}

                    	char_literal144=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1810); 
                    		char_literal144_tree = (object)adaptor.Create(char_literal144);
                    		adaptor.AddChild(root_0, char_literal144_tree);

                    	char_literal145=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1812); 
                    		char_literal145_tree = (object)adaptor.Create(char_literal145);
                    		adaptor.AddChild(root_0, char_literal145_tree);

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:298:5: ( ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ )?
                    	int alt45 = 2;
                    	int LA45_0 = input.LA(1);

                    	if ( (LA45_0 == VARIABLE || LA45_0 == VARTYPE || LA45_0 == STRINGTYPE || LA45_0 == 28 || LA45_0 == 32 || (LA45_0 >= 35 && LA45_0 <= 37) || LA45_0 == 40 || LA45_0 == 42 || LA45_0 == 47) )
                    	{
                    	    alt45 = 1;
                    	}
                    	switch (alt45) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:298:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    	        {
                    	        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:298:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    	        	int cnt44 = 0;
                    	        	do 
                    	        	{
                    	        	    int alt44 = 12;
                    	        	    alt44 = dfa44.Predict(input);
                    	        	    switch (alt44) 
                    	        		{
                    	        			case 1 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:298:7: assignment
                    	        			    {
                    	        			    	PushFollow(FOLLOW_assignment_in_functiondefination1816);
                    	        			    	assignment146 = assignment();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, assignment146.Tree);
                    	        			    	retval.ret.setBody(((assignment146 != null) ? assignment146.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 2 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:298:56: functioncall
                    	        			    {
                    	        			    	PushFollow(FOLLOW_functioncall_in_functiondefination1819);
                    	        			    	functioncall147 = functioncall();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, functioncall147.Tree);
                    	        			    	retval.ret.setBody(((functioncall147 != null) ? functioncall147.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 3 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:298:110: scalarvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1823);
                    	        			    	scalarvardec148 = scalarvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, scalarvardec148.Tree);
                    	        			    	 retval.ret.setBody(((scalarvardec148 != null) ? scalarvardec148.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 4 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:299:5: vectorvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1831);
                    	        			    	vectorvardec149 = vectorvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, vectorvardec149.Tree);
                    	        			    	 retval.ret.setBody(((vectorvardec149 != null) ? vectorvardec149.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 5 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:300:5: matrixvardec
                    	        			    {
                    	        			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1839);
                    	        			    	matrixvardec150 = matrixvardec();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, matrixvardec150.Tree);
                    	        			    	 retval.ret.setBody(((matrixvardec150 != null) ? matrixvardec150.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 6 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:301:5: deletionofvar
                    	        			    {
                    	        			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1847);
                    	        			    	deletionofvar151 = deletionofvar();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, deletionofvar151.Tree);
                    	        			    	 retval.ret.setBody(((deletionofvar151 != null) ? deletionofvar151.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 7 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:301:64: print
                    	        			    {
                    	        			    	PushFollow(FOLLOW_print_in_functiondefination1853);
                    	        			    	print152 = print();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, print152.Tree);
                    	        			    	 retval.ret.setBody(((print152 != null) ? print152.ret : null)); 

                    	        			    }
                    	        			    break;
                    	        			case 8 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:302:5: ifelse
                    	        			    {
                    	        			    	PushFollow(FOLLOW_ifelse_in_functiondefination1861);
                    	        			    	ifelse153 = ifelse();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, ifelse153.Tree);
                    	        			    	retval.ret.setBody(((ifelse153 != null) ? ifelse153.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 9 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:302:47: functionreturn
                    	        			    {
                    	        			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1865);
                    	        			    	functionreturn154 = functionreturn();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, functionreturn154.Tree);
                    	        			    	retval.ret.setBody(((functionreturn154 != null) ? functionreturn154.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 10 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:302:105: parallelfor
                    	        			    {
                    	        			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1869);
                    	        			    	parallelfor155 = parallelfor();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, parallelfor155.Tree);
                    	        			    	retval.ret.setBody(((parallelfor155 != null) ? parallelfor155.ret : null));

                    	        			    }
                    	        			    break;
                    	        			case 11 :
                    	        			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:302:157: forstatement
                    	        			    {
                    	        			    	PushFollow(FOLLOW_forstatement_in_functiondefination1873);
                    	        			    	forstatement156 = forstatement();
                    	        			    	state.followingStackPointer--;

                    	        			    	adaptor.AddChild(root_0, forstatement156.Tree);
                    	        			    	retval.ret.setBody(((forstatement156 != null) ? forstatement156.ret : null));

                    	        			    }
                    	        			    break;

                    	        			default:
                    	        			    if ( cnt44 >= 1 ) goto loop44;
                    	        		            EarlyExitException eee44 =
                    	        		                new EarlyExitException(44, input);
                    	        		            throw eee44;
                    	        	    }
                    	        	    cnt44++;
                    	        	} while (true);

                    	        	loop44:
                    	        		;	// Stops C# compiler whining that label 'loop44' has no statements


                    	        }
                    	        break;

                    	}

                    	char_literal157=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1880); 
                    		char_literal157_tree = (object)adaptor.Create(char_literal157);
                    		adaptor.AddChild(root_0, char_literal157_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:307:1: dotproduct returns [DotProductElement ret] : e11= variable 'DOT' e12= variable ;
    public spinachParser.dotproduct_return dotproduct() // throws RecognitionException [1]
    {   
        spinachParser.dotproduct_return retval = new spinachParser.dotproduct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal158 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.variable_return e12 = null;


        object string_literal158_tree=null;


        retval.ret = new DotProductElement ();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:311:1: (e11= variable 'DOT' e12= variable )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:311:3: e11= variable 'DOT' e12= variable
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_dotproduct1902);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLhs(((e11 != null) ? e11.ret : null)); 
            	string_literal158=(IToken)Match(input,44,FOLLOW_44_in_dotproduct1906); 
            		string_literal158_tree = (object)adaptor.Create(string_literal158);
            		adaptor.AddChild(root_0, string_literal158_tree);

            	PushFollow(FOLLOW_variable_in_dotproduct1912);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:313:1: matrixtranspose returns [MatrixTranspose ret] : 'T' LEFTBRACE variable ')' ;
    public spinachParser.matrixtranspose_return matrixtranspose() // throws RecognitionException [1]
    {   
        spinachParser.matrixtranspose_return retval = new spinachParser.matrixtranspose_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal159 = null;
        IToken LEFTBRACE160 = null;
        IToken char_literal162 = null;
        spinachParser.variable_return variable161 = null;


        object char_literal159_tree=null;
        object LEFTBRACE160_tree=null;
        object char_literal162_tree=null;


        retval.ret = new MatrixTranspose();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:318:1: ( 'T' LEFTBRACE variable ')' )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:318:3: 'T' LEFTBRACE variable ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal159=(IToken)Match(input,45,FOLLOW_45_in_matrixtranspose1931); 
            		char_literal159_tree = (object)adaptor.Create(char_literal159);
            		adaptor.AddChild(root_0, char_literal159_tree);

            	LEFTBRACE160=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_matrixtranspose1933); 
            		LEFTBRACE160_tree = (object)adaptor.Create(LEFTBRACE160);
            		adaptor.AddChild(root_0, LEFTBRACE160_tree);

            	PushFollow(FOLLOW_variable_in_matrixtranspose1935);
            	variable161 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable161.Tree);
            	retval.ret.setvariable(((variable161 != null) ? variable161.ret : null)); 
            	char_literal162=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_matrixtranspose1938); 
            		char_literal162_tree = (object)adaptor.Create(char_literal162);
            		adaptor.AddChild(root_0, char_literal162_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:321:1: matrixreference returns [MatrixReference ret] : 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.matrixreference_return matrixreference() // throws RecognitionException [1]
    {   
        spinachParser.matrixreference_return retval = new spinachParser.matrixreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal163 = null;
        IToken char_literal164 = null;
        IToken char_literal165 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal163_tree=null;
        object char_literal164_tree=null;
        object char_literal165_tree=null;

         retval.ret = new MatrixReference();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:324:1: ( 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:324:2: 'Matrix' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal163=(IToken)Match(input,28,FOLLOW_28_in_matrixreference1954); 
            		string_literal163_tree = (object)adaptor.Create(string_literal163);
            		adaptor.AddChild(root_0, string_literal163_tree);

            	char_literal164=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixreference1956); 
            		char_literal164_tree = (object)adaptor.Create(char_literal164);
            		adaptor.AddChild(root_0, char_literal164_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:324:15: (el1= VARTYPE '>' el2= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:324:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixreference1961); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal165=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixreference1963); 
            			char_literal165_tree = (object)adaptor.Create(char_literal165);
            			adaptor.AddChild(root_0, char_literal165_tree);

            		PushFollow(FOLLOW_variable_in_matrixreference1967);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:327:1: vectorreference returns [VectorReference ret] : 'Vector' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.vectorreference_return vectorreference() // throws RecognitionException [1]
    {   
        spinachParser.vectorreference_return retval = new spinachParser.vectorreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal166 = null;
        IToken char_literal167 = null;
        IToken char_literal168 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal166_tree=null;
        object char_literal167_tree=null;
        object char_literal168_tree=null;

         retval.ret = new VectorReference();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:330:1: ( 'Vector' '<' (el1= VARTYPE '>' el2= variable ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:330:2: 'Vector' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal166=(IToken)Match(input,32,FOLLOW_32_in_vectorreference1986); 
            		string_literal166_tree = (object)adaptor.Create(string_literal166);
            		adaptor.AddChild(root_0, string_literal166_tree);

            	char_literal167=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorreference1988); 
            		char_literal167_tree = (object)adaptor.Create(char_literal167);
            		adaptor.AddChild(root_0, char_literal167_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:330:15: (el1= VARTYPE '>' el2= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:330:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorreference1993); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal168=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorreference1995); 
            			char_literal168_tree = (object)adaptor.Create(char_literal168);
            			adaptor.AddChild(root_0, char_literal168_tree);

            		PushFollow(FOLLOW_variable_in_vectorreference1999);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:332:1: arguments returns [Element ret] : ( scalarargument | matrixreference | vectorreference ) ;
    public spinachParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        spinachParser.arguments_return retval = new spinachParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.scalarargument_return scalarargument169 = null;

        spinachParser.matrixreference_return matrixreference170 = null;

        spinachParser.vectorreference_return vectorreference171 = null;



        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:333:1: ( ( scalarargument | matrixreference | vectorreference ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:333:3: ( scalarargument | matrixreference | vectorreference )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:333:3: ( scalarargument | matrixreference | vectorreference )
            	int alt47 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARTYPE:
            		{
            	    alt47 = 1;
            	    }
            	    break;
            	case 28:
            		{
            	    alt47 = 2;
            	    }
            	    break;
            	case 32:
            		{
            	    alt47 = 3;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d47s0 =
            		        new NoViableAltException("", 47, 0, input);

            		    throw nvae_d47s0;
            	}

            	switch (alt47) 
            	{
            	    case 1 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:333:4: scalarargument
            	        {
            	        	PushFollow(FOLLOW_scalarargument_in_arguments2015);
            	        	scalarargument169 = scalarargument();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, scalarargument169.Tree);
            	        	 retval.ret = ((scalarargument169 != null) ? scalarargument169.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:334:3: matrixreference
            	        {
            	        	PushFollow(FOLLOW_matrixreference_in_arguments2021);
            	        	matrixreference170 = matrixreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixreference170.Tree);
            	        	retval.ret = ((matrixreference170 != null) ? matrixreference170.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:335:3: vectorreference
            	        {
            	        	PushFollow(FOLLOW_vectorreference_in_arguments2027);
            	        	vectorreference171 = vectorreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorreference171.Tree);
            	        	retval.ret = ((vectorreference171 != null) ? vectorreference171.ret : null);

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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:346:1: scalarargument returns [ScalarArgument ret] : ( (e11= VARTYPE ) e12= variable ) ;
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
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:348:2: ( ( (e11= VARTYPE ) e12= variable ) )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:349:1: ( (e11= VARTYPE ) e12= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:349:1: ( (e11= VARTYPE ) e12= variable )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:349:2: (e11= VARTYPE ) e12= variable
            	{
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:349:2: (e11= VARTYPE )
            		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:349:3: e11= VARTYPE
            		{
            			e11=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarargument2059); 
            				e11_tree = (object)adaptor.Create(e11);
            				adaptor.AddChild(root_0, e11_tree);

            			retval.ret.settype(((e11 != null) ? e11.Text : null));

            		}

            		PushFollow(FOLLOW_variable_in_scalarargument2066);
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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:353:1: comment returns [CommentElement ret] : '//' ( var_int_or_double_literal )* ;
    public spinachParser.comment_return comment() // throws RecognitionException [1]
    {   
        spinachParser.comment_return retval = new spinachParser.comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal172 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal173 = null;


        object string_literal172_tree=null;


        retval.ret = new CommentElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:357:1: ( '//' ( var_int_or_double_literal )* )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:357:2: '//' ( var_int_or_double_literal )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal172=(IToken)Match(input,46,FOLLOW_46_in_comment2085); 
            		string_literal172_tree = (object)adaptor.Create(string_literal172);
            		adaptor.AddChild(root_0, string_literal172_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:357:6: ( var_int_or_double_literal )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( (LA48_0 == VARIABLE) )
            	    {
            	        switch ( input.LA(2) ) 
            	        {
            	        case DOT:
            	        	{
            	            int LA48_4 = input.LA(3);

            	            if ( (LA48_4 == VARIABLE) )
            	            {
            	                int LA48_6 = input.LA(4);

            	                if ( (LA48_6 == EOF || (LA48_6 >= VARIABLE && LA48_6 <= VARTYPE) || LA48_6 == STRINGTYPE || LA48_6 == RIGHTPARANTHESIS || LA48_6 == 28 || LA48_6 == 32 || (LA48_6 >= 34 && LA48_6 <= 37) || (LA48_6 >= 39 && LA48_6 <= 40) || (LA48_6 >= 42 && LA48_6 <= 43) || (LA48_6 >= 46 && LA48_6 <= 48) || (LA48_6 >= 52 && LA48_6 <= 56)) )
            	                {
            	                    alt48 = 1;
            	                }


            	            }


            	            }
            	            break;
            	        case VARIABLE:
            	        	{
            	            int LA48_5 = input.LA(3);

            	            if ( (LA48_5 == EOF || (LA48_5 >= VARIABLE && LA48_5 <= ASSIGNMENT) || (LA48_5 >= STRINGTYPE && LA48_5 <= LEFTBRACE) || LA48_5 == RIGHTPARANTHESIS || LA48_5 == DOT || (LA48_5 >= 28 && LA48_5 <= 29) || LA48_5 == 32 || (LA48_5 >= 34 && LA48_5 <= 37) || (LA48_5 >= 39 && LA48_5 <= 40) || (LA48_5 >= 42 && LA48_5 <= 43) || (LA48_5 >= 46 && LA48_5 <= 48) || (LA48_5 >= 52 && LA48_5 <= 56)) )
            	            {
            	                alt48 = 1;
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
            	            alt48 = 1;
            	            }
            	            break;

            	        }

            	    }
            	    else if ( ((LA48_0 >= INT_LITERAL && LA48_0 <= DOUBLE_LITERAL)) )
            	    {
            	        alt48 = 1;
            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:357:6: var_int_or_double_literal
            			    {
            			    	PushFollow(FOLLOW_var_int_or_double_literal_in_comment2086);
            			    	var_int_or_double_literal173 = var_int_or_double_literal();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, var_int_or_double_literal173.Tree);

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:361:1: functionreturn returns [ReturnElement ret] : 'return' ( var_int_or_double_literal ) END_OF_STATEMENT ;
    public spinachParser.functionreturn_return functionreturn() // throws RecognitionException [1]
    {   
        spinachParser.functionreturn_return retval = new spinachParser.functionreturn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal174 = null;
        IToken END_OF_STATEMENT176 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal175 = null;


        object string_literal174_tree=null;
        object END_OF_STATEMENT176_tree=null;


        retval.ret = new ReturnElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:365:1: ( 'return' ( var_int_or_double_literal ) END_OF_STATEMENT )
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:365:2: 'return' ( var_int_or_double_literal ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal174=(IToken)Match(input,47,FOLLOW_47_in_functionreturn2104); 
            		string_literal174_tree = (object)adaptor.Create(string_literal174);
            		adaptor.AddChild(root_0, string_literal174_tree);

            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:365:11: ( var_int_or_double_literal )
            	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:365:12: var_int_or_double_literal
            	{
            		PushFollow(FOLLOW_var_int_or_double_literal_in_functionreturn2107);
            		var_int_or_double_literal175 = var_int_or_double_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, var_int_or_double_literal175.Tree);
            		retval.ret.setreturnvariable(((var_int_or_double_literal175 != null) ? var_int_or_double_literal175.ret : null));

            	}

            	END_OF_STATEMENT176=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functionreturn2111); 
            		END_OF_STATEMENT176_tree = (object)adaptor.Create(END_OF_STATEMENT176);
            		adaptor.AddChild(root_0, END_OF_STATEMENT176_tree);


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
    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:371:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );
    public spinachParser.plotfunctions_return plotfunctions() // throws RecognitionException [1]
    {   
        spinachParser.plotfunctions_return retval = new spinachParser.plotfunctions_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal177 = null;
        IToken char_literal178 = null;
        IToken char_literal179 = null;
        IToken char_literal180 = null;
        IToken char_literal181 = null;
        IToken char_literal182 = null;
        IToken string_literal183 = null;
        IToken string_literal184 = null;
        IToken string_literal185 = null;
        IToken char_literal186 = null;
        IToken char_literal187 = null;
        IToken END_OF_STATEMENT188 = null;
        IToken string_literal189 = null;
        IToken char_literal190 = null;
        IToken char_literal191 = null;
        IToken char_literal192 = null;
        IToken string_literal193 = null;
        IToken string_literal194 = null;
        IToken string_literal195 = null;
        IToken char_literal196 = null;
        IToken char_literal197 = null;
        IToken END_OF_STATEMENT198 = null;
        IToken string_literal199 = null;
        IToken char_literal200 = null;
        IToken char_literal201 = null;
        IToken END_OF_STATEMENT202 = null;
        IToken string_literal203 = null;
        IToken char_literal204 = null;
        IToken char_literal205 = null;
        IToken char_literal206 = null;
        IToken char_literal207 = null;
        IToken END_OF_STATEMENT208 = null;
        IToken string_literal209 = null;
        IToken char_literal210 = null;
        IToken char_literal211 = null;
        IToken char_literal212 = null;
        IToken END_OF_STATEMENT213 = null;
        IToken string_literal214 = null;
        IToken char_literal215 = null;
        IToken char_literal216 = null;
        IToken END_OF_STATEMENT217 = null;
        IToken string_literal218 = null;
        IToken char_literal219 = null;
        IToken char_literal220 = null;
        IToken char_literal221 = null;
        IToken char_literal222 = null;
        IToken END_OF_STATEMENT223 = null;
        IToken string_literal224 = null;
        IToken char_literal225 = null;
        IToken char_literal226 = null;
        IToken char_literal227 = null;
        IToken END_OF_STATEMENT228 = null;
        IToken string_literal229 = null;
        IToken char_literal230 = null;
        IToken char_literal231 = null;
        IToken END_OF_STATEMENT232 = null;
        IToken string_literal233 = null;
        IToken char_literal234 = null;
        IToken SCALEMODE235 = null;
        IToken char_literal236 = null;
        IToken END_OF_STATEMENT237 = null;
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


        object string_literal177_tree=null;
        object char_literal178_tree=null;
        object char_literal179_tree=null;
        object char_literal180_tree=null;
        object char_literal181_tree=null;
        object char_literal182_tree=null;
        object string_literal183_tree=null;
        object string_literal184_tree=null;
        object string_literal185_tree=null;
        object char_literal186_tree=null;
        object char_literal187_tree=null;
        object END_OF_STATEMENT188_tree=null;
        object string_literal189_tree=null;
        object char_literal190_tree=null;
        object char_literal191_tree=null;
        object char_literal192_tree=null;
        object string_literal193_tree=null;
        object string_literal194_tree=null;
        object string_literal195_tree=null;
        object char_literal196_tree=null;
        object char_literal197_tree=null;
        object END_OF_STATEMENT198_tree=null;
        object string_literal199_tree=null;
        object char_literal200_tree=null;
        object char_literal201_tree=null;
        object END_OF_STATEMENT202_tree=null;
        object string_literal203_tree=null;
        object char_literal204_tree=null;
        object char_literal205_tree=null;
        object char_literal206_tree=null;
        object char_literal207_tree=null;
        object END_OF_STATEMENT208_tree=null;
        object string_literal209_tree=null;
        object char_literal210_tree=null;
        object char_literal211_tree=null;
        object char_literal212_tree=null;
        object END_OF_STATEMENT213_tree=null;
        object string_literal214_tree=null;
        object char_literal215_tree=null;
        object char_literal216_tree=null;
        object END_OF_STATEMENT217_tree=null;
        object string_literal218_tree=null;
        object char_literal219_tree=null;
        object char_literal220_tree=null;
        object char_literal221_tree=null;
        object char_literal222_tree=null;
        object END_OF_STATEMENT223_tree=null;
        object string_literal224_tree=null;
        object char_literal225_tree=null;
        object char_literal226_tree=null;
        object char_literal227_tree=null;
        object END_OF_STATEMENT228_tree=null;
        object string_literal229_tree=null;
        object char_literal230_tree=null;
        object char_literal231_tree=null;
        object END_OF_STATEMENT232_tree=null;
        object string_literal233_tree=null;
        object char_literal234_tree=null;
        object SCALEMODE235_tree=null;
        object char_literal236_tree=null;
        object END_OF_STATEMENT237_tree=null;

         retval.ret = new PlotFunctionElement();

        try 
    	{
            // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:374:1: ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) )
            int alt53 = 10;
            alt53 = dfa53.Predict(input);
            switch (alt53) 
            {
                case 1 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:374:3: ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:374:3: ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:374:4: 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal177=(IToken)Match(input,48,FOLLOW_48_in_plotfunctions2135); 
                    			string_literal177_tree = (object)adaptor.Create(string_literal177);
                    			adaptor.AddChild(root_0, string_literal177_tree);

                    		retval.ret.setPlotFunction("subPlot");
                    		char_literal178=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2138); 
                    			char_literal178_tree = (object)adaptor.Create(char_literal178);
                    			adaptor.AddChild(root_0, char_literal178_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:375:1: (el1= int_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:375:2: el1= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2145);
                    			el1 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el1.Tree);
                    			retval.ret.setRow(((el1 != null) ? el1.ret : null));

                    		}

                    		char_literal179=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2150); 
                    			char_literal179_tree = (object)adaptor.Create(char_literal179);
                    			adaptor.AddChild(root_0, char_literal179_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:376:1: (el2= int_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:376:2: el2= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2157);
                    			el2 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el2.Tree);
                    			retval.ret.setColumn(((el2 != null) ? el2.ret : null));

                    		}

                    		char_literal180=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2162); 
                    			char_literal180_tree = (object)adaptor.Create(char_literal180);
                    			adaptor.AddChild(root_0, char_literal180_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:377:1: (vll1= variable )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:377:2: vll1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2169);
                    			vll1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll1.Tree);
                    			retval.ret.setData(((vll1 != null) ? vll1.ret : null));

                    		}

                    		char_literal181=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2174); 
                    			char_literal181_tree = (object)adaptor.Create(char_literal181);
                    			adaptor.AddChild(root_0, char_literal181_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:378:1: (vll2= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:378:2: vll2= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2181);
                    			vll2 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll2.Tree);
                    			retval.ret.setTitle(((vll2 != null) ? vll2.ret : null));

                    		}

                    		char_literal182=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2185); 
                    			char_literal182_tree = (object)adaptor.Create(char_literal182);
                    			adaptor.AddChild(root_0, char_literal182_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt50 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt50 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt50 = 2;
                    		    }
                    		    break;
                    		case 51:
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
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:2: ( '1D' )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:2: ( '1D' )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:3: '1D'
                    		        	{
                    		        		string_literal183=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2189); 
                    		        			string_literal183_tree = (object)adaptor.Create(string_literal183);
                    		        			adaptor.AddChild(root_0, string_literal183_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:40: ( '2D' )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:40: ( '2D' )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:41: '2D'
                    		        	{
                    		        		string_literal184=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2194); 
                    		        			string_literal184_tree = (object)adaptor.Create(string_literal184);
                    		        			adaptor.AddChild(root_0, string_literal184_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal185=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2199); 
                    		        			string_literal185_tree = (object)adaptor.Create(string_literal185);
                    		        			adaptor.AddChild(root_0, string_literal185_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:114: ( ',' (el3= int_literal ) )?
                    		        		int alt49 = 2;
                    		        		int LA49_0 = input.LA(1);

                    		        		if ( (LA49_0 == 31) )
                    		        		{
                    		        		    alt49 = 1;
                    		        		}
                    		        		switch (alt49) 
                    		        		{
                    		        		    case 1 :
                    		        		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal186=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2202); 
                    		        		        		char_literal186_tree = (object)adaptor.Create(char_literal186);
                    		        		        		adaptor.AddChild(root_0, char_literal186_tree);

                    		        		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:118: (el3= int_literal )
                    		        		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:379:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2208);
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

                    		char_literal187=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2216); 
                    			char_literal187_tree = (object)adaptor.Create(char_literal187);
                    			adaptor.AddChild(root_0, char_literal187_tree);

                    		END_OF_STATEMENT188=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2217); 
                    			END_OF_STATEMENT188_tree = (object)adaptor.Create(END_OF_STATEMENT188);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT188_tree);


                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:381:4: 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal189=(IToken)Match(input,52,FOLLOW_52_in_plotfunctions2223); 
                    			string_literal189_tree = (object)adaptor.Create(string_literal189);
                    			adaptor.AddChild(root_0, string_literal189_tree);

                    		retval.ret.setPlotFunction("plot");
                    		char_literal190=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2226); 
                    			char_literal190_tree = (object)adaptor.Create(char_literal190);
                    			adaptor.AddChild(root_0, char_literal190_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:382:1: (vll3= variable )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:382:2: vll3= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2232);
                    			vll3 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll3.Tree);
                    			retval.ret.setData(((vll3 != null) ? vll3.ret : null));

                    		}

                    		char_literal191=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2237); 
                    			char_literal191_tree = (object)adaptor.Create(char_literal191);
                    			adaptor.AddChild(root_0, char_literal191_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:383:1: (vll4= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:383:2: vll4= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2243);
                    			vll4 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll4.Tree);
                    			retval.ret.setTitle(((vll4 != null) ? vll4.ret : null));

                    		}

                    		char_literal192=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2247); 
                    			char_literal192_tree = (object)adaptor.Create(char_literal192);
                    			adaptor.AddChild(root_0, char_literal192_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt52 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt52 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt52 = 2;
                    		    }
                    		    break;
                    		case 51:
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
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:2: ( '1D' )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:2: ( '1D' )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:3: '1D'
                    		        	{
                    		        		string_literal193=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2251); 
                    		        			string_literal193_tree = (object)adaptor.Create(string_literal193);
                    		        			adaptor.AddChild(root_0, string_literal193_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:40: ( '2D' )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:40: ( '2D' )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:41: '2D'
                    		        	{
                    		        		string_literal194=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2256); 
                    		        			string_literal194_tree = (object)adaptor.Create(string_literal194);
                    		        			adaptor.AddChild(root_0, string_literal194_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal195=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2261); 
                    		        			string_literal195_tree = (object)adaptor.Create(string_literal195);
                    		        			adaptor.AddChild(root_0, string_literal195_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:114: ( ',' (el3= int_literal ) )?
                    		        		int alt51 = 2;
                    		        		int LA51_0 = input.LA(1);

                    		        		if ( (LA51_0 == 31) )
                    		        		{
                    		        		    alt51 = 1;
                    		        		}
                    		        		switch (alt51) 
                    		        		{
                    		        		    case 1 :
                    		        		        // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal196=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2264); 
                    		        		        		char_literal196_tree = (object)adaptor.Create(char_literal196);
                    		        		        		adaptor.AddChild(root_0, char_literal196_tree);

                    		        		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:118: (el3= int_literal )
                    		        		        	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:384:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2270);
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

                    		char_literal197=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2278); 
                    			char_literal197_tree = (object)adaptor.Create(char_literal197);
                    			adaptor.AddChild(root_0, char_literal197_tree);

                    		END_OF_STATEMENT198=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2279); 
                    			END_OF_STATEMENT198_tree = (object)adaptor.Create(END_OF_STATEMENT198);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT198_tree);


                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:386:4: 'resetPlot' '(' ')' END_OF_STATEMENT
                    	{
                    		string_literal199=(IToken)Match(input,53,FOLLOW_53_in_plotfunctions2285); 
                    			string_literal199_tree = (object)adaptor.Create(string_literal199);
                    			adaptor.AddChild(root_0, string_literal199_tree);

                    		char_literal200=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2286); 
                    			char_literal200_tree = (object)adaptor.Create(char_literal200);
                    			adaptor.AddChild(root_0, char_literal200_tree);

                    		char_literal201=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2287); 
                    			char_literal201_tree = (object)adaptor.Create(char_literal201);
                    			adaptor.AddChild(root_0, char_literal201_tree);

                    		retval.ret.setPlotFunction("resetPlot");
                    		END_OF_STATEMENT202=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2289); 
                    			END_OF_STATEMENT202_tree = (object)adaptor.Create(END_OF_STATEMENT202);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT202_tree);


                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:387:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:387:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:387:4: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal203=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2295); 
                    			string_literal203_tree = (object)adaptor.Create(string_literal203);
                    			adaptor.AddChild(root_0, string_literal203_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal204=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2297); 
                    			char_literal204_tree = (object)adaptor.Create(char_literal204);
                    			adaptor.AddChild(root_0, char_literal204_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:388:1: (ell2= double_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:388:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2303);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal205=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2306); 
                    			char_literal205_tree = (object)adaptor.Create(char_literal205);
                    			adaptor.AddChild(root_0, char_literal205_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:389:1: ( (ell3= double_literal ) ',' )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:389:2: (ell3= double_literal ) ','
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:389:2: (ell3= double_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:389:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2312);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}

                    			char_literal206=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2315); 
                    				char_literal206_tree = (object)adaptor.Create(char_literal206);
                    				adaptor.AddChild(root_0, char_literal206_tree);


                    		}

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:390:1: ( (el4= double_literal ) )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:390:2: (el4= double_literal )
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:390:2: (el4= double_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:390:3: el4= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2322);
                    				el4 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, el4.Tree);
                    				retval.ret.setZFact(((el4 != null) ? el4.ret : null));

                    			}


                    		}

                    		char_literal207=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2327); 
                    			char_literal207_tree = (object)adaptor.Create(char_literal207);
                    			adaptor.AddChild(root_0, char_literal207_tree);

                    		END_OF_STATEMENT208=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2328); 
                    			END_OF_STATEMENT208_tree = (object)adaptor.Create(END_OF_STATEMENT208);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT208_tree);


                    	}


                    }
                    break;
                case 5 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:392:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:392:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:392:3: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal209=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2333); 
                    			string_literal209_tree = (object)adaptor.Create(string_literal209);
                    			adaptor.AddChild(root_0, string_literal209_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal210=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2335); 
                    			char_literal210_tree = (object)adaptor.Create(char_literal210);
                    			adaptor.AddChild(root_0, char_literal210_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:393:1: (ell2= double_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:393:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2341);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal211=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2344); 
                    			char_literal211_tree = (object)adaptor.Create(char_literal211);
                    			adaptor.AddChild(root_0, char_literal211_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:394:1: ( (ell3= double_literal ) )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:394:2: (ell3= double_literal )
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:394:2: (ell3= double_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:394:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2350);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}


                    		}

                    		char_literal212=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2355); 
                    			char_literal212_tree = (object)adaptor.Create(char_literal212);
                    			adaptor.AddChild(root_0, char_literal212_tree);

                    		END_OF_STATEMENT213=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2356); 
                    			END_OF_STATEMENT213_tree = (object)adaptor.Create(END_OF_STATEMENT213);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT213_tree);


                    	}


                    }
                    break;
                case 6 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:396:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:396:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:396:3: 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal214=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2361); 
                    			string_literal214_tree = (object)adaptor.Create(string_literal214);
                    			adaptor.AddChild(root_0, string_literal214_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal215=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2363); 
                    			char_literal215_tree = (object)adaptor.Create(char_literal215);
                    			adaptor.AddChild(root_0, char_literal215_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:397:1: (ell2= double_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:397:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2369);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal216=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2373); 
                    			char_literal216_tree = (object)adaptor.Create(char_literal216);
                    			adaptor.AddChild(root_0, char_literal216_tree);

                    		END_OF_STATEMENT217=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2374); 
                    			END_OF_STATEMENT217_tree = (object)adaptor.Create(END_OF_STATEMENT217);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT217_tree);


                    	}


                    }
                    break;
                case 7 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:399:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:399:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:399:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal218=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2380); 
                    			string_literal218_tree = (object)adaptor.Create(string_literal218);
                    			adaptor.AddChild(root_0, string_literal218_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal219=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2382); 
                    			char_literal219_tree = (object)adaptor.Create(char_literal219);
                    			adaptor.AddChild(root_0, char_literal219_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:400:1: (vl1= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:400:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2388);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal220=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2391); 
                    			char_literal220_tree = (object)adaptor.Create(char_literal220);
                    			adaptor.AddChild(root_0, char_literal220_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:401:1: ( (vl2= string_literal ) ',' )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:401:2: (vl2= string_literal ) ','
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:401:2: (vl2= string_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:401:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2398);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}

                    			char_literal221=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2401); 
                    				char_literal221_tree = (object)adaptor.Create(char_literal221);
                    				adaptor.AddChild(root_0, char_literal221_tree);


                    		}

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:402:1: ( (vl3= string_literal ) )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:402:2: (vl3= string_literal )
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:402:2: (vl3= string_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:402:3: vl3= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2409);
                    				vl3 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl3.Tree);
                    				retval.ret.setZTitle(((vl3 != null) ? vl3.ret : null));

                    			}


                    		}

                    		char_literal222=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2414); 
                    			char_literal222_tree = (object)adaptor.Create(char_literal222);
                    			adaptor.AddChild(root_0, char_literal222_tree);

                    		END_OF_STATEMENT223=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2415); 
                    			END_OF_STATEMENT223_tree = (object)adaptor.Create(END_OF_STATEMENT223);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT223_tree);


                    	}


                    }
                    break;
                case 8 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:404:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:404:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:404:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal224=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2421); 
                    			string_literal224_tree = (object)adaptor.Create(string_literal224);
                    			adaptor.AddChild(root_0, string_literal224_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal225=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2423); 
                    			char_literal225_tree = (object)adaptor.Create(char_literal225);
                    			adaptor.AddChild(root_0, char_literal225_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:405:1: (vl1= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:405:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2429);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal226=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2432); 
                    			char_literal226_tree = (object)adaptor.Create(char_literal226);
                    			adaptor.AddChild(root_0, char_literal226_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:406:1: ( (vl2= string_literal ) )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:406:2: (vl2= string_literal )
                    		{
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:406:2: (vl2= string_literal )
                    			// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:406:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2439);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}


                    		}

                    		char_literal227=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2444); 
                    			char_literal227_tree = (object)adaptor.Create(char_literal227);
                    			adaptor.AddChild(root_0, char_literal227_tree);

                    		END_OF_STATEMENT228=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2445); 
                    			END_OF_STATEMENT228_tree = (object)adaptor.Create(END_OF_STATEMENT228);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT228_tree);


                    	}


                    }
                    break;
                case 9 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:408:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:408:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:408:3: 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal229=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2450); 
                    			string_literal229_tree = (object)adaptor.Create(string_literal229);
                    			adaptor.AddChild(root_0, string_literal229_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal230=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2452); 
                    			char_literal230_tree = (object)adaptor.Create(char_literal230);
                    			adaptor.AddChild(root_0, char_literal230_tree);

                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:409:1: (vl1= string_literal )
                    		// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:409:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2458);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal231=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2462); 
                    			char_literal231_tree = (object)adaptor.Create(char_literal231);
                    			adaptor.AddChild(root_0, char_literal231_tree);

                    		END_OF_STATEMENT232=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2463); 
                    			END_OF_STATEMENT232_tree = (object)adaptor.Create(END_OF_STATEMENT232);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT232_tree);


                    	}


                    }
                    break;
                case 10 :
                    // C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:411:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:411:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    	// C:\\Users\\KULDEEP GANDHI\\Desktop\\pinac\\Spinach\\InterpreterFrontEnd\\spinach.g:411:3: 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT
                    	{
                    		string_literal233=(IToken)Match(input,56,FOLLOW_56_in_plotfunctions2468); 
                    			string_literal233_tree = (object)adaptor.Create(string_literal233);
                    			adaptor.AddChild(root_0, string_literal233_tree);

                    		char_literal234=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2469); 
                    			char_literal234_tree = (object)adaptor.Create(char_literal234);
                    			adaptor.AddChild(root_0, char_literal234_tree);

                    		retval.ret.setPlotFunction("setScaleMode");
                    		SCALEMODE235=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_plotfunctions2472); 
                    			SCALEMODE235_tree = (object)adaptor.Create(SCALEMODE235);
                    			adaptor.AddChild(root_0, SCALEMODE235_tree);

                    		retval.ret.setScaleMode(SCALEMODE235.Text);
                    		char_literal236=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2476); 
                    			char_literal236_tree = (object)adaptor.Create(char_literal236);
                    			adaptor.AddChild(root_0, char_literal236_tree);

                    		END_OF_STATEMENT237=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2478); 
                    			END_OF_STATEMENT237_tree = (object)adaptor.Create(END_OF_STATEMENT237);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT237_tree);


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
   	protected DFA4 dfa4;
   	protected DFA24 dfa24;
   	protected DFA40 dfa40;
   	protected DFA44 dfa44;
   	protected DFA53 dfa53;
	private void InitializeCyclicDFAs()
	{
    	this.dfa3 = new DFA3(this);
    	this.dfa4 = new DFA4(this);
    	this.dfa24 = new DFA24(this);
    	this.dfa40 = new DFA40(this);
    	this.dfa44 = new DFA44(this);
    	this.dfa53 = new DFA53(this);






	}

    const string DFA3_eotS =
        "\x0a\uffff";
    const string DFA3_eofS =
        "\x0a\uffff";
    const string DFA3_minS =
        "\x03\x04\x06\uffff\x01\x09";
    const string DFA3_maxS =
        "\x01\x38\x01\x1d\x01\x04\x06\uffff\x01\x0b";
    const string DFA3_acceptS =
        "\x03\uffff\x01\x01\x01\x02\x01\x03\x01\x05\x01\x06\x01\x04\x01"+
        "\uffff";
    const string DFA3_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x01\x01\x02\uffff\x01\x02\x02\uffff\x01\x03\x11\uffff\x01"+
            "\x04\x03\uffff\x01\x03\x01\uffff\x01\x05\x02\x03\x03\uffff\x01"+
            "\x03\x01\uffff\x01\x03\x01\x06\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x07\x03\uffff\x05\x07",
            "\x01\x08\x03\uffff\x01\x03\x02\uffff\x01\x03\x05\uffff\x01"+
            "\x03\x0b\uffff\x01\x03",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x03\x01\uffff\x01\x06"
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
            get { return "34:1: expr1 returns [Element ret] : ( expr2 | matrixvardec | structdec | structobjdec | functiondefination | plotfunctions );"; }
        }

    }

    const string DFA4_eotS =
        "\x0b\uffff";
    const string DFA4_eofS =
        "\x0b\uffff";
    const string DFA4_minS =
        "\x01\x04\x01\x08\x09\uffff";
    const string DFA4_maxS =
        "\x01\x2e\x01\x1d\x09\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\x09\x01\x01\x01\x07";
    const string DFA4_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x02\uffff\x01\x02\x02\uffff\x01\x02\x15\uffff\x01"+
            "\x03\x02\uffff\x01\x04\x01\x05\x03\uffff\x01\x06\x01\uffff\x01"+
            "\x07\x03\uffff\x01\x08",
            "\x01\x09\x02\uffff\x01\x0a\x05\uffff\x01\x09\x0b\uffff\x01"+
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
            get { return "43:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )"; }
        }

    }

    const string DFA24_eotS =
        "\x0b\uffff";
    const string DFA24_eofS =
        "\x0b\uffff";
    const string DFA24_minS =
        "\x01\x04\x0a\uffff";
    const string DFA24_maxS =
        "\x01\x2e\x0a\uffff";
    const string DFA24_acceptS =
        "\x01\uffff\x01\x02\x09\x01";
    const string DFA24_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA24_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x04\x04\uffff\x01"+
            "\x01\x10\uffff\x01\x05\x02\uffff\x01\x06\x01\x07\x02\uffff\x01"+
            "\x01\x01\x08\x01\uffff\x01\x09\x03\uffff\x01\x0a",
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

    static readonly short[] DFA24_eot = DFA.UnpackEncodedString(DFA24_eotS);
    static readonly short[] DFA24_eof = DFA.UnpackEncodedString(DFA24_eofS);
    static readonly char[] DFA24_min = DFA.UnpackEncodedStringToUnsignedChars(DFA24_minS);
    static readonly char[] DFA24_max = DFA.UnpackEncodedStringToUnsignedChars(DFA24_maxS);
    static readonly short[] DFA24_accept = DFA.UnpackEncodedString(DFA24_acceptS);
    static readonly short[] DFA24_special = DFA.UnpackEncodedString(DFA24_specialS);
    static readonly short[][] DFA24_transition = DFA.UnpackEncodedStringArray(DFA24_transitionS);

    protected class DFA24 : DFA
    {
        public DFA24(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 24;
            this.eot = DFA24_eot;
            this.eof = DFA24_eof;
            this.min = DFA24_min;
            this.max = DFA24_max;
            this.accept = DFA24_accept;
            this.special = DFA24_special;
            this.transition = DFA24_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 235:229: (e11= expr2 )+"; }
        }

    }

    const string DFA40_eotS =
        "\x0e\uffff";
    const string DFA40_eofS =
        "\x0e\uffff";
    const string DFA40_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA40_maxS =
        "\x01\x2f\x01\uffff\x01\x1d\x0b\uffff";
    const string DFA40_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x01\x01\x02";
    const string DFA40_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA40_transitionS = {
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

    static readonly short[] DFA40_eot = DFA.UnpackEncodedString(DFA40_eotS);
    static readonly short[] DFA40_eof = DFA.UnpackEncodedString(DFA40_eofS);
    static readonly char[] DFA40_min = DFA.UnpackEncodedStringToUnsignedChars(DFA40_minS);
    static readonly char[] DFA40_max = DFA.UnpackEncodedStringToUnsignedChars(DFA40_maxS);
    static readonly short[] DFA40_accept = DFA.UnpackEncodedString(DFA40_acceptS);
    static readonly short[] DFA40_special = DFA.UnpackEncodedString(DFA40_specialS);
    static readonly short[][] DFA40_transition = DFA.UnpackEncodedStringArray(DFA40_transitionS);

    protected class DFA40 : DFA
    {
        public DFA40(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 40;
            this.eot = DFA40_eot;
            this.eof = DFA40_eof;
            this.min = DFA40_min;
            this.max = DFA40_max;
            this.accept = DFA40_accept;
            this.special = DFA40_special;
            this.transition = DFA40_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 288:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA44_eotS =
        "\x0e\uffff";
    const string DFA44_eofS =
        "\x0e\uffff";
    const string DFA44_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA44_maxS =
        "\x01\x2f\x01\uffff\x01\x1d\x0b\uffff";
    const string DFA44_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x02\x01\x01";
    const string DFA44_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA44_transitionS = {
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

    static readonly short[] DFA44_eot = DFA.UnpackEncodedString(DFA44_eotS);
    static readonly short[] DFA44_eof = DFA.UnpackEncodedString(DFA44_eofS);
    static readonly char[] DFA44_min = DFA.UnpackEncodedStringToUnsignedChars(DFA44_minS);
    static readonly char[] DFA44_max = DFA.UnpackEncodedStringToUnsignedChars(DFA44_maxS);
    static readonly short[] DFA44_accept = DFA.UnpackEncodedString(DFA44_acceptS);
    static readonly short[] DFA44_special = DFA.UnpackEncodedString(DFA44_specialS);
    static readonly short[][] DFA44_transition = DFA.UnpackEncodedStringArray(DFA44_transitionS);

    protected class DFA44 : DFA
    {
        public DFA44(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 44;
            this.eot = DFA44_eot;
            this.eof = DFA44_eof;
            this.min = DFA44_min;
            this.max = DFA44_max;
            this.accept = DFA44_accept;
            this.special = DFA44_special;
            this.transition = DFA44_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 298:6: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA53_eotS =
        "\x21\uffff";
    const string DFA53_eofS =
        "\x21\uffff";
    const string DFA53_minS =
        "\x01\x30\x03\uffff\x02\x0b\x01\uffff\x01\x06\x01\x1b\x01\x0d\x01"+
        "\x04\x01\x06\x01\uffff\x03\x04\x02\x0d\x01\x04\x01\uffff\x01\x1b"+
        "\x02\uffff\x05\x04\x01\x0d\x01\x04\x02\uffff\x01\x04";
    const string DFA53_maxS =
        "\x01\x38\x03\uffff\x02\x0b\x01\uffff\x01\x06\x01\x1b\x01\x1f\x01"+
        "\x1b\x01\x06\x01\uffff\x03\x1b\x02\x1f\x01\x04\x01\uffff\x01\x1b"+
        "\x02\uffff\x05\x1b\x01\x1f\x01\x04\x02\uffff\x01\x1b";
    const string DFA53_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x02\uffff\x01\x0a\x05\uffff"+
        "\x01\x06\x06\uffff\x01\x09\x01\uffff\x01\x05\x01\x04\x07\uffff\x01"+
        "\x07\x01\x08\x01\uffff";
    const string DFA53_specialS =
        "\x21\uffff}>";
    static readonly string[] DFA53_transitionS = {
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

    static readonly short[] DFA53_eot = DFA.UnpackEncodedString(DFA53_eotS);
    static readonly short[] DFA53_eof = DFA.UnpackEncodedString(DFA53_eofS);
    static readonly char[] DFA53_min = DFA.UnpackEncodedStringToUnsignedChars(DFA53_minS);
    static readonly char[] DFA53_max = DFA.UnpackEncodedStringToUnsignedChars(DFA53_maxS);
    static readonly short[] DFA53_accept = DFA.UnpackEncodedString(DFA53_acceptS);
    static readonly short[] DFA53_special = DFA.UnpackEncodedString(DFA53_specialS);
    static readonly short[][] DFA53_transition = DFA.UnpackEncodedStringArray(DFA53_transitionS);

    protected class DFA53 : DFA
    {
        public DFA53(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 53;
            this.eot = DFA53_eot;
            this.eof = DFA53_eof;
            this.min = DFA53_min;
            this.max = DFA53_max;
            this.accept = DFA53_accept;
            this.special = DFA53_special;
            this.transition = DFA53_transition;

        }

        override public string Description
        {
            get { return "371:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program67 = new BitSet(new ulong[]{0x01F14D3D10000492UL});
    public static readonly BitSet FOLLOW_expr1_in_expr94 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallelfor_in_expr98 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr2_in_expr1115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_expr1124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr1135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr1146 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functiondefination_in_expr1157 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_plotfunctions_in_expr1168 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expr2186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_expr2196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_expr2206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_expr2217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr2228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifelse_in_expr2238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_expr2247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forstatement_in_expr2256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_expr2265 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_int_or_double_literal284 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_double_literal_in_var_int_or_double_literal294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varorstruct_in_var_int_or_double_literal302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_varorstruct317 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structassign_in_varorstruct320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal363 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_double_literal385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_string_literal405 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_string_literal409 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_27_in_string_literal414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixvardec434 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixvardec436 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixvardec438 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec441 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec443 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec446 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec449 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec452 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec456 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec459 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixvardec467 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matrixvardec474 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec478 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec483 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec488 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec491 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec504 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec511 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec514 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec521 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matrixvardec527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorvardec545 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorvardec547 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorvardec549 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec552 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec554 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec557 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec560 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorvardec566 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_vectorvardec573 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec578 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec583 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec588 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec591 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec604 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec611 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec614 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec621 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_vectorvardec627 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem647 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem650 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem653 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem655 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem658 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem661 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem685 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorelem688 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorelem691 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorelem694 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment717 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment727 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_vectorelem_in_assignment739 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_matrixelem_in_assignment752 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment760 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_assignment770 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_dotproduct_in_assignment774 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixtranspose_in_assignment783 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_assignment787 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_assignment803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_additive_expression834 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additive_expression839 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_additive_expression_in_additive_expression845 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplicative_expression873 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_bracket_exp_in_multiplicative_expression885 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_matrixelem_in_multiplicative_expression898 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_vectorelem_in_multiplicative_expression911 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplicative_expression920 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_multiplicative_expression942 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_bracket_exp988 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_bracket_exp989 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_bracket_exp991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expression_in_subtractive_exp1020 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_33_in_subtractive_exp1025 = new BitSet(new ulong[]{0x0000000000000870UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_subtractive_exp1031 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_34_in_structdec1061 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structdec1063 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_structdec1067 = new BitSet(new ulong[]{0x0000000000000480UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_structdec1072 = new BitSet(new ulong[]{0x0000000000008480UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_structdec1078 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec1080 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarvardec1101 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_scalarvardec1108 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarvardec1115 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_scalarvardec1119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1141 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1148 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec1154 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1174 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_DOT_in_structassign1177 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1180 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_deletionofvar1200 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_deletionofvar1204 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_deletionofvar1208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_print1227 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_print1230 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_print1239 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_vectorelem_in_print1247 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixelem_in_print1258 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print1272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parallelfor1294 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_parallelfor1295 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_parallelfor1301 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_POINT_in_parallelfor1304 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallelfor1310 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_parallelfor1313 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_parallelfor1318 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_parallelfor1321 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_parallelfor1323 = new BitSet(new ulong[]{0x0000451900000490UL});
    public static readonly BitSet FOLLOW_expr2_in_parallelfor1330 = new BitSet(new ulong[]{0x0000459900008490UL});
    public static readonly BitSet FOLLOW_39_in_parallelfor1336 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_parallelfor1339 = new BitSet(new ulong[]{0x0000451900008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_parallelfor1347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_ifelse1364 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_ifelse1366 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_varorstruct_in_ifelse1369 = new BitSet(new ulong[]{0x0000000007E00000UL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_ifelse1380 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_ifelse1390 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_ifelse1400 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_LESSTHANEQUALTOEXPRESSION_in_ifelse1411 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_ifelse1421 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_ifelse1432 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_ifelse1445 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_ifelse1452 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_ifelse1456 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1458 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1466 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1471 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_ifelse1474 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1477 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1486 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_ifloop1513 = new BitSet(new ulong[]{0x01F1CD3D10000492UL});
    public static readonly BitSet FOLLOW_functionreturn_in_ifloop1516 = new BitSet(new ulong[]{0x01F1CD3D10000492UL});
    public static readonly BitSet FOLLOW_42_in_forstatement1535 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_forstatement1541 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_POINT_in_forstatement1544 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_forstatement1550 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_forstatement1553 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_forstatement1558 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_forstatement1561 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_forstatement1563 = new BitSet(new ulong[]{0x01F14D1D10000490UL});
    public static readonly BitSet FOLLOW_expr1_in_forstatement1568 = new BitSet(new ulong[]{0x01F14D1D10008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_forstatement1573 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_functioncall1594 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functioncall1599 = new BitSet(new ulong[]{0x0000200008002870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1604 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_functioncall1610 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functioncall1615 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1620 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_string_literal_in_functioncall1626 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functioncall1634 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functioncall1638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_functiondefination1665 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1670 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1676 = new BitSet(new ulong[]{0x0000000110002080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1684 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1687 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1692 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1701 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1703 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1707 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1710 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1714 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1722 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1730 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1738 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1744 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1752 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1756 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1760 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1764 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1771 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_functiondefination1774 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1779 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1785 = new BitSet(new ulong[]{0x0000000110002080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1794 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1797 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1801 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1810 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1812 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1816 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1819 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1823 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1831 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1839 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1847 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1853 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1861 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1865 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1869 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1873 = new BitSet(new ulong[]{0x01F1CD3D10008490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1880 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct1902 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_dotproduct1906 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct1912 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_matrixtranspose1931 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_matrixtranspose1933 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixtranspose1935 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_matrixtranspose1938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixreference1954 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixreference1956 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixreference1961 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixreference1963 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixreference1967 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorreference1986 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorreference1988 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorreference1993 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorreference1995 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorreference1999 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarargument_in_arguments2015 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixreference_in_arguments2021 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorreference_in_arguments2027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarargument2059 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarargument2066 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_comment2085 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_comment2086 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_47_in_functionreturn2104 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functionreturn2107 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functionreturn2111 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_plotfunctions2135 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2138 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2145 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2150 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2157 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2162 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2169 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2174 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2181 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2185 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2189 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2194 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2199 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2202 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2208 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2216 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_plotfunctions2223 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2226 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2232 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2237 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2243 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2247 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2251 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2256 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2261 = new BitSet(new ulong[]{0x0000000080002000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2264 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2270 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2278 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_plotfunctions2285 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2286 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2287 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2295 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2297 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2303 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2306 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2312 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2315 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2322 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2327 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2333 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2335 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2341 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2344 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2350 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2355 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2361 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2363 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2369 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2373 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2380 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2382 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2388 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2391 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2398 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2401 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2409 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2414 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2421 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2423 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2429 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2432 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2439 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2444 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2450 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2452 = new BitSet(new ulong[]{0x0000200008000870UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2458 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2462 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_plotfunctions2468 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2469 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_plotfunctions2472 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2476 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2478 = new BitSet(new ulong[]{0x0000000000000002UL});

}
