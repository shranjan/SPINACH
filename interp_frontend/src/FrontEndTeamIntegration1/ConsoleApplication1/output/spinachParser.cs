// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g 2009-11-05 18:26:30


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
		get { return "C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g"; }
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:19:1: program returns [List<Element> ret] : ( expr )+ ;
    public spinachParser.program_return program() // throws RecognitionException [1]
    {   
        spinachParser.program_return retval = new spinachParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:23:3: ( ( expr )+ )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:23:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:23:5: ( expr )+
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
            			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:23:6: expr
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:27:1: expr returns [Element ret] : ( expr1 | parallelfor );
    public spinachParser.expr_return expr() // throws RecognitionException [1]
    {   
        spinachParser.expr_return retval = new spinachParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr12 = null;

        spinachParser.parallelfor_return parallelfor3 = null;



        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:28:3: ( expr1 | parallelfor )
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
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:28:4: expr1
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr1_in_expr91);
                    	expr12 = expr1();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr12.Tree);
                    	retval.ret = ((expr12 != null) ? expr12.ret : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:28:37: parallelfor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallelfor_in_expr95);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:31:1: expr1 returns [Element ret] : ( expr2 | matrixvardec | structdec | structobjdec | functiondefination | plotfunctions );
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
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:32:4: ( expr2 | matrixvardec | structdec | structobjdec | functiondefination | plotfunctions )
            int alt3 = 6;
            alt3 = dfa3.Predict(input);
            switch (alt3) 
            {
                case 1 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:32:6: expr2
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr2_in_expr1112);
                    	expr24 = expr2();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr24.Tree);
                    	retval.ret = ((expr24 != null) ? expr24.ret : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:33:7: matrixvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixvardec_in_expr1121);
                    	matrixvardec5 = matrixvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matrixvardec5.Tree);
                    	 retval.ret = ((matrixvardec5 != null) ? matrixvardec5.ret : null);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:34:8: structdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structdec_in_expr1132);
                    	structdec6 = structdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structdec6.Tree);
                    	retval.ret = ((structdec6 != null) ? structdec6.ret : null);

                    }
                    break;
                case 4 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:35:8: structobjdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structobjdec_in_expr1143);
                    	structobjdec7 = structobjdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structobjdec7.Tree);
                    	 retval.ret = ((structobjdec7 != null) ? structobjdec7.ret : null);

                    }
                    break;
                case 5 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:36:8: functiondefination
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functiondefination_in_expr1154);
                    	functiondefination8 = functiondefination();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functiondefination8.Tree);
                    	retval.ret = ((functiondefination8 != null) ? functiondefination8.ret : null);

                    }
                    break;
                case 6 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:37:9: plotfunctions
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_plotfunctions_in_expr1165);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:39:1: expr2 returns [Element ret] : (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment ) ;
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
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:40:1: ( (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:40:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:40:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )
            	int alt4 = 9;
            	alt4 = dfa4.Predict(input);
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:40:5: el1= assignment
            	        {
            	        	PushFollow(FOLLOW_assignment_in_expr2183);
            	        	el1 = assignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret = ((el1 != null) ? el1.ret : null);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:41:5: el2= scalarvardec
            	        {
            	        	PushFollow(FOLLOW_scalarvardec_in_expr2193);
            	        	el2 = scalarvardec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el2.Tree);
            	        	 retval.ret = ((el2 != null) ? el2.ret : null);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:42:5: el3= vectorvardec
            	        {
            	        	PushFollow(FOLLOW_vectorvardec_in_expr2203);
            	        	el3 = vectorvardec();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el3.Tree);
            	        	 retval.ret = ((el3 != null) ? el3.ret : null);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:43:5: el4= deletionofvar
            	        {
            	        	PushFollow(FOLLOW_deletionofvar_in_expr2214);
            	        	el4 = deletionofvar();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	 retval.ret = ((el4 != null) ? el4.ret : null);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:44:5: el5= print
            	        {
            	        	PushFollow(FOLLOW_print_in_expr2225);
            	        	el5 = print();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el5.Tree);
            	        	 retval.ret = ((el5 != null) ? el5.ret : null); 

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:45:5: el6= ifelse
            	        {
            	        	PushFollow(FOLLOW_ifelse_in_expr2235);
            	        	el6 = ifelse();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el6.Tree);
            	        	retval.ret = ((el6 != null) ? el6.ret : null);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:46:5: el7= functioncall
            	        {
            	        	PushFollow(FOLLOW_functioncall_in_expr2244);
            	        	el7 = functioncall();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el7.Tree);
            	        	retval.ret=((el7 != null) ? el7.ret : null);

            	        }
            	        break;
            	    case 8 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:47:5: el8= forstatement
            	        {
            	        	PushFollow(FOLLOW_forstatement_in_expr2253);
            	        	el8 = forstatement();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el8.Tree);
            	        	retval.ret = ((el8 != null) ? el8.ret : null);

            	        }
            	        break;
            	    case 9 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:48:5: el9= comment
            	        {
            	        	PushFollow(FOLLOW_comment_in_expr2262);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:50:1: var_int_or_double_literal returns [Element ret] : ( variable | int_literal | double_literal ) ;
    public spinachParser.var_int_or_double_literal_return var_int_or_double_literal() // throws RecognitionException [1]
    {   
        spinachParser.var_int_or_double_literal_return retval = new spinachParser.var_int_or_double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.variable_return variable10 = null;

        spinachParser.int_literal_return int_literal11 = null;

        spinachParser.double_literal_return double_literal12 = null;



        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:51:3: ( ( variable | int_literal | double_literal ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:51:6: ( variable | int_literal | double_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:51:6: ( variable | int_literal | double_literal )
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
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:51:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_int_or_double_literal280);
            	        	variable10 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable10.Tree);
            	        	 retval.ret = ((variable10 != null) ? variable10.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:52:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_int_or_double_literal291);
            	        	int_literal11 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal11.Tree);
            	        	retval.ret = ((int_literal11 != null) ? int_literal11.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:53:7: double_literal
            	        {
            	        	PushFollow(FOLLOW_double_literal_in_var_int_or_double_literal301);
            	        	double_literal12 = double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, double_literal12.Tree);
            	        	retval.ret = ((double_literal12 != null) ? double_literal12.ret : null);

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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:55:1: variable returns [VariableElement ret] : VARIABLE ;
    public spinachParser.variable_return variable() // throws RecognitionException [1]
    {   
        spinachParser.variable_return retval = new spinachParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE13 = null;

        object VARIABLE13_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:59:3: ( VARIABLE )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:59:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE13=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable323); 
            		VARIABLE13_tree = (object)adaptor.Create(VARIABLE13);
            		adaptor.AddChild(root_0, VARIABLE13_tree);

            	 retval.ret.setText(((VARIABLE13 != null) ? VARIABLE13.Text : null)); 

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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:61:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public spinachParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        spinachParser.int_literal_return retval = new spinachParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL14 = null;

        object INT_LITERAL14_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:65:3: ( INT_LITERAL )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:65:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL14=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal344); 
            		INT_LITERAL14_tree = (object)adaptor.Create(INT_LITERAL14);
            		adaptor.AddChild(root_0, INT_LITERAL14_tree);

            	 retval.ret.setText(((INT_LITERAL14 != null) ? INT_LITERAL14.Text : null)); 

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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:67:1: double_literal returns [DoubleElement ret] : el1= DOUBLE_LITERAL ;
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
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:71:2: (el1= DOUBLE_LITERAL )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:71:4: el1= DOUBLE_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_double_literal366); 
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:73:1: string_literal returns [StringElement ret] : ( '\"' (el1= var_int_or_double_literal )* '\"' ) ;
    public spinachParser.string_literal_return string_literal() // throws RecognitionException [1]
    {   
        spinachParser.string_literal_return retval = new spinachParser.string_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal15 = null;
        IToken char_literal16 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;


        object char_literal15_tree=null;
        object char_literal16_tree=null;


         retval.ret = new StringElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:77:2: ( ( '\"' (el1= var_int_or_double_literal )* '\"' ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:77:3: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:77:3: ( '\"' (el1= var_int_or_double_literal )* '\"' )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:77:4: '\"' (el1= var_int_or_double_literal )* '\"'
            	{
            		char_literal15=(IToken)Match(input,27,FOLLOW_27_in_string_literal386); 
            			char_literal15_tree = (object)adaptor.Create(char_literal15);
            			adaptor.AddChild(root_0, char_literal15_tree);

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:77:7: (el1= var_int_or_double_literal )*
            		do 
            		{
            		    int alt6 = 2;
            		    int LA6_0 = input.LA(1);

            		    if ( ((LA6_0 >= VARIABLE && LA6_0 <= DOUBLE_LITERAL)) )
            		    {
            		        alt6 = 1;
            		    }


            		    switch (alt6) 
            			{
            				case 1 :
            				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:77:8: el1= var_int_or_double_literal
            				    {
            				    	PushFollow(FOLLOW_var_int_or_double_literal_in_string_literal390);
            				    	el1 = var_int_or_double_literal();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	retval.ret.setText(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop6;
            		    }
            		} while (true);

            		loop6:
            			;	// Stops C# compiler whining that label 'loop6' has no statements

            		char_literal16=(IToken)Match(input,27,FOLLOW_27_in_string_literal395); 
            			char_literal16_tree = (object)adaptor.Create(char_literal16);
            			adaptor.AddChild(root_0, char_literal16_tree);

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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:79:1: matrixvardec returns [MatrixVariableDeclaration ret] : ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT ;
    public spinachParser.matrixvardec_return matrixvardec() // throws RecognitionException [1]
    {   
        spinachParser.matrixvardec_return retval = new spinachParser.matrixvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal17 = null;
        IToken char_literal18 = null;
        IToken VARTYPE19 = null;
        IToken char_literal20 = null;
        IToken char_literal21 = null;
        IToken char_literal22 = null;
        IToken char_literal23 = null;
        IToken char_literal24 = null;
        IToken ASSIGNMENT25 = null;
        IToken char_literal26 = null;
        IToken char_literal27 = null;
        IToken char_literal28 = null;
        IToken char_literal29 = null;
        IToken END_OF_STATEMENT30 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;

        spinachParser.int_literal_return el7 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal17_tree=null;
        object char_literal18_tree=null;
        object VARTYPE19_tree=null;
        object char_literal20_tree=null;
        object char_literal21_tree=null;
        object char_literal22_tree=null;
        object char_literal23_tree=null;
        object char_literal24_tree=null;
        object ASSIGNMENT25_tree=null;
        object char_literal26_tree=null;
        object char_literal27_tree=null;
        object char_literal28_tree=null;
        object char_literal29_tree=null;
        object END_OF_STATEMENT30_tree=null;


        	retval.ret = new MatrixVariableDeclaration();
        	
        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:83:2: ( ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:83:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:83:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:83:4: 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']'
            	{
            		string_literal17=(IToken)Match(input,28,FOLLOW_28_in_matrixvardec415); 
            			string_literal17_tree = (object)adaptor.Create(string_literal17);
            			adaptor.AddChild(root_0, string_literal17_tree);

            		char_literal18=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixvardec417); 
            			char_literal18_tree = (object)adaptor.Create(char_literal18);
            			adaptor.AddChild(root_0, char_literal18_tree);

            		VARTYPE19=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixvardec419); 
            			VARTYPE19_tree = (object)adaptor.Create(VARTYPE19);
            			adaptor.AddChild(root_0, VARTYPE19_tree);

            		 retval.ret.setType(((VARTYPE19 != null) ? VARTYPE19.Text : null));
            		char_literal20=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec422); 
            			char_literal20_tree = (object)adaptor.Create(char_literal20);
            			adaptor.AddChild(root_0, char_literal20_tree);

            		char_literal21=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec424); 
            			char_literal21_tree = (object)adaptor.Create(char_literal21);
            			adaptor.AddChild(root_0, char_literal21_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec427);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            		char_literal22=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec430); 
            			char_literal22_tree = (object)adaptor.Create(char_literal22);
            			adaptor.AddChild(root_0, char_literal22_tree);

            		char_literal23=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec433); 
            			char_literal23_tree = (object)adaptor.Create(char_literal23);
            			adaptor.AddChild(root_0, char_literal23_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec437);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            		char_literal24=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec440); 
            			char_literal24_tree = (object)adaptor.Create(char_literal24);
            			adaptor.AddChild(root_0, char_literal24_tree);

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:85:3: (el3= variable )
            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:85:4: el3= variable
            		{
            			PushFollow(FOLLOW_variable_in_matrixvardec448);
            			el3 = variable();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el3.Tree);
            			 retval.ret.setVar(((el3 != null) ? el3.ret : null));

            		}

            		ASSIGNMENT25=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matrixvardec455); 
            			ASSIGNMENT25_tree = (object)adaptor.Create(ASSIGNMENT25);
            			adaptor.AddChild(root_0, ASSIGNMENT25_tree);

            		char_literal26=(IToken)Match(input,29,FOLLOW_29_in_matrixvardec459); 
            			char_literal26_tree = (object)adaptor.Create(char_literal26);
            			adaptor.AddChild(root_0, char_literal26_tree);

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:87:6: ( (el7= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) )
            		int alt9 = 2;
            		int LA9_0 = input.LA(1);

            		if ( (LA9_0 == INT_LITERAL) )
            		{
            		    alt9 = 1;
            		}
            		else if ( (LA9_0 == DOUBLE_LITERAL) )
            		{
            		    alt9 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d9s0 =
            		        new NoViableAltException("", 9, 0, input);

            		    throw nvae_d9s0;
            		}
            		switch (alt9) 
            		{
            		    case 1 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:87:7: (el7= int_literal ( ',' el5= int_literal )* )
            		        {
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:87:7: (el7= int_literal ( ',' el5= int_literal )* )
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:87:8: el7= int_literal ( ',' el5= int_literal )*
            		        	{
            		        		PushFollow(FOLLOW_int_literal_in_matrixvardec464);
            		        		el7 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el7.Tree);
            		        		retval.ret.addValue(((el7 != null) ? el7.ret : null));
            		        		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:87:57: ( ',' el5= int_literal )*
            		        		do 
            		        		{
            		        		    int alt7 = 2;
            		        		    int LA7_0 = input.LA(1);

            		        		    if ( (LA7_0 == 31) )
            		        		    {
            		        		        alt7 = 1;
            		        		    }


            		        		    switch (alt7) 
            		        			{
            		        				case 1 :
            		        				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:87:58: ',' el5= int_literal
            		        				    {
            		        				    	char_literal27=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec469); 
            		        				    		char_literal27_tree = (object)adaptor.Create(char_literal27);
            		        				    		adaptor.AddChild(root_0, char_literal27_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_matrixvardec472);
            		        				    	el5 = int_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el5.Tree);
            		        				    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop7;
            		        		    }
            		        		} while (true);

            		        		loop7:
            		        			;	// Stops C# compiler whining that label 'loop7' has no statements


            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:88:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        {
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:88:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:88:4: el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		PushFollow(FOLLOW_double_literal_in_matrixvardec485);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:89:3: ( ',' el6= double_literal )*
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
            		        				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:89:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal28=(IToken)Match(input,31,FOLLOW_31_in_matrixvardec492); 
            		        				    		char_literal28_tree = (object)adaptor.Create(char_literal28);
            		        				    		adaptor.AddChild(root_0, char_literal28_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_matrixvardec495);
            		        				    	el6 = double_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el6.Tree);
            		        				    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

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

            		}

            		char_literal29=(IToken)Match(input,30,FOLLOW_30_in_matrixvardec502); 
            			char_literal29_tree = (object)adaptor.Create(char_literal29);
            			adaptor.AddChild(root_0, char_literal29_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT30=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matrixvardec508); 
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:92:1: vectorvardec returns [VectorVariableDeclaration ret] : ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT ;
    public spinachParser.vectorvardec_return vectorvardec() // throws RecognitionException [1]
    {   
        spinachParser.vectorvardec_return retval = new spinachParser.vectorvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal31 = null;
        IToken char_literal32 = null;
        IToken VARTYPE33 = null;
        IToken char_literal34 = null;
        IToken char_literal35 = null;
        IToken char_literal36 = null;
        IToken ASSIGNMENT37 = null;
        IToken char_literal38 = null;
        IToken char_literal39 = null;
        IToken char_literal40 = null;
        IToken char_literal41 = null;
        IToken END_OF_STATEMENT42 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.variable_return el2 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal31_tree=null;
        object char_literal32_tree=null;
        object VARTYPE33_tree=null;
        object char_literal34_tree=null;
        object char_literal35_tree=null;
        object char_literal36_tree=null;
        object ASSIGNMENT37_tree=null;
        object char_literal38_tree=null;
        object char_literal39_tree=null;
        object char_literal40_tree=null;
        object char_literal41_tree=null;
        object END_OF_STATEMENT42_tree=null;


        	retval.ret = new VectorVariableDeclaration();
        	
        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:96:2: ( ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:96:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:96:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']' )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:96:4: 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) ) ']'
            	{
            		string_literal31=(IToken)Match(input,32,FOLLOW_32_in_vectorvardec526); 
            			string_literal31_tree = (object)adaptor.Create(string_literal31);
            			adaptor.AddChild(root_0, string_literal31_tree);

            		char_literal32=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorvardec528); 
            			char_literal32_tree = (object)adaptor.Create(char_literal32);
            			adaptor.AddChild(root_0, char_literal32_tree);

            		VARTYPE33=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorvardec530); 
            			VARTYPE33_tree = (object)adaptor.Create(VARTYPE33);
            			adaptor.AddChild(root_0, VARTYPE33_tree);

            		 retval.ret.setType(((VARTYPE33 != null) ? VARTYPE33.Text : null));
            		char_literal34=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec533); 
            			char_literal34_tree = (object)adaptor.Create(char_literal34);
            			adaptor.AddChild(root_0, char_literal34_tree);

            		char_literal35=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec535); 
            			char_literal35_tree = (object)adaptor.Create(char_literal35);
            			adaptor.AddChild(root_0, char_literal35_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorvardec538);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setRange(((el1 != null) ? el1.ret : null));
            		char_literal36=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec541); 
            			char_literal36_tree = (object)adaptor.Create(char_literal36);
            			adaptor.AddChild(root_0, char_literal36_tree);

            		PushFollow(FOLLOW_variable_in_vectorvardec547);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setText(((el2 != null) ? el2.ret : null));
            		ASSIGNMENT37=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_vectorvardec554); 
            			ASSIGNMENT37_tree = (object)adaptor.Create(ASSIGNMENT37);
            			adaptor.AddChild(root_0, ASSIGNMENT37_tree);

            		char_literal38=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec559); 
            			char_literal38_tree = (object)adaptor.Create(char_literal38);
            			adaptor.AddChild(root_0, char_literal38_tree);

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:99:6: ( (el3= int_literal ( ',' el5= int_literal )* ) | (el4= double_literal ( ',' el6= double_literal )* ) )
            		int alt12 = 2;
            		int LA12_0 = input.LA(1);

            		if ( (LA12_0 == INT_LITERAL) )
            		{
            		    alt12 = 1;
            		}
            		else if ( (LA12_0 == DOUBLE_LITERAL) )
            		{
            		    alt12 = 2;
            		}
            		else 
            		{
            		    NoViableAltException nvae_d12s0 =
            		        new NoViableAltException("", 12, 0, input);

            		    throw nvae_d12s0;
            		}
            		switch (alt12) 
            		{
            		    case 1 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:99:7: (el3= int_literal ( ',' el5= int_literal )* )
            		        {
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:99:7: (el3= int_literal ( ',' el5= int_literal )* )
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:99:8: el3= int_literal ( ',' el5= int_literal )*
            		        	{
            		        		PushFollow(FOLLOW_int_literal_in_vectorvardec564);
            		        		el3 = int_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el3.Tree);
            		        		retval.ret.addValue(((el3 != null) ? el3.ret : null));
            		        		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:99:57: ( ',' el5= int_literal )*
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
            		        				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:99:58: ',' el5= int_literal
            		        				    {
            		        				    	char_literal39=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec569); 
            		        				    		char_literal39_tree = (object)adaptor.Create(char_literal39);
            		        				    		adaptor.AddChild(root_0, char_literal39_tree);

            		        				    	PushFollow(FOLLOW_int_literal_in_vectorvardec572);
            		        				    	el5 = int_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el5.Tree);
            		        				    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            		        				    }
            		        				    break;

            		        				default:
            		        				    goto loop10;
            		        		    }
            		        		} while (true);

            		        		loop10:
            		        			;	// Stops C# compiler whining that label 'loop10' has no statements


            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:100:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        {
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:100:3: (el4= double_literal ( ',' el6= double_literal )* )
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:100:4: el4= double_literal ( ',' el6= double_literal )*
            		        	{
            		        		PushFollow(FOLLOW_double_literal_in_vectorvardec585);
            		        		el4 = double_literal();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, el4.Tree);
            		        		retval.ret.addValue(((el4 != null) ? el4.ret : null));
            		        		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:101:3: ( ',' el6= double_literal )*
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
            		        				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:101:4: ',' el6= double_literal
            		        				    {
            		        				    	char_literal40=(IToken)Match(input,31,FOLLOW_31_in_vectorvardec592); 
            		        				    		char_literal40_tree = (object)adaptor.Create(char_literal40);
            		        				    		adaptor.AddChild(root_0, char_literal40_tree);

            		        				    	PushFollow(FOLLOW_double_literal_in_vectorvardec595);
            		        				    	el6 = double_literal();
            		        				    	state.followingStackPointer--;

            		        				    	adaptor.AddChild(root_0, el6.Tree);
            		        				    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

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

            		}

            		char_literal41=(IToken)Match(input,30,FOLLOW_30_in_vectorvardec602); 
            			char_literal41_tree = (object)adaptor.Create(char_literal41);
            			adaptor.AddChild(root_0, char_literal41_tree);

            		retval.ret.setValue();

            	}

            	END_OF_STATEMENT42=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_vectorvardec608); 
            		END_OF_STATEMENT42_tree = (object)adaptor.Create(END_OF_STATEMENT42);
            		adaptor.AddChild(root_0, END_OF_STATEMENT42_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:104:1: matrixelem returns [MatrixElement ret] : (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' ) ;
    public spinachParser.matrixelem_return matrixelem() // throws RecognitionException [1]
    {   
        spinachParser.matrixelem_return retval = new spinachParser.matrixelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal43 = null;
        IToken char_literal44 = null;
        IToken char_literal45 = null;
        IToken char_literal46 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.int_literal_return el3 = null;


        object char_literal43_tree=null;
        object char_literal44_tree=null;
        object char_literal45_tree=null;
        object char_literal46_tree=null;


         retval.ret = new MatrixElement();
         
        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:108:2: ( (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:108:3: (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:108:3: (el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']' )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:108:4: el1= variable '[' el2= int_literal ']' '[' el3= int_literal ']'
            	{
            		PushFollow(FOLLOW_variable_in_matrixelem628);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal43=(IToken)Match(input,29,FOLLOW_29_in_matrixelem631); 
            			char_literal43_tree = (object)adaptor.Create(char_literal43);
            			adaptor.AddChild(root_0, char_literal43_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixelem634);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setRow(((el2 != null) ? el2.ret : null));
            		char_literal44=(IToken)Match(input,30,FOLLOW_30_in_matrixelem636); 
            			char_literal44_tree = (object)adaptor.Create(char_literal44);
            			adaptor.AddChild(root_0, char_literal44_tree);

            		char_literal45=(IToken)Match(input,29,FOLLOW_29_in_matrixelem639); 
            			char_literal45_tree = (object)adaptor.Create(char_literal45);
            			adaptor.AddChild(root_0, char_literal45_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixelem642);
            		el3 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el3.Tree);
            		retval.ret.setColumn(((el3 != null) ? el3.ret : null));
            		char_literal46=(IToken)Match(input,30,FOLLOW_30_in_matrixelem644); 
            			char_literal46_tree = (object)adaptor.Create(char_literal46);
            			adaptor.AddChild(root_0, char_literal46_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:111:1: vectorelem returns [VectorElement ret] : (el1= variable '[' el2= int_literal ']' ) ;
    public spinachParser.vectorelem_return vectorelem() // throws RecognitionException [1]
    {   
        spinachParser.vectorelem_return retval = new spinachParser.vectorelem_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal47 = null;
        IToken char_literal48 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.int_literal_return el2 = null;


        object char_literal47_tree=null;
        object char_literal48_tree=null;


         retval.ret = new VectorElement();
         
        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:115:2: ( (el1= variable '[' el2= int_literal ']' ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:115:3: (el1= variable '[' el2= int_literal ']' )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:115:3: (el1= variable '[' el2= int_literal ']' )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:115:4: el1= variable '[' el2= int_literal ']'
            	{
            		PushFollow(FOLLOW_variable_in_vectorelem666);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setVar(((el1 != null) ? el1.ret : null));
            		char_literal47=(IToken)Match(input,29,FOLLOW_29_in_vectorelem669); 
            			char_literal47_tree = (object)adaptor.Create(char_literal47);
            			adaptor.AddChild(root_0, char_literal47_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorelem672);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setRange(((el2 != null) ? el2.ret : null));
            		char_literal48=(IToken)Match(input,30,FOLLOW_30_in_vectorelem675); 
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:117:1: assignment returns [AssignmentOperationElement ret] : ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) ) END_OF_STATEMENT ;
    public spinachParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        spinachParser.assignment_return retval = new spinachParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT51 = null;
        IToken END_OF_STATEMENT56 = null;
        spinachParser.vectorelem_return e12 = null;

        spinachParser.matrixelem_return e11 = null;

        spinachParser.variable_return variable49 = null;

        spinachParser.structassign_return structassign50 = null;

        spinachParser.subtractive_exp_return subtractive_exp52 = null;

        spinachParser.dotproduct_return dotproduct53 = null;

        spinachParser.matrixtranspose_return matrixtranspose54 = null;

        spinachParser.string_literal_return string_literal55 = null;


        object ASSIGNMENT51_tree=null;
        object END_OF_STATEMENT56_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:121:3: ( ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) ) END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:121:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:121:5: ( ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal ) )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:121:6: ( variable | structassign | e12= vectorelem | e11= matrixelem ) ASSIGNMENT ( subtractive_exp | dotproduct | matrixtranspose | string_literal )
            	{
            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:121:6: ( variable | structassign | e12= vectorelem | e11= matrixelem )
            		int alt13 = 4;
            		int LA13_0 = input.LA(1);

            		if ( (LA13_0 == VARIABLE) )
            		{
            		    switch ( input.LA(2) ) 
            		    {
            		    case 29:
            		    	{
            		        int LA13_2 = input.LA(3);

            		        if ( (LA13_2 == INT_LITERAL) )
            		        {
            		            int LA13_5 = input.LA(4);

            		            if ( (LA13_5 == 30) )
            		            {
            		                int LA13_6 = input.LA(5);

            		                if ( (LA13_6 == 29) )
            		                {
            		                    alt13 = 4;
            		                }
            		                else if ( (LA13_6 == ASSIGNMENT) )
            		                {
            		                    alt13 = 3;
            		                }
            		                else 
            		                {
            		                    NoViableAltException nvae_d13s6 =
            		                        new NoViableAltException("", 13, 6, input);

            		                    throw nvae_d13s6;
            		                }
            		            }
            		            else 
            		            {
            		                NoViableAltException nvae_d13s5 =
            		                    new NoViableAltException("", 13, 5, input);

            		                throw nvae_d13s5;
            		            }
            		        }
            		        else 
            		        {
            		            NoViableAltException nvae_d13s2 =
            		                new NoViableAltException("", 13, 2, input);

            		            throw nvae_d13s2;
            		        }
            		        }
            		        break;
            		    case DOT:
            		    	{
            		        alt13 = 2;
            		        }
            		        break;
            		    case ASSIGNMENT:
            		    	{
            		        alt13 = 1;
            		        }
            		        break;
            		    	default:
            		    	    NoViableAltException nvae_d13s1 =
            		    	        new NoViableAltException("", 13, 1, input);

            		    	    throw nvae_d13s1;
            		    }

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
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:121:7: variable
            		        {
            		        	PushFollow(FOLLOW_variable_in_assignment698);
            		        	variable49 = variable();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, variable49.Tree);
            		        	retval.ret.setLhs(((variable49 != null) ? variable49.ret : null)); 

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:122:7: structassign
            		        {
            		        	PushFollow(FOLLOW_structassign_in_assignment708);
            		        	structassign50 = structassign();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, structassign50.Tree);
            		        	retval.ret.setLhs(((structassign50 != null) ? structassign50.ret : null));

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:123:6: e12= vectorelem
            		        {
            		        	PushFollow(FOLLOW_vectorelem_in_assignment720);
            		        	e12 = vectorelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e12.Tree);
            		        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:124:7: e11= matrixelem
            		        {
            		        	PushFollow(FOLLOW_matrixelem_in_assignment733);
            		        	e11 = matrixelem();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, e11.Tree);
            		        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		        }
            		        break;

            		}

            		ASSIGNMENT51=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment741); 
            			ASSIGNMENT51_tree = (object)adaptor.Create(ASSIGNMENT51);
            			adaptor.AddChild(root_0, ASSIGNMENT51_tree);

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:126:5: ( subtractive_exp | dotproduct | matrixtranspose | string_literal )
            		int alt14 = 4;
            		switch ( input.LA(1) ) 
            		{
            		case VARIABLE:
            			{
            		    int LA14_1 = input.LA(2);

            		    if ( (LA14_1 == 44) )
            		    {
            		        alt14 = 2;
            		    }
            		    else if ( (LA14_1 == END_OF_STATEMENT || (LA14_1 >= PLUS && LA14_1 <= MULTIPLY) || LA14_1 == 29 || LA14_1 == 33) )
            		    {
            		        alt14 = 1;
            		    }
            		    else 
            		    {
            		        NoViableAltException nvae_d14s1 =
            		            new NoViableAltException("", 14, 1, input);

            		        throw nvae_d14s1;
            		    }
            		    }
            		    break;
            		case INT_LITERAL:
            		case DOUBLE_LITERAL:
            		case LEFTBRACE:
            			{
            		    alt14 = 1;
            		    }
            		    break;
            		case 45:
            			{
            		    alt14 = 3;
            		    }
            		    break;
            		case 27:
            			{
            		    alt14 = 4;
            		    }
            		    break;
            			default:
            			    NoViableAltException nvae_d14s0 =
            			        new NoViableAltException("", 14, 0, input);

            			    throw nvae_d14s0;
            		}

            		switch (alt14) 
            		{
            		    case 1 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:126:7: subtractive_exp
            		        {
            		        	PushFollow(FOLLOW_subtractive_exp_in_assignment750);
            		        	subtractive_exp52 = subtractive_exp();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, subtractive_exp52.Tree);
            		        	retval.ret.setRhs(((subtractive_exp52 != null) ? subtractive_exp52.ret : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:126:66: dotproduct
            		        {
            		        	PushFollow(FOLLOW_dotproduct_in_assignment754);
            		        	dotproduct53 = dotproduct();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, dotproduct53.Tree);
            		        	retval.ret.setRhs(((dotproduct53 != null) ? dotproduct53.ret : null));

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:127:7: matrixtranspose
            		        {
            		        	PushFollow(FOLLOW_matrixtranspose_in_assignment763);
            		        	matrixtranspose54 = matrixtranspose();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, matrixtranspose54.Tree);
            		        	retval.ret.setRhs(((matrixtranspose54 != null) ? matrixtranspose54.ret : null));

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:127:66: string_literal
            		        {
            		        	PushFollow(FOLLOW_string_literal_in_assignment767);
            		        	string_literal55 = string_literal();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, string_literal55.Tree);
            		        	retval.ret.setRhs(((string_literal55 != null) ? string_literal55.ret : null));

            		        }
            		        break;

            		}


            	}

            	END_OF_STATEMENT56=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment782); 
            		END_OF_STATEMENT56_tree = (object)adaptor.Create(END_OF_STATEMENT56);
            		adaptor.AddChild(root_0, END_OF_STATEMENT56_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:132:1: additive_expression returns [AdditiveElement ret] : ( (e11= multiplicative_expression ) ( '+' e12= multiplicative_expression )* ) ;
    public spinachParser.additive_expression_return additive_expression() // throws RecognitionException [1]
    {   
        spinachParser.additive_expression_return retval = new spinachParser.additive_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal57 = null;
        spinachParser.multiplicative_expression_return e11 = null;

        spinachParser.multiplicative_expression_return e12 = null;


        object char_literal57_tree=null;


        	retval.ret = new AdditiveElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:136:2: ( ( (e11= multiplicative_expression ) ( '+' e12= multiplicative_expression )* ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:136:4: ( (e11= multiplicative_expression ) ( '+' e12= multiplicative_expression )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:136:4: ( (e11= multiplicative_expression ) ( '+' e12= multiplicative_expression )* )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:136:5: (e11= multiplicative_expression ) ( '+' e12= multiplicative_expression )*
            	{
            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:136:5: (e11= multiplicative_expression )
            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:136:6: e11= multiplicative_expression
            		{
            			PushFollow(FOLLOW_multiplicative_expression_in_additive_expression810);
            			e11 = multiplicative_expression();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, e11.Tree);
            			retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            		}

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:136:69: ( '+' e12= multiplicative_expression )*
            		do 
            		{
            		    int alt15 = 2;
            		    int LA15_0 = input.LA(1);

            		    if ( (LA15_0 == PLUS) )
            		    {
            		        alt15 = 1;
            		    }


            		    switch (alt15) 
            			{
            				case 1 :
            				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:136:70: '+' e12= multiplicative_expression
            				    {
            				    	char_literal57=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_additive_expression815); 
            				    		char_literal57_tree = (object)adaptor.Create(char_literal57);
            				    		adaptor.AddChild(root_0, char_literal57_tree);

            				    	PushFollow(FOLLOW_multiplicative_expression_in_additive_expression821);
            				    	e12 = multiplicative_expression();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, e12.Tree);
            				    	retval.ret.setRhs(((e12 != null) ? e12.ret : null));

            				    }
            				    break;

            				default:
            				    goto loop15;
            		    }
            		} while (true);

            		loop15:
            			;	// Stops C# compiler whining that label 'loop15' has no statements


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:139:1: multiplicative_expression returns [MultiplicationElement ret] : (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' (e15= var_int_or_double_literal | e16= bracket_exp | el7= vectorelem | el8= matrixelem ) )* ;
    public spinachParser.multiplicative_expression_return multiplicative_expression() // throws RecognitionException [1]
    {   
        spinachParser.multiplicative_expression_return retval = new spinachParser.multiplicative_expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal58 = null;
        spinachParser.var_int_or_double_literal_return e11 = null;

        spinachParser.bracket_exp_return e12 = null;

        spinachParser.matrixelem_return el3 = null;

        spinachParser.vectorelem_return el4 = null;

        spinachParser.var_int_or_double_literal_return e15 = null;

        spinachParser.bracket_exp_return e16 = null;

        spinachParser.vectorelem_return el7 = null;

        spinachParser.matrixelem_return el8 = null;


        object char_literal58_tree=null;


        	retval.ret = new MultiplicationElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:143:2: ( (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' (e15= var_int_or_double_literal | e16= bracket_exp | el7= vectorelem | el8= matrixelem ) )* )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:143:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem ) ( '*' (e15= var_int_or_double_literal | e16= bracket_exp | el7= vectorelem | el8= matrixelem ) )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:143:4: (e11= var_int_or_double_literal | e12= bracket_exp | el3= matrixelem | el4= vectorelem )
            	int alt16 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    int LA16_1 = input.LA(2);

            	    if ( (LA16_1 == 29) )
            	    {
            	        int LA16_4 = input.LA(3);

            	        if ( (LA16_4 == INT_LITERAL) )
            	        {
            	            int LA16_5 = input.LA(4);

            	            if ( (LA16_5 == 30) )
            	            {
            	                int LA16_6 = input.LA(5);

            	                if ( (LA16_6 == 29) )
            	                {
            	                    alt16 = 3;
            	                }
            	                else if ( (LA16_6 == END_OF_STATEMENT || LA16_6 == RIGHTBRACE || (LA16_6 >= PLUS && LA16_6 <= MULTIPLY) || LA16_6 == 33) )
            	                {
            	                    alt16 = 4;
            	                }
            	                else 
            	                {
            	                    NoViableAltException nvae_d16s6 =
            	                        new NoViableAltException("", 16, 6, input);

            	                    throw nvae_d16s6;
            	                }
            	            }
            	            else 
            	            {
            	                NoViableAltException nvae_d16s5 =
            	                    new NoViableAltException("", 16, 5, input);

            	                throw nvae_d16s5;
            	            }
            	        }
            	        else 
            	        {
            	            NoViableAltException nvae_d16s4 =
            	                new NoViableAltException("", 16, 4, input);

            	            throw nvae_d16s4;
            	        }
            	    }
            	    else if ( (LA16_1 == END_OF_STATEMENT || LA16_1 == RIGHTBRACE || (LA16_1 >= PLUS && LA16_1 <= MULTIPLY) || LA16_1 == 33) )
            	    {
            	        alt16 = 1;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d16s1 =
            	            new NoViableAltException("", 16, 1, input);

            	        throw nvae_d16s1;
            	    }
            	    }
            	    break;
            	case INT_LITERAL:
            	case DOUBLE_LITERAL:
            		{
            	    alt16 = 1;
            	    }
            	    break;
            	case LEFTBRACE:
            		{
            	    alt16 = 2;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d16s0 =
            		        new NoViableAltException("", 16, 0, input);

            		    throw nvae_d16s0;
            	}

            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:143:5: e11= var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplicative_expression849);
            	        	e11 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e11.Tree);
            	        	retval.ret.setLhs(((e11 != null) ? e11.ret : null));

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:144:7: e12= bracket_exp
            	        {
            	        	PushFollow(FOLLOW_bracket_exp_in_multiplicative_expression861);
            	        	e12 = bracket_exp();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e12.Tree);
            	        	retval.ret.setLhs(((e12 != null) ? e12.ret : null));

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:145:7: el3= matrixelem
            	        {
            	        	PushFollow(FOLLOW_matrixelem_in_multiplicative_expression874);
            	        	el3 = matrixelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el3.Tree);
            	        	retval.ret.setLhs(((el3 != null) ? el3.ret : null));

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:146:7: el4= vectorelem
            	        {
            	        	PushFollow(FOLLOW_vectorelem_in_multiplicative_expression887);
            	        	el4 = vectorelem();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el4.Tree);
            	        	retval.ret.setLhs(((el4 != null) ? el4.ret : null));

            	        }
            	        break;

            	}

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:147:5: ( '*' (e15= var_int_or_double_literal | e16= bracket_exp | el7= vectorelem | el8= matrixelem ) )*
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
            			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:147:6: '*' (e15= var_int_or_double_literal | e16= bracket_exp | el7= vectorelem | el8= matrixelem )
            			    {
            			    	char_literal58=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplicative_expression896); 
            			    		char_literal58_tree = (object)adaptor.Create(char_literal58);
            			    		adaptor.AddChild(root_0, char_literal58_tree);

            			    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:147:9: (e15= var_int_or_double_literal | e16= bracket_exp | el7= vectorelem | el8= matrixelem )
            			    	int alt17 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case VARIABLE:
            			    		{
            			    	    int LA17_1 = input.LA(2);

            			    	    if ( (LA17_1 == 29) )
            			    	    {
            			    	        int LA17_4 = input.LA(3);

            			    	        if ( (LA17_4 == INT_LITERAL) )
            			    	        {
            			    	            int LA17_5 = input.LA(4);

            			    	            if ( (LA17_5 == 30) )
            			    	            {
            			    	                int LA17_6 = input.LA(5);

            			    	                if ( (LA17_6 == 29) )
            			    	                {
            			    	                    alt17 = 4;
            			    	                }
            			    	                else if ( (LA17_6 == END_OF_STATEMENT || LA17_6 == RIGHTBRACE || (LA17_6 >= PLUS && LA17_6 <= MULTIPLY) || LA17_6 == 33) )
            			    	                {
            			    	                    alt17 = 3;
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
            			    	    else if ( (LA17_1 == END_OF_STATEMENT || LA17_1 == RIGHTBRACE || (LA17_1 >= PLUS && LA17_1 <= MULTIPLY) || LA17_1 == 33) )
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
            			    	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:147:11: e15= var_int_or_double_literal
            			    	        {
            			    	        	PushFollow(FOLLOW_var_int_or_double_literal_in_multiplicative_expression902);
            			    	        	e15 = var_int_or_double_literal();
            			    	        	state.followingStackPointer--;

            			    	        	adaptor.AddChild(root_0, e15.Tree);
            			    	        	retval.ret.setRhs(((e15 != null) ? e15.ret : null));

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:148:7: e16= bracket_exp
            			    	        {
            			    	        	PushFollow(FOLLOW_bracket_exp_in_multiplicative_expression915);
            			    	        	e16 = bracket_exp();
            			    	        	state.followingStackPointer--;

            			    	        	adaptor.AddChild(root_0, e16.Tree);
            			    	        	retval.ret.setRhs(((e16 != null) ? e16.ret : null));

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:149:7: el7= vectorelem
            			    	        {
            			    	        	PushFollow(FOLLOW_vectorelem_in_multiplicative_expression928);
            			    	        	el7 = vectorelem();
            			    	        	state.followingStackPointer--;

            			    	        	adaptor.AddChild(root_0, el7.Tree);
            			    	        	retval.ret.setLhs(((el7 != null) ? el7.ret : null));

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:150:7: el8= matrixelem
            			    	        {
            			    	        	PushFollow(FOLLOW_matrixelem_in_multiplicative_expression941);
            			    	        	el8 = matrixelem();
            			    	        	state.followingStackPointer--;

            			    	        	adaptor.AddChild(root_0, el8.Tree);
            			    	        	retval.ret.setLhs(((el8 != null) ? el8.ret : null));

            			    	        }
            			    	        break;

            			    	}


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:154:1: bracket_exp returns [BracketElement ret] : '(' subtractive_exp ')' ;
    public spinachParser.bracket_exp_return bracket_exp() // throws RecognitionException [1]
    {   
        spinachParser.bracket_exp_return retval = new spinachParser.bracket_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal59 = null;
        IToken char_literal61 = null;
        spinachParser.subtractive_exp_return subtractive_exp60 = null;


        object char_literal59_tree=null;
        object char_literal61_tree=null;


        	retval.ret = new BracketElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:158:1: ( '(' subtractive_exp ')' )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:158:3: '(' subtractive_exp ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal59=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_bracket_exp978); 
            		char_literal59_tree = (object)adaptor.Create(char_literal59);
            		adaptor.AddChild(root_0, char_literal59_tree);

            	PushFollow(FOLLOW_subtractive_exp_in_bracket_exp979);
            	subtractive_exp60 = subtractive_exp();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, subtractive_exp60.Tree);
            	retval.ret.setbracketexpression(((subtractive_exp60 != null) ? subtractive_exp60.ret : null));
            	char_literal61=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_bracket_exp981); 
            		char_literal61_tree = (object)adaptor.Create(char_literal61);
            		adaptor.AddChild(root_0, char_literal61_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:164:1: subtractive_exp returns [SubtractionElement ret] : (e11= additive_expression ( '-' e12= additive_expression )* ) ;
    public spinachParser.subtractive_exp_return subtractive_exp() // throws RecognitionException [1]
    {   
        spinachParser.subtractive_exp_return retval = new spinachParser.subtractive_exp_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal62 = null;
        spinachParser.additive_expression_return e11 = null;

        spinachParser.additive_expression_return e12 = null;


        object char_literal62_tree=null;


        	retval.ret = new SubtractionElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:168:1: ( (e11= additive_expression ( '-' e12= additive_expression )* ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:168:6: (e11= additive_expression ( '-' e12= additive_expression )* )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:168:6: (e11= additive_expression ( '-' e12= additive_expression )* )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:168:7: e11= additive_expression ( '-' e12= additive_expression )*
            	{
            		PushFollow(FOLLOW_additive_expression_in_subtractive_exp1010);
            		e11 = additive_expression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, e11.Tree);
            		retval.ret.setLhs(((e11 != null) ? e11.ret : null));
            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:168:64: ( '-' e12= additive_expression )*
            		do 
            		{
            		    int alt19 = 2;
            		    int LA19_0 = input.LA(1);

            		    if ( (LA19_0 == 33) )
            		    {
            		        alt19 = 1;
            		    }


            		    switch (alt19) 
            			{
            				case 1 :
            				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:168:65: '-' e12= additive_expression
            				    {
            				    	char_literal62=(IToken)Match(input,33,FOLLOW_33_in_subtractive_exp1015); 
            				    		char_literal62_tree = (object)adaptor.Create(char_literal62);
            				    		adaptor.AddChild(root_0, char_literal62_tree);

            				    	PushFollow(FOLLOW_additive_expression_in_subtractive_exp1021);
            				    	e12 = additive_expression();
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:172:1: structdec returns [StructDeclaration ret] : ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT ;
    public spinachParser.structdec_return structdec() // throws RecognitionException [1]
    {   
        spinachParser.structdec_return retval = new spinachParser.structdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal63 = null;
        IToken char_literal65 = null;
        IToken char_literal66 = null;
        IToken END_OF_STATEMENT67 = null;
        spinachParser.scalarvardec_return el1 = null;

        spinachParser.variable_return variable64 = null;


        object string_literal63_tree=null;
        object char_literal65_tree=null;
        object char_literal66_tree=null;
        object END_OF_STATEMENT67_tree=null;


        retval.ret = new StructDeclaration();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:176:1: ( ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:176:3: ( 'struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:176:3: ( 'struct' variable '{' (el1= scalarvardec )+ '}' )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:176:4: 'struct' variable '{' (el1= scalarvardec )+ '}'
            	{
            		string_literal63=(IToken)Match(input,34,FOLLOW_34_in_structdec1051); 
            			string_literal63_tree = (object)adaptor.Create(string_literal63);
            			adaptor.AddChild(root_0, string_literal63_tree);

            		PushFollow(FOLLOW_variable_in_structdec1053);
            		variable64 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable64.Tree);
            		 retval.ret.setName(((variable64 != null) ? variable64.ret : null));
            		char_literal65=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_structdec1057); 
            			char_literal65_tree = (object)adaptor.Create(char_literal65);
            			adaptor.AddChild(root_0, char_literal65_tree);

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:177:5: (el1= scalarvardec )+
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
            				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:177:6: el1= scalarvardec
            				    {
            				    	PushFollow(FOLLOW_scalarvardec_in_structdec1062);
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

            		char_literal66=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_structdec1068); 
            			char_literal66_tree = (object)adaptor.Create(char_literal66);
            			adaptor.AddChild(root_0, char_literal66_tree);


            	}

            	END_OF_STATEMENT67=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec1070); 
            		END_OF_STATEMENT67_tree = (object)adaptor.Create(END_OF_STATEMENT67);
            		adaptor.AddChild(root_0, END_OF_STATEMENT67_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:180:1: scalarvardec returns [ScalarVariableDeclaration ret] : ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT ;
    public spinachParser.scalarvardec_return scalarvardec() // throws RecognitionException [1]
    {   
        spinachParser.scalarvardec_return retval = new spinachParser.scalarvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE68 = null;
        IToken STRINGTYPE69 = null;
        IToken END_OF_STATEMENT71 = null;
        spinachParser.variable_return variable70 = null;


        object VARTYPE68_tree=null;
        object STRINGTYPE69_tree=null;
        object END_OF_STATEMENT71_tree=null;


        	retval.ret = new ScalarVariableDeclaration();
        	
        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:184:2: ( ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:184:3: ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:184:3: ( ( VARTYPE | STRINGTYPE ) variable )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:184:4: ( VARTYPE | STRINGTYPE ) variable
            	{
            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:184:4: ( VARTYPE | STRINGTYPE )
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
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:184:5: VARTYPE
            		        {
            		        	VARTYPE68=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarvardec1091); 
            		        		VARTYPE68_tree = (object)adaptor.Create(VARTYPE68);
            		        		adaptor.AddChild(root_0, VARTYPE68_tree);

            		        	 retval.ret.setType(((VARTYPE68 != null) ? VARTYPE68.Text : null));

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:185:4: STRINGTYPE
            		        {
            		        	STRINGTYPE69=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_scalarvardec1098); 
            		        		STRINGTYPE69_tree = (object)adaptor.Create(STRINGTYPE69);
            		        		adaptor.AddChild(root_0, STRINGTYPE69_tree);

            		        	 retval.ret.setType(((STRINGTYPE69 != null) ? STRINGTYPE69.Text : null));

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_variable_in_scalarvardec1105);
            		variable70 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable70.Tree);
            		 retval.ret.setVar(((variable70 != null) ? variable70.ret : null));

            	}

            	END_OF_STATEMENT71=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_scalarvardec1109); 
            		END_OF_STATEMENT71_tree = (object)adaptor.Create(END_OF_STATEMENT71);
            		adaptor.AddChild(root_0, END_OF_STATEMENT71_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:189:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
    public spinachParser.structobjdec_return structobjdec() // throws RecognitionException [1]
    {   
        spinachParser.structobjdec_return retval = new spinachParser.structobjdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT72 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object END_OF_STATEMENT72_tree=null;


        retval.ret = new StructObjectDeclaration();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:193:1: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:193:3: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:193:3: (el1= variable el2= variable )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:193:4: el1= variable el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structobjdec1131);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		PushFollow(FOLLOW_variable_in_structobjdec1138);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	END_OF_STATEMENT72=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec1144); 
            		END_OF_STATEMENT72_tree = (object)adaptor.Create(END_OF_STATEMENT72);
            		adaptor.AddChild(root_0, END_OF_STATEMENT72_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:197:1: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
    public spinachParser.structassign_return structassign() // throws RecognitionException [1]
    {   
        spinachParser.structassign_return retval = new spinachParser.structassign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal73 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object char_literal73_tree=null;


        retval.ret = new StructAssignDeclaration();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:201:1: ( (el1= variable '.' el2= variable ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:201:2: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:201:2: (el1= variable '.' el2= variable )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:201:3: el1= variable '.' el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structassign1164);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setName(((el1 != null) ? el1.ret : null));
            		char_literal73=(IToken)Match(input,DOT,FOLLOW_DOT_in_structassign1167); 
            			char_literal73_tree = (object)adaptor.Create(char_literal73);
            			adaptor.AddChild(root_0, char_literal73_tree);

            		PushFollow(FOLLOW_variable_in_structassign1170);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:203:1: deletionofvar returns [DeleteVariable ret] : ( 'delete' el1= variable ) END_OF_STATEMENT ;
    public spinachParser.deletionofvar_return deletionofvar() // throws RecognitionException [1]
    {   
        spinachParser.deletionofvar_return retval = new spinachParser.deletionofvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal74 = null;
        IToken END_OF_STATEMENT75 = null;
        spinachParser.variable_return el1 = null;


        object string_literal74_tree=null;
        object END_OF_STATEMENT75_tree=null;


        retval.ret = new DeleteVariable();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:207:1: ( ( 'delete' el1= variable ) END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:207:2: ( 'delete' el1= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:207:2: ( 'delete' el1= variable )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:207:3: 'delete' el1= variable
            	{
            		string_literal74=(IToken)Match(input,35,FOLLOW_35_in_deletionofvar1190); 
            			string_literal74_tree = (object)adaptor.Create(string_literal74);
            			adaptor.AddChild(root_0, string_literal74_tree);

            		PushFollow(FOLLOW_variable_in_deletionofvar1194);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setVar(((el1 != null) ? el1.ret : null));

            	}

            	END_OF_STATEMENT75=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_deletionofvar1198); 
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:209:1: print returns [PrintOperationElement ret] : 'print' var_int_or_double_literal END_OF_STATEMENT ;
    public spinachParser.print_return print() // throws RecognitionException [1]
    {   
        spinachParser.print_return retval = new spinachParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal76 = null;
        IToken END_OF_STATEMENT78 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal77 = null;


        object string_literal76_tree=null;
        object END_OF_STATEMENT78_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:213:3: ( 'print' var_int_or_double_literal END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:213:5: 'print' var_int_or_double_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal76=(IToken)Match(input,36,FOLLOW_36_in_print1217); 
            		string_literal76_tree = (object)adaptor.Create(string_literal76);
            		adaptor.AddChild(root_0, string_literal76_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_print1219);
            	var_int_or_double_literal77 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal77.Tree);
            	retval.ret.setChildElement(((var_int_or_double_literal77 != null) ? var_int_or_double_literal77.ret : null)); 
            	END_OF_STATEMENT78=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print1227); 
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:217:1: parallelfor returns [ParallelForElement ret] : 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS ;
    public spinachParser.parallelfor_return parallelfor() // throws RecognitionException [1]
    {   
        spinachParser.parallelfor_return retval = new spinachParser.parallelfor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal79 = null;
        IToken LEFTPARANTHESIS80 = null;
        IToken string_literal81 = null;
        IToken END_OF_STATEMENT82 = null;
        IToken RIGHTPARANTHESIS83 = null;
        spinachParser.range_return r11 = null;

        spinachParser.expr2_return e11 = null;


        object string_literal79_tree=null;
        object LEFTPARANTHESIS80_tree=null;
        object string_literal81_tree=null;
        object END_OF_STATEMENT82_tree=null;
        object RIGHTPARANTHESIS83_tree=null;


          retval.ret = new ParallelForElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:2: ( 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:4: 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal79=(IToken)Match(input,37,FOLLOW_37_in_parallelfor1249); 
            		string_literal79_tree = (object)adaptor.Create(string_literal79);
            		adaptor.AddChild(root_0, string_literal79_tree);

            	PushFollow(FOLLOW_range_in_parallelfor1255);
            	r11 = range();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGE = ((r11 != null) ? r11.ret : null);
            	LEFTPARANTHESIS80=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_parallelfor1258); 
            		LEFTPARANTHESIS80_tree = (object)adaptor.Create(LEFTPARANTHESIS80);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS80_tree);

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:79: ( (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+
            	int cnt24 = 0;
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == VARIABLE || LA24_0 == VARTYPE || LA24_0 == STRINGTYPE || LA24_0 == 32 || (LA24_0 >= 35 && LA24_0 <= 36) || LA24_0 == 40 || LA24_0 == 42 || LA24_0 == 46) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:80: (e11= expr2 )+ ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    {
            			    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:80: (e11= expr2 )+
            			    	int cnt22 = 0;
            			    	do 
            			    	{
            			    	    int alt22 = 2;
            			    	    alt22 = dfa22.Predict(input);
            			    	    switch (alt22) 
            			    		{
            			    			case 1 :
            			    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:81: e11= expr2
            			    			    {
            			    			    	PushFollow(FOLLOW_expr2_in_parallelfor1265);
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

            			    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:123: ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    	int alt23 = 2;
            			    	int LA23_0 = input.LA(1);

            			    	if ( (LA23_0 == 38) )
            			    	{
            			    	    alt23 = 1;
            			    	}
            			    	else if ( (LA23_0 == VARIABLE || LA23_0 == VARTYPE || LA23_0 == STRINGTYPE || LA23_0 == RIGHTPARANTHESIS || LA23_0 == 32 || (LA23_0 >= 35 && LA23_0 <= 36) || LA23_0 == 40 || LA23_0 == 42 || LA23_0 == 46) )
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
            			    	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:124: ( 'SYNC' END_OF_STATEMENT )
            			    	        {
            			    	        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:124: ( 'SYNC' END_OF_STATEMENT )
            			    	        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:125: 'SYNC' END_OF_STATEMENT
            			    	        	{
            			    	        		string_literal81=(IToken)Match(input,38,FOLLOW_38_in_parallelfor1271); 
            			    	        			string_literal81_tree = (object)adaptor.Create(string_literal81);
            			    	        			adaptor.AddChild(root_0, string_literal81_tree);

            			    	        		retval.ret.syncfunction();
            			    	        		END_OF_STATEMENT82=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_parallelfor1274); 
            			    	        			END_OF_STATEMENT82_tree = (object)adaptor.Create(END_OF_STATEMENT82);
            			    	        			adaptor.AddChild(root_0, END_OF_STATEMENT82_tree);


            			    	        	}


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:220:178: 
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

            	RIGHTPARANTHESIS83=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_parallelfor1282); 
            		RIGHTPARANTHESIS83_tree = (object)adaptor.Create(RIGHTPARANTHESIS83);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS83_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:223:1: range returns [RangeElement ret] : LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE ;
    public spinachParser.range_return range() // throws RecognitionException [1]
    {   
        spinachParser.range_return retval = new spinachParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LEFTBRACE84 = null;
        IToken POINT85 = null;
        IToken string_literal86 = null;
        IToken RIGHTBRACE87 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.int_literal_return e12 = null;

        spinachParser.int_literal_return e13 = null;


        object LEFTBRACE84_tree=null;
        object POINT85_tree=null;
        object string_literal86_tree=null;
        object RIGHTBRACE87_tree=null;


          retval.ret= new RangeElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:226:2: ( LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:226:3: LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LEFTBRACE84=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_range1296); 
            		LEFTBRACE84_tree = (object)adaptor.Create(LEFTBRACE84);
            		adaptor.AddChild(root_0, LEFTBRACE84_tree);

            	PushFollow(FOLLOW_variable_in_range1302);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.RANGEVARIABLE = ((e11 != null) ? e11.ret : null);
            	POINT85=(IToken)Match(input,POINT,FOLLOW_POINT_in_range1305); 
            		POINT85_tree = (object)adaptor.Create(POINT85);
            		adaptor.AddChild(root_0, POINT85_tree);

            	PushFollow(FOLLOW_int_literal_in_range1311);
            	e12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.STARTINGRANGE = ((e12 != null) ? e12.ret : null);
            	string_literal86=(IToken)Match(input,39,FOLLOW_39_in_range1314); 
            		string_literal86_tree = (object)adaptor.Create(string_literal86);
            		adaptor.AddChild(root_0, string_literal86_tree);

            	PushFollow(FOLLOW_int_literal_in_range1319);
            	e13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e13.Tree);
            	retval.ret.ENDINGRANGE = ((e13 != null) ? e13.ret : null);
            	RIGHTBRACE87=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_range1322); 
            		RIGHTBRACE87_tree = (object)adaptor.Create(RIGHTBRACE87);
            		adaptor.AddChild(root_0, RIGHTBRACE87_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:229:1: ifelse returns [IfStatementElement ret] : ( 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? ;
    public spinachParser.ifelse_return ifelse() // throws RecognitionException [1]
    {   
        spinachParser.ifelse_return retval = new spinachParser.ifelse_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal88 = null;
        IToken LEFTBRACE89 = null;
        IToken RIGHTBRACE96 = null;
        IToken LEFTPARANTHESIS97 = null;
        IToken RIGHTPARANTHESIS98 = null;
        IToken string_literal99 = null;
        IToken LEFTPARANTHESIS100 = null;
        IToken RIGHTPARANTHESIS101 = null;
        spinachParser.ifloop_return e11 = null;

        spinachParser.ifloop_return e12 = null;

        spinachParser.equality_return equality90 = null;

        spinachParser.nonequality_return nonequality91 = null;

        spinachParser.lessthan_return lessthan92 = null;

        spinachParser.lessthanequalto_return lessthanequalto93 = null;

        spinachParser.greaterthan_return greaterthan94 = null;

        spinachParser.greaterthanequalto_return greaterthanequalto95 = null;


        object string_literal88_tree=null;
        object LEFTBRACE89_tree=null;
        object RIGHTBRACE96_tree=null;
        object LEFTPARANTHESIS97_tree=null;
        object RIGHTPARANTHESIS98_tree=null;
        object string_literal99_tree=null;
        object LEFTPARANTHESIS100_tree=null;
        object RIGHTPARANTHESIS101_tree=null;


           retval.ret = new IfStatementElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:233:1: ( ( 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )? )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:233:2: ( 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:233:2: ( 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:233:3: 'if' LEFTBRACE ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto ) RIGHTBRACE LEFTPARANTHESIS ( (e11= ifloop ) | ) RIGHTPARANTHESIS
            	{
            		string_literal88=(IToken)Match(input,40,FOLLOW_40_in_ifelse1339); 
            			string_literal88_tree = (object)adaptor.Create(string_literal88);
            			adaptor.AddChild(root_0, string_literal88_tree);

            		LEFTBRACE89=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_ifelse1341); 
            			LEFTBRACE89_tree = (object)adaptor.Create(LEFTBRACE89);
            			adaptor.AddChild(root_0, LEFTBRACE89_tree);

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:233:18: ( equality | nonequality | lessthan | lessthanequalto | greaterthan | greaterthanequalto )
            		int alt25 = 6;
            		int LA25_0 = input.LA(1);

            		if ( (LA25_0 == VARIABLE) )
            		{
            		    switch ( input.LA(2) ) 
            		    {
            		    case NONEQUALITYEXPRESSION:
            		    	{
            		        alt25 = 2;
            		        }
            		        break;
            		    case EQUALITYEXPRESSION:
            		    	{
            		        alt25 = 1;
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
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:233:19: equality
            		        {
            		        	PushFollow(FOLLOW_equality_in_ifelse1344);
            		        	equality90 = equality();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, equality90.Tree);
            		        	retval.ret.CONDITION = ((equality90 != null) ? equality90.ret : null);

            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:233:67: nonequality
            		        {
            		        	PushFollow(FOLLOW_nonequality_in_ifelse1347);
            		        	nonequality91 = nonequality();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, nonequality91.Tree);
            		        	retval.ret.CONDITION = ((nonequality91 != null) ? nonequality91.ret : null);

            		        }
            		        break;
            		    case 3 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:233:121: lessthan
            		        {
            		        	PushFollow(FOLLOW_lessthan_in_ifelse1350);
            		        	lessthan92 = lessthan();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, lessthan92.Tree);
            		        	retval.ret.CONDITION = ((lessthan92 != null) ? lessthan92.ret : null);

            		        }
            		        break;
            		    case 4 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:234:4: lessthanequalto
            		        {
            		        	PushFollow(FOLLOW_lessthanequalto_in_ifelse1356);
            		        	lessthanequalto93 = lessthanequalto();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, lessthanequalto93.Tree);
            		        	retval.ret.CONDITION = ((lessthanequalto93 != null) ? lessthanequalto93.ret : null);

            		        }
            		        break;
            		    case 5 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:234:66: greaterthan
            		        {
            		        	PushFollow(FOLLOW_greaterthan_in_ifelse1359);
            		        	greaterthan94 = greaterthan();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, greaterthan94.Tree);
            		        	retval.ret.CONDITION =((greaterthan94 != null) ? greaterthan94.ret : null);

            		        }
            		        break;
            		    case 6 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:234:120: greaterthanequalto
            		        {
            		        	PushFollow(FOLLOW_greaterthanequalto_in_ifelse1363);
            		        	greaterthanequalto95 = greaterthanequalto();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, greaterthanequalto95.Tree);
            		        	retval.ret.CONDITION = ((greaterthanequalto95 != null) ? greaterthanequalto95.ret : null);

            		        }
            		        break;

            		}

            		RIGHTBRACE96=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_ifelse1368); 
            			RIGHTBRACE96_tree = (object)adaptor.Create(RIGHTBRACE96);
            			adaptor.AddChild(root_0, RIGHTBRACE96_tree);

            		LEFTPARANTHESIS97=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1370); 
            			LEFTPARANTHESIS97_tree = (object)adaptor.Create(LEFTPARANTHESIS97);
            			adaptor.AddChild(root_0, LEFTPARANTHESIS97_tree);

            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:30: ( (e11= ifloop ) | )
            		int alt26 = 2;
            		int LA26_0 = input.LA(1);

            		if ( (LA26_0 == VARIABLE || LA26_0 == VARTYPE || LA26_0 == STRINGTYPE || LA26_0 == 28 || LA26_0 == 32 || (LA26_0 >= 34 && LA26_0 <= 37) || LA26_0 == 40 || (LA26_0 >= 42 && LA26_0 <= 43) || (LA26_0 >= 46 && LA26_0 <= 48) || (LA26_0 >= 52 && LA26_0 <= 56)) )
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
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:31: (e11= ifloop )
            		        {
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:31: (e11= ifloop )
            		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:32: e11= ifloop
            		        	{
            		        		PushFollow(FOLLOW_ifloop_in_ifelse1378);
            		        		e11 = ifloop();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, e11.Tree);
            		        		retval.ret.IFCODE = ((e11 != null) ? e11.ret : null);

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:77: 
            		        {
            		        }
            		        break;

            		}

            		RIGHTPARANTHESIS98=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1383); 
            			RIGHTPARANTHESIS98_tree = (object)adaptor.Create(RIGHTPARANTHESIS98);
            			adaptor.AddChild(root_0, RIGHTPARANTHESIS98_tree);


            	}

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:95: ( 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == 41) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:96: 'else' LEFTPARANTHESIS ( (e12= ifloop ) | ) RIGHTPARANTHESIS
            	        {
            	        	string_literal99=(IToken)Match(input,41,FOLLOW_41_in_ifelse1386); 
            	        		string_literal99_tree = (object)adaptor.Create(string_literal99);
            	        		adaptor.AddChild(root_0, string_literal99_tree);

            	        	LEFTPARANTHESIS100=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse1389); 
            	        		LEFTPARANTHESIS100_tree = (object)adaptor.Create(LEFTPARANTHESIS100);
            	        		adaptor.AddChild(root_0, LEFTPARANTHESIS100_tree);

            	        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:120: ( (e12= ifloop ) | )
            	        	int alt27 = 2;
            	        	int LA27_0 = input.LA(1);

            	        	if ( (LA27_0 == VARIABLE || LA27_0 == VARTYPE || LA27_0 == STRINGTYPE || LA27_0 == 28 || LA27_0 == 32 || (LA27_0 >= 34 && LA27_0 <= 37) || LA27_0 == 40 || (LA27_0 >= 42 && LA27_0 <= 43) || (LA27_0 >= 46 && LA27_0 <= 48) || (LA27_0 >= 52 && LA27_0 <= 56)) )
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
            	        	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:121: (e12= ifloop )
            	        	        {
            	        	        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:121: (e12= ifloop )
            	        	        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:122: e12= ifloop
            	        	        	{
            	        	        		PushFollow(FOLLOW_ifloop_in_ifelse1398);
            	        	        		e12 = ifloop();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, e12.Tree);
            	        	        		retval.ret.ELSECODE = ((e12 != null) ? e12.ret : null);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:235:170: 
            	        	        {
            	        	        }
            	        	        break;

            	        	}

            	        	RIGHTPARANTHESIS101=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse1404); 
            	        		RIGHTPARANTHESIS101_tree = (object)adaptor.Create(RIGHTPARANTHESIS101);
            	        		adaptor.AddChild(root_0, RIGHTPARANTHESIS101_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:237:1: ifloop returns [List<Element> ret] : ( expr | functionreturn )+ ;
    public spinachParser.ifloop_return ifloop() // throws RecognitionException [1]
    {   
        spinachParser.ifloop_return retval = new spinachParser.ifloop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr_return expr102 = null;

        spinachParser.functionreturn_return functionreturn103 = null;




           retval.ret = new List<Element>();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:242:1: ( ( expr | functionreturn )+ )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:242:3: ( expr | functionreturn )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:242:3: ( expr | functionreturn )+
            	int cnt29 = 0;
            	do 
            	{
            	    int alt29 = 3;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == VARIABLE || LA29_0 == VARTYPE || LA29_0 == STRINGTYPE || LA29_0 == 28 || LA29_0 == 32 || (LA29_0 >= 34 && LA29_0 <= 37) || LA29_0 == 40 || (LA29_0 >= 42 && LA29_0 <= 43) || LA29_0 == 46 || LA29_0 == 48 || (LA29_0 >= 52 && LA29_0 <= 56)) )
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
            			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:242:4: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_ifloop1425);
            			    	expr102 = expr();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expr102.Tree);
            			    	retval.ret.Add(((expr102 != null) ? expr102.ret : null));

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:242:37: functionreturn
            			    {
            			    	PushFollow(FOLLOW_functionreturn_in_ifloop1428);
            			    	functionreturn103 = functionreturn();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, functionreturn103.Tree);
            			    	retval.ret.Add(((functionreturn103 != null) ? functionreturn103.ret : null));

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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:246:1: forstatement returns [ForStatementElement ret] : 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS ;
    public spinachParser.forstatement_return forstatement() // throws RecognitionException [1]
    {   
        spinachParser.forstatement_return retval = new spinachParser.forstatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal104 = null;
        IToken LEFTPARANTHESIS105 = null;
        IToken RIGHTPARANTHESIS106 = null;
        spinachParser.range_return r11 = null;

        spinachParser.expr1_return e11 = null;


        object string_literal104_tree=null;
        object LEFTPARANTHESIS105_tree=null;
        object RIGHTPARANTHESIS106_tree=null;


           retval.ret = new ForStatementElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:249:2: ( 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:249:3: 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal104=(IToken)Match(input,42,FOLLOW_42_in_forstatement1447); 
            		string_literal104_tree = (object)adaptor.Create(string_literal104);
            		adaptor.AddChild(root_0, string_literal104_tree);

            	PushFollow(FOLLOW_range_in_forstatement1452);
            	r11 = range();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGE = ((r11 != null) ? r11.ret : null);
            	LEFTPARANTHESIS105=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_forstatement1455); 
            		LEFTPARANTHESIS105_tree = (object)adaptor.Create(LEFTPARANTHESIS105);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS105_tree);

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:249:66: (e11= expr1 )+
            	int cnt30 = 0;
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == VARIABLE || LA30_0 == VARTYPE || LA30_0 == STRINGTYPE || LA30_0 == 28 || LA30_0 == 32 || (LA30_0 >= 34 && LA30_0 <= 36) || LA30_0 == 40 || (LA30_0 >= 42 && LA30_0 <= 43) || LA30_0 == 46 || LA30_0 == 48 || (LA30_0 >= 52 && LA30_0 <= 56)) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:249:67: e11= expr1
            			    {
            			    	PushFollow(FOLLOW_expr1_in_forstatement1460);
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

            	RIGHTPARANTHESIS106=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_forstatement1465); 
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:252:4: functioncall returns [FunctionCallElement ret] : variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT ;
    public spinachParser.functioncall_return functioncall() // throws RecognitionException [1]
    {   
        spinachParser.functioncall_return retval = new spinachParser.functioncall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal108 = null;
        IToken char_literal109 = null;
        IToken char_literal110 = null;
        IToken END_OF_STATEMENT111 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;

        spinachParser.var_int_or_double_literal_return el2 = null;

        spinachParser.variable_return variable107 = null;


        object char_literal108_tree=null;
        object char_literal109_tree=null;
        object char_literal110_tree=null;
        object END_OF_STATEMENT111_tree=null;

         retval.ret = new FunctionCallElement();
         
        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:255:3: ( variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:255:4: variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_functioncall1490);
            	variable107 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable107.Tree);
            	retval.ret.setfunctioncallname(((variable107 != null) ? variable107.ret : null));
            	char_literal108=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functioncall1495); 
            		char_literal108_tree = (object)adaptor.Create(char_literal108);
            		adaptor.AddChild(root_0, char_literal108_tree);

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:256:6: (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )?
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( ((LA32_0 >= VARIABLE && LA32_0 <= DOUBLE_LITERAL)) )
            	{
            	    alt32 = 1;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:256:7: el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )*
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1499);
            	        	el1 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret.setparameters(((el1 != null) ? el1.ret : null));
            	        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:256:74: ( ',' el2= var_int_or_double_literal )*
            	        	do 
            	        	{
            	        	    int alt31 = 2;
            	        	    int LA31_0 = input.LA(1);

            	        	    if ( (LA31_0 == 31) )
            	        	    {
            	        	        alt31 = 1;
            	        	    }


            	        	    switch (alt31) 
            	        		{
            	        			case 1 :
            	        			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:256:75: ',' el2= var_int_or_double_literal
            	        			    {
            	        			    	char_literal109=(IToken)Match(input,31,FOLLOW_31_in_functioncall1503); 
            	        			    		char_literal109_tree = (object)adaptor.Create(char_literal109);
            	        			    		adaptor.AddChild(root_0, char_literal109_tree);

            	        			    	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1507);
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

            	char_literal110=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functioncall1514); 
            		char_literal110_tree = (object)adaptor.Create(char_literal110);
            		adaptor.AddChild(root_0, char_literal110_tree);

            	END_OF_STATEMENT111=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functioncall1518); 
            		END_OF_STATEMENT111_tree = (object)adaptor.Create(END_OF_STATEMENT111);
            		adaptor.AddChild(root_0, END_OF_STATEMENT111_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:261:1: equality returns [EqualityOperationElement ret] : e11= variable EQUALITYEXPRESSION var_int_or_double_literal ;
    public spinachParser.equality_return equality() // throws RecognitionException [1]
    {   
        spinachParser.equality_return retval = new spinachParser.equality_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQUALITYEXPRESSION112 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return var_int_or_double_literal113 = null;


        object EQUALITYEXPRESSION112_tree=null;


          retval.ret = new EqualityOperationElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:267:1: (e11= variable EQUALITYEXPRESSION var_int_or_double_literal )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:267:3: e11= variable EQUALITYEXPRESSION var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_equality1547);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setequalityLhs(((e11 != null) ? e11.ret : null)); 
            	EQUALITYEXPRESSION112=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_equality1556); 
            		EQUALITYEXPRESSION112_tree = (object)adaptor.Create(EQUALITYEXPRESSION112);
            		adaptor.AddChild(root_0, EQUALITYEXPRESSION112_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_equality1566);
            	var_int_or_double_literal113 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal113.Tree);
            	retval.ret.setequalityRhs(((var_int_or_double_literal113 != null) ? var_int_or_double_literal113.ret : null)); 

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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:273:1: nonequality returns [NonEqualityOperationElement ret] : e11= variable NONEQUALITYEXPRESSION var_int_or_double_literal ;
    public spinachParser.nonequality_return nonequality() // throws RecognitionException [1]
    {   
        spinachParser.nonequality_return retval = new spinachParser.nonequality_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NONEQUALITYEXPRESSION114 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return var_int_or_double_literal115 = null;


        object NONEQUALITYEXPRESSION114_tree=null;


          retval.ret = new NonEqualityOperationElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:279:1: (e11= variable NONEQUALITYEXPRESSION var_int_or_double_literal )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:279:3: e11= variable NONEQUALITYEXPRESSION var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_nonequality1609);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setnonequalityLhs(((e11 != null) ? e11.ret : null)); 
            	NONEQUALITYEXPRESSION114=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_nonequality1618); 
            		NONEQUALITYEXPRESSION114_tree = (object)adaptor.Create(NONEQUALITYEXPRESSION114);
            		adaptor.AddChild(root_0, NONEQUALITYEXPRESSION114_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_nonequality1623);
            	var_int_or_double_literal115 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal115.Tree);
            	retval.ret.setnonequalityRhs(((var_int_or_double_literal115 != null) ? var_int_or_double_literal115.ret : null)); 

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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:285:1: functiondefination returns [FunctionElement ret] : ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' );
    public spinachParser.functiondefination_return functiondefination() // throws RecognitionException [1]
    {   
        spinachParser.functiondefination_return retval = new spinachParser.functiondefination_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE116 = null;
        IToken char_literal118 = null;
        IToken char_literal119 = null;
        IToken char_literal120 = null;
        IToken char_literal121 = null;
        IToken char_literal133 = null;
        IToken string_literal134 = null;
        IToken char_literal136 = null;
        IToken char_literal137 = null;
        IToken char_literal138 = null;
        IToken char_literal139 = null;
        IToken char_literal151 = null;
        spinachParser.arguments_return e11 = null;

        spinachParser.arguments_return e12 = null;

        spinachParser.variable_return variable117 = null;

        spinachParser.assignment_return assignment122 = null;

        spinachParser.functioncall_return functioncall123 = null;

        spinachParser.scalarvardec_return scalarvardec124 = null;

        spinachParser.vectorvardec_return vectorvardec125 = null;

        spinachParser.matrixvardec_return matrixvardec126 = null;

        spinachParser.deletionofvar_return deletionofvar127 = null;

        spinachParser.print_return print128 = null;

        spinachParser.ifelse_return ifelse129 = null;

        spinachParser.functionreturn_return functionreturn130 = null;

        spinachParser.parallelfor_return parallelfor131 = null;

        spinachParser.forstatement_return forstatement132 = null;

        spinachParser.variable_return variable135 = null;

        spinachParser.assignment_return assignment140 = null;

        spinachParser.functioncall_return functioncall141 = null;

        spinachParser.scalarvardec_return scalarvardec142 = null;

        spinachParser.vectorvardec_return vectorvardec143 = null;

        spinachParser.matrixvardec_return matrixvardec144 = null;

        spinachParser.deletionofvar_return deletionofvar145 = null;

        spinachParser.print_return print146 = null;

        spinachParser.ifelse_return ifelse147 = null;

        spinachParser.functionreturn_return functionreturn148 = null;

        spinachParser.parallelfor_return parallelfor149 = null;

        spinachParser.forstatement_return forstatement150 = null;


        object VARTYPE116_tree=null;
        object char_literal118_tree=null;
        object char_literal119_tree=null;
        object char_literal120_tree=null;
        object char_literal121_tree=null;
        object char_literal133_tree=null;
        object string_literal134_tree=null;
        object char_literal136_tree=null;
        object char_literal137_tree=null;
        object char_literal138_tree=null;
        object char_literal139_tree=null;
        object char_literal151_tree=null;


        retval.ret = new FunctionElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:290:1: ( ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' ) | 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' )
            int alt39 = 2;
            int LA39_0 = input.LA(1);

            if ( (LA39_0 == VARTYPE) )
            {
                alt39 = 1;
            }
            else if ( (LA39_0 == 43) )
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
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:290:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:290:3: ( VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}' )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:290:4: VARTYPE variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}'
                    	{
                    		VARTYPE116=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_functiondefination1655); 
                    			VARTYPE116_tree = (object)adaptor.Create(VARTYPE116);
                    			adaptor.AddChild(root_0, VARTYPE116_tree);

                    		retval.ret.setreturntype(((VARTYPE116 != null) ? VARTYPE116.Text : null));
                    		PushFollow(FOLLOW_variable_in_functiondefination1660);
                    		variable117 = variable();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, variable117.Tree);
                    		retval.ret.setfunctionname(((variable117 != null) ? variable117.ret : null));
                    		char_literal118=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1666); 
                    			char_literal118_tree = (object)adaptor.Create(char_literal118);
                    			adaptor.AddChild(root_0, char_literal118_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:293:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:293:3: (e11= arguments ( ',' e12= arguments )* )?
                    		{
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:293:3: (e11= arguments ( ',' e12= arguments )* )?
                    			int alt34 = 2;
                    			int LA34_0 = input.LA(1);

                    			if ( (LA34_0 == VARTYPE || LA34_0 == 28 || LA34_0 == 32) )
                    			{
                    			    alt34 = 1;
                    			}
                    			switch (alt34) 
                    			{
                    			    case 1 :
                    			        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:293:4: e11= arguments ( ',' e12= arguments )*
                    			        {
                    			        	PushFollow(FOLLOW_arguments_in_functiondefination1674);
                    			        	e11 = arguments();
                    			        	state.followingStackPointer--;

                    			        	adaptor.AddChild(root_0, e11.Tree);
                    			        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    			        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:293:54: ( ',' e12= arguments )*
                    			        	do 
                    			        	{
                    			        	    int alt33 = 2;
                    			        	    int LA33_0 = input.LA(1);

                    			        	    if ( (LA33_0 == 31) )
                    			        	    {
                    			        	        alt33 = 1;
                    			        	    }


                    			        	    switch (alt33) 
                    			        		{
                    			        			case 1 :
                    			        			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:293:55: ',' e12= arguments
                    			        			    {
                    			        			    	char_literal119=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1677); 
                    			        			    		char_literal119_tree = (object)adaptor.Create(char_literal119);
                    			        			    		adaptor.AddChild(root_0, char_literal119_tree);

                    			        			    	PushFollow(FOLLOW_arguments_in_functiondefination1682);
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

                    		char_literal120=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1691); 
                    			char_literal120_tree = (object)adaptor.Create(char_literal120);
                    			adaptor.AddChild(root_0, char_literal120_tree);

                    		char_literal121=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1693); 
                    			char_literal121_tree = (object)adaptor.Create(char_literal121);
                    			adaptor.AddChild(root_0, char_literal121_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:295:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    		int cnt35 = 0;
                    		do 
                    		{
                    		    int alt35 = 12;
                    		    alt35 = dfa35.Predict(input);
                    		    switch (alt35) 
                    			{
                    				case 1 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:295:6: assignment
                    				    {
                    				    	PushFollow(FOLLOW_assignment_in_functiondefination1696);
                    				    	assignment122 = assignment();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, assignment122.Tree);
                    				    	retval.ret.setBody(((assignment122 != null) ? assignment122.ret : null));

                    				    }
                    				    break;
                    				case 2 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:295:55: functioncall
                    				    {
                    				    	PushFollow(FOLLOW_functioncall_in_functiondefination1699);
                    				    	functioncall123 = functioncall();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, functioncall123.Tree);
                    				    	retval.ret.setBody(((functioncall123 != null) ? functioncall123.ret : null));

                    				    }
                    				    break;
                    				case 3 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:295:109: scalarvardec
                    				    {
                    				    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1703);
                    				    	scalarvardec124 = scalarvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, scalarvardec124.Tree);
                    				    	 retval.ret.setBody(((scalarvardec124 != null) ? scalarvardec124.ret : null));

                    				    }
                    				    break;
                    				case 4 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:296:5: vectorvardec
                    				    {
                    				    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1711);
                    				    	vectorvardec125 = vectorvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, vectorvardec125.Tree);
                    				    	 retval.ret.setBody(((vectorvardec125 != null) ? vectorvardec125.ret : null));

                    				    }
                    				    break;
                    				case 5 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:297:5: matrixvardec
                    				    {
                    				    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1719);
                    				    	matrixvardec126 = matrixvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, matrixvardec126.Tree);
                    				    	 retval.ret.setBody(((matrixvardec126 != null) ? matrixvardec126.ret : null));

                    				    }
                    				    break;
                    				case 6 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:298:5: deletionofvar
                    				    {
                    				    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1727);
                    				    	deletionofvar127 = deletionofvar();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, deletionofvar127.Tree);
                    				    	 retval.ret.setBody(((deletionofvar127 != null) ? deletionofvar127.ret : null));

                    				    }
                    				    break;
                    				case 7 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:298:64: print
                    				    {
                    				    	PushFollow(FOLLOW_print_in_functiondefination1733);
                    				    	print128 = print();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, print128.Tree);
                    				    	 retval.ret.setBody(((print128 != null) ? print128.ret : null)); 

                    				    }
                    				    break;
                    				case 8 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:299:5: ifelse
                    				    {
                    				    	PushFollow(FOLLOW_ifelse_in_functiondefination1741);
                    				    	ifelse129 = ifelse();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, ifelse129.Tree);
                    				    	retval.ret.setBody(((ifelse129 != null) ? ifelse129.ret : null));

                    				    }
                    				    break;
                    				case 9 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:299:47: functionreturn
                    				    {
                    				    	PushFollow(FOLLOW_functionreturn_in_functiondefination1745);
                    				    	functionreturn130 = functionreturn();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, functionreturn130.Tree);
                    				    	retval.ret.setBody(((functionreturn130 != null) ? functionreturn130.ret : null));

                    				    }
                    				    break;
                    				case 10 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:299:105: parallelfor
                    				    {
                    				    	PushFollow(FOLLOW_parallelfor_in_functiondefination1749);
                    				    	parallelfor131 = parallelfor();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, parallelfor131.Tree);
                    				    	retval.ret.setBody(((parallelfor131 != null) ? parallelfor131.ret : null));

                    				    }
                    				    break;
                    				case 11 :
                    				    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:299:157: forstatement
                    				    {
                    				    	PushFollow(FOLLOW_forstatement_in_functiondefination1753);
                    				    	forstatement132 = forstatement();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, forstatement132.Tree);
                    				    	retval.ret.setBody(((forstatement132 != null) ? forstatement132.ret : null));

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

                    		char_literal133=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1758); 
                    			char_literal133_tree = (object)adaptor.Create(char_literal133);
                    			adaptor.AddChild(root_0, char_literal133_tree);


                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:300:6: 'void' variable '(' ( (e11= arguments ( ',' e12= arguments )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+ '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal134=(IToken)Match(input,43,FOLLOW_43_in_functiondefination1761); 
                    		string_literal134_tree = (object)adaptor.Create(string_literal134);
                    		adaptor.AddChild(root_0, string_literal134_tree);

                    	retval.ret.setreturntype("void");
                    	PushFollow(FOLLOW_variable_in_functiondefination1766);
                    	variable135 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable135.Tree);
                    	retval.ret.setfunctionname(((variable135 != null) ? variable135.ret : null));
                    	char_literal136=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1772); 
                    		char_literal136_tree = (object)adaptor.Create(char_literal136);
                    		adaptor.AddChild(root_0, char_literal136_tree);

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:303:2: ( (e11= arguments ( ',' e12= arguments )* )? )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:303:3: (e11= arguments ( ',' e12= arguments )* )?
                    	{
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:303:3: (e11= arguments ( ',' e12= arguments )* )?
                    		int alt37 = 2;
                    		int LA37_0 = input.LA(1);

                    		if ( (LA37_0 == VARTYPE || LA37_0 == 28 || LA37_0 == 32) )
                    		{
                    		    alt37 = 1;
                    		}
                    		switch (alt37) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:303:4: e11= arguments ( ',' e12= arguments )*
                    		        {
                    		        	PushFollow(FOLLOW_arguments_in_functiondefination1781);
                    		        	e11 = arguments();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, e11.Tree);
                    		        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:303:55: ( ',' e12= arguments )*
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
                    		        			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:303:56: ',' e12= arguments
                    		        			    {
                    		        			    	char_literal137=(IToken)Match(input,31,FOLLOW_31_in_functiondefination1784); 
                    		        			    		char_literal137_tree = (object)adaptor.Create(char_literal137);
                    		        			    		adaptor.AddChild(root_0, char_literal137_tree);

                    		        			    	PushFollow(FOLLOW_arguments_in_functiondefination1788);
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

                    	char_literal138=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1797); 
                    		char_literal138_tree = (object)adaptor.Create(char_literal138);
                    		adaptor.AddChild(root_0, char_literal138_tree);

                    	char_literal139=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1799); 
                    		char_literal139_tree = (object)adaptor.Create(char_literal139);
                    		adaptor.AddChild(root_0, char_literal139_tree);

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:305:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+
                    	int cnt38 = 0;
                    	do 
                    	{
                    	    int alt38 = 12;
                    	    alt38 = dfa38.Predict(input);
                    	    switch (alt38) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:305:6: assignment
                    			    {
                    			    	PushFollow(FOLLOW_assignment_in_functiondefination1802);
                    			    	assignment140 = assignment();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, assignment140.Tree);
                    			    	retval.ret.setBody(((assignment140 != null) ? assignment140.ret : null));

                    			    }
                    			    break;
                    			case 2 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:305:55: functioncall
                    			    {
                    			    	PushFollow(FOLLOW_functioncall_in_functiondefination1805);
                    			    	functioncall141 = functioncall();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, functioncall141.Tree);
                    			    	retval.ret.setBody(((functioncall141 != null) ? functioncall141.ret : null));

                    			    }
                    			    break;
                    			case 3 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:305:109: scalarvardec
                    			    {
                    			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1809);
                    			    	scalarvardec142 = scalarvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, scalarvardec142.Tree);
                    			    	 retval.ret.setBody(((scalarvardec142 != null) ? scalarvardec142.ret : null));

                    			    }
                    			    break;
                    			case 4 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:306:5: vectorvardec
                    			    {
                    			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1817);
                    			    	vectorvardec143 = vectorvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, vectorvardec143.Tree);
                    			    	 retval.ret.setBody(((vectorvardec143 != null) ? vectorvardec143.ret : null));

                    			    }
                    			    break;
                    			case 5 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:307:5: matrixvardec
                    			    {
                    			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1825);
                    			    	matrixvardec144 = matrixvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, matrixvardec144.Tree);
                    			    	 retval.ret.setBody(((matrixvardec144 != null) ? matrixvardec144.ret : null));

                    			    }
                    			    break;
                    			case 6 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:308:5: deletionofvar
                    			    {
                    			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1833);
                    			    	deletionofvar145 = deletionofvar();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, deletionofvar145.Tree);
                    			    	 retval.ret.setBody(((deletionofvar145 != null) ? deletionofvar145.ret : null));

                    			    }
                    			    break;
                    			case 7 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:308:64: print
                    			    {
                    			    	PushFollow(FOLLOW_print_in_functiondefination1839);
                    			    	print146 = print();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, print146.Tree);
                    			    	 retval.ret.setBody(((print146 != null) ? print146.ret : null)); 

                    			    }
                    			    break;
                    			case 8 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:309:5: ifelse
                    			    {
                    			    	PushFollow(FOLLOW_ifelse_in_functiondefination1847);
                    			    	ifelse147 = ifelse();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, ifelse147.Tree);
                    			    	retval.ret.setBody(((ifelse147 != null) ? ifelse147.ret : null));

                    			    }
                    			    break;
                    			case 9 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:309:47: functionreturn
                    			    {
                    			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1851);
                    			    	functionreturn148 = functionreturn();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, functionreturn148.Tree);
                    			    	retval.ret.setBody(((functionreturn148 != null) ? functionreturn148.ret : null));

                    			    }
                    			    break;
                    			case 10 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:309:105: parallelfor
                    			    {
                    			    	PushFollow(FOLLOW_parallelfor_in_functiondefination1855);
                    			    	parallelfor149 = parallelfor();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, parallelfor149.Tree);
                    			    	retval.ret.setBody(((parallelfor149 != null) ? parallelfor149.ret : null));

                    			    }
                    			    break;
                    			case 11 :
                    			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:309:157: forstatement
                    			    {
                    			    	PushFollow(FOLLOW_forstatement_in_functiondefination1859);
                    			    	forstatement150 = forstatement();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, forstatement150.Tree);
                    			    	retval.ret.setBody(((forstatement150 != null) ? forstatement150.ret : null));

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

                    	char_literal151=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1864); 
                    		char_literal151_tree = (object)adaptor.Create(char_literal151);
                    		adaptor.AddChild(root_0, char_literal151_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:312:1: lessthan returns [LessThanElement ret] : e11= variable LESSTHANEXPRESSION e12= var_int_or_double_literal ;
    public spinachParser.lessthan_return lessthan() // throws RecognitionException [1]
    {   
        spinachParser.lessthan_return retval = new spinachParser.lessthan_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSTHANEXPRESSION152 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return e12 = null;


        object LESSTHANEXPRESSION152_tree=null;


        	retval.ret = new LessThanElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:316:1: (e11= variable LESSTHANEXPRESSION e12= var_int_or_double_literal )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:316:3: e11= variable LESSTHANEXPRESSION e12= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_lessthan1884);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLessThanLhs(((e11 != null) ? e11.ret : null));
            	LESSTHANEXPRESSION152=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_lessthan1887); 
            		LESSTHANEXPRESSION152_tree = (object)adaptor.Create(LESSTHANEXPRESSION152);
            		adaptor.AddChild(root_0, LESSTHANEXPRESSION152_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_lessthan1892);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:319:1: greaterthan returns [GreaterThanElement ret] : e11= variable GREATERTHANEXPRESSION e12= var_int_or_double_literal ;
    public spinachParser.greaterthan_return greaterthan() // throws RecognitionException [1]
    {   
        spinachParser.greaterthan_return retval = new spinachParser.greaterthan_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken GREATERTHANEXPRESSION153 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return e12 = null;


        object GREATERTHANEXPRESSION153_tree=null;


        	retval.ret = new GreaterThanElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:323:1: (e11= variable GREATERTHANEXPRESSION e12= var_int_or_double_literal )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:323:3: e11= variable GREATERTHANEXPRESSION e12= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_greaterthan1914);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setGreaterThanLhs(((e11 != null) ? e11.ret : null));
            	GREATERTHANEXPRESSION153=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_greaterthan1917); 
            		GREATERTHANEXPRESSION153_tree = (object)adaptor.Create(GREATERTHANEXPRESSION153);
            		adaptor.AddChild(root_0, GREATERTHANEXPRESSION153_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_greaterthan1922);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:326:1: lessthanequalto returns [LessThanEqualToElement ret] : e11= variable LESSTHANEQUALTOEXPRESSION e12= var_int_or_double_literal ;
    public spinachParser.lessthanequalto_return lessthanequalto() // throws RecognitionException [1]
    {   
        spinachParser.lessthanequalto_return retval = new spinachParser.lessthanequalto_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LESSTHANEQUALTOEXPRESSION154 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return e12 = null;


        object LESSTHANEQUALTOEXPRESSION154_tree=null;


        	retval.ret = new LessThanEqualToElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:330:1: (e11= variable LESSTHANEQUALTOEXPRESSION e12= var_int_or_double_literal )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:330:3: e11= variable LESSTHANEQUALTOEXPRESSION e12= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_lessthanequalto1944);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLessThanEqualToLhs(((e11 != null) ? e11.ret : null));
            	LESSTHANEQUALTOEXPRESSION154=(IToken)Match(input,LESSTHANEQUALTOEXPRESSION,FOLLOW_LESSTHANEQUALTOEXPRESSION_in_lessthanequalto1947); 
            		LESSTHANEQUALTOEXPRESSION154_tree = (object)adaptor.Create(LESSTHANEQUALTOEXPRESSION154);
            		adaptor.AddChild(root_0, LESSTHANEQUALTOEXPRESSION154_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_lessthanequalto1953);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:333:1: greaterthanequalto returns [GreaterThanEqualToElement ret] : e11= variable GREATERTHANEQUALTOEXPRESSION e12= var_int_or_double_literal ;
    public spinachParser.greaterthanequalto_return greaterthanequalto() // throws RecognitionException [1]
    {   
        spinachParser.greaterthanequalto_return retval = new spinachParser.greaterthanequalto_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken GREATERTHANEQUALTOEXPRESSION155 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.var_int_or_double_literal_return e12 = null;


        object GREATERTHANEQUALTOEXPRESSION155_tree=null;


        	retval.ret = new GreaterThanEqualToElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:337:1: (e11= variable GREATERTHANEQUALTOEXPRESSION e12= var_int_or_double_literal )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:337:3: e11= variable GREATERTHANEQUALTOEXPRESSION e12= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_greaterthanequalto1975);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setGreaterThanEqualToLhs(((e11 != null) ? e11.ret : null));
            	GREATERTHANEQUALTOEXPRESSION155=(IToken)Match(input,GREATERTHANEQUALTOEXPRESSION,FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_greaterthanequalto1978); 
            		GREATERTHANEQUALTOEXPRESSION155_tree = (object)adaptor.Create(GREATERTHANEQUALTOEXPRESSION155);
            		adaptor.AddChild(root_0, GREATERTHANEQUALTOEXPRESSION155_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_greaterthanequalto1984);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:343:1: dotproduct returns [DotProductElement ret] : e11= variable 'DOT' e12= variable ;
    public spinachParser.dotproduct_return dotproduct() // throws RecognitionException [1]
    {   
        spinachParser.dotproduct_return retval = new spinachParser.dotproduct_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal156 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.variable_return e12 = null;


        object string_literal156_tree=null;


        retval.ret = new DotProductElement ();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:347:1: (e11= variable 'DOT' e12= variable )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:347:3: e11= variable 'DOT' e12= variable
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_dotproduct2009);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.setLhs(((e11 != null) ? e11.ret : null)); 
            	string_literal156=(IToken)Match(input,44,FOLLOW_44_in_dotproduct2013); 
            		string_literal156_tree = (object)adaptor.Create(string_literal156);
            		adaptor.AddChild(root_0, string_literal156_tree);

            	PushFollow(FOLLOW_variable_in_dotproduct2019);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:349:1: matrixtranspose returns [MatrixTranspose ret] : 'T' LEFTBRACE variable ')' ;
    public spinachParser.matrixtranspose_return matrixtranspose() // throws RecognitionException [1]
    {   
        spinachParser.matrixtranspose_return retval = new spinachParser.matrixtranspose_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal157 = null;
        IToken LEFTBRACE158 = null;
        IToken char_literal160 = null;
        spinachParser.variable_return variable159 = null;


        object char_literal157_tree=null;
        object LEFTBRACE158_tree=null;
        object char_literal160_tree=null;


        retval.ret = new MatrixTranspose();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:354:1: ( 'T' LEFTBRACE variable ')' )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:354:3: 'T' LEFTBRACE variable ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal157=(IToken)Match(input,45,FOLLOW_45_in_matrixtranspose2038); 
            		char_literal157_tree = (object)adaptor.Create(char_literal157);
            		adaptor.AddChild(root_0, char_literal157_tree);

            	LEFTBRACE158=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_matrixtranspose2040); 
            		LEFTBRACE158_tree = (object)adaptor.Create(LEFTBRACE158);
            		adaptor.AddChild(root_0, LEFTBRACE158_tree);

            	PushFollow(FOLLOW_variable_in_matrixtranspose2042);
            	variable159 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable159.Tree);
            	retval.ret.setvariable(((variable159 != null) ? variable159.ret : null)); 
            	char_literal160=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_matrixtranspose2045); 
            		char_literal160_tree = (object)adaptor.Create(char_literal160);
            		adaptor.AddChild(root_0, char_literal160_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:357:1: matrixreference returns [MatrixReference ret] : 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.matrixreference_return matrixreference() // throws RecognitionException [1]
    {   
        spinachParser.matrixreference_return retval = new spinachParser.matrixreference_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken el1 = null;
        IToken string_literal161 = null;
        IToken char_literal162 = null;
        IToken char_literal163 = null;
        spinachParser.variable_return el2 = null;


        object el1_tree=null;
        object string_literal161_tree=null;
        object char_literal162_tree=null;
        object char_literal163_tree=null;

         retval.ret = new MatrixReference();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:360:1: ( 'Matrix' '<' (el1= VARTYPE '>' el2= variable ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:360:2: 'Matrix' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal161=(IToken)Match(input,28,FOLLOW_28_in_matrixreference2061); 
            		string_literal161_tree = (object)adaptor.Create(string_literal161);
            		adaptor.AddChild(root_0, string_literal161_tree);

            	char_literal162=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_matrixreference2063); 
            		char_literal162_tree = (object)adaptor.Create(char_literal162);
            		adaptor.AddChild(root_0, char_literal162_tree);

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:360:15: (el1= VARTYPE '>' el2= variable )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:360:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixreference2068); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal163=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_matrixreference2070); 
            			char_literal163_tree = (object)adaptor.Create(char_literal163);
            			adaptor.AddChild(root_0, char_literal163_tree);

            		PushFollow(FOLLOW_variable_in_matrixreference2074);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:363:1: vectorreference returns [VectorReference ret] : 'Vector' '<' (el1= VARTYPE '>' el2= variable ) ;
    public spinachParser.vectorreference_return vectorreference() // throws RecognitionException [1]
    {   
        spinachParser.vectorreference_return retval = new spinachParser.vectorreference_return();
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

         retval.ret = new VectorReference();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:366:1: ( 'Vector' '<' (el1= VARTYPE '>' el2= variable ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:366:2: 'Vector' '<' (el1= VARTYPE '>' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal164=(IToken)Match(input,32,FOLLOW_32_in_vectorreference2093); 
            		string_literal164_tree = (object)adaptor.Create(string_literal164);
            		adaptor.AddChild(root_0, string_literal164_tree);

            	char_literal165=(IToken)Match(input,LESSTHANEXPRESSION,FOLLOW_LESSTHANEXPRESSION_in_vectorreference2095); 
            		char_literal165_tree = (object)adaptor.Create(char_literal165);
            		adaptor.AddChild(root_0, char_literal165_tree);

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:366:15: (el1= VARTYPE '>' el2= variable )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:366:16: el1= VARTYPE '>' el2= variable
            	{
            		el1=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorreference2100); 
            			el1_tree = (object)adaptor.Create(el1);
            			adaptor.AddChild(root_0, el1_tree);

            		retval.ret.settype(((el1 != null) ? el1.Text : null));
            		char_literal166=(IToken)Match(input,GREATERTHANEXPRESSION,FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2102); 
            			char_literal166_tree = (object)adaptor.Create(char_literal166);
            			adaptor.AddChild(root_0, char_literal166_tree);

            		PushFollow(FOLLOW_variable_in_vectorreference2106);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:368:1: arguments returns [Element ret] : ( scalarargument | matrixreference | vectorreference ) ;
    public spinachParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        spinachParser.arguments_return retval = new spinachParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.scalarargument_return scalarargument167 = null;

        spinachParser.matrixreference_return matrixreference168 = null;

        spinachParser.vectorreference_return vectorreference169 = null;



        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:369:1: ( ( scalarargument | matrixreference | vectorreference ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:369:3: ( scalarargument | matrixreference | vectorreference )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:369:3: ( scalarargument | matrixreference | vectorreference )
            	int alt40 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARTYPE:
            		{
            	    alt40 = 1;
            	    }
            	    break;
            	case 28:
            		{
            	    alt40 = 2;
            	    }
            	    break;
            	case 32:
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
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:369:4: scalarargument
            	        {
            	        	PushFollow(FOLLOW_scalarargument_in_arguments2122);
            	        	scalarargument167 = scalarargument();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, scalarargument167.Tree);
            	        	 retval.ret = ((scalarargument167 != null) ? scalarargument167.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:370:3: matrixreference
            	        {
            	        	PushFollow(FOLLOW_matrixreference_in_arguments2128);
            	        	matrixreference168 = matrixreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, matrixreference168.Tree);
            	        	retval.ret = ((matrixreference168 != null) ? matrixreference168.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:371:3: vectorreference
            	        {
            	        	PushFollow(FOLLOW_vectorreference_in_arguments2134);
            	        	vectorreference169 = vectorreference();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, vectorreference169.Tree);
            	        	retval.ret = ((vectorreference169 != null) ? vectorreference169.ret : null);

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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:382:1: scalarargument returns [ScalarArgument ret] : ( (e11= VARTYPE ) e12= variable ) ;
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
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:384:2: ( ( (e11= VARTYPE ) e12= variable ) )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:385:1: ( (e11= VARTYPE ) e12= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:385:1: ( (e11= VARTYPE ) e12= variable )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:385:2: (e11= VARTYPE ) e12= variable
            	{
            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:385:2: (e11= VARTYPE )
            		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:385:3: e11= VARTYPE
            		{
            			e11=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarargument2166); 
            				e11_tree = (object)adaptor.Create(e11);
            				adaptor.AddChild(root_0, e11_tree);

            			retval.ret.settype(((e11 != null) ? e11.Text : null));

            		}

            		PushFollow(FOLLOW_variable_in_scalarargument2173);
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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:389:1: comment returns [CommentElement ret] : '//' ( var_int_or_double_literal )* ;
    public spinachParser.comment_return comment() // throws RecognitionException [1]
    {   
        spinachParser.comment_return retval = new spinachParser.comment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal170 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal171 = null;


        object string_literal170_tree=null;


        retval.ret = new CommentElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:393:1: ( '//' ( var_int_or_double_literal )* )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:393:2: '//' ( var_int_or_double_literal )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal170=(IToken)Match(input,46,FOLLOW_46_in_comment2192); 
            		string_literal170_tree = (object)adaptor.Create(string_literal170);
            		adaptor.AddChild(root_0, string_literal170_tree);

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:393:6: ( var_int_or_double_literal )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == VARIABLE) )
            	    {
            	        int LA41_2 = input.LA(2);

            	        if ( (LA41_2 == VARIABLE) )
            	        {
            	            int LA41_4 = input.LA(3);

            	            if ( (LA41_4 == EOF || (LA41_4 >= VARIABLE && LA41_4 <= ASSIGNMENT) || LA41_4 == STRINGTYPE || (LA41_4 >= RIGHTPARANTHESIS && LA41_4 <= LEFTBRACE) || LA41_4 == DOT || (LA41_4 >= 28 && LA41_4 <= 29) || LA41_4 == 32 || (LA41_4 >= 34 && LA41_4 <= 38) || LA41_4 == 40 || (LA41_4 >= 42 && LA41_4 <= 43) || (LA41_4 >= 46 && LA41_4 <= 48) || (LA41_4 >= 52 && LA41_4 <= 56)) )
            	            {
            	                alt41 = 1;
            	            }


            	        }
            	        else if ( (LA41_2 == EOF || (LA41_2 >= INT_LITERAL && LA41_2 <= VARTYPE) || LA41_2 == STRINGTYPE || LA41_2 == RIGHTPARANTHESIS || LA41_2 == 28 || LA41_2 == 32 || (LA41_2 >= 34 && LA41_2 <= 38) || LA41_2 == 40 || (LA41_2 >= 42 && LA41_2 <= 43) || (LA41_2 >= 46 && LA41_2 <= 48) || (LA41_2 >= 52 && LA41_2 <= 56)) )
            	        {
            	            alt41 = 1;
            	        }


            	    }
            	    else if ( ((LA41_0 >= INT_LITERAL && LA41_0 <= DOUBLE_LITERAL)) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:393:6: var_int_or_double_literal
            			    {
            			    	PushFollow(FOLLOW_var_int_or_double_literal_in_comment2193);
            			    	var_int_or_double_literal171 = var_int_or_double_literal();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, var_int_or_double_literal171.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:397:1: functionreturn returns [ReturnElement ret] : 'return' ( var_int_or_double_literal ) END_OF_STATEMENT ;
    public spinachParser.functionreturn_return functionreturn() // throws RecognitionException [1]
    {   
        spinachParser.functionreturn_return retval = new spinachParser.functionreturn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal172 = null;
        IToken END_OF_STATEMENT174 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal173 = null;


        object string_literal172_tree=null;
        object END_OF_STATEMENT174_tree=null;


        retval.ret = new ReturnElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:401:1: ( 'return' ( var_int_or_double_literal ) END_OF_STATEMENT )
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:401:2: 'return' ( var_int_or_double_literal ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal172=(IToken)Match(input,47,FOLLOW_47_in_functionreturn2211); 
            		string_literal172_tree = (object)adaptor.Create(string_literal172);
            		adaptor.AddChild(root_0, string_literal172_tree);

            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:401:11: ( var_int_or_double_literal )
            	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:401:12: var_int_or_double_literal
            	{
            		PushFollow(FOLLOW_var_int_or_double_literal_in_functionreturn2214);
            		var_int_or_double_literal173 = var_int_or_double_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, var_int_or_double_literal173.Tree);
            		retval.ret.setreturnvariable(((var_int_or_double_literal173 != null) ? var_int_or_double_literal173.ret : null));

            	}

            	END_OF_STATEMENT174=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functionreturn2218); 
            		END_OF_STATEMENT174_tree = (object)adaptor.Create(END_OF_STATEMENT174);
            		adaptor.AddChild(root_0, END_OF_STATEMENT174_tree);


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
    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:407:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );
    public spinachParser.plotfunctions_return plotfunctions() // throws RecognitionException [1]
    {   
        spinachParser.plotfunctions_return retval = new spinachParser.plotfunctions_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal175 = null;
        IToken char_literal176 = null;
        IToken char_literal177 = null;
        IToken char_literal178 = null;
        IToken char_literal179 = null;
        IToken char_literal180 = null;
        IToken string_literal181 = null;
        IToken string_literal182 = null;
        IToken string_literal183 = null;
        IToken char_literal184 = null;
        IToken char_literal185 = null;
        IToken END_OF_STATEMENT186 = null;
        IToken string_literal187 = null;
        IToken char_literal188 = null;
        IToken char_literal189 = null;
        IToken char_literal190 = null;
        IToken string_literal191 = null;
        IToken string_literal192 = null;
        IToken string_literal193 = null;
        IToken char_literal194 = null;
        IToken char_literal195 = null;
        IToken END_OF_STATEMENT196 = null;
        IToken string_literal197 = null;
        IToken char_literal198 = null;
        IToken char_literal199 = null;
        IToken END_OF_STATEMENT200 = null;
        IToken string_literal201 = null;
        IToken char_literal202 = null;
        IToken char_literal203 = null;
        IToken char_literal204 = null;
        IToken char_literal205 = null;
        IToken END_OF_STATEMENT206 = null;
        IToken string_literal207 = null;
        IToken char_literal208 = null;
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
        IToken SCALEMODE233 = null;
        IToken char_literal234 = null;
        IToken END_OF_STATEMENT235 = null;
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


        object string_literal175_tree=null;
        object char_literal176_tree=null;
        object char_literal177_tree=null;
        object char_literal178_tree=null;
        object char_literal179_tree=null;
        object char_literal180_tree=null;
        object string_literal181_tree=null;
        object string_literal182_tree=null;
        object string_literal183_tree=null;
        object char_literal184_tree=null;
        object char_literal185_tree=null;
        object END_OF_STATEMENT186_tree=null;
        object string_literal187_tree=null;
        object char_literal188_tree=null;
        object char_literal189_tree=null;
        object char_literal190_tree=null;
        object string_literal191_tree=null;
        object string_literal192_tree=null;
        object string_literal193_tree=null;
        object char_literal194_tree=null;
        object char_literal195_tree=null;
        object END_OF_STATEMENT196_tree=null;
        object string_literal197_tree=null;
        object char_literal198_tree=null;
        object char_literal199_tree=null;
        object END_OF_STATEMENT200_tree=null;
        object string_literal201_tree=null;
        object char_literal202_tree=null;
        object char_literal203_tree=null;
        object char_literal204_tree=null;
        object char_literal205_tree=null;
        object END_OF_STATEMENT206_tree=null;
        object string_literal207_tree=null;
        object char_literal208_tree=null;
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
        object SCALEMODE233_tree=null;
        object char_literal234_tree=null;
        object END_OF_STATEMENT235_tree=null;

         retval.ret = new PlotFunctionElement();

        try 
    	{
            // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:410:1: ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) )
            int alt46 = 10;
            alt46 = dfa46.Predict(input);
            switch (alt46) 
            {
                case 1 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:410:3: ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:410:3: ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:410:4: 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal175=(IToken)Match(input,48,FOLLOW_48_in_plotfunctions2242); 
                    			string_literal175_tree = (object)adaptor.Create(string_literal175);
                    			adaptor.AddChild(root_0, string_literal175_tree);

                    		retval.ret.setPlotFunction("subPlot");
                    		char_literal176=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2245); 
                    			char_literal176_tree = (object)adaptor.Create(char_literal176);
                    			adaptor.AddChild(root_0, char_literal176_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:411:1: (el1= int_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:411:2: el1= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2252);
                    			el1 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el1.Tree);
                    			retval.ret.setRow(((el1 != null) ? el1.ret : null));

                    		}

                    		char_literal177=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2257); 
                    			char_literal177_tree = (object)adaptor.Create(char_literal177);
                    			adaptor.AddChild(root_0, char_literal177_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:412:1: (el2= int_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:412:2: el2= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions2264);
                    			el2 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el2.Tree);
                    			retval.ret.setColumn(((el2 != null) ? el2.ret : null));

                    		}

                    		char_literal178=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2269); 
                    			char_literal178_tree = (object)adaptor.Create(char_literal178);
                    			adaptor.AddChild(root_0, char_literal178_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:413:1: (vll1= variable )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:413:2: vll1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2276);
                    			vll1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll1.Tree);
                    			retval.ret.setData(((vll1 != null) ? vll1.ret : null));

                    		}

                    		char_literal179=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2281); 
                    			char_literal179_tree = (object)adaptor.Create(char_literal179);
                    			adaptor.AddChild(root_0, char_literal179_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:414:1: (vll2= string_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:414:2: vll2= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2288);
                    			vll2 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll2.Tree);
                    			retval.ret.setTitle(((vll2 != null) ? vll2.ret : null));

                    		}

                    		char_literal180=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2292); 
                    			char_literal180_tree = (object)adaptor.Create(char_literal180);
                    			adaptor.AddChild(root_0, char_literal180_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt43 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt43 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt43 = 2;
                    		    }
                    		    break;
                    		case 51:
                    			{
                    		    alt43 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d43s0 =
                    			        new NoViableAltException("", 43, 0, input);

                    			    throw nvae_d43s0;
                    		}

                    		switch (alt43) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:2: ( '1D' )
                    		        {
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:2: ( '1D' )
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:3: '1D'
                    		        	{
                    		        		string_literal181=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2296); 
                    		        			string_literal181_tree = (object)adaptor.Create(string_literal181);
                    		        			adaptor.AddChild(root_0, string_literal181_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:40: ( '2D' )
                    		        {
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:40: ( '2D' )
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:41: '2D'
                    		        	{
                    		        		string_literal182=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2301); 
                    		        			string_literal182_tree = (object)adaptor.Create(string_literal182);
                    		        			adaptor.AddChild(root_0, string_literal182_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal183=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2306); 
                    		        			string_literal183_tree = (object)adaptor.Create(string_literal183);
                    		        			adaptor.AddChild(root_0, string_literal183_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:114: ( ',' (el3= int_literal ) )?
                    		        		int alt42 = 2;
                    		        		int LA42_0 = input.LA(1);

                    		        		if ( (LA42_0 == 31) )
                    		        		{
                    		        		    alt42 = 1;
                    		        		}
                    		        		switch (alt42) 
                    		        		{
                    		        		    case 1 :
                    		        		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal184=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2309); 
                    		        		        		char_literal184_tree = (object)adaptor.Create(char_literal184);
                    		        		        		adaptor.AddChild(root_0, char_literal184_tree);

                    		        		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:118: (el3= int_literal )
                    		        		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:415:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2315);
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

                    		char_literal185=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2323); 
                    			char_literal185_tree = (object)adaptor.Create(char_literal185);
                    			adaptor.AddChild(root_0, char_literal185_tree);

                    		END_OF_STATEMENT186=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2324); 
                    			END_OF_STATEMENT186_tree = (object)adaptor.Create(END_OF_STATEMENT186);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT186_tree);


                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:417:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:417:3: ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:417:4: 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal187=(IToken)Match(input,52,FOLLOW_52_in_plotfunctions2330); 
                    			string_literal187_tree = (object)adaptor.Create(string_literal187);
                    			adaptor.AddChild(root_0, string_literal187_tree);

                    		retval.ret.setPlotFunction("plot");
                    		char_literal188=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2333); 
                    			char_literal188_tree = (object)adaptor.Create(char_literal188);
                    			adaptor.AddChild(root_0, char_literal188_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:418:1: (vll3= variable )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:418:2: vll3= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions2339);
                    			vll3 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll3.Tree);
                    			retval.ret.setData(((vll3 != null) ? vll3.ret : null));

                    		}

                    		char_literal189=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2344); 
                    			char_literal189_tree = (object)adaptor.Create(char_literal189);
                    			adaptor.AddChild(root_0, char_literal189_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:419:1: (vll4= string_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:419:2: vll4= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2350);
                    			vll4 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vll4.Tree);
                    			retval.ret.setTitle(((vll4 != null) ? vll4.ret : null));

                    		}

                    		char_literal190=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2354); 
                    			char_literal190_tree = (object)adaptor.Create(char_literal190);
                    			adaptor.AddChild(root_0, char_literal190_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:1: ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) )
                    		int alt45 = 3;
                    		switch ( input.LA(1) ) 
                    		{
                    		case 49:
                    			{
                    		    alt45 = 1;
                    		    }
                    		    break;
                    		case 50:
                    			{
                    		    alt45 = 2;
                    		    }
                    		    break;
                    		case 51:
                    			{
                    		    alt45 = 3;
                    		    }
                    		    break;
                    			default:
                    			    NoViableAltException nvae_d45s0 =
                    			        new NoViableAltException("", 45, 0, input);

                    			    throw nvae_d45s0;
                    		}

                    		switch (alt45) 
                    		{
                    		    case 1 :
                    		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:2: ( '1D' )
                    		        {
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:2: ( '1D' )
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:3: '1D'
                    		        	{
                    		        		string_literal191=(IToken)Match(input,49,FOLLOW_49_in_plotfunctions2358); 
                    		        			string_literal191_tree = (object)adaptor.Create(string_literal191);
                    		        			adaptor.AddChild(root_0, string_literal191_tree);

                    		        		retval.ret.setPlotType("1D");

                    		        	}


                    		        }
                    		        break;
                    		    case 2 :
                    		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:40: ( '2D' )
                    		        {
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:40: ( '2D' )
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:41: '2D'
                    		        	{
                    		        		string_literal192=(IToken)Match(input,50,FOLLOW_50_in_plotfunctions2363); 
                    		        			string_literal192_tree = (object)adaptor.Create(string_literal192);
                    		        			adaptor.AddChild(root_0, string_literal192_tree);

                    		        		retval.ret.setPlotType("2D");

                    		        	}


                    		        }
                    		        break;
                    		    case 3 :
                    		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        {
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:78: ( '3D' ( ',' (el3= int_literal ) )? )
                    		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:79: '3D' ( ',' (el3= int_literal ) )?
                    		        	{
                    		        		string_literal193=(IToken)Match(input,51,FOLLOW_51_in_plotfunctions2368); 
                    		        			string_literal193_tree = (object)adaptor.Create(string_literal193);
                    		        			adaptor.AddChild(root_0, string_literal193_tree);

                    		        		retval.ret.setPlotType("3D");
                    		        		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:114: ( ',' (el3= int_literal ) )?
                    		        		int alt44 = 2;
                    		        		int LA44_0 = input.LA(1);

                    		        		if ( (LA44_0 == 31) )
                    		        		{
                    		        		    alt44 = 1;
                    		        		}
                    		        		switch (alt44) 
                    		        		{
                    		        		    case 1 :
                    		        		        // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:115: ',' (el3= int_literal )
                    		        		        {
                    		        		        	char_literal194=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2371); 
                    		        		        		char_literal194_tree = (object)adaptor.Create(char_literal194);
                    		        		        		adaptor.AddChild(root_0, char_literal194_tree);

                    		        		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:118: (el3= int_literal )
                    		        		        	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:420:119: el3= int_literal
                    		        		        	{
                    		        		        		PushFollow(FOLLOW_int_literal_in_plotfunctions2377);
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

                    		char_literal195=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2385); 
                    			char_literal195_tree = (object)adaptor.Create(char_literal195);
                    			adaptor.AddChild(root_0, char_literal195_tree);

                    		END_OF_STATEMENT196=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2386); 
                    			END_OF_STATEMENT196_tree = (object)adaptor.Create(END_OF_STATEMENT196);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT196_tree);


                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:422:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:422:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:422:4: 'resetPlot' '(' ')' END_OF_STATEMENT
                    	{
                    		string_literal197=(IToken)Match(input,53,FOLLOW_53_in_plotfunctions2392); 
                    			string_literal197_tree = (object)adaptor.Create(string_literal197);
                    			adaptor.AddChild(root_0, string_literal197_tree);

                    		char_literal198=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2393); 
                    			char_literal198_tree = (object)adaptor.Create(char_literal198);
                    			adaptor.AddChild(root_0, char_literal198_tree);

                    		char_literal199=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2394); 
                    			char_literal199_tree = (object)adaptor.Create(char_literal199);
                    			adaptor.AddChild(root_0, char_literal199_tree);

                    		retval.ret.setPlotFunction("resetPlot");
                    		END_OF_STATEMENT200=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2396); 
                    			END_OF_STATEMENT200_tree = (object)adaptor.Create(END_OF_STATEMENT200);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT200_tree);


                    	}


                    }
                    break;
                case 4 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:423:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:423:3: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:423:4: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal201=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2402); 
                    			string_literal201_tree = (object)adaptor.Create(string_literal201);
                    			adaptor.AddChild(root_0, string_literal201_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal202=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2404); 
                    			char_literal202_tree = (object)adaptor.Create(char_literal202);
                    			adaptor.AddChild(root_0, char_literal202_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:424:1: (ell2= double_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:424:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2410);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal203=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2413); 
                    			char_literal203_tree = (object)adaptor.Create(char_literal203);
                    			adaptor.AddChild(root_0, char_literal203_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:425:1: ( (ell3= double_literal ) ',' )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:425:2: (ell3= double_literal ) ','
                    		{
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:425:2: (ell3= double_literal )
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:425:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2419);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}

                    			char_literal204=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2422); 
                    				char_literal204_tree = (object)adaptor.Create(char_literal204);
                    				adaptor.AddChild(root_0, char_literal204_tree);


                    		}

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:426:1: ( (el4= double_literal ) )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:426:2: (el4= double_literal )
                    		{
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:426:2: (el4= double_literal )
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:426:3: el4= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2429);
                    				el4 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, el4.Tree);
                    				retval.ret.setZFact(((el4 != null) ? el4.ret : null));

                    			}


                    		}

                    		char_literal205=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2434); 
                    			char_literal205_tree = (object)adaptor.Create(char_literal205);
                    			adaptor.AddChild(root_0, char_literal205_tree);

                    		END_OF_STATEMENT206=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2435); 
                    			END_OF_STATEMENT206_tree = (object)adaptor.Create(END_OF_STATEMENT206);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT206_tree);


                    	}


                    }
                    break;
                case 5 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:428:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:428:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:428:3: 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal207=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2440); 
                    			string_literal207_tree = (object)adaptor.Create(string_literal207);
                    			adaptor.AddChild(root_0, string_literal207_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal208=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2442); 
                    			char_literal208_tree = (object)adaptor.Create(char_literal208);
                    			adaptor.AddChild(root_0, char_literal208_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:429:1: (ell2= double_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:429:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2448);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal209=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2451); 
                    			char_literal209_tree = (object)adaptor.Create(char_literal209);
                    			adaptor.AddChild(root_0, char_literal209_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:430:1: ( (ell3= double_literal ) )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:430:2: (ell3= double_literal )
                    		{
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:430:2: (ell3= double_literal )
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:430:3: ell3= double_literal
                    			{
                    				PushFollow(FOLLOW_double_literal_in_plotfunctions2457);
                    				ell3 = double_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}


                    		}

                    		char_literal210=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2462); 
                    			char_literal210_tree = (object)adaptor.Create(char_literal210);
                    			adaptor.AddChild(root_0, char_literal210_tree);

                    		END_OF_STATEMENT211=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2463); 
                    			END_OF_STATEMENT211_tree = (object)adaptor.Create(END_OF_STATEMENT211);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT211_tree);


                    	}


                    }
                    break;
                case 6 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:432:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:432:2: ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:432:3: 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal212=(IToken)Match(input,54,FOLLOW_54_in_plotfunctions2468); 
                    			string_literal212_tree = (object)adaptor.Create(string_literal212);
                    			adaptor.AddChild(root_0, string_literal212_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal213=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2470); 
                    			char_literal213_tree = (object)adaptor.Create(char_literal213);
                    			adaptor.AddChild(root_0, char_literal213_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:433:1: (ell2= double_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:433:2: ell2= double_literal
                    		{
                    			PushFollow(FOLLOW_double_literal_in_plotfunctions2476);
                    			ell2 = double_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal214=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2480); 
                    			char_literal214_tree = (object)adaptor.Create(char_literal214);
                    			adaptor.AddChild(root_0, char_literal214_tree);

                    		END_OF_STATEMENT215=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2481); 
                    			END_OF_STATEMENT215_tree = (object)adaptor.Create(END_OF_STATEMENT215);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT215_tree);


                    	}


                    }
                    break;
                case 7 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:435:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:435:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:435:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal216=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2487); 
                    			string_literal216_tree = (object)adaptor.Create(string_literal216);
                    			adaptor.AddChild(root_0, string_literal216_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal217=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2489); 
                    			char_literal217_tree = (object)adaptor.Create(char_literal217);
                    			adaptor.AddChild(root_0, char_literal217_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:436:1: (vl1= string_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:436:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2495);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal218=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2498); 
                    			char_literal218_tree = (object)adaptor.Create(char_literal218);
                    			adaptor.AddChild(root_0, char_literal218_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:437:1: ( (vl2= string_literal ) ',' )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:437:2: (vl2= string_literal ) ','
                    		{
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:437:2: (vl2= string_literal )
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:437:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2505);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}

                    			char_literal219=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2508); 
                    				char_literal219_tree = (object)adaptor.Create(char_literal219);
                    				adaptor.AddChild(root_0, char_literal219_tree);


                    		}

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:438:1: ( (vl3= string_literal ) )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:438:2: (vl3= string_literal )
                    		{
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:438:2: (vl3= string_literal )
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:438:3: vl3= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2516);
                    				vl3 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl3.Tree);
                    				retval.ret.setZTitle(((vl3 != null) ? vl3.ret : null));

                    			}


                    		}

                    		char_literal220=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2521); 
                    			char_literal220_tree = (object)adaptor.Create(char_literal220);
                    			adaptor.AddChild(root_0, char_literal220_tree);

                    		END_OF_STATEMENT221=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2522); 
                    			END_OF_STATEMENT221_tree = (object)adaptor.Create(END_OF_STATEMENT221);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT221_tree);


                    	}


                    }
                    break;
                case 8 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:440:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:440:3: ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:440:4: 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal222=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2528); 
                    			string_literal222_tree = (object)adaptor.Create(string_literal222);
                    			adaptor.AddChild(root_0, string_literal222_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal223=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2530); 
                    			char_literal223_tree = (object)adaptor.Create(char_literal223);
                    			adaptor.AddChild(root_0, char_literal223_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:441:1: (vl1= string_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:441:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2536);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal224=(IToken)Match(input,31,FOLLOW_31_in_plotfunctions2539); 
                    			char_literal224_tree = (object)adaptor.Create(char_literal224);
                    			adaptor.AddChild(root_0, char_literal224_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:442:1: ( (vl2= string_literal ) )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:442:2: (vl2= string_literal )
                    		{
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:442:2: (vl2= string_literal )
                    			// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:442:3: vl2= string_literal
                    			{
                    				PushFollow(FOLLOW_string_literal_in_plotfunctions2546);
                    				vl2 = string_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}


                    		}

                    		char_literal225=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2551); 
                    			char_literal225_tree = (object)adaptor.Create(char_literal225);
                    			adaptor.AddChild(root_0, char_literal225_tree);

                    		END_OF_STATEMENT226=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2552); 
                    			END_OF_STATEMENT226_tree = (object)adaptor.Create(END_OF_STATEMENT226);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT226_tree);


                    	}


                    }
                    break;
                case 9 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:444:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:444:2: ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:444:3: 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal227=(IToken)Match(input,55,FOLLOW_55_in_plotfunctions2557); 
                    			string_literal227_tree = (object)adaptor.Create(string_literal227);
                    			adaptor.AddChild(root_0, string_literal227_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal228=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2559); 
                    			char_literal228_tree = (object)adaptor.Create(char_literal228);
                    			adaptor.AddChild(root_0, char_literal228_tree);

                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:445:1: (vl1= string_literal )
                    		// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:445:2: vl1= string_literal
                    		{
                    			PushFollow(FOLLOW_string_literal_in_plotfunctions2565);
                    			vl1 = string_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal229=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2569); 
                    			char_literal229_tree = (object)adaptor.Create(char_literal229);
                    			adaptor.AddChild(root_0, char_literal229_tree);

                    		END_OF_STATEMENT230=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2570); 
                    			END_OF_STATEMENT230_tree = (object)adaptor.Create(END_OF_STATEMENT230);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT230_tree);


                    	}


                    }
                    break;
                case 10 :
                    // C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:447:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:447:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    	// C:\\Users\\Jegan\\Documents\\MSCE\\FALL 09\\SoftwareStudio\\SPINACH-Srinivasan\\ConsoleApplication1\\ConsoleApplication1\\spinach.g:447:3: 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT
                    	{
                    		string_literal231=(IToken)Match(input,56,FOLLOW_56_in_plotfunctions2575); 
                    			string_literal231_tree = (object)adaptor.Create(string_literal231);
                    			adaptor.AddChild(root_0, string_literal231_tree);

                    		char_literal232=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions2576); 
                    			char_literal232_tree = (object)adaptor.Create(char_literal232);
                    			adaptor.AddChild(root_0, char_literal232_tree);

                    		retval.ret.setPlotFunction("setScaleMode");
                    		SCALEMODE233=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_plotfunctions2579); 
                    			SCALEMODE233_tree = (object)adaptor.Create(SCALEMODE233);
                    			adaptor.AddChild(root_0, SCALEMODE233_tree);

                    		retval.ret.setScaleMode(SCALEMODE233.Text);
                    		char_literal234=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions2583); 
                    			char_literal234_tree = (object)adaptor.Create(char_literal234);
                    			adaptor.AddChild(root_0, char_literal234_tree);

                    		END_OF_STATEMENT235=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions2585); 
                    			END_OF_STATEMENT235_tree = (object)adaptor.Create(END_OF_STATEMENT235);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT235_tree);


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
   	protected DFA22 dfa22;
   	protected DFA35 dfa35;
   	protected DFA38 dfa38;
   	protected DFA46 dfa46;
	private void InitializeCyclicDFAs()
	{
    	this.dfa3 = new DFA3(this);
    	this.dfa4 = new DFA4(this);
    	this.dfa22 = new DFA22(this);
    	this.dfa35 = new DFA35(this);
    	this.dfa38 = new DFA38(this);
    	this.dfa46 = new DFA46(this);






	}

    const string DFA3_eotS =
        "\x0a\uffff";
    const string DFA3_eofS =
        "\x0a\uffff";
    const string DFA3_minS =
        "\x03\x04\x06\uffff\x01\x09";
    const string DFA3_maxS =
        "\x01\x38\x01\x1d\x01\x04\x06\uffff\x01\x0d";
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
            "\x01\x08\x03\uffff\x01\x03\x04\uffff\x01\x03\x09\uffff\x01"+
            "\x03\x05\uffff\x01\x03",
            "\x01\x09",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x03\x03\uffff\x01\x06"
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
            get { return "31:1: expr1 returns [Element ret] : ( expr2 | matrixvardec | structdec | structobjdec | functiondefination | plotfunctions );"; }
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
        "\x09\x01\x07\x01\x01";
    const string DFA4_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x02\uffff\x01\x02\x02\uffff\x01\x02\x15\uffff\x01"+
            "\x03\x02\uffff\x01\x04\x01\x05\x03\uffff\x01\x06\x01\uffff\x01"+
            "\x07\x03\uffff\x01\x08",
            "\x01\x0a\x04\uffff\x01\x09\x09\uffff\x01\x0a\x05\uffff\x01"+
            "\x0a",
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
            get { return "40:4: (el1= assignment | el2= scalarvardec | el3= vectorvardec | el4= deletionofvar | el5= print | el6= ifelse | el7= functioncall | el8= forstatement | el9= comment )"; }
        }

    }

    const string DFA22_eotS =
        "\x0b\uffff";
    const string DFA22_eofS =
        "\x0b\uffff";
    const string DFA22_minS =
        "\x01\x04\x0a\uffff";
    const string DFA22_maxS =
        "\x01\x2e\x0a\uffff";
    const string DFA22_acceptS =
        "\x01\uffff\x01\x02\x09\x01";
    const string DFA22_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA22_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x04\x01\uffff\x01"+
            "\x01\x13\uffff\x01\x05\x02\uffff\x01\x06\x01\x07\x01\uffff\x01"+
            "\x01\x01\uffff\x01\x08\x01\uffff\x01\x09\x03\uffff\x01\x0a",
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
            get { return "()+ loopback of 220:80: (e11= expr2 )+"; }
        }

    }

    const string DFA35_eotS =
        "\x0e\uffff";
    const string DFA35_eofS =
        "\x0e\uffff";
    const string DFA35_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA35_maxS =
        "\x01\x2f\x01\uffff\x01\x1d\x0b\uffff";
    const string DFA35_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x01\x01\x02";
    const string DFA35_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x01\x0f\uffff\x01\x05\x03\uffff\x01\x04\x02\uffff\x01\x06\x01"+
            "\x07\x01\x0a\x02\uffff\x01\x08\x01\uffff\x01\x0b\x04\uffff\x01"+
            "\x09",
            "",
            "\x01\x0c\x04\uffff\x01\x0d\x09\uffff\x01\x0c\x05\uffff\x01"+
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
            get { return "()+ loopback of 295:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA38_eotS =
        "\x0e\uffff";
    const string DFA38_eofS =
        "\x0e\uffff";
    const string DFA38_minS =
        "\x01\x04\x01\uffff\x01\x08\x0b\uffff";
    const string DFA38_maxS =
        "\x01\x2f\x01\uffff\x01\x1d\x0b\uffff";
    const string DFA38_acceptS =
        "\x01\uffff\x01\x0c\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x02\x01\x01";
    const string DFA38_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA38_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x01\x0f\uffff\x01\x05\x03\uffff\x01\x04\x02\uffff\x01\x06\x01"+
            "\x07\x01\x0a\x02\uffff\x01\x08\x01\uffff\x01\x0b\x04\uffff\x01"+
            "\x09",
            "",
            "\x01\x0d\x04\uffff\x01\x0c\x09\uffff\x01\x0d\x05\uffff\x01"+
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
            get { return "()+ loopback of 305:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn | parallelfor | forstatement )+"; }
        }

    }

    const string DFA46_eotS =
        "\x1d\uffff";
    const string DFA46_eofS =
        "\x1d\uffff";
    const string DFA46_minS =
        "\x01\x30\x03\uffff\x02\x0d\x01\uffff\x01\x06\x01\x1b\x01\x0f\x01"+
        "\x04\x01\x06\x01\uffff\x03\x04\x02\x0f\x01\uffff\x01\x1b\x02\uffff"+
        "\x04\x04\x01\x0f\x02\uffff";
    const string DFA46_maxS =
        "\x01\x38\x03\uffff\x02\x0d\x01\uffff\x01\x06\x01\x1b\x01\x1f\x01"+
        "\x1b\x01\x06\x01\uffff\x03\x1b\x02\x1f\x01\uffff\x01\x1b\x02\uffff"+
        "\x04\x1b\x01\x1f\x02\uffff";
    const string DFA46_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x02\uffff\x01\x0a\x05\uffff"+
        "\x01\x06\x05\uffff\x01\x09\x01\uffff\x01\x05\x01\x04\x05\uffff\x01"+
        "\x07\x01\x08";
    const string DFA46_specialS =
        "\x1d\uffff}>";
    static readonly string[] DFA46_transitionS = {
            "\x01\x01\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06",
            "",
            "",
            "",
            "\x01\x07",
            "\x01\x08",
            "",
            "\x01\x09",
            "\x01\x0a",
            "\x01\x0c\x0f\uffff\x01\x0b",
            "\x01\x0d\x01\x0e\x01\x0f\x14\uffff\x01\x10",
            "\x01\x11",
            "",
            "\x01\x0d\x01\x0e\x01\x0f\x14\uffff\x01\x10",
            "\x01\x0d\x01\x0e\x01\x0f\x14\uffff\x01\x10",
            "\x01\x0d\x01\x0e\x01\x0f\x14\uffff\x01\x10",
            "\x01\x12\x0f\uffff\x01\x13",
            "\x01\x14\x0f\uffff\x01\x15",
            "",
            "\x01\x16",
            "",
            "",
            "\x01\x17\x01\x18\x01\x19\x14\uffff\x01\x1a",
            "\x01\x17\x01\x18\x01\x19\x14\uffff\x01\x1a",
            "\x01\x17\x01\x18\x01\x19\x14\uffff\x01\x1a",
            "\x01\x17\x01\x18\x01\x19\x14\uffff\x01\x1a",
            "\x01\x1c\x0f\uffff\x01\x1b",
            "",
            ""
    };

    static readonly short[] DFA46_eot = DFA.UnpackEncodedString(DFA46_eotS);
    static readonly short[] DFA46_eof = DFA.UnpackEncodedString(DFA46_eofS);
    static readonly char[] DFA46_min = DFA.UnpackEncodedStringToUnsignedChars(DFA46_minS);
    static readonly char[] DFA46_max = DFA.UnpackEncodedStringToUnsignedChars(DFA46_maxS);
    static readonly short[] DFA46_accept = DFA.UnpackEncodedString(DFA46_acceptS);
    static readonly short[] DFA46_special = DFA.UnpackEncodedString(DFA46_specialS);
    static readonly short[][] DFA46_transition = DFA.UnpackEncodedStringArray(DFA46_transitionS);

    protected class DFA46 : DFA
    {
        public DFA46(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 46;
            this.eot = DFA46_eot;
            this.eof = DFA46_eof;
            this.min = DFA46_min;
            this.max = DFA46_max;
            this.accept = DFA46_accept;
            this.special = DFA46_special;
            this.transition = DFA46_transition;

        }

        override public string Description
        {
            get { return "407:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vll1= variable ) ',' (vll2= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vll3= variable ) ',' (vll4= string_literal ) ',' ( ( '1D' ) | ( '2D' ) | ( '3D' ( ',' (el3= int_literal ) )? ) ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ',' ) ( (el4= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ',' ( (ell3= double_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= double_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ',' ) ( (vl3= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ',' ( (vl2= string_literal ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= string_literal ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program64 = new BitSet(new ulong[]{0x01F14D3D10000492UL});
    public static readonly BitSet FOLLOW_expr1_in_expr91 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallelfor_in_expr95 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr2_in_expr1112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_expr1121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr1132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr1143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functiondefination_in_expr1154 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_plotfunctions_in_expr1165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expr2183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_expr2193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_expr2203 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_expr2214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr2225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifelse_in_expr2235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_expr2244 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forstatement_in_expr2253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_comment_in_expr2262 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_int_or_double_literal280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_int_or_double_literal291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_double_literal_in_var_int_or_double_literal301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_double_literal366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_string_literal386 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_string_literal390 = new BitSet(new ulong[]{0x0000000008000070UL});
    public static readonly BitSet FOLLOW_27_in_string_literal395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixvardec415 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixvardec417 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixvardec419 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixvardec422 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec424 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec427 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec430 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec433 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec437 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec440 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixvardec448 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matrixvardec455 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixvardec459 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec464 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec469 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec472 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec485 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_matrixvardec492 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec495 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixvardec502 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matrixvardec508 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorvardec526 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorvardec528 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorvardec530 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorvardec533 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec535 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec538 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec541 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorvardec547 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_vectorvardec554 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec559 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec564 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec569 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec572 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec585 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_31_in_vectorvardec592 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec595 = new BitSet(new ulong[]{0x00000000C0000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorvardec602 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_vectorvardec608 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_matrixelem628 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem631 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem634 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem636 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_matrixelem639 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixelem642 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_matrixelem644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_vectorelem666 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_29_in_vectorelem669 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorelem672 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_30_in_vectorelem675 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment698 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment708 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_vectorelem_in_assignment720 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_matrixelem_in_assignment733 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment741 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_assignment750 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_dotproduct_in_assignment754 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_matrixtranspose_in_assignment763 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_string_literal_in_assignment767 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment782 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_additive_expression810 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additive_expression815 = new BitSet(new ulong[]{0x0000000000002070UL});
    public static readonly BitSet FOLLOW_multiplicative_expression_in_additive_expression821 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplicative_expression849 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_bracket_exp_in_multiplicative_expression861 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_matrixelem_in_multiplicative_expression874 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_vectorelem_in_multiplicative_expression887 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplicative_expression896 = new BitSet(new ulong[]{0x0000000000002070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_multiplicative_expression902 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_bracket_exp_in_multiplicative_expression915 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_vectorelem_in_multiplicative_expression928 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_matrixelem_in_multiplicative_expression941 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_bracket_exp978 = new BitSet(new ulong[]{0x0000000000002070UL});
    public static readonly BitSet FOLLOW_subtractive_exp_in_bracket_exp979 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_bracket_exp981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additive_expression_in_subtractive_exp1010 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_33_in_subtractive_exp1015 = new BitSet(new ulong[]{0x0000000000002070UL});
    public static readonly BitSet FOLLOW_additive_expression_in_subtractive_exp1021 = new BitSet(new ulong[]{0x0000000200000002UL});
    public static readonly BitSet FOLLOW_34_in_structdec1051 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structdec1053 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_structdec1057 = new BitSet(new ulong[]{0x0000000000000480UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_structdec1062 = new BitSet(new ulong[]{0x0000000000001480UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_structdec1068 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec1070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarvardec1091 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_scalarvardec1098 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarvardec1105 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_scalarvardec1109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1131 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec1138 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec1144 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1164 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_DOT_in_structassign1167 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structassign1170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_deletionofvar1190 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_deletionofvar1194 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_deletionofvar1198 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_print1217 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_print1219 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print1227 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parallelfor1249 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_range_in_parallelfor1255 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_parallelfor1258 = new BitSet(new ulong[]{0x0000451900000490UL});
    public static readonly BitSet FOLLOW_expr2_in_parallelfor1265 = new BitSet(new ulong[]{0x0000455900001490UL});
    public static readonly BitSet FOLLOW_38_in_parallelfor1271 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_parallelfor1274 = new BitSet(new ulong[]{0x0000451900001490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_parallelfor1282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_range1296 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_range1302 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_POINT_in_range1305 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_range1311 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_range1314 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_range1319 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_range1322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_ifelse1339 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_ifelse1341 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_equality_in_ifelse1344 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_nonequality_in_ifelse1347 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_lessthan_in_ifelse1350 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_lessthanequalto_in_ifelse1356 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_greaterthan_in_ifelse1359 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_greaterthanequalto_in_ifelse1363 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_ifelse1368 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1370 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1378 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1383 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_ifelse1386 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse1389 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_ifloop_in_ifelse1398 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse1404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_ifloop1425 = new BitSet(new ulong[]{0x01F1CD3D10000492UL});
    public static readonly BitSet FOLLOW_functionreturn_in_ifloop1428 = new BitSet(new ulong[]{0x01F1CD3D10000492UL});
    public static readonly BitSet FOLLOW_42_in_forstatement1447 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_range_in_forstatement1452 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_forstatement1455 = new BitSet(new ulong[]{0x01F14D1D10000490UL});
    public static readonly BitSet FOLLOW_expr1_in_forstatement1460 = new BitSet(new ulong[]{0x01F14D1D10001490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_forstatement1465 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_functioncall1490 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functioncall1495 = new BitSet(new ulong[]{0x0000000000008070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1499 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_31_in_functioncall1503 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1507 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functioncall1514 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functioncall1518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_equality1547 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_equality1556 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_equality1566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_nonequality1609 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_nonequality1618 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_nonequality1623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_functiondefination1655 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1660 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1666 = new BitSet(new ulong[]{0x0000000110008080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1674 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1677 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1682 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1691 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1693 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1696 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1699 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1703 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1711 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1719 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1727 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1733 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1741 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1745 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1749 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1753 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_functiondefination1761 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1766 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1772 = new BitSet(new ulong[]{0x0000000110008080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1781 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_31_in_functiondefination1784 = new BitSet(new ulong[]{0x0000000110000080UL});
    public static readonly BitSet FOLLOW_arguments_in_functiondefination1788 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1797 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1799 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1802 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1805 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1809 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1817 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1825 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1833 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1839 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1847 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1851 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_parallelfor_in_functiondefination1855 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_forstatement_in_functiondefination1859 = new BitSet(new ulong[]{0x01F1CD3D10001490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lessthan1884 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_lessthan1887 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_lessthan1892 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_greaterthan1914 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_greaterthan1917 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_greaterthan1922 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lessthanequalto1944 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_LESSTHANEQUALTOEXPRESSION_in_lessthanequalto1947 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_lessthanequalto1953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_greaterthanequalto1975 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEQUALTOEXPRESSION_in_greaterthanequalto1978 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_greaterthanequalto1984 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct2009 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_dotproduct2013 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_dotproduct2019 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_matrixtranspose2038 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_matrixtranspose2040 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixtranspose2042 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_matrixtranspose2045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_matrixreference2061 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_matrixreference2063 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixreference2068 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_matrixreference2070 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixreference2074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_vectorreference2093 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_LESSTHANEXPRESSION_in_vectorreference2095 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorreference2100 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_GREATERTHANEXPRESSION_in_vectorreference2102 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorreference2106 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarargument_in_arguments2122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixreference_in_arguments2128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorreference_in_arguments2134 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarargument2166 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarargument2173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_comment2192 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_comment2193 = new BitSet(new ulong[]{0x0000000000000072UL});
    public static readonly BitSet FOLLOW_47_in_functionreturn2211 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functionreturn2214 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functionreturn2218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_plotfunctions2242 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2245 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2252 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2257 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2264 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2269 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2276 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2281 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2288 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2292 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2296 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2301 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2306 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2309 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2315 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2323 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_plotfunctions2330 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2333 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions2339 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2344 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2350 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2354 = new BitSet(new ulong[]{0x000E000000000000UL});
    public static readonly BitSet FOLLOW_49_in_plotfunctions2358 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_50_in_plotfunctions2363 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_51_in_plotfunctions2368 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2371 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions2377 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2385 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2386 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_plotfunctions2392 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2393 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2394 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2402 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2404 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2410 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2413 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2419 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2422 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2429 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2434 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2440 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2442 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2448 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2451 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2457 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2462 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_plotfunctions2468 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2470 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_double_literal_in_plotfunctions2476 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2480 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2487 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2489 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2495 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2498 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2505 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2508 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2516 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2521 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2528 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2530 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2536 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_31_in_plotfunctions2539 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2546 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2551 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_plotfunctions2557 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2559 = new BitSet(new ulong[]{0x0000200008002070UL});
    public static readonly BitSet FOLLOW_string_literal_in_plotfunctions2565 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2569 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2570 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_plotfunctions2575 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions2576 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_plotfunctions2579 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions2583 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions2585 = new BitSet(new ulong[]{0x0000000000000002UL});

}
