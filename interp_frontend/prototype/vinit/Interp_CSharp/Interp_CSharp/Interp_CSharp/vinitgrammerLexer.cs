// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 vinitgrammer.g 2009-10-26 19:18:43


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class vinitgrammerLexer : Lexer {
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

    public vinitgrammerLexer() 
    {
		InitializeCyclicDFAs();
    }
    public vinitgrammerLexer(ICharStream input)
		: this(input, null) {
    }
    public vinitgrammerLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "vinitgrammer.g";} 
    }

    // $ANTLR start "T__11"
    public void mT__11() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__11;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:11:7: ( 'parallel_for' )
            // vinitgrammer.g:11:9: 'parallel_for'
            {
            	Match("parallel_for"); 


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
            // vinitgrammer.g:12:7: ( '(' )
            // vinitgrammer.g:12:9: '('
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
            // vinitgrammer.g:13:7: ( ')' )
            // vinitgrammer.g:13:9: ')'
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
    // $ANTLR end "T__13"

    // $ANTLR start "T__14"
    public void mT__14() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__14;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:14:7: ( '{' )
            // vinitgrammer.g:14:9: '{'
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
    // $ANTLR end "T__14"

    // $ANTLR start "T__15"
    public void mT__15() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__15;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:15:7: ( '}' )
            // vinitgrammer.g:15:9: '}'
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
    // $ANTLR end "T__15"

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:16:7: ( '..' )
            // vinitgrammer.g:16:9: '..'
            {
            	Match(".."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__16"

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:17:7: ( '[' )
            // vinitgrammer.g:17:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:18:7: ( ']' )
            // vinitgrammer.g:18:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:19:7: ( '};' )
            // vinitgrammer.g:19:9: '};'
            {
            	Match("};"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:20:7: ( ',' )
            // vinitgrammer.g:20:9: ','
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
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:21:7: ( ' ' )
            // vinitgrammer.g:21:9: ' '
            {
            	Match(' '); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:22:7: ( 'print' )
            // vinitgrammer.g:22:9: 'print'
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
    // $ANTLR end "T__22"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:159:17: ( ';' )
            // vinitgrammer.g:159:19: ';'
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
            // vinitgrammer.g:160:11: ( '=' )
            // vinitgrammer.g:160:13: '='
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

    // $ANTLR start "TYPE"
    public void mTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:161:6: ( 'int' )
            // vinitgrammer.g:161:7: 'int'
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

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:162:5: ( '+' )
            // vinitgrammer.g:162:7: '+'
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

    // $ANTLR start "VARIABLE"
    public void mVARIABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARIABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // vinitgrammer.g:163:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // vinitgrammer.g:163:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// vinitgrammer.g:163:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
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
            			    // vinitgrammer.g:
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
            // vinitgrammer.g:164:12: ( ( '0' .. '9' )+ )
            // vinitgrammer.g:164:14: ( '0' .. '9' )+
            {
            	// vinitgrammer.g:164:14: ( '0' .. '9' )+
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
            			    // vinitgrammer.g:164:15: '0' .. '9'
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
            // vinitgrammer.g:165:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // vinitgrammer.g:165:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// vinitgrammer.g:165:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
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
            			    // vinitgrammer.g:
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
        // vinitgrammer.g:1:8: ( T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | END_OF_STATEMENT | ASSIGNMENT | TYPE | PLUS | VARIABLE | INT_LITERAL | WHITESPACE )
        int alt4 = 19;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // vinitgrammer.g:1:10: T__11
                {
                	mT__11(); 

                }
                break;
            case 2 :
                // vinitgrammer.g:1:16: T__12
                {
                	mT__12(); 

                }
                break;
            case 3 :
                // vinitgrammer.g:1:22: T__13
                {
                	mT__13(); 

                }
                break;
            case 4 :
                // vinitgrammer.g:1:28: T__14
                {
                	mT__14(); 

                }
                break;
            case 5 :
                // vinitgrammer.g:1:34: T__15
                {
                	mT__15(); 

                }
                break;
            case 6 :
                // vinitgrammer.g:1:40: T__16
                {
                	mT__16(); 

                }
                break;
            case 7 :
                // vinitgrammer.g:1:46: T__17
                {
                	mT__17(); 

                }
                break;
            case 8 :
                // vinitgrammer.g:1:52: T__18
                {
                	mT__18(); 

                }
                break;
            case 9 :
                // vinitgrammer.g:1:58: T__19
                {
                	mT__19(); 

                }
                break;
            case 10 :
                // vinitgrammer.g:1:64: T__20
                {
                	mT__20(); 

                }
                break;
            case 11 :
                // vinitgrammer.g:1:70: T__21
                {
                	mT__21(); 

                }
                break;
            case 12 :
                // vinitgrammer.g:1:76: T__22
                {
                	mT__22(); 

                }
                break;
            case 13 :
                // vinitgrammer.g:1:82: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 14 :
                // vinitgrammer.g:1:99: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 15 :
                // vinitgrammer.g:1:110: TYPE
                {
                	mTYPE(); 

                }
                break;
            case 16 :
                // vinitgrammer.g:1:115: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 17 :
                // vinitgrammer.g:1:120: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 18 :
                // vinitgrammer.g:1:129: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 19 :
                // vinitgrammer.g:1:141: WHITESPACE
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
        "\x01\uffff\x01\x0f\x03\uffff\x01\x15\x04\uffff\x01\x16\x02\uffff"+
        "\x01\x0f\x04\uffff\x02\x0f\x03\uffff\x03\x0f\x01\x1d\x02\x0f\x01"+
        "\uffff\x01\x0f\x01\x21\x01\x0f\x01\uffff\x02\x0f\x01\uffff";
    const string DFA4_eofS =
        "\x25\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x61\x03\uffff\x01\x3b\x04\uffff\x01\x09\x02\uffff"+
        "\x01\x6e\x04\uffff\x01\x72\x01\x69\x03\uffff\x01\x74\x01\x61\x01"+
        "\x6e\x01\x41\x01\x6c\x01\x74\x01\uffff\x01\x6c\x01\x41\x01\x65\x01"+
        "\uffff\x01\x6c\x01\x5f\x01\uffff";
    const string DFA4_maxS =
        "\x01\x7d\x01\x72\x03\uffff\x01\x3b\x04\uffff\x01\x20\x02\uffff"+
        "\x01\x6e\x04\uffff\x01\x72\x01\x69\x03\uffff\x01\x74\x01\x61\x01"+
        "\x6e\x01\x7a\x01\x6c\x01\x74\x01\uffff\x01\x6c\x01\x7a\x01\x65\x01"+
        "\uffff\x01\x6c\x01\x5f\x01\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x06\x01\x07\x01"+
        "\x08\x01\x0a\x01\uffff\x01\x0d\x01\x0e\x01\uffff\x01\x10\x01\x11"+
        "\x01\x12\x01\x13\x02\uffff\x01\x09\x01\x05\x01\x0b\x06\uffff\x01"+
        "\x0f\x03\uffff\x01\x0c\x02\uffff\x01\x01";
    const string DFA4_specialS =
        "\x25\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x02\x11\x02\uffff\x01\x11\x12\uffff\x01\x0a\x07\uffff\x01"+
            "\x02\x01\x03\x01\uffff\x01\x0e\x01\x09\x01\uffff\x01\x06\x01"+
            "\uffff\x0a\x10\x01\uffff\x01\x0b\x01\uffff\x01\x0c\x03\uffff"+
            "\x1a\x0f\x01\x07\x01\uffff\x01\x08\x03\uffff\x08\x0f\x01\x0d"+
            "\x06\x0f\x01\x01\x0a\x0f\x01\x04\x01\uffff\x01\x05",
            "\x01\x12\x10\uffff\x01\x13",
            "",
            "",
            "",
            "\x01\x14",
            "",
            "",
            "",
            "",
            "\x02\x11\x02\uffff\x01\x11\x12\uffff\x01\x11",
            "",
            "",
            "\x01\x17",
            "",
            "",
            "",
            "",
            "\x01\x18",
            "\x01\x19",
            "",
            "",
            "",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c",
            "\x1a\x0f\x06\uffff\x1a\x0f",
            "\x01\x1e",
            "\x01\x1f",
            "",
            "\x01\x20",
            "\x1a\x0f\x06\uffff\x1a\x0f",
            "\x01\x22",
            "",
            "\x01\x23",
            "\x01\x24",
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
            get { return "1:1: Tokens : ( T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | END_OF_STATEMENT | ASSIGNMENT | TYPE | PLUS | VARIABLE | INT_LITERAL | WHITESPACE );"; }
        }

    }

 
    
}
