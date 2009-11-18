// $ANTLR 3.1.3 Mar 18, 2009 10:09:25 spinach.g 2009-11-17 16:54:25


using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public class spinachLexer : Lexer {
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
    public const int LEFTBRACE = 11;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int LESSTHANEQUALTOEXPRESSION = 24;
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
    public const int VARIABLE = 4;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int STRINGTYPE = 10;
    public const int LEFTPARANTHESIS = 14;
    public const int ASSIGNMENT = 8;

    // delegates
    // delegators

    public spinachLexer() 
    {
		InitializeCyclicDFAs();
    }
    public spinachLexer(ICharStream input)
		: this(input, null) {
    }
    public spinachLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "spinach.g";} 
    }

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:11:7: ( '\"' )
            // spinach.g:11:9: '\"'
            {
            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:12:7: ( 'Matrix' )
            // spinach.g:12:9: 'Matrix'
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
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:13:7: ( '[' )
            // spinach.g:13:9: '['
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
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:14:7: ( ']' )
            // spinach.g:14:9: ']'
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
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:15:7: ( ',' )
            // spinach.g:15:9: ','
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
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:16:7: ( 'Vector' )
            // spinach.g:16:9: 'Vector'
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
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:17:7: ( '-' )
            // spinach.g:17:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:18:7: ( 'struct' )
            // spinach.g:18:9: 'struct'
            {
            	Match("struct"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:19:7: ( 'delete' )
            // spinach.g:19:9: 'delete'
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
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:20:7: ( 'print' )
            // spinach.g:20:9: 'print'
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
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:21:7: ( 'parallelfor' )
            // spinach.g:21:9: 'parallelfor'
            {
            	Match("parallelfor"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:22:7: ( 'to' )
            // spinach.g:22:9: 'to'
            {
            	Match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:23:7: ( 'SYNC' )
            // spinach.g:23:9: 'SYNC'
            {
            	Match("SYNC"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:24:7: ( 'if' )
            // spinach.g:24:9: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:25:7: ( 'else' )
            // spinach.g:25:9: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:26:7: ( 'for' )
            // spinach.g:26:9: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:27:7: ( 'void' )
            // spinach.g:27:9: 'void'
            {
            	Match("void"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:28:7: ( 'DOT' )
            // spinach.g:28:9: 'DOT'
            {
            	Match("DOT"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:29:7: ( 'T' )
            // spinach.g:29:9: 'T'
            {
            	Match('T'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:30:7: ( '//' )
            // spinach.g:30:9: '//'
            {
            	Match("//"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:31:7: ( 'return' )
            // spinach.g:31:9: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:32:7: ( 'subPlot' )
            // spinach.g:32:9: 'subPlot'
            {
            	Match("subPlot"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:33:7: ( '1D' )
            // spinach.g:33:9: '1D'
            {
            	Match("1D"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:34:7: ( '2D' )
            // spinach.g:34:9: '2D'
            {
            	Match("2D"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:35:7: ( '3D' )
            // spinach.g:35:9: '3D'
            {
            	Match("3D"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:36:7: ( 'plot' )
            // spinach.g:36:9: 'plot'
            {
            	Match("plot"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:37:7: ( 'resetPlot' )
            // spinach.g:37:9: 'resetPlot'
            {
            	Match("resetPlot"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:38:7: ( 'setPlotAxis' )
            // spinach.g:38:9: 'setPlotAxis'
            {
            	Match("setPlotAxis"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:39:7: ( 'setAxisTitle' )
            // spinach.g:39:9: 'setAxisTitle'
            {
            	Match("setAxisTitle"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:40:7: ( 'setScaleMode' )
            // spinach.g:40:9: 'setScaleMode'
            {
            	Match("setScaleMode"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "END_OF_STATEMENT"
    public void mEND_OF_STATEMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END_OF_STATEMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:431:17: ( ';' )
            // spinach.g:431:19: ';'
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

    // $ANTLR start "SCALEMODE"
    public void mSCALEMODE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SCALEMODE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:432:10: ( 'log' | 'linear' )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == 'l') )
            {
                int LA1_1 = input.LA(2);

                if ( (LA1_1 == 'o') )
                {
                    alt1 = 1;
                }
                else if ( (LA1_1 == 'i') )
                {
                    alt1 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d1s1 =
                        new NoViableAltException("", 1, 1, input);

                    throw nvae_d1s1;
                }
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
                    // spinach.g:432:12: 'log'
                    {
                    	Match("log"); 


                    }
                    break;
                case 2 :
                    // spinach.g:432:20: 'linear'
                    {
                    	Match("linear"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SCALEMODE"

    // $ANTLR start "VARTYPE"
    public void mVARTYPE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARTYPE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:433:9: ( 'int' | 'double' )
            int alt2 = 2;
            int LA2_0 = input.LA(1);

            if ( (LA2_0 == 'i') )
            {
                alt2 = 1;
            }
            else if ( (LA2_0 == 'd') )
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
                    // spinach.g:433:11: 'int'
                    {
                    	Match("int"); 


                    }
                    break;
                case 2 :
                    // spinach.g:433:19: 'double'
                    {
                    	Match("double"); 


                    }
                    break;

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
            // spinach.g:434:12: ( 'string' )
            // spinach.g:434:14: 'string'
            {
            	Match("string"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRINGTYPE"

    // $ANTLR start "DOT"
    public void mDOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:435:5: ( '.' )
            // spinach.g:435:6: '.'
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
    // $ANTLR end "DOT"

    // $ANTLR start "ASSIGNMENT"
    public void mASSIGNMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGNMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:436:11: ( '=' )
            // spinach.g:436:13: '='
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
            // spinach.g:437:5: ( '+' )
            // spinach.g:437:7: '+'
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
            // spinach.g:438:9: ( '*' )
            // spinach.g:438:10: '*'
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

    // $ANTLR start "VARIABLE"
    public void mVARIABLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VARIABLE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:439:9: ( ( 'a' .. 'z' | 'A' .. 'Z' )+ )
            // spinach.g:439:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            {
            	// spinach.g:439:11: ( 'a' .. 'z' | 'A' .. 'Z' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= 'A' && LA3_0 <= 'Z') || (LA3_0 >= 'a' && LA3_0 <= 'z')) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // spinach.g:
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
    // $ANTLR end "VARIABLE"

    // $ANTLR start "INT_LITERAL"
    public void mINT_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:440:12: ( ( '0' .. '9' )+ )
            // spinach.g:440:14: ( '0' .. '9' )+
            {
            	// spinach.g:440:14: ( '0' .. '9' )+
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
            			    // spinach.g:440:15: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

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
    // $ANTLR end "INT_LITERAL"

    // $ANTLR start "DOUBLE_LITERAL"
    public void mDOUBLE_LITERAL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DOUBLE_LITERAL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:441:15: ( ( INT_LITERAL DOT INT_LITERAL ) )
            // spinach.g:441:16: ( INT_LITERAL DOT INT_LITERAL )
            {
            	// spinach.g:441:16: ( INT_LITERAL DOT INT_LITERAL )
            	// spinach.g:441:17: INT_LITERAL DOT INT_LITERAL
            	{
            		mINT_LITERAL(); 
            		mDOT(); 
            		mINT_LITERAL(); 

            	}


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
            // spinach.g:442:12: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // spinach.g:442:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// spinach.g:442:14: ( ' ' | '\\t' | '\\n' | '\\r' )+
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
            			    // spinach.g:
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

    // $ANTLR start "LEFTBRACE"
    public void mLEFTBRACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEFTBRACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:443:11: ( '(' )
            // spinach.g:443:12: '('
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
    // $ANTLR end "LEFTBRACE"

    // $ANTLR start "RIGHTBRACE"
    public void mRIGHTBRACE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RIGHTBRACE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:444:11: ( ')' )
            // spinach.g:444:12: ')'
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
    // $ANTLR end "RIGHTBRACE"

    // $ANTLR start "LEFTPARANTHESIS"
    public void mLEFTPARANTHESIS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LEFTPARANTHESIS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:445:16: ( '{' )
            // spinach.g:445:17: '{'
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
    // $ANTLR end "LEFTPARANTHESIS"

    // $ANTLR start "RIGHTPARANTHESIS"
    public void mRIGHTPARANTHESIS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RIGHTPARANTHESIS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:446:17: ( '}' )
            // spinach.g:446:18: '}'
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
    // $ANTLR end "RIGHTPARANTHESIS"

    // $ANTLR start "POINT"
    public void mPOINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = POINT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:447:6: ( '->' )
            // spinach.g:447:8: '->'
            {
            	Match("->"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "POINT"

    // $ANTLR start "EQUALITYEXPRESSION"
    public void mEQUALITYEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUALITYEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:448:19: ( '==' )
            // spinach.g:448:21: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQUALITYEXPRESSION"

    // $ANTLR start "NONEQUALITYEXPRESSION"
    public void mNONEQUALITYEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NONEQUALITYEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:449:22: ( '!=' )
            // spinach.g:449:24: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NONEQUALITYEXPRESSION"

    // $ANTLR start "LESSTHANEXPRESSION"
    public void mLESSTHANEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESSTHANEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:450:20: ( '<' )
            // spinach.g:450:21: '<'
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
    // $ANTLR end "LESSTHANEXPRESSION"

    // $ANTLR start "LESSTHANEQUALTOEXPRESSION"
    public void mLESSTHANEQUALTOEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESSTHANEQUALTOEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:451:26: ( '<=' )
            // spinach.g:451:27: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LESSTHANEQUALTOEXPRESSION"

    // $ANTLR start "GREATERTHANEXPRESSION"
    public void mGREATERTHANEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GREATERTHANEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:452:23: ( '>' )
            // spinach.g:452:24: '>'
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
    // $ANTLR end "GREATERTHANEXPRESSION"

    // $ANTLR start "GREATERTHANEQUALTOEXPRESSION"
    public void mGREATERTHANEQUALTOEXPRESSION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GREATERTHANEQUALTOEXPRESSION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // spinach.g:453:29: ( '>=' )
            // spinach.g:453:30: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GREATERTHANEQUALTOEXPRESSION"

    override public void mTokens() // throws RecognitionException 
    {
        // spinach.g:1:8: ( T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | END_OF_STATEMENT | SCALEMODE | VARTYPE | STRINGTYPE | DOT | ASSIGNMENT | PLUS | MULTIPLY | VARIABLE | INT_LITERAL | DOUBLE_LITERAL | WHITESPACE | LEFTBRACE | RIGHTBRACE | LEFTPARANTHESIS | RIGHTPARANTHESIS | POINT | EQUALITYEXPRESSION | NONEQUALITYEXPRESSION | LESSTHANEXPRESSION | LESSTHANEQUALTOEXPRESSION | GREATERTHANEXPRESSION | GREATERTHANEQUALTOEXPRESSION )
        int alt6 = 53;
        alt6 = dfa6.Predict(input);
        switch (alt6) 
        {
            case 1 :
                // spinach.g:1:10: T__27
                {
                	mT__27(); 

                }
                break;
            case 2 :
                // spinach.g:1:16: T__28
                {
                	mT__28(); 

                }
                break;
            case 3 :
                // spinach.g:1:22: T__29
                {
                	mT__29(); 

                }
                break;
            case 4 :
                // spinach.g:1:28: T__30
                {
                	mT__30(); 

                }
                break;
            case 5 :
                // spinach.g:1:34: T__31
                {
                	mT__31(); 

                }
                break;
            case 6 :
                // spinach.g:1:40: T__32
                {
                	mT__32(); 

                }
                break;
            case 7 :
                // spinach.g:1:46: T__33
                {
                	mT__33(); 

                }
                break;
            case 8 :
                // spinach.g:1:52: T__34
                {
                	mT__34(); 

                }
                break;
            case 9 :
                // spinach.g:1:58: T__35
                {
                	mT__35(); 

                }
                break;
            case 10 :
                // spinach.g:1:64: T__36
                {
                	mT__36(); 

                }
                break;
            case 11 :
                // spinach.g:1:70: T__37
                {
                	mT__37(); 

                }
                break;
            case 12 :
                // spinach.g:1:76: T__38
                {
                	mT__38(); 

                }
                break;
            case 13 :
                // spinach.g:1:82: T__39
                {
                	mT__39(); 

                }
                break;
            case 14 :
                // spinach.g:1:88: T__40
                {
                	mT__40(); 

                }
                break;
            case 15 :
                // spinach.g:1:94: T__41
                {
                	mT__41(); 

                }
                break;
            case 16 :
                // spinach.g:1:100: T__42
                {
                	mT__42(); 

                }
                break;
            case 17 :
                // spinach.g:1:106: T__43
                {
                	mT__43(); 

                }
                break;
            case 18 :
                // spinach.g:1:112: T__44
                {
                	mT__44(); 

                }
                break;
            case 19 :
                // spinach.g:1:118: T__45
                {
                	mT__45(); 

                }
                break;
            case 20 :
                // spinach.g:1:124: T__46
                {
                	mT__46(); 

                }
                break;
            case 21 :
                // spinach.g:1:130: T__47
                {
                	mT__47(); 

                }
                break;
            case 22 :
                // spinach.g:1:136: T__48
                {
                	mT__48(); 

                }
                break;
            case 23 :
                // spinach.g:1:142: T__49
                {
                	mT__49(); 

                }
                break;
            case 24 :
                // spinach.g:1:148: T__50
                {
                	mT__50(); 

                }
                break;
            case 25 :
                // spinach.g:1:154: T__51
                {
                	mT__51(); 

                }
                break;
            case 26 :
                // spinach.g:1:160: T__52
                {
                	mT__52(); 

                }
                break;
            case 27 :
                // spinach.g:1:166: T__53
                {
                	mT__53(); 

                }
                break;
            case 28 :
                // spinach.g:1:172: T__54
                {
                	mT__54(); 

                }
                break;
            case 29 :
                // spinach.g:1:178: T__55
                {
                	mT__55(); 

                }
                break;
            case 30 :
                // spinach.g:1:184: T__56
                {
                	mT__56(); 

                }
                break;
            case 31 :
                // spinach.g:1:190: END_OF_STATEMENT
                {
                	mEND_OF_STATEMENT(); 

                }
                break;
            case 32 :
                // spinach.g:1:207: SCALEMODE
                {
                	mSCALEMODE(); 

                }
                break;
            case 33 :
                // spinach.g:1:217: VARTYPE
                {
                	mVARTYPE(); 

                }
                break;
            case 34 :
                // spinach.g:1:225: STRINGTYPE
                {
                	mSTRINGTYPE(); 

                }
                break;
            case 35 :
                // spinach.g:1:236: DOT
                {
                	mDOT(); 

                }
                break;
            case 36 :
                // spinach.g:1:240: ASSIGNMENT
                {
                	mASSIGNMENT(); 

                }
                break;
            case 37 :
                // spinach.g:1:251: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 38 :
                // spinach.g:1:256: MULTIPLY
                {
                	mMULTIPLY(); 

                }
                break;
            case 39 :
                // spinach.g:1:265: VARIABLE
                {
                	mVARIABLE(); 

                }
                break;
            case 40 :
                // spinach.g:1:274: INT_LITERAL
                {
                	mINT_LITERAL(); 

                }
                break;
            case 41 :
                // spinach.g:1:286: DOUBLE_LITERAL
                {
                	mDOUBLE_LITERAL(); 

                }
                break;
            case 42 :
                // spinach.g:1:301: WHITESPACE
                {
                	mWHITESPACE(); 

                }
                break;
            case 43 :
                // spinach.g:1:312: LEFTBRACE
                {
                	mLEFTBRACE(); 

                }
                break;
            case 44 :
                // spinach.g:1:322: RIGHTBRACE
                {
                	mRIGHTBRACE(); 

                }
                break;
            case 45 :
                // spinach.g:1:333: LEFTPARANTHESIS
                {
                	mLEFTPARANTHESIS(); 

                }
                break;
            case 46 :
                // spinach.g:1:349: RIGHTPARANTHESIS
                {
                	mRIGHTPARANTHESIS(); 

                }
                break;
            case 47 :
                // spinach.g:1:366: POINT
                {
                	mPOINT(); 

                }
                break;
            case 48 :
                // spinach.g:1:372: EQUALITYEXPRESSION
                {
                	mEQUALITYEXPRESSION(); 

                }
                break;
            case 49 :
                // spinach.g:1:391: NONEQUALITYEXPRESSION
                {
                	mNONEQUALITYEXPRESSION(); 

                }
                break;
            case 50 :
                // spinach.g:1:413: LESSTHANEXPRESSION
                {
                	mLESSTHANEXPRESSION(); 

                }
                break;
            case 51 :
                // spinach.g:1:432: LESSTHANEQUALTOEXPRESSION
                {
                	mLESSTHANEQUALTOEXPRESSION(); 

                }
                break;
            case 52 :
                // spinach.g:1:458: GREATERTHANEXPRESSION
                {
                	mGREATERTHANEXPRESSION(); 

                }
                break;
            case 53 :
                // spinach.g:1:480: GREATERTHANEQUALTOEXPRESSION
                {
                	mGREATERTHANEQUALTOEXPRESSION(); 

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
        "\x02\uffff\x01\x1e\x03\uffff\x01\x1e\x01\x2b\x0a\x1e\x01\x3c\x01"+
        "\uffff\x01\x1e\x03\x3f\x01\uffff\x01\x1e\x01\uffff\x01\x46\x03\uffff"+
        "\x01\x3f\x06\uffff\x01\x48\x01\x4a\x02\x1e\x02\uffff\x08\x1e\x01"+
        "\x55\x01\x1e\x01\x57\x05\x1e\x01\uffff\x01\x1e\x05\uffff\x02\x1e"+
        "\x06\uffff\x0a\x1e\x01\uffff\x01\x1e\x01\uffff\x01\x6f\x01\x1e\x01"+
        "\x71\x01\x1e\x01\x73\x02\x1e\x01\x76\x0d\x1e\x01\u0084\x01\u0085"+
        "\x01\uffff\x01\u0086\x01\uffff\x01\u0087\x01\uffff\x02\x1e\x01\uffff"+
        "\x0b\x1e\x01\u0095\x01\x1e\x04\uffff\x03\x1e\x01\u009a\x01\u009b"+
        "\x01\u009c\x01\u009d\x04\x1e\x01\u00a2\x01\x6f\x01\uffff\x01\x1e"+
        "\x01\u00a4\x01\x1e\x01\x76\x04\uffff\x01\u00a6\x03\x1e\x01\uffff"+
        "\x01\x1e\x01\uffff\x01\x1e\x01\uffff\x09\x1e\x01\u00b5\x04\x1e\x01"+
        "\uffff\x01\u00ba\x02\x1e\x01\u00bd\x01\uffff\x01\u00be\x01\u00bf"+
        "\x03\uffff";
    const string DFA6_eofS =
        "\u00c0\uffff";
    const string DFA6_minS =
        "\x01\x09\x01\uffff\x01\x61\x03\uffff\x01\x65\x01\x3e\x02\x65\x01"+
        "\x61\x01\x6f\x01\x59\x01\x66\x01\x6c\x02\x6f\x01\x4f\x01\x41\x01"+
        "\uffff\x01\x65\x03\x2e\x01\uffff\x01\x69\x01\uffff\x01\x3d\x03\uffff"+
        "\x01\x2e\x06\uffff\x02\x3d\x01\x74\x01\x63\x02\uffff\x01\x72\x01"+
        "\x62\x01\x74\x01\x6c\x01\x75\x01\x69\x01\x72\x01\x6f\x01\x41\x01"+
        "\x4e\x01\x41\x01\x74\x01\x73\x01\x72\x01\x69\x01\x54\x01\uffff\x01"+
        "\x73\x05\uffff\x01\x67\x01\x6e\x06\uffff\x01\x72\x01\x74\x01\x69"+
        "\x01\x50\x01\x41\x01\x65\x01\x62\x01\x6e\x01\x61\x01\x74\x01\uffff"+
        "\x01\x43\x01\uffff\x01\x41\x01\x65\x01\x41\x01\x64\x01\x41\x01\x75"+
        "\x01\x65\x01\x41\x01\x65\x01\x69\x01\x6f\x01\x63\x01\x6e\x02\x6c"+
        "\x01\x78\x01\x63\x01\x74\x01\x6c\x01\x74\x01\x6c\x02\x41\x01\uffff"+
        "\x01\x41\x01\uffff\x01\x41\x01\uffff\x01\x72\x01\x74\x01\uffff\x01"+
        "\x61\x01\x78\x01\x72\x01\x74\x01\x67\x02\x6f\x01\x69\x01\x61\x02"+
        "\x65\x01\x41\x01\x6c\x04\uffff\x01\x6e\x01\x50\x01\x72\x04\x41\x02"+
        "\x74\x01\x73\x01\x6c\x02\x41\x01\uffff\x01\x65\x01\x41\x01\x6c\x01"+
        "\x41\x04\uffff\x02\x41\x01\x54\x01\x65\x01\uffff\x01\x6c\x01\uffff"+
        "\x01\x6f\x01\uffff\x01\x78\x01\x69\x01\x4d\x01\x66\x01\x74\x01\x69"+
        "\x01\x74\x02\x6f\x01\x41\x01\x73\x01\x6c\x01\x64\x01\x72\x01\uffff"+
        "\x01\x41\x02\x65\x01\x41\x01\uffff\x02\x41\x03\uffff";
    const string DFA6_maxS =
        "\x01\x7d\x01\uffff\x01\x61\x03\uffff\x01\x65\x01\x3e\x01\x75\x01"+
        "\x6f\x01\x72\x01\x6f\x01\x59\x01\x6e\x01\x6c\x02\x6f\x01\x4f\x01"+
        "\x7a\x01\uffff\x01\x65\x03\x44\x01\uffff\x01\x6f\x01\uffff\x01\x3d"+
        "\x03\uffff\x01\x39\x06\uffff\x02\x3d\x01\x74\x01\x63\x02\uffff\x01"+
        "\x72\x01\x62\x01\x74\x01\x6c\x01\x75\x01\x69\x01\x72\x01\x6f\x01"+
        "\x7a\x01\x4e\x01\x7a\x01\x74\x01\x73\x01\x72\x01\x69\x01\x54\x01"+
        "\uffff\x01\x74\x05\uffff\x01\x67\x01\x6e\x06\uffff\x01\x72\x01\x74"+
        "\x01\x75\x01\x50\x01\x53\x01\x65\x01\x62\x01\x6e\x01\x61\x01\x74"+
        "\x01\uffff\x01\x43\x01\uffff\x01\x7a\x01\x65\x01\x7a\x01\x64\x01"+
        "\x7a\x01\x75\x01\x65\x01\x7a\x01\x65\x01\x69\x01\x6f\x01\x63\x01"+
        "\x6e\x02\x6c\x01\x78\x01\x63\x01\x74\x01\x6c\x01\x74\x01\x6c\x02"+
        "\x7a\x01\uffff\x01\x7a\x01\uffff\x01\x7a\x01\uffff\x01\x72\x01\x74"+
        "\x01\uffff\x01\x61\x01\x78\x01\x72\x01\x74\x01\x67\x02\x6f\x01\x69"+
        "\x01\x61\x02\x65\x01\x7a\x01\x6c\x04\uffff\x01\x6e\x01\x50\x01\x72"+
        "\x04\x7a\x02\x74\x01\x73\x01\x6c\x02\x7a\x01\uffff\x01\x65\x01\x7a"+
        "\x01\x6c\x01\x7a\x04\uffff\x01\x7a\x01\x41\x01\x54\x01\x65\x01\uffff"+
        "\x01\x6c\x01\uffff\x01\x6f\x01\uffff\x01\x78\x01\x69\x01\x4d\x01"+
        "\x66\x01\x74\x01\x69\x01\x74\x02\x6f\x01\x7a\x01\x73\x01\x6c\x01"+
        "\x64\x01\x72\x01\uffff\x01\x7a\x02\x65\x01\x7a\x01\uffff\x02\x7a"+
        "\x03\uffff";
    const string DFA6_acceptS =
        "\x01\uffff\x01\x01\x01\uffff\x01\x03\x01\x04\x01\x05\x0d\uffff"+
        "\x01\x14\x04\uffff\x01\x1f\x01\uffff\x01\x23\x01\uffff\x01\x25\x01"+
        "\x26\x01\x27\x01\uffff\x01\x2a\x01\x2b\x01\x2c\x01\x2d\x01\x2e\x01"+
        "\x31\x04\uffff\x01\x2f\x01\x07\x10\uffff\x01\x13\x01\uffff\x01\x17"+
        "\x01\x28\x01\x29\x01\x18\x01\x19\x02\uffff\x01\x30\x01\x24\x01\x33"+
        "\x01\x32\x01\x35\x01\x34\x0a\uffff\x01\x0c\x01\uffff\x01\x0e\x17"+
        "\uffff\x01\x21\x01\uffff\x01\x10\x01\uffff\x01\x12\x02\uffff\x01"+
        "\x20\x0d\uffff\x01\x1a\x01\x0d\x01\x0f\x01\x11\x0d\uffff\x01\x0a"+
        "\x04\uffff\x01\x02\x01\x06\x01\x08\x01\x22\x04\uffff\x01\x09\x01"+
        "\uffff\x01\x15\x01\uffff\x01\x16\x0e\uffff\x01\x1b\x04\uffff\x01"+
        "\x1c\x02\uffff\x01\x0b\x01\x1d\x01\x1e";
    const string DFA6_specialS =
        "\u00c0\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x02\x20\x02\uffff\x01\x20\x12\uffff\x01\x20\x01\x25\x01\x01"+
            "\x05\uffff\x01\x21\x01\x22\x01\x1d\x01\x1c\x01\x05\x01\x07\x01"+
            "\x1a\x01\x13\x01\x1f\x01\x15\x01\x16\x01\x17\x06\x1f\x01\uffff"+
            "\x01\x18\x01\x26\x01\x1b\x01\x27\x02\uffff\x03\x1e\x01\x11\x08"+
            "\x1e\x01\x02\x05\x1e\x01\x0c\x01\x12\x01\x1e\x01\x06\x04\x1e"+
            "\x01\x03\x01\uffff\x01\x04\x03\uffff\x03\x1e\x01\x09\x01\x0e"+
            "\x01\x0f\x02\x1e\x01\x0d\x02\x1e\x01\x19\x03\x1e\x01\x0a\x01"+
            "\x1e\x01\x14\x01\x08\x01\x0b\x01\x1e\x01\x10\x04\x1e\x01\x23"+
            "\x01\uffff\x01\x24",
            "",
            "\x01\x28",
            "",
            "",
            "",
            "\x01\x29",
            "\x01\x2a",
            "\x01\x2e\x0e\uffff\x01\x2c\x01\x2d",
            "\x01\x2f\x09\uffff\x01\x30",
            "\x01\x32\x0a\uffff\x01\x33\x05\uffff\x01\x31",
            "\x01\x34",
            "\x01\x35",
            "\x01\x36\x07\uffff\x01\x37",
            "\x01\x38",
            "\x01\x39",
            "\x01\x3a",
            "\x01\x3b",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "\x01\x3d",
            "\x01\x40\x01\uffff\x0a\x1f\x0a\uffff\x01\x3e",
            "\x01\x40\x01\uffff\x0a\x1f\x0a\uffff\x01\x41",
            "\x01\x40\x01\uffff\x0a\x1f\x0a\uffff\x01\x42",
            "",
            "\x01\x44\x05\uffff\x01\x43",
            "",
            "\x01\x45",
            "",
            "",
            "",
            "\x01\x40\x01\uffff\x0a\x1f",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x47",
            "\x01\x49",
            "\x01\x4b",
            "\x01\x4c",
            "",
            "",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f",
            "\x01\x50",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "\x01\x54",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\x56",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "",
            "\x01\x5e\x01\x5d",
            "",
            "",
            "",
            "",
            "",
            "\x01\x5f",
            "\x01\x60",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x61",
            "\x01\x62",
            "\x01\x64\x0b\uffff\x01\x63",
            "\x01\x65",
            "\x01\x67\x0e\uffff\x01\x66\x02\uffff\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b",
            "\x01\x6c",
            "\x01\x6d",
            "",
            "\x01\x6e",
            "",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\x70",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\x72",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\x74",
            "\x01\x75",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x01\x7c",
            "\x01\x7d",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0083",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "\x01\u0088",
            "\x01\u0089",
            "",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "\x01\u008d",
            "\x01\u008e",
            "\x01\u008f",
            "\x01\u0090",
            "\x01\u0091",
            "\x01\u0092",
            "\x01\u0093",
            "\x01\u0094",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\u0096",
            "",
            "",
            "",
            "",
            "\x01\u0097",
            "\x01\u0098",
            "\x01\u0099",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\u009e",
            "\x01\u009f",
            "\x01\u00a0",
            "\x01\u00a1",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "\x01\u00a3",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\u00a5",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "",
            "",
            "",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\u00a7",
            "\x01\u00a8",
            "\x01\u00a9",
            "",
            "\x01\u00aa",
            "",
            "\x01\u00ab",
            "",
            "\x01\u00ac",
            "\x01\u00ad",
            "\x01\u00ae",
            "\x01\u00af",
            "\x01\u00b0",
            "\x01\u00b1",
            "\x01\u00b2",
            "\x01\u00b3",
            "\x01\u00b4",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\u00b6",
            "\x01\u00b7",
            "\x01\u00b8",
            "\x01\u00b9",
            "",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "",
            "\x1a\x1e\x06\uffff\x1a\x1e",
            "\x1a\x1e\x06\uffff\x1a\x1e",
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
            get { return "1:1: Tokens : ( T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | END_OF_STATEMENT | SCALEMODE | VARTYPE | STRINGTYPE | DOT | ASSIGNMENT | PLUS | MULTIPLY | VARIABLE | INT_LITERAL | DOUBLE_LITERAL | WHITESPACE | LEFTBRACE | RIGHTBRACE | LEFTPARANTHESIS | RIGHTPARANTHESIS | POINT | EQUALITYEXPRESSION | NONEQUALITYEXPRESSION | LESSTHANEXPRESSION | LESSTHANEQUALTOEXPRESSION | GREATERTHANEXPRESSION | GREATERTHANEQUALTOEXPRESSION );"; }
        }

    }

 
    
}
