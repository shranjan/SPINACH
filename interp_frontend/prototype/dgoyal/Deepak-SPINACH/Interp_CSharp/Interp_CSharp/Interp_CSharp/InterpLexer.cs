// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-10-25 20:41:01


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
    public const int INT_LITERAL = 6;
    public const int T__20 = 20;
    public const int WHITESPACE = 11;
    public const int EOF = -1;
    public const int TYPE = 8;
    public const int T__19 = 19;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int T__18 = 18;
    public const int VARIABLE = 7;
    public const int T__17 = 17;
    public const int T__12 = 12;
    public const int MULTIPLY = 10;
    public const int T__14 = 14;
    public const int T__13 = 13;
    public const int PLUS = 9;
    public const int ASSIGNMENT = 4;
    public const int END_OF_STATEMENT = 5;

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

    // $ANTLR start "T__12"
    public void mT__12() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__12;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:11:7: ( '(' )
            // Interp.g:11:9: '('
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
            // Interp.g:12:7: ( ')' )
            // Interp.g:12:9: ')'
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
            // Interp.g:13:7: ( '[' )
            // Interp.g:13:9: '['
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
    // $ANTLR end "T__14"

    // $ANTLR start "T__15"
    public void mT__15() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__15;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:14:7: ( ']' )
            // Interp.g:14:9: ']'
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
    // $ANTLR end "T__15"

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:15:7: ( 'Struct' )
            // Interp.g:15:9: 'Struct'
            {
            	Match("Struct"); 


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
            // Interp.g:16:7: ( '{' )
            // Interp.g:16:9: '{'
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
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:17:7: ( '}' )
            // Interp.g:17:9: '}'
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
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:18:7: ( '.' )
            // Interp.g:18:9: '.'
            {
            	Match('.'); 

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
            // Interp.g:19:7: ( 'print' )
            // Interp.g:19:9: 'print'
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
    // $ANTLR end "T__20"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:126:17: ( ';' )
            // Interp.g:126:19: ';'
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
            // Interp.g:127:11: ( '=' )
            // Interp.g:127:13: '='
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
            // Interp.g:128:5: ( '+' )
            // Interp.g:128:7: '+'
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

    // $ANTLR start "MULTIPLY"
    public void mMULTIPLY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTIPLY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:129:9: ( '*' )
            // Interp.g:129:11: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MULTIPLY"

    // $ANTLR start "TYPE"
    public void mTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:134:6: ( ( 'int' | 'double' ) )
            // Interp.g:134:8: ( 'int' | 'double' )
            {
            	// Interp.g:134:8: ( 'int' | 'double' )
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == 'i') )
            	{
            	    alt1 = 1;
            	}
            	else if ( (LA1_0 == 'd') )
            	{
            	    alt1 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // Interp.g:134:9: 'int'
            	        {
            	        	Match("int"); 


            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:134:15: 'double'
            	        {
            	        	Match("double"); 


            	        }
            	        break;

            	}


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
            // Interp.g:135:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:135:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:135:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
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
            // Interp.g:136:12: ( ( '0' .. '9' | ',' )+ )
            // Interp.g:136:14: ( '0' .. '9' | ',' )+
            {
            	// Interp.g:136:14: ( '0' .. '9' | ',' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == ',' || (LA3_0 >= '0' && LA3_0 <= '9')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Interp.g:
            			    {
            			    	if ( input.LA(1) == ',' || (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
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
            // Interp.g:138:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:138:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:138:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
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
        // Interp.g:1:8: ( T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULTIPLY | TYPE | VARIABLE | INT_LITERAL | WHITESPACE )
        int alt5 = 17;
        alt5 = dfa5.Predict(input);
        switch (alt5) 
        {
            case 1 :
                // Interp.g:1:10: T__12
                {
                	mT__12(); 

                }
                break;
            case 2 :
                // Interp.g:1:16: T__13
                {
                	mT__13(); 

                }
                break;
            case 3 :
                // Interp.g:1:22: T__14
                {
                	mT__14(); 

                }
                break;
            case 4 :
                // Interp.g:1:28: T__15
                {
                	mT__15(); 

                }
                break;
            case 5 :
                // Interp.g:1:34: T__16
                {
                	mT__16(); 

                }
                break;
            case 6 :
                // Interp.g:1:40: T__17
                {
                	mT__17(); 

                }
                break;
            case 7 :
                // Interp.g:1:46: T__18
                {
                	mT__18(); 

                }
                break;
            case 8 :
                // Interp.g:1:52: T__19
                {
                	mT__19(); 

                }
                break;
            case 9 :
                // Interp.g:1:58: T__20
                {
                	mT__20(); 

                }
                break;
            case 10 :
                // Interp.g:1:64: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 11 :
                // Interp.g:1:81: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 12 :
                // Interp.g:1:92: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 13 :
                // Interp.g:1:97: MULTIPLY
                {
                	mMULTIPLY(); 

                }
                break;
            case 14 :
                // Interp.g:1:106: TYPE
                {
                	mTYPE(); 

                }
                break;
            case 15 :
                // Interp.g:1:111: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 16 :
                // Interp.g:1:120: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 17 :
                // Interp.g:1:132: WHITESPACE
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
        "\x05\uffff\x01\x10\x03\uffff\x01\x10\x04\uffff\x02\x10\x03\uffff"+
        "\x06\x10\x01\x1d\x03\x10\x01\uffff\x02\x10\x01\x23\x01\x10\x01\x25"+
        "\x01\uffff\x01\x1d\x01\uffff";
    const string DFA5_eofS =
        "\x26\uffff";
    const string DFA5_minS =
        "\x01\x09\x04\uffff\x01\x74\x03\uffff\x01\x72\x04\uffff\x01\x6e"+
        "\x01\x6f\x03\uffff\x01\x72\x01\x69\x01\x74\x02\x75\x01\x6e\x01\x41"+
        "\x01\x62\x01\x63\x01\x74\x01\uffff\x01\x6c\x01\x74\x01\x41\x01\x65"+
        "\x01\x41\x01\uffff\x01\x41\x01\uffff";
    const string DFA5_maxS =
        "\x01\x7d\x04\uffff\x01\x74\x03\uffff\x01\x72\x04\uffff\x01\x6e"+
        "\x01\x6f\x03\uffff\x01\x72\x01\x69\x01\x74\x02\x75\x01\x6e\x01\x7a"+
        "\x01\x62\x01\x63\x01\x74\x01\uffff\x01\x6c\x01\x74\x01\x7a\x01\x65"+
        "\x01\x7a\x01\uffff\x01\x7a\x01\uffff";
    const string DFA5_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x06\x01"+
        "\x07\x01\x08\x01\uffff\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x02\uffff"+
        "\x01\x0f\x01\x10\x01\x11\x0a\uffff\x01\x0e\x05\uffff\x01\x09\x01"+
        "\uffff\x01\x05";
    const string DFA5_specialS =
        "\x26\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x02\x12\x02\uffff\x01\x12\x12\uffff\x01\x12\x07\uffff\x01"+
            "\x01\x01\x02\x01\x0d\x01\x0c\x01\x11\x01\uffff\x01\x08\x01\uffff"+
            "\x0a\x11\x01\uffff\x01\x0a\x01\uffff\x01\x0b\x03\uffff\x12\x10"+
            "\x01\x05\x07\x10\x01\x03\x01\uffff\x01\x04\x03\uffff\x03\x10"+
            "\x01\x0f\x04\x10\x01\x0e\x06\x10\x01\x09\x0a\x10\x01\x06\x01"+
            "\uffff\x01\x07",
            "",
            "",
            "",
            "",
            "\x01\x13",
            "",
            "",
            "",
            "\x01\x14",
            "",
            "",
            "",
            "",
            "\x01\x15",
            "\x01\x16",
            "",
            "",
            "",
            "\x01\x17",
            "\x01\x18",
            "\x01\x19",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c",
            "\x1a\x10\x06\uffff\x1a\x10",
            "\x01\x1e",
            "\x01\x1f",
            "\x01\x20",
            "",
            "\x01\x21",
            "\x01\x22",
            "\x1a\x10\x06\uffff\x1a\x10",
            "\x01\x24",
            "\x1a\x10\x06\uffff\x1a\x10",
            "",
            "\x1a\x10\x06\uffff\x1a\x10",
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
            get { return "1:1: Tokens : ( T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULTIPLY | TYPE | VARIABLE | INT_LITERAL | WHITESPACE );"; }
        }

    }

 
    
}
