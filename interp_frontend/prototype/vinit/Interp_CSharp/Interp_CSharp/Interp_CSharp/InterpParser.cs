// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-26 20:33:39


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
		"VARIABLE", 
		"INT_LITERAL", 
		"TYPE", 
		"Declaration1", 
		"Function", 
		"PLUS", 
		"WHITESPACE", 
		"'print'"
    };

    public const int INT_LITERAL = 7;
    public const int VARIABLE = 6;
    public const int Function = 10;
    public const int Declaration1 = 9;
    public const int T__13 = 13;
    public const int WHITESPACE = 12;
    public const int PLUS = 11;
    public const int ASSIGNMENT = 4;
    public const int EOF = -1;
    public const int END_OF_STATEMENT = 5;
    public const int TYPE = 8;

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
    // Interp.g:41:1: program returns [List<Element> ret] : ( expr )+ ;
    public InterpParser.program_return program() // throws RecognitionException [1]
    {   
        InterpParser.program_return retval = new InterpParser.program_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.expr_return expr1 = null;




          retval.ret = new List<Element>();

        try 
    	{
            // Interp.g:49:3: ( ( expr )+ )
            // Interp.g:49:5: ( expr )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:49:5: ( expr )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARIABLE || LA1_0 == 13) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Interp.g:49:6: expr
            			    {
            			    	PushFollow(FOLLOW_expr_in_program91);
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
    // Interp.g:53:1: expr returns [Element ret] : ( assignment | print );
    public InterpParser.expr_return expr() // throws RecognitionException [1]
    {   
        InterpParser.expr_return retval = new InterpParser.expr_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.assignment_return assignment2 = null;

        InterpParser.print_return print3 = null;



        try 
    	{
            // Interp.g:56:3: ( assignment | print )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == VARIABLE) )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 13) )
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
                    // Interp.g:56:5: assignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignment_in_expr115);
                    	assignment2 = assignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, assignment2.Tree);
                    	retval.ret = ((assignment2 != null) ? assignment2.ret : null);

                    }
                    break;
                case 2 :
                    // Interp.g:57:5: print
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_print_in_expr123);
                    	print3 = print();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, print3.Tree);
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
    // Interp.g:62:1: assignment returns [AssignmentOperationElement ret] : variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT ;
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



        try 
    	{
            // Interp.g:73:3: ( variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT )
            // Interp.g:73:5: variable ASSIGNMENT ( var_or_int_literal | addition ) END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variable_in_assignment151);
            	variable4 = variable();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variable4.Tree);
            	retval.ret.setLhs(((variable4 != null) ? variable4.ret : null)); 
            	ASSIGNMENT5=(IToken)Match(input,ASSIGNMENT,FOLLOW_ASSIGNMENT_in_assignment162); 
            		ASSIGNMENT5_tree = (object)adaptor.Create(ASSIGNMENT5);
            		adaptor.AddChild(root_0, ASSIGNMENT5_tree);

            	// Interp.g:77:4: ( var_or_int_literal | addition )
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == VARIABLE) )
            	{
            	    int LA3_1 = input.LA(2);

            	    if ( (LA3_1 == PLUS) )
            	    {
            	        alt3 = 2;
            	    }
            	    else if ( (LA3_1 == END_OF_STATEMENT) )
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

            	        throw nvae_d3s2;
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
            	        // Interp.g:77:5: var_or_int_literal
            	        {
            	        	PushFollow(FOLLOW_var_or_int_literal_in_assignment173);
            	        	var_or_int_literal6 = var_or_int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, var_or_int_literal6.Tree);
            	        	retval.ret.setRhs(((var_or_int_literal6 != null) ? var_or_int_literal6.ret : null)); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:78:7: addition
            	        {
            	        	PushFollow(FOLLOW_addition_in_assignment184);
            	        	addition7 = addition();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, addition7.Tree);
            	        	retval.ret.setRhs(((addition7 != null) ? addition7.ret : null)); 

            	        }
            	        break;

            	}

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
    // Interp.g:83:1: var_or_int_literal returns [Element ret] : ( variable | int_literal ) ;
    public InterpParser.var_or_int_literal_return var_or_int_literal() // throws RecognitionException [1]
    {   
        InterpParser.var_or_int_literal_return retval = new InterpParser.var_or_int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        InterpParser.variable_return variable9 = null;

        InterpParser.int_literal_return int_literal10 = null;



        try 
    	{
            // Interp.g:85:3: ( ( variable | int_literal ) )
            // Interp.g:85:6: ( variable | int_literal )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Interp.g:85:6: ( variable | int_literal )
            	int alt4 = 2;
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

            	    throw nvae_d4s0;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Interp.g:85:7: variable
            	        {
            	        	PushFollow(FOLLOW_variable_in_var_or_int_literal214);
            	        	variable9 = variable();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variable9.Tree);
            	        	 retval.ret = ((variable9 != null) ? variable9.ret : null); 

            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:87:4: int_literal
            	        {
            	        	PushFollow(FOLLOW_int_literal_in_var_or_int_literal227);
            	        	int_literal10 = int_literal();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, int_literal10.Tree);
            	        	retval.ret = ((int_literal10 != null) ? int_literal10.ret : null); 

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
    // Interp.g:91:1: variable returns [VariableElement ret] : VARIABLE ;
    public InterpParser.variable_return variable() // throws RecognitionException [1]
    {   
        InterpParser.variable_return retval = new InterpParser.variable_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken VARIABLE11 = null;

        object VARIABLE11_tree=null;


          retval.ret = new VariableElement();

        try 
    	{
            // Interp.g:99:3: ( VARIABLE )
            // Interp.g:99:5: VARIABLE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	VARIABLE11=(IToken)Match(input,VARIABLE,FOLLOW_VARIABLE_in_variable257); 
            		VARIABLE11_tree = (object)adaptor.Create(VARIABLE11);
            		adaptor.AddChild(root_0, VARIABLE11_tree);

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
    // Interp.g:103:1: int_literal returns [IntegerElement ret] : INT_LITERAL ;
    public InterpParser.int_literal_return int_literal() // throws RecognitionException [1]
    {   
        InterpParser.int_literal_return retval = new InterpParser.int_literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INT_LITERAL12 = null;

        object INT_LITERAL12_tree=null;


          retval.ret = new IntegerElement();

        try 
    	{
            // Interp.g:111:2: ( INT_LITERAL )
            // Interp.g:111:4: INT_LITERAL
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INT_LITERAL12=(IToken)Match(input,INT_LITERAL,FOLLOW_INT_LITERAL_in_int_literal285); 
            		INT_LITERAL12_tree = (object)adaptor.Create(INT_LITERAL12);
            		adaptor.AddChild(root_0, INT_LITERAL12_tree);

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
    // Interp.g:115:1: addition returns [AdditionOperationElement ret] : el1= var_or_int_literal '+' el2= var_or_int_literal ;
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

        try 
    	{
            // Interp.g:123:3: (el1= var_or_int_literal '+' el2= var_or_int_literal )
            // Interp.g:123:5: el1= var_or_int_literal '+' el2= var_or_int_literal
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_var_or_int_literal_in_addition315);
            	el1 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, el1.Tree);
            	 retval.ret.setLhs(((el1 != null) ? el1.ret : null)); 
            	char_literal13=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_addition327); 
            		char_literal13_tree = (object)adaptor.Create(char_literal13);
            		adaptor.AddChild(root_0, char_literal13_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_addition341);
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
    // Interp.g:131:1: print returns [PrintOperationElement ret] : 'print' var_or_int_literal END_OF_STATEMENT ;
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

        try 
    	{
            // Interp.g:139:2: ( 'print' var_or_int_literal END_OF_STATEMENT )
            // Interp.g:139:4: 'print' var_or_int_literal END_OF_STATEMENT
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal14=(IToken)Match(input,13,FOLLOW_13_in_print369); 
            		string_literal14_tree = (object)adaptor.Create(string_literal14);
            		adaptor.AddChild(root_0, string_literal14_tree);

            	PushFollow(FOLLOW_var_or_int_literal_in_print371);
            	var_or_int_literal15 = var_or_int_literal();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, var_or_int_literal15.Tree);
            	retval.ret.setChildElement(((var_or_int_literal15 != null) ? var_or_int_literal15.ret : null)); 
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
        return retval;
    }
    // $ANTLR end "print"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_expr_in_program91 = new BitSet(new ulong[]{0x0000000000002042UL});
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
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition315 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_PLUS_in_addition327 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_addition341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_print369 = new BitSet(new ulong[]{0x00000000000000C0UL});
    public static readonly BitSet FOLLOW_var_or_int_literal_in_print371 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_END_OF_STATEMENT_in_print381 = new BitSet(new ulong[]{0x0000000000000002UL});

}
