//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g 2012-07-13 08:02:05

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
	public const int DOLLAR=6;
	public const int PIPE=7;

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

	partial void EnterRule_DOLLAR();
	partial void LeaveRule_DOLLAR();

	// $ANTLR start "DOLLAR"
	[GrammarRule("DOLLAR")]
	private void mDOLLAR()
	{
		EnterRule_DOLLAR();
		EnterRule("DOLLAR", 2);
		TraceIn("DOLLAR", 2);
		try
		{
			int _type = DOLLAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:10:8: ( '$' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:10:10: '$'
			{
			DebugLocation(10, 10);
			Match('$'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOLLAR", 2);
			LeaveRule("DOLLAR", 2);
			LeaveRule_DOLLAR();
		}
	}
	// $ANTLR end "DOLLAR"

	partial void EnterRule_PIPE();
	partial void LeaveRule_PIPE();

	// $ANTLR start "PIPE"
	[GrammarRule("PIPE")]
	private void mPIPE()
	{
		EnterRule_PIPE();
		EnterRule("PIPE", 3);
		TraceIn("PIPE", 3);
		try
		{
			int _type = PIPE;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:11:6: ( '|' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:11:8: '|'
			{
			DebugLocation(11, 8);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("PIPE", 3);
			LeaveRule("PIPE", 3);
			LeaveRule_PIPE();
		}
	}
	// $ANTLR end "PIPE"

	partial void EnterRule_CHAR();
	partial void LeaveRule_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		EnterRule_CHAR();
		EnterRule("CHAR", 4);
		TraceIn("CHAR", 4);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:48:2: (~ ( '\\\\' | '|' | '[' | '{' | '(' ) )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:
			{
			DebugLocation(48, 2);
			if ((input.LA(1)>='\u0000' && input.LA(1)<='\'')||(input.LA(1)>=')' && input.LA(1)<='Z')||(input.LA(1)>=']' && input.LA(1)<='z')||(input.LA(1)>='}' && input.LA(1)<='\uFFFF'))
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
			TraceOut("CHAR", 4);
			LeaveRule("CHAR", 4);
			LeaveRule_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	public override void mTokens()
	{
		// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:8: ( CARAT | DOLLAR | PIPE | CHAR )
		int alt1=4;
		try { DebugEnterDecision(1, false);
		int LA1_0 = input.LA(1);

		if ((LA1_0=='^'))
		{
			alt1 = 1;
		}
		else if ((LA1_0=='$'))
		{
			alt1 = 2;
		}
		else if ((LA1_0=='|'))
		{
			alt1 = 3;
		}
		else if (((LA1_0>='\u0000' && LA1_0<='#')||(LA1_0>='%' && LA1_0<='\'')||(LA1_0>=')' && LA1_0<='Z')||LA1_0==']'||(LA1_0>='_' && LA1_0<='z')||(LA1_0>='}' && LA1_0<='\uFFFF')))
		{
			alt1 = 4;
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
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:16: DOLLAR
			{
			DebugLocation(1, 16);
			mDOLLAR(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:23: PIPE
			{
			DebugLocation(1, 23);
			mPIPE(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:28: CHAR
			{
			DebugLocation(1, 28);
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
