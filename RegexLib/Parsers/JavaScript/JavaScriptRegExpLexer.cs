//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g 2012-07-10 08:12:30

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
	public const int CHAR=4;

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

	partial void EnterRule_CHAR();
	partial void LeaveRule_CHAR();

	// $ANTLR start "CHAR"
	[GrammarRule("CHAR")]
	private void mCHAR()
	{
		EnterRule_CHAR();
		EnterRule("CHAR", 1);
		TraceIn("CHAR", 1);
		try
		{
			int _type = CHAR;
			int _channel = DefaultTokenChannel;
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:19:2: (~ ( '\\\\' | '|' | '[' | '{' | '(' ) )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:
			{
			DebugLocation(19, 2);
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
			TraceOut("CHAR", 1);
			LeaveRule("CHAR", 1);
			LeaveRule_CHAR();
		}
	}
	// $ANTLR end "CHAR"

	public override void mTokens()
	{
		// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:8: ( CHAR )
		DebugEnterAlt(1);
		// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:1:10: CHAR
		{
		DebugLocation(1, 10);
		mCHAR(); 

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
