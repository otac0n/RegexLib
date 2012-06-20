// $ANTLR 3.3 Nov 30, 2010 12:50:56 C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g 2012-06-20 09:48:11

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class JavaScriptRegExpParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "'|'", "'^'", "'$'", "'\\\\b'", "'\\\\B'", "'(?='", "')'", "'(?!'", "'?'", "'*'", "'+'", "'{'", "'}'", "',}'", "','", "'.'", "'\\\\'", "'('", "'(:?'", "'['", "']'", "'c'", "'f'", "'n'", "'r'", "'t'", "'v'", "'a'", "'z'", "'A'", "'Z'", "'x'", "'u'", "'0'", "'9'", "'F'", "'1'", "'d'", "'D'", "'s'", "'S'", "'w'", "'W'", "'[^'", "'-'", "'b'"
	};
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

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, true, false, false, false, true, true, true, true, 
				true, true, false, false, true, true, false, false, true
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public JavaScriptRegExpParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public JavaScriptRegExpParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[97+1];

		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return JavaScriptRegExpParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class pattern_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_pattern();
	partial void Leave_pattern();

	// $ANTLR start "pattern"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:9:1: pattern : disjunction EOF ;
	[GrammarRule("pattern")]
	private JavaScriptRegExpParser.pattern_return pattern()
	{
		Enter_pattern();
		EnterRule("pattern", 1);
		TraceIn("pattern", 1);
		JavaScriptRegExpParser.pattern_return retval = new JavaScriptRegExpParser.pattern_return();
		retval.Start = (IToken)input.LT(1);
		int pattern_StartIndex = input.Index;
		object root_0 = null;

		IToken EOF2=null;
		JavaScriptRegExpParser.disjunction_return disjunction1 = default(JavaScriptRegExpParser.disjunction_return);

		object EOF2_tree=null;

		try { DebugEnterRule(GrammarFileName, "pattern");
		DebugLocation(9, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:10:2: ( disjunction EOF )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:10:4: disjunction EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(10, 4);
			PushFollow(Follow._disjunction_in_pattern47);
			disjunction1=disjunction();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, disjunction1.Tree);
			DebugLocation(10, 16);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_pattern49); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			EOF2_tree = (object)adaptor.Create(EOF2);
			adaptor.AddChild(root_0, EOF2_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("pattern", 1);
			LeaveRule("pattern", 1);
			Leave_pattern();
			if (state.backtracking > 0) { Memoize(input, 1, pattern_StartIndex); }
		}
		DebugLocation(11, 1);
		} finally { DebugExitRule(GrammarFileName, "pattern"); }
		return retval;

	}
	// $ANTLR end "pattern"

	public class disjunction_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_disjunction();
	partial void Leave_disjunction();

	// $ANTLR start "disjunction"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:13:1: disjunction : alternative ( '|' disjunction )? ;
	[GrammarRule("disjunction")]
	private JavaScriptRegExpParser.disjunction_return disjunction()
	{
		Enter_disjunction();
		EnterRule("disjunction", 2);
		TraceIn("disjunction", 2);
		JavaScriptRegExpParser.disjunction_return retval = new JavaScriptRegExpParser.disjunction_return();
		retval.Start = (IToken)input.LT(1);
		int disjunction_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal4=null;
		JavaScriptRegExpParser.alternative_return alternative3 = default(JavaScriptRegExpParser.alternative_return);
		JavaScriptRegExpParser.disjunction_return disjunction5 = default(JavaScriptRegExpParser.disjunction_return);

		object char_literal4_tree=null;

		try { DebugEnterRule(GrammarFileName, "disjunction");
		DebugLocation(13, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:14:2: ( alternative ( '|' disjunction )? )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:14:4: alternative ( '|' disjunction )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(14, 4);
			PushFollow(Follow._alternative_in_disjunction60);
			alternative3=alternative();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, alternative3.Tree);
			DebugLocation(14, 16);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:14:16: ( '|' disjunction )?
			int alt1=2;
			try { DebugEnterSubRule(1);
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			int LA1_0 = input.LA(1);

			if ((LA1_0==4))
			{
				alt1=1;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:14:17: '|' disjunction
				{
				DebugLocation(14, 17);
				char_literal4=(IToken)Match(input,4,Follow._4_in_disjunction63); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal4_tree = (object)adaptor.Create(char_literal4);
				adaptor.AddChild(root_0, char_literal4_tree);
				}
				DebugLocation(14, 21);
				PushFollow(Follow._disjunction_in_disjunction65);
				disjunction5=disjunction();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, disjunction5.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(1); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("disjunction", 2);
			LeaveRule("disjunction", 2);
			Leave_disjunction();
			if (state.backtracking > 0) { Memoize(input, 2, disjunction_StartIndex); }
		}
		DebugLocation(15, 1);
		} finally { DebugExitRule(GrammarFileName, "disjunction"); }
		return retval;

	}
	// $ANTLR end "disjunction"

	public class alternative_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_alternative();
	partial void Leave_alternative();

	// $ANTLR start "alternative"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:17:1: alternative : ( term )* ;
	[GrammarRule("alternative")]
	private JavaScriptRegExpParser.alternative_return alternative()
	{
		Enter_alternative();
		EnterRule("alternative", 3);
		TraceIn("alternative", 3);
		JavaScriptRegExpParser.alternative_return retval = new JavaScriptRegExpParser.alternative_return();
		retval.Start = (IToken)input.LT(1);
		int alternative_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptRegExpParser.term_return term6 = default(JavaScriptRegExpParser.term_return);


		try { DebugEnterRule(GrammarFileName, "alternative");
		DebugLocation(17, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:18:2: ( ( term )* )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:18:4: ( term )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(18, 4);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:18:4: ( term )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>=5 && LA2_0<=9)||LA2_0==11||(LA2_0>=17 && LA2_0<=23)||(LA2_0>=25 && LA2_0<=49)))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:0:0: term
					{
					DebugLocation(18, 4);
					PushFollow(Follow._term_in_alternative78);
					term6=term();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term6.Tree);

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("alternative", 3);
			LeaveRule("alternative", 3);
			Leave_alternative();
			if (state.backtracking > 0) { Memoize(input, 3, alternative_StartIndex); }
		}
		DebugLocation(19, 1);
		} finally { DebugExitRule(GrammarFileName, "alternative"); }
		return retval;

	}
	// $ANTLR end "alternative"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:21:1: term : ( assertion | atom ( quantifier )? );
	[GrammarRule("term")]
	private JavaScriptRegExpParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 4);
		TraceIn("term", 4);
		JavaScriptRegExpParser.term_return retval = new JavaScriptRegExpParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptRegExpParser.assertion_return assertion7 = default(JavaScriptRegExpParser.assertion_return);
		JavaScriptRegExpParser.atom_return atom8 = default(JavaScriptRegExpParser.atom_return);
		JavaScriptRegExpParser.quantifier_return quantifier9 = default(JavaScriptRegExpParser.quantifier_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(21, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:22:2: ( assertion | atom ( quantifier )? )
			int alt4=2;
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			switch (input.LA(1))
			{
			case 5:
			case 6:
				{
				alt4=1;
				}
				break;
			case 7:
				{
				int LA4_2 = input.LA(2);

				if ((EvaluatePredicate(synpred3_JavaScriptRegExp_fragment)))
				{
					alt4=1;
				}
				else if ((true))
				{
					alt4=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 4, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 8:
				{
				int LA4_3 = input.LA(2);

				if ((EvaluatePredicate(synpred3_JavaScriptRegExp_fragment)))
				{
					alt4=1;
				}
				else if ((true))
				{
					alt4=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 4, 3, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 9:
				{
				int LA4_4 = input.LA(2);

				if ((EvaluatePredicate(synpred3_JavaScriptRegExp_fragment)))
				{
					alt4=1;
				}
				else if ((true))
				{
					alt4=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 4, 4, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 11:
				{
				int LA4_5 = input.LA(2);

				if ((EvaluatePredicate(synpred3_JavaScriptRegExp_fragment)))
				{
					alt4=1;
				}
				else if ((true))
				{
					alt4=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 4, 5, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 23:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 46:
			case 47:
			case 48:
			case 49:
				{
				alt4=2;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:22:4: assertion
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(22, 4);
				PushFollow(Follow._assertion_in_term90);
				assertion7=assertion();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assertion7.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:23:4: atom ( quantifier )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(23, 4);
				PushFollow(Follow._atom_in_term95);
				atom8=atom();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, atom8.Tree);
				DebugLocation(23, 9);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:23:9: ( quantifier )?
				int alt3=2;
				try { DebugEnterSubRule(3);
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>=12 && LA3_0<=15)))
				{
					alt3=1;
				}
				} finally { DebugExitDecision(3); }
				switch (alt3)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:0:0: quantifier
					{
					DebugLocation(23, 9);
					PushFollow(Follow._quantifier_in_term97);
					quantifier9=quantifier();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quantifier9.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(3); }


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 4);
			LeaveRule("term", 4);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 4, term_StartIndex); }
		}
		DebugLocation(24, 1);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class assertion_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assertion();
	partial void Leave_assertion();

	// $ANTLR start "assertion"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:26:1: assertion : ( '^' | '$' | '\\\\b' | '\\\\B' | '(?=' disjunction ')' | '(?!' disjunction ')' );
	[GrammarRule("assertion")]
	private JavaScriptRegExpParser.assertion_return assertion()
	{
		Enter_assertion();
		EnterRule("assertion", 5);
		TraceIn("assertion", 5);
		JavaScriptRegExpParser.assertion_return retval = new JavaScriptRegExpParser.assertion_return();
		retval.Start = (IToken)input.LT(1);
		int assertion_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal10=null;
		IToken char_literal11=null;
		IToken string_literal12=null;
		IToken string_literal13=null;
		IToken string_literal14=null;
		IToken char_literal16=null;
		IToken string_literal17=null;
		IToken char_literal19=null;
		JavaScriptRegExpParser.disjunction_return disjunction15 = default(JavaScriptRegExpParser.disjunction_return);
		JavaScriptRegExpParser.disjunction_return disjunction18 = default(JavaScriptRegExpParser.disjunction_return);

		object char_literal10_tree=null;
		object char_literal11_tree=null;
		object string_literal12_tree=null;
		object string_literal13_tree=null;
		object string_literal14_tree=null;
		object char_literal16_tree=null;
		object string_literal17_tree=null;
		object char_literal19_tree=null;

		try { DebugEnterRule(GrammarFileName, "assertion");
		DebugLocation(26, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:27:2: ( '^' | '$' | '\\\\b' | '\\\\B' | '(?=' disjunction ')' | '(?!' disjunction ')' )
			int alt5=6;
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			switch (input.LA(1))
			{
			case 5:
				{
				alt5=1;
				}
				break;
			case 6:
				{
				alt5=2;
				}
				break;
			case 7:
				{
				alt5=3;
				}
				break;
			case 8:
				{
				alt5=4;
				}
				break;
			case 9:
				{
				alt5=5;
				}
				break;
			case 11:
				{
				alt5=6;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 5, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:27:4: '^'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(27, 4);
				char_literal10=(IToken)Match(input,5,Follow._5_in_assertion109); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal10_tree = (object)adaptor.Create(char_literal10);
				adaptor.AddChild(root_0, char_literal10_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:28:4: '$'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(28, 4);
				char_literal11=(IToken)Match(input,6,Follow._6_in_assertion114); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal11_tree = (object)adaptor.Create(char_literal11);
				adaptor.AddChild(root_0, char_literal11_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:29:4: '\\\\b'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(29, 4);
				string_literal12=(IToken)Match(input,7,Follow._7_in_assertion119); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal12_tree = (object)adaptor.Create(string_literal12);
				adaptor.AddChild(root_0, string_literal12_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:30:4: '\\\\B'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(30, 4);
				string_literal13=(IToken)Match(input,8,Follow._8_in_assertion124); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal13_tree = (object)adaptor.Create(string_literal13);
				adaptor.AddChild(root_0, string_literal13_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:31:4: '(?=' disjunction ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(31, 4);
				string_literal14=(IToken)Match(input,9,Follow._9_in_assertion129); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal14_tree = (object)adaptor.Create(string_literal14);
				adaptor.AddChild(root_0, string_literal14_tree);
				}
				DebugLocation(31, 10);
				PushFollow(Follow._disjunction_in_assertion131);
				disjunction15=disjunction();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, disjunction15.Tree);
				DebugLocation(31, 22);
				char_literal16=(IToken)Match(input,10,Follow._10_in_assertion133); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal16_tree = (object)adaptor.Create(char_literal16);
				adaptor.AddChild(root_0, char_literal16_tree);
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:32:4: '(?!' disjunction ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(32, 4);
				string_literal17=(IToken)Match(input,11,Follow._11_in_assertion138); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal17_tree = (object)adaptor.Create(string_literal17);
				adaptor.AddChild(root_0, string_literal17_tree);
				}
				DebugLocation(32, 10);
				PushFollow(Follow._disjunction_in_assertion140);
				disjunction18=disjunction();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, disjunction18.Tree);
				DebugLocation(32, 22);
				char_literal19=(IToken)Match(input,10,Follow._10_in_assertion142); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal19_tree = (object)adaptor.Create(char_literal19);
				adaptor.AddChild(root_0, char_literal19_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assertion", 5);
			LeaveRule("assertion", 5);
			Leave_assertion();
			if (state.backtracking > 0) { Memoize(input, 5, assertion_StartIndex); }
		}
		DebugLocation(33, 1);
		} finally { DebugExitRule(GrammarFileName, "assertion"); }
		return retval;

	}
	// $ANTLR end "assertion"

	public class quantifier_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_quantifier();
	partial void Leave_quantifier();

	// $ANTLR start "quantifier"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:35:1: quantifier : ( quantifierPrefix '?' | quantifierPrefix );
	[GrammarRule("quantifier")]
	private JavaScriptRegExpParser.quantifier_return quantifier()
	{
		Enter_quantifier();
		EnterRule("quantifier", 6);
		TraceIn("quantifier", 6);
		JavaScriptRegExpParser.quantifier_return retval = new JavaScriptRegExpParser.quantifier_return();
		retval.Start = (IToken)input.LT(1);
		int quantifier_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal21=null;
		JavaScriptRegExpParser.quantifierPrefix_return quantifierPrefix20 = default(JavaScriptRegExpParser.quantifierPrefix_return);
		JavaScriptRegExpParser.quantifierPrefix_return quantifierPrefix22 = default(JavaScriptRegExpParser.quantifierPrefix_return);

		object char_literal21_tree=null;

		try { DebugEnterRule(GrammarFileName, "quantifier");
		DebugLocation(35, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:36:2: ( quantifierPrefix '?' | quantifierPrefix )
			int alt6=2;
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			try
			{
				alt6 = dfa6.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:36:4: quantifierPrefix '?'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(36, 4);
				PushFollow(Follow._quantifierPrefix_in_quantifier153);
				quantifierPrefix20=quantifierPrefix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quantifierPrefix20.Tree);
				DebugLocation(36, 21);
				char_literal21=(IToken)Match(input,12,Follow._12_in_quantifier155); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal21_tree = (object)adaptor.Create(char_literal21);
				adaptor.AddChild(root_0, char_literal21_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:37:4: quantifierPrefix
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(37, 4);
				PushFollow(Follow._quantifierPrefix_in_quantifier160);
				quantifierPrefix22=quantifierPrefix();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, quantifierPrefix22.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("quantifier", 6);
			LeaveRule("quantifier", 6);
			Leave_quantifier();
			if (state.backtracking > 0) { Memoize(input, 6, quantifier_StartIndex); }
		}
		DebugLocation(38, 1);
		} finally { DebugExitRule(GrammarFileName, "quantifier"); }
		return retval;

	}
	// $ANTLR end "quantifier"

	public class quantifierPrefix_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_quantifierPrefix();
	partial void Leave_quantifierPrefix();

	// $ANTLR start "quantifierPrefix"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:40:1: quantifierPrefix : ( '*' | '+' | '?' | '{' decimalDigits '}' | '{' decimalDigits ',}' | '{' decimalDigits ',' decimalDigits '}' );
	[GrammarRule("quantifierPrefix")]
	private JavaScriptRegExpParser.quantifierPrefix_return quantifierPrefix()
	{
		Enter_quantifierPrefix();
		EnterRule("quantifierPrefix", 7);
		TraceIn("quantifierPrefix", 7);
		JavaScriptRegExpParser.quantifierPrefix_return retval = new JavaScriptRegExpParser.quantifierPrefix_return();
		retval.Start = (IToken)input.LT(1);
		int quantifierPrefix_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal23=null;
		IToken char_literal24=null;
		IToken char_literal25=null;
		IToken char_literal26=null;
		IToken char_literal28=null;
		IToken char_literal29=null;
		IToken string_literal31=null;
		IToken char_literal32=null;
		IToken char_literal34=null;
		IToken char_literal36=null;
		JavaScriptRegExpParser.decimalDigits_return decimalDigits27 = default(JavaScriptRegExpParser.decimalDigits_return);
		JavaScriptRegExpParser.decimalDigits_return decimalDigits30 = default(JavaScriptRegExpParser.decimalDigits_return);
		JavaScriptRegExpParser.decimalDigits_return decimalDigits33 = default(JavaScriptRegExpParser.decimalDigits_return);
		JavaScriptRegExpParser.decimalDigits_return decimalDigits35 = default(JavaScriptRegExpParser.decimalDigits_return);

		object char_literal23_tree=null;
		object char_literal24_tree=null;
		object char_literal25_tree=null;
		object char_literal26_tree=null;
		object char_literal28_tree=null;
		object char_literal29_tree=null;
		object string_literal31_tree=null;
		object char_literal32_tree=null;
		object char_literal34_tree=null;
		object char_literal36_tree=null;

		try { DebugEnterRule(GrammarFileName, "quantifierPrefix");
		DebugLocation(40, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:41:2: ( '*' | '+' | '?' | '{' decimalDigits '}' | '{' decimalDigits ',}' | '{' decimalDigits ',' decimalDigits '}' )
			int alt7=6;
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			switch (input.LA(1))
			{
			case 13:
				{
				alt7=1;
				}
				break;
			case 14:
				{
				alt7=2;
				}
				break;
			case 12:
				{
				alt7=3;
				}
				break;
			case 15:
				{
				switch (input.LA(2))
				{
				case 16:
					{
					alt7=4;
					}
					break;
				case 17:
					{
					alt7=5;
					}
					break;
				case 18:
					{
					alt7=6;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 7, 4, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:41:4: '*'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(41, 4);
				char_literal23=(IToken)Match(input,13,Follow._13_in_quantifierPrefix171); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal23_tree = (object)adaptor.Create(char_literal23);
				adaptor.AddChild(root_0, char_literal23_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:42:4: '+'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(42, 4);
				char_literal24=(IToken)Match(input,14,Follow._14_in_quantifierPrefix176); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal24_tree = (object)adaptor.Create(char_literal24);
				adaptor.AddChild(root_0, char_literal24_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:43:4: '?'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(43, 4);
				char_literal25=(IToken)Match(input,12,Follow._12_in_quantifierPrefix181); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal25_tree = (object)adaptor.Create(char_literal25);
				adaptor.AddChild(root_0, char_literal25_tree);
				}

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:44:4: '{' decimalDigits '}'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(44, 4);
				char_literal26=(IToken)Match(input,15,Follow._15_in_quantifierPrefix186); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal26_tree = (object)adaptor.Create(char_literal26);
				adaptor.AddChild(root_0, char_literal26_tree);
				}
				DebugLocation(44, 8);
				PushFollow(Follow._decimalDigits_in_quantifierPrefix188);
				decimalDigits27=decimalDigits();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalDigits27.Tree);
				DebugLocation(44, 22);
				char_literal28=(IToken)Match(input,16,Follow._16_in_quantifierPrefix190); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal28_tree = (object)adaptor.Create(char_literal28);
				adaptor.AddChild(root_0, char_literal28_tree);
				}

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:45:4: '{' decimalDigits ',}'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(45, 4);
				char_literal29=(IToken)Match(input,15,Follow._15_in_quantifierPrefix195); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal29_tree = (object)adaptor.Create(char_literal29);
				adaptor.AddChild(root_0, char_literal29_tree);
				}
				DebugLocation(45, 8);
				PushFollow(Follow._decimalDigits_in_quantifierPrefix197);
				decimalDigits30=decimalDigits();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalDigits30.Tree);
				DebugLocation(45, 22);
				string_literal31=(IToken)Match(input,17,Follow._17_in_quantifierPrefix199); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal31_tree = (object)adaptor.Create(string_literal31);
				adaptor.AddChild(root_0, string_literal31_tree);
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:46:4: '{' decimalDigits ',' decimalDigits '}'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(46, 4);
				char_literal32=(IToken)Match(input,15,Follow._15_in_quantifierPrefix204); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal32_tree = (object)adaptor.Create(char_literal32);
				adaptor.AddChild(root_0, char_literal32_tree);
				}
				DebugLocation(46, 8);
				PushFollow(Follow._decimalDigits_in_quantifierPrefix206);
				decimalDigits33=decimalDigits();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalDigits33.Tree);
				DebugLocation(46, 22);
				char_literal34=(IToken)Match(input,18,Follow._18_in_quantifierPrefix208); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal34_tree = (object)adaptor.Create(char_literal34);
				adaptor.AddChild(root_0, char_literal34_tree);
				}
				DebugLocation(46, 26);
				PushFollow(Follow._decimalDigits_in_quantifierPrefix210);
				decimalDigits35=decimalDigits();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalDigits35.Tree);
				DebugLocation(46, 40);
				char_literal36=(IToken)Match(input,16,Follow._16_in_quantifierPrefix212); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal36_tree = (object)adaptor.Create(char_literal36);
				adaptor.AddChild(root_0, char_literal36_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("quantifierPrefix", 7);
			LeaveRule("quantifierPrefix", 7);
			Leave_quantifierPrefix();
			if (state.backtracking > 0) { Memoize(input, 7, quantifierPrefix_StartIndex); }
		}
		DebugLocation(47, 1);
		} finally { DebugExitRule(GrammarFileName, "quantifierPrefix"); }
		return retval;

	}
	// $ANTLR end "quantifierPrefix"

	public class atom_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_atom();
	partial void Leave_atom();

	// $ANTLR start "atom"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:49:1: atom : ( patternCharacter | '.' | '\\\\' atomEscape | characterClass | '(' disjunction ')' | '(:?' disjunction ')' );
	[GrammarRule("atom")]
	private JavaScriptRegExpParser.atom_return atom()
	{
		Enter_atom();
		EnterRule("atom", 8);
		TraceIn("atom", 8);
		JavaScriptRegExpParser.atom_return retval = new JavaScriptRegExpParser.atom_return();
		retval.Start = (IToken)input.LT(1);
		int atom_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal38=null;
		IToken char_literal39=null;
		IToken char_literal42=null;
		IToken char_literal44=null;
		IToken string_literal45=null;
		IToken char_literal47=null;
		JavaScriptRegExpParser.patternCharacter_return patternCharacter37 = default(JavaScriptRegExpParser.patternCharacter_return);
		JavaScriptRegExpParser.atomEscape_return atomEscape40 = default(JavaScriptRegExpParser.atomEscape_return);
		JavaScriptRegExpParser.characterClass_return characterClass41 = default(JavaScriptRegExpParser.characterClass_return);
		JavaScriptRegExpParser.disjunction_return disjunction43 = default(JavaScriptRegExpParser.disjunction_return);
		JavaScriptRegExpParser.disjunction_return disjunction46 = default(JavaScriptRegExpParser.disjunction_return);

		object char_literal38_tree=null;
		object char_literal39_tree=null;
		object char_literal42_tree=null;
		object char_literal44_tree=null;
		object string_literal45_tree=null;
		object char_literal47_tree=null;

		try { DebugEnterRule(GrammarFileName, "atom");
		DebugLocation(49, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:50:2: ( patternCharacter | '.' | '\\\\' atomEscape | characterClass | '(' disjunction ')' | '(:?' disjunction ')' )
			int alt8=6;
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			switch (input.LA(1))
			{
			case 47:
				{
				int LA8_1 = input.LA(2);

				if ((EvaluatePredicate(synpred16_JavaScriptRegExp_fragment)))
				{
					alt8=1;
				}
				else if ((EvaluatePredicate(synpred19_JavaScriptRegExp_fragment)))
				{
					alt8=4;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 8, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 19:
				{
				alt8=2;
				}
				break;
			case 20:
				{
				alt8=3;
				}
				break;
			case 23:
				{
				alt8=4;
				}
				break;
			case 22:
				{
				int LA8_5 = input.LA(2);

				if ((EvaluatePredicate(synpred16_JavaScriptRegExp_fragment)))
				{
					alt8=1;
				}
				else if ((true))
				{
					alt8=6;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 8, 5, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 21:
				{
				alt8=5;
				}
				break;
			case 7:
			case 8:
			case 9:
			case 11:
			case 17:
			case 18:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 46:
			case 48:
			case 49:
				{
				alt8=1;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:50:4: patternCharacter
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(50, 4);
				PushFollow(Follow._patternCharacter_in_atom223);
				patternCharacter37=patternCharacter();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, patternCharacter37.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:51:4: '.'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(51, 4);
				char_literal38=(IToken)Match(input,19,Follow._19_in_atom228); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal38_tree = (object)adaptor.Create(char_literal38);
				adaptor.AddChild(root_0, char_literal38_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:52:4: '\\\\' atomEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(52, 4);
				char_literal39=(IToken)Match(input,20,Follow._20_in_atom233); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal39_tree = (object)adaptor.Create(char_literal39);
				adaptor.AddChild(root_0, char_literal39_tree);
				}
				DebugLocation(52, 9);
				PushFollow(Follow._atomEscape_in_atom235);
				atomEscape40=atomEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, atomEscape40.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:53:4: characterClass
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(53, 4);
				PushFollow(Follow._characterClass_in_atom240);
				characterClass41=characterClass();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, characterClass41.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:54:4: '(' disjunction ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(54, 4);
				char_literal42=(IToken)Match(input,21,Follow._21_in_atom245); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal42_tree = (object)adaptor.Create(char_literal42);
				adaptor.AddChild(root_0, char_literal42_tree);
				}
				DebugLocation(54, 8);
				PushFollow(Follow._disjunction_in_atom247);
				disjunction43=disjunction();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, disjunction43.Tree);
				DebugLocation(54, 20);
				char_literal44=(IToken)Match(input,10,Follow._10_in_atom249); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal44_tree = (object)adaptor.Create(char_literal44);
				adaptor.AddChild(root_0, char_literal44_tree);
				}

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:55:4: '(:?' disjunction ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(55, 4);
				string_literal45=(IToken)Match(input,22,Follow._22_in_atom254); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal45_tree = (object)adaptor.Create(string_literal45);
				adaptor.AddChild(root_0, string_literal45_tree);
				}
				DebugLocation(55, 10);
				PushFollow(Follow._disjunction_in_atom256);
				disjunction46=disjunction();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, disjunction46.Tree);
				DebugLocation(55, 22);
				char_literal47=(IToken)Match(input,10,Follow._10_in_atom258); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal47_tree = (object)adaptor.Create(char_literal47);
				adaptor.AddChild(root_0, char_literal47_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("atom", 8);
			LeaveRule("atom", 8);
			Leave_atom();
			if (state.backtracking > 0) { Memoize(input, 8, atom_StartIndex); }
		}
		DebugLocation(56, 1);
		} finally { DebugExitRule(GrammarFileName, "atom"); }
		return retval;

	}
	// $ANTLR end "atom"

	public class patternCharacter_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_patternCharacter();
	partial void Leave_patternCharacter();

	// $ANTLR start "patternCharacter"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:58:1: patternCharacter : ~ ( '^' | '$' | '\\\\' | '.' | '*' | '+' | '?' | '(' | ')' | '[' | ']' | '{' | '}' | '|' ) ;
	[GrammarRule("patternCharacter")]
	private JavaScriptRegExpParser.patternCharacter_return patternCharacter()
	{
		Enter_patternCharacter();
		EnterRule("patternCharacter", 9);
		TraceIn("patternCharacter", 9);
		JavaScriptRegExpParser.patternCharacter_return retval = new JavaScriptRegExpParser.patternCharacter_return();
		retval.Start = (IToken)input.LT(1);
		int patternCharacter_StartIndex = input.Index;
		object root_0 = null;

		IToken set48=null;

		object set48_tree=null;

		try { DebugEnterRule(GrammarFileName, "patternCharacter");
		DebugLocation(58, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:59:2: (~ ( '^' | '$' | '\\\\' | '.' | '*' | '+' | '?' | '(' | ')' | '[' | ']' | '{' | '}' | '|' ) )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:59:4: ~ ( '^' | '$' | '\\\\' | '.' | '*' | '+' | '?' | '(' | ')' | '[' | ']' | '{' | '}' | '|' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(59, 4);
			set48=(IToken)input.LT(1);
			if ((input.LA(1)>=7 && input.LA(1)<=9)||input.LA(1)==11||(input.LA(1)>=17 && input.LA(1)<=18)||input.LA(1)==22||(input.LA(1)>=25 && input.LA(1)<=49))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set48));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("patternCharacter", 9);
			LeaveRule("patternCharacter", 9);
			Leave_patternCharacter();
			if (state.backtracking > 0) { Memoize(input, 9, patternCharacter_StartIndex); }
		}
		DebugLocation(60, 1);
		} finally { DebugExitRule(GrammarFileName, "patternCharacter"); }
		return retval;

	}
	// $ANTLR end "patternCharacter"

	public class atomEscape_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_atomEscape();
	partial void Leave_atomEscape();

	// $ANTLR start "atomEscape"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:62:1: atomEscape : ( decimalEscape | characterEscape | characterClassEscape );
	[GrammarRule("atomEscape")]
	private JavaScriptRegExpParser.atomEscape_return atomEscape()
	{
		Enter_atomEscape();
		EnterRule("atomEscape", 10);
		TraceIn("atomEscape", 10);
		JavaScriptRegExpParser.atomEscape_return retval = new JavaScriptRegExpParser.atomEscape_return();
		retval.Start = (IToken)input.LT(1);
		int atomEscape_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptRegExpParser.decimalEscape_return decimalEscape49 = default(JavaScriptRegExpParser.decimalEscape_return);
		JavaScriptRegExpParser.characterEscape_return characterEscape50 = default(JavaScriptRegExpParser.characterEscape_return);
		JavaScriptRegExpParser.characterClassEscape_return characterClassEscape51 = default(JavaScriptRegExpParser.characterClassEscape_return);


		try { DebugEnterRule(GrammarFileName, "atomEscape");
		DebugLocation(62, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:63:2: ( decimalEscape | characterEscape | characterClassEscape )
			int alt9=3;
			try { DebugEnterDecision(9, decisionCanBacktrack[9]);
			try
			{
				alt9 = dfa9.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:63:4: decimalEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(63, 4);
				PushFollow(Follow._decimalEscape_in_atomEscape335);
				decimalEscape49=decimalEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalEscape49.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:64:4: characterEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(64, 4);
				PushFollow(Follow._characterEscape_in_atomEscape340);
				characterEscape50=characterEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, characterEscape50.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:65:4: characterClassEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(65, 4);
				PushFollow(Follow._characterClassEscape_in_atomEscape345);
				characterClassEscape51=characterClassEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, characterClassEscape51.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("atomEscape", 10);
			LeaveRule("atomEscape", 10);
			Leave_atomEscape();
			if (state.backtracking > 0) { Memoize(input, 10, atomEscape_StartIndex); }
		}
		DebugLocation(66, 1);
		} finally { DebugExitRule(GrammarFileName, "atomEscape"); }
		return retval;

	}
	// $ANTLR end "atomEscape"

	public class characterEscape_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_characterEscape();
	partial void Leave_characterEscape();

	// $ANTLR start "characterEscape"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:68:1: characterEscape : ( controlEscape | 'c' controlLetter | hexEscapeSequence | unicodeEscapeSequence | identityEscape );
	[GrammarRule("characterEscape")]
	private JavaScriptRegExpParser.characterEscape_return characterEscape()
	{
		Enter_characterEscape();
		EnterRule("characterEscape", 11);
		TraceIn("characterEscape", 11);
		JavaScriptRegExpParser.characterEscape_return retval = new JavaScriptRegExpParser.characterEscape_return();
		retval.Start = (IToken)input.LT(1);
		int characterEscape_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal53=null;
		JavaScriptRegExpParser.controlEscape_return controlEscape52 = default(JavaScriptRegExpParser.controlEscape_return);
		JavaScriptRegExpParser.controlLetter_return controlLetter54 = default(JavaScriptRegExpParser.controlLetter_return);
		JavaScriptRegExpParser.hexEscapeSequence_return hexEscapeSequence55 = default(JavaScriptRegExpParser.hexEscapeSequence_return);
		JavaScriptRegExpParser.unicodeEscapeSequence_return unicodeEscapeSequence56 = default(JavaScriptRegExpParser.unicodeEscapeSequence_return);
		JavaScriptRegExpParser.identityEscape_return identityEscape57 = default(JavaScriptRegExpParser.identityEscape_return);

		object char_literal53_tree=null;

		try { DebugEnterRule(GrammarFileName, "characterEscape");
		DebugLocation(68, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:69:2: ( controlEscape | 'c' controlLetter | hexEscapeSequence | unicodeEscapeSequence | identityEscape )
			int alt10=5;
			try { DebugEnterDecision(10, decisionCanBacktrack[10]);
			switch (input.LA(1))
			{
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
				{
				int LA10_1 = input.LA(2);

				if ((EvaluatePredicate(synpred36_JavaScriptRegExp_fragment)))
				{
					alt10=1;
				}
				else if ((true))
				{
					alt10=5;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 25:
				{
				int LA10_2 = input.LA(2);

				if ((LA10_2==EOF||(LA10_2>=4 && LA10_2<=49)))
				{
					alt10=5;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 2, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 35:
				{
				int LA10_3 = input.LA(2);

				if ((LA10_3==EOF||(LA10_3>=4 && LA10_3<=49)))
				{
					alt10=5;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 3, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 36:
				{
				int LA10_4 = input.LA(2);

				if ((LA10_4==EOF||(LA10_4>=4 && LA10_4<=49)))
				{
					alt10=5;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 4, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case EOF:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
			case 22:
			case 23:
			case 24:
			case 31:
			case 32:
			case 33:
			case 34:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 46:
			case 47:
			case 48:
			case 49:
				{
				alt10=5;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(10); }
			switch (alt10)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:69:4: controlEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(69, 4);
				PushFollow(Follow._controlEscape_in_characterEscape356);
				controlEscape52=controlEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controlEscape52.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:70:4: 'c' controlLetter
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(70, 4);
				char_literal53=(IToken)Match(input,25,Follow._25_in_characterEscape361); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal53_tree = (object)adaptor.Create(char_literal53);
				adaptor.AddChild(root_0, char_literal53_tree);
				}
				DebugLocation(70, 8);
				PushFollow(Follow._controlLetter_in_characterEscape363);
				controlLetter54=controlLetter();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, controlLetter54.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:71:4: hexEscapeSequence
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(71, 4);
				PushFollow(Follow._hexEscapeSequence_in_characterEscape368);
				hexEscapeSequence55=hexEscapeSequence();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hexEscapeSequence55.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:72:4: unicodeEscapeSequence
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(72, 4);
				PushFollow(Follow._unicodeEscapeSequence_in_characterEscape373);
				unicodeEscapeSequence56=unicodeEscapeSequence();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unicodeEscapeSequence56.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:73:4: identityEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(73, 4);
				PushFollow(Follow._identityEscape_in_characterEscape378);
				identityEscape57=identityEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, identityEscape57.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("characterEscape", 11);
			LeaveRule("characterEscape", 11);
			Leave_characterEscape();
			if (state.backtracking > 0) { Memoize(input, 11, characterEscape_StartIndex); }
		}
		DebugLocation(74, 1);
		} finally { DebugExitRule(GrammarFileName, "characterEscape"); }
		return retval;

	}
	// $ANTLR end "characterEscape"

	public class controlEscape_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_controlEscape();
	partial void Leave_controlEscape();

	// $ANTLR start "controlEscape"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:76:1: controlEscape : ( 'f' | 'n' | 'r' | 't' | 'v' );
	[GrammarRule("controlEscape")]
	private JavaScriptRegExpParser.controlEscape_return controlEscape()
	{
		Enter_controlEscape();
		EnterRule("controlEscape", 12);
		TraceIn("controlEscape", 12);
		JavaScriptRegExpParser.controlEscape_return retval = new JavaScriptRegExpParser.controlEscape_return();
		retval.Start = (IToken)input.LT(1);
		int controlEscape_StartIndex = input.Index;
		object root_0 = null;

		IToken set58=null;

		object set58_tree=null;

		try { DebugEnterRule(GrammarFileName, "controlEscape");
		DebugLocation(76, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:77:2: ( 'f' | 'n' | 'r' | 't' | 'v' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(77, 2);
			set58=(IToken)input.LT(1);
			if ((input.LA(1)>=26 && input.LA(1)<=30))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set58));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("controlEscape", 12);
			LeaveRule("controlEscape", 12);
			Leave_controlEscape();
			if (state.backtracking > 0) { Memoize(input, 12, controlEscape_StartIndex); }
		}
		DebugLocation(82, 1);
		} finally { DebugExitRule(GrammarFileName, "controlEscape"); }
		return retval;

	}
	// $ANTLR end "controlEscape"

	public class controlLetter_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_controlLetter();
	partial void Leave_controlLetter();

	// $ANTLR start "controlLetter"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:84:1: controlLetter : ( 'a' .. 'z' | 'A' .. 'Z' ) ;
	[GrammarRule("controlLetter")]
	private JavaScriptRegExpParser.controlLetter_return controlLetter()
	{
		Enter_controlLetter();
		EnterRule("controlLetter", 13);
		TraceIn("controlLetter", 13);
		JavaScriptRegExpParser.controlLetter_return retval = new JavaScriptRegExpParser.controlLetter_return();
		retval.Start = (IToken)input.LT(1);
		int controlLetter_StartIndex = input.Index;
		object root_0 = null;

		IToken set59=null;

		object set59_tree=null;

		try { DebugEnterRule(GrammarFileName, "controlLetter");
		DebugLocation(84, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:85:2: ( ( 'a' .. 'z' | 'A' .. 'Z' ) )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:85:4: ( 'a' .. 'z' | 'A' .. 'Z' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(85, 4);
			set59=(IToken)input.LT(1);
			if ()
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set59));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("controlLetter", 13);
			LeaveRule("controlLetter", 13);
			Leave_controlLetter();
			if (state.backtracking > 0) { Memoize(input, 13, controlLetter_StartIndex); }
		}
		DebugLocation(86, 1);
		} finally { DebugExitRule(GrammarFileName, "controlLetter"); }
		return retval;

	}
	// $ANTLR end "controlLetter"

	public class hexEscapeSequence_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_hexEscapeSequence();
	partial void Leave_hexEscapeSequence();

	// $ANTLR start "hexEscapeSequence"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:88:1: hexEscapeSequence : 'x' hexDigit hexDigit ;
	[GrammarRule("hexEscapeSequence")]
	private JavaScriptRegExpParser.hexEscapeSequence_return hexEscapeSequence()
	{
		Enter_hexEscapeSequence();
		EnterRule("hexEscapeSequence", 14);
		TraceIn("hexEscapeSequence", 14);
		JavaScriptRegExpParser.hexEscapeSequence_return retval = new JavaScriptRegExpParser.hexEscapeSequence_return();
		retval.Start = (IToken)input.LT(1);
		int hexEscapeSequence_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal60=null;
		JavaScriptRegExpParser.hexDigit_return hexDigit61 = default(JavaScriptRegExpParser.hexDigit_return);
		JavaScriptRegExpParser.hexDigit_return hexDigit62 = default(JavaScriptRegExpParser.hexDigit_return);

		object char_literal60_tree=null;

		try { DebugEnterRule(GrammarFileName, "hexEscapeSequence");
		DebugLocation(88, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:89:2: ( 'x' hexDigit hexDigit )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:89:4: 'x' hexDigit hexDigit
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 4);
			char_literal60=(IToken)Match(input,35,Follow._35_in_hexEscapeSequence440); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal60_tree = (object)adaptor.Create(char_literal60);
			adaptor.AddChild(root_0, char_literal60_tree);
			}
			DebugLocation(89, 8);
			PushFollow(Follow._hexDigit_in_hexEscapeSequence442);
			hexDigit61=hexDigit();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hexDigit61.Tree);
			DebugLocation(89, 17);
			PushFollow(Follow._hexDigit_in_hexEscapeSequence444);
			hexDigit62=hexDigit();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hexDigit62.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("hexEscapeSequence", 14);
			LeaveRule("hexEscapeSequence", 14);
			Leave_hexEscapeSequence();
			if (state.backtracking > 0) { Memoize(input, 14, hexEscapeSequence_StartIndex); }
		}
		DebugLocation(90, 1);
		} finally { DebugExitRule(GrammarFileName, "hexEscapeSequence"); }
		return retval;

	}
	// $ANTLR end "hexEscapeSequence"

	public class unicodeEscapeSequence_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_unicodeEscapeSequence();
	partial void Leave_unicodeEscapeSequence();

	// $ANTLR start "unicodeEscapeSequence"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:92:1: unicodeEscapeSequence : 'u' hexDigit hexDigit hexDigit hexDigit ;
	[GrammarRule("unicodeEscapeSequence")]
	private JavaScriptRegExpParser.unicodeEscapeSequence_return unicodeEscapeSequence()
	{
		Enter_unicodeEscapeSequence();
		EnterRule("unicodeEscapeSequence", 15);
		TraceIn("unicodeEscapeSequence", 15);
		JavaScriptRegExpParser.unicodeEscapeSequence_return retval = new JavaScriptRegExpParser.unicodeEscapeSequence_return();
		retval.Start = (IToken)input.LT(1);
		int unicodeEscapeSequence_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal63=null;
		JavaScriptRegExpParser.hexDigit_return hexDigit64 = default(JavaScriptRegExpParser.hexDigit_return);
		JavaScriptRegExpParser.hexDigit_return hexDigit65 = default(JavaScriptRegExpParser.hexDigit_return);
		JavaScriptRegExpParser.hexDigit_return hexDigit66 = default(JavaScriptRegExpParser.hexDigit_return);
		JavaScriptRegExpParser.hexDigit_return hexDigit67 = default(JavaScriptRegExpParser.hexDigit_return);

		object char_literal63_tree=null;

		try { DebugEnterRule(GrammarFileName, "unicodeEscapeSequence");
		DebugLocation(92, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:93:2: ( 'u' hexDigit hexDigit hexDigit hexDigit )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:93:4: 'u' hexDigit hexDigit hexDigit hexDigit
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(93, 4);
			char_literal63=(IToken)Match(input,36,Follow._36_in_unicodeEscapeSequence455); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			char_literal63_tree = (object)adaptor.Create(char_literal63);
			adaptor.AddChild(root_0, char_literal63_tree);
			}
			DebugLocation(93, 8);
			PushFollow(Follow._hexDigit_in_unicodeEscapeSequence457);
			hexDigit64=hexDigit();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hexDigit64.Tree);
			DebugLocation(93, 17);
			PushFollow(Follow._hexDigit_in_unicodeEscapeSequence459);
			hexDigit65=hexDigit();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hexDigit65.Tree);
			DebugLocation(93, 26);
			PushFollow(Follow._hexDigit_in_unicodeEscapeSequence461);
			hexDigit66=hexDigit();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hexDigit66.Tree);
			DebugLocation(93, 35);
			PushFollow(Follow._hexDigit_in_unicodeEscapeSequence463);
			hexDigit67=hexDigit();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, hexDigit67.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("unicodeEscapeSequence", 15);
			LeaveRule("unicodeEscapeSequence", 15);
			Leave_unicodeEscapeSequence();
			if (state.backtracking > 0) { Memoize(input, 15, unicodeEscapeSequence_StartIndex); }
		}
		DebugLocation(94, 1);
		} finally { DebugExitRule(GrammarFileName, "unicodeEscapeSequence"); }
		return retval;

	}
	// $ANTLR end "unicodeEscapeSequence"

	public class hexDigit_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_hexDigit();
	partial void Leave_hexDigit();

	// $ANTLR start "hexDigit"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:96:1: hexDigit : ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) ;
	[GrammarRule("hexDigit")]
	private JavaScriptRegExpParser.hexDigit_return hexDigit()
	{
		Enter_hexDigit();
		EnterRule("hexDigit", 16);
		TraceIn("hexDigit", 16);
		JavaScriptRegExpParser.hexDigit_return retval = new JavaScriptRegExpParser.hexDigit_return();
		retval.Start = (IToken)input.LT(1);
		int hexDigit_StartIndex = input.Index;
		object root_0 = null;

		IToken set68=null;

		object set68_tree=null;

		try { DebugEnterRule(GrammarFileName, "hexDigit");
		DebugLocation(96, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:97:2: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:97:4: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 4);
			set68=(IToken)input.LT(1);
			if ()
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set68));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("hexDigit", 16);
			LeaveRule("hexDigit", 16);
			Leave_hexDigit();
			if (state.backtracking > 0) { Memoize(input, 16, hexDigit_StartIndex); }
		}
		DebugLocation(98, 1);
		} finally { DebugExitRule(GrammarFileName, "hexDigit"); }
		return retval;

	}
	// $ANTLR end "hexDigit"

	public class identityEscape_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_identityEscape();
	partial void Leave_identityEscape();

	// $ANTLR start "identityEscape"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:100:1: identityEscape : 'a' .. 'z' ;
	[GrammarRule("identityEscape")]
	private JavaScriptRegExpParser.identityEscape_return identityEscape()
	{
		Enter_identityEscape();
		EnterRule("identityEscape", 17);
		TraceIn("identityEscape", 17);
		JavaScriptRegExpParser.identityEscape_return retval = new JavaScriptRegExpParser.identityEscape_return();
		retval.Start = (IToken)input.LT(1);
		int identityEscape_StartIndex = input.Index;
		object root_0 = null;

		try { DebugEnterRule(GrammarFileName, "identityEscape");
		DebugLocation(100, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:101:2: ( 'a' .. 'z' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:101:4: 'a' .. 'z'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(101, 4);
			MatchRange('a','z'); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("identityEscape", 17);
			LeaveRule("identityEscape", 17);
			Leave_identityEscape();
			if (state.backtracking > 0) { Memoize(input, 17, identityEscape_StartIndex); }
		}
		DebugLocation(102, 1);
		} finally { DebugExitRule(GrammarFileName, "identityEscape"); }
		return retval;

	}
	// $ANTLR end "identityEscape"

	public class decimalEscape_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_decimalEscape();
	partial void Leave_decimalEscape();

	// $ANTLR start "decimalEscape"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:104:1: decimalEscape : decimalIntegerLiteral ;
	[GrammarRule("decimalEscape")]
	private JavaScriptRegExpParser.decimalEscape_return decimalEscape()
	{
		Enter_decimalEscape();
		EnterRule("decimalEscape", 18);
		TraceIn("decimalEscape", 18);
		JavaScriptRegExpParser.decimalEscape_return retval = new JavaScriptRegExpParser.decimalEscape_return();
		retval.Start = (IToken)input.LT(1);
		int decimalEscape_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptRegExpParser.decimalIntegerLiteral_return decimalIntegerLiteral69 = default(JavaScriptRegExpParser.decimalIntegerLiteral_return);


		try { DebugEnterRule(GrammarFileName, "decimalEscape");
		DebugLocation(104, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:105:2: ( decimalIntegerLiteral )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:105:4: decimalIntegerLiteral
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 4);
			PushFollow(Follow._decimalIntegerLiteral_in_decimalEscape512);
			decimalIntegerLiteral69=decimalIntegerLiteral();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalIntegerLiteral69.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("decimalEscape", 18);
			LeaveRule("decimalEscape", 18);
			Leave_decimalEscape();
			if (state.backtracking > 0) { Memoize(input, 18, decimalEscape_StartIndex); }
		}
		DebugLocation(106, 1);
		} finally { DebugExitRule(GrammarFileName, "decimalEscape"); }
		return retval;

	}
	// $ANTLR end "decimalEscape"

	public class decimalIntegerLiteral_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_decimalIntegerLiteral();
	partial void Leave_decimalIntegerLiteral();

	// $ANTLR start "decimalIntegerLiteral"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:108:1: decimalIntegerLiteral : ( '0' | nonZeroDigit ( decimalDigits )? );
	[GrammarRule("decimalIntegerLiteral")]
	private JavaScriptRegExpParser.decimalIntegerLiteral_return decimalIntegerLiteral()
	{
		Enter_decimalIntegerLiteral();
		EnterRule("decimalIntegerLiteral", 19);
		TraceIn("decimalIntegerLiteral", 19);
		JavaScriptRegExpParser.decimalIntegerLiteral_return retval = new JavaScriptRegExpParser.decimalIntegerLiteral_return();
		retval.Start = (IToken)input.LT(1);
		int decimalIntegerLiteral_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal70=null;
		JavaScriptRegExpParser.nonZeroDigit_return nonZeroDigit71 = default(JavaScriptRegExpParser.nonZeroDigit_return);
		JavaScriptRegExpParser.decimalDigits_return decimalDigits72 = default(JavaScriptRegExpParser.decimalDigits_return);

		object char_literal70_tree=null;

		try { DebugEnterRule(GrammarFileName, "decimalIntegerLiteral");
		DebugLocation(108, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:109:2: ( '0' | nonZeroDigit ( decimalDigits )? )
			int alt12=2;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			int LA12_0 = input.LA(1);

			if ((LA12_0==37))
			{
				int LA12_1 = input.LA(2);

				if ((EvaluatePredicate(synpred47_JavaScriptRegExp_fragment)))
				{
					alt12=1;
				}
				else if ((true))
				{
					alt12=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 12, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else if ((LA12_0==EOF||(LA12_0>=4 && LA12_0<=36)||(LA12_0>=38 && LA12_0<=49)))
			{
				alt12=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:109:4: '0'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(109, 4);
				char_literal70=(IToken)Match(input,37,Follow._37_in_decimalIntegerLiteral525); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal70_tree = (object)adaptor.Create(char_literal70);
				adaptor.AddChild(root_0, char_literal70_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:110:4: nonZeroDigit ( decimalDigits )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(110, 4);
				PushFollow(Follow._nonZeroDigit_in_decimalIntegerLiteral530);
				nonZeroDigit71=nonZeroDigit();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonZeroDigit71.Tree);
				DebugLocation(110, 17);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:110:17: ( decimalDigits )?
				int alt11=2;
				try { DebugEnterSubRule(11);
				try { DebugEnterDecision(11, decisionCanBacktrack[11]);
				try
				{
					alt11 = dfa11.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(11); }
				switch (alt11)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:0:0: decimalDigits
					{
					DebugLocation(110, 17);
					PushFollow(Follow._decimalDigits_in_decimalIntegerLiteral532);
					decimalDigits72=decimalDigits();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalDigits72.Tree);

					}
					break;

				}
				} finally { DebugExitSubRule(11); }


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("decimalIntegerLiteral", 19);
			LeaveRule("decimalIntegerLiteral", 19);
			Leave_decimalIntegerLiteral();
			if (state.backtracking > 0) { Memoize(input, 19, decimalIntegerLiteral_StartIndex); }
		}
		DebugLocation(111, 1);
		} finally { DebugExitRule(GrammarFileName, "decimalIntegerLiteral"); }
		return retval;

	}
	// $ANTLR end "decimalIntegerLiteral"

	public class nonZeroDigit_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_nonZeroDigit();
	partial void Leave_nonZeroDigit();

	// $ANTLR start "nonZeroDigit"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:113:1: nonZeroDigit : '1' .. '9' ;
	[GrammarRule("nonZeroDigit")]
	private JavaScriptRegExpParser.nonZeroDigit_return nonZeroDigit()
	{
		Enter_nonZeroDigit();
		EnterRule("nonZeroDigit", 20);
		TraceIn("nonZeroDigit", 20);
		JavaScriptRegExpParser.nonZeroDigit_return retval = new JavaScriptRegExpParser.nonZeroDigit_return();
		retval.Start = (IToken)input.LT(1);
		int nonZeroDigit_StartIndex = input.Index;
		object root_0 = null;

		try { DebugEnterRule(GrammarFileName, "nonZeroDigit");
		DebugLocation(113, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:114:2: ( '1' .. '9' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:114:4: '1' .. '9'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(114, 4);
			MatchRange('1','9'); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("nonZeroDigit", 20);
			LeaveRule("nonZeroDigit", 20);
			Leave_nonZeroDigit();
			if (state.backtracking > 0) { Memoize(input, 20, nonZeroDigit_StartIndex); }
		}
		DebugLocation(115, 1);
		} finally { DebugExitRule(GrammarFileName, "nonZeroDigit"); }
		return retval;

	}
	// $ANTLR end "nonZeroDigit"

	public class decimalDigits_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_decimalDigits();
	partial void Leave_decimalDigits();

	// $ANTLR start "decimalDigits"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:117:1: decimalDigits : ( decimalDigit )+ ;
	[GrammarRule("decimalDigits")]
	private JavaScriptRegExpParser.decimalDigits_return decimalDigits()
	{
		Enter_decimalDigits();
		EnterRule("decimalDigits", 21);
		TraceIn("decimalDigits", 21);
		JavaScriptRegExpParser.decimalDigits_return retval = new JavaScriptRegExpParser.decimalDigits_return();
		retval.Start = (IToken)input.LT(1);
		int decimalDigits_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptRegExpParser.decimalDigit_return decimalDigit73 = default(JavaScriptRegExpParser.decimalDigit_return);


		try { DebugEnterRule(GrammarFileName, "decimalDigits");
		DebugLocation(117, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:118:2: ( ( decimalDigit )+ )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:118:4: ( decimalDigit )+
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(118, 4);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:118:4: ( decimalDigit )+
			int cnt13=0;
			try { DebugEnterSubRule(13);
			while (true)
			{
				int alt13=2;
				try { DebugEnterDecision(13, decisionCanBacktrack[13]);
				try
				{
					alt13 = dfa13.Predict(input);
				}
				catch (NoViableAltException nvae)
				{
					DebugRecognitionException(nvae);
					throw;
				}
				} finally { DebugExitDecision(13); }
				switch (alt13)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:0:0: decimalDigit
					{
					DebugLocation(118, 4);
					PushFollow(Follow._decimalDigit_in_decimalDigits558);
					decimalDigit73=decimalDigit();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalDigit73.Tree);

					}
					break;

				default:
					if (cnt13 >= 1)
						goto loop13;

					if (state.backtracking>0) {state.failed=true; return retval;}
					EarlyExitException eee13 = new EarlyExitException( 13, input );
					DebugRecognitionException(eee13);
					throw eee13;
				}
				cnt13++;
			}
			loop13:
				;

			} finally { DebugExitSubRule(13); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("decimalDigits", 21);
			LeaveRule("decimalDigits", 21);
			Leave_decimalDigits();
			if (state.backtracking > 0) { Memoize(input, 21, decimalDigits_StartIndex); }
		}
		DebugLocation(119, 1);
		} finally { DebugExitRule(GrammarFileName, "decimalDigits"); }
		return retval;

	}
	// $ANTLR end "decimalDigits"

	public class decimalDigit_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_decimalDigit();
	partial void Leave_decimalDigit();

	// $ANTLR start "decimalDigit"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:121:1: decimalDigit : '0' .. '9' ;
	[GrammarRule("decimalDigit")]
	private JavaScriptRegExpParser.decimalDigit_return decimalDigit()
	{
		Enter_decimalDigit();
		EnterRule("decimalDigit", 22);
		TraceIn("decimalDigit", 22);
		JavaScriptRegExpParser.decimalDigit_return retval = new JavaScriptRegExpParser.decimalDigit_return();
		retval.Start = (IToken)input.LT(1);
		int decimalDigit_StartIndex = input.Index;
		object root_0 = null;

		try { DebugEnterRule(GrammarFileName, "decimalDigit");
		DebugLocation(121, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:122:2: ( '0' .. '9' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:122:4: '0' .. '9'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(122, 4);
			MatchRange('0','9'); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("decimalDigit", 22);
			LeaveRule("decimalDigit", 22);
			Leave_decimalDigit();
			if (state.backtracking > 0) { Memoize(input, 22, decimalDigit_StartIndex); }
		}
		DebugLocation(123, 1);
		} finally { DebugExitRule(GrammarFileName, "decimalDigit"); }
		return retval;

	}
	// $ANTLR end "decimalDigit"

	public class characterClassEscape_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_characterClassEscape();
	partial void Leave_characterClassEscape();

	// $ANTLR start "characterClassEscape"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:125:1: characterClassEscape : ( 'd' | 'D' | 's' | 'S' | 'w' | 'W' );
	[GrammarRule("characterClassEscape")]
	private JavaScriptRegExpParser.characterClassEscape_return characterClassEscape()
	{
		Enter_characterClassEscape();
		EnterRule("characterClassEscape", 23);
		TraceIn("characterClassEscape", 23);
		JavaScriptRegExpParser.characterClassEscape_return retval = new JavaScriptRegExpParser.characterClassEscape_return();
		retval.Start = (IToken)input.LT(1);
		int characterClassEscape_StartIndex = input.Index;
		object root_0 = null;

		IToken set74=null;

		object set74_tree=null;

		try { DebugEnterRule(GrammarFileName, "characterClassEscape");
		DebugLocation(125, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:126:2: ( 'd' | 'D' | 's' | 'S' | 'w' | 'W' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(126, 2);
			set74=(IToken)input.LT(1);
			if ((input.LA(1)>=41 && input.LA(1)<=46))
			{
				input.Consume();
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set74));
				state.errorRecovery=false;state.failed=false;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				throw mse;
			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("characterClassEscape", 23);
			LeaveRule("characterClassEscape", 23);
			Leave_characterClassEscape();
			if (state.backtracking > 0) { Memoize(input, 23, characterClassEscape_StartIndex); }
		}
		DebugLocation(132, 1);
		} finally { DebugExitRule(GrammarFileName, "characterClassEscape"); }
		return retval;

	}
	// $ANTLR end "characterClassEscape"

	public class characterClass_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_characterClass();
	partial void Leave_characterClass();

	// $ANTLR start "characterClass"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:134:1: characterClass : ( '[' t=~ '^' classRanges ']' | '[^' classRanges ']' );
	[GrammarRule("characterClass")]
	private JavaScriptRegExpParser.characterClass_return characterClass()
	{
		Enter_characterClass();
		EnterRule("characterClass", 24);
		TraceIn("characterClass", 24);
		JavaScriptRegExpParser.characterClass_return retval = new JavaScriptRegExpParser.characterClass_return();
		retval.Start = (IToken)input.LT(1);
		int characterClass_StartIndex = input.Index;
		object root_0 = null;

		IToken t=null;
		IToken char_literal75=null;
		IToken char_literal77=null;
		IToken string_literal78=null;
		IToken char_literal80=null;
		JavaScriptRegExpParser.classRanges_return classRanges76 = default(JavaScriptRegExpParser.classRanges_return);
		JavaScriptRegExpParser.classRanges_return classRanges79 = default(JavaScriptRegExpParser.classRanges_return);

		object t_tree=null;
		object char_literal75_tree=null;
		object char_literal77_tree=null;
		object string_literal78_tree=null;
		object char_literal80_tree=null;

		try { DebugEnterRule(GrammarFileName, "characterClass");
		DebugLocation(134, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:135:2: ( '[' t=~ '^' classRanges ']' | '[^' classRanges ']' )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			int LA14_0 = input.LA(1);

			if ((LA14_0==23))
			{
				alt14=1;
			}
			else if ((LA14_0==47))
			{
				alt14=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:135:4: '[' t=~ '^' classRanges ']'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(135, 4);
				char_literal75=(IToken)Match(input,23,Follow._23_in_characterClass619); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal75_tree = (object)adaptor.Create(char_literal75);
				adaptor.AddChild(root_0, char_literal75_tree);
				}
				DebugLocation(135, 9);
				t=(IToken)input.LT(1);
				if (input.LA(1)==4||(input.LA(1)>=6 && input.LA(1)<=49))
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(t));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(135, 15);
				PushFollow(Follow._classRanges_in_characterClass626);
				classRanges76=classRanges();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classRanges76.Tree);
				DebugLocation(135, 27);
				char_literal77=(IToken)Match(input,24,Follow._24_in_characterClass628); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal77_tree = (object)adaptor.Create(char_literal77);
				adaptor.AddChild(root_0, char_literal77_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:136:4: '[^' classRanges ']'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(136, 4);
				string_literal78=(IToken)Match(input,47,Follow._47_in_characterClass633); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				string_literal78_tree = (object)adaptor.Create(string_literal78);
				adaptor.AddChild(root_0, string_literal78_tree);
				}
				DebugLocation(136, 9);
				PushFollow(Follow._classRanges_in_characterClass635);
				classRanges79=classRanges();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classRanges79.Tree);
				DebugLocation(136, 21);
				char_literal80=(IToken)Match(input,24,Follow._24_in_characterClass637); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal80_tree = (object)adaptor.Create(char_literal80);
				adaptor.AddChild(root_0, char_literal80_tree);
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("characterClass", 24);
			LeaveRule("characterClass", 24);
			Leave_characterClass();
			if (state.backtracking > 0) { Memoize(input, 24, characterClass_StartIndex); }
		}
		DebugLocation(137, 1);
		} finally { DebugExitRule(GrammarFileName, "characterClass"); }
		return retval;

	}
	// $ANTLR end "characterClass"

	public class classRanges_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_classRanges();
	partial void Leave_classRanges();

	// $ANTLR start "classRanges"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:139:1: classRanges : ( nonEmptyClassRanges )? ;
	[GrammarRule("classRanges")]
	private JavaScriptRegExpParser.classRanges_return classRanges()
	{
		Enter_classRanges();
		EnterRule("classRanges", 25);
		TraceIn("classRanges", 25);
		JavaScriptRegExpParser.classRanges_return retval = new JavaScriptRegExpParser.classRanges_return();
		retval.Start = (IToken)input.LT(1);
		int classRanges_StartIndex = input.Index;
		object root_0 = null;

		JavaScriptRegExpParser.nonEmptyClassRanges_return nonEmptyClassRanges81 = default(JavaScriptRegExpParser.nonEmptyClassRanges_return);


		try { DebugEnterRule(GrammarFileName, "classRanges");
		DebugLocation(139, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:140:2: ( ( nonEmptyClassRanges )? )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:140:4: ( nonEmptyClassRanges )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(140, 4);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:140:4: ( nonEmptyClassRanges )?
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if (((LA15_0>=4 && LA15_0<=23)||(LA15_0>=25 && LA15_0<=49)))
			{
				alt15=1;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:0:0: nonEmptyClassRanges
				{
				DebugLocation(140, 4);
				PushFollow(Follow._nonEmptyClassRanges_in_classRanges648);
				nonEmptyClassRanges81=nonEmptyClassRanges();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEmptyClassRanges81.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(15); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("classRanges", 25);
			LeaveRule("classRanges", 25);
			Leave_classRanges();
			if (state.backtracking > 0) { Memoize(input, 25, classRanges_StartIndex); }
		}
		DebugLocation(141, 1);
		} finally { DebugExitRule(GrammarFileName, "classRanges"); }
		return retval;

	}
	// $ANTLR end "classRanges"

	public class nonEmptyClassRanges_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_nonEmptyClassRanges();
	partial void Leave_nonEmptyClassRanges();

	// $ANTLR start "nonEmptyClassRanges"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:143:1: nonEmptyClassRanges : ( classAtom | classAtom nonEmptyClassRangesNoDash | classAtom '-' classAtom classRanges );
	[GrammarRule("nonEmptyClassRanges")]
	private JavaScriptRegExpParser.nonEmptyClassRanges_return nonEmptyClassRanges()
	{
		Enter_nonEmptyClassRanges();
		EnterRule("nonEmptyClassRanges", 26);
		TraceIn("nonEmptyClassRanges", 26);
		JavaScriptRegExpParser.nonEmptyClassRanges_return retval = new JavaScriptRegExpParser.nonEmptyClassRanges_return();
		retval.Start = (IToken)input.LT(1);
		int nonEmptyClassRanges_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal86=null;
		JavaScriptRegExpParser.classAtom_return classAtom82 = default(JavaScriptRegExpParser.classAtom_return);
		JavaScriptRegExpParser.classAtom_return classAtom83 = default(JavaScriptRegExpParser.classAtom_return);
		JavaScriptRegExpParser.nonEmptyClassRangesNoDash_return nonEmptyClassRangesNoDash84 = default(JavaScriptRegExpParser.nonEmptyClassRangesNoDash_return);
		JavaScriptRegExpParser.classAtom_return classAtom85 = default(JavaScriptRegExpParser.classAtom_return);
		JavaScriptRegExpParser.classAtom_return classAtom87 = default(JavaScriptRegExpParser.classAtom_return);
		JavaScriptRegExpParser.classRanges_return classRanges88 = default(JavaScriptRegExpParser.classRanges_return);

		object char_literal86_tree=null;

		try { DebugEnterRule(GrammarFileName, "nonEmptyClassRanges");
		DebugLocation(143, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:144:2: ( classAtom | classAtom nonEmptyClassRangesNoDash | classAtom '-' classAtom classRanges )
			int alt16=3;
			try { DebugEnterDecision(16, decisionCanBacktrack[16]);
			try
			{
				alt16 = dfa16.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(16); }
			switch (alt16)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:144:4: classAtom
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(144, 4);
				PushFollow(Follow._classAtom_in_nonEmptyClassRanges660);
				classAtom82=classAtom();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtom82.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:145:4: classAtom nonEmptyClassRangesNoDash
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(145, 4);
				PushFollow(Follow._classAtom_in_nonEmptyClassRanges665);
				classAtom83=classAtom();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtom83.Tree);
				DebugLocation(145, 14);
				PushFollow(Follow._nonEmptyClassRangesNoDash_in_nonEmptyClassRanges667);
				nonEmptyClassRangesNoDash84=nonEmptyClassRangesNoDash();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEmptyClassRangesNoDash84.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:146:4: classAtom '-' classAtom classRanges
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(146, 4);
				PushFollow(Follow._classAtom_in_nonEmptyClassRanges672);
				classAtom85=classAtom();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtom85.Tree);
				DebugLocation(146, 14);
				char_literal86=(IToken)Match(input,48,Follow._48_in_nonEmptyClassRanges674); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal86_tree = (object)adaptor.Create(char_literal86);
				adaptor.AddChild(root_0, char_literal86_tree);
				}
				DebugLocation(146, 18);
				PushFollow(Follow._classAtom_in_nonEmptyClassRanges676);
				classAtom87=classAtom();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtom87.Tree);
				DebugLocation(146, 28);
				PushFollow(Follow._classRanges_in_nonEmptyClassRanges678);
				classRanges88=classRanges();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classRanges88.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("nonEmptyClassRanges", 26);
			LeaveRule("nonEmptyClassRanges", 26);
			Leave_nonEmptyClassRanges();
			if (state.backtracking > 0) { Memoize(input, 26, nonEmptyClassRanges_StartIndex); }
		}
		DebugLocation(147, 1);
		} finally { DebugExitRule(GrammarFileName, "nonEmptyClassRanges"); }
		return retval;

	}
	// $ANTLR end "nonEmptyClassRanges"

	public class nonEmptyClassRangesNoDash_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_nonEmptyClassRangesNoDash();
	partial void Leave_nonEmptyClassRangesNoDash();

	// $ANTLR start "nonEmptyClassRangesNoDash"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:149:1: nonEmptyClassRangesNoDash : ( classAtom | classAtomNoDash nonEmptyClassRangesNoDash | classAtomNoDash '-' classAtom classRanges );
	[GrammarRule("nonEmptyClassRangesNoDash")]
	private JavaScriptRegExpParser.nonEmptyClassRangesNoDash_return nonEmptyClassRangesNoDash()
	{
		Enter_nonEmptyClassRangesNoDash();
		EnterRule("nonEmptyClassRangesNoDash", 27);
		TraceIn("nonEmptyClassRangesNoDash", 27);
		JavaScriptRegExpParser.nonEmptyClassRangesNoDash_return retval = new JavaScriptRegExpParser.nonEmptyClassRangesNoDash_return();
		retval.Start = (IToken)input.LT(1);
		int nonEmptyClassRangesNoDash_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal93=null;
		JavaScriptRegExpParser.classAtom_return classAtom89 = default(JavaScriptRegExpParser.classAtom_return);
		JavaScriptRegExpParser.classAtomNoDash_return classAtomNoDash90 = default(JavaScriptRegExpParser.classAtomNoDash_return);
		JavaScriptRegExpParser.nonEmptyClassRangesNoDash_return nonEmptyClassRangesNoDash91 = default(JavaScriptRegExpParser.nonEmptyClassRangesNoDash_return);
		JavaScriptRegExpParser.classAtomNoDash_return classAtomNoDash92 = default(JavaScriptRegExpParser.classAtomNoDash_return);
		JavaScriptRegExpParser.classAtom_return classAtom94 = default(JavaScriptRegExpParser.classAtom_return);
		JavaScriptRegExpParser.classRanges_return classRanges95 = default(JavaScriptRegExpParser.classRanges_return);

		object char_literal93_tree=null;

		try { DebugEnterRule(GrammarFileName, "nonEmptyClassRangesNoDash");
		DebugLocation(149, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 27)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:150:2: ( classAtom | classAtomNoDash nonEmptyClassRangesNoDash | classAtomNoDash '-' classAtom classRanges )
			int alt17=3;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			try
			{
				alt17 = dfa17.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:150:4: classAtom
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(150, 4);
				PushFollow(Follow._classAtom_in_nonEmptyClassRangesNoDash689);
				classAtom89=classAtom();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtom89.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:151:4: classAtomNoDash nonEmptyClassRangesNoDash
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(151, 4);
				PushFollow(Follow._classAtomNoDash_in_nonEmptyClassRangesNoDash694);
				classAtomNoDash90=classAtomNoDash();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtomNoDash90.Tree);
				DebugLocation(151, 20);
				PushFollow(Follow._nonEmptyClassRangesNoDash_in_nonEmptyClassRangesNoDash696);
				nonEmptyClassRangesNoDash91=nonEmptyClassRangesNoDash();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nonEmptyClassRangesNoDash91.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:152:4: classAtomNoDash '-' classAtom classRanges
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(152, 4);
				PushFollow(Follow._classAtomNoDash_in_nonEmptyClassRangesNoDash701);
				classAtomNoDash92=classAtomNoDash();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtomNoDash92.Tree);
				DebugLocation(152, 20);
				char_literal93=(IToken)Match(input,48,Follow._48_in_nonEmptyClassRangesNoDash703); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal93_tree = (object)adaptor.Create(char_literal93);
				adaptor.AddChild(root_0, char_literal93_tree);
				}
				DebugLocation(152, 24);
				PushFollow(Follow._classAtom_in_nonEmptyClassRangesNoDash705);
				classAtom94=classAtom();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtom94.Tree);
				DebugLocation(152, 34);
				PushFollow(Follow._classRanges_in_nonEmptyClassRangesNoDash707);
				classRanges95=classRanges();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classRanges95.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("nonEmptyClassRangesNoDash", 27);
			LeaveRule("nonEmptyClassRangesNoDash", 27);
			Leave_nonEmptyClassRangesNoDash();
			if (state.backtracking > 0) { Memoize(input, 27, nonEmptyClassRangesNoDash_StartIndex); }
		}
		DebugLocation(153, 1);
		} finally { DebugExitRule(GrammarFileName, "nonEmptyClassRangesNoDash"); }
		return retval;

	}
	// $ANTLR end "nonEmptyClassRangesNoDash"

	public class classAtom_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_classAtom();
	partial void Leave_classAtom();

	// $ANTLR start "classAtom"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:155:1: classAtom : ( '-' | classAtomNoDash );
	[GrammarRule("classAtom")]
	private JavaScriptRegExpParser.classAtom_return classAtom()
	{
		Enter_classAtom();
		EnterRule("classAtom", 28);
		TraceIn("classAtom", 28);
		JavaScriptRegExpParser.classAtom_return retval = new JavaScriptRegExpParser.classAtom_return();
		retval.Start = (IToken)input.LT(1);
		int classAtom_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal96=null;
		JavaScriptRegExpParser.classAtomNoDash_return classAtomNoDash97 = default(JavaScriptRegExpParser.classAtomNoDash_return);

		object char_literal96_tree=null;

		try { DebugEnterRule(GrammarFileName, "classAtom");
		DebugLocation(155, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 28)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:156:2: ( '-' | classAtomNoDash )
			int alt18=2;
			try { DebugEnterDecision(18, decisionCanBacktrack[18]);
			int LA18_0 = input.LA(1);

			if ((LA18_0==48))
			{
				alt18=1;
			}
			else if (((LA18_0>=4 && LA18_0<=23)||(LA18_0>=25 && LA18_0<=47)||LA18_0==49))
			{
				alt18=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 18, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(18); }
			switch (alt18)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:156:4: '-'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(156, 4);
				char_literal96=(IToken)Match(input,48,Follow._48_in_classAtom718); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal96_tree = (object)adaptor.Create(char_literal96);
				adaptor.AddChild(root_0, char_literal96_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:157:4: classAtomNoDash
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(157, 4);
				PushFollow(Follow._classAtomNoDash_in_classAtom723);
				classAtomNoDash97=classAtomNoDash();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classAtomNoDash97.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("classAtom", 28);
			LeaveRule("classAtom", 28);
			Leave_classAtom();
			if (state.backtracking > 0) { Memoize(input, 28, classAtom_StartIndex); }
		}
		DebugLocation(158, 1);
		} finally { DebugExitRule(GrammarFileName, "classAtom"); }
		return retval;

	}
	// $ANTLR end "classAtom"

	public class classAtomNoDash_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_classAtomNoDash();
	partial void Leave_classAtomNoDash();

	// $ANTLR start "classAtomNoDash"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:160:1: classAtomNoDash : (~ ( '\\\\' | ']' | '-' ) | '\\\\' classEscape );
	[GrammarRule("classAtomNoDash")]
	private JavaScriptRegExpParser.classAtomNoDash_return classAtomNoDash()
	{
		Enter_classAtomNoDash();
		EnterRule("classAtomNoDash", 29);
		TraceIn("classAtomNoDash", 29);
		JavaScriptRegExpParser.classAtomNoDash_return retval = new JavaScriptRegExpParser.classAtomNoDash_return();
		retval.Start = (IToken)input.LT(1);
		int classAtomNoDash_StartIndex = input.Index;
		object root_0 = null;

		IToken set98=null;
		IToken char_literal99=null;
		JavaScriptRegExpParser.classEscape_return classEscape100 = default(JavaScriptRegExpParser.classEscape_return);

		object set98_tree=null;
		object char_literal99_tree=null;

		try { DebugEnterRule(GrammarFileName, "classAtomNoDash");
		DebugLocation(160, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 29)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:161:2: (~ ( '\\\\' | ']' | '-' ) | '\\\\' classEscape )
			int alt19=2;
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if (((LA19_0>=4 && LA19_0<=19)||(LA19_0>=21 && LA19_0<=23)||(LA19_0>=25 && LA19_0<=47)||LA19_0==49))
			{
				alt19=1;
			}
			else if ((LA19_0==20))
			{
				alt19=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 19, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:161:4: ~ ( '\\\\' | ']' | '-' )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(161, 4);
				set98=(IToken)input.LT(1);
				if ((input.LA(1)>=4 && input.LA(1)<=19)||(input.LA(1)>=21 && input.LA(1)<=23)||(input.LA(1)>=25 && input.LA(1)<=47)||input.LA(1)==49)
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set98));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:162:4: '\\\\' classEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(162, 4);
				char_literal99=(IToken)Match(input,20,Follow._20_in_classAtomNoDash750); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal99_tree = (object)adaptor.Create(char_literal99);
				adaptor.AddChild(root_0, char_literal99_tree);
				}
				DebugLocation(162, 9);
				PushFollow(Follow._classEscape_in_classAtomNoDash752);
				classEscape100=classEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, classEscape100.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("classAtomNoDash", 29);
			LeaveRule("classAtomNoDash", 29);
			Leave_classAtomNoDash();
			if (state.backtracking > 0) { Memoize(input, 29, classAtomNoDash_StartIndex); }
		}
		DebugLocation(163, 1);
		} finally { DebugExitRule(GrammarFileName, "classAtomNoDash"); }
		return retval;

	}
	// $ANTLR end "classAtomNoDash"

	public class classEscape_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_classEscape();
	partial void Leave_classEscape();

	// $ANTLR start "classEscape"
	// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:165:1: classEscape : ( decimalEscape | 'b' | characterEscape | characterClassEscape );
	[GrammarRule("classEscape")]
	private JavaScriptRegExpParser.classEscape_return classEscape()
	{
		Enter_classEscape();
		EnterRule("classEscape", 30);
		TraceIn("classEscape", 30);
		JavaScriptRegExpParser.classEscape_return retval = new JavaScriptRegExpParser.classEscape_return();
		retval.Start = (IToken)input.LT(1);
		int classEscape_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal102=null;
		JavaScriptRegExpParser.decimalEscape_return decimalEscape101 = default(JavaScriptRegExpParser.decimalEscape_return);
		JavaScriptRegExpParser.characterEscape_return characterEscape103 = default(JavaScriptRegExpParser.characterEscape_return);
		JavaScriptRegExpParser.characterClassEscape_return characterClassEscape104 = default(JavaScriptRegExpParser.characterClassEscape_return);

		object char_literal102_tree=null;

		try { DebugEnterRule(GrammarFileName, "classEscape");
		DebugLocation(165, 1);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 30)) { return retval; }
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:166:2: ( decimalEscape | 'b' | characterEscape | characterClassEscape )
			int alt20=4;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			try
			{
				alt20 = dfa20.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:166:4: decimalEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(166, 4);
				PushFollow(Follow._decimalEscape_in_classEscape763);
				decimalEscape101=decimalEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, decimalEscape101.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:167:4: 'b'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(167, 4);
				char_literal102=(IToken)Match(input,49,Follow._49_in_classEscape768); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				char_literal102_tree = (object)adaptor.Create(char_literal102);
				adaptor.AddChild(root_0, char_literal102_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:168:4: characterEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(168, 4);
				PushFollow(Follow._characterEscape_in_classEscape773);
				characterEscape103=characterEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, characterEscape103.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:169:4: characterClassEscape
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(169, 4);
				PushFollow(Follow._characterClassEscape_in_classEscape778);
				characterClassEscape104=characterClassEscape();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, characterClassEscape104.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("classEscape", 30);
			LeaveRule("classEscape", 30);
			Leave_classEscape();
			if (state.backtracking > 0) { Memoize(input, 30, classEscape_StartIndex); }
		}
		DebugLocation(170, 1);
		} finally { DebugExitRule(GrammarFileName, "classEscape"); }
		return retval;

	}
	// $ANTLR end "classEscape"

	partial void Enter_synpred3_JavaScriptRegExp_fragment();
	partial void Leave_synpred3_JavaScriptRegExp_fragment();

	// $ANTLR start synpred3_JavaScriptRegExp
	public void synpred3_JavaScriptRegExp_fragment()
	{
		Enter_synpred3_JavaScriptRegExp_fragment();
		EnterRule("synpred3_JavaScriptRegExp_fragment", 33);
		TraceIn("synpred3_JavaScriptRegExp_fragment", 33);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:22:4: ( assertion )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:22:4: assertion
			{
			DebugLocation(22, 4);
			PushFollow(Follow._assertion_in_synpred3_JavaScriptRegExp90);
			assertion();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred3_JavaScriptRegExp_fragment", 33);
			LeaveRule("synpred3_JavaScriptRegExp_fragment", 33);
			Leave_synpred3_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred3_JavaScriptRegExp

	partial void Enter_synpred16_JavaScriptRegExp_fragment();
	partial void Leave_synpred16_JavaScriptRegExp_fragment();

	// $ANTLR start synpred16_JavaScriptRegExp
	public void synpred16_JavaScriptRegExp_fragment()
	{
		Enter_synpred16_JavaScriptRegExp_fragment();
		EnterRule("synpred16_JavaScriptRegExp_fragment", 46);
		TraceIn("synpred16_JavaScriptRegExp_fragment", 46);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:50:4: ( patternCharacter )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:50:4: patternCharacter
			{
			DebugLocation(50, 4);
			PushFollow(Follow._patternCharacter_in_synpred16_JavaScriptRegExp223);
			patternCharacter();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred16_JavaScriptRegExp_fragment", 46);
			LeaveRule("synpred16_JavaScriptRegExp_fragment", 46);
			Leave_synpred16_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred16_JavaScriptRegExp

	partial void Enter_synpred19_JavaScriptRegExp_fragment();
	partial void Leave_synpred19_JavaScriptRegExp_fragment();

	// $ANTLR start synpred19_JavaScriptRegExp
	public void synpred19_JavaScriptRegExp_fragment()
	{
		Enter_synpred19_JavaScriptRegExp_fragment();
		EnterRule("synpred19_JavaScriptRegExp_fragment", 49);
		TraceIn("synpred19_JavaScriptRegExp_fragment", 49);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:53:4: ( characterClass )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:53:4: characterClass
			{
			DebugLocation(53, 4);
			PushFollow(Follow._characterClass_in_synpred19_JavaScriptRegExp240);
			characterClass();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred19_JavaScriptRegExp_fragment", 49);
			LeaveRule("synpred19_JavaScriptRegExp_fragment", 49);
			Leave_synpred19_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred19_JavaScriptRegExp

	partial void Enter_synpred34_JavaScriptRegExp_fragment();
	partial void Leave_synpred34_JavaScriptRegExp_fragment();

	// $ANTLR start synpred34_JavaScriptRegExp
	public void synpred34_JavaScriptRegExp_fragment()
	{
		Enter_synpred34_JavaScriptRegExp_fragment();
		EnterRule("synpred34_JavaScriptRegExp_fragment", 64);
		TraceIn("synpred34_JavaScriptRegExp_fragment", 64);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:63:4: ( decimalEscape )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:63:4: decimalEscape
			{
			DebugLocation(63, 4);
			PushFollow(Follow._decimalEscape_in_synpred34_JavaScriptRegExp335);
			decimalEscape();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred34_JavaScriptRegExp_fragment", 64);
			LeaveRule("synpred34_JavaScriptRegExp_fragment", 64);
			Leave_synpred34_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred34_JavaScriptRegExp

	partial void Enter_synpred35_JavaScriptRegExp_fragment();
	partial void Leave_synpred35_JavaScriptRegExp_fragment();

	// $ANTLR start synpred35_JavaScriptRegExp
	public void synpred35_JavaScriptRegExp_fragment()
	{
		Enter_synpred35_JavaScriptRegExp_fragment();
		EnterRule("synpred35_JavaScriptRegExp_fragment", 65);
		TraceIn("synpred35_JavaScriptRegExp_fragment", 65);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:64:4: ( characterEscape )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:64:4: characterEscape
			{
			DebugLocation(64, 4);
			PushFollow(Follow._characterEscape_in_synpred35_JavaScriptRegExp340);
			characterEscape();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred35_JavaScriptRegExp_fragment", 65);
			LeaveRule("synpred35_JavaScriptRegExp_fragment", 65);
			Leave_synpred35_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred35_JavaScriptRegExp

	partial void Enter_synpred36_JavaScriptRegExp_fragment();
	partial void Leave_synpred36_JavaScriptRegExp_fragment();

	// $ANTLR start synpred36_JavaScriptRegExp
	public void synpred36_JavaScriptRegExp_fragment()
	{
		Enter_synpred36_JavaScriptRegExp_fragment();
		EnterRule("synpred36_JavaScriptRegExp_fragment", 66);
		TraceIn("synpred36_JavaScriptRegExp_fragment", 66);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:69:4: ( controlEscape )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:69:4: controlEscape
			{
			DebugLocation(69, 4);
			PushFollow(Follow._controlEscape_in_synpred36_JavaScriptRegExp356);
			controlEscape();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred36_JavaScriptRegExp_fragment", 66);
			LeaveRule("synpred36_JavaScriptRegExp_fragment", 66);
			Leave_synpred36_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred36_JavaScriptRegExp

	partial void Enter_synpred47_JavaScriptRegExp_fragment();
	partial void Leave_synpred47_JavaScriptRegExp_fragment();

	// $ANTLR start synpred47_JavaScriptRegExp
	public void synpred47_JavaScriptRegExp_fragment()
	{
		Enter_synpred47_JavaScriptRegExp_fragment();
		EnterRule("synpred47_JavaScriptRegExp_fragment", 77);
		TraceIn("synpred47_JavaScriptRegExp_fragment", 77);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:109:4: ( '0' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:109:4: '0'
			{
			DebugLocation(109, 4);
			Match(input,37,Follow._37_in_synpred47_JavaScriptRegExp525); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred47_JavaScriptRegExp_fragment", 77);
			LeaveRule("synpred47_JavaScriptRegExp_fragment", 77);
			Leave_synpred47_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred47_JavaScriptRegExp

	partial void Enter_synpred48_JavaScriptRegExp_fragment();
	partial void Leave_synpred48_JavaScriptRegExp_fragment();

	// $ANTLR start synpred48_JavaScriptRegExp
	public void synpred48_JavaScriptRegExp_fragment()
	{
		Enter_synpred48_JavaScriptRegExp_fragment();
		EnterRule("synpred48_JavaScriptRegExp_fragment", 78);
		TraceIn("synpred48_JavaScriptRegExp_fragment", 78);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:110:17: ( decimalDigits )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:110:17: decimalDigits
			{
			DebugLocation(110, 17);
			PushFollow(Follow._decimalDigits_in_synpred48_JavaScriptRegExp532);
			decimalDigits();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred48_JavaScriptRegExp_fragment", 78);
			LeaveRule("synpred48_JavaScriptRegExp_fragment", 78);
			Leave_synpred48_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred48_JavaScriptRegExp

	partial void Enter_synpred49_JavaScriptRegExp_fragment();
	partial void Leave_synpred49_JavaScriptRegExp_fragment();

	// $ANTLR start synpred49_JavaScriptRegExp
	public void synpred49_JavaScriptRegExp_fragment()
	{
		Enter_synpred49_JavaScriptRegExp_fragment();
		EnterRule("synpred49_JavaScriptRegExp_fragment", 79);
		TraceIn("synpred49_JavaScriptRegExp_fragment", 79);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:118:4: ( decimalDigit )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:118:4: decimalDigit
			{
			DebugLocation(118, 4);
			PushFollow(Follow._decimalDigit_in_synpred49_JavaScriptRegExp558);
			decimalDigit();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred49_JavaScriptRegExp_fragment", 79);
			LeaveRule("synpred49_JavaScriptRegExp_fragment", 79);
			Leave_synpred49_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred49_JavaScriptRegExp

	partial void Enter_synpred57_JavaScriptRegExp_fragment();
	partial void Leave_synpred57_JavaScriptRegExp_fragment();

	// $ANTLR start synpred57_JavaScriptRegExp
	public void synpred57_JavaScriptRegExp_fragment()
	{
		Enter_synpred57_JavaScriptRegExp_fragment();
		EnterRule("synpred57_JavaScriptRegExp_fragment", 87);
		TraceIn("synpred57_JavaScriptRegExp_fragment", 87);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:144:4: ( classAtom )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:144:4: classAtom
			{
			DebugLocation(144, 4);
			PushFollow(Follow._classAtom_in_synpred57_JavaScriptRegExp660);
			classAtom();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred57_JavaScriptRegExp_fragment", 87);
			LeaveRule("synpred57_JavaScriptRegExp_fragment", 87);
			Leave_synpred57_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred57_JavaScriptRegExp

	partial void Enter_synpred58_JavaScriptRegExp_fragment();
	partial void Leave_synpred58_JavaScriptRegExp_fragment();

	// $ANTLR start synpred58_JavaScriptRegExp
	public void synpred58_JavaScriptRegExp_fragment()
	{
		Enter_synpred58_JavaScriptRegExp_fragment();
		EnterRule("synpred58_JavaScriptRegExp_fragment", 88);
		TraceIn("synpred58_JavaScriptRegExp_fragment", 88);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:145:4: ( classAtom nonEmptyClassRangesNoDash )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:145:4: classAtom nonEmptyClassRangesNoDash
			{
			DebugLocation(145, 4);
			PushFollow(Follow._classAtom_in_synpred58_JavaScriptRegExp665);
			classAtom();
			PopFollow();
			if (state.failed) return;
			DebugLocation(145, 14);
			PushFollow(Follow._nonEmptyClassRangesNoDash_in_synpred58_JavaScriptRegExp667);
			nonEmptyClassRangesNoDash();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred58_JavaScriptRegExp_fragment", 88);
			LeaveRule("synpred58_JavaScriptRegExp_fragment", 88);
			Leave_synpred58_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred58_JavaScriptRegExp

	partial void Enter_synpred59_JavaScriptRegExp_fragment();
	partial void Leave_synpred59_JavaScriptRegExp_fragment();

	// $ANTLR start synpred59_JavaScriptRegExp
	public void synpred59_JavaScriptRegExp_fragment()
	{
		Enter_synpred59_JavaScriptRegExp_fragment();
		EnterRule("synpred59_JavaScriptRegExp_fragment", 89);
		TraceIn("synpred59_JavaScriptRegExp_fragment", 89);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:150:4: ( classAtom )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:150:4: classAtom
			{
			DebugLocation(150, 4);
			PushFollow(Follow._classAtom_in_synpred59_JavaScriptRegExp689);
			classAtom();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred59_JavaScriptRegExp_fragment", 89);
			LeaveRule("synpred59_JavaScriptRegExp_fragment", 89);
			Leave_synpred59_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred59_JavaScriptRegExp

	partial void Enter_synpred60_JavaScriptRegExp_fragment();
	partial void Leave_synpred60_JavaScriptRegExp_fragment();

	// $ANTLR start synpred60_JavaScriptRegExp
	public void synpred60_JavaScriptRegExp_fragment()
	{
		Enter_synpred60_JavaScriptRegExp_fragment();
		EnterRule("synpred60_JavaScriptRegExp_fragment", 90);
		TraceIn("synpred60_JavaScriptRegExp_fragment", 90);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:151:4: ( classAtomNoDash nonEmptyClassRangesNoDash )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:151:4: classAtomNoDash nonEmptyClassRangesNoDash
			{
			DebugLocation(151, 4);
			PushFollow(Follow._classAtomNoDash_in_synpred60_JavaScriptRegExp694);
			classAtomNoDash();
			PopFollow();
			if (state.failed) return;
			DebugLocation(151, 20);
			PushFollow(Follow._nonEmptyClassRangesNoDash_in_synpred60_JavaScriptRegExp696);
			nonEmptyClassRangesNoDash();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred60_JavaScriptRegExp_fragment", 90);
			LeaveRule("synpred60_JavaScriptRegExp_fragment", 90);
			Leave_synpred60_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred60_JavaScriptRegExp

	partial void Enter_synpred65_JavaScriptRegExp_fragment();
	partial void Leave_synpred65_JavaScriptRegExp_fragment();

	// $ANTLR start synpred65_JavaScriptRegExp
	public void synpred65_JavaScriptRegExp_fragment()
	{
		Enter_synpred65_JavaScriptRegExp_fragment();
		EnterRule("synpred65_JavaScriptRegExp_fragment", 95);
		TraceIn("synpred65_JavaScriptRegExp_fragment", 95);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:166:4: ( decimalEscape )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:166:4: decimalEscape
			{
			DebugLocation(166, 4);
			PushFollow(Follow._decimalEscape_in_synpred65_JavaScriptRegExp763);
			decimalEscape();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred65_JavaScriptRegExp_fragment", 95);
			LeaveRule("synpred65_JavaScriptRegExp_fragment", 95);
			Leave_synpred65_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred65_JavaScriptRegExp

	partial void Enter_synpred66_JavaScriptRegExp_fragment();
	partial void Leave_synpred66_JavaScriptRegExp_fragment();

	// $ANTLR start synpred66_JavaScriptRegExp
	public void synpred66_JavaScriptRegExp_fragment()
	{
		Enter_synpred66_JavaScriptRegExp_fragment();
		EnterRule("synpred66_JavaScriptRegExp_fragment", 96);
		TraceIn("synpred66_JavaScriptRegExp_fragment", 96);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:167:4: ( 'b' )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:167:4: 'b'
			{
			DebugLocation(167, 4);
			Match(input,49,Follow._49_in_synpred66_JavaScriptRegExp768); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred66_JavaScriptRegExp_fragment", 96);
			LeaveRule("synpred66_JavaScriptRegExp_fragment", 96);
			Leave_synpred66_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred66_JavaScriptRegExp

	partial void Enter_synpred67_JavaScriptRegExp_fragment();
	partial void Leave_synpred67_JavaScriptRegExp_fragment();

	// $ANTLR start synpred67_JavaScriptRegExp
	public void synpred67_JavaScriptRegExp_fragment()
	{
		Enter_synpred67_JavaScriptRegExp_fragment();
		EnterRule("synpred67_JavaScriptRegExp_fragment", 97);
		TraceIn("synpred67_JavaScriptRegExp_fragment", 97);
		try
		{
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:168:4: ( characterEscape )
			DebugEnterAlt(1);
			// C:\\Users\\otac0n\\Projects\\RegexLib\\RegexLib\\Parsers\\JavaScript\\JavaScriptRegExp.g:168:4: characterEscape
			{
			DebugLocation(168, 4);
			PushFollow(Follow._characterEscape_in_synpred67_JavaScriptRegExp773);
			characterEscape();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred67_JavaScriptRegExp_fragment", 97);
			LeaveRule("synpred67_JavaScriptRegExp_fragment", 97);
			Leave_synpred67_JavaScriptRegExp_fragment();
		}
	}
	// $ANTLR end synpred67_JavaScriptRegExp
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA6 dfa6;
	DFA9 dfa9;
	DFA11 dfa11;
	DFA13 dfa13;
	DFA16 dfa16;
	DFA17 dfa17;
	DFA20 dfa20;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa6 = new DFA6( this );
		dfa9 = new DFA9( this, SpecialStateTransition9 );
		dfa11 = new DFA11( this, SpecialStateTransition11 );
		dfa13 = new DFA13( this, SpecialStateTransition13 );
		dfa16 = new DFA16( this, SpecialStateTransition16 );
		dfa17 = new DFA17( this, SpecialStateTransition17 );
		dfa20 = new DFA20( this, SpecialStateTransition20 );
	}

	private class DFA6 : DFA
	{
		private const string DFA6_eotS =
			"\xB\xFFFF";
		private const string DFA6_eofS =
			"\x1\xFFFF\x3\x6\x3\xFFFF\x2\x6\x1\xFFFF\x1\x6";
		private const string DFA6_minS =
			"\x1\xC\x3\x4\x1\x10\x2\xFFFF\x2\x4\x1\x10\x1\x4";
		private const string DFA6_maxS =
			"\x1\xF\x3\x31\x1\x12\x2\xFFFF\x2\x31\x1\x10\x1\x31";
		private const string DFA6_acceptS =
			"\x5\xFFFF\x1\x1\x1\x2\x4\xFFFF";
		private const string DFA6_specialS =
			"\xB\xFFFF}>";
		private static readonly string[] DFA6_transitionS =
			{
				"\x1\x3\x1\x1\x1\x2\x1\x4",
				"\x8\x6\x1\x5\x4\xFFFF\x7\x6\x1\xFFFF\x19\x6",
				"\x8\x6\x1\x5\x4\xFFFF\x7\x6\x1\xFFFF\x19\x6",
				"\x8\x6\x1\x5\x4\xFFFF\x7\x6\x1\xFFFF\x19\x6",
				"\x1\x7\x1\x8\x1\x9",
				"",
				"",
				"\x8\x6\x1\x5\x4\xFFFF\x7\x6\x1\xFFFF\x19\x6",
				"\x8\x6\x1\x5\x4\xFFFF\x7\x6\x1\xFFFF\x19\x6",
				"\x1\xA",
				"\x8\x6\x1\x5\x4\xFFFF\x7\x6\x1\xFFFF\x19\x6"
			};

		private static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
		private static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
		private static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
		private static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
		private static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
		private static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
		private static readonly short[][] DFA6_transition;

		static DFA6()
		{
			int numStates = DFA6_transitionS.Length;
			DFA6_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA6_transition[i] = DFA.UnpackEncodedString(DFA6_transitionS[i]);
			}
		}

		public DFA6( BaseRecognizer recognizer )
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

		public override string Description { get { return "35:1: quantifier : ( quantifierPrefix '?' | quantifierPrefix );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private class DFA9 : DFA
	{
		private const string DFA9_eotS =
			"\x1E\xFFFF";
		private const string DFA9_eofS =
			"\x1\x7\x1D\xFFFF";
		private const string DFA9_minS =
			"\x1\x4\x1A\x0\x3\xFFFF";
		private const string DFA9_maxS =
			"\x1\x31\x1A\x0\x3\xFFFF";
		private const string DFA9_acceptS =
			"\x1B\xFFFF\x1\x1\x1\x2\x1\x3";
		private const string DFA9_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x1\x10\x1\x11\x1\x12\x1\x13\x1\x14"+
			"\x1\x15\x1\x16\x1\x17\x1\x18\x1\x19\x3\xFFFF}>";
		private static readonly string[] DFA9_transitionS =
			{
				"\x1\x6\x1\x9\x1\xA\x1\xB\x1\xC\x1\xD\x1\x8\x1\xE\x1\x4\x1\x2\x1\x3"+
				"\x1\x5\x1\xFFFF\x2\x1A\x1\x10\x1\x11\x1\x14\x1\x13\x1\x12\x1\xFFFF\x1"+
				"\x16\x5\x15\x4\x1A\x1\x17\x1\x18\x1\x1\x3\x1A\x6\x19\x1\xF\x2\x1A",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				"",
				""
			};

		private static readonly short[] DFA9_eot = DFA.UnpackEncodedString(DFA9_eotS);
		private static readonly short[] DFA9_eof = DFA.UnpackEncodedString(DFA9_eofS);
		private static readonly char[] DFA9_min = DFA.UnpackEncodedStringToUnsignedChars(DFA9_minS);
		private static readonly char[] DFA9_max = DFA.UnpackEncodedStringToUnsignedChars(DFA9_maxS);
		private static readonly short[] DFA9_accept = DFA.UnpackEncodedString(DFA9_acceptS);
		private static readonly short[] DFA9_special = DFA.UnpackEncodedString(DFA9_specialS);
		private static readonly short[][] DFA9_transition;

		static DFA9()
		{
			int numStates = DFA9_transitionS.Length;
			DFA9_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA9_transition[i] = DFA.UnpackEncodedString(DFA9_transitionS[i]);
			}
		}

		public DFA9( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 9;
			this.eot = DFA9_eot;
			this.eof = DFA9_eof;
			this.min = DFA9_min;
			this.max = DFA9_max;
			this.accept = DFA9_accept;
			this.special = DFA9_special;
			this.transition = DFA9_transition;
		}

		public override string Description { get { return "62:1: atomEscape : ( decimalEscape | characterEscape | characterClassEscape );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition9(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA9_1 = input.LA(1);


				int index9_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA9_2 = input.LA(1);


				int index9_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA9_3 = input.LA(1);


				int index9_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA9_4 = input.LA(1);


				int index9_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA9_5 = input.LA(1);


				int index9_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA9_6 = input.LA(1);


				int index9_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA9_7 = input.LA(1);


				int index9_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA9_8 = input.LA(1);


				int index9_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA9_9 = input.LA(1);


				int index9_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA9_10 = input.LA(1);


				int index9_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA9_11 = input.LA(1);


				int index9_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA9_12 = input.LA(1);


				int index9_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_12);
				if ( s>=0 ) return s;
				break;
			case 12:
				int LA9_13 = input.LA(1);


				int index9_13 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_13);
				if ( s>=0 ) return s;
				break;
			case 13:
				int LA9_14 = input.LA(1);


				int index9_14 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_14);
				if ( s>=0 ) return s;
				break;
			case 14:
				int LA9_15 = input.LA(1);


				int index9_15 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_15);
				if ( s>=0 ) return s;
				break;
			case 15:
				int LA9_16 = input.LA(1);


				int index9_16 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_16);
				if ( s>=0 ) return s;
				break;
			case 16:
				int LA9_17 = input.LA(1);


				int index9_17 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_17);
				if ( s>=0 ) return s;
				break;
			case 17:
				int LA9_18 = input.LA(1);


				int index9_18 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_18);
				if ( s>=0 ) return s;
				break;
			case 18:
				int LA9_19 = input.LA(1);


				int index9_19 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_19);
				if ( s>=0 ) return s;
				break;
			case 19:
				int LA9_20 = input.LA(1);


				int index9_20 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_20);
				if ( s>=0 ) return s;
				break;
			case 20:
				int LA9_21 = input.LA(1);


				int index9_21 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_21);
				if ( s>=0 ) return s;
				break;
			case 21:
				int LA9_22 = input.LA(1);


				int index9_22 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_22);
				if ( s>=0 ) return s;
				break;
			case 22:
				int LA9_23 = input.LA(1);


				int index9_23 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_23);
				if ( s>=0 ) return s;
				break;
			case 23:
				int LA9_24 = input.LA(1);


				int index9_24 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_24);
				if ( s>=0 ) return s;
				break;
			case 24:
				int LA9_25 = input.LA(1);


				int index9_25 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}

				else if ( (true) ) {s = 29;}


				input.Seek(index9_25);
				if ( s>=0 ) return s;
				break;
			case 25:
				int LA9_26 = input.LA(1);


				int index9_26 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred34_JavaScriptRegExp_fragment)) ) {s = 27;}

				else if ( (EvaluatePredicate(synpred35_JavaScriptRegExp_fragment)) ) {s = 28;}


				input.Seek(index9_26);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 9, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA11 : DFA
	{
		private const string DFA11_eotS =
			"\x1A\xFFFF";
		private const string DFA11_eofS =
			"\x1\x6\x19\xFFFF";
		private const string DFA11_minS =
			"\x1\x4\x17\x0\x2\xFFFF";
		private const string DFA11_maxS =
			"\x1\x31\x17\x0\x2\xFFFF";
		private const string DFA11_acceptS =
			"\x18\xFFFF\x1\x1\x1\x2";
		private const string DFA11_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x1\x10\x1\x11\x1\x12\x1\x13\x1\x14"+
			"\x1\x15\x1\x16\x2\xFFFF}>";
		private static readonly string[] DFA11_transitionS =
			{
				"\x1\x5\x1\x8\x1\x9\x1\xA\x1\xB\x1\xC\x1\x7\x1\xD\x1\x3\x1\x1\x1\x2"+
				"\x1\x4\x1\x16\x2\x15\x1\xF\x1\x10\x1\x13\x1\x12\x1\x11\x1\x17\x16\x15"+
				"\x1\xE\x1\x14\x1\x15",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				""
			};

		private static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
		private static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
		private static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
		private static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
		private static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
		private static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
		private static readonly short[][] DFA11_transition;

		static DFA11()
		{
			int numStates = DFA11_transitionS.Length;
			DFA11_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA11_transition[i] = DFA.UnpackEncodedString(DFA11_transitionS[i]);
			}
		}

		public DFA11( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 11;
			this.eot = DFA11_eot;
			this.eof = DFA11_eof;
			this.min = DFA11_min;
			this.max = DFA11_max;
			this.accept = DFA11_accept;
			this.special = DFA11_special;
			this.transition = DFA11_transition;
		}

		public override string Description { get { return "110:17: ( decimalDigits )?"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition11(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA11_1 = input.LA(1);


				int index11_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA11_2 = input.LA(1);


				int index11_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA11_3 = input.LA(1);


				int index11_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA11_4 = input.LA(1);


				int index11_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA11_5 = input.LA(1);


				int index11_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA11_6 = input.LA(1);


				int index11_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA11_7 = input.LA(1);


				int index11_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA11_8 = input.LA(1);


				int index11_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA11_9 = input.LA(1);


				int index11_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA11_10 = input.LA(1);


				int index11_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA11_11 = input.LA(1);


				int index11_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA11_12 = input.LA(1);


				int index11_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_12);
				if ( s>=0 ) return s;
				break;
			case 12:
				int LA11_13 = input.LA(1);


				int index11_13 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_13);
				if ( s>=0 ) return s;
				break;
			case 13:
				int LA11_14 = input.LA(1);


				int index11_14 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_14);
				if ( s>=0 ) return s;
				break;
			case 14:
				int LA11_15 = input.LA(1);


				int index11_15 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_15);
				if ( s>=0 ) return s;
				break;
			case 15:
				int LA11_16 = input.LA(1);


				int index11_16 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_16);
				if ( s>=0 ) return s;
				break;
			case 16:
				int LA11_17 = input.LA(1);


				int index11_17 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_17);
				if ( s>=0 ) return s;
				break;
			case 17:
				int LA11_18 = input.LA(1);


				int index11_18 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_18);
				if ( s>=0 ) return s;
				break;
			case 18:
				int LA11_19 = input.LA(1);


				int index11_19 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_19);
				if ( s>=0 ) return s;
				break;
			case 19:
				int LA11_20 = input.LA(1);


				int index11_20 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_20);
				if ( s>=0 ) return s;
				break;
			case 20:
				int LA11_21 = input.LA(1);


				int index11_21 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_21);
				if ( s>=0 ) return s;
				break;
			case 21:
				int LA11_22 = input.LA(1);


				int index11_22 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_22);
				if ( s>=0 ) return s;
				break;
			case 22:
				int LA11_23 = input.LA(1);


				int index11_23 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred48_JavaScriptRegExp_fragment)) ) {s = 24;}

				else if ( (true) ) {s = 25;}


				input.Seek(index11_23);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 11, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA13 : DFA
	{
		private const string DFA13_eotS =
			"\x1C\xFFFF";
		private const string DFA13_eofS =
			"\x1\x9\x1B\xFFFF";
		private const string DFA13_minS =
			"\x1\x4\x19\x0\x2\xFFFF";
		private const string DFA13_maxS =
			"\x1\x31\x19\x0\x2\xFFFF";
		private const string DFA13_acceptS =
			"\x1A\xFFFF\x1\x1\x1\x2";
		private const string DFA13_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x1\x10\x1\x11\x1\x12\x1\x13\x1\x14"+
			"\x1\x15\x1\x16\x1\x17\x1\x18\x2\xFFFF}>";
		private static readonly string[] DFA13_transitionS =
			{
				"\x1\x8\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x1\xA\x1\x10\x1\x6\x1\x4\x1\x5"+
				"\x1\x7\x1\x1\x1\x2\x1\x3\x1\x12\x1\x13\x1\x16\x1\x15\x1\x14\x1\x19\x16"+
				"\x18\x1\x11\x1\x17\x1\x18",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				""
			};

		private static readonly short[] DFA13_eot = DFA.UnpackEncodedString(DFA13_eotS);
		private static readonly short[] DFA13_eof = DFA.UnpackEncodedString(DFA13_eofS);
		private static readonly char[] DFA13_min = DFA.UnpackEncodedStringToUnsignedChars(DFA13_minS);
		private static readonly char[] DFA13_max = DFA.UnpackEncodedStringToUnsignedChars(DFA13_maxS);
		private static readonly short[] DFA13_accept = DFA.UnpackEncodedString(DFA13_acceptS);
		private static readonly short[] DFA13_special = DFA.UnpackEncodedString(DFA13_specialS);
		private static readonly short[][] DFA13_transition;

		static DFA13()
		{
			int numStates = DFA13_transitionS.Length;
			DFA13_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA13_transition[i] = DFA.UnpackEncodedString(DFA13_transitionS[i]);
			}
		}

		public DFA13( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 13;
			this.eot = DFA13_eot;
			this.eof = DFA13_eof;
			this.min = DFA13_min;
			this.max = DFA13_max;
			this.accept = DFA13_accept;
			this.special = DFA13_special;
			this.transition = DFA13_transition;
		}

		public override string Description { get { return "()+ loopback of 118:4: ( decimalDigit )+"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition13(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA13_1 = input.LA(1);


				int index13_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA13_2 = input.LA(1);


				int index13_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA13_3 = input.LA(1);


				int index13_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA13_4 = input.LA(1);


				int index13_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA13_5 = input.LA(1);


				int index13_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA13_6 = input.LA(1);


				int index13_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA13_7 = input.LA(1);


				int index13_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA13_8 = input.LA(1);


				int index13_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA13_9 = input.LA(1);


				int index13_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA13_10 = input.LA(1);


				int index13_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA13_11 = input.LA(1);


				int index13_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA13_12 = input.LA(1);


				int index13_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_12);
				if ( s>=0 ) return s;
				break;
			case 12:
				int LA13_13 = input.LA(1);


				int index13_13 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_13);
				if ( s>=0 ) return s;
				break;
			case 13:
				int LA13_14 = input.LA(1);


				int index13_14 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_14);
				if ( s>=0 ) return s;
				break;
			case 14:
				int LA13_15 = input.LA(1);


				int index13_15 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_15);
				if ( s>=0 ) return s;
				break;
			case 15:
				int LA13_16 = input.LA(1);


				int index13_16 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_16);
				if ( s>=0 ) return s;
				break;
			case 16:
				int LA13_17 = input.LA(1);


				int index13_17 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_17);
				if ( s>=0 ) return s;
				break;
			case 17:
				int LA13_18 = input.LA(1);


				int index13_18 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_18);
				if ( s>=0 ) return s;
				break;
			case 18:
				int LA13_19 = input.LA(1);


				int index13_19 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_19);
				if ( s>=0 ) return s;
				break;
			case 19:
				int LA13_20 = input.LA(1);


				int index13_20 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_20);
				if ( s>=0 ) return s;
				break;
			case 20:
				int LA13_21 = input.LA(1);


				int index13_21 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_21);
				if ( s>=0 ) return s;
				break;
			case 21:
				int LA13_22 = input.LA(1);


				int index13_22 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_22);
				if ( s>=0 ) return s;
				break;
			case 22:
				int LA13_23 = input.LA(1);


				int index13_23 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_23);
				if ( s>=0 ) return s;
				break;
			case 23:
				int LA13_24 = input.LA(1);


				int index13_24 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_24);
				if ( s>=0 ) return s;
				break;
			case 24:
				int LA13_25 = input.LA(1);


				int index13_25 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_JavaScriptRegExp_fragment)) ) {s = 26;}

				else if ( (true) ) {s = 27;}


				input.Seek(index13_25);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 13, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA16 : DFA
	{
		private const string DFA16_eotS =
			"\xF\xFFFF";
		private const string DFA16_eofS =
			"\x1\xFFFF\x3\x4\x1\xFFFF\x1\x6\x4\xFFFF\x3\x6\x2\xFFFF";
		private const string DFA16_minS =
			"\x4\x4\x1\xFFFF\x1\x4\x1\xFFFF\x3\x30\x3\x4\x1\x30\x1\xFFFF";
		private const string DFA16_maxS =
			"\x4\x31\x1\xFFFF\x1\x31\x1\xFFFF\x3\x30\x3\x31\x1\x30\x1\xFFFF";
		private const string DFA16_acceptS =
			"\x4\xFFFF\x1\x1\x1\xFFFF\x1\x2\x7\xFFFF\x1\x3";
		private const string DFA16_specialS =
			"\x7\xFFFF\x1\x1\x1\x3\x1\x2\x3\xFFFF\x1\x0\x1\xFFFF}>";
		private static readonly string[] DFA16_transitionS =
			{
				"\x10\x2\x1\x3\x3\x2\x1\xFFFF\x17\x2\x1\x1\x1\x2",
				"\x14\x6\x1\x4\x17\x6\x1\x5\x1\x6",
				"\x14\x6\x1\x4\x17\x6\x1\x5\x1\x6",
				"\x14\x6\x1\x4\x1\xA\x5\x9\x4\x6\x1\xB\x1\xC\x1\x7\x3\x6\x6\xD\x1\x6"+
				"\x1\x5\x1\x8",
				"",
				"\x14\xE\x1\x6\x19\xE",
				"",
				"\x1\xE",
				"\x1\xE",
				"\x1\xE",
				"\x2E\x6",
				"\x2E\x6",
				"\x2E\x6",
				"\x1\xE",
				""
			};

		private static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
		private static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
		private static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
		private static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
		private static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
		private static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
		private static readonly short[][] DFA16_transition;

		static DFA16()
		{
			int numStates = DFA16_transitionS.Length;
			DFA16_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA16_transition[i] = DFA.UnpackEncodedString(DFA16_transitionS[i]);
			}
		}

		public DFA16( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 16;
			this.eot = DFA16_eot;
			this.eof = DFA16_eof;
			this.min = DFA16_min;
			this.max = DFA16_max;
			this.accept = DFA16_accept;
			this.special = DFA16_special;
			this.transition = DFA16_transition;
		}

		public override string Description { get { return "143:1: nonEmptyClassRanges : ( classAtom | classAtom nonEmptyClassRangesNoDash | classAtom '-' classAtom classRanges );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition16(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA16_13 = input.LA(1);


				int index16_13 = input.Index;
				input.Rewind();
				s = -1;
				if ( (LA16_13==48) ) {s = 14;}

				else if ( (EvaluatePredicate(synpred57_JavaScriptRegExp_fragment)) ) {s = 4;}

				else if ( (EvaluatePredicate(synpred58_JavaScriptRegExp_fragment)) ) {s = 6;}


				input.Seek(index16_13);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA16_7 = input.LA(1);


				int index16_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (LA16_7==48) ) {s = 14;}

				else if ( (EvaluatePredicate(synpred57_JavaScriptRegExp_fragment)) ) {s = 4;}

				else if ( (EvaluatePredicate(synpred58_JavaScriptRegExp_fragment)) ) {s = 6;}


				input.Seek(index16_7);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA16_9 = input.LA(1);


				int index16_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (LA16_9==48) ) {s = 14;}

				else if ( (EvaluatePredicate(synpred57_JavaScriptRegExp_fragment)) ) {s = 4;}

				else if ( (EvaluatePredicate(synpred58_JavaScriptRegExp_fragment)) ) {s = 6;}


				input.Seek(index16_9);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA16_8 = input.LA(1);


				int index16_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (LA16_8==48) ) {s = 14;}

				else if ( (EvaluatePredicate(synpred57_JavaScriptRegExp_fragment)) ) {s = 4;}

				else if ( (EvaluatePredicate(synpred58_JavaScriptRegExp_fragment)) ) {s = 6;}


				input.Seek(index16_8);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 16, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA17 : DFA
	{
		private const string DFA17_eotS =
			"\xE\xFFFF";
		private const string DFA17_eofS =
			"\x2\xFFFF\x2\x1\x1\x5\x4\xFFFF\x3\x5\x2\xFFFF";
		private const string DFA17_minS =
			"\x1\x4\x1\xFFFF\x3\x4\x1\xFFFF\x3\x0\x3\x4\x1\x0\x1\xFFFF";
		private const string DFA17_maxS =
			"\x1\x31\x1\xFFFF\x3\x31\x1\xFFFF\x3\x0\x3\x31\x1\x0\x1\xFFFF";
		private const string DFA17_acceptS =
			"\x1\xFFFF\x1\x1\x3\xFFFF\x1\x2\x7\xFFFF\x1\x3";
		private const string DFA17_specialS =
			"\x6\xFFFF\x1\x0\x1\x3\x1\x2\x3\xFFFF\x1\x1\x1\xFFFF}>";
		private static readonly string[] DFA17_transitionS =
			{
				"\x10\x2\x1\x3\x3\x2\x1\xFFFF\x17\x2\x1\x1\x1\x2",
				"",
				"\x14\x5\x1\x1\x17\x5\x1\x4\x1\x5",
				"\x14\x5\x1\x1\x1\x9\x5\x8\x4\x5\x1\xA\x1\xB\x1\x6\x3\x5\x6\xC\x1\x5"+
				"\x1\x4\x1\x7",
				"\x14\xD\x1\x5\x19\xD",
				"",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x2E\x5",
				"\x2E\x5",
				"\x2E\x5",
				"\x1\xFFFF",
				""
			};

		private static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
		private static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
		private static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
		private static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
		private static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
		private static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
		private static readonly short[][] DFA17_transition;

		static DFA17()
		{
			int numStates = DFA17_transitionS.Length;
			DFA17_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA17_transition[i] = DFA.UnpackEncodedString(DFA17_transitionS[i]);
			}
		}

		public DFA17( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 17;
			this.eot = DFA17_eot;
			this.eof = DFA17_eof;
			this.min = DFA17_min;
			this.max = DFA17_max;
			this.accept = DFA17_accept;
			this.special = DFA17_special;
			this.transition = DFA17_transition;
		}

		public override string Description { get { return "149:1: nonEmptyClassRangesNoDash : ( classAtom | classAtomNoDash nonEmptyClassRangesNoDash | classAtomNoDash '-' classAtom classRanges );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition17(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA17_6 = input.LA(1);


				int index17_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred59_JavaScriptRegExp_fragment)) ) {s = 1;}

				else if ( (EvaluatePredicate(synpred60_JavaScriptRegExp_fragment)) ) {s = 5;}

				else if ( (true) ) {s = 13;}


				input.Seek(index17_6);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA17_12 = input.LA(1);


				int index17_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred59_JavaScriptRegExp_fragment)) ) {s = 1;}

				else if ( (EvaluatePredicate(synpred60_JavaScriptRegExp_fragment)) ) {s = 5;}

				else if ( (true) ) {s = 13;}


				input.Seek(index17_12);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA17_8 = input.LA(1);


				int index17_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred59_JavaScriptRegExp_fragment)) ) {s = 1;}

				else if ( (EvaluatePredicate(synpred60_JavaScriptRegExp_fragment)) ) {s = 5;}

				else if ( (true) ) {s = 13;}


				input.Seek(index17_8);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA17_7 = input.LA(1);


				int index17_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred59_JavaScriptRegExp_fragment)) ) {s = 1;}

				else if ( (EvaluatePredicate(synpred60_JavaScriptRegExp_fragment)) ) {s = 5;}

				else if ( (true) ) {s = 13;}


				input.Seek(index17_7);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 17, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
	private class DFA20 : DFA
	{
		private const string DFA20_eotS =
			"\x11\xFFFF";
		private const string DFA20_eofS =
			"\x1\x6\x10\xFFFF";
		private const string DFA20_minS =
			"\x1\x4\xC\x0\x4\xFFFF";
		private const string DFA20_maxS =
			"\x1\x31\xC\x0\x4\xFFFF";
		private const string DFA20_acceptS =
			"\xD\xFFFF\x1\x1\x1\x3\x1\x2\x1\x4";
		private const string DFA20_specialS =
			"\x1\xFFFF\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
			"\x1\xA\x1\xB\x4\xFFFF}>";
		private static readonly string[] DFA20_transitionS =
			{
				"\x10\xC\x1\x4\x3\xC\x1\x5\x1\x8\x5\x7\x4\xC\x1\x9\x1\xA\x1\x1\x3\xC"+
				"\x6\xB\x1\xC\x1\x2\x1\x3",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA20_eot = DFA.UnpackEncodedString(DFA20_eotS);
		private static readonly short[] DFA20_eof = DFA.UnpackEncodedString(DFA20_eofS);
		private static readonly char[] DFA20_min = DFA.UnpackEncodedStringToUnsignedChars(DFA20_minS);
		private static readonly char[] DFA20_max = DFA.UnpackEncodedStringToUnsignedChars(DFA20_maxS);
		private static readonly short[] DFA20_accept = DFA.UnpackEncodedString(DFA20_acceptS);
		private static readonly short[] DFA20_special = DFA.UnpackEncodedString(DFA20_specialS);
		private static readonly short[][] DFA20_transition;

		static DFA20()
		{
			int numStates = DFA20_transitionS.Length;
			DFA20_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA20_transition[i] = DFA.UnpackEncodedString(DFA20_transitionS[i]);
			}
		}

		public DFA20( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 20;
			this.eot = DFA20_eot;
			this.eof = DFA20_eof;
			this.min = DFA20_min;
			this.max = DFA20_max;
			this.accept = DFA20_accept;
			this.special = DFA20_special;
			this.transition = DFA20_transition;
		}

		public override string Description { get { return "165:1: classEscape : ( decimalEscape | 'b' | characterEscape | characterClassEscape );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition20(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA20_1 = input.LA(1);


				int index20_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA20_2 = input.LA(1);


				int index20_2 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_2);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA20_3 = input.LA(1);


				int index20_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred66_JavaScriptRegExp_fragment)) ) {s = 15;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_3);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA20_4 = input.LA(1);


				int index20_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_4);
				if ( s>=0 ) return s;
				break;
			case 4:
				int LA20_5 = input.LA(1);


				int index20_5 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_5);
				if ( s>=0 ) return s;
				break;
			case 5:
				int LA20_6 = input.LA(1);


				int index20_6 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_6);
				if ( s>=0 ) return s;
				break;
			case 6:
				int LA20_7 = input.LA(1);


				int index20_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_7);
				if ( s>=0 ) return s;
				break;
			case 7:
				int LA20_8 = input.LA(1);


				int index20_8 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_8);
				if ( s>=0 ) return s;
				break;
			case 8:
				int LA20_9 = input.LA(1);


				int index20_9 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_9);
				if ( s>=0 ) return s;
				break;
			case 9:
				int LA20_10 = input.LA(1);


				int index20_10 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_10);
				if ( s>=0 ) return s;
				break;
			case 10:
				int LA20_11 = input.LA(1);


				int index20_11 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}

				else if ( (true) ) {s = 16;}


				input.Seek(index20_11);
				if ( s>=0 ) return s;
				break;
			case 11:
				int LA20_12 = input.LA(1);


				int index20_12 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred65_JavaScriptRegExp_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred67_JavaScriptRegExp_fragment)) ) {s = 14;}


				input.Seek(index20_12);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 20, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _disjunction_in_pattern47 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_pattern49 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _alternative_in_disjunction60 = new BitSet(new ulong[]{0x12UL});
		public static readonly BitSet _4_in_disjunction63 = new BitSet(new ulong[]{0x3FFFFFEFE0BF0UL});
		public static readonly BitSet _disjunction_in_disjunction65 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _term_in_alternative78 = new BitSet(new ulong[]{0x3FFFFFEFE0BE2UL});
		public static readonly BitSet _assertion_in_term90 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _atom_in_term95 = new BitSet(new ulong[]{0xF002UL});
		public static readonly BitSet _quantifier_in_term97 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _5_in_assertion109 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _6_in_assertion114 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _7_in_assertion119 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _8_in_assertion124 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _9_in_assertion129 = new BitSet(new ulong[]{0x3FFFFFEFE0BF0UL});
		public static readonly BitSet _disjunction_in_assertion131 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _10_in_assertion133 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _11_in_assertion138 = new BitSet(new ulong[]{0x3FFFFFEFE0BF0UL});
		public static readonly BitSet _disjunction_in_assertion140 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _10_in_assertion142 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _quantifierPrefix_in_quantifier153 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _12_in_quantifier155 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _quantifierPrefix_in_quantifier160 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _13_in_quantifierPrefix171 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _14_in_quantifierPrefix176 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _12_in_quantifierPrefix181 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _15_in_quantifierPrefix186 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _decimalDigits_in_quantifierPrefix188 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _16_in_quantifierPrefix190 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _15_in_quantifierPrefix195 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _decimalDigits_in_quantifierPrefix197 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _17_in_quantifierPrefix199 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _15_in_quantifierPrefix204 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _decimalDigits_in_quantifierPrefix206 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _18_in_quantifierPrefix208 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _decimalDigits_in_quantifierPrefix210 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _16_in_quantifierPrefix212 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _patternCharacter_in_atom223 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _19_in_atom228 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _20_in_atom233 = new BitSet(new ulong[]{0x7E387E000000UL});
		public static readonly BitSet _atomEscape_in_atom235 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _characterClass_in_atom240 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _21_in_atom245 = new BitSet(new ulong[]{0x3FFFFFEFE0BF0UL});
		public static readonly BitSet _disjunction_in_atom247 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _10_in_atom249 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _22_in_atom254 = new BitSet(new ulong[]{0x3FFFFFEFE0BF0UL});
		public static readonly BitSet _disjunction_in_atom256 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _10_in_atom258 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_patternCharacter269 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalEscape_in_atomEscape335 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _characterEscape_in_atomEscape340 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _characterClassEscape_in_atomEscape345 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _controlEscape_in_characterEscape356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _25_in_characterEscape361 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _controlLetter_in_characterEscape363 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _hexEscapeSequence_in_characterEscape368 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _unicodeEscapeSequence_in_characterEscape373 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _identityEscape_in_characterEscape378 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_controlEscape0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_controlLetter420 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _35_in_hexEscapeSequence440 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _hexDigit_in_hexEscapeSequence442 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _hexDigit_in_hexEscapeSequence444 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _36_in_unicodeEscapeSequence455 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _hexDigit_in_unicodeEscapeSequence457 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _hexDigit_in_unicodeEscapeSequence459 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _hexDigit_in_unicodeEscapeSequence461 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _hexDigit_in_unicodeEscapeSequence463 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_hexDigit474 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalIntegerLiteral_in_decimalEscape512 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _37_in_decimalIntegerLiteral525 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nonZeroDigit_in_decimalIntegerLiteral530 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalDigits_in_decimalIntegerLiteral532 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalDigit_in_decimalDigits558 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_characterClassEscape0 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _23_in_characterClass619 = new BitSet(new ulong[]{0x3FFFFFFFFFFD0UL});
		public static readonly BitSet _set_in_characterClass623 = new BitSet(new ulong[]{0x3FFFFFFFFFFF0UL});
		public static readonly BitSet _classRanges_in_characterClass626 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _24_in_characterClass628 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _47_in_characterClass633 = new BitSet(new ulong[]{0x3FFFFFFFFFFF0UL});
		public static readonly BitSet _classRanges_in_characterClass635 = new BitSet(new ulong[]{0x1000000UL});
		public static readonly BitSet _24_in_characterClass637 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nonEmptyClassRanges_in_classRanges648 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtom_in_nonEmptyClassRanges660 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtom_in_nonEmptyClassRanges665 = new BitSet(new ulong[]{0x3FFFFFEFFFFF0UL});
		public static readonly BitSet _nonEmptyClassRangesNoDash_in_nonEmptyClassRanges667 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtom_in_nonEmptyClassRanges672 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_nonEmptyClassRanges674 = new BitSet(new ulong[]{0x3FFFFFEFFFFF0UL});
		public static readonly BitSet _classAtom_in_nonEmptyClassRanges676 = new BitSet(new ulong[]{0x3FFFFFEFFFFF0UL});
		public static readonly BitSet _classRanges_in_nonEmptyClassRanges678 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtom_in_nonEmptyClassRangesNoDash689 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtomNoDash_in_nonEmptyClassRangesNoDash694 = new BitSet(new ulong[]{0x3FFFFFEFFFFF0UL});
		public static readonly BitSet _nonEmptyClassRangesNoDash_in_nonEmptyClassRangesNoDash696 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtomNoDash_in_nonEmptyClassRangesNoDash701 = new BitSet(new ulong[]{0x1000000000000UL});
		public static readonly BitSet _48_in_nonEmptyClassRangesNoDash703 = new BitSet(new ulong[]{0x3FFFFFEFFFFF0UL});
		public static readonly BitSet _classAtom_in_nonEmptyClassRangesNoDash705 = new BitSet(new ulong[]{0x3FFFFFEFFFFF0UL});
		public static readonly BitSet _classRanges_in_nonEmptyClassRangesNoDash707 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _48_in_classAtom718 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtomNoDash_in_classAtom723 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_classAtomNoDash734 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _20_in_classAtomNoDash750 = new BitSet(new ulong[]{0x27E387E000000UL});
		public static readonly BitSet _classEscape_in_classAtomNoDash752 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalEscape_in_classEscape763 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _49_in_classEscape768 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _characterEscape_in_classEscape773 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _characterClassEscape_in_classEscape778 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assertion_in_synpred3_JavaScriptRegExp90 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _patternCharacter_in_synpred16_JavaScriptRegExp223 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _characterClass_in_synpred19_JavaScriptRegExp240 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalEscape_in_synpred34_JavaScriptRegExp335 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _characterEscape_in_synpred35_JavaScriptRegExp340 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _controlEscape_in_synpred36_JavaScriptRegExp356 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _37_in_synpred47_JavaScriptRegExp525 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalDigits_in_synpred48_JavaScriptRegExp532 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalDigit_in_synpred49_JavaScriptRegExp558 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtom_in_synpred57_JavaScriptRegExp660 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtom_in_synpred58_JavaScriptRegExp665 = new BitSet(new ulong[]{0x3FFFFFEFFFFF0UL});
		public static readonly BitSet _nonEmptyClassRangesNoDash_in_synpred58_JavaScriptRegExp667 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtom_in_synpred59_JavaScriptRegExp689 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _classAtomNoDash_in_synpred60_JavaScriptRegExp694 = new BitSet(new ulong[]{0x3FFFFFEFFFFF0UL});
		public static readonly BitSet _nonEmptyClassRangesNoDash_in_synpred60_JavaScriptRegExp696 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _decimalEscape_in_synpred65_JavaScriptRegExp763 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _49_in_synpred66_JavaScriptRegExp768 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _characterEscape_in_synpred67_JavaScriptRegExp773 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
