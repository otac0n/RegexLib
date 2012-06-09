%namespace RegexLib.Parsers.JavaScript
%visibility internal

%token<Token> PIPE CARAT DOLLAR PAREN_L PAREN_R QUESTION STAR PLUS BRACKET_L BRACKET_R LITERAL_CHAR

%{
	public RegexNode RootNode { get; set; }

	internal Parser(Scanner lex)
		: base(lex)
	{
	}
%}

%union
{
	public RegexNode Node;
	public Token Token;
}

%type<Node> Start
%type<Node> Disjunction
%type<Node> Alternative
%type<Node> Term

%%

Start
	: Disjunction { this.RootNode = $$; }
	;

Disjunction
	: Alternative { $$ = $1; }
	| Alternative PIPE Disjunction { $$ = new AlternationNode($1, $3); }
	;

Alternative
	: /* empty */
	| Alternative Term { $$ = $1 == null ? $2 : new ConcatenationNode($1, $2); }
	;

Term
	: LITERAL_CHAR { $$ = new CharacterClassNode($1.Value[0]); }
	;
