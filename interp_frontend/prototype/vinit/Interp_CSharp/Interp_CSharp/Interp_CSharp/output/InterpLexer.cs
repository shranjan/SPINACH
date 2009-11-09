// $ANTLR 3.2 Sep 23, 2009 12:02:23 H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g 2009-10-26 20:47:04


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
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
    	get { return "H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g";} 
    }

    // $ANTLR start "T__11"
    public void mT__11() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__11;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:11:7: ( 'print' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:11:9: 'print'
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
    // $ANTLR end "T__11"

    // $ANTLR start "T__12"
    public void mT__12() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__12;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:12:7: ( '(' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:12:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__12"

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:13:7: ( ',' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:13:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__13"

    // $ANTLR start "T__14"
    public void mT__14() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__14;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:14:7: ( ')' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:14:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__14"

    // $ANTLR start "T__15"
    public void mT__15() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__15;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:15:7: ( '{' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:15:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__15"

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:16:7: ( '}' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:16:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__16"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:171:17: ( ';' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:171:19: ';'
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
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:173:11: ( '=' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:173:13: '='
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
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:175:5: ( '+' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:175:7: '+'
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
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:177:5: ( 'int' )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:177:7: 'int'
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
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:178:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:178:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:178:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= 'A' && LA1_0 <= 'Z') || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:
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
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:180:12: ( ( '0' .. '9' )+ )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:180:14: ( '0' .. '9' )+
            {
            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:180:14: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:180:15: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

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
    // $ANTLR end "INT_LITERAL"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:183:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:183:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:183:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == '\r' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:
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
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

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
        // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:8: ( T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | END_OF_STATEMENT | ASSIGNMENT | PLUS | TYPE | VARIABLE | INT_LITERAL | WHITESPACE )
        int alt4 = 13;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:10: T__11
                {
                	mT__11(); 

                }
                break;
            case 2 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:16: T__12
                {
                	mT__12(); 

                }
                break;
            case 3 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:22: T__13
                {
                	mT__13(); 

                }
                break;
            case 4 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:28: T__14
                {
                	mT__14(); 

                }
                break;
            case 5 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:34: T__15
                {
                	mT__15(); 

                }
                break;
            case 6 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:40: T__16
                {
                	mT__16(); 

                }
                break;
            case 7 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:46: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 8 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:63: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 9 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:74: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 10 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:79: TYPE
                {
                	mTYPE(); 

                }
                break;
            case 11 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:84: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 12 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:93: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 13 :
                // H:\\Interp_CSharp\\Interp_CSharp\\Interp_CSharp\\Interp.g:1:105: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;

        }

    }


    protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	}

    const string DFA4_eotS =
        "\x01\uffff\x01\x0b\x08\uffff\x01\x0b\x03\uffff\x03\x0b\x01\x13"+
        "\x01\x0b\x01\uffff\x01\x15\x01\uffff";
    const string DFA4_eofS =
        "\x16\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x72\x08\uffff\x01\x6e\x03\uffff\x01\x69\x01\x74\x01"+
        "\x6e\x01\x41\x01\x74\x01\uffff\x01\x41\x01\uffff";
    const string DFA4_maxS =
        "\x01\x7d\x01\x72\x08\uffff\x01\x6e\x03\uffff\x01\x69\x01\x74\x01"+
        "\x6e\x01\x7a\x01\x74\x01\uffff\x01\x7a\x01\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07\x01"+
        "\x08\x01\x09\x01\uffff\x01\x0b\x01\x0c\x01\x0d\x05\uffff\x01\x0a"+
        "\x01\uffff\x01\x01";
    const string DFA4_specialS =
        "\x16\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x02\x0d\x02\uffff\x01\x0d\x12\uffff\x01\x0d\x07\uffff\x01"+
            "\x02\x01\x04\x01\uffff\x01\x09\x01\x03\x03\uffff\x0a\x0c\x01"+
            "\uffff\x01\x07\x01\uffff\x01\x08\x03\uffff\x1a\x0b\x06\uffff"+
            "\x08\x0b\x01\x0a\x06\x0b\x01\x01\x0a\x0b\x01\x05\x01\uffff\x01"+
            "\x06",
            "\x01\x0e",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x0f",
            "",
            "",
            "",
            "\x01\x10",
            "\x01\x11",
            "\x01\x12",
            "\x1a\x0b\x06\uffff\x1a\x0b",
            "\x01\x14",
            "",
            "\x1a\x0b\x06\uffff\x1a\x0b",
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
            get { return "1:1: Tokens : ( T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | END_OF_STATEMENT | ASSIGNMENT | PLUS | TYPE | VARIABLE | INT_LITERAL | WHITESPACE );"; }
        }

    }

 
    
}
