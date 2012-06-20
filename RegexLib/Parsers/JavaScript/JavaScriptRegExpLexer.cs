// $ANTLR 3.3 Nov 30, 2010 12:50:56 JavaScriptRegExp__.g 2012-06-20 09:48:11

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class JavaScriptRegExpLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__4=4;
	public const int T__5=5;
	public const int T__6=6;
	public const int T__7=7;
	public const int T__8=8;
	public const int T__9=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int T__14=14;
	public const int T__15=15;
	public const int T__16=16;
	public const int T__17=17;
	public const int T__18=18;
	public const int T__19=19;
	public const int T__20=20;
	public const int T__21=21;
	public const int T__22=22;
	public const int T__23=23;
	public const int T__24=24;
	public const int T__25=25;
	public const int T__26=26;
	public const int T__27=27;
	public const int T__28=28;
	public const int T__29=29;
	public const int T__30=30;
	public const int T__31=31;
	public const int T__32=32;
	public const int T__33=33;
	public const int T__34=34;
	public const int T__35=35;
	public const int T__36=36;
	public const int T__37=37;
	public const int T__38=38;
	public const int T__39=39;
	public const int T__40=40;
	public const int T__41=41;
	public const int T__42=42;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;
	public const int T__47=47;
	public const int T__48=48;
	public const int T__49=49;

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
	public override string GrammarFileName { get { return "JavaScriptRegExp__.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_T__4();
	partial void Leave_T__4();

	// $ANTLR start "T__4"
	[GrammarRule("T__4")]
	private void mT__4()
	{
		Enter_T__4();
		EnterRule("T__4", 1);
		TraceIn("T__4", 1);
		try
		{
			int _type = T__4;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:7:6: ( '|' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:7:8: '|'
			{
			DebugLocation(7, 8);
			Match('|'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__4", 1);
			LeaveRule("T__4", 1);
			Leave_T__4();
		}
	}
	// $ANTLR end "T__4"

	partial void Enter_T__5();
	partial void Leave_T__5();

	// $ANTLR start "T__5"
	[GrammarRule("T__5")]
	private void mT__5()
	{
		Enter_T__5();
		EnterRule("T__5", 2);
		TraceIn("T__5", 2);
		try
		{
			int _type = T__5;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:8:6: ( '^' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:8:8: '^'
			{
			DebugLocation(8, 8);
			Match('^'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__5", 2);
			LeaveRule("T__5", 2);
			Leave_T__5();
		}
	}
	// $ANTLR end "T__5"

	partial void Enter_T__6();
	partial void Leave_T__6();

	// $ANTLR start "T__6"
	[GrammarRule("T__6")]
	private void mT__6()
	{
		Enter_T__6();
		EnterRule("T__6", 3);
		TraceIn("T__6", 3);
		try
		{
			int _type = T__6;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:9:6: ( '$' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:9:8: '$'
			{
			DebugLocation(9, 8);
			Match('$'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__6", 3);
			LeaveRule("T__6", 3);
			Leave_T__6();
		}
	}
	// $ANTLR end "T__6"

	partial void Enter_T__7();
	partial void Leave_T__7();

	// $ANTLR start "T__7"
	[GrammarRule("T__7")]
	private void mT__7()
	{
		Enter_T__7();
		EnterRule("T__7", 4);
		TraceIn("T__7", 4);
		try
		{
			int _type = T__7;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:10:6: ( '\\\\b' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:10:8: '\\\\b'
			{
			DebugLocation(10, 8);
			Match("\\b"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__7", 4);
			LeaveRule("T__7", 4);
			Leave_T__7();
		}
	}
	// $ANTLR end "T__7"

	partial void Enter_T__8();
	partial void Leave_T__8();

	// $ANTLR start "T__8"
	[GrammarRule("T__8")]
	private void mT__8()
	{
		Enter_T__8();
		EnterRule("T__8", 5);
		TraceIn("T__8", 5);
		try
		{
			int _type = T__8;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:11:6: ( '\\\\B' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:11:8: '\\\\B'
			{
			DebugLocation(11, 8);
			Match("\\B"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__8", 5);
			LeaveRule("T__8", 5);
			Leave_T__8();
		}
	}
	// $ANTLR end "T__8"

	partial void Enter_T__9();
	partial void Leave_T__9();

	// $ANTLR start "T__9"
	[GrammarRule("T__9")]
	private void mT__9()
	{
		Enter_T__9();
		EnterRule("T__9", 6);
		TraceIn("T__9", 6);
		try
		{
			int _type = T__9;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:12:6: ( '(?=' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:12:8: '(?='
			{
			DebugLocation(12, 8);
			Match("(?="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__9", 6);
			LeaveRule("T__9", 6);
			Leave_T__9();
		}
	}
	// $ANTLR end "T__9"

	partial void Enter_T__10();
	partial void Leave_T__10();

	// $ANTLR start "T__10"
	[GrammarRule("T__10")]
	private void mT__10()
	{
		Enter_T__10();
		EnterRule("T__10", 7);
		TraceIn("T__10", 7);
		try
		{
			int _type = T__10;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:13:7: ( ')' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:13:9: ')'
			{
			DebugLocation(13, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__10", 7);
			LeaveRule("T__10", 7);
			Leave_T__10();
		}
	}
	// $ANTLR end "T__10"

	partial void Enter_T__11();
	partial void Leave_T__11();

	// $ANTLR start "T__11"
	[GrammarRule("T__11")]
	private void mT__11()
	{
		Enter_T__11();
		EnterRule("T__11", 8);
		TraceIn("T__11", 8);
		try
		{
			int _type = T__11;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:14:7: ( '(?!' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:14:9: '(?!'
			{
			DebugLocation(14, 9);
			Match("(?!"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__11", 8);
			LeaveRule("T__11", 8);
			Leave_T__11();
		}
	}
	// $ANTLR end "T__11"

	partial void Enter_T__12();
	partial void Leave_T__12();

	// $ANTLR start "T__12"
	[GrammarRule("T__12")]
	private void mT__12()
	{
		Enter_T__12();
		EnterRule("T__12", 9);
		TraceIn("T__12", 9);
		try
		{
			int _type = T__12;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:15:7: ( '?' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:15:9: '?'
			{
			DebugLocation(15, 9);
			Match('?'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__12", 9);
			LeaveRule("T__12", 9);
			Leave_T__12();
		}
	}
	// $ANTLR end "T__12"

	partial void Enter_T__13();
	partial void Leave_T__13();

	// $ANTLR start "T__13"
	[GrammarRule("T__13")]
	private void mT__13()
	{
		Enter_T__13();
		EnterRule("T__13", 10);
		TraceIn("T__13", 10);
		try
		{
			int _type = T__13;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:16:7: ( '*' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:16:9: '*'
			{
			DebugLocation(16, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__13", 10);
			LeaveRule("T__13", 10);
			Leave_T__13();
		}
	}
	// $ANTLR end "T__13"

	partial void Enter_T__14();
	partial void Leave_T__14();

	// $ANTLR start "T__14"
	[GrammarRule("T__14")]
	private void mT__14()
	{
		Enter_T__14();
		EnterRule("T__14", 11);
		TraceIn("T__14", 11);
		try
		{
			int _type = T__14;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:17:7: ( '+' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:17:9: '+'
			{
			DebugLocation(17, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__14", 11);
			LeaveRule("T__14", 11);
			Leave_T__14();
		}
	}
	// $ANTLR end "T__14"

	partial void Enter_T__15();
	partial void Leave_T__15();

	// $ANTLR start "T__15"
	[GrammarRule("T__15")]
	private void mT__15()
	{
		Enter_T__15();
		EnterRule("T__15", 12);
		TraceIn("T__15", 12);
		try
		{
			int _type = T__15;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:18:7: ( '{' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:18:9: '{'
			{
			DebugLocation(18, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__15", 12);
			LeaveRule("T__15", 12);
			Leave_T__15();
		}
	}
	// $ANTLR end "T__15"

	partial void Enter_T__16();
	partial void Leave_T__16();

	// $ANTLR start "T__16"
	[GrammarRule("T__16")]
	private void mT__16()
	{
		Enter_T__16();
		EnterRule("T__16", 13);
		TraceIn("T__16", 13);
		try
		{
			int _type = T__16;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:19:7: ( '}' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:19:9: '}'
			{
			DebugLocation(19, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__16", 13);
			LeaveRule("T__16", 13);
			Leave_T__16();
		}
	}
	// $ANTLR end "T__16"

	partial void Enter_T__17();
	partial void Leave_T__17();

	// $ANTLR start "T__17"
	[GrammarRule("T__17")]
	private void mT__17()
	{
		Enter_T__17();
		EnterRule("T__17", 14);
		TraceIn("T__17", 14);
		try
		{
			int _type = T__17;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:20:7: ( ',}' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:20:9: ',}'
			{
			DebugLocation(20, 9);
			Match(",}"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__17", 14);
			LeaveRule("T__17", 14);
			Leave_T__17();
		}
	}
	// $ANTLR end "T__17"

	partial void Enter_T__18();
	partial void Leave_T__18();

	// $ANTLR start "T__18"
	[GrammarRule("T__18")]
	private void mT__18()
	{
		Enter_T__18();
		EnterRule("T__18", 15);
		TraceIn("T__18", 15);
		try
		{
			int _type = T__18;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:21:7: ( ',' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:21:9: ','
			{
			DebugLocation(21, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__18", 15);
			LeaveRule("T__18", 15);
			Leave_T__18();
		}
	}
	// $ANTLR end "T__18"

	partial void Enter_T__19();
	partial void Leave_T__19();

	// $ANTLR start "T__19"
	[GrammarRule("T__19")]
	private void mT__19()
	{
		Enter_T__19();
		EnterRule("T__19", 16);
		TraceIn("T__19", 16);
		try
		{
			int _type = T__19;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:22:7: ( '.' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:22:9: '.'
			{
			DebugLocation(22, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__19", 16);
			LeaveRule("T__19", 16);
			Leave_T__19();
		}
	}
	// $ANTLR end "T__19"

	partial void Enter_T__20();
	partial void Leave_T__20();

	// $ANTLR start "T__20"
	[GrammarRule("T__20")]
	private void mT__20()
	{
		Enter_T__20();
		EnterRule("T__20", 17);
		TraceIn("T__20", 17);
		try
		{
			int _type = T__20;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:23:7: ( '\\\\' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:23:9: '\\\\'
			{
			DebugLocation(23, 9);
			Match('\\'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__20", 17);
			LeaveRule("T__20", 17);
			Leave_T__20();
		}
	}
	// $ANTLR end "T__20"

	partial void Enter_T__21();
	partial void Leave_T__21();

	// $ANTLR start "T__21"
	[GrammarRule("T__21")]
	private void mT__21()
	{
		Enter_T__21();
		EnterRule("T__21", 18);
		TraceIn("T__21", 18);
		try
		{
			int _type = T__21;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:24:7: ( '(' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:24:9: '('
			{
			DebugLocation(24, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__21", 18);
			LeaveRule("T__21", 18);
			Leave_T__21();
		}
	}
	// $ANTLR end "T__21"

	partial void Enter_T__22();
	partial void Leave_T__22();

	// $ANTLR start "T__22"
	[GrammarRule("T__22")]
	private void mT__22()
	{
		Enter_T__22();
		EnterRule("T__22", 19);
		TraceIn("T__22", 19);
		try
		{
			int _type = T__22;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:25:7: ( '(:?' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:25:9: '(:?'
			{
			DebugLocation(25, 9);
			Match("(:?"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__22", 19);
			LeaveRule("T__22", 19);
			Leave_T__22();
		}
	}
	// $ANTLR end "T__22"

	partial void Enter_T__23();
	partial void Leave_T__23();

	// $ANTLR start "T__23"
	[GrammarRule("T__23")]
	private void mT__23()
	{
		Enter_T__23();
		EnterRule("T__23", 20);
		TraceIn("T__23", 20);
		try
		{
			int _type = T__23;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:26:7: ( '[' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:26:9: '['
			{
			DebugLocation(26, 9);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__23", 20);
			LeaveRule("T__23", 20);
			Leave_T__23();
		}
	}
	// $ANTLR end "T__23"

	partial void Enter_T__24();
	partial void Leave_T__24();

	// $ANTLR start "T__24"
	[GrammarRule("T__24")]
	private void mT__24()
	{
		Enter_T__24();
		EnterRule("T__24", 21);
		TraceIn("T__24", 21);
		try
		{
			int _type = T__24;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:27:7: ( ']' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:27:9: ']'
			{
			DebugLocation(27, 9);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__24", 21);
			LeaveRule("T__24", 21);
			Leave_T__24();
		}
	}
	// $ANTLR end "T__24"

	partial void Enter_T__25();
	partial void Leave_T__25();

	// $ANTLR start "T__25"
	[GrammarRule("T__25")]
	private void mT__25()
	{
		Enter_T__25();
		EnterRule("T__25", 22);
		TraceIn("T__25", 22);
		try
		{
			int _type = T__25;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:28:7: ( 'c' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:28:9: 'c'
			{
			DebugLocation(28, 9);
			Match('c'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__25", 22);
			LeaveRule("T__25", 22);
			Leave_T__25();
		}
	}
	// $ANTLR end "T__25"

	partial void Enter_T__26();
	partial void Leave_T__26();

	// $ANTLR start "T__26"
	[GrammarRule("T__26")]
	private void mT__26()
	{
		Enter_T__26();
		EnterRule("T__26", 23);
		TraceIn("T__26", 23);
		try
		{
			int _type = T__26;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:29:7: ( 'f' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:29:9: 'f'
			{
			DebugLocation(29, 9);
			Match('f'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__26", 23);
			LeaveRule("T__26", 23);
			Leave_T__26();
		}
	}
	// $ANTLR end "T__26"

	partial void Enter_T__27();
	partial void Leave_T__27();

	// $ANTLR start "T__27"
	[GrammarRule("T__27")]
	private void mT__27()
	{
		Enter_T__27();
		EnterRule("T__27", 24);
		TraceIn("T__27", 24);
		try
		{
			int _type = T__27;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:30:7: ( 'n' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:30:9: 'n'
			{
			DebugLocation(30, 9);
			Match('n'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__27", 24);
			LeaveRule("T__27", 24);
			Leave_T__27();
		}
	}
	// $ANTLR end "T__27"

	partial void Enter_T__28();
	partial void Leave_T__28();

	// $ANTLR start "T__28"
	[GrammarRule("T__28")]
	private void mT__28()
	{
		Enter_T__28();
		EnterRule("T__28", 25);
		TraceIn("T__28", 25);
		try
		{
			int _type = T__28;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:31:7: ( 'r' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:31:9: 'r'
			{
			DebugLocation(31, 9);
			Match('r'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__28", 25);
			LeaveRule("T__28", 25);
			Leave_T__28();
		}
	}
	// $ANTLR end "T__28"

	partial void Enter_T__29();
	partial void Leave_T__29();

	// $ANTLR start "T__29"
	[GrammarRule("T__29")]
	private void mT__29()
	{
		Enter_T__29();
		EnterRule("T__29", 26);
		TraceIn("T__29", 26);
		try
		{
			int _type = T__29;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:32:7: ( 't' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:32:9: 't'
			{
			DebugLocation(32, 9);
			Match('t'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__29", 26);
			LeaveRule("T__29", 26);
			Leave_T__29();
		}
	}
	// $ANTLR end "T__29"

	partial void Enter_T__30();
	partial void Leave_T__30();

	// $ANTLR start "T__30"
	[GrammarRule("T__30")]
	private void mT__30()
	{
		Enter_T__30();
		EnterRule("T__30", 27);
		TraceIn("T__30", 27);
		try
		{
			int _type = T__30;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:33:7: ( 'v' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:33:9: 'v'
			{
			DebugLocation(33, 9);
			Match('v'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__30", 27);
			LeaveRule("T__30", 27);
			Leave_T__30();
		}
	}
	// $ANTLR end "T__30"

	partial void Enter_T__31();
	partial void Leave_T__31();

	// $ANTLR start "T__31"
	[GrammarRule("T__31")]
	private void mT__31()
	{
		Enter_T__31();
		EnterRule("T__31", 28);
		TraceIn("T__31", 28);
		try
		{
			int _type = T__31;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:34:7: ( 'a' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:34:9: 'a'
			{
			DebugLocation(34, 9);
			Match('a'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__31", 28);
			LeaveRule("T__31", 28);
			Leave_T__31();
		}
	}
	// $ANTLR end "T__31"

	partial void Enter_T__32();
	partial void Leave_T__32();

	// $ANTLR start "T__32"
	[GrammarRule("T__32")]
	private void mT__32()
	{
		Enter_T__32();
		EnterRule("T__32", 29);
		TraceIn("T__32", 29);
		try
		{
			int _type = T__32;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:35:7: ( 'z' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:35:9: 'z'
			{
			DebugLocation(35, 9);
			Match('z'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__32", 29);
			LeaveRule("T__32", 29);
			Leave_T__32();
		}
	}
	// $ANTLR end "T__32"

	partial void Enter_T__33();
	partial void Leave_T__33();

	// $ANTLR start "T__33"
	[GrammarRule("T__33")]
	private void mT__33()
	{
		Enter_T__33();
		EnterRule("T__33", 30);
		TraceIn("T__33", 30);
		try
		{
			int _type = T__33;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:36:7: ( 'A' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:36:9: 'A'
			{
			DebugLocation(36, 9);
			Match('A'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__33", 30);
			LeaveRule("T__33", 30);
			Leave_T__33();
		}
	}
	// $ANTLR end "T__33"

	partial void Enter_T__34();
	partial void Leave_T__34();

	// $ANTLR start "T__34"
	[GrammarRule("T__34")]
	private void mT__34()
	{
		Enter_T__34();
		EnterRule("T__34", 31);
		TraceIn("T__34", 31);
		try
		{
			int _type = T__34;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:37:7: ( 'Z' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:37:9: 'Z'
			{
			DebugLocation(37, 9);
			Match('Z'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__34", 31);
			LeaveRule("T__34", 31);
			Leave_T__34();
		}
	}
	// $ANTLR end "T__34"

	partial void Enter_T__35();
	partial void Leave_T__35();

	// $ANTLR start "T__35"
	[GrammarRule("T__35")]
	private void mT__35()
	{
		Enter_T__35();
		EnterRule("T__35", 32);
		TraceIn("T__35", 32);
		try
		{
			int _type = T__35;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:38:7: ( 'x' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:38:9: 'x'
			{
			DebugLocation(38, 9);
			Match('x'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__35", 32);
			LeaveRule("T__35", 32);
			Leave_T__35();
		}
	}
	// $ANTLR end "T__35"

	partial void Enter_T__36();
	partial void Leave_T__36();

	// $ANTLR start "T__36"
	[GrammarRule("T__36")]
	private void mT__36()
	{
		Enter_T__36();
		EnterRule("T__36", 33);
		TraceIn("T__36", 33);
		try
		{
			int _type = T__36;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:39:7: ( 'u' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:39:9: 'u'
			{
			DebugLocation(39, 9);
			Match('u'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__36", 33);
			LeaveRule("T__36", 33);
			Leave_T__36();
		}
	}
	// $ANTLR end "T__36"

	partial void Enter_T__37();
	partial void Leave_T__37();

	// $ANTLR start "T__37"
	[GrammarRule("T__37")]
	private void mT__37()
	{
		Enter_T__37();
		EnterRule("T__37", 34);
		TraceIn("T__37", 34);
		try
		{
			int _type = T__37;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:40:7: ( '0' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:40:9: '0'
			{
			DebugLocation(40, 9);
			Match('0'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__37", 34);
			LeaveRule("T__37", 34);
			Leave_T__37();
		}
	}
	// $ANTLR end "T__37"

	partial void Enter_T__38();
	partial void Leave_T__38();

	// $ANTLR start "T__38"
	[GrammarRule("T__38")]
	private void mT__38()
	{
		Enter_T__38();
		EnterRule("T__38", 35);
		TraceIn("T__38", 35);
		try
		{
			int _type = T__38;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:41:7: ( '9' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:41:9: '9'
			{
			DebugLocation(41, 9);
			Match('9'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__38", 35);
			LeaveRule("T__38", 35);
			Leave_T__38();
		}
	}
	// $ANTLR end "T__38"

	partial void Enter_T__39();
	partial void Leave_T__39();

	// $ANTLR start "T__39"
	[GrammarRule("T__39")]
	private void mT__39()
	{
		Enter_T__39();
		EnterRule("T__39", 36);
		TraceIn("T__39", 36);
		try
		{
			int _type = T__39;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:42:7: ( 'F' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:42:9: 'F'
			{
			DebugLocation(42, 9);
			Match('F'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__39", 36);
			LeaveRule("T__39", 36);
			Leave_T__39();
		}
	}
	// $ANTLR end "T__39"

	partial void Enter_T__40();
	partial void Leave_T__40();

	// $ANTLR start "T__40"
	[GrammarRule("T__40")]
	private void mT__40()
	{
		Enter_T__40();
		EnterRule("T__40", 37);
		TraceIn("T__40", 37);
		try
		{
			int _type = T__40;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:43:7: ( '1' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:43:9: '1'
			{
			DebugLocation(43, 9);
			Match('1'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__40", 37);
			LeaveRule("T__40", 37);
			Leave_T__40();
		}
	}
	// $ANTLR end "T__40"

	partial void Enter_T__41();
	partial void Leave_T__41();

	// $ANTLR start "T__41"
	[GrammarRule("T__41")]
	private void mT__41()
	{
		Enter_T__41();
		EnterRule("T__41", 38);
		TraceIn("T__41", 38);
		try
		{
			int _type = T__41;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:44:7: ( 'd' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:44:9: 'd'
			{
			DebugLocation(44, 9);
			Match('d'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__41", 38);
			LeaveRule("T__41", 38);
			Leave_T__41();
		}
	}
	// $ANTLR end "T__41"

	partial void Enter_T__42();
	partial void Leave_T__42();

	// $ANTLR start "T__42"
	[GrammarRule("T__42")]
	private void mT__42()
	{
		Enter_T__42();
		EnterRule("T__42", 39);
		TraceIn("T__42", 39);
		try
		{
			int _type = T__42;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:45:7: ( 'D' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:45:9: 'D'
			{
			DebugLocation(45, 9);
			Match('D'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__42", 39);
			LeaveRule("T__42", 39);
			Leave_T__42();
		}
	}
	// $ANTLR end "T__42"

	partial void Enter_T__43();
	partial void Leave_T__43();

	// $ANTLR start "T__43"
	[GrammarRule("T__43")]
	private void mT__43()
	{
		Enter_T__43();
		EnterRule("T__43", 40);
		TraceIn("T__43", 40);
		try
		{
			int _type = T__43;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:46:7: ( 's' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:46:9: 's'
			{
			DebugLocation(46, 9);
			Match('s'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__43", 40);
			LeaveRule("T__43", 40);
			Leave_T__43();
		}
	}
	// $ANTLR end "T__43"

	partial void Enter_T__44();
	partial void Leave_T__44();

	// $ANTLR start "T__44"
	[GrammarRule("T__44")]
	private void mT__44()
	{
		Enter_T__44();
		EnterRule("T__44", 41);
		TraceIn("T__44", 41);
		try
		{
			int _type = T__44;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:47:7: ( 'S' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:47:9: 'S'
			{
			DebugLocation(47, 9);
			Match('S'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__44", 41);
			LeaveRule("T__44", 41);
			Leave_T__44();
		}
	}
	// $ANTLR end "T__44"

	partial void Enter_T__45();
	partial void Leave_T__45();

	// $ANTLR start "T__45"
	[GrammarRule("T__45")]
	private void mT__45()
	{
		Enter_T__45();
		EnterRule("T__45", 42);
		TraceIn("T__45", 42);
		try
		{
			int _type = T__45;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:48:7: ( 'w' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:48:9: 'w'
			{
			DebugLocation(48, 9);
			Match('w'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__45", 42);
			LeaveRule("T__45", 42);
			Leave_T__45();
		}
	}
	// $ANTLR end "T__45"

	partial void Enter_T__46();
	partial void Leave_T__46();

	// $ANTLR start "T__46"
	[GrammarRule("T__46")]
	private void mT__46()
	{
		Enter_T__46();
		EnterRule("T__46", 43);
		TraceIn("T__46", 43);
		try
		{
			int _type = T__46;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:49:7: ( 'W' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:49:9: 'W'
			{
			DebugLocation(49, 9);
			Match('W'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__46", 43);
			LeaveRule("T__46", 43);
			Leave_T__46();
		}
	}
	// $ANTLR end "T__46"

	partial void Enter_T__47();
	partial void Leave_T__47();

	// $ANTLR start "T__47"
	[GrammarRule("T__47")]
	private void mT__47()
	{
		Enter_T__47();
		EnterRule("T__47", 44);
		TraceIn("T__47", 44);
		try
		{
			int _type = T__47;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:50:7: ( '[^' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:50:9: '[^'
			{
			DebugLocation(50, 9);
			Match("[^"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__47", 44);
			LeaveRule("T__47", 44);
			Leave_T__47();
		}
	}
	// $ANTLR end "T__47"

	partial void Enter_T__48();
	partial void Leave_T__48();

	// $ANTLR start "T__48"
	[GrammarRule("T__48")]
	private void mT__48()
	{
		Enter_T__48();
		EnterRule("T__48", 45);
		TraceIn("T__48", 45);
		try
		{
			int _type = T__48;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:51:7: ( '-' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:51:9: '-'
			{
			DebugLocation(51, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__48", 45);
			LeaveRule("T__48", 45);
			Leave_T__48();
		}
	}
	// $ANTLR end "T__48"

	partial void Enter_T__49();
	partial void Leave_T__49();

	// $ANTLR start "T__49"
	[GrammarRule("T__49")]
	private void mT__49()
	{
		Enter_T__49();
		EnterRule("T__49", 46);
		TraceIn("T__49", 46);
		try
		{
			int _type = T__49;
			int _channel = DefaultTokenChannel;
			// JavaScriptRegExp__.g:52:7: ( 'b' )
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:52:9: 'b'
			{
			DebugLocation(52, 9);
			Match('b'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__49", 46);
			LeaveRule("T__49", 46);
			Leave_T__49();
		}
	}
	// $ANTLR end "T__49"

	public override void mTokens()
	{
		// JavaScriptRegExp__.g:1:8: ( T__4 | T__5 | T__6 | T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 )
		int alt1=46;
		try { DebugEnterDecision(1, decisionCanBacktrack[1]);
		try
		{
			alt1 = dfa1.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(1); }
		switch (alt1)
		{
		case 1:
			DebugEnterAlt(1);
			// JavaScriptRegExp__.g:1:10: T__4
			{
			DebugLocation(1, 10);
			mT__4(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// JavaScriptRegExp__.g:1:15: T__5
			{
			DebugLocation(1, 15);
			mT__5(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// JavaScriptRegExp__.g:1:20: T__6
			{
			DebugLocation(1, 20);
			mT__6(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// JavaScriptRegExp__.g:1:25: T__7
			{
			DebugLocation(1, 25);
			mT__7(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// JavaScriptRegExp__.g:1:30: T__8
			{
			DebugLocation(1, 30);
			mT__8(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// JavaScriptRegExp__.g:1:35: T__9
			{
			DebugLocation(1, 35);
			mT__9(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// JavaScriptRegExp__.g:1:40: T__10
			{
			DebugLocation(1, 40);
			mT__10(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// JavaScriptRegExp__.g:1:46: T__11
			{
			DebugLocation(1, 46);
			mT__11(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// JavaScriptRegExp__.g:1:52: T__12
			{
			DebugLocation(1, 52);
			mT__12(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// JavaScriptRegExp__.g:1:58: T__13
			{
			DebugLocation(1, 58);
			mT__13(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// JavaScriptRegExp__.g:1:64: T__14
			{
			DebugLocation(1, 64);
			mT__14(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// JavaScriptRegExp__.g:1:70: T__15
			{
			DebugLocation(1, 70);
			mT__15(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// JavaScriptRegExp__.g:1:76: T__16
			{
			DebugLocation(1, 76);
			mT__16(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// JavaScriptRegExp__.g:1:82: T__17
			{
			DebugLocation(1, 82);
			mT__17(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// JavaScriptRegExp__.g:1:88: T__18
			{
			DebugLocation(1, 88);
			mT__18(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// JavaScriptRegExp__.g:1:94: T__19
			{
			DebugLocation(1, 94);
			mT__19(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// JavaScriptRegExp__.g:1:100: T__20
			{
			DebugLocation(1, 100);
			mT__20(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// JavaScriptRegExp__.g:1:106: T__21
			{
			DebugLocation(1, 106);
			mT__21(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// JavaScriptRegExp__.g:1:112: T__22
			{
			DebugLocation(1, 112);
			mT__22(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// JavaScriptRegExp__.g:1:118: T__23
			{
			DebugLocation(1, 118);
			mT__23(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// JavaScriptRegExp__.g:1:124: T__24
			{
			DebugLocation(1, 124);
			mT__24(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// JavaScriptRegExp__.g:1:130: T__25
			{
			DebugLocation(1, 130);
			mT__25(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// JavaScriptRegExp__.g:1:136: T__26
			{
			DebugLocation(1, 136);
			mT__26(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// JavaScriptRegExp__.g:1:142: T__27
			{
			DebugLocation(1, 142);
			mT__27(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// JavaScriptRegExp__.g:1:148: T__28
			{
			DebugLocation(1, 148);
			mT__28(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// JavaScriptRegExp__.g:1:154: T__29
			{
			DebugLocation(1, 154);
			mT__29(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// JavaScriptRegExp__.g:1:160: T__30
			{
			DebugLocation(1, 160);
			mT__30(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// JavaScriptRegExp__.g:1:166: T__31
			{
			DebugLocation(1, 166);
			mT__31(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// JavaScriptRegExp__.g:1:172: T__32
			{
			DebugLocation(1, 172);
			mT__32(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// JavaScriptRegExp__.g:1:178: T__33
			{
			DebugLocation(1, 178);
			mT__33(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// JavaScriptRegExp__.g:1:184: T__34
			{
			DebugLocation(1, 184);
			mT__34(); 

			}
			break;
		case 32:
			DebugEnterAlt(32);
			// JavaScriptRegExp__.g:1:190: T__35
			{
			DebugLocation(1, 190);
			mT__35(); 

			}
			break;
		case 33:
			DebugEnterAlt(33);
			// JavaScriptRegExp__.g:1:196: T__36
			{
			DebugLocation(1, 196);
			mT__36(); 

			}
			break;
		case 34:
			DebugEnterAlt(34);
			// JavaScriptRegExp__.g:1:202: T__37
			{
			DebugLocation(1, 202);
			mT__37(); 

			}
			break;
		case 35:
			DebugEnterAlt(35);
			// JavaScriptRegExp__.g:1:208: T__38
			{
			DebugLocation(1, 208);
			mT__38(); 

			}
			break;
		case 36:
			DebugEnterAlt(36);
			// JavaScriptRegExp__.g:1:214: T__39
			{
			DebugLocation(1, 214);
			mT__39(); 

			}
			break;
		case 37:
			DebugEnterAlt(37);
			// JavaScriptRegExp__.g:1:220: T__40
			{
			DebugLocation(1, 220);
			mT__40(); 

			}
			break;
		case 38:
			DebugEnterAlt(38);
			// JavaScriptRegExp__.g:1:226: T__41
			{
			DebugLocation(1, 226);
			mT__41(); 

			}
			break;
		case 39:
			DebugEnterAlt(39);
			// JavaScriptRegExp__.g:1:232: T__42
			{
			DebugLocation(1, 232);
			mT__42(); 

			}
			break;
		case 40:
			DebugEnterAlt(40);
			// JavaScriptRegExp__.g:1:238: T__43
			{
			DebugLocation(1, 238);
			mT__43(); 

			}
			break;
		case 41:
			DebugEnterAlt(41);
			// JavaScriptRegExp__.g:1:244: T__44
			{
			DebugLocation(1, 244);
			mT__44(); 

			}
			break;
		case 42:
			DebugEnterAlt(42);
			// JavaScriptRegExp__.g:1:250: T__45
			{
			DebugLocation(1, 250);
			mT__45(); 

			}
			break;
		case 43:
			DebugEnterAlt(43);
			// JavaScriptRegExp__.g:1:256: T__46
			{
			DebugLocation(1, 256);
			mT__46(); 

			}
			break;
		case 44:
			DebugEnterAlt(44);
			// JavaScriptRegExp__.g:1:262: T__47
			{
			DebugLocation(1, 262);
			mT__47(); 

			}
			break;
		case 45:
			DebugEnterAlt(45);
			// JavaScriptRegExp__.g:1:268: T__48
			{
			DebugLocation(1, 268);
			mT__48(); 

			}
			break;
		case 46:
			DebugEnterAlt(46);
			// JavaScriptRegExp__.g:1:274: T__49
			{
			DebugLocation(1, 274);
			mT__49(); 

			}
			break;

		}

	}


	#region DFA
	DFA1 dfa1;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa1 = new DFA1(this);
	}

	private class DFA1 : DFA
	{
		private const string DFA1_eotS =
			"\x4\xFFFF\x1\x2A\x1\x2D\x6\xFFFF\x1\x2F\x1\xFFFF\x1\x31\x25\xFFFF";
		private const string DFA1_eofS =
			"\x34\xFFFF";
		private const string DFA1_minS =
			"\x1\x24\x3\xFFFF\x1\x42\x1\x3A\x6\xFFFF\x1\x7D\x1\xFFFF\x1\x5E\x1C\xFFFF"+
			"\x1\x21\x8\xFFFF";
		private const string DFA1_maxS =
			"\x1\x7D\x3\xFFFF\x1\x62\x1\x3F\x6\xFFFF\x1\x7D\x1\xFFFF\x1\x5E\x1C\xFFFF"+
			"\x1\x3D\x8\xFFFF";
		private const string DFA1_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x2\xFFFF\x1\x7\x1\x9\x1\xA\x1\xB\x1\xC\x1"+
			"\xD\x1\xFFFF\x1\x10\x1\xFFFF\x1\x15\x1\x16\x1\x17\x1\x18\x1\x19\x1\x1A"+
			"\x1\x1B\x1\x1C\x1\x1D\x1\x1E\x1\x1F\x1\x20\x1\x21\x1\x22\x1\x23\x1\x24"+
			"\x1\x25\x1\x26\x1\x27\x1\x28\x1\x29\x1\x2A\x1\x2B\x1\x2D\x1\x2E\x1\x4"+
			"\x1\x5\x1\x11\x1\xFFFF\x1\x13\x1\x12\x1\xE\x1\xF\x1\x2C\x1\x14\x1\x6"+
			"\x1\x8";
		private const string DFA1_specialS =
			"\x34\xFFFF}>";
		private static readonly string[] DFA1_transitionS =
			{
				"\x1\x3\x3\xFFFF\x1\x5\x1\x6\x1\x8\x1\x9\x1\xC\x1\x26\x1\xD\x1\xFFFF"+
				"\x1\x1C\x1\x1F\x7\xFFFF\x1\x1D\x5\xFFFF\x1\x7\x1\xFFFF\x1\x18\x2\xFFFF"+
				"\x1\x21\x1\xFFFF\x1\x1E\xC\xFFFF\x1\x23\x3\xFFFF\x1\x25\x2\xFFFF\x1"+
				"\x19\x1\xE\x1\x4\x1\xF\x1\x2\x2\xFFFF\x1\x16\x1\x27\x1\x10\x1\x20\x1"+
				"\xFFFF\x1\x11\x7\xFFFF\x1\x12\x3\xFFFF\x1\x13\x1\x22\x1\x14\x1\x1B\x1"+
				"\x15\x1\x24\x1\x1A\x1\xFFFF\x1\x17\x1\xA\x1\x1\x1\xB",
				"",
				"",
				"",
				"\x1\x29\x1F\xFFFF\x1\x28",
				"\x1\x2C\x4\xFFFF\x1\x2B",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x2E",
				"",
				"\x1\x30",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x33\x1B\xFFFF\x1\x32",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
		private static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
		private static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
		private static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
		private static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
		private static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
		private static readonly short[][] DFA1_transition;

		static DFA1()
		{
			int numStates = DFA1_transitionS.Length;
			DFA1_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA1_transition[i] = DFA.UnpackEncodedString(DFA1_transitionS[i]);
			}
		}

		public DFA1( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 1;
			this.eot = DFA1_eot;
			this.eof = DFA1_eof;
			this.min = DFA1_min;
			this.max = DFA1_max;
			this.accept = DFA1_accept;
			this.special = DFA1_special;
			this.transition = DFA1_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( T__4 | T__5 | T__6 | T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}
