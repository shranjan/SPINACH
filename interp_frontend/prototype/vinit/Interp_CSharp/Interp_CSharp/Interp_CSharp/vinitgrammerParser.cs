// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 vinitgrammer.g 2009-10-26 19:18:42


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public class vinitgrammerParser : Parser 
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
		"PLUS", 
		"WHITESPACE", 
		"'parallel_for'", 
		"'('", 
		"')'", 
		"'{'", 
		"'}'", 
		"'..'", 
		"'['", 
		"']'", 
		"'};'", 
		"','", 
		"' '", 
		"'print'"
    };

    public const int INT_LITERAL = 6;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int WHITESPACE = 10;
    public const int EOF = -1;
    public const int TYPE = 8;
    public const int T__19 = 19;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int T__18 = 18;
    public const int VARIABLE = 7;
    public const int T__17 = 17;
    public const int T__12 = 12;
    public const int T__11 = 11;
    public const int T__14 = 14;
    public const int T__13 = 13;
    public const int PLUS = 9;
    public const int ASSIGNMENT = 4;
    public const int END_OF_STATEMENT = 5;

    // delegates
    // delegators



        public vinitgrammerParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public vinitgrammerParser(ITokenStream input, RecognizerSharedState state)
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
		get { return vinitgrammerParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "vinitgrammer.g"; }
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
    // vinitgrammer.g:29:1: program returns [List<Element> ret] : ( expr )+ ;
    public vinitgrammerParser.program_return program() // throws RecognitionException [1]
    {   
        vinitgrammerParser.program_return retval = new vinitgrammerParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        vinitgrammerParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // vinitgrammer.g:33:3: ( ( expr )+ )
            // vinitgrammer.g:33:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// vinitgrammer.g:33:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || LA1_0 == 11 || LA1_0 == 22) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // vinitgrammer.g:33:6: expr
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
    // vinitgrammer.g:35:1: expr returns [Element ret] : ( assignment | print | parallelfor );
    public vinitgrammerParser.expr_return expr() // throws RecognitionException [1]
    {   
        vinitgrammerParser.expr_return retval = new vinitgrammerParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        vinitgrammerParser.assignment_return assignment2 = null;

        vinitgrammerParser.print_return print3 = null;

        vinitgrammerParser.parallelfor_return parallelfor4 = null;



        try 
    	{
            // vinitgrammer.g:36:3: ( assignment | print | parallelfor )
            int alt2 = 3;
            switch ( input.LA(1) ) 
            {
            case VARIABLE:
            	{
                alt2 = 1;
                }
                break;
            case 22:
            	{
                alt2 = 2;
                }
                break;
            case 11:
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
                    // vinitgrammer.g:36:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expr93);
                    	assignment2 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment2.Tree);
                    	retval.ret = ((assignment2 != null) ? assignment2.ret : null);

                    }
                    break;
                case 2 :
                    // vinitgrammer.g:37:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr101);
                    	print3 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print3.Tree);
                    	 retval.ret = ((print3 != null) ? print3.ret : null); 

                    }
                    break;
                case 3 :
                    // vinitgrammer.g:38:5: parallelfor
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_parallelfor_in_expr109);
                    	parallelfor4 = parallelfor();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, parallelfor4.Tree);
                    	retval.ret = $parallelFor.ret

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

    public class parallelfor_return : ParserRuleReturnScope
    {
        public ParallelForOperationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "parallelfor"
    // vinitgrammer.g:40:1: parallelfor returns [ParallelForOperationElement ret] : 'parallel_for' '(' pfargument ')' '{' ( assignment )+ '}' ;
    public vinitgrammerParser.parallelfor_return parallelfor() // throws RecognitionException [1]
    {   
        vinitgrammerParser.parallelfor_return retval = new vinitgrammerParser.parallelfor_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal5 = null;
        IToken char_literal6 = null;
        IToken char_literal8 = null;
        IToken char_literal9 = null;
        IToken char_literal11 = null;
        vinitgrammerParser.pfargument_return pfargument7 = null;

        vinitgrammerParser.assignment_return assignment10 = null;


        object string_literal5_tree=null;
        object char_literal6_tree=null;
        object char_literal8_tree=null;
        object char_literal9_tree=null;
        object char_literal11_tree=null;


        	retval.ret = new ParallelForOperationElement();

        try 
    	{
            // vinitgrammer.g:44:5: ( 'parallel_for' '(' pfargument ')' '{' ( assignment )+ '}' )
            // vinitgrammer.g:44:7: 'parallel_for' '(' pfargument ')' '{' ( assignment )+ '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal5=(IToken)Match(input,11,FOLLOW_11_in_parallelfor132); 
            		string_literal5_tree = (object)adaptor.Create(string_literal5);
            		adaptor.AddChild(root_0, string_literal5_tree);

            	char_literal6=(IToken)Match(input,12,FOLLOW_12_in_parallelfor134); 
            		char_literal6_tree = (object)adaptor.Create(char_literal6);
            		adaptor.AddChild(root_0, char_literal6_tree);

            	PushFollow(FOLLOW_pfargument_in_parallelfor136);
            	pfargument7 = pfargument();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, pfargument7.Tree);
            	char_literal8=(IToken)Match(input,13,FOLLOW_13_in_parallelfor138); 
            		char_literal8_tree = (object)adaptor.Create(char_literal8);
            		adaptor.AddChild(root_0, char_literal8_tree);

            	char_literal9=(IToken)Match(input,14,FOLLOW_14_in_parallelfor145); 
            		char_literal9_tree = (object)adaptor.Create(char_literal9);
            		adaptor.AddChild(root_0, char_literal9_tree);

            	// vinitgrammer.g:45:10: ( assignment )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == VARIABLE) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // vinitgrammer.g:45:11: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_parallelfor148);
            			    	assignment10 = assignment();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, assignment10.Tree);
            			    	retval.ret = ((assignment10 != null) ? assignment10.ret : null);

            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	char_literal11=(IToken)Match(input,15,FOLLOW_15_in_parallelfor154); 
            		char_literal11_tree = (object)adaptor.Create(char_literal11);
            		adaptor.AddChild(root_0, char_literal11_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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

    public class pfargument_return : ParserRuleReturnScope
    {
        public pfargumentElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "pfargument"
    // vinitgrammer.g:48:1: pfargument returns [pfargumentElement ret] : ( variable ASSIGNMENT range | range END_OF_STATEMENT );
    public vinitgrammerParser.pfargument_return pfargument() // throws RecognitionException [1]
    {   
        vinitgrammerParser.pfargument_return retval = new vinitgrammerParser.pfargument_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT13 = null;
        IToken END_OF_STATEMENT16 = null;
        vinitgrammerParser.variable_return variable12 = null;

        vinitgrammerParser.range_return range14 = null;

        vinitgrammerParser.range_return range15 = null;


        object ASSIGNMENT13_tree=null;
        object END_OF_STATEMENT16_tree=null;


          retval.ret = new pfargumentElement();

        try 
    	{
            // vinitgrammer.g:52:3: ( variable ASSIGNMENT range | range END_OF_STATEMENT )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == VARIABLE) )
            {
                int LA4_1 = input.LA(2);

                if ( (LA4_1 == 16) )
                {
                    alt4 = 2;
                }
                else if ( (LA4_1 == ASSIGNMENT) )
                {
                    alt4 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d4s1 =
                        new NoViableAltException("", 4, 1, input);

                    throw nvae_d4s1;
                }
            }
            else if ( (LA4_0 == INT_LITERAL) )
            {
                alt4 = 2;
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // vinitgrammer.g:52:5: variable ASSIGNMENT range
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variable_in_pfargument175);
                    	variable12 = variable();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variable12.Tree);
                    	retval.ret.setLhs(((variable12 != null) ? variable12.ret : null)); 
                    	ASSIGNMENT13=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_pfargument183); 
                    		ASSIGNMENT13_tree = (object)adaptor.Create(ASSIGNMENT13);
                    		adaptor.AddChild(root_0, ASSIGNMENT13_tree);

                    	PushFollow(FOLLOW_range_in_pfargument193);
                    	range14 = range();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, range14.Tree);
                    	retval.ret = ((range14 != null) ? range14.ret : null);

                    }
                    break;
                case 2 :
                    // vinitgrammer.g:55:7: range END_OF_STATEMENT
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_range_in_pfargument202);
                    	range15 = range();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, range15.Tree);
                    	retval.ret = ((range15 != null) ? range15.ret : null);
                    	END_OF_STATEMENT16=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_pfargument211); 
                    		END_OF_STATEMENT16_tree = (object)adaptor.Create(END_OF_STATEMENT16);
                    		adaptor.AddChild(root_0, END_OF_STATEMENT16_tree);


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
    // $ANTLR end "pfargument"

    public class range_return : ParserRuleReturnScope
    {
        public rangeElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "range"
    // vinitgrammer.g:58:1: range returns [rangeElement ret] : (el1= var_or_int_literal '..' el2= var_or_int_literal ) ;
    public vinitgrammerParser.range_return range() // throws RecognitionException [1]
    {   
        vinitgrammerParser.range_return retval = new vinitgrammerParser.range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal17 = null;
        vinitgrammerParser.var_or_int_literal_return el1 = null;

        vinitgrammerParser.var_or_int_literal_return el2 = null;


        object string_literal17_tree=null;


        	retval.ret = new rangeElement();
        	
        try 
    	{
            // vinitgrammer.g:62:2: ( (el1= var_or_int_literal '..' el2= var_or_int_literal ) )
            // vinitgrammer.g:62:4: (el1= var_or_int_literal '..' el2= var_or_int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// vinitgrammer.g:62:4: (el1= var_or_int_literal '..' el2= var_or_int_literal )
            	// vinitgrammer.g:62:7: el1= var_or_int_literal '..' el2= var_or_int_literal
            	{
            		PushFollow(FOLLOW_var_or_int_literal_in_range235);
            		el1 = var_or_int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el1.Tree);
            		 retval.ret.setLow(((el1 != null) ? el1.ret : null)); 
            		string_literal17=(IToken)Match(input,16,FOLLOW_16_in_range252); 
            			string_literal17_tree = (object)adaptor.Create(string_literal17);
            			adaptor.AddChild(root_0, string_literal17_tree);

            		PushFollow(FOLLOW_var_or_int_literal_in_range270);
            		el2 = var_or_int_literal();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, el2.Tree);
            		 retval.ret.setHigh(((el2 != null) ? el2.ret : null)); 

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
    // $ANTLR end "range"

    public class array_return : ParserRuleReturnScope
    {
        public ArrayElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "array"
    // vinitgrammer.g:67:2: array returns [ArrayElement ret] : variable '[' INT_LITERAL ']' ASSIGNMENT ( ( '{' elements '};' ) | ( '{' elements ( ',' elements )+ '};' ) ) ;
    public vinitgrammerParser.array_return array() // throws RecognitionException [1]
    {   
        vinitgrammerParser.array_return retval = new vinitgrammerParser.array_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal19 = null;
        IToken INT_LITERAL20 = null;
        IToken char_literal21 = null;
        IToken ASSIGNMENT22 = null;
        IToken char_literal23 = null;
        IToken string_literal25 = null;
        IToken char_literal26 = null;
        IToken char_literal28 = null;
        IToken string_literal30 = null;
        vinitgrammerParser.variable_return variable18 = null;

        vinitgrammerParser.elements_return elements24 = null;

        vinitgrammerParser.elements_return elements27 = null;

        vinitgrammerParser.elements_return elements29 = null;


        object char_literal19_tree=null;
        object INT_LITERAL20_tree=null;
        object char_literal21_tree=null;
        object ASSIGNMENT22_tree=null;
        object char_literal23_tree=null;
        object string_literal25_tree=null;
        object char_literal26_tree=null;
        object char_literal28_tree=null;
        object string_literal30_tree=null;


         	retval.ret = new ArrayElement();
         	
        try 
    	{
            // vinitgrammer.g:71:3: ( variable '[' INT_LITERAL ']' ASSIGNMENT ( ( '{' elements '};' ) | ( '{' elements ( ',' elements )+ '};' ) ) )
            // vinitgrammer.g:71:5: variable '[' INT_LITERAL ']' ASSIGNMENT ( ( '{' elements '};' ) | ( '{' elements ( ',' elements )+ '};' ) )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_array309);
            	variable18 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable18.Tree);
            	char_literal19=(IToken)Match(input,17,FOLLOW_17_in_array310); 
            		char_literal19_tree = (object)adaptor.Create(char_literal19);
            		adaptor.AddChild(root_0, char_literal19_tree);

            	INT_LITERAL20=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_array311); 
            		INT_LITERAL20_tree = (object)adaptor.Create(INT_LITERAL20);
            		adaptor.AddChild(root_0, INT_LITERAL20_tree);

            	char_literal21=(IToken)Match(input,18,FOLLOW_18_in_array312); 
            		char_literal21_tree = (object)adaptor.Create(char_literal21);
            		adaptor.AddChild(root_0, char_literal21_tree);

            	retval.ret.setLhs(((variable18 != null) ? variable18.ret : null));
            	ASSIGNMENT22=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_array320); 
            		ASSIGNMENT22_tree = (object)adaptor.Create(ASSIGNMENT22);
            		adaptor.AddChild(root_0, ASSIGNMENT22_tree);

            	// vinitgrammer.g:73:5: ( ( '{' elements '};' ) | ( '{' elements ( ',' elements )+ '};' ) )
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == 14) )
            	{
            	    int LA6_1 = input.LA(2);

            	    if ( (LA6_1 == VARIABLE) )
            	    {
            	        int LA6_2 = input.LA(3);

            	        if ( (LA6_2 == 19) )
            	        {
            	            alt6 = 1;
            	        }
            	        else if ( (LA6_2 == 20) )
            	        {
            	            alt6 = 2;
            	        }
            	        else 
            	        {
            	            NoViableAltException nvae_d6s2 =
            	                new NoViableAltException("", 6, 2, input);

            	            throw nvae_d6s2;
            	        }
            	    }
            	    else if ( (LA6_1 == INT_LITERAL) )
            	    {
            	        int LA6_3 = input.LA(3);

            	        if ( (LA6_3 == 20) )
            	        {
            	            alt6 = 2;
            	        }
            	        else if ( (LA6_3 == 19) )
            	        {
            	            alt6 = 1;
            	        }
            	        else 
            	        {
            	            NoViableAltException nvae_d6s3 =
            	                new NoViableAltException("", 6, 3, input);

            	            throw nvae_d6s3;
            	        }
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
            	        // vinitgrammer.g:73:6: ( '{' elements '};' )
            	        {
            	        	// vinitgrammer.g:73:6: ( '{' elements '};' )
            	        	// vinitgrammer.g:73:8: '{' elements '};'
            	        	{
            	        		char_literal23=(IToken)Match(input,14,FOLLOW_14_in_array329); 
            	        			char_literal23_tree = (object)adaptor.Create(char_literal23);
            	        			adaptor.AddChild(root_0, char_literal23_tree);

            	        		PushFollow(FOLLOW_elements_in_array332);
            	        		elements24 = elements();
            	        		state.followingStackPointer--;

            	        		adaptor.AddChild(root_0, elements24.Tree);
            	        		retval.ret.setRhs{((variable18 != null) ? variable18.ret : null)};
            	        		string_literal25=(IToken)Match(input,19,FOLLOW_19_in_array336); 
            	        			string_literal25_tree = (object)adaptor.Create(string_literal25);
            	        			adaptor.AddChild(root_0, string_literal25_tree);


            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // vinitgrammer.g:74:6: ( '{' elements ( ',' elements )+ '};' )
            	        {
            	        	// vinitgrammer.g:74:6: ( '{' elements ( ',' elements )+ '};' )
            	        	// vinitgrammer.g:74:8: '{' elements ( ',' elements )+ '};'
            	        	{
            	        		char_literal26=(IToken)Match(input,14,FOLLOW_14_in_array346); 
            	        			char_literal26_tree = (object)adaptor.Create(char_literal26);
            	        			adaptor.AddChild(root_0, char_literal26_tree);

            	        		PushFollow(FOLLOW_elements_in_array349);
            	        		elements27 = elements();
            	        		state.followingStackPointer--;

            	        		adaptor.AddChild(root_0, elements27.Tree);
            	        		// vinitgrammer.g:74:21: ( ',' elements )+
            	        		int cnt5 = 0;
            	        		do 
            	        		{
            	        		    int alt5 = 2;
            	        		    int LA5_0 = input.LA(1);

            	        		    if ( (LA5_0 == 20) )
            	        		    {
            	        		        alt5 = 1;
            	        		    }


            	        		    switch (alt5) 
            	        			{
            	        				case 1 :
            	        				    // vinitgrammer.g:74:22: ',' elements
            	        				    {
            	        				    	char_literal28=(IToken)Match(input,20,FOLLOW_20_in_array351); 
            	        				    		char_literal28_tree = (object)adaptor.Create(char_literal28);
            	        				    		adaptor.AddChild(root_0, char_literal28_tree);

            	        				    	PushFollow(FOLLOW_elements_in_array352);
            	        				    	elements29 = elements();
            	        				    	state.followingStackPointer--;

            	        				    	adaptor.AddChild(root_0, elements29.Tree);

            	        				    }
            	        				    break;

            	        				default:
            	        				    if ( cnt5 >= 1 ) goto loop5;
            	        			            EarlyExitException eee5 =
            	        			                new EarlyExitException(5, input);
            	        			            throw eee5;
            	        		    }
            	        		    cnt5++;
            	        		} while (true);

            	        		loop5:
            	        			;	// Stops C# compiler whining that label 'loop5' has no statements

            	        		retval.ret.addtolist($int_literal.ret);
            	        		string_literal30=(IToken)Match(input,19,FOLLOW_19_in_array363); 
            	        			string_literal30_tree = (object)adaptor.Create(string_literal30);
            	        			adaptor.AddChild(root_0, string_literal30_tree);


            	        	}


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
    // $ANTLR end "array"

    public class elements_return : ParserRuleReturnScope
    {
        public Element ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elements"
    // vinitgrammer.g:78:1: elements returns [Element ret] : var_or_int_literal ;
    public vinitgrammerParser.elements_return elements() // throws RecognitionException [1]
    {   
        vinitgrammerParser.elements_return retval = new vinitgrammerParser.elements_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        vinitgrammerParser.var_or_int_literal_return var_or_int_literal31 = null;



        try 
    	{
            // vinitgrammer.g:79:2: ( var_or_int_literal )
            // vinitgrammer.g:79:4: var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_elements384);
            	var_or_int_literal31 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal31.Tree);
            	retval.ret = $int_literal.ret;

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elements"

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
    // vinitgrammer.g:93:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT ;
    public vinitgrammerParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        vinitgrammerParser.assignment_return retval = new vinitgrammerParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ASSIGNMENT33 = null;
        IToken END_OF_STATEMENT36 = null;
        vinitgrammerParser.variable_return variable32 = null;

        vinitgrammerParser.var_or_int_literal_return var_or_int_literal34 = null;

        vinitgrammerParser.addition_return addition35 = null;


        object ASSIGNMENT33_tree=null;
        object END_OF_STATEMENT36_tree=null;


          retval.ret = new AssignmentOperationElement();

        try 
    	{
            // vinitgrammer.g:97:3: ( variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT )
            // vinitgrammer.g:97:5: variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_assignment477);
            	variable32 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable32.Tree);
            	retval.ret.setLhs(((variable32 != null) ? variable32.ret : null)); 
            	ASSIGNMENT33=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment485); 
            		ASSIGNMENT33_tree = (object)adaptor.Create(ASSIGNMENT33);
            		adaptor.AddChild(root_0, ASSIGNMENT33_tree);

            	// vinitgrammer.g:99:5: ( var_or_int_literal | addition )
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == VARIABLE) )
            	{
            	    int LA7_1 = input.LA(2);

            	    if ( (LA7_1 == PLUS) )
            	    {
            	        alt7 = 2;
            	    }
            	    else if ( (LA7_1 == END_OF_STATEMENT) )
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
            	else if ( (LA7_0 == INT_LITERAL) )
            	{
            	    int LA7_2 = input.LA(2);

            	    if ( (LA7_2 == END_OF_STATEMENT) )
            	    {
            	        alt7 = 1;
            	    }
            	    else if ( (LA7_2 == PLUS) )
            	    {
            	        alt7 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d7s2 =
            	            new NoViableAltException("", 7, 2, input);

            	        throw nvae_d7s2;
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
            	        // vinitgrammer.g:99:6: var_or_int_literal
            	        {
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment493);
            	        	var_or_int_literal34 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal34.Tree);
            	        	retval.ret.setRhs(((var_or_int_literal34 != null) ? var_or_int_literal34.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // vinitgrammer.g:100:7: addition
            	        {
            	        	PushFollow(FOLLOW_addition_in_assignment504);
            	        	addition35 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition35.Tree);
            	        	retval.ret.setRhs(((addition35 != null) ? addition35.ret : null)); 

            	        }
            	        break;

            	}

            	END_OF_STATEMENT36=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_assignment514); 
            		END_OF_STATEMENT36_tree = (object)adaptor.Create(END_OF_STATEMENT36);
            		adaptor.AddChild(root_0, END_OF_STATEMENT36_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // vinitgrammer.g:103:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public vinitgrammerParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        vinitgrammerParser.var_or_int_literal_return retval = new vinitgrammerParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        vinitgrammerParser.variable_return variable37 = null;

        vinitgrammerParser.int_literal_return int_literal38 = null;



        try 
    	{
            // vinitgrammer.g:104:3: ( ( variable | int_literal ) )
            // vinitgrammer.g:104:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// vinitgrammer.g:104:6: ( variable | int_literal )
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == VARIABLE) )
            	{
            	    alt8 = 1;
            	}
            	else if ( (LA8_0 == INT_LITERAL) )
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
            	        // vinitgrammer.g:104:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal530);
            	        	variable37 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable37.Tree);
            	        	 retval.ret = ((variable37 != null) ? variable37.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // vinitgrammer.g:105:7: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal541);
            	        	int_literal38 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal38.Tree);
            	        	retval.ret = ((int_literal38 != null) ? int_literal38.ret : null); 

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
    // vinitgrammer.g:107:1: variable returns [VariableElement ret] : VARIABLE ;
    public vinitgrammerParser.variable_return variable() // throws RecognitionException [1]
    {   
        vinitgrammerParser.variable_return retval = new vinitgrammerParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE39 = null;

        object VARIABLE39_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // vinitgrammer.g:111:3: ( VARIABLE )
            // vinitgrammer.g:111:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE39=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable564); 
            		VARIABLE39_tree = (object)adaptor.Create(VARIABLE39);
            		adaptor.AddChild(root_0, VARIABLE39_tree);

            	 retval.ret.setText(((VARIABLE39 != null) ? VARIABLE39.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // vinitgrammer.g:113:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public vinitgrammerParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        vinitgrammerParser.int_literal_return retval = new vinitgrammerParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL40 = null;

        object INT_LITERAL40_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // vinitgrammer.g:117:3: ( INT_LITERAL )
            // vinitgrammer.g:117:5: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL40=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal585); 
            		INT_LITERAL40_tree = (object)adaptor.Create(INT_LITERAL40);
            		adaptor.AddChild(root_0, INT_LITERAL40_tree);

            	 retval.ret.setText(((INT_LITERAL40 != null) ? INT_LITERAL40.Text : null)); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
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
    // vinitgrammer.g:119:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
    public vinitgrammerParser.addition_return addition() // throws RecognitionException [1]
    {   
        vinitgrammerParser.addition_return retval = new vinitgrammerParser.addition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal41 = null;
        vinitgrammerParser.var_or_int_literal_return el1 = null;

        vinitgrammerParser.var_or_int_literal_return el2 = null;


        object char_literal41_tree=null;


          retval.ret = new AdditionOperationElement();

        try 
    	{
            // vinitgrammer.g:123:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            // vinitgrammer.g:123:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_addition608);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal41=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition617); 
            		char_literal41_tree = (object)adaptor.Create(char_literal41);
            		adaptor.AddChild(root_0, char_literal41_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_addition626);
            	el2 = var_or_int_literal();
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

    public class function_return : ParserRuleReturnScope
    {
        public FunctionElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "function"
    // vinitgrammer.g:127:1: function returns [FunctionElement ret] : TYPE variable '(' ( declaration ( ',' declaration )* )* ')' '{' program '}' ;
    public vinitgrammerParser.function_return function() // throws RecognitionException [1]
    {   
        vinitgrammerParser.function_return retval = new vinitgrammerParser.function_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TYPE42 = null;
        IToken char_literal44 = null;
        IToken char_literal46 = null;
        IToken char_literal48 = null;
        IToken char_literal49 = null;
        IToken char_literal51 = null;
        vinitgrammerParser.variable_return variable43 = null;

        vinitgrammerParser.declaration_return declaration45 = null;

        vinitgrammerParser.declaration_return declaration47 = null;

        vinitgrammerParser.program_return program50 = null;


        object TYPE42_tree=null;
        object char_literal44_tree=null;
        object char_literal46_tree=null;
        object char_literal48_tree=null;
        object char_literal49_tree=null;
        object char_literal51_tree=null;


        	retval.ret = new FunctionElement();
        	

        try 
    	{
            // vinitgrammer.g:133:2: ( TYPE variable '(' ( declaration ( ',' declaration )* )* ')' '{' program '}' )
            // vinitgrammer.g:133:4: TYPE variable '(' ( declaration ( ',' declaration )* )* ')' '{' program '}'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TYPE42=(IToken)Match(input,TYPE,FOLLOW_TYPE_in_function646); 
            		TYPE42_tree = (object)adaptor.Create(TYPE42);
            		adaptor.AddChild(root_0, TYPE42_tree);

            	retval.ret.setreturntype(TYPE42.Text)
            	PushFollow(FOLLOW_variable_in_function652);
            	variable43 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable43.Tree);
            	retval.ret.setfunctionname(((variable43 != null) ? variable43.ret : null))
            	char_literal44=(IToken)Match(input,12,FOLLOW_12_in_function658); 
            		char_literal44_tree = (object)adaptor.Create(char_literal44);
            		adaptor.AddChild(root_0, char_literal44_tree);

            	// vinitgrammer.g:135:7: ( declaration ( ',' declaration )* )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == TYPE) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // vinitgrammer.g:135:8: declaration ( ',' declaration )*
            			    {
            			    	PushFollow(FOLLOW_declaration_in_function661);
            			    	declaration45 = declaration();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, declaration45.Tree);
            			    	retval.ret.setArguments(((declaration45 != null) ? declaration45.ret : null))
            			    	// vinitgrammer.g:135:62: ( ',' declaration )*
            			    	do 
            			    	{
            			    	    int alt9 = 2;
            			    	    int LA9_0 = input.LA(1);

            			    	    if ( (LA9_0 == 20) )
            			    	    {
            			    	        alt9 = 1;
            			    	    }


            			    	    switch (alt9) 
            			    		{
            			    			case 1 :
            			    			    // vinitgrammer.g:135:63: ',' declaration
            			    			    {
            			    			    	char_literal46=(IToken)Match(input,20,FOLLOW_20_in_function664); 
            			    			    		char_literal46_tree = (object)adaptor.Create(char_literal46);
            			    			    		adaptor.AddChild(root_0, char_literal46_tree);

            			    			    	PushFollow(FOLLOW_declaration_in_function666);
            			    			    	declaration47 = declaration();
            			    			    	state.followingStackPointer--;

            			    			    	adaptor.AddChild(root_0, declaration47.Tree);
            			    			    	retval.ret.setArguments(((declaration45 != null) ? declaration45.ret : null))

            			    			    }
            			    			    break;

            			    			default:
            			    			    goto loop9;
            			    	    }
            			    	} while (true);

            			    	loop9:
            			    		;	// Stops C# compiler whining that label 'loop9' has no statements


            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	char_literal48=(IToken)Match(input,13,FOLLOW_13_in_function672); 
            		char_literal48_tree = (object)adaptor.Create(char_literal48);
            		adaptor.AddChild(root_0, char_literal48_tree);

            	char_literal49=(IToken)Match(input,14,FOLLOW_14_in_function676); 
            		char_literal49_tree = (object)adaptor.Create(char_literal49);
            		adaptor.AddChild(root_0, char_literal49_tree);

            	PushFollow(FOLLOW_program_in_function678);
            	program50 = program();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, program50.Tree);
            	retval.ret.setBody(((program50 != null) ? program50.ret : null))
            	char_literal51=(IToken)Match(input,15,FOLLOW_15_in_function681); 
            		char_literal51_tree = (object)adaptor.Create(char_literal51);
            		adaptor.AddChild(root_0, char_literal51_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "function"

    public class declaration_return : ParserRuleReturnScope
    {
        public DeclerationElement ret;
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "declaration"
    // vinitgrammer.g:140:1: declaration returns [DeclerationElement ret] : TYPE ' ' variable ;
    public vinitgrammerParser.declaration_return declaration() // throws RecognitionException [1]
    {   
        vinitgrammerParser.declaration_return retval = new vinitgrammerParser.declaration_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TYPE52 = null;
        IToken char_literal53 = null;
        vinitgrammerParser.variable_return variable54 = null;


        object TYPE52_tree=null;
        object char_literal53_tree=null;

         retval.ret = new DeclarationElement();

        try 
    	{
            // vinitgrammer.g:143:2: ( TYPE ' ' variable )
            // vinitgrammer.g:144:3: TYPE ' ' variable
            {
            	root_0 = (object)adaptor.GetNilNode();

            	TYPE52=(IToken)Match(input,TYPE,FOLLOW_TYPE_in_declaration710); 
            		TYPE52_tree = (object)adaptor.Create(TYPE52);
            		adaptor.AddChild(root_0, TYPE52_tree);

            	retval.ret.settype(TYPE52.Text)
            	char_literal53=(IToken)Match(input,21,FOLLOW_21_in_declaration713); 
            		char_literal53_tree = (object)adaptor.Create(char_literal53);
            		adaptor.AddChild(root_0, char_literal53_tree);

            	PushFollow(FOLLOW_variable_in_declaration716);
            	variable54 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable54.Tree);
            	retval.ret.setvariable(((variable54 != null) ? variable54.ret : null)) 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "declaration"

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
    // vinitgrammer.g:147:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal END_OF_STATEMENT ;
    public vinitgrammerParser.print_return print() // throws RecognitionException [1]
    {   
        vinitgrammerParser.print_return retval = new vinitgrammerParser.print_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal55 = null;
        IToken END_OF_STATEMENT57 = null;
        vinitgrammerParser.var_or_int_literal_return var_or_int_literal56 = null;


        object string_literal55_tree=null;
        object END_OF_STATEMENT57_tree=null;


          retval.ret = new PrintOperationElement();

        try 
    	{
            // vinitgrammer.g:151:3: ( 'print' var_or_int_literal END_OF_STATEMENT )
            // vinitgrammer.g:151:5: 'print' var_or_int_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal55=(IToken)Match(input,22,FOLLOW_22_in_print739); 
            		string_literal55_tree = (object)adaptor.Create(string_literal55);
            		adaptor.AddChild(root_0, string_literal55_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_print741);
            	var_or_int_literal56 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal56.Tree);
            	retval.ret.setChildElement(((var_or_int_literal56 != null) ? var_or_int_literal56.ret : null)); 
            	END_OF_STATEMENT57=(IToken)Match(input,END_OF_STATEMENT,FOLLOW_END_OF_STATEMENT_in_print749); 
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
    // $ANTLR end "print"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_program74 = new BitSet(new ulong[]{0x0000000000400882UL});
    public static readonly BitSet FOLLOW_assignment_in_expr93 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_print_in_expr101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parallelfor_in_expr109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_11_in_parallelfor132 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_12_in_parallelfor134 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_pfargument_in_parallelfor136 = new BitSet(new ulong[]{0x0000000000002000UL});
    public static readonly BitSet FOLLOW_13_in_parallelfor138 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_14_in_parallelfor145 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_assignment_in_parallelfor148 = new BitSet(new ulong[]{0x0000000000008080UL});
    public static readonly BitSet FOLLOW_15_in_parallelfor154 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_pfargument175 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_pfargument183 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_range_in_pfargument193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_range_in_pfargument202 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_pfargument211 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_range235 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_16_in_range252 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_range270 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_array309 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_array310 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_array311 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_array312 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_array320 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_14_in_array329 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_elements_in_array332 = new BitSet(new ulong[]{0x0000000000080000UL});
    public static readonly BitSet FOLLOW_19_in_array336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_14_in_array346 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_elements_in_array349 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_20_in_array351 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_elements_in_array352 = new BitSet(new ulong[]{0x0000000000180000UL});
    public static readonly BitSet FOLLOW_19_in_array363 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_elements384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment477 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_ASSIGNMENT_in_assignment485 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_assignment493 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_addition_in_assignment504 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_assignment514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_var_or_int_literal530 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_int_literal_in_var_or_int_literal541 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARIABLE_in_variable564 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_LITERAL_in_int_literal585 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition608 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition617 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition626 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TYPE_in_function646 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variable_in_function652 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_12_in_function658 = new BitSet(new ulong[]{0x0000000000002100UL});
    public static readonly BitSet FOLLOW_declaration_in_function661 = new BitSet(new ulong[]{0x0000000000102100UL});
    public static readonly BitSet FOLLOW_20_in_function664 = new BitSet(new ulong[]{0x0000000000000100UL});
    public static readonly BitSet FOLLOW_declaration_in_function666 = new BitSet(new ulong[]{0x0000000000102100UL});
    public static readonly BitSet FOLLOW_13_in_function672 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_14_in_function676 = new BitSet(new ulong[]{0x0000000000400880UL});
    public static readonly BitSet FOLLOW_program_in_function678 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_15_in_function681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TYPE_in_declaration710 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_declaration713 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variable_in_declaration716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_22_in_print739 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print741 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print749 = new BitSet(new ulong[]{0x0000000000000002UL});

}
