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
 internal  partial class JavaScriptRegExpParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "CHAR"
	};
	public const int EOF=-1;
	public const int CHAR=4;

	public JavaScriptRegExpParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public JavaScriptRegExpParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		OnCreated();
	}

	public override string[] TokenNames { get { return JavaScriptRegExpParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_pattern();
	partial void LeaveRule_pattern();

	// $ANTLR start "pattern"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:10:8: public pattern returns [RegexNode value] : atom EOF ;
	[GrammarRule("pattern")]
	public RegexNode pattern()
	{
		EnterRule_pattern();
		EnterRule("pattern", 1);
		TraceIn("pattern", 1);
		RegexNode value = default(RegexNode);


		RegexNode atom1 = default(RegexNode);

		try { DebugEnterRule(GrammarFileName, "pattern");
		DebugLocation(10, 1);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:11:2: ( atom EOF )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:11:4: atom EOF
			{
			DebugLocation(11, 4);
			PushFollow(Follow._atom_in_pattern51);
			atom1=atom();
			PopFollow();

			DebugLocation(11, 9);
			Match(input,EOF,Follow._EOF_in_pattern53); 
			DebugLocation(11, 13);
			 return atom1; 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("pattern", 1);
			LeaveRule("pattern", 1);
			LeaveRule_pattern();
		}
		DebugLocation(12, 1);
		} finally { DebugExitRule(GrammarFileName, "pattern"); }
		return value;

	}
	// $ANTLR end "pattern"

	partial void EnterRule_atom();
	partial void LeaveRule_atom();

	// $ANTLR start "atom"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:14:1: atom returns [RegexNode value] : CHAR ;
	[GrammarRule("atom")]
	private RegexNode atom()
	{
		EnterRule_atom();
		EnterRule("atom", 2);
		TraceIn("atom", 2);
		RegexNode value = default(RegexNode);


		IToken CHAR2 = default(IToken);

		try { DebugEnterRule(GrammarFileName, "atom");
		DebugLocation(14, 1);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:15:2: ( CHAR )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:15:4: CHAR
			{
			DebugLocation(15, 4);
			CHAR2=(IToken)Match(input,CHAR,Follow._CHAR_in_atom70); 
			DebugLocation(15, 9);
			 return new CharacterClassNode(CHAR2.Text[0]); 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("atom", 2);
			LeaveRule("atom", 2);
			LeaveRule_atom();
		}
		DebugLocation(16, 1);
		} finally { DebugExitRule(GrammarFileName, "atom"); }
		return value;

	}
	// $ANTLR end "atom"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _atom_in_pattern51 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_pattern53 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _CHAR_in_atom70 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}

} // namespace  RegexLib.Parsers.JavaScript 
