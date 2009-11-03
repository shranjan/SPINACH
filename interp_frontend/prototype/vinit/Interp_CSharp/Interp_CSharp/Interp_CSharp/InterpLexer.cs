// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-26 20:33:40


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
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

    public InterpLexer() 
    {
		InitializeCyclicDFAs();
    }
    public InterpLexer(ICharStream input)
		: this(input, null) {
    }
    public InterpLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Interp.g";} 
    }

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:11:7: ( 'print' )
            // Interp.g:11:9: 'print'
            {
            	Match("print"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__13"

    // $ANTLR start "Function"
    public void mFunction() // throws RecognitionException [2]
    {
        FunctionElement ret = null;

    		try
    		{
            int _type = Function;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            IToken TYPE1 = null;
            IToken VARIABLE2 = null;
            IToken Declaration13 = null;


            	retval.ret = new FunctionElement();
            	

            // Interp.g:149:2: ( TYPE VARIABLE '(' ( Declaration1 ( ',' Declaration1 )* ) ')' '{' ASSIGNMENT '}' )
            // Interp.g:149:4: TYPE VARIABLE '(' ( Declaration1 ( ',' Declaration1 )* ) ')' '{' ASSIGNMENT '}'
            {
            	int TYPE1Start50 = CharIndex;
            	mTYPE(); 
            	TYPE1 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, TYPE1Start50, CharIndex-1);
            	retval.ret.setreturntype(TYPE1.Text);
            	int VARIABLE2Start56 = CharIndex;
            	mVARIABLE(); 
            	VARIABLE2 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, VARIABLE2Start56, CharIndex-1);
            	retval.ret.setfunctionname(VARIABLE2.ret);
            	Match('('); 
            	// Interp.g:151:7: ( Declaration1 ( ',' Declaration1 )* )
            	// Interp.g:151:8: Declaration1 ( ',' Declaration1 )*
            	{
            		int Declaration13Start65 = CharIndex;
            		mDeclaration1(); 
            		Declaration13 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, Declaration13Start65, CharIndex-1);
            		retval.ret.setArguments(Declaration13)
            		// Interp.g:151:64: ( ',' Declaration1 )*
            		do 
            		{
            		    int alt1 = 2;
            		    int LA1_0 = input.LA(1);

            		    if ( (LA1_0 == ',') )
            		    {
            		        alt1 = 1;
            		    }


            		    switch (alt1) 
            			{
            				case 1 :
            				    // Interp.g:151:65: ',' Declaration1
            				    {
            				    	Match(','); 
            				    	mDeclaration1(); 
            				    	retval.ret.setArguments(Declaration13)

            				    }
            				    break;

            				default:
            				    goto loop1;
            		    }
            		} while (true);

            		loop1:
            			;	// Stops C# compiler whining that label 'loop1' has no statements


            	}

            	Match(')'); 
            	Match('{'); 
            	mASSIGNMENT(); 
            	retval.ret.setBody($assignment.ret);
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Function"

    // $ANTLR start "Declaration1"
    public void mDeclaration1() // throws RecognitionException [2]
    {
        DeclerationElement ret = null;

    		try
    		{
            int _type = Declaration1;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            IToken TYPE4 = null;

             retval.ret = new DeclarationElement();

            // Interp.g:159:2: ( TYPE ' ' VARIABLE )
            // Interp.g:159:4: TYPE ' ' VARIABLE
            {
            	int TYPE4Start111 = CharIndex;
            	mTYPE(); 
            	TYPE4 = new CommonToken(input, Token.INVALID_TOKEN_TYPE, Token.DEFAULT_CHANNEL, TYPE4Start111, CharIndex-1);
            	retval.ret.settype(TYPE4.Text)
            	Match(' '); 
            	mVARIABLE(); 
            	retval.ret.setvariable($variable.ret) 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Declaration1"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:171:17: ( ';' )
            // Interp.g:171:19: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END_OF_STATEMENT"

    // $ANTLR start "ASSIGNMENT"
    public void mASSIGNMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGNMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:173:11: ( '=' )
            // Interp.g:173:13: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGNMENT"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:175:5: ( '+' )
            // Interp.g:175:7: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "TYPE"
    public void mTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:177:5: ( 'int' )
            // Interp.g:177:7: 'int'
            {
            	Match("int"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TYPE"

    // $ANTLR start "VARIABLE"
    public void mVARIABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARIABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:178:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:178:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:178:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= 'A' && LA2_0 <= 'Z') || (LA2_0 >= 'a' && LA2_0 <= 'z')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VARIABLE"

    // $ANTLR start "INT_LITERAL"
    public void mINT_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:180:12: ( ( '0' .. '9' )+ )
            // Interp.g:180:14: ( '0' .. '9' )+
            {
            	// Interp.g:180:14: ( '0' .. '9' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Interp.g:180:15: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT_LITERAL"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:183:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:183:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:183:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '\t' && LA4_0 <= '\n') || LA4_0 == '\r' || LA4_0 == ' ') )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	_channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHITESPACE"

    override public void mTokens() // throws RecognitionException 
    {
        // Interp.g:1:8: ( T__13 | Function | Declaration1 | END_OF_STATEMENT | ASSIGNMENT | PLUS | TYPE | VARIABLE | INT_LITERAL | WHITESPACE )
        int alt5 = 10;
        alt5 = dfa5.Predict(input);
        switch (alt5) 
        {
            case 1 :
                // Interp.g:1:10: T__13
                {
                	mT__13(); 

                }
                break;
            case 2 :
                // Interp.g:1:16: Function
                {
                	mFunction(); 

                }
                break;
            case 3 :
                // Interp.g:1:25: Declaration1
                {
                	mDeclaration1(); 

                }
                break;
            case 4 :
                // Interp.g:1:38: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 5 :
                // Interp.g:1:55: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 6 :
                // Interp.g:1:66: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 7 :
                // Interp.g:1:71: TYPE
                {
                	mTYPE(); 

                }
                break;
            case 8 :
                // Interp.g:1:76: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 9 :
                // Interp.g:1:85: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 10 :
                // Interp.g:1:97: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;

        }

    }


    protected DFA5 dfa5;
	private void InitializeCyclicDFAs()
	{
	    this.dfa5 = new DFA5(this);
	}

    const string DFA5_eotS =
        "\x01\uffff\x02\x06\x06\uffff\x03\x06\x01\x0e\x01\x06\x01\uffff"+
        "\x01\x06\x01\uffff\x01\x13\x02\uffff";
    const string DFA5_eofS =
        "\x14\uffff";
    const string DFA5_minS =
        "\x01\x09\x01\x72\x01\x6e\x06\uffff\x01\x69\x01\x74\x01\x6e\x01"+
        "\x20\x01\x74\x01\uffff\x01\x28\x01\uffff\x01\x41\x02\uffff";
    const string DFA5_maxS =
        "\x01\x7a\x01\x72\x01\x6e\x06\uffff\x01\x69\x01\x74\x01\x6e\x01"+
        "\x7a\x01\x74\x01\uffff\x01\x7a\x01\uffff\x01\x7a\x02\uffff";
    const string DFA5_acceptS =
        "\x03\uffff\x01\x04\x01\x05\x01\x06\x01\x08\x01\x09\x01\x0a\x05"+
        "\uffff\x01\x07\x01\uffff\x01\x03\x01\uffff\x01\x02\x01\x01";
    const string DFA5_specialS =
        "\x14\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x02\x08\x02\uffff\x01\x08\x12\uffff\x01\x08\x0a\uffff\x01"+
            "\x05\x04\uffff\x0a\x07\x01\uffff\x01\x03\x01\uffff\x01\x04\x03"+
            "\uffff\x1a\x06\x06\uffff\x08\x06\x01\x02\x06\x06\x01\x01\x0a"+
            "\x06",
            "\x01\x09",
            "\x01\x0a",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0b",
            "\x01\x0c",
            "\x01\x0d",
            "\x01\x10\x20\uffff\x1a\x0f\x06\uffff\x1a\x0f",
            "\x01\x11",
            "",
            "\x01\x12\x18\uffff\x1a\x0f\x06\uffff\x1a\x0f",
            "",
            "\x1a\x06\x06\uffff\x1a\x06",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__13 | Function | Declaration1 | END_OF_STATEMENT | ASSIGNMENT | PLUS | TYPE | VARIABLE | INT_LITERAL | WHITESPACE );"; }
        }

    }

 
    
}
