//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g 2012-07-15 08:56:15

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

namespace  RegexLib.Parsers.JavaScript 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
public partial class JavaScriptRegExpLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int CARAT=4;
	public const int CHAR=5;
	public const int COMMA=6;
	public const int DIGIT=7;
	public const int DOLLAR=8;
	public const int DOT=9;
	public const int L_CURLY=10;
	public const int PIPE=11;
	public const int PLUS=12;
	public const int QUESTION=13;
	public const int R_CURLY=14;
	public const int STAR=15;

    // delegates
    // delegators

	public JavaScriptRegExpLexer()
	{
		OnCreated();
	}

	public JavaScriptRegExpLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public JavaScriptRegExpLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_CARAT();
	partial void LeaveRule_CARAT();

	// $ANTLR start "CARAT"
	[GrammarRule("CARAT")]
	private void mCARAT()
	{
		EnterRule_CARAT();
		EnterRule("CARAT", 1);
		TraceIn("CARAT", 1);
		try
		{
			int _type = CARAT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:9:7: ( '^' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:9:9: '^'
			{
			DebugLocation(9, 9);
			Match('^'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CARAT", 1);
			LeaveRule("CARAT", 1);
			LeaveRule_CARAT();
		}
	}
	// $ANTLR end "CARAT"

	partial void EnterRule_COMMA();
	partial void LeaveRule_COMMA();

	// $ANTLR start "COMMA"
	[GrammarRule("COMMA")]
	private void mCOMMA()
	{
		EnterRule_COMMA();
		EnterRule("COMMA", 2);
		TraceIn("COMMA", 2);
		try
		{
			int _type = COMMA;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:10:7: ( ',' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:10:9: ','
			{
			DebugLocation(10, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMA", 2);
			LeaveRule("COMMA", 2);
			LeaveRule_COMMA();
		}
	}
	// $ANTLR end "COMMA"

	partial void EnterRule_DOLLAR();
	partial void LeaveRule_DOLLAR();

	// $ANTLR start "DOLLAR"
	[GrammarRule("DOLLAR")]
	private void mDOLLAR()
	{
		EnterRule_DOLLAR();
		EnterRule("DOLLAR", 3);
		TraceIn("DOLLAR", 3);
		try
		{
			int _type = DOLLAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:11:8: ( '$' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:11:10: '$'
			{
			DebugLocation(11, 10);
			Match('$'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOLLAR", 3);
			LeaveRule("DOLLAR", 3);
			LeaveRule_DOLLAR();
		}
	}
	// $ANTLR end "DOLLAR"

	partial void EnterRule_DOT();
	partial void LeaveRule_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		EnterRule_DOT();
		EnterRule("DOT", 4);
		TraceIn("DOT", 4);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:12:5: ( '.' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:12:7: '.'
			{
			DebugLocation(12, 7);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 4);
			LeaveRule("DOT", 4);
			LeaveRule_DOT();
		}
	}
	// $ANTLR end "DOT"

	partial void EnterRule_L_CURLY();
	partial void LeaveRule_L_CURLY();

	// $ANTLR start "L_CURLY"
	[GrammarRule("L_CURLY")]
	private void mL_CURLY()
	{
		EnterRule_L_CURLY();
		EnterRule("L_CURLY", 5);
		TraceIn("L_CURLY", 5);
		try
		{
			int _type = L_CURLY;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:13:9: ( '{' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:13:11: '{'
			{
			DebugLocation(13, 11);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("L_CURLY", 5);
			LeaveRule("L_CURLY", 5);
			LeaveRule_L_CURLY();
		}
	}
	// $ANTLR end "L_CURLY"

	partial void EnterRule_PIPE();
	partial void LeaveRule_PIPE();

	// $ANTLR start "PIPE"
	[GrammarRule("PIPE")]
	private void mPIPE()
	{
		EnterRule_PIPE();
		EnterRule("PIPE", 6);
		TraceIn("PIPE", 6);
		try
		{
			int _type = PIPE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:14:6: ( '|' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:14:8: '|'
			{
			DebugLocation(14, 8);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PIPE", 6);
			LeaveRule("PIPE", 6);
			LeaveRule_PIPE();
		}
	}
	// $ANTLR end "PIPE"

	partial void EnterRule_PLUS();
	partial void LeaveRule_PLUS();

	// $ANTLR start "PLUS"
	[GrammarRule("PLUS")]
	private void mPLUS()
	{
		EnterRule_PLUS();
		EnterRule("PLUS", 7);
		TraceIn("PLUS", 7);
		try
		{
			int _type = PLUS;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:15:6: ( '+' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:15:8: '+'
			{
			DebugLocation(15, 8);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PLUS", 7);
			LeaveRule("PLUS", 7);
			LeaveRule_PLUS();
		}
	}
	// $ANTLR end "PLUS"

	partial void EnterRule_QUESTION();
	partial void LeaveRule_QUESTION();

	// $ANTLR start "QUESTION"
	[GrammarRule("QUESTION")]
	private void mQUESTION()
	{
		EnterRule_QUESTION();
		EnterRule("QUESTION", 8);
		TraceIn("QUESTION", 8);
		try
		{
			int _type = QUESTION;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:16:10: ( '?' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:16:12: '?'
			{
			DebugLocation(16, 12);
			Match('?'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("QUESTION", 8);
			LeaveRule("QUESTION", 8);
			LeaveRule_QUESTION();
		}
	}
	// $ANTLR end "QUESTION"

	partial void EnterRule_R_CURLY();
	partial void LeaveRule_R_CURLY();

	// $ANTLR start "R_CURLY"
	[GrammarRule("R_CURLY")]
	private void mR_CURLY()
	{
		EnterRule_R_CURLY();
		EnterRule("R_CURLY", 9);
		TraceIn("R_CURLY", 9);
		try
		{
			int _type = R_CURLY;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:17:9: ( '}' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:17:11: '}'
			{
			DebugLocation(17, 11);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("R_CURLY", 9);
			LeaveRule("R_CURLY", 9);
			LeaveRule_R_CURLY();
		}
	}
	// $ANTLR end "R_CURLY"

	partial void EnterRule_STAR();
	partial void LeaveRule_STAR();

	// $ANTLR start "STAR"
	[GrammarRule("STAR")]
	private void mSTAR()
	{
		EnterRule_STAR();
		EnterRule("STAR", 10);
		TraceIn("STAR", 10);
		try
		{
			int _type = STAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:18:6: ( '*' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:18:8: '*'
			{
			DebugLocation(18, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STAR", 10);
			LeaveRule("STAR", 10);
			LeaveRule_STAR();
		}
	}
	// $ANTLR end "STAR"

	partial void EnterRule_DIGIT();
	partial void LeaveRule_DIGIT();

	// $ANTLR start "DIGIT"
	[GrammarRule("DIGIT")]
	private void mDIGIT()
	{
		EnterRule_DIGIT();
		EnterRule("DIGIT", 11);
		TraceIn("DIGIT", 11);
		try
		{
			int _type = DIGIT;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:95:2: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:
			{
			DebugLocation(95, 2);
			if ((input.LA(1)>='0' && input.LA(1)<='9'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIGIT", 11);
			LeaveRule("DIGIT", 11);
			LeaveRule_DIGIT();
		}
	}
	// $ANTLR end "DIGIT"

	partial void EnterRule_CHAR();
	partial void LeaveRule_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		EnterRule_CHAR();
		EnterRule("CHAR", 12);
		TraceIn("CHAR", 12);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:104:2: (~ ( '^' | '$' | '\\\\' | '.' | '*' | '+' | '?' | '(' | ')' | '[' | ']' | '{' | '}' | '|' ) )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:
			{
			DebugLocation(104, 2);
			if ((input.LA(1)>='\u0000' && input.LA(1)<='#')||(input.LA(1)>='%' && input.LA(1)<='\'')||(input.LA(1)>=',' && input.LA(1)<='-')||(input.LA(1)>='/' && input.LA(1)<='>')||(input.LA(1)>='@' && input.LA(1)<='Z')||(input.LA(1)>='_' && input.LA(1)<='z')||(input.LA(1)>='~' && input.LA(1)<='\uFFFF'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CHAR", 12);
			LeaveRule("CHAR", 12);
			LeaveRule_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	public override void mTokens()
	{
		// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:8: ( CARAT | COMMA | DOLLAR | DOT | L_CURLY | PIPE | PLUS | QUESTION | R_CURLY | STAR | DIGIT | CHAR )
		int alt1=12;
		try { DebugEnterDecision(1, false);
		int LA1_0 = input.LA(1);

		if ((LA1_0=='^'))
		{
			alt1 = 1;
		}
		else if ((LA1_0==','))
		{
			alt1 = 2;
		}
		else if ((LA1_0=='$'))
		{
			alt1 = 3;
		}
		else if ((LA1_0=='.'))
		{
			alt1 = 4;
		}
		else if ((LA1_0=='{'))
		{
			alt1 = 5;
		}
		else if ((LA1_0=='|'))
		{
			alt1 = 6;
		}
		else if ((LA1_0=='+'))
		{
			alt1 = 7;
		}
		else if ((LA1_0=='?'))
		{
			alt1 = 8;
		}
		else if ((LA1_0=='}'))
		{
			alt1 = 9;
		}
		else if ((LA1_0=='*'))
		{
			alt1 = 10;
		}
		else if (((LA1_0>='0' && LA1_0<='9')))
		{
			alt1 = 11;
		}
		else if (((LA1_0>='\u0000' && LA1_0<='#')||(LA1_0>='%' && LA1_0<='\'')||LA1_0=='-'||LA1_0=='/'||(LA1_0>=':' && LA1_0<='>')||(LA1_0>='@' && LA1_0<='Z')||(LA1_0>='_' && LA1_0<='z')||(LA1_0>='~' && LA1_0<='\uFFFF')))
		{
			alt1 = 12;
		}
		else
		{
			NoViableAltException nvae = new NoViableAltException("", 1, 0, input);
			DebugRecognitionException(nvae);
			throw nvae;
		}
		} finally { DebugExitDecision(1); }
		switch (alt1)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:10: CARAT
			{
			DebugLocation(1, 10);
			mCARAT(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:16: COMMA
			{
			DebugLocation(1, 16);
			mCOMMA(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:22: DOLLAR
			{
			DebugLocation(1, 22);
			mDOLLAR(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:29: DOT
			{
			DebugLocation(1, 29);
			mDOT(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:33: L_CURLY
			{
			DebugLocation(1, 33);
			mL_CURLY(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:41: PIPE
			{
			DebugLocation(1, 41);
			mPIPE(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:46: PLUS
			{
			DebugLocation(1, 46);
			mPLUS(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:51: QUESTION
			{
			DebugLocation(1, 51);
			mQUESTION(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:60: R_CURLY
			{
			DebugLocation(1, 60);
			mR_CURLY(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:68: STAR
			{
			DebugLocation(1, 68);
			mSTAR(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:73: DIGIT
			{
			DebugLocation(1, 73);
			mDIGIT(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:79: CHAR
			{
			DebugLocation(1, 79);
			mCHAR(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

 
	#endregion

}

} // namespace  RegexLib.Parsers.JavaScript 
