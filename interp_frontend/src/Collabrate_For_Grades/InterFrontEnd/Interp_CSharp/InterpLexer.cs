// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 Interp.g 2009-11-03 18:50:11


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class InterpLexer : Lexer {
    public const int INT_LITERAL = 6;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int DOUBLE_LITERAL = 7;
    public const int WHITESPACE = 13;
    public const int EOF = -1;
    public const int VARTYPE = 9;
    public const int T__19 = 19;
    public const int T__16 = 16;
    public const int T__15 = 15;
    public const int VARIABLE = 8;
    public const int T__18 = 18;
    public const int T__17 = 17;
    public const int MULTIPLY = 12;
    public const int T__14 = 14;
    public const int STRINGTYPE = 10;
    public const int PLUS = 11;
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

    // $ANTLR start "T__14"
    public void mT__14() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__14;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:11:7: ( 'Matrix' )
            // Interp.g:11:9: 'Matrix'
            {
            	Match("Matrix"); 


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
            // Interp.g:12:7: ( '<' )
            // Interp.g:12:9: '<'
            {
            	Match('<'); 

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
            // Interp.g:13:7: ( '>' )
            // Interp.g:13:9: '>'
            {
            	Match('>'); 

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
            // Interp.g:14:7: ( '[' )
            // Interp.g:14:9: '['
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
            // Interp.g:15:7: ( ']' )
            // Interp.g:15:9: ']'
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
            // Interp.g:16:7: ( ',' )
            // Interp.g:16:9: ','
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
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:17:7: ( 'Vector' )
            // Interp.g:17:9: 'Vector'
            {
            	Match("Vector"); 


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
            // Interp.g:18:7: ( 'Struct' )
            // Interp.g:18:9: 'Struct'
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
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:19:7: ( '{' )
            // Interp.g:19:9: '{'
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
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:20:7: ( '}' )
            // Interp.g:20:9: '}'
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
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:21:7: ( '.' )
            // Interp.g:21:9: '.'
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
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:22:7: ( 'delete' )
            // Interp.g:22:9: 'delete'
            {
            	Match("delete"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:23:7: ( 'print' )
            // Interp.g:23:9: 'print'
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
    // $ANTLR end "T__26"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:166:17: ( ';' )
            // Interp.g:166:19: ';'
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
            // Interp.g:167:11: ( '=' )
            // Interp.g:167:13: '='
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
            // Interp.g:168:5: ( '+' )
            // Interp.g:168:7: '+'
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
            // Interp.g:169:9: ( '*' )
            // Interp.g:169:11: '*'
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

    // $ANTLR start "VARTYPE"
    public void mVARTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARTYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:174:9: ( ( 'int' | 'double' ) )
            // Interp.g:174:11: ( 'int' | 'double' )
            {
            	// Interp.g:174:11: ( 'int' | 'double' )
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
            	        // Interp.g:174:12: 'int'
            	        {
            	        	Match("int"); 


            	        }
            	        break;
            	    case 2 :
            	        // Interp.g:174:18: 'double'
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
    // $ANTLR end "VARTYPE"

    // $ANTLR start "STRINGTYPE"
    public void mSTRINGTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRINGTYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:175:12: ( ( 'String' ) )
            // Interp.g:175:14: ( 'String' )
            {
            	// Interp.g:175:14: ( 'String' )
            	// Interp.g:175:15: 'String'
            	{
            		Match("String"); 


            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRINGTYPE"

    // $ANTLR start "VARIABLE"
    public void mVARIABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARIABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:176:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // Interp.g:176:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// Interp.g:176:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
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
            // Interp.g:177:12: ( ( '0' .. '9' )+ )
            // Interp.g:177:14: ( '0' .. '9' )+
            {
            	// Interp.g:177:14: ( '0' .. '9' )+
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
            			    // Interp.g:177:15: '0' .. '9'
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

    // $ANTLR start "DOUBLE_LITERAL"
    public void mDOUBLE_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLE_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:178:15: ( ( INT_LITERAL '.' INT_LITERAL )+ )
            // Interp.g:178:16: ( INT_LITERAL '.' INT_LITERAL )+
            {
            	// Interp.g:178:16: ( INT_LITERAL '.' INT_LITERAL )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // Interp.g:178:17: INT_LITERAL '.' INT_LITERAL
            			    {
            			    	mINT_LITERAL(); 
            			    	Match('.'); 
            			    	mINT_LITERAL(); 

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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DOUBLE_LITERAL"

    // $ANTLR start "WHITESPACE"
    public void mWHITESPACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHITESPACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Interp.g:180:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // Interp.g:180:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// Interp.g:180:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt5 = 0;
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '\t' && LA5_0 <= '\n') || LA5_0 == '\r' || LA5_0 == ' ') )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
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
            			    if ( cnt5 >= 1 ) goto loop5;
            		            EarlyExitException eee5 =
            		                new EarlyExitException(5, input);
            		            throw eee5;
            	    }
            	    cnt5++;
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

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
        // Interp.g:1:8: ( T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULTIPLY | VARTYPE | STRINGTYPE | VARIABLE | INT_LITERAL | DOUBLE_LITERAL | WHITESPACE )
        int alt6 = 23;
        alt6 = dfa6.Predict(input);
        switch (alt6) 
        {
            case 1 :
                // Interp.g:1:10: T__14
                {
                	mT__14(); 

                }
                break;
            case 2 :
                // Interp.g:1:16: T__15
                {
                	mT__15(); 

                }
                break;
            case 3 :
                // Interp.g:1:22: T__16
                {
                	mT__16(); 

                }
                break;
            case 4 :
                // Interp.g:1:28: T__17
                {
                	mT__17(); 

                }
                break;
            case 5 :
                // Interp.g:1:34: T__18
                {
                	mT__18(); 

                }
                break;
            case 6 :
                // Interp.g:1:40: T__19
                {
                	mT__19(); 

                }
                break;
            case 7 :
                // Interp.g:1:46: T__20
                {
                	mT__20(); 

                }
                break;
            case 8 :
                // Interp.g:1:52: T__21
                {
                	mT__21(); 

                }
                break;
            case 9 :
                // Interp.g:1:58: T__22
                {
                	mT__22(); 

                }
                break;
            case 10 :
                // Interp.g:1:64: T__23
                {
                	mT__23(); 

                }
                break;
            case 11 :
                // Interp.g:1:70: T__24
                {
                	mT__24(); 

                }
                break;
            case 12 :
                // Interp.g:1:76: T__25
                {
                	mT__25(); 

                }
                break;
            case 13 :
                // Interp.g:1:82: T__26
                {
                	mT__26(); 

                }
                break;
            case 14 :
                // Interp.g:1:88: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 15 :
                // Interp.g:1:105: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 16 :
                // Interp.g:1:116: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 17 :
                // Interp.g:1:121: MULTIPLY
                {
                	mMULTIPLY(); 

                }
                break;
            case 18 :
                // Interp.g:1:130: VARTYPE
                {
                	mVARTYPE(); 

                }
                break;
            case 19 :
                // Interp.g:1:138: STRINGTYPE
                {
                	mSTRINGTYPE(); 

                }
                break;
            case 20 :
                // Interp.g:1:149: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 21 :
                // Interp.g:1:158: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 22 :
                // Interp.g:1:170: DOUBLE_LITERAL
                {
                	mDOUBLE_LITERAL(); 

                }
                break;
            case 23 :
                // Interp.g:1:185: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;

        }

    }


    protected DFA6 dfa6;
	private void InitializeCyclicDFAs()
	{
	    this.dfa6 = new DFA6(this);
	}

    const string DFA6_eotS =
        "\x01\uffff\x01\x13\x05\uffff\x02\x13\x03\uffff\x02\x13\x04\uffff"+
        "\x01\x13\x01\uffff\x01\x1d\x01\uffff\x07\x13\x02\uffff\x06\x13\x01"+
        "\x2d\x07\x13\x01\uffff\x06\x13\x01\x3b\x01\x3c\x01\x3d\x01\x3e\x01"+
        "\x3f\x01\x40\x01\x2d\x06\uffff";
    const string DFA6_eofS =
        "\x41\uffff";
    const string DFA6_minS =
        "\x01\x09\x01\x61\x05\uffff\x01\x65\x01\x74\x03\uffff\x01\x65\x01"+
        "\x72\x04\uffff\x01\x6e\x01\uffff\x01\x2e\x01\uffff\x01\x74\x01\x63"+
        "\x01\x72\x01\x6c\x01\x75\x01\x69\x01\x74\x02\uffff\x01\x72\x01\x74"+
        "\x01\x69\x01\x65\x01\x62\x01\x6e\x01\x41\x01\x69\x01\x6f\x01\x63"+
        "\x01\x6e\x01\x74\x01\x6c\x01\x74\x01\uffff\x01\x78\x01\x72\x01\x74"+
        "\x01\x67\x02\x65\x07\x41\x06\uffff";
    const string DFA6_maxS =
        "\x01\x7d\x01\x61\x05\uffff\x01\x65\x01\x74\x03\uffff\x01\x6f\x01"+
        "\x72\x04\uffff\x01\x6e\x01\uffff\x01\x39\x01\uffff\x01\x74\x01\x63"+
        "\x01\x72\x01\x6c\x01\x75\x01\x69\x01\x74\x02\uffff\x01\x72\x01\x74"+
        "\x01\x75\x01\x65\x01\x62\x01\x6e\x01\x7a\x01\x69\x01\x6f\x01\x63"+
        "\x01\x6e\x01\x74\x01\x6c\x01\x74\x01\uffff\x01\x78\x01\x72\x01\x74"+
        "\x01\x67\x02\x65\x07\x7a\x06\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x02\uffff\x01"+
        "\x09\x01\x0a\x01\x0b\x02\uffff\x01\x0e\x01\x0f\x01\x10\x01\x11\x01"+
        "\uffff\x01\x14\x01\uffff\x01\x17\x07\uffff\x01\x15\x01\x16\x0e\uffff"+
        "\x01\x12\x0d\uffff\x01\x0d\x01\x01\x01\x07\x01\x08\x01\x13\x01\x0c";
    const string DFA6_specialS =
        "\x41\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x02\x15\x02\uffff\x01\x15\x12\uffff\x01\x15\x09\uffff\x01"+
            "\x11\x01\x10\x01\x06\x01\uffff\x01\x0b\x01\uffff\x0a\x14\x01"+
            "\uffff\x01\x0e\x01\x02\x01\x0f\x01\x03\x02\uffff\x0c\x13\x01"+
            "\x01\x05\x13\x01\x08\x02\x13\x01\x07\x04\x13\x01\x04\x01\uffff"+
            "\x01\x05\x03\uffff\x03\x13\x01\x0c\x04\x13\x01\x12\x06\x13\x01"+
            "\x0d\x0a\x13\x01\x09\x01\uffff\x01\x0a",
            "\x01\x16",
            "",
            "",
            "",
            "",
            "",
            "\x01\x17",
            "\x01\x18",
            "",
            "",
            "",
            "\x01\x19\x09\uffff\x01\x1a",
            "\x01\x1b",
            "",
            "",
            "",
            "",
            "\x01\x1c",
            "",
            "\x01\x1e\x01\uffff\x0a\x14",
            "",
            "\x01\x1f",
            "\x01\x20",
            "\x01\x21",
            "\x01\x22",
            "\x01\x23",
            "\x01\x24",
            "\x01\x25",
            "",
            "",
            "\x01\x26",
            "\x01\x27",
            "\x01\x29\x0b\uffff\x01\x28",
            "\x01\x2a",
            "\x01\x2b",
            "\x01\x2c",
            "\x1a\x13\x06\uffff\x1a\x13",
            "\x01\x2e",
            "\x01\x2f",
            "\x01\x30",
            "\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34",
            "",
            "\x01\x35",
            "\x01\x36",
            "\x01\x37",
            "\x01\x38",
            "\x01\x39",
            "\x01\x3a",
            "\x1a\x13\x06\uffff\x1a\x13",
            "\x1a\x13\x06\uffff\x1a\x13",
            "\x1a\x13\x06\uffff\x1a\x13",
            "\x1a\x13\x06\uffff\x1a\x13",
            "\x1a\x13\x06\uffff\x1a\x13",
            "\x1a\x13\x06\uffff\x1a\x13",
            "\x1a\x13\x06\uffff\x1a\x13",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | END_OF_STATEMENT | ASSIGNMENT | PLUS | MULTIPLY | VARTYPE | STRINGTYPE | VARIABLE | INT_LITERAL | DOUBLE_LITERAL | WHITESPACE );"; }
        }

    }

 
    
}
