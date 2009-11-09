// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 spinach.g 2009-11-02 22:06:33


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
		"SCALEMODE", 
		"DOT", 
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
		"'delete'", 
		"'print'", 
		"'parallelfor'", 
		"'SYNC'", 
		"'to'", 
		"'if'", 
		"'else'", 
		"'for'", 
		"'void'", 
		"'return'", 
		"'subPlot'", 
		"'plot'", 
		"'resetPlot'", 
		"'setPlotAxis'", 
		"'setAxisTitle'", 
		"'setScaleMode'"
    };

    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int POINT = 14;
    public const int T__23 = 23;
    public const int EQUALITYEXPRESSION = 16;
    public const int DOUBLE_LITERAL = 6;
    public const int EOF = -1;
    public const int NONEQUALITYEXPRESSION = 17;
    public const int LEFTBRACE = 13;
    public const int MULTIPLY = 21;
    public const int PLUS = 20;
    public const int RIGHTBRACE = 15;
    public const int DOT = 19;
    public const int END_OF_STATEMENT = 9;
    public const int RIGHTPARANTHESIS = 12;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int SCALEMODE = 18;
    public const int T__41 = 41;
    public const int INT_LITERAL = 5;
    public const int T__46 = 46;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int WHITESPACE = 22;
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
    // spinach.g:20:1: program returns [List<Element> ret] : ( expr )+ ;
    public spinachParser.program_return program() // throws RecognitionException [1]
    {   
        spinachParser.program_return retval = new spinachParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // spinach.g:24:3: ( ( expr )+ )
            // spinach.g:24:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:24:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || LA1_0 == VARTYPE || LA1_0 == STRINGTYPE || LA1_0 == 23 || (LA1_0 >= 29 && LA1_0 <= 33) || LA1_0 == 36 || (LA1_0 >= 38 && LA1_0 <= 46)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // spinach.g:24:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program65);
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
    // spinach.g:26:1: expr returns [Element ret] : ( expr1 | parallelfor );
    public spinachParser.expr_return expr() // throws RecognitionException [1]
    {   
        spinachParser.expr_return retval = new spinachParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.expr1_return expr12 = null;

        spinachParser.parallelfor_return parallelfor3 = null;



        try 
    	{
            // spinach.g:27:3: ( expr1 | parallelfor )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == VARIABLE || LA2_0 == VARTYPE || LA2_0 == STRINGTYPE || LA2_0 == 23 || (LA2_0 >= 29 && LA2_0 <= 32) || LA2_0 == 36 || (LA2_0 >= 38 && LA2_0 <= 46)) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 33) )
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
                    // spinach.g:27:4: expr1
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_expr1_in_expr85);
                    	expr12 = expr1();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, expr12.Tree);
                    	retval.ret = ((expr12 != null) ? expr12.ret : null);

                    }
                    break;
                case 2 :
                    // spinach.g:27:37: parallelfor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallelfor_in_expr89);
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
    // spinach.g:30:1: expr1 returns [Element ret] : ( assignment | scalarvardec | vectorvardec | matrixvardec | deletionofvar | structdec | structobjdec | print | ifelse | functioncall | equality | nonequality | forstatement | functiondefination | functionreturn | plotfunctions );
    public spinachParser.expr1_return expr1() // throws RecognitionException [1]
    {   
        spinachParser.expr1_return retval = new spinachParser.expr1_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.assignment_return assignment4 = null;

        spinachParser.scalarvardec_return scalarvardec5 = null;

        spinachParser.vectorvardec_return vectorvardec6 = null;

        spinachParser.matrixvardec_return matrixvardec7 = null;

        spinachParser.deletionofvar_return deletionofvar8 = null;

        spinachParser.structdec_return structdec9 = null;

        spinachParser.structobjdec_return structobjdec10 = null;

        spinachParser.print_return print11 = null;

        spinachParser.ifelse_return ifelse12 = null;

        spinachParser.functioncall_return functioncall13 = null;

        spinachParser.equality_return equality14 = null;

        spinachParser.nonequality_return nonequality15 = null;

        spinachParser.forstatement_return forstatement16 = null;

        spinachParser.functiondefination_return functiondefination17 = null;

        spinachParser.functionreturn_return functionreturn18 = null;

        spinachParser.plotfunctions_return plotfunctions19 = null;



        try 
    	{
            // spinach.g:31:3: ( assignment | scalarvardec | vectorvardec | matrixvardec | deletionofvar | structdec | structobjdec | print | ifelse | functioncall | equality | nonequality | forstatement | functiondefination | functionreturn | plotfunctions )
            int alt3 = 16;
            alt3 = dfa3.Predict(input);
            switch (alt3) 
            {
                case 1 :
                    // spinach.g:31:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expr1105);
                    	assignment4 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment4.Tree);
                    	retval.ret = ((assignment4 != null) ? assignment4.ret : null);

                    }
                    break;
                case 2 :
                    // spinach.g:32:5: scalarvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_scalarvardec_in_expr1113);
                    	scalarvardec5 = scalarvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, scalarvardec5.Tree);
                    	 retval.ret = ((scalarvardec5 != null) ? scalarvardec5.ret : null);

                    }
                    break;
                case 3 :
                    // spinach.g:33:5: vectorvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_vectorvardec_in_expr1121);
                    	vectorvardec6 = vectorvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, vectorvardec6.Tree);
                    	 retval.ret = ((vectorvardec6 != null) ? vectorvardec6.ret : null);

                    }
                    break;
                case 4 :
                    // spinach.g:34:5: matrixvardec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_matrixvardec_in_expr1129);
                    	matrixvardec7 = matrixvardec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, matrixvardec7.Tree);
                    	 retval.ret = ((matrixvardec7 != null) ? matrixvardec7.ret : null);

                    }
                    break;
                case 5 :
                    // spinach.g:35:5: deletionofvar
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_deletionofvar_in_expr1137);
                    	deletionofvar8 = deletionofvar();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, deletionofvar8.Tree);
                    	 retval.ret = ((deletionofvar8 != null) ? deletionofvar8.ret : null);

                    }
                    break;
                case 6 :
                    // spinach.g:36:5: structdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structdec_in_expr1145);
                    	structdec9 = structdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structdec9.Tree);
                    	retval.ret = ((structdec9 != null) ? structdec9.ret : null);

                    }
                    break;
                case 7 :
                    // spinach.g:37:5: structobjdec
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_structobjdec_in_expr1153);
                    	structobjdec10 = structobjdec();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, structobjdec10.Tree);
                    	 retval.ret = ((structobjdec10 != null) ? structobjdec10.ret : null);

                    }
                    break;
                case 8 :
                    // spinach.g:38:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr1161);
                    	print11 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print11.Tree);
                    	 retval.ret = ((print11 != null) ? print11.ret : null); 

                    }
                    break;
                case 9 :
                    // spinach.g:39:5: ifelse
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifelse_in_expr1169);
                    	ifelse12 = ifelse();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ifelse12.Tree);
                    	retval.ret = ((ifelse12 != null) ? ifelse12.ret : null);

                    }
                    break;
                case 10 :
                    // spinach.g:40:5: functioncall
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functioncall_in_expr1176);
                    	functioncall13 = functioncall();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functioncall13.Tree);
                    	retval.ret=((functioncall13 != null) ? functioncall13.ret : null);

                    }
                    break;
                case 11 :
                    // spinach.g:41:5: equality
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_equality_in_expr1183);
                    	equality14 = equality();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, equality14.Tree);
                    	retval.ret = ((equality14 != null) ? equality14.ret : null);

                    }
                    break;
                case 12 :
                    // spinach.g:42:5: nonequality
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_nonequality_in_expr1190);
                    	nonequality15 = nonequality();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, nonequality15.Tree);
                    	retval.ret = ((nonequality15 != null) ? nonequality15.ret : null);

                    }
                    break;
                case 13 :
                    // spinach.g:43:5: forstatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forstatement_in_expr1197);
                    	forstatement16 = forstatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, forstatement16.Tree);
                    	retval.ret = ((forstatement16 != null) ? forstatement16.ret : null);

                    }
                    break;
                case 14 :
                    // spinach.g:44:5: functiondefination
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functiondefination_in_expr1204);
                    	functiondefination17 = functiondefination();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functiondefination17.Tree);
                    	retval.ret = ((functiondefination17 != null) ? functiondefination17.ret : null);

                    }
                    break;
                case 15 :
                    // spinach.g:45:5: functionreturn
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_functionreturn_in_expr1211);
                    	functionreturn18 = functionreturn();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, functionreturn18.Tree);
                    	retval.ret =((functionreturn18 != null) ? functionreturn18.ret : null);

                    }
                    break;
                case 16 :
                    // spinach.g:46:5: plotfunctions
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_plotfunctions_in_expr1218);
                    	plotfunctions19 = plotfunctions();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, plotfunctions19.Tree);
                    	retval.ret = ((plotfunctions19 != null) ? plotfunctions19.ret : null);

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
    // spinach.g:48:1: var_int_or_double_literal returns [Element ret] : ( variable | int_literal | double_literal ) ;
    public spinachParser.var_int_or_double_literal_return var_int_or_double_literal() // throws RecognitionException [1]
    {   
        spinachParser.var_int_or_double_literal_return retval = new spinachParser.var_int_or_double_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        spinachParser.variable_return variable20 = null;

        spinachParser.int_literal_return int_literal21 = null;

        spinachParser.double_literal_return double_literal22 = null;



        try 
    	{
            // spinach.g:49:3: ( ( variable | int_literal | double_literal ) )
            // spinach.g:49:6: ( variable | int_literal | double_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:49:6: ( variable | int_literal | double_literal )
            	int alt4 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    alt4 = 1;
            	    }
            	    break;
            	case INT_LITERAL:
            		{
            	    alt4 = 2;
            	    }
            	    break;
            	case DOUBLE_LITERAL:
            		{
            	    alt4 = 3;
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
            	        // spinach.g:49:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_int_or_double_literal235);
            	        	variable20 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable20.Tree);
            	        	 retval.ret = ((variable20 != null) ? variable20.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:50:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_int_or_double_literal246);
            	        	int_literal21 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal21.Tree);
            	        	retval.ret = ((int_literal21 != null) ? int_literal21.ret : null); 

            	        }
            	        break;
            	    case 3 :
            	        // spinach.g:51:7: double_literal
            	        {
            	        	PushFollow(FOLLOW_double_literal_in_var_int_or_double_literal256);
            	        	double_literal22 = double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, double_literal22.Tree);
            	        	retval.ret = ((double_literal22 != null) ? double_literal22.ret : null);

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
    // spinach.g:53:1: variable returns [VariableElement ret] : VARIABLE ;
    public spinachParser.variable_return variable() // throws RecognitionException [1]
    {   
        spinachParser.variable_return retval = new spinachParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE23 = null;

        object VARIABLE23_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // spinach.g:57:3: ( VARIABLE )
            // spinach.g:57:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE23=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable278); 
            		VARIABLE23_tree = (object)adaptor.Create(VARIABLE23);
            		adaptor.AddChild(root_0, VARIABLE23_tree);

            	 retval.ret.setText(((VARIABLE23 != null) ? VARIABLE23.Text : null)); 

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
    // spinach.g:59:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public spinachParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        spinachParser.int_literal_return retval = new spinachParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL24 = null;

        object INT_LITERAL24_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // spinach.g:63:3: ( INT_LITERAL )
            // spinach.g:63:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL24=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal299); 
            		INT_LITERAL24_tree = (object)adaptor.Create(INT_LITERAL24);
            		adaptor.AddChild(root_0, INT_LITERAL24_tree);

            	 retval.ret.setText(((INT_LITERAL24 != null) ? INT_LITERAL24.Text : null)); 

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
    // spinach.g:65:1: double_literal returns [DoubleElement ret] : el1= DOUBLE_LITERAL ;
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
            // spinach.g:69:2: (el1= DOUBLE_LITERAL )
            // spinach.g:69:4: el1= DOUBLE_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	el1=(IToken)Match(input,DOUBLE_LITERAL,FOLLOW_DOUBLE_LITERAL_in_double_literal321); 
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
    // spinach.g:71:1: matrixvardec returns [MatrixVariableDeclaration ret] : ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']' ) END_OF_STATEMENT ;
    public spinachParser.matrixvardec_return matrixvardec() // throws RecognitionException [1]
    {   
        spinachParser.matrixvardec_return retval = new spinachParser.matrixvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal25 = null;
        IToken char_literal26 = null;
        IToken VARTYPE27 = null;
        IToken char_literal28 = null;
        IToken char_literal29 = null;
        IToken char_literal30 = null;
        IToken char_literal31 = null;
        IToken char_literal32 = null;
        IToken ASSIGNMENT33 = null;
        IToken char_literal34 = null;
        IToken char_literal35 = null;
        IToken char_literal36 = null;
        IToken char_literal37 = null;
        IToken END_OF_STATEMENT38 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return el3 = null;

        spinachParser.int_literal_return el4 = null;

        spinachParser.double_literal_return el5 = null;

        spinachParser.int_literal_return el6 = null;

        spinachParser.double_literal_return el7 = null;


        object string_literal25_tree=null;
        object char_literal26_tree=null;
        object VARTYPE27_tree=null;
        object char_literal28_tree=null;
        object char_literal29_tree=null;
        object char_literal30_tree=null;
        object char_literal31_tree=null;
        object char_literal32_tree=null;
        object ASSIGNMENT33_tree=null;
        object char_literal34_tree=null;
        object char_literal35_tree=null;
        object char_literal36_tree=null;
        object char_literal37_tree=null;
        object END_OF_STATEMENT38_tree=null;


        	retval.ret = new MatrixVariableDeclaration();
        	
        try 
    	{
            // spinach.g:75:2: ( ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']' ) END_OF_STATEMENT )
            // spinach.g:75:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:75:3: ( 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']' )
            	// spinach.g:75:4: 'Matrix' '<' VARTYPE '>' '[' el1= int_literal ']' '[' el2= int_literal ']' (el3= variable ) ASSIGNMENT '[' ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* ) ']'
            	{
            		string_literal25=(IToken)Match(input,23,FOLLOW_23_in_matrixvardec341); 
            			string_literal25_tree = (object)adaptor.Create(string_literal25);
            			adaptor.AddChild(root_0, string_literal25_tree);

            		char_literal26=(IToken)Match(input,24,FOLLOW_24_in_matrixvardec343); 
            			char_literal26_tree = (object)adaptor.Create(char_literal26);
            			adaptor.AddChild(root_0, char_literal26_tree);

            		VARTYPE27=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_matrixvardec345); 
            			VARTYPE27_tree = (object)adaptor.Create(VARTYPE27);
            			adaptor.AddChild(root_0, VARTYPE27_tree);

            		 retval.ret.setType(((VARTYPE27 != null) ? VARTYPE27.Text : null));
            		char_literal28=(IToken)Match(input,25,FOLLOW_25_in_matrixvardec348); 
            			char_literal28_tree = (object)adaptor.Create(char_literal28);
            			adaptor.AddChild(root_0, char_literal28_tree);

            		char_literal29=(IToken)Match(input,26,FOLLOW_26_in_matrixvardec350); 
            			char_literal29_tree = (object)adaptor.Create(char_literal29);
            			adaptor.AddChild(root_0, char_literal29_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec353);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setRow(((el1 != null) ? el1.ret : null));
            		char_literal30=(IToken)Match(input,27,FOLLOW_27_in_matrixvardec356); 
            			char_literal30_tree = (object)adaptor.Create(char_literal30);
            			adaptor.AddChild(root_0, char_literal30_tree);

            		char_literal31=(IToken)Match(input,26,FOLLOW_26_in_matrixvardec359); 
            			char_literal31_tree = (object)adaptor.Create(char_literal31);
            			adaptor.AddChild(root_0, char_literal31_tree);

            		PushFollow(FOLLOW_int_literal_in_matrixvardec363);
            		el2 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setColumn(((el2 != null) ? el2.ret : null));
            		char_literal32=(IToken)Match(input,27,FOLLOW_27_in_matrixvardec366); 
            			char_literal32_tree = (object)adaptor.Create(char_literal32);
            			adaptor.AddChild(root_0, char_literal32_tree);

            		// spinach.g:77:3: (el3= variable )
            		// spinach.g:77:4: el3= variable
            		{
            			PushFollow(FOLLOW_variable_in_matrixvardec374);
            			el3 = variable();
            			state.followingStackPointer--;

            			adaptor.AddChild(root_0, el3.Tree);
            			 retval.ret.setVar(((el3 != null) ? el3.ret : null));

            		}

            		ASSIGNMENT33=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_matrixvardec381); 
            			ASSIGNMENT33_tree = (object)adaptor.Create(ASSIGNMENT33);
            			adaptor.AddChild(root_0, ASSIGNMENT33_tree);

            		char_literal34=(IToken)Match(input,26,FOLLOW_26_in_matrixvardec385); 
            			char_literal34_tree = (object)adaptor.Create(char_literal34);
            			adaptor.AddChild(root_0, char_literal34_tree);

            		// spinach.g:79:6: ( (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )* )
            		// spinach.g:79:7: (el4= int_literal | el5= double_literal ) ( ',' el6= int_literal | ',' el7= double_literal )*
            		{
            			// spinach.g:79:7: (el4= int_literal | el5= double_literal )
            			int alt5 = 2;
            			int LA5_0 = input.LA(1);

            			if ( (LA5_0 == INT_LITERAL) )
            			{
            			    alt5 = 1;
            			}
            			else if ( (LA5_0 == DOUBLE_LITERAL) )
            			{
            			    alt5 = 2;
            			}
            			else 
            			{
            			    NoViableAltException nvae_d5s0 =
            			        new NoViableAltException("", 5, 0, input);

            			    throw nvae_d5s0;
            			}
            			switch (alt5) 
            			{
            			    case 1 :
            			        // spinach.g:79:8: el4= int_literal
            			        {
            			        	PushFollow(FOLLOW_int_literal_in_matrixvardec390);
            			        	el4 = int_literal();
            			        	state.followingStackPointer--;

            			        	adaptor.AddChild(root_0, el4.Tree);
            			        	retval.ret.addValue(((el4 != null) ? el4.ret : null));

            			        }
            			        break;
            			    case 2 :
            			        // spinach.g:79:57: el5= double_literal
            			        {
            			        	PushFollow(FOLLOW_double_literal_in_matrixvardec396);
            			        	el5 = double_literal();
            			        	state.followingStackPointer--;

            			        	adaptor.AddChild(root_0, el5.Tree);
            			        	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            			        }
            			        break;

            			}

            			// spinach.g:80:3: ( ',' el6= int_literal | ',' el7= double_literal )*
            			do 
            			{
            			    int alt6 = 3;
            			    int LA6_0 = input.LA(1);

            			    if ( (LA6_0 == 28) )
            			    {
            			        int LA6_2 = input.LA(2);

            			        if ( (LA6_2 == DOUBLE_LITERAL) )
            			        {
            			            alt6 = 2;
            			        }
            			        else if ( (LA6_2 == INT_LITERAL) )
            			        {
            			            alt6 = 1;
            			        }


            			    }


            			    switch (alt6) 
            				{
            					case 1 :
            					    // spinach.g:80:4: ',' el6= int_literal
            					    {
            					    	char_literal35=(IToken)Match(input,28,FOLLOW_28_in_matrixvardec404); 
            					    		char_literal35_tree = (object)adaptor.Create(char_literal35);
            					    		adaptor.AddChild(root_0, char_literal35_tree);

            					    	PushFollow(FOLLOW_int_literal_in_matrixvardec407);
            					    	el6 = int_literal();
            					    	state.followingStackPointer--;

            					    	adaptor.AddChild(root_0, el6.Tree);
            					    	retval.ret.addValue(((el6 != null) ? el6.ret : null));

            					    }
            					    break;
            					case 2 :
            					    // spinach.g:80:56: ',' el7= double_literal
            					    {
            					    	char_literal36=(IToken)Match(input,28,FOLLOW_28_in_matrixvardec411); 
            					    		char_literal36_tree = (object)adaptor.Create(char_literal36);
            					    		adaptor.AddChild(root_0, char_literal36_tree);

            					    	PushFollow(FOLLOW_double_literal_in_matrixvardec414);
            					    	el7 = double_literal();
            					    	state.followingStackPointer--;

            					    	adaptor.AddChild(root_0, el7.Tree);
            					    	retval.ret.addValue(((el7 != null) ? el7.ret : null));

            					    }
            					    break;

            					default:
            					    goto loop6;
            			    }
            			} while (true);

            			loop6:
            				;	// Stops C# compiler whining that label 'loop6' has no statements


            		}

            		char_literal37=(IToken)Match(input,27,FOLLOW_27_in_matrixvardec420); 
            			char_literal37_tree = (object)adaptor.Create(char_literal37);
            			adaptor.AddChild(root_0, char_literal37_tree);


            	}

            	retval.ret.setValue();
            	END_OF_STATEMENT38=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_matrixvardec426); 
            		END_OF_STATEMENT38_tree = (object)adaptor.Create(END_OF_STATEMENT38);
            		adaptor.AddChild(root_0, END_OF_STATEMENT38_tree);


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
    // spinach.g:83:1: vectorvardec returns [VectorVariableDeclaration ret] : ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']' ) END_OF_STATEMENT ;
    public spinachParser.vectorvardec_return vectorvardec() // throws RecognitionException [1]
    {   
        spinachParser.vectorvardec_return retval = new spinachParser.vectorvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal39 = null;
        IToken char_literal40 = null;
        IToken VARTYPE41 = null;
        IToken char_literal42 = null;
        IToken char_literal43 = null;
        IToken char_literal44 = null;
        IToken ASSIGNMENT45 = null;
        IToken char_literal46 = null;
        IToken char_literal47 = null;
        IToken char_literal48 = null;
        IToken char_literal49 = null;
        IToken END_OF_STATEMENT50 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.variable_return el2 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.double_literal_return el4 = null;

        spinachParser.int_literal_return el5 = null;

        spinachParser.double_literal_return el6 = null;


        object string_literal39_tree=null;
        object char_literal40_tree=null;
        object VARTYPE41_tree=null;
        object char_literal42_tree=null;
        object char_literal43_tree=null;
        object char_literal44_tree=null;
        object ASSIGNMENT45_tree=null;
        object char_literal46_tree=null;
        object char_literal47_tree=null;
        object char_literal48_tree=null;
        object char_literal49_tree=null;
        object END_OF_STATEMENT50_tree=null;


        	retval.ret = new VectorVariableDeclaration();
        	
        try 
    	{
            // spinach.g:87:2: ( ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']' ) END_OF_STATEMENT )
            // spinach.g:87:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:87:3: ( 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']' )
            	// spinach.g:87:4: 'Vector' '<' VARTYPE '>' '[' el1= int_literal ']' el2= variable ASSIGNMENT '[' ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* ) ']'
            	{
            		string_literal39=(IToken)Match(input,29,FOLLOW_29_in_vectorvardec444); 
            			string_literal39_tree = (object)adaptor.Create(string_literal39);
            			adaptor.AddChild(root_0, string_literal39_tree);

            		char_literal40=(IToken)Match(input,24,FOLLOW_24_in_vectorvardec446); 
            			char_literal40_tree = (object)adaptor.Create(char_literal40);
            			adaptor.AddChild(root_0, char_literal40_tree);

            		VARTYPE41=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_vectorvardec448); 
            			VARTYPE41_tree = (object)adaptor.Create(VARTYPE41);
            			adaptor.AddChild(root_0, VARTYPE41_tree);

            		 retval.ret.setType(((VARTYPE41 != null) ? VARTYPE41.Text : null));
            		char_literal42=(IToken)Match(input,25,FOLLOW_25_in_vectorvardec451); 
            			char_literal42_tree = (object)adaptor.Create(char_literal42);
            			adaptor.AddChild(root_0, char_literal42_tree);

            		char_literal43=(IToken)Match(input,26,FOLLOW_26_in_vectorvardec453); 
            			char_literal43_tree = (object)adaptor.Create(char_literal43);
            			adaptor.AddChild(root_0, char_literal43_tree);

            		PushFollow(FOLLOW_int_literal_in_vectorvardec456);
            		el1 = int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setRange(((el1 != null) ? el1.ret : null));
            		char_literal44=(IToken)Match(input,27,FOLLOW_27_in_vectorvardec459); 
            			char_literal44_tree = (object)adaptor.Create(char_literal44);
            			adaptor.AddChild(root_0, char_literal44_tree);

            		PushFollow(FOLLOW_variable_in_vectorvardec465);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		retval.ret.setText(((el2 != null) ? el2.ret : null));
            		ASSIGNMENT45=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_vectorvardec472); 
            			ASSIGNMENT45_tree = (object)adaptor.Create(ASSIGNMENT45);
            			adaptor.AddChild(root_0, ASSIGNMENT45_tree);

            		char_literal46=(IToken)Match(input,26,FOLLOW_26_in_vectorvardec477); 
            			char_literal46_tree = (object)adaptor.Create(char_literal46);
            			adaptor.AddChild(root_0, char_literal46_tree);

            		// spinach.g:90:6: ( (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )* )
            		// spinach.g:90:7: (el3= int_literal | el4= double_literal ) ( ',' el5= int_literal | ',' el6= double_literal )*
            		{
            			// spinach.g:90:7: (el3= int_literal | el4= double_literal )
            			int alt7 = 2;
            			int LA7_0 = input.LA(1);

            			if ( (LA7_0 == INT_LITERAL) )
            			{
            			    alt7 = 1;
            			}
            			else if ( (LA7_0 == DOUBLE_LITERAL) )
            			{
            			    alt7 = 2;
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
            			        // spinach.g:90:8: el3= int_literal
            			        {
            			        	PushFollow(FOLLOW_int_literal_in_vectorvardec482);
            			        	el3 = int_literal();
            			        	state.followingStackPointer--;

            			        	adaptor.AddChild(root_0, el3.Tree);
            			        	retval.ret.addValue(((el3 != null) ? el3.ret : null));

            			        }
            			        break;
            			    case 2 :
            			        // spinach.g:90:57: el4= double_literal
            			        {
            			        	PushFollow(FOLLOW_double_literal_in_vectorvardec488);
            			        	el4 = double_literal();
            			        	state.followingStackPointer--;

            			        	adaptor.AddChild(root_0, el4.Tree);
            			        	retval.ret.addValue(((el4 != null) ? el4.ret : null));

            			        }
            			        break;

            			}

            			// spinach.g:91:3: ( ',' el5= int_literal | ',' el6= double_literal )*
            			do 
            			{
            			    int alt8 = 3;
            			    int LA8_0 = input.LA(1);

            			    if ( (LA8_0 == 28) )
            			    {
            			        int LA8_2 = input.LA(2);

            			        if ( (LA8_2 == INT_LITERAL) )
            			        {
            			            alt8 = 1;
            			        }
            			        else if ( (LA8_2 == DOUBLE_LITERAL) )
            			        {
            			            alt8 = 2;
            			        }


            			    }


            			    switch (alt8) 
            				{
            					case 1 :
            					    // spinach.g:91:4: ',' el5= int_literal
            					    {
            					    	char_literal47=(IToken)Match(input,28,FOLLOW_28_in_vectorvardec496); 
            					    		char_literal47_tree = (object)adaptor.Create(char_literal47);
            					    		adaptor.AddChild(root_0, char_literal47_tree);

            					    	PushFollow(FOLLOW_int_literal_in_vectorvardec499);
            					    	el5 = int_literal();
            					    	state.followingStackPointer--;

            					    	adaptor.AddChild(root_0, el5.Tree);
            					    	retval.ret.addValue(((el5 != null) ? el5.ret : null));

            					    }
            					    break;
            					case 2 :
            					    // spinach.g:91:56: ',' el6= double_literal
            					    {
            					    	char_literal48=(IToken)Match(input,28,FOLLOW_28_in_vectorvardec503); 
            					    		char_literal48_tree = (object)adaptor.Create(char_literal48);
            					    		adaptor.AddChild(root_0, char_literal48_tree);

            					    	PushFollow(FOLLOW_double_literal_in_vectorvardec506);
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

            		char_literal49=(IToken)Match(input,27,FOLLOW_27_in_vectorvardec512); 
            			char_literal49_tree = (object)adaptor.Create(char_literal49);
            			adaptor.AddChild(root_0, char_literal49_tree);


            	}

            	retval.ret.setValue();
            	END_OF_STATEMENT50=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_vectorvardec518); 
            		END_OF_STATEMENT50_tree = (object)adaptor.Create(END_OF_STATEMENT50);
            		adaptor.AddChild(root_0, END_OF_STATEMENT50_tree);


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
    // spinach.g:94:1: assignment returns [AssignmentOperationElement ret] : ( variable | structassign ) ASSIGNMENT ( var_int_or_double_literal | addition ) END_OF_STATEMENT ;
    public spinachParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        spinachParser.assignment_return retval = new spinachParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT53 = null;
        IToken END_OF_STATEMENT56 = null;
        spinachParser.variable_return variable51 = null;

        spinachParser.structassign_return structassign52 = null;

        spinachParser.var_int_or_double_literal_return var_int_or_double_literal54 = null;

        spinachParser.addition_return addition55 = null;


        object ASSIGNMENT53_tree=null;
        object END_OF_STATEMENT56_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // spinach.g:98:3: ( ( variable | structassign ) ASSIGNMENT ( var_int_or_double_literal | addition ) END_OF_STATEMENT )
            // spinach.g:98:5: ( variable | structassign ) ASSIGNMENT ( var_int_or_double_literal | addition ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:98:5: ( variable | structassign )
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == VARIABLE) )
            	{
            	    int LA9_1 = input.LA(2);

            	    if ( (LA9_1 == ASSIGNMENT) )
            	    {
            	        alt9 = 1;
            	    }
            	    else if ( (LA9_1 == DOT) )
            	    {
            	        alt9 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d9s1 =
            	            new NoViableAltException("", 9, 1, input);

            	        throw nvae_d9s1;
            	    }
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
            	        // spinach.g:98:6: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_assignment538);
            	        	variable51 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable51.Tree);
            	        	retval.ret.setLhs(((variable51 != null) ? variable51.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:99:7: structassign
            	        {
            	        	PushFollow(FOLLOW_structassign_in_assignment548);
            	        	structassign52 = structassign();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, structassign52.Tree);
            	        	retval.ret.setLhs(((structassign52 != null) ? structassign52.ret : null));

            	        }
            	        break;

            	}

            	ASSIGNMENT53=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment557); 
            		ASSIGNMENT53_tree = (object)adaptor.Create(ASSIGNMENT53);
            		adaptor.AddChild(root_0, ASSIGNMENT53_tree);

            	// spinach.g:101:5: ( var_int_or_double_literal | addition )
            	int alt10 = 2;
            	switch ( input.LA(1) ) 
            	{
            	case VARIABLE:
            		{
            	    int LA10_1 = input.LA(2);

            	    if ( (LA10_1 == END_OF_STATEMENT) )
            	    {
            	        alt10 = 1;
            	    }
            	    else if ( (LA10_1 == PLUS) )
            	    {
            	        alt10 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d10s1 =
            	            new NoViableAltException("", 10, 1, input);

            	        throw nvae_d10s1;
            	    }
            	    }
            	    break;
            	case INT_LITERAL:
            		{
            	    int LA10_2 = input.LA(2);

            	    if ( (LA10_2 == END_OF_STATEMENT) )
            	    {
            	        alt10 = 1;
            	    }
            	    else if ( (LA10_2 == PLUS) )
            	    {
            	        alt10 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d10s2 =
            	            new NoViableAltException("", 10, 2, input);

            	        throw nvae_d10s2;
            	    }
            	    }
            	    break;
            	case DOUBLE_LITERAL:
            		{
            	    int LA10_3 = input.LA(2);

            	    if ( (LA10_3 == END_OF_STATEMENT) )
            	    {
            	        alt10 = 1;
            	    }
            	    else if ( (LA10_3 == PLUS) )
            	    {
            	        alt10 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d10s3 =
            	            new NoViableAltException("", 10, 3, input);

            	        throw nvae_d10s3;
            	    }
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d10s0 =
            		        new NoViableAltException("", 10, 0, input);

            		    throw nvae_d10s0;
            	}

            	switch (alt10) 
            	{
            	    case 1 :
            	        // spinach.g:101:6: var_int_or_double_literal
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_assignment565);
            	        	var_int_or_double_literal54 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_int_or_double_literal54.Tree);
            	        	retval.ret.setRhs(((var_int_or_double_literal54 != null) ? var_int_or_double_literal54.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // spinach.g:102:7: addition
            	        {
            	        	PushFollow(FOLLOW_addition_in_assignment576);
            	        	addition55 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition55.Tree);
            	        	retval.ret.setRhs(((addition55 != null) ? addition55.ret : null)); 

            	        }
            	        break;

            	}

            	END_OF_STATEMENT56=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment586); 
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
    // spinach.g:105:1: addition returns [AdditionOperationElement ret] : el1= var_int_or_double_literal '+' el2= var_int_or_double_literal ;
    public spinachParser.addition_return addition() // throws RecognitionException [1]
    {   
        spinachParser.addition_return retval = new spinachParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal57 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;

        spinachParser.var_int_or_double_literal_return el2 = null;


        object char_literal57_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // spinach.g:109:3: (el1= var_int_or_double_literal '+' el2= var_int_or_double_literal )
            // spinach.g:109:5: el1= var_int_or_double_literal '+' el2= var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_int_or_double_literal_in_addition607);
            	el1 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal57=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition616); 
            		char_literal57_tree = (object)adaptor.Create(char_literal57);
            		adaptor.AddChild(root_0, char_literal57_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_addition626);
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
    // spinach.g:115:1: structdec returns [StructDeclaration ret] : ( 'Struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT ;
    public spinachParser.structdec_return structdec() // throws RecognitionException [1]
    {   
        spinachParser.structdec_return retval = new spinachParser.structdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal58 = null;
        IToken char_literal60 = null;
        IToken char_literal61 = null;
        IToken END_OF_STATEMENT62 = null;
        spinachParser.scalarvardec_return el1 = null;

        spinachParser.variable_return variable59 = null;


        object string_literal58_tree=null;
        object char_literal60_tree=null;
        object char_literal61_tree=null;
        object END_OF_STATEMENT62_tree=null;


        retval.ret = new StructDeclaration();

        try 
    	{
            // spinach.g:119:1: ( ( 'Struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT )
            // spinach.g:119:3: ( 'Struct' variable '{' (el1= scalarvardec )+ '}' ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:119:3: ( 'Struct' variable '{' (el1= scalarvardec )+ '}' )
            	// spinach.g:119:4: 'Struct' variable '{' (el1= scalarvardec )+ '}'
            	{
            		string_literal58=(IToken)Match(input,30,FOLLOW_30_in_structdec657); 
            			string_literal58_tree = (object)adaptor.Create(string_literal58);
            			adaptor.AddChild(root_0, string_literal58_tree);

            		PushFollow(FOLLOW_variable_in_structdec659);
            		variable59 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable59.Tree);
            		 retval.ret.setName(((variable59 != null) ? variable59.ret : null));
            		char_literal60=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_structdec663); 
            			char_literal60_tree = (object)adaptor.Create(char_literal60);
            			adaptor.AddChild(root_0, char_literal60_tree);

            		// spinach.g:120:5: (el1= scalarvardec )+
            		int cnt11 = 0;
            		do 
            		{
            		    int alt11 = 2;
            		    int LA11_0 = input.LA(1);

            		    if ( (LA11_0 == VARTYPE || LA11_0 == STRINGTYPE) )
            		    {
            		        alt11 = 1;
            		    }


            		    switch (alt11) 
            			{
            				case 1 :
            				    // spinach.g:120:6: el1= scalarvardec
            				    {
            				    	PushFollow(FOLLOW_scalarvardec_in_structdec668);
            				    	el1 = scalarvardec();
            				    	state.followingStackPointer--;

            				    	adaptor.AddChild(root_0, el1.Tree);
            				    	 retval.ret.setVarType(((el1 != null) ? el1.ret : null));

            				    }
            				    break;

            				default:
            				    if ( cnt11 >= 1 ) goto loop11;
            			            EarlyExitException eee11 =
            			                new EarlyExitException(11, input);
            			            throw eee11;
            		    }
            		    cnt11++;
            		} while (true);

            		loop11:
            			;	// Stops C# compiler whining that label 'loop11' has no statements

            		char_literal61=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_structdec674); 
            			char_literal61_tree = (object)adaptor.Create(char_literal61);
            			adaptor.AddChild(root_0, char_literal61_tree);


            	}

            	END_OF_STATEMENT62=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structdec676); 
            		END_OF_STATEMENT62_tree = (object)adaptor.Create(END_OF_STATEMENT62);
            		adaptor.AddChild(root_0, END_OF_STATEMENT62_tree);


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
    // spinach.g:123:1: scalarvardec returns [ScalarVariableDeclaration ret] : ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT ;
    public spinachParser.scalarvardec_return scalarvardec() // throws RecognitionException [1]
    {   
        spinachParser.scalarvardec_return retval = new spinachParser.scalarvardec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE63 = null;
        IToken STRINGTYPE64 = null;
        IToken END_OF_STATEMENT66 = null;
        spinachParser.variable_return variable65 = null;


        object VARTYPE63_tree=null;
        object STRINGTYPE64_tree=null;
        object END_OF_STATEMENT66_tree=null;


        	retval.ret = new ScalarVariableDeclaration();
        	
        try 
    	{
            // spinach.g:127:2: ( ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT )
            // spinach.g:127:3: ( ( VARTYPE | STRINGTYPE ) variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:127:3: ( ( VARTYPE | STRINGTYPE ) variable )
            	// spinach.g:127:4: ( VARTYPE | STRINGTYPE ) variable
            	{
            		// spinach.g:127:4: ( VARTYPE | STRINGTYPE )
            		int alt12 = 2;
            		int LA12_0 = input.LA(1);

            		if ( (LA12_0 == VARTYPE) )
            		{
            		    alt12 = 1;
            		}
            		else if ( (LA12_0 == STRINGTYPE) )
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
            		        // spinach.g:127:5: VARTYPE
            		        {
            		        	VARTYPE63=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_scalarvardec697); 
            		        		VARTYPE63_tree = (object)adaptor.Create(VARTYPE63);
            		        		adaptor.AddChild(root_0, VARTYPE63_tree);

            		        	 retval.ret.setType(((VARTYPE63 != null) ? VARTYPE63.Text : null));

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:128:4: STRINGTYPE
            		        {
            		        	STRINGTYPE64=(IToken)Match(input,STRINGTYPE,FOLLOW_STRINGTYPE_in_scalarvardec704); 
            		        		STRINGTYPE64_tree = (object)adaptor.Create(STRINGTYPE64);
            		        		adaptor.AddChild(root_0, STRINGTYPE64_tree);

            		        	 retval.ret.setType(((STRINGTYPE64 != null) ? STRINGTYPE64.Text : null));

            		        }
            		        break;

            		}

            		PushFollow(FOLLOW_variable_in_scalarvardec711);
            		variable65 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable65.Tree);
            		 retval.ret.setVar(((variable65 != null) ? variable65.ret : null));

            	}

            	END_OF_STATEMENT66=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_scalarvardec715); 
            		END_OF_STATEMENT66_tree = (object)adaptor.Create(END_OF_STATEMENT66);
            		adaptor.AddChild(root_0, END_OF_STATEMENT66_tree);


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
    // spinach.g:131:1: structobjdec returns [StructObjectDeclaration ret] : (el1= variable el2= variable ) END_OF_STATEMENT ;
    public spinachParser.structobjdec_return structobjdec() // throws RecognitionException [1]
    {   
        spinachParser.structobjdec_return retval = new spinachParser.structobjdec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken END_OF_STATEMENT67 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object END_OF_STATEMENT67_tree=null;


        retval.ret = new StructObjectDeclaration();

        try 
    	{
            // spinach.g:135:1: ( (el1= variable el2= variable ) END_OF_STATEMENT )
            // spinach.g:135:3: (el1= variable el2= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:135:3: (el1= variable el2= variable )
            	// spinach.g:135:4: el1= variable el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structobjdec736);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setStructName(((el1 != null) ? el1.ret : null));
            		PushFollow(FOLLOW_variable_in_structobjdec743);
            		el2 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setObjName(((el2 != null) ? el2.ret : null));

            	}

            	END_OF_STATEMENT67=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_structobjdec749); 
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
    // spinach.g:139:1: structassign returns [StructAssignDeclaration ret] : (el1= variable '.' el2= variable ) ;
    public spinachParser.structassign_return structassign() // throws RecognitionException [1]
    {   
        spinachParser.structassign_return retval = new spinachParser.structassign_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal68 = null;
        spinachParser.variable_return el1 = null;

        spinachParser.variable_return el2 = null;


        object char_literal68_tree=null;


        retval.ret = new StructAssignDeclaration();

        try 
    	{
            // spinach.g:143:1: ( (el1= variable '.' el2= variable ) )
            // spinach.g:143:2: (el1= variable '.' el2= variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:143:2: (el1= variable '.' el2= variable )
            	// spinach.g:143:3: el1= variable '.' el2= variable
            	{
            		PushFollow(FOLLOW_variable_in_structassign769);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		retval.ret.setName(((el1 != null) ? el1.ret : null));
            		char_literal68=(IToken)Match(input,DOT,FOLLOW_DOT_in_structassign772); 
            			char_literal68_tree = (object)adaptor.Create(char_literal68);
            			adaptor.AddChild(root_0, char_literal68_tree);

            		PushFollow(FOLLOW_variable_in_structassign775);
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
    // spinach.g:145:1: deletionofvar returns [DeleteVariable ret] : ( 'delete' el1= variable ) END_OF_STATEMENT ;
    public spinachParser.deletionofvar_return deletionofvar() // throws RecognitionException [1]
    {   
        spinachParser.deletionofvar_return retval = new spinachParser.deletionofvar_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal69 = null;
        IToken END_OF_STATEMENT70 = null;
        spinachParser.variable_return el1 = null;


        object string_literal69_tree=null;
        object END_OF_STATEMENT70_tree=null;


        retval.ret = new DeleteVariable();

        try 
    	{
            // spinach.g:149:1: ( ( 'delete' el1= variable ) END_OF_STATEMENT )
            // spinach.g:149:2: ( 'delete' el1= variable ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:149:2: ( 'delete' el1= variable )
            	// spinach.g:149:3: 'delete' el1= variable
            	{
            		string_literal69=(IToken)Match(input,31,FOLLOW_31_in_deletionofvar795); 
            			string_literal69_tree = (object)adaptor.Create(string_literal69);
            			adaptor.AddChild(root_0, string_literal69_tree);

            		PushFollow(FOLLOW_variable_in_deletionofvar799);
            		el1 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setVar(((el1 != null) ? el1.ret : null));

            	}

            	END_OF_STATEMENT70=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_deletionofvar803); 
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
    // spinach.g:151:1: print returns [PrintOperationElement ret] : 'print' var_int_or_double_literal END_OF_STATEMENT ;
    public spinachParser.print_return print() // throws RecognitionException [1]
    {   
        spinachParser.print_return retval = new spinachParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal71 = null;
        IToken END_OF_STATEMENT73 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal72 = null;


        object string_literal71_tree=null;
        object END_OF_STATEMENT73_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // spinach.g:155:3: ( 'print' var_int_or_double_literal END_OF_STATEMENT )
            // spinach.g:155:5: 'print' var_int_or_double_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal71=(IToken)Match(input,32,FOLLOW_32_in_print822); 
            		string_literal71_tree = (object)adaptor.Create(string_literal71);
            		adaptor.AddChild(root_0, string_literal71_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_print824);
            	var_int_or_double_literal72 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal72.Tree);
            	retval.ret.setChildElement(((var_int_or_double_literal72 != null) ? var_int_or_double_literal72.ret : null)); 
            	END_OF_STATEMENT73=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print832); 
            		END_OF_STATEMENT73_tree = (object)adaptor.Create(END_OF_STATEMENT73);
            		adaptor.AddChild(root_0, END_OF_STATEMENT73_tree);


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
    // spinach.g:159:1: parallelfor returns [ParallelForElement ret] : 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr1 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS ;
    public spinachParser.parallelfor_return parallelfor() // throws RecognitionException [1]
    {   
        spinachParser.parallelfor_return retval = new spinachParser.parallelfor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal74 = null;
        IToken LEFTPARANTHESIS75 = null;
        IToken string_literal76 = null;
        IToken END_OF_STATEMENT77 = null;
        IToken RIGHTPARANTHESIS78 = null;
        spinachParser.range_return r11 = null;

        spinachParser.expr1_return e11 = null;


        object string_literal74_tree=null;
        object LEFTPARANTHESIS75_tree=null;
        object string_literal76_tree=null;
        object END_OF_STATEMENT77_tree=null;
        object RIGHTPARANTHESIS78_tree=null;


          retval.ret = new ParallelForElement();

        try 
    	{
            // spinach.g:162:2: ( 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr1 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS )
            // spinach.g:162:4: 'parallelfor' r11= range LEFTPARANTHESIS ( (e11= expr1 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal74=(IToken)Match(input,33,FOLLOW_33_in_parallelfor854); 
            		string_literal74_tree = (object)adaptor.Create(string_literal74);
            		adaptor.AddChild(root_0, string_literal74_tree);

            	PushFollow(FOLLOW_range_in_parallelfor860);
            	r11 = range();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGE = ((r11 != null) ? r11.ret : null);
            	LEFTPARANTHESIS75=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_parallelfor863); 
            		LEFTPARANTHESIS75_tree = (object)adaptor.Create(LEFTPARANTHESIS75);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS75_tree);

            	// spinach.g:162:79: ( (e11= expr1 )+ ( ( 'SYNC' END_OF_STATEMENT ) | ) )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == VARIABLE || LA15_0 == VARTYPE || LA15_0 == STRINGTYPE || LA15_0 == 23 || (LA15_0 >= 29 && LA15_0 <= 32) || LA15_0 == 36 || (LA15_0 >= 38 && LA15_0 <= 46)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // spinach.g:162:80: (e11= expr1 )+ ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    {
            			    	// spinach.g:162:80: (e11= expr1 )+
            			    	int cnt13 = 0;
            			    	do 
            			    	{
            			    	    int alt13 = 2;
            			    	    alt13 = dfa13.Predict(input);
            			    	    switch (alt13) 
            			    		{
            			    			case 1 :
            			    			    // spinach.g:162:81: e11= expr1
            			    			    {
            			    			    	PushFollow(FOLLOW_expr1_in_parallelfor870);
            			    			    	e11 = expr1();
            			    			    	state.followingStackPointer--;

            			    			    	adaptor.AddChild(root_0, e11.Tree);
            			    			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

            			    			    }
            			    			    break;

            			    			default:
            			    			    if ( cnt13 >= 1 ) goto loop13;
            			    		            EarlyExitException eee13 =
            			    		                new EarlyExitException(13, input);
            			    		            throw eee13;
            			    	    }
            			    	    cnt13++;
            			    	} while (true);

            			    	loop13:
            			    		;	// Stops C# compiler whining that label 'loop13' has no statements

            			    	// spinach.g:162:123: ( ( 'SYNC' END_OF_STATEMENT ) | )
            			    	int alt14 = 2;
            			    	int LA14_0 = input.LA(1);

            			    	if ( (LA14_0 == 34) )
            			    	{
            			    	    alt14 = 1;
            			    	}
            			    	else if ( (LA14_0 == VARIABLE || LA14_0 == VARTYPE || LA14_0 == STRINGTYPE || LA14_0 == RIGHTPARANTHESIS || LA14_0 == 23 || (LA14_0 >= 29 && LA14_0 <= 32) || LA14_0 == 36 || (LA14_0 >= 38 && LA14_0 <= 46)) )
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
            			    	        // spinach.g:162:124: ( 'SYNC' END_OF_STATEMENT )
            			    	        {
            			    	        	// spinach.g:162:124: ( 'SYNC' END_OF_STATEMENT )
            			    	        	// spinach.g:162:125: 'SYNC' END_OF_STATEMENT
            			    	        	{
            			    	        		string_literal76=(IToken)Match(input,34,FOLLOW_34_in_parallelfor876); 
            			    	        			string_literal76_tree = (object)adaptor.Create(string_literal76);
            			    	        			adaptor.AddChild(root_0, string_literal76_tree);

            			    	        		retval.ret.syncfunction();
            			    	        		END_OF_STATEMENT77=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_parallelfor879); 
            			    	        			END_OF_STATEMENT77_tree = (object)adaptor.Create(END_OF_STATEMENT77);
            			    	        			adaptor.AddChild(root_0, END_OF_STATEMENT77_tree);


            			    	        	}


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // spinach.g:162:178: 
            			    	        {
            			    	        	retval.ret.syncfunction();

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    if ( cnt15 >= 1 ) goto loop15;
            		            EarlyExitException eee15 =
            		                new EarlyExitException(15, input);
            		            throw eee15;
            	    }
            	    cnt15++;
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	RIGHTPARANTHESIS78=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_parallelfor887); 
            		RIGHTPARANTHESIS78_tree = (object)adaptor.Create(RIGHTPARANTHESIS78);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS78_tree);


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
    // spinach.g:165:1: range returns [RangeElement ret] : LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE ;
    public spinachParser.range_return range() // throws RecognitionException [1]
    {   
        spinachParser.range_return retval = new spinachParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LEFTBRACE79 = null;
        IToken POINT80 = null;
        IToken string_literal81 = null;
        IToken RIGHTBRACE82 = null;
        spinachParser.variable_return e11 = null;

        spinachParser.int_literal_return e12 = null;

        spinachParser.int_literal_return e13 = null;


        object LEFTBRACE79_tree=null;
        object POINT80_tree=null;
        object string_literal81_tree=null;
        object RIGHTBRACE82_tree=null;


          retval.ret= new RangeElement();

        try 
    	{
            // spinach.g:168:2: ( LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE )
            // spinach.g:168:3: LEFTBRACE e11= variable POINT e12= int_literal 'to' e13= int_literal RIGHTBRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LEFTBRACE79=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_range901); 
            		LEFTBRACE79_tree = (object)adaptor.Create(LEFTBRACE79);
            		adaptor.AddChild(root_0, LEFTBRACE79_tree);

            	PushFollow(FOLLOW_variable_in_range907);
            	e11 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e11.Tree);
            	retval.ret.RANGEVARIABLE = ((e11 != null) ? e11.ret : null);
            	POINT80=(IToken)Match(input,POINT,FOLLOW_POINT_in_range910); 
            		POINT80_tree = (object)adaptor.Create(POINT80);
            		adaptor.AddChild(root_0, POINT80_tree);

            	PushFollow(FOLLOW_int_literal_in_range916);
            	e12 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e12.Tree);
            	retval.ret.STARTINGRANGE = ((e12 != null) ? e12.ret : null);
            	string_literal81=(IToken)Match(input,35,FOLLOW_35_in_range919); 
            		string_literal81_tree = (object)adaptor.Create(string_literal81);
            		adaptor.AddChild(root_0, string_literal81_tree);

            	PushFollow(FOLLOW_int_literal_in_range924);
            	e13 = int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e13.Tree);
            	retval.ret.ENDINGRANGE = ((e13 != null) ? e13.ret : null);
            	RIGHTBRACE82=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_range927); 
            		RIGHTBRACE82_tree = (object)adaptor.Create(RIGHTBRACE82);
            		adaptor.AddChild(root_0, RIGHTBRACE82_tree);


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
    // spinach.g:176:1: ifelse returns [IfStatementElement ret] : ( 'if' LEFTBRACE ( equality | nonequality ) RIGHTBRACE LEFTPARANTHESIS ( (e11= program ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= program ) | ) RIGHTPARANTHESIS )? ;
    public spinachParser.ifelse_return ifelse() // throws RecognitionException [1]
    {   
        spinachParser.ifelse_return retval = new spinachParser.ifelse_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal83 = null;
        IToken LEFTBRACE84 = null;
        IToken RIGHTBRACE87 = null;
        IToken LEFTPARANTHESIS88 = null;
        IToken RIGHTPARANTHESIS89 = null;
        IToken string_literal90 = null;
        IToken LEFTPARANTHESIS91 = null;
        IToken RIGHTPARANTHESIS92 = null;
        spinachParser.program_return e11 = null;

        spinachParser.program_return e12 = null;

        spinachParser.equality_return equality85 = null;

        spinachParser.nonequality_return nonequality86 = null;


        object string_literal83_tree=null;
        object LEFTBRACE84_tree=null;
        object RIGHTBRACE87_tree=null;
        object LEFTPARANTHESIS88_tree=null;
        object RIGHTPARANTHESIS89_tree=null;
        object string_literal90_tree=null;
        object LEFTPARANTHESIS91_tree=null;
        object RIGHTPARANTHESIS92_tree=null;


           retval.ret = new IfStatementElement();

        try 
    	{
            // spinach.g:180:1: ( ( 'if' LEFTBRACE ( equality | nonequality ) RIGHTBRACE LEFTPARANTHESIS ( (e11= program ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= program ) | ) RIGHTPARANTHESIS )? )
            // spinach.g:180:2: ( 'if' LEFTBRACE ( equality | nonequality ) RIGHTBRACE LEFTPARANTHESIS ( (e11= program ) | ) RIGHTPARANTHESIS ) ( 'else' LEFTPARANTHESIS ( (e12= program ) | ) RIGHTPARANTHESIS )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:180:2: ( 'if' LEFTBRACE ( equality | nonequality ) RIGHTBRACE LEFTPARANTHESIS ( (e11= program ) | ) RIGHTPARANTHESIS )
            	// spinach.g:180:3: 'if' LEFTBRACE ( equality | nonequality ) RIGHTBRACE LEFTPARANTHESIS ( (e11= program ) | ) RIGHTPARANTHESIS
            	{
            		string_literal83=(IToken)Match(input,36,FOLLOW_36_in_ifelse949); 
            			string_literal83_tree = (object)adaptor.Create(string_literal83);
            			adaptor.AddChild(root_0, string_literal83_tree);

            		LEFTBRACE84=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_ifelse951); 
            			LEFTBRACE84_tree = (object)adaptor.Create(LEFTBRACE84);
            			adaptor.AddChild(root_0, LEFTBRACE84_tree);

            		// spinach.g:180:18: ( equality | nonequality )
            		int alt16 = 2;
            		int LA16_0 = input.LA(1);

            		if ( (LA16_0 == VARIABLE) )
            		{
            		    int LA16_1 = input.LA(2);

            		    if ( (LA16_1 == EQUALITYEXPRESSION) )
            		    {
            		        alt16 = 1;
            		    }
            		    else if ( (LA16_1 == NONEQUALITYEXPRESSION) )
            		    {
            		        alt16 = 2;
            		    }
            		    else 
            		    {
            		        NoViableAltException nvae_d16s1 =
            		            new NoViableAltException("", 16, 1, input);

            		        throw nvae_d16s1;
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
            		        // spinach.g:180:19: equality
            		        {
            		        	PushFollow(FOLLOW_equality_in_ifelse954);
            		        	equality85 = equality();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, equality85.Tree);
            		        	retval.ret.CONDITION = ((equality85 != null) ? equality85.ret : null);

            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:180:67: nonequality
            		        {
            		        	PushFollow(FOLLOW_nonequality_in_ifelse957);
            		        	nonequality86 = nonequality();
            		        	state.followingStackPointer--;

            		        	adaptor.AddChild(root_0, nonequality86.Tree);
            		        	retval.ret.CONDITION = ((nonequality86 != null) ? nonequality86.ret : null);

            		        }
            		        break;

            		}

            		RIGHTBRACE87=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_ifelse961); 
            			RIGHTBRACE87_tree = (object)adaptor.Create(RIGHTBRACE87);
            			adaptor.AddChild(root_0, RIGHTBRACE87_tree);

            		LEFTPARANTHESIS88=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse963); 
            			LEFTPARANTHESIS88_tree = (object)adaptor.Create(LEFTPARANTHESIS88);
            			adaptor.AddChild(root_0, LEFTPARANTHESIS88_tree);

            		// spinach.g:180:149: ( (e11= program ) | )
            		int alt17 = 2;
            		int LA17_0 = input.LA(1);

            		if ( (LA17_0 == VARIABLE || LA17_0 == VARTYPE || LA17_0 == STRINGTYPE || LA17_0 == 23 || (LA17_0 >= 29 && LA17_0 <= 33) || LA17_0 == 36 || (LA17_0 >= 38 && LA17_0 <= 46)) )
            		{
            		    alt17 = 1;
            		}
            		else if ( (LA17_0 == RIGHTPARANTHESIS) )
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
            		        // spinach.g:180:150: (e11= program )
            		        {
            		        	// spinach.g:180:150: (e11= program )
            		        	// spinach.g:180:151: e11= program
            		        	{
            		        		PushFollow(FOLLOW_program_in_ifelse971);
            		        		e11 = program();
            		        		state.followingStackPointer--;

            		        		adaptor.AddChild(root_0, e11.Tree);
            		        		retval.ret.IFCODE = ((e11 != null) ? e11.ret : null);

            		        	}


            		        }
            		        break;
            		    case 2 :
            		        // spinach.g:180:197: 
            		        {
            		        }
            		        break;

            		}

            		RIGHTPARANTHESIS89=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse976); 
            			RIGHTPARANTHESIS89_tree = (object)adaptor.Create(RIGHTPARANTHESIS89);
            			adaptor.AddChild(root_0, RIGHTPARANTHESIS89_tree);


            	}

            	// spinach.g:180:215: ( 'else' LEFTPARANTHESIS ( (e12= program ) | ) RIGHTPARANTHESIS )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 37) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // spinach.g:180:216: 'else' LEFTPARANTHESIS ( (e12= program ) | ) RIGHTPARANTHESIS
            	        {
            	        	string_literal90=(IToken)Match(input,37,FOLLOW_37_in_ifelse979); 
            	        		string_literal90_tree = (object)adaptor.Create(string_literal90);
            	        		adaptor.AddChild(root_0, string_literal90_tree);

            	        	LEFTPARANTHESIS91=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_ifelse982); 
            	        		LEFTPARANTHESIS91_tree = (object)adaptor.Create(LEFTPARANTHESIS91);
            	        		adaptor.AddChild(root_0, LEFTPARANTHESIS91_tree);

            	        	// spinach.g:180:240: ( (e12= program ) | )
            	        	int alt18 = 2;
            	        	int LA18_0 = input.LA(1);

            	        	if ( (LA18_0 == VARIABLE || LA18_0 == VARTYPE || LA18_0 == STRINGTYPE || LA18_0 == 23 || (LA18_0 >= 29 && LA18_0 <= 33) || LA18_0 == 36 || (LA18_0 >= 38 && LA18_0 <= 46)) )
            	        	{
            	        	    alt18 = 1;
            	        	}
            	        	else if ( (LA18_0 == RIGHTPARANTHESIS) )
            	        	{
            	        	    alt18 = 2;
            	        	}
            	        	else 
            	        	{
            	        	    NoViableAltException nvae_d18s0 =
            	        	        new NoViableAltException("", 18, 0, input);

            	        	    throw nvae_d18s0;
            	        	}
            	        	switch (alt18) 
            	        	{
            	        	    case 1 :
            	        	        // spinach.g:180:241: (e12= program )
            	        	        {
            	        	        	// spinach.g:180:241: (e12= program )
            	        	        	// spinach.g:180:242: e12= program
            	        	        	{
            	        	        		PushFollow(FOLLOW_program_in_ifelse991);
            	        	        		e12 = program();
            	        	        		state.followingStackPointer--;

            	        	        		adaptor.AddChild(root_0, e12.Tree);
            	        	        		retval.ret.ELSECODE = ((e12 != null) ? e12.ret : null);

            	        	        	}


            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // spinach.g:180:291: 
            	        	        {
            	        	        }
            	        	        break;

            	        	}

            	        	RIGHTPARANTHESIS92=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_ifelse997); 
            	        		RIGHTPARANTHESIS92_tree = (object)adaptor.Create(RIGHTPARANTHESIS92);
            	        		adaptor.AddChild(root_0, RIGHTPARANTHESIS92_tree);


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
    // spinach.g:182:1: forstatement returns [ForStatementElement ret] : 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS ;
    public spinachParser.forstatement_return forstatement() // throws RecognitionException [1]
    {   
        spinachParser.forstatement_return retval = new spinachParser.forstatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal93 = null;
        IToken LEFTPARANTHESIS94 = null;
        IToken RIGHTPARANTHESIS95 = null;
        spinachParser.range_return r11 = null;

        spinachParser.expr1_return e11 = null;


        object string_literal93_tree=null;
        object LEFTPARANTHESIS94_tree=null;
        object RIGHTPARANTHESIS95_tree=null;


           retval.ret = new ForStatementElement();

        try 
    	{
            // spinach.g:185:2: ( 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS )
            // spinach.g:185:3: 'for' r11= range LEFTPARANTHESIS (e11= expr1 )+ RIGHTPARANTHESIS
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal93=(IToken)Match(input,38,FOLLOW_38_in_forstatement1014); 
            		string_literal93_tree = (object)adaptor.Create(string_literal93);
            		adaptor.AddChild(root_0, string_literal93_tree);

            	PushFollow(FOLLOW_range_in_forstatement1019);
            	r11 = range();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, r11.Tree);
            	retval.ret.RANGE = ((r11 != null) ? r11.ret : null);
            	LEFTPARANTHESIS94=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_forstatement1022); 
            		LEFTPARANTHESIS94_tree = (object)adaptor.Create(LEFTPARANTHESIS94);
            		adaptor.AddChild(root_0, LEFTPARANTHESIS94_tree);

            	// spinach.g:185:66: (e11= expr1 )+
            	int cnt20 = 0;
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == VARIABLE || LA20_0 == VARTYPE || LA20_0 == STRINGTYPE || LA20_0 == 23 || (LA20_0 >= 29 && LA20_0 <= 32) || LA20_0 == 36 || (LA20_0 >= 38 && LA20_0 <= 46)) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // spinach.g:185:67: e11= expr1
            			    {
            			    	PushFollow(FOLLOW_expr1_in_forstatement1027);
            			    	e11 = expr1();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e11.Tree);
            			    	retval.ret.ADDCODE =((e11 != null) ? e11.ret : null);

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

            	RIGHTPARANTHESIS95=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_forstatement1032); 
            		RIGHTPARANTHESIS95_tree = (object)adaptor.Create(RIGHTPARANTHESIS95);
            		adaptor.AddChild(root_0, RIGHTPARANTHESIS95_tree);


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
    // spinach.g:188:4: functioncall returns [FunctionCallElement ret] : variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT ;
    public spinachParser.functioncall_return functioncall() // throws RecognitionException [1]
    {   
        spinachParser.functioncall_return retval = new spinachParser.functioncall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal97 = null;
        IToken char_literal98 = null;
        IToken char_literal99 = null;
        IToken END_OF_STATEMENT100 = null;
        spinachParser.var_int_or_double_literal_return el1 = null;

        spinachParser.var_int_or_double_literal_return el2 = null;

        spinachParser.variable_return variable96 = null;


        object char_literal97_tree=null;
        object char_literal98_tree=null;
        object char_literal99_tree=null;
        object END_OF_STATEMENT100_tree=null;

         retval.ret = new FunctionCallElement();
         
        try 
    	{
            // spinach.g:191:3: ( variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT )
            // spinach.g:191:4: variable '(' (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )? ')' END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_functioncall1057);
            	variable96 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable96.Tree);
            	retval.ret.setfunctioncallname(((variable96 != null) ? variable96.ret : null));
            	char_literal97=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functioncall1062); 
            		char_literal97_tree = (object)adaptor.Create(char_literal97);
            		adaptor.AddChild(root_0, char_literal97_tree);

            	// spinach.g:192:6: (el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )* )?
            	int alt22 = 2;
            	int LA22_0 = input.LA(1);

            	if ( ((LA22_0 >= VARIABLE && LA22_0 <= DOUBLE_LITERAL)) )
            	{
            	    alt22 = 1;
            	}
            	switch (alt22) 
            	{
            	    case 1 :
            	        // spinach.g:192:7: el1= var_int_or_double_literal ( ',' el2= var_int_or_double_literal )*
            	        {
            	        	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1066);
            	        	el1 = var_int_or_double_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, el1.Tree);
            	        	retval.ret.setparameters(((el1 != null) ? el1.ret : null));
            	        	// spinach.g:192:74: ( ',' el2= var_int_or_double_literal )*
            	        	do 
            	        	{
            	        	    int alt21 = 2;
            	        	    int LA21_0 = input.LA(1);

            	        	    if ( (LA21_0 == 28) )
            	        	    {
            	        	        alt21 = 1;
            	        	    }


            	        	    switch (alt21) 
            	        		{
            	        			case 1 :
            	        			    // spinach.g:192:75: ',' el2= var_int_or_double_literal
            	        			    {
            	        			    	char_literal98=(IToken)Match(input,28,FOLLOW_28_in_functioncall1070); 
            	        			    		char_literal98_tree = (object)adaptor.Create(char_literal98);
            	        			    		adaptor.AddChild(root_0, char_literal98_tree);

            	        			    	PushFollow(FOLLOW_var_int_or_double_literal_in_functioncall1074);
            	        			    	el2 = var_int_or_double_literal();
            	        			    	state.followingStackPointer--;

            	        			    	adaptor.AddChild(root_0, el2.Tree);
            	        			    	retval.ret.setparameters(((el2 != null) ? el2.ret : null));

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop21;
            	        	    }
            	        	} while (true);

            	        	loop21:
            	        		;	// Stops C# compiler whining that label 'loop21' has no statements


            	        }
            	        break;

            	}

            	char_literal99=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functioncall1081); 
            		char_literal99_tree = (object)adaptor.Create(char_literal99);
            		adaptor.AddChild(root_0, char_literal99_tree);

            	END_OF_STATEMENT100=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functioncall1085); 
            		END_OF_STATEMENT100_tree = (object)adaptor.Create(END_OF_STATEMENT100);
            		adaptor.AddChild(root_0, END_OF_STATEMENT100_tree);


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
    // spinach.g:197:1: equality returns [EqualityOperationElement ret] : variable EQUALITYEXPRESSION var_int_or_double_literal ;
    public spinachParser.equality_return equality() // throws RecognitionException [1]
    {   
        spinachParser.equality_return retval = new spinachParser.equality_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EQUALITYEXPRESSION102 = null;
        spinachParser.variable_return variable101 = null;

        spinachParser.var_int_or_double_literal_return var_int_or_double_literal103 = null;


        object EQUALITYEXPRESSION102_tree=null;


          retval.ret = new EqualityOperationElement();

        try 
    	{
            // spinach.g:203:1: ( variable EQUALITYEXPRESSION var_int_or_double_literal )
            // spinach.g:203:3: variable EQUALITYEXPRESSION var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_equality1110);
            	variable101 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable101.Tree);
            	retval.ret.setequalityLhs(((variable101 != null) ? variable101.ret : null)); 
            	EQUALITYEXPRESSION102=(IToken)Match(input,EQUALITYEXPRESSION,FOLLOW_EQUALITYEXPRESSION_in_equality1119); 
            		EQUALITYEXPRESSION102_tree = (object)adaptor.Create(EQUALITYEXPRESSION102);
            		adaptor.AddChild(root_0, EQUALITYEXPRESSION102_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_equality1129);
            	var_int_or_double_literal103 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal103.Tree);
            	retval.ret.setequalityRhs(((var_int_or_double_literal103 != null) ? var_int_or_double_literal103.ret : null)); 

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
    // spinach.g:209:1: nonequality returns [NonEqualityOperationElement ret] : variable NONEQUALITYEXPRESSION var_int_or_double_literal ;
    public spinachParser.nonequality_return nonequality() // throws RecognitionException [1]
    {   
        spinachParser.nonequality_return retval = new spinachParser.nonequality_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NONEQUALITYEXPRESSION105 = null;
        spinachParser.variable_return variable104 = null;

        spinachParser.var_int_or_double_literal_return var_int_or_double_literal106 = null;


        object NONEQUALITYEXPRESSION105_tree=null;


          retval.ret = new NonEqualityOperationElement();

        try 
    	{
            // spinach.g:215:1: ( variable NONEQUALITYEXPRESSION var_int_or_double_literal )
            // spinach.g:215:3: variable NONEQUALITYEXPRESSION var_int_or_double_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_nonequality1168);
            	variable104 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable104.Tree);
            	retval.ret.setnonequalityLhs(((variable104 != null) ? variable104.ret : null)); 
            	NONEQUALITYEXPRESSION105=(IToken)Match(input,NONEQUALITYEXPRESSION,FOLLOW_NONEQUALITYEXPRESSION_in_nonequality1177); 
            		NONEQUALITYEXPRESSION105_tree = (object)adaptor.Create(NONEQUALITYEXPRESSION105);
            		adaptor.AddChild(root_0, NONEQUALITYEXPRESSION105_tree);

            	PushFollow(FOLLOW_var_int_or_double_literal_in_nonequality1182);
            	var_int_or_double_literal106 = var_int_or_double_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_int_or_double_literal106.Tree);
            	retval.ret.setnonequalityRhs(((var_int_or_double_literal106 != null) ? var_int_or_double_literal106.ret : null)); 

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
    // spinach.g:222:1: functiondefination returns [FunctionElement ret] : ( ( VARTYPE variable '(' ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+ '}' ) | 'void' variable '(' ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+ '}' );
    public spinachParser.functiondefination_return functiondefination() // throws RecognitionException [1]
    {   
        spinachParser.functiondefination_return retval = new spinachParser.functiondefination_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE107 = null;
        IToken char_literal109 = null;
        IToken char_literal110 = null;
        IToken char_literal111 = null;
        IToken char_literal112 = null;
        IToken char_literal122 = null;
        IToken string_literal123 = null;
        IToken char_literal125 = null;
        IToken char_literal126 = null;
        IToken char_literal127 = null;
        IToken char_literal128 = null;
        IToken char_literal138 = null;
        spinachParser.functiondeclaration_return e11 = null;

        spinachParser.functiondeclaration_return e12 = null;

        spinachParser.variable_return variable108 = null;

        spinachParser.assignment_return assignment113 = null;

        spinachParser.functioncall_return functioncall114 = null;

        spinachParser.scalarvardec_return scalarvardec115 = null;

        spinachParser.vectorvardec_return vectorvardec116 = null;

        spinachParser.matrixvardec_return matrixvardec117 = null;

        spinachParser.deletionofvar_return deletionofvar118 = null;

        spinachParser.print_return print119 = null;

        spinachParser.ifelse_return ifelse120 = null;

        spinachParser.functionreturn_return functionreturn121 = null;

        spinachParser.variable_return variable124 = null;

        spinachParser.assignment_return assignment129 = null;

        spinachParser.functioncall_return functioncall130 = null;

        spinachParser.scalarvardec_return scalarvardec131 = null;

        spinachParser.vectorvardec_return vectorvardec132 = null;

        spinachParser.matrixvardec_return matrixvardec133 = null;

        spinachParser.deletionofvar_return deletionofvar134 = null;

        spinachParser.print_return print135 = null;

        spinachParser.ifelse_return ifelse136 = null;

        spinachParser.functionreturn_return functionreturn137 = null;


        object VARTYPE107_tree=null;
        object char_literal109_tree=null;
        object char_literal110_tree=null;
        object char_literal111_tree=null;
        object char_literal112_tree=null;
        object char_literal122_tree=null;
        object string_literal123_tree=null;
        object char_literal125_tree=null;
        object char_literal126_tree=null;
        object char_literal127_tree=null;
        object char_literal128_tree=null;
        object char_literal138_tree=null;


        retval.ret = new FunctionElement();

        try 
    	{
            // spinach.g:227:1: ( ( VARTYPE variable '(' ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+ '}' ) | 'void' variable '(' ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+ '}' )
            int alt29 = 2;
            int LA29_0 = input.LA(1);

            if ( (LA29_0 == VARTYPE) )
            {
                alt29 = 1;
            }
            else if ( (LA29_0 == 39) )
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
                    // spinach.g:227:3: ( VARTYPE variable '(' ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+ '}' )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:227:3: ( VARTYPE variable '(' ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+ '}' )
                    	// spinach.g:227:4: VARTYPE variable '(' ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+ '}'
                    	{
                    		VARTYPE107=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_functiondefination1215); 
                    			VARTYPE107_tree = (object)adaptor.Create(VARTYPE107);
                    			adaptor.AddChild(root_0, VARTYPE107_tree);

                    		retval.ret.setreturntype(((VARTYPE107 != null) ? VARTYPE107.Text : null));
                    		PushFollow(FOLLOW_variable_in_functiondefination1220);
                    		variable108 = variable();
                    		state.followingStackPointer--;

                    		adaptor.AddChild(root_0, variable108.Tree);
                    		retval.ret.setfunctionname(((variable108 != null) ? variable108.ret : null));
                    		char_literal109=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1226); 
                    			char_literal109_tree = (object)adaptor.Create(char_literal109);
                    			adaptor.AddChild(root_0, char_literal109_tree);

                    		// spinach.g:230:2: ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? )
                    		// spinach.g:230:3: (e11= functiondeclaration ( ',' e12= functiondeclaration )* )?
                    		{
                    			// spinach.g:230:3: (e11= functiondeclaration ( ',' e12= functiondeclaration )* )?
                    			int alt24 = 2;
                    			int LA24_0 = input.LA(1);

                    			if ( (LA24_0 == VARTYPE) )
                    			{
                    			    alt24 = 1;
                    			}
                    			switch (alt24) 
                    			{
                    			    case 1 :
                    			        // spinach.g:230:4: e11= functiondeclaration ( ',' e12= functiondeclaration )*
                    			        {
                    			        	PushFollow(FOLLOW_functiondeclaration_in_functiondefination1234);
                    			        	e11 = functiondeclaration();
                    			        	state.followingStackPointer--;

                    			        	adaptor.AddChild(root_0, e11.Tree);
                    			        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    			        	// spinach.g:230:64: ( ',' e12= functiondeclaration )*
                    			        	do 
                    			        	{
                    			        	    int alt23 = 2;
                    			        	    int LA23_0 = input.LA(1);

                    			        	    if ( (LA23_0 == 28) )
                    			        	    {
                    			        	        alt23 = 1;
                    			        	    }


                    			        	    switch (alt23) 
                    			        		{
                    			        			case 1 :
                    			        			    // spinach.g:230:65: ',' e12= functiondeclaration
                    			        			    {
                    			        			    	char_literal110=(IToken)Match(input,28,FOLLOW_28_in_functiondefination1237); 
                    			        			    		char_literal110_tree = (object)adaptor.Create(char_literal110);
                    			        			    		adaptor.AddChild(root_0, char_literal110_tree);

                    			        			    	PushFollow(FOLLOW_functiondeclaration_in_functiondefination1242);
                    			        			    	e12 = functiondeclaration();
                    			        			    	state.followingStackPointer--;

                    			        			    	adaptor.AddChild(root_0, e12.Tree);
                    			        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    			        			    }
                    			        			    break;

                    			        			default:
                    			        			    goto loop23;
                    			        	    }
                    			        	} while (true);

                    			        	loop23:
                    			        		;	// Stops C# compiler whining that label 'loop23' has no statements


                    			        }
                    			        break;

                    			}


                    		}

                    		char_literal111=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1251); 
                    			char_literal111_tree = (object)adaptor.Create(char_literal111);
                    			adaptor.AddChild(root_0, char_literal111_tree);

                    		char_literal112=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1253); 
                    			char_literal112_tree = (object)adaptor.Create(char_literal112);
                    			adaptor.AddChild(root_0, char_literal112_tree);

                    		// spinach.g:232:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+
                    		int cnt25 = 0;
                    		do 
                    		{
                    		    int alt25 = 10;
                    		    alt25 = dfa25.Predict(input);
                    		    switch (alt25) 
                    			{
                    				case 1 :
                    				    // spinach.g:232:6: assignment
                    				    {
                    				    	PushFollow(FOLLOW_assignment_in_functiondefination1256);
                    				    	assignment113 = assignment();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, assignment113.Tree);
                    				    	retval.ret.setBody(((assignment113 != null) ? assignment113.ret : null));

                    				    }
                    				    break;
                    				case 2 :
                    				    // spinach.g:232:55: functioncall
                    				    {
                    				    	PushFollow(FOLLOW_functioncall_in_functiondefination1259);
                    				    	functioncall114 = functioncall();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, functioncall114.Tree);
                    				    	retval.ret.setBody(((functioncall114 != null) ? functioncall114.ret : null));

                    				    }
                    				    break;
                    				case 3 :
                    				    // spinach.g:232:109: scalarvardec
                    				    {
                    				    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1263);
                    				    	scalarvardec115 = scalarvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, scalarvardec115.Tree);
                    				    	 retval.ret.setBody(((scalarvardec115 != null) ? scalarvardec115.ret : null));

                    				    }
                    				    break;
                    				case 4 :
                    				    // spinach.g:233:5: vectorvardec
                    				    {
                    				    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1271);
                    				    	vectorvardec116 = vectorvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, vectorvardec116.Tree);
                    				    	 retval.ret.setBody(((vectorvardec116 != null) ? vectorvardec116.ret : null));

                    				    }
                    				    break;
                    				case 5 :
                    				    // spinach.g:234:5: matrixvardec
                    				    {
                    				    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1279);
                    				    	matrixvardec117 = matrixvardec();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, matrixvardec117.Tree);
                    				    	 retval.ret.setBody(((matrixvardec117 != null) ? matrixvardec117.ret : null));

                    				    }
                    				    break;
                    				case 6 :
                    				    // spinach.g:235:5: deletionofvar
                    				    {
                    				    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1287);
                    				    	deletionofvar118 = deletionofvar();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, deletionofvar118.Tree);
                    				    	 retval.ret.setBody(((deletionofvar118 != null) ? deletionofvar118.ret : null));

                    				    }
                    				    break;
                    				case 7 :
                    				    // spinach.g:235:64: print
                    				    {
                    				    	PushFollow(FOLLOW_print_in_functiondefination1293);
                    				    	print119 = print();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, print119.Tree);
                    				    	 retval.ret.setBody(((print119 != null) ? print119.ret : null)); 

                    				    }
                    				    break;
                    				case 8 :
                    				    // spinach.g:236:5: ifelse
                    				    {
                    				    	PushFollow(FOLLOW_ifelse_in_functiondefination1301);
                    				    	ifelse120 = ifelse();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, ifelse120.Tree);
                    				    	retval.ret.setBody(((ifelse120 != null) ? ifelse120.ret : null));

                    				    }
                    				    break;
                    				case 9 :
                    				    // spinach.g:236:47: functionreturn
                    				    {
                    				    	PushFollow(FOLLOW_functionreturn_in_functiondefination1305);
                    				    	functionreturn121 = functionreturn();
                    				    	state.followingStackPointer--;

                    				    	adaptor.AddChild(root_0, functionreturn121.Tree);
                    				    	retval.ret.setBody(((functionreturn121 != null) ? functionreturn121.ret : null));

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
                    			;	// Stops C# compiler whining that label 'loop25' has no statements

                    		char_literal122=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1310); 
                    			char_literal122_tree = (object)adaptor.Create(char_literal122);
                    			adaptor.AddChild(root_0, char_literal122_tree);


                    	}


                    }
                    break;
                case 2 :
                    // spinach.g:237:6: 'void' variable '(' ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? ) ')' '{' ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+ '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal123=(IToken)Match(input,39,FOLLOW_39_in_functiondefination1313); 
                    		string_literal123_tree = (object)adaptor.Create(string_literal123);
                    		adaptor.AddChild(root_0, string_literal123_tree);

                    	retval.ret.setreturntype("void");
                    	PushFollow(FOLLOW_variable_in_functiondefination1318);
                    	variable124 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable124.Tree);
                    	retval.ret.setfunctionname(((variable124 != null) ? variable124.ret : null));
                    	char_literal125=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_functiondefination1324); 
                    		char_literal125_tree = (object)adaptor.Create(char_literal125);
                    		adaptor.AddChild(root_0, char_literal125_tree);

                    	// spinach.g:240:2: ( (e11= functiondeclaration ( ',' e12= functiondeclaration )* )? )
                    	// spinach.g:240:3: (e11= functiondeclaration ( ',' e12= functiondeclaration )* )?
                    	{
                    		// spinach.g:240:3: (e11= functiondeclaration ( ',' e12= functiondeclaration )* )?
                    		int alt27 = 2;
                    		int LA27_0 = input.LA(1);

                    		if ( (LA27_0 == VARTYPE) )
                    		{
                    		    alt27 = 1;
                    		}
                    		switch (alt27) 
                    		{
                    		    case 1 :
                    		        // spinach.g:240:4: e11= functiondeclaration ( ',' e12= functiondeclaration )*
                    		        {
                    		        	PushFollow(FOLLOW_functiondeclaration_in_functiondefination1333);
                    		        	e11 = functiondeclaration();
                    		        	state.followingStackPointer--;

                    		        	adaptor.AddChild(root_0, e11.Tree);
                    		        	retval.ret.setArguments(((e11 != null) ? e11.ret : null));
                    		        	// spinach.g:240:65: ( ',' e12= functiondeclaration )*
                    		        	do 
                    		        	{
                    		        	    int alt26 = 2;
                    		        	    int LA26_0 = input.LA(1);

                    		        	    if ( (LA26_0 == 28) )
                    		        	    {
                    		        	        alt26 = 1;
                    		        	    }


                    		        	    switch (alt26) 
                    		        		{
                    		        			case 1 :
                    		        			    // spinach.g:240:66: ',' e12= functiondeclaration
                    		        			    {
                    		        			    	char_literal126=(IToken)Match(input,28,FOLLOW_28_in_functiondefination1336); 
                    		        			    		char_literal126_tree = (object)adaptor.Create(char_literal126);
                    		        			    		adaptor.AddChild(root_0, char_literal126_tree);

                    		        			    	PushFollow(FOLLOW_functiondeclaration_in_functiondefination1340);
                    		        			    	e12 = functiondeclaration();
                    		        			    	state.followingStackPointer--;

                    		        			    	adaptor.AddChild(root_0, e12.Tree);
                    		        			    	retval.ret.setArguments(((e12 != null) ? e12.ret : null));

                    		        			    }
                    		        			    break;

                    		        			default:
                    		        			    goto loop26;
                    		        	    }
                    		        	} while (true);

                    		        	loop26:
                    		        		;	// Stops C# compiler whining that label 'loop26' has no statements


                    		        }
                    		        break;

                    		}


                    	}

                    	char_literal127=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_functiondefination1349); 
                    		char_literal127_tree = (object)adaptor.Create(char_literal127);
                    		adaptor.AddChild(root_0, char_literal127_tree);

                    	char_literal128=(IToken)Match(input,LEFTPARANTHESIS,FOLLOW_LEFTPARANTHESIS_in_functiondefination1351); 
                    		char_literal128_tree = (object)adaptor.Create(char_literal128);
                    		adaptor.AddChild(root_0, char_literal128_tree);

                    	// spinach.g:242:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+
                    	int cnt28 = 0;
                    	do 
                    	{
                    	    int alt28 = 10;
                    	    alt28 = dfa28.Predict(input);
                    	    switch (alt28) 
                    		{
                    			case 1 :
                    			    // spinach.g:242:6: assignment
                    			    {
                    			    	PushFollow(FOLLOW_assignment_in_functiondefination1354);
                    			    	assignment129 = assignment();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, assignment129.Tree);
                    			    	retval.ret.setBody(((assignment129 != null) ? assignment129.ret : null));

                    			    }
                    			    break;
                    			case 2 :
                    			    // spinach.g:242:55: functioncall
                    			    {
                    			    	PushFollow(FOLLOW_functioncall_in_functiondefination1357);
                    			    	functioncall130 = functioncall();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, functioncall130.Tree);
                    			    	retval.ret.setBody(((functioncall130 != null) ? functioncall130.ret : null));

                    			    }
                    			    break;
                    			case 3 :
                    			    // spinach.g:242:109: scalarvardec
                    			    {
                    			    	PushFollow(FOLLOW_scalarvardec_in_functiondefination1361);
                    			    	scalarvardec131 = scalarvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, scalarvardec131.Tree);
                    			    	 retval.ret.setBody(((scalarvardec131 != null) ? scalarvardec131.ret : null));

                    			    }
                    			    break;
                    			case 4 :
                    			    // spinach.g:243:5: vectorvardec
                    			    {
                    			    	PushFollow(FOLLOW_vectorvardec_in_functiondefination1369);
                    			    	vectorvardec132 = vectorvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, vectorvardec132.Tree);
                    			    	 retval.ret.setBody(((vectorvardec132 != null) ? vectorvardec132.ret : null));

                    			    }
                    			    break;
                    			case 5 :
                    			    // spinach.g:244:5: matrixvardec
                    			    {
                    			    	PushFollow(FOLLOW_matrixvardec_in_functiondefination1377);
                    			    	matrixvardec133 = matrixvardec();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, matrixvardec133.Tree);
                    			    	 retval.ret.setBody(((matrixvardec133 != null) ? matrixvardec133.ret : null));

                    			    }
                    			    break;
                    			case 6 :
                    			    // spinach.g:245:5: deletionofvar
                    			    {
                    			    	PushFollow(FOLLOW_deletionofvar_in_functiondefination1385);
                    			    	deletionofvar134 = deletionofvar();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, deletionofvar134.Tree);
                    			    	 retval.ret.setBody(((deletionofvar134 != null) ? deletionofvar134.ret : null));

                    			    }
                    			    break;
                    			case 7 :
                    			    // spinach.g:245:64: print
                    			    {
                    			    	PushFollow(FOLLOW_print_in_functiondefination1391);
                    			    	print135 = print();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, print135.Tree);
                    			    	 retval.ret.setBody(((print135 != null) ? print135.ret : null)); 

                    			    }
                    			    break;
                    			case 8 :
                    			    // spinach.g:246:5: ifelse
                    			    {
                    			    	PushFollow(FOLLOW_ifelse_in_functiondefination1399);
                    			    	ifelse136 = ifelse();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, ifelse136.Tree);
                    			    	retval.ret.setBody(((ifelse136 != null) ? ifelse136.ret : null));

                    			    }
                    			    break;
                    			case 9 :
                    			    // spinach.g:246:47: functionreturn
                    			    {
                    			    	PushFollow(FOLLOW_functionreturn_in_functiondefination1403);
                    			    	functionreturn137 = functionreturn();
                    			    	state.followingStackPointer--;

                    			    	adaptor.AddChild(root_0, functionreturn137.Tree);
                    			    	retval.ret.setBody(((functionreturn137 != null) ? functionreturn137.ret : null));

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt28 >= 1 ) goto loop28;
                    		            EarlyExitException eee28 =
                    		                new EarlyExitException(28, input);
                    		            throw eee28;
                    	    }
                    	    cnt28++;
                    	} while (true);

                    	loop28:
                    		;	// Stops C# compiler whining that label 'loop28' has no statements

                    	char_literal138=(IToken)Match(input,RIGHTPARANTHESIS,FOLLOW_RIGHTPARANTHESIS_in_functiondefination1408); 
                    		char_literal138_tree = (object)adaptor.Create(char_literal138);
                    		adaptor.AddChild(root_0, char_literal138_tree);


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

    public class functiondeclaration_return : ParserRuleReturnScope
    {
        public DeclarationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functiondeclaration"
    // spinach.g:249:1: functiondeclaration returns [DeclarationElement ret] : ( ( VARTYPE ) variable ) ;
    public spinachParser.functiondeclaration_return functiondeclaration() // throws RecognitionException [1]
    {   
        spinachParser.functiondeclaration_return retval = new spinachParser.functiondeclaration_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARTYPE139 = null;
        spinachParser.variable_return variable140 = null;


        object VARTYPE139_tree=null;

         retval.ret = new DeclarationElement();

        try 
    	{
            // spinach.g:252:1: ( ( ( VARTYPE ) variable ) )
            // spinach.g:252:2: ( ( VARTYPE ) variable )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// spinach.g:252:2: ( ( VARTYPE ) variable )
            	// spinach.g:252:3: ( VARTYPE ) variable
            	{
            		// spinach.g:252:3: ( VARTYPE )
            		// spinach.g:252:4: VARTYPE
            		{
            			VARTYPE139=(IToken)Match(input,VARTYPE,FOLLOW_VARTYPE_in_functiondeclaration1427); 
            				VARTYPE139_tree = (object)adaptor.Create(VARTYPE139);
            				adaptor.AddChild(root_0, VARTYPE139_tree);

            			retval.ret.settype(((VARTYPE139 != null) ? VARTYPE139.Text : null));

            		}

            		PushFollow(FOLLOW_variable_in_functiondeclaration1432);
            		variable140 = variable();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, variable140.Tree);
            		retval.ret.setvariable(((variable140 != null) ? variable140.ret : null)); 

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
    // $ANTLR end "functiondeclaration"

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
    // spinach.g:255:1: functionreturn returns [ReturnElement ret] : 'return' ( var_int_or_double_literal ) END_OF_STATEMENT ;
    public spinachParser.functionreturn_return functionreturn() // throws RecognitionException [1]
    {   
        spinachParser.functionreturn_return retval = new spinachParser.functionreturn_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal141 = null;
        IToken END_OF_STATEMENT143 = null;
        spinachParser.var_int_or_double_literal_return var_int_or_double_literal142 = null;


        object string_literal141_tree=null;
        object END_OF_STATEMENT143_tree=null;


        retval.ret = new ReturnElement();

        try 
    	{
            // spinach.g:259:1: ( 'return' ( var_int_or_double_literal ) END_OF_STATEMENT )
            // spinach.g:259:2: 'return' ( var_int_or_double_literal ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal141=(IToken)Match(input,40,FOLLOW_40_in_functionreturn1450); 
            		string_literal141_tree = (object)adaptor.Create(string_literal141);
            		adaptor.AddChild(root_0, string_literal141_tree);

            	// spinach.g:259:11: ( var_int_or_double_literal )
            	// spinach.g:259:12: var_int_or_double_literal
            	{
            		PushFollow(FOLLOW_var_int_or_double_literal_in_functionreturn1453);
            		var_int_or_double_literal142 = var_int_or_double_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, var_int_or_double_literal142.Tree);
            		retval.ret.setreturnvariable(((var_int_or_double_literal142 != null) ? var_int_or_double_literal142.ret : null));

            	}

            	END_OF_STATEMENT143=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_functionreturn1457); 
            		END_OF_STATEMENT143_tree = (object)adaptor.Create(END_OF_STATEMENT143);
            		adaptor.AddChild(root_0, END_OF_STATEMENT143_tree);


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
    // spinach.g:266:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vl1= variable ) ',' ( (el3= int_literal ) ',' )? (vl2= variable ) ',' (el4= int_literal ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vl1= variable ) ',' ( (el1= int_literal ) ',' )? (vl2= variable ) ',' (el2= int_literal ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ',' ) ( (el4= int_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ',' ) ( (vl3= variable ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );
    public spinachParser.plotfunctions_return plotfunctions() // throws RecognitionException [1]
    {   
        spinachParser.plotfunctions_return retval = new spinachParser.plotfunctions_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal144 = null;
        IToken char_literal145 = null;
        IToken char_literal146 = null;
        IToken char_literal147 = null;
        IToken char_literal148 = null;
        IToken char_literal149 = null;
        IToken char_literal150 = null;
        IToken char_literal151 = null;
        IToken END_OF_STATEMENT152 = null;
        IToken string_literal153 = null;
        IToken char_literal154 = null;
        IToken char_literal155 = null;
        IToken char_literal156 = null;
        IToken char_literal157 = null;
        IToken char_literal158 = null;
        IToken END_OF_STATEMENT159 = null;
        IToken string_literal160 = null;
        IToken char_literal161 = null;
        IToken char_literal162 = null;
        IToken END_OF_STATEMENT163 = null;
        IToken string_literal164 = null;
        IToken char_literal165 = null;
        IToken char_literal166 = null;
        IToken char_literal167 = null;
        IToken char_literal168 = null;
        IToken END_OF_STATEMENT169 = null;
        IToken string_literal170 = null;
        IToken char_literal171 = null;
        IToken char_literal172 = null;
        IToken char_literal173 = null;
        IToken END_OF_STATEMENT174 = null;
        IToken string_literal175 = null;
        IToken char_literal176 = null;
        IToken char_literal177 = null;
        IToken END_OF_STATEMENT178 = null;
        IToken string_literal179 = null;
        IToken char_literal180 = null;
        IToken char_literal181 = null;
        IToken char_literal182 = null;
        IToken char_literal183 = null;
        IToken END_OF_STATEMENT184 = null;
        IToken string_literal185 = null;
        IToken char_literal186 = null;
        IToken char_literal187 = null;
        IToken char_literal188 = null;
        IToken END_OF_STATEMENT189 = null;
        IToken string_literal190 = null;
        IToken char_literal191 = null;
        IToken char_literal192 = null;
        IToken END_OF_STATEMENT193 = null;
        IToken string_literal194 = null;
        IToken char_literal195 = null;
        IToken SCALEMODE196 = null;
        IToken char_literal197 = null;
        IToken END_OF_STATEMENT198 = null;
        spinachParser.int_literal_return el1 = null;

        spinachParser.int_literal_return el2 = null;

        spinachParser.variable_return vl1 = null;

        spinachParser.int_literal_return el3 = null;

        spinachParser.variable_return vl2 = null;

        spinachParser.int_literal_return el4 = null;

        spinachParser.int_literal_return ell2 = null;

        spinachParser.int_literal_return ell3 = null;

        spinachParser.variable_return vl3 = null;


        object string_literal144_tree=null;
        object char_literal145_tree=null;
        object char_literal146_tree=null;
        object char_literal147_tree=null;
        object char_literal148_tree=null;
        object char_literal149_tree=null;
        object char_literal150_tree=null;
        object char_literal151_tree=null;
        object END_OF_STATEMENT152_tree=null;
        object string_literal153_tree=null;
        object char_literal154_tree=null;
        object char_literal155_tree=null;
        object char_literal156_tree=null;
        object char_literal157_tree=null;
        object char_literal158_tree=null;
        object END_OF_STATEMENT159_tree=null;
        object string_literal160_tree=null;
        object char_literal161_tree=null;
        object char_literal162_tree=null;
        object END_OF_STATEMENT163_tree=null;
        object string_literal164_tree=null;
        object char_literal165_tree=null;
        object char_literal166_tree=null;
        object char_literal167_tree=null;
        object char_literal168_tree=null;
        object END_OF_STATEMENT169_tree=null;
        object string_literal170_tree=null;
        object char_literal171_tree=null;
        object char_literal172_tree=null;
        object char_literal173_tree=null;
        object END_OF_STATEMENT174_tree=null;
        object string_literal175_tree=null;
        object char_literal176_tree=null;
        object char_literal177_tree=null;
        object END_OF_STATEMENT178_tree=null;
        object string_literal179_tree=null;
        object char_literal180_tree=null;
        object char_literal181_tree=null;
        object char_literal182_tree=null;
        object char_literal183_tree=null;
        object END_OF_STATEMENT184_tree=null;
        object string_literal185_tree=null;
        object char_literal186_tree=null;
        object char_literal187_tree=null;
        object char_literal188_tree=null;
        object END_OF_STATEMENT189_tree=null;
        object string_literal190_tree=null;
        object char_literal191_tree=null;
        object char_literal192_tree=null;
        object END_OF_STATEMENT193_tree=null;
        object string_literal194_tree=null;
        object char_literal195_tree=null;
        object SCALEMODE196_tree=null;
        object char_literal197_tree=null;
        object END_OF_STATEMENT198_tree=null;

         retval.ret = new PlotFunctionElement();

        try 
    	{
            // spinach.g:269:1: ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vl1= variable ) ',' ( (el3= int_literal ) ',' )? (vl2= variable ) ',' (el4= int_literal ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vl1= variable ) ',' ( (el1= int_literal ) ',' )? (vl2= variable ) ',' (el2= int_literal ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ',' ) ( (el4= int_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ',' ) ( (vl3= variable ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) )
            int alt32 = 10;
            alt32 = dfa32.Predict(input);
            switch (alt32) 
            {
                case 1 :
                    // spinach.g:269:3: ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vl1= variable ) ',' ( (el3= int_literal ) ',' )? (vl2= variable ) ',' (el4= int_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:269:3: ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vl1= variable ) ',' ( (el3= int_literal ) ',' )? (vl2= variable ) ',' (el4= int_literal ) ')' END_OF_STATEMENT )
                    	// spinach.g:269:4: 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vl1= variable ) ',' ( (el3= int_literal ) ',' )? (vl2= variable ) ',' (el4= int_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal144=(IToken)Match(input,41,FOLLOW_41_in_plotfunctions1482); 
                    			string_literal144_tree = (object)adaptor.Create(string_literal144);
                    			adaptor.AddChild(root_0, string_literal144_tree);

                    		retval.ret.setPlotFunction("subPlot");
                    		char_literal145=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1485); 
                    			char_literal145_tree = (object)adaptor.Create(char_literal145);
                    			adaptor.AddChild(root_0, char_literal145_tree);

                    		// spinach.g:270:1: (el1= int_literal )
                    		// spinach.g:270:2: el1= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions1492);
                    			el1 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el1.Tree);
                    			retval.ret.setRow(((el1 != null) ? el1.ret : null));

                    		}

                    		char_literal146=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1497); 
                    			char_literal146_tree = (object)adaptor.Create(char_literal146);
                    			adaptor.AddChild(root_0, char_literal146_tree);

                    		// spinach.g:271:1: (el2= int_literal )
                    		// spinach.g:271:2: el2= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions1504);
                    			el2 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el2.Tree);
                    			retval.ret.setColumn(((el2 != null) ? el2.ret : null));

                    		}

                    		char_literal147=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1509); 
                    			char_literal147_tree = (object)adaptor.Create(char_literal147);
                    			adaptor.AddChild(root_0, char_literal147_tree);

                    		// spinach.g:272:1: (vl1= variable )
                    		// spinach.g:272:2: vl1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions1516);
                    			vl1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setData(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal148=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1521); 
                    			char_literal148_tree = (object)adaptor.Create(char_literal148);
                    			adaptor.AddChild(root_0, char_literal148_tree);

                    		// spinach.g:273:1: ( (el3= int_literal ) ',' )?
                    		int alt30 = 2;
                    		int LA30_0 = input.LA(1);

                    		if ( (LA30_0 == INT_LITERAL) )
                    		{
                    		    alt30 = 1;
                    		}
                    		switch (alt30) 
                    		{
                    		    case 1 :
                    		        // spinach.g:273:2: (el3= int_literal ) ','
                    		        {
                    		        	// spinach.g:273:2: (el3= int_literal )
                    		        	// spinach.g:273:3: el3= int_literal
                    		        	{
                    		        		PushFollow(FOLLOW_int_literal_in_plotfunctions1529);
                    		        		el3 = int_literal();
                    		        		state.followingStackPointer--;

                    		        		adaptor.AddChild(root_0, el3.Tree);
                    		        		retval.ret.setMode(((el3 != null) ? el3.ret : null));

                    		        	}

                    		        	char_literal149=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1532); 
                    		        		char_literal149_tree = (object)adaptor.Create(char_literal149);
                    		        		adaptor.AddChild(root_0, char_literal149_tree);


                    		        }
                    		        break;

                    		}

                    		// spinach.g:274:1: (vl2= variable )
                    		// spinach.g:274:2: vl2= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions1540);
                    			vl2 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl2.Tree);
                    			retval.ret.setTitle(((vl2 != null) ? vl2.ret : null));

                    		}

                    		char_literal150=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1544); 
                    			char_literal150_tree = (object)adaptor.Create(char_literal150);
                    			adaptor.AddChild(root_0, char_literal150_tree);

                    		// spinach.g:275:1: (el4= int_literal )
                    		// spinach.g:275:2: el4= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions1551);
                    			el4 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el4.Tree);
                    			retval.ret.setPlotType(((el4 != null) ? el4.ret : null));

                    		}

                    		char_literal151=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1555); 
                    			char_literal151_tree = (object)adaptor.Create(char_literal151);
                    			adaptor.AddChild(root_0, char_literal151_tree);

                    		END_OF_STATEMENT152=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1556); 
                    			END_OF_STATEMENT152_tree = (object)adaptor.Create(END_OF_STATEMENT152);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT152_tree);


                    	}


                    }
                    break;
                case 2 :
                    // spinach.g:277:3: ( 'plot' '(' (vl1= variable ) ',' ( (el1= int_literal ) ',' )? (vl2= variable ) ',' (el2= int_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:277:3: ( 'plot' '(' (vl1= variable ) ',' ( (el1= int_literal ) ',' )? (vl2= variable ) ',' (el2= int_literal ) ')' END_OF_STATEMENT )
                    	// spinach.g:277:4: 'plot' '(' (vl1= variable ) ',' ( (el1= int_literal ) ',' )? (vl2= variable ) ',' (el2= int_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal153=(IToken)Match(input,42,FOLLOW_42_in_plotfunctions1562); 
                    			string_literal153_tree = (object)adaptor.Create(string_literal153);
                    			adaptor.AddChild(root_0, string_literal153_tree);

                    		retval.ret.setPlotFunction("plot");
                    		char_literal154=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1565); 
                    			char_literal154_tree = (object)adaptor.Create(char_literal154);
                    			adaptor.AddChild(root_0, char_literal154_tree);

                    		// spinach.g:278:1: (vl1= variable )
                    		// spinach.g:278:2: vl1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions1571);
                    			vl1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setData(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal155=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1576); 
                    			char_literal155_tree = (object)adaptor.Create(char_literal155);
                    			adaptor.AddChild(root_0, char_literal155_tree);

                    		// spinach.g:279:1: ( (el1= int_literal ) ',' )?
                    		int alt31 = 2;
                    		int LA31_0 = input.LA(1);

                    		if ( (LA31_0 == INT_LITERAL) )
                    		{
                    		    alt31 = 1;
                    		}
                    		switch (alt31) 
                    		{
                    		    case 1 :
                    		        // spinach.g:279:2: (el1= int_literal ) ','
                    		        {
                    		        	// spinach.g:279:2: (el1= int_literal )
                    		        	// spinach.g:279:3: el1= int_literal
                    		        	{
                    		        		PushFollow(FOLLOW_int_literal_in_plotfunctions1584);
                    		        		el1 = int_literal();
                    		        		state.followingStackPointer--;

                    		        		adaptor.AddChild(root_0, el1.Tree);
                    		        		retval.ret.setMode(((el1 != null) ? el1.ret : null));

                    		        	}

                    		        	char_literal156=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1587); 
                    		        		char_literal156_tree = (object)adaptor.Create(char_literal156);
                    		        		adaptor.AddChild(root_0, char_literal156_tree);


                    		        }
                    		        break;

                    		}

                    		// spinach.g:280:1: (vl2= variable )
                    		// spinach.g:280:2: vl2= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions1595);
                    			vl2 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl2.Tree);
                    			retval.ret.setTitle(((vl2 != null) ? vl2.ret : null));

                    		}

                    		char_literal157=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1599); 
                    			char_literal157_tree = (object)adaptor.Create(char_literal157);
                    			adaptor.AddChild(root_0, char_literal157_tree);

                    		// spinach.g:281:1: (el2= int_literal )
                    		// spinach.g:281:2: el2= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions1605);
                    			el2 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, el2.Tree);
                    			retval.ret.setPlotType(((el2 != null) ? el2.ret : null));

                    		}

                    		char_literal158=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1609); 
                    			char_literal158_tree = (object)adaptor.Create(char_literal158);
                    			adaptor.AddChild(root_0, char_literal158_tree);

                    		END_OF_STATEMENT159=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1610); 
                    			END_OF_STATEMENT159_tree = (object)adaptor.Create(END_OF_STATEMENT159);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT159_tree);


                    	}


                    }
                    break;
                case 3 :
                    // spinach.g:283:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:283:3: ( 'resetPlot' '(' ')' END_OF_STATEMENT )
                    	// spinach.g:283:4: 'resetPlot' '(' ')' END_OF_STATEMENT
                    	{
                    		string_literal160=(IToken)Match(input,43,FOLLOW_43_in_plotfunctions1616); 
                    			string_literal160_tree = (object)adaptor.Create(string_literal160);
                    			adaptor.AddChild(root_0, string_literal160_tree);

                    		char_literal161=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1617); 
                    			char_literal161_tree = (object)adaptor.Create(char_literal161);
                    			adaptor.AddChild(root_0, char_literal161_tree);

                    		char_literal162=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1618); 
                    			char_literal162_tree = (object)adaptor.Create(char_literal162);
                    			adaptor.AddChild(root_0, char_literal162_tree);

                    		retval.ret.setPlotFunction("resetPlot");
                    		END_OF_STATEMENT163=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1620); 
                    			END_OF_STATEMENT163_tree = (object)adaptor.Create(END_OF_STATEMENT163);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT163_tree);


                    	}


                    }
                    break;
                case 4 :
                    // spinach.g:284:3: ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ',' ) ( (el4= int_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:284:3: ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ',' ) ( (el4= int_literal ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:284:4: 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ',' ) ( (el4= int_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal164=(IToken)Match(input,44,FOLLOW_44_in_plotfunctions1626); 
                    			string_literal164_tree = (object)adaptor.Create(string_literal164);
                    			adaptor.AddChild(root_0, string_literal164_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal165=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1628); 
                    			char_literal165_tree = (object)adaptor.Create(char_literal165);
                    			adaptor.AddChild(root_0, char_literal165_tree);

                    		// spinach.g:285:1: (ell2= int_literal )
                    		// spinach.g:285:2: ell2= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions1634);
                    			ell2 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal166=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1637); 
                    			char_literal166_tree = (object)adaptor.Create(char_literal166);
                    			adaptor.AddChild(root_0, char_literal166_tree);

                    		// spinach.g:286:1: ( (ell3= int_literal ) ',' )
                    		// spinach.g:286:2: (ell3= int_literal ) ','
                    		{
                    			// spinach.g:286:2: (ell3= int_literal )
                    			// spinach.g:286:3: ell3= int_literal
                    			{
                    				PushFollow(FOLLOW_int_literal_in_plotfunctions1643);
                    				ell3 = int_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}

                    			char_literal167=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1646); 
                    				char_literal167_tree = (object)adaptor.Create(char_literal167);
                    				adaptor.AddChild(root_0, char_literal167_tree);


                    		}

                    		// spinach.g:287:1: ( (el4= int_literal ) )
                    		// spinach.g:287:2: (el4= int_literal )
                    		{
                    			// spinach.g:287:2: (el4= int_literal )
                    			// spinach.g:287:3: el4= int_literal
                    			{
                    				PushFollow(FOLLOW_int_literal_in_plotfunctions1653);
                    				el4 = int_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, el4.Tree);
                    				retval.ret.setZFact(((el4 != null) ? el4.ret : null));

                    			}


                    		}

                    		char_literal168=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1658); 
                    			char_literal168_tree = (object)adaptor.Create(char_literal168);
                    			adaptor.AddChild(root_0, char_literal168_tree);

                    		END_OF_STATEMENT169=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1659); 
                    			END_OF_STATEMENT169_tree = (object)adaptor.Create(END_OF_STATEMENT169);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT169_tree);


                    	}


                    }
                    break;
                case 5 :
                    // spinach.g:289:2: ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:289:2: ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:289:3: 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal170=(IToken)Match(input,44,FOLLOW_44_in_plotfunctions1664); 
                    			string_literal170_tree = (object)adaptor.Create(string_literal170);
                    			adaptor.AddChild(root_0, string_literal170_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal171=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1666); 
                    			char_literal171_tree = (object)adaptor.Create(char_literal171);
                    			adaptor.AddChild(root_0, char_literal171_tree);

                    		// spinach.g:290:1: (ell2= int_literal )
                    		// spinach.g:290:2: ell2= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions1672);
                    			ell2 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal172=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1675); 
                    			char_literal172_tree = (object)adaptor.Create(char_literal172);
                    			adaptor.AddChild(root_0, char_literal172_tree);

                    		// spinach.g:291:1: ( (ell3= int_literal ) )
                    		// spinach.g:291:2: (ell3= int_literal )
                    		{
                    			// spinach.g:291:2: (ell3= int_literal )
                    			// spinach.g:291:3: ell3= int_literal
                    			{
                    				PushFollow(FOLLOW_int_literal_in_plotfunctions1681);
                    				ell3 = int_literal();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, ell3.Tree);
                    				retval.ret.setYFact(((ell3 != null) ? ell3.ret : null));

                    			}


                    		}

                    		char_literal173=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1686); 
                    			char_literal173_tree = (object)adaptor.Create(char_literal173);
                    			adaptor.AddChild(root_0, char_literal173_tree);

                    		END_OF_STATEMENT174=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1687); 
                    			END_OF_STATEMENT174_tree = (object)adaptor.Create(END_OF_STATEMENT174);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT174_tree);


                    	}


                    }
                    break;
                case 6 :
                    // spinach.g:293:2: ( 'setPlotAxis' '(' (ell2= int_literal ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:293:2: ( 'setPlotAxis' '(' (ell2= int_literal ) ')' END_OF_STATEMENT )
                    	// spinach.g:293:3: 'setPlotAxis' '(' (ell2= int_literal ) ')' END_OF_STATEMENT
                    	{
                    		string_literal175=(IToken)Match(input,44,FOLLOW_44_in_plotfunctions1692); 
                    			string_literal175_tree = (object)adaptor.Create(string_literal175);
                    			adaptor.AddChild(root_0, string_literal175_tree);

                    		retval.ret.setPlotFunction("setPlotAxis");
                    		char_literal176=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1694); 
                    			char_literal176_tree = (object)adaptor.Create(char_literal176);
                    			adaptor.AddChild(root_0, char_literal176_tree);

                    		// spinach.g:294:1: (ell2= int_literal )
                    		// spinach.g:294:2: ell2= int_literal
                    		{
                    			PushFollow(FOLLOW_int_literal_in_plotfunctions1700);
                    			ell2 = int_literal();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, ell2.Tree);
                    			retval.ret.setXFact(((ell2 != null) ? ell2.ret : null));

                    		}

                    		char_literal177=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1704); 
                    			char_literal177_tree = (object)adaptor.Create(char_literal177);
                    			adaptor.AddChild(root_0, char_literal177_tree);

                    		END_OF_STATEMENT178=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1705); 
                    			END_OF_STATEMENT178_tree = (object)adaptor.Create(END_OF_STATEMENT178);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT178_tree);


                    	}


                    }
                    break;
                case 7 :
                    // spinach.g:296:3: ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ',' ) ( (vl3= variable ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:296:3: ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ',' ) ( (vl3= variable ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:296:4: 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ',' ) ( (vl3= variable ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal179=(IToken)Match(input,45,FOLLOW_45_in_plotfunctions1711); 
                    			string_literal179_tree = (object)adaptor.Create(string_literal179);
                    			adaptor.AddChild(root_0, string_literal179_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal180=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1713); 
                    			char_literal180_tree = (object)adaptor.Create(char_literal180);
                    			adaptor.AddChild(root_0, char_literal180_tree);

                    		// spinach.g:297:1: (vl1= variable )
                    		// spinach.g:297:2: vl1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions1719);
                    			vl1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal181=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1722); 
                    			char_literal181_tree = (object)adaptor.Create(char_literal181);
                    			adaptor.AddChild(root_0, char_literal181_tree);

                    		// spinach.g:298:1: ( (vl2= variable ) ',' )
                    		// spinach.g:298:2: (vl2= variable ) ','
                    		{
                    			// spinach.g:298:2: (vl2= variable )
                    			// spinach.g:298:3: vl2= variable
                    			{
                    				PushFollow(FOLLOW_variable_in_plotfunctions1729);
                    				vl2 = variable();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}

                    			char_literal182=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1732); 
                    				char_literal182_tree = (object)adaptor.Create(char_literal182);
                    				adaptor.AddChild(root_0, char_literal182_tree);


                    		}

                    		// spinach.g:299:1: ( (vl3= variable ) )
                    		// spinach.g:299:2: (vl3= variable )
                    		{
                    			// spinach.g:299:2: (vl3= variable )
                    			// spinach.g:299:3: vl3= variable
                    			{
                    				PushFollow(FOLLOW_variable_in_plotfunctions1740);
                    				vl3 = variable();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl3.Tree);
                    				retval.ret.setZTitle(((vl3 != null) ? vl3.ret : null));

                    			}


                    		}

                    		char_literal183=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1745); 
                    			char_literal183_tree = (object)adaptor.Create(char_literal183);
                    			adaptor.AddChild(root_0, char_literal183_tree);

                    		END_OF_STATEMENT184=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1746); 
                    			END_OF_STATEMENT184_tree = (object)adaptor.Create(END_OF_STATEMENT184);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT184_tree);


                    	}


                    }
                    break;
                case 8 :
                    // spinach.g:301:3: ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:301:3: ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ) ')' END_OF_STATEMENT )
                    	// spinach.g:301:4: 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ) ')' END_OF_STATEMENT
                    	{
                    		string_literal185=(IToken)Match(input,45,FOLLOW_45_in_plotfunctions1752); 
                    			string_literal185_tree = (object)adaptor.Create(string_literal185);
                    			adaptor.AddChild(root_0, string_literal185_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal186=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1754); 
                    			char_literal186_tree = (object)adaptor.Create(char_literal186);
                    			adaptor.AddChild(root_0, char_literal186_tree);

                    		// spinach.g:302:1: (vl1= variable )
                    		// spinach.g:302:2: vl1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions1760);
                    			vl1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal187=(IToken)Match(input,28,FOLLOW_28_in_plotfunctions1763); 
                    			char_literal187_tree = (object)adaptor.Create(char_literal187);
                    			adaptor.AddChild(root_0, char_literal187_tree);

                    		// spinach.g:303:1: ( (vl2= variable ) )
                    		// spinach.g:303:2: (vl2= variable )
                    		{
                    			// spinach.g:303:2: (vl2= variable )
                    			// spinach.g:303:3: vl2= variable
                    			{
                    				PushFollow(FOLLOW_variable_in_plotfunctions1770);
                    				vl2 = variable();
                    				state.followingStackPointer--;

                    				adaptor.AddChild(root_0, vl2.Tree);
                    				retval.ret.setYTitle(((vl2 != null) ? vl2.ret : null));

                    			}


                    		}

                    		char_literal188=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1775); 
                    			char_literal188_tree = (object)adaptor.Create(char_literal188);
                    			adaptor.AddChild(root_0, char_literal188_tree);

                    		END_OF_STATEMENT189=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1776); 
                    			END_OF_STATEMENT189_tree = (object)adaptor.Create(END_OF_STATEMENT189);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT189_tree);


                    	}


                    }
                    break;
                case 9 :
                    // spinach.g:305:2: ( 'setAxisTitle' '(' (vl1= variable ) ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:305:2: ( 'setAxisTitle' '(' (vl1= variable ) ')' END_OF_STATEMENT )
                    	// spinach.g:305:3: 'setAxisTitle' '(' (vl1= variable ) ')' END_OF_STATEMENT
                    	{
                    		string_literal190=(IToken)Match(input,45,FOLLOW_45_in_plotfunctions1781); 
                    			string_literal190_tree = (object)adaptor.Create(string_literal190);
                    			adaptor.AddChild(root_0, string_literal190_tree);

                    		retval.ret.setPlotFunction("setAxisTitle");
                    		char_literal191=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1783); 
                    			char_literal191_tree = (object)adaptor.Create(char_literal191);
                    			adaptor.AddChild(root_0, char_literal191_tree);

                    		// spinach.g:306:1: (vl1= variable )
                    		// spinach.g:306:2: vl1= variable
                    		{
                    			PushFollow(FOLLOW_variable_in_plotfunctions1789);
                    			vl1 = variable();
                    			state.followingStackPointer--;

                    			adaptor.AddChild(root_0, vl1.Tree);
                    			retval.ret.setXTitle(((vl1 != null) ? vl1.ret : null));

                    		}

                    		char_literal192=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1793); 
                    			char_literal192_tree = (object)adaptor.Create(char_literal192);
                    			adaptor.AddChild(root_0, char_literal192_tree);

                    		END_OF_STATEMENT193=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1794); 
                    			END_OF_STATEMENT193_tree = (object)adaptor.Create(END_OF_STATEMENT193);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT193_tree);


                    	}


                    }
                    break;
                case 10 :
                    // spinach.g:308:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// spinach.g:308:2: ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT )
                    	// spinach.g:308:3: 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT
                    	{
                    		string_literal194=(IToken)Match(input,46,FOLLOW_46_in_plotfunctions1799); 
                    			string_literal194_tree = (object)adaptor.Create(string_literal194);
                    			adaptor.AddChild(root_0, string_literal194_tree);

                    		char_literal195=(IToken)Match(input,LEFTBRACE,FOLLOW_LEFTBRACE_in_plotfunctions1800); 
                    			char_literal195_tree = (object)adaptor.Create(char_literal195);
                    			adaptor.AddChild(root_0, char_literal195_tree);

                    		retval.ret.setPlotFunction("setScaleMode");
                    		SCALEMODE196=(IToken)Match(input,SCALEMODE,FOLLOW_SCALEMODE_in_plotfunctions1803); 
                    			SCALEMODE196_tree = (object)adaptor.Create(SCALEMODE196);
                    			adaptor.AddChild(root_0, SCALEMODE196_tree);

                    		retval.ret.setScaleMode(SCALEMODE196.Text);
                    		char_literal197=(IToken)Match(input,RIGHTBRACE,FOLLOW_RIGHTBRACE_in_plotfunctions1807); 
                    			char_literal197_tree = (object)adaptor.Create(char_literal197);
                    			adaptor.AddChild(root_0, char_literal197_tree);

                    		END_OF_STATEMENT198=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_plotfunctions1809); 
                    			END_OF_STATEMENT198_tree = (object)adaptor.Create(END_OF_STATEMENT198);
                    			adaptor.AddChild(root_0, END_OF_STATEMENT198_tree);


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
   	protected DFA13 dfa13;
   	protected DFA25 dfa25;
   	protected DFA28 dfa28;
   	protected DFA32 dfa32;
	private void InitializeCyclicDFAs()
	{
    	this.dfa3 = new DFA3(this);
    	this.dfa13 = new DFA13(this);
    	this.dfa25 = new DFA25(this);
    	this.dfa28 = new DFA28(this);
    	this.dfa32 = new DFA32(this);





	}

    const string DFA3_eotS =
        "\x14\uffff";
    const string DFA3_eofS =
        "\x14\uffff";
    const string DFA3_minS =
        "\x03\x04\x10\uffff\x01\x09";
    const string DFA3_maxS =
        "\x01\x2e\x01\x13\x01\x04\x10\uffff\x01\x0d";
    const string DFA3_acceptS =
        "\x03\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x08\x01"+
        "\x09\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x07\x01\x0c\x01\x01\x01"+
        "\x0b\x01\x0a\x01\uffff";
    const string DFA3_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA3_transitionS = {
            "\x01\x01\x02\uffff\x01\x02\x02\uffff\x01\x03\x0c\uffff\x01"+
            "\x05\x05\uffff\x01\x04\x01\x07\x01\x06\x01\x08\x03\uffff\x01"+
            "\x09\x01\uffff\x01\x0a\x01\x0b\x01\x0c\x06\x0d",
            "\x01\x0e\x03\uffff\x01\x10\x04\uffff\x01\x12\x02\uffff\x01"+
            "\x11\x01\x0f\x01\uffff\x01\x10",
            "\x01\x13",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x03\x03\uffff\x01\x0b"
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
            get { return "30:1: expr1 returns [Element ret] : ( assignment | scalarvardec | vectorvardec | matrixvardec | deletionofvar | structdec | structobjdec | print | ifelse | functioncall | equality | nonequality | forstatement | functiondefination | functionreturn | plotfunctions );"; }
        }

    }

    const string DFA13_eotS =
        "\x14\uffff";
    const string DFA13_eofS =
        "\x14\uffff";
    const string DFA13_minS =
        "\x01\x04\x13\uffff";
    const string DFA13_maxS =
        "\x01\x2e\x13\uffff";
    const string DFA13_acceptS =
        "\x01\uffff\x01\x02\x12\x01";
    const string DFA13_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA13_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x04\x01\uffff\x01"+
            "\x01\x0a\uffff\x01\x06\x05\uffff\x01\x05\x01\x08\x01\x07\x01"+
            "\x09\x01\uffff\x01\x01\x01\uffff\x01\x0a\x01\uffff\x01\x0b\x01"+
            "\x0c\x01\x0d\x01\x0e\x01\x0f\x01\x10\x01\x11\x01\x12\x01\x13",
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

    static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
    static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
    static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
    static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
    static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
    static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
    static readonly short[][] DFA13_transition = DFA.UnpackEncodedStringArray(DFA13_transitionS);

    protected class DFA13 : DFA
    {
        public DFA13(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 13;
            this.eot = DFA13_eot;
            this.eof = DFA13_eof;
            this.min = DFA13_min;
            this.max = DFA13_max;
            this.accept = DFA13_accept;
            this.special = DFA13_special;
            this.transition = DFA13_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 162:80: (e11= expr1 )+"; }
        }

    }

    const string DFA25_eotS =
        "\x0c\uffff";
    const string DFA25_eofS =
        "\x0c\uffff";
    const string DFA25_minS =
        "\x01\x04\x01\uffff\x01\x08\x09\uffff";
    const string DFA25_maxS =
        "\x01\x28\x01\uffff\x01\x13\x09\uffff";
    const string DFA25_acceptS =
        "\x01\uffff\x01\x0a\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x01\x01\x02";
    const string DFA25_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA25_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x01\x0a\uffff\x01\x05\x05\uffff\x01\x04\x01\uffff\x01\x06\x01"+
            "\x07\x03\uffff\x01\x08\x03\uffff\x01\x09",
            "",
            "\x01\x0a\x04\uffff\x01\x0b\x05\uffff\x01\x0a",
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

    static readonly short[] DFA25_eot = DFA.UnpackEncodedString(DFA25_eotS);
    static readonly short[] DFA25_eof = DFA.UnpackEncodedString(DFA25_eofS);
    static readonly char[] DFA25_min = DFA.UnpackEncodedStringToUnsignedChars(DFA25_minS);
    static readonly char[] DFA25_max = DFA.UnpackEncodedStringToUnsignedChars(DFA25_maxS);
    static readonly short[] DFA25_accept = DFA.UnpackEncodedString(DFA25_acceptS);
    static readonly short[] DFA25_special = DFA.UnpackEncodedString(DFA25_specialS);
    static readonly short[][] DFA25_transition = DFA.UnpackEncodedStringArray(DFA25_transitionS);

    protected class DFA25 : DFA
    {
        public DFA25(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 25;
            this.eot = DFA25_eot;
            this.eof = DFA25_eof;
            this.min = DFA25_min;
            this.max = DFA25_max;
            this.accept = DFA25_accept;
            this.special = DFA25_special;
            this.transition = DFA25_transition;

        }

        override public string Description
        {
            get { return "()+ loopback of 232:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+"; }
        }

    }

    const string DFA28_eotS =
        "\x0c\uffff";
    const string DFA28_eofS =
        "\x0c\uffff";
    const string DFA28_minS =
        "\x01\x04\x01\uffff\x01\x08\x09\uffff";
    const string DFA28_maxS =
        "\x01\x28\x01\uffff\x01\x13\x09\uffff";
    const string DFA28_acceptS =
        "\x01\uffff\x01\x0a\x01\uffff\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x02\x01\x01";
    const string DFA28_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA28_transitionS = {
            "\x01\x02\x02\uffff\x01\x03\x02\uffff\x01\x03\x01\uffff\x01"+
            "\x01\x0a\uffff\x01\x05\x05\uffff\x01\x04\x01\uffff\x01\x06\x01"+
            "\x07\x03\uffff\x01\x08\x03\uffff\x01\x09",
            "",
            "\x01\x0b\x04\uffff\x01\x0a\x05\uffff\x01\x0b",
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
            get { return "()+ loopback of 242:5: ( assignment | functioncall | scalarvardec | vectorvardec | matrixvardec | deletionofvar | print | ifelse | functionreturn )+"; }
        }

    }

    const string DFA32_eotS =
        "\x15\uffff";
    const string DFA32_eofS =
        "\x15\uffff";
    const string DFA32_minS =
        "\x01\x29\x03\uffff\x02\x0d\x01\uffff\x01\x05\x01\x04\x02\x0f\x01"+
        "\x05\x01\uffff\x01\x04\x01\uffff\x02\x0f\x04\uffff";
    const string DFA32_maxS =
        "\x01\x2e\x03\uffff\x02\x0d\x01\uffff\x01\x05\x01\x04\x02\x1c\x01"+
        "\x05\x01\uffff\x01\x04\x01\uffff\x02\x1c\x04\uffff";
    const string DFA32_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x02\uffff\x01\x0a\x05\uffff"+
        "\x01\x06\x01\uffff\x01\x09\x02\uffff\x01\x04\x01\x05\x01\x07\x01"+
        "\x08";
    const string DFA32_specialS =
        "\x15\uffff}>";
    static readonly string[] DFA32_transitionS = {
            "\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06",
            "",
            "",
            "",
            "\x01\x07",
            "\x01\x08",
            "",
            "\x01\x09",
            "\x01\x0a",
            "\x01\x0c\x0c\uffff\x01\x0b",
            "\x01\x0e\x0c\uffff\x01\x0d",
            "\x01\x0f",
            "",
            "\x01\x10",
            "",
            "\x01\x12\x0c\uffff\x01\x11",
            "\x01\x14\x0c\uffff\x01\x13",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA32_eot = DFA.UnpackEncodedString(DFA32_eotS);
    static readonly short[] DFA32_eof = DFA.UnpackEncodedString(DFA32_eofS);
    static readonly char[] DFA32_min = DFA.UnpackEncodedStringToUnsignedChars(DFA32_minS);
    static readonly char[] DFA32_max = DFA.UnpackEncodedStringToUnsignedChars(DFA32_maxS);
    static readonly short[] DFA32_accept = DFA.UnpackEncodedString(DFA32_acceptS);
    static readonly short[] DFA32_special = DFA.UnpackEncodedString(DFA32_specialS);
    static readonly short[][] DFA32_transition = DFA.UnpackEncodedStringArray(DFA32_transitionS);

    protected class DFA32 : DFA
    {
        public DFA32(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 32;
            this.eot = DFA32_eot;
            this.eof = DFA32_eof;
            this.min = DFA32_min;
            this.max = DFA32_max;
            this.accept = DFA32_accept;
            this.special = DFA32_special;
            this.transition = DFA32_transition;

        }

        override public string Description
        {
            get { return "266:1: plotfunctions returns [PlotFunctionElement ret] : ( ( 'subPlot' '(' (el1= int_literal ) ',' (el2= int_literal ) ',' (vl1= variable ) ',' ( (el3= int_literal ) ',' )? (vl2= variable ) ',' (el4= int_literal ) ')' END_OF_STATEMENT ) | ( 'plot' '(' (vl1= variable ) ',' ( (el1= int_literal ) ',' )? (vl2= variable ) ',' (el2= int_literal ) ')' END_OF_STATEMENT ) | ( 'resetPlot' '(' ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ',' ) ( (el4= int_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ',' ( (ell3= int_literal ) ) ')' END_OF_STATEMENT ) | ( 'setPlotAxis' '(' (ell2= int_literal ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ',' ) ( (vl3= variable ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ',' ( (vl2= variable ) ) ')' END_OF_STATEMENT ) | ( 'setAxisTitle' '(' (vl1= variable ) ')' END_OF_STATEMENT ) | ( 'setScaleMode' '(' SCALEMODE ')' END_OF_STATEMENT ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_expr_in_program65 = new BitSet(new ulong[]{0x00007FD3E0800492UL});
    public static readonly BitSet FOLLOW_expr1_in_expr85 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallelfor_in_expr89 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_expr1105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_expr1113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_expr1121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_expr1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_expr1137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structdec_in_expr1145 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_structobjdec_in_expr1153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr1161 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifelse_in_expr1169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functioncall_in_expr1176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_equality_in_expr1183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_nonequality_in_expr1190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forstatement_in_expr1197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functiondefination_in_expr1204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionreturn_in_expr1211 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_plotfunctions_in_expr1218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_int_or_double_literal235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_int_or_double_literal246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_double_literal_in_var_int_or_double_literal256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DOUBLE_LITERAL_in_double_literal321 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_23_in_matrixvardec341 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_matrixvardec343 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_matrixvardec345 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_matrixvardec348 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_matrixvardec350 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec353 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_matrixvardec356 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_matrixvardec359 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec363 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_matrixvardec366 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_matrixvardec374 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_matrixvardec381 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_matrixvardec385 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec390 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec396 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_28_in_matrixvardec404 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_matrixvardec407 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_28_in_matrixvardec411 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_double_literal_in_matrixvardec414 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_27_in_matrixvardec420 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_matrixvardec426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_vectorvardec444 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_vectorvardec446 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_vectorvardec448 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_vectorvardec451 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_vectorvardec453 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec456 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_vectorvardec459 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_vectorvardec465 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_vectorvardec472 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_vectorvardec477 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec482 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec488 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_28_in_vectorvardec496 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_vectorvardec499 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_28_in_vectorvardec503 = new BitSet(new ulong[]{0x0000000000000060UL});
    public static readonly BitSet FOLLOW_double_literal_in_vectorvardec506 = new BitSet(new ulong[]{0x0000000018000000UL});
    public static readonly BitSet FOLLOW_27_in_vectorvardec512 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_vectorvardec518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment538 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_structassign_in_assignment548 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment557 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_assignment565 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_addition_in_assignment576 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_addition607 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition616 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_addition626 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_structdec657 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structdec659 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_structdec663 = new BitSet(new ulong[]{0x0000000000000480UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_structdec668 = new BitSet(new ulong[]{0x0000000000001480UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_structdec674 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structdec676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_scalarvardec697 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_STRINGTYPE_in_scalarvardec704 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_scalarvardec711 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_scalarvardec715 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec736 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structobjdec743 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_structobjdec749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_structassign769 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_DOT_in_structassign772 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_structassign775 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_deletionofvar795 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_deletionofvar799 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_deletionofvar803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_print822 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_print824 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print832 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_parallelfor854 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_range_in_parallelfor860 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_parallelfor863 = new BitSet(new ulong[]{0x00007FD1E0800490UL});
    public static readonly BitSet FOLLOW_expr1_in_parallelfor870 = new BitSet(new ulong[]{0x00007FD5E0801490UL});
    public static readonly BitSet FOLLOW_34_in_parallelfor876 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_parallelfor879 = new BitSet(new ulong[]{0x00007FD1E0801490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_parallelfor887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_range901 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_range907 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_POINT_in_range910 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_range916 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_range919 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_range924 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_range927 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_ifelse949 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_ifelse951 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_equality_in_ifelse954 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_nonequality_in_ifelse957 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_ifelse961 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse963 = new BitSet(new ulong[]{0x00007FD3E0801490UL});
    public static readonly BitSet FOLLOW_program_in_ifelse971 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse976 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_37_in_ifelse979 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_ifelse982 = new BitSet(new ulong[]{0x00007FD3E0801490UL});
    public static readonly BitSet FOLLOW_program_in_ifelse991 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_ifelse997 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_forstatement1014 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_range_in_forstatement1019 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_forstatement1022 = new BitSet(new ulong[]{0x00007FD1E0800490UL});
    public static readonly BitSet FOLLOW_expr1_in_forstatement1027 = new BitSet(new ulong[]{0x00007FD1E0801490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_forstatement1032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_functioncall1057 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functioncall1062 = new BitSet(new ulong[]{0x0000000000008070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1066 = new BitSet(new ulong[]{0x0000000010008000UL});
    public static readonly BitSet FOLLOW_28_in_functioncall1070 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functioncall1074 = new BitSet(new ulong[]{0x0000000010008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functioncall1081 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functioncall1085 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_equality1110 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_EQUALITYEXPRESSION_in_equality1119 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_equality1129 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_nonequality1168 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_NONEQUALITYEXPRESSION_in_nonequality1177 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_nonequality1182 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_functiondefination1215 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1220 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1226 = new BitSet(new ulong[]{0x0000000000008080UL});
    public static readonly BitSet FOLLOW_functiondeclaration_in_functiondefination1234 = new BitSet(new ulong[]{0x0000000010008000UL});
    public static readonly BitSet FOLLOW_28_in_functiondefination1237 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_functiondeclaration_in_functiondefination1242 = new BitSet(new ulong[]{0x0000000010008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1251 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1253 = new BitSet(new ulong[]{0x00000111A0800490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1256 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1259 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1263 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1271 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1279 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1287 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1293 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1301 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1305 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_functiondefination1313 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondefination1318 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_functiondefination1324 = new BitSet(new ulong[]{0x0000000000008080UL});
    public static readonly BitSet FOLLOW_functiondeclaration_in_functiondefination1333 = new BitSet(new ulong[]{0x0000000010008000UL});
    public static readonly BitSet FOLLOW_28_in_functiondefination1336 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_functiondeclaration_in_functiondefination1340 = new BitSet(new ulong[]{0x0000000010008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_functiondefination1349 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_LEFTPARANTHESIS_in_functiondefination1351 = new BitSet(new ulong[]{0x00000111A0800490UL});
    public static readonly BitSet FOLLOW_assignment_in_functiondefination1354 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_functioncall_in_functiondefination1357 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_scalarvardec_in_functiondefination1361 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_vectorvardec_in_functiondefination1369 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_matrixvardec_in_functiondefination1377 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_deletionofvar_in_functiondefination1385 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_print_in_functiondefination1391 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_ifelse_in_functiondefination1399 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_functionreturn_in_functiondefination1403 = new BitSet(new ulong[]{0x00000111A0801490UL});
    public static readonly BitSet FOLLOW_RIGHTPARANTHESIS_in_functiondefination1408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARTYPE_in_functiondeclaration1427 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_functiondeclaration1432 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_functionreturn1450 = new BitSet(new ulong[]{0x0000000000000070UL});
    public static readonly BitSet FOLLOW_var_int_or_double_literal_in_functionreturn1453 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_functionreturn1457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_plotfunctions1482 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1485 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1492 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1497 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1504 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1509 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1516 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1521 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1529 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1532 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1540 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1544 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1551 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1555 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1556 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_plotfunctions1562 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1565 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1571 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1576 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1584 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1587 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1595 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1599 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1605 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1609 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_plotfunctions1616 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1617 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1618 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1620 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_plotfunctions1626 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1628 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1634 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1637 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1643 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1646 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1653 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1658 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1659 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_plotfunctions1664 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1666 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1672 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1675 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1681 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1686 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_plotfunctions1692 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1694 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_int_literal_in_plotfunctions1700 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1704 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_plotfunctions1711 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1713 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1719 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1722 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1729 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1732 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1740 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1745 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_plotfunctions1752 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1754 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1760 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_plotfunctions1763 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1770 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1775 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1776 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_plotfunctions1781 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1783 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_variable_in_plotfunctions1789 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1793 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1794 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_plotfunctions1799 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_LEFTBRACE_in_plotfunctions1800 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_SCALEMODE_in_plotfunctions1803 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_RIGHTBRACE_in_plotfunctions1807 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_plotfunctions1809 = new BitSet(new ulong[]{0x0000000000000002UL});

}
