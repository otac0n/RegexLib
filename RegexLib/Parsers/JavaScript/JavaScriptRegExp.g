grammar JavaScriptRegExp;
options {
	language = 'CSharp3';
}

tokens {
	PIPE = '|';
	CARAT = '^';
	DOLLAR = '$';
}

@lexer::namespace { RegexLib.Parsers.JavaScript }
@parser::namespace { RegexLib.Parsers.JavaScript }
@modifier { internal }

public pattern returns [RegexNode value]
	:	disjunction EOF { return $disjunction.value; }
	;

disjunction returns [RegexNode value]
	:	first=alternative (PIPE rest=disjunction)? { return $rest.value != null ? new AlternationNode($first.value, $rest.value) : $first.value; }
	;

alternative returns [RegexNode value]
	:	terms { return $terms.value; }
	|	/* empty */ { return null; }
	;

terms returns [RegexNode value]
	:	first=term rest=terms? { return $rest.value != null ? new ConcatenationNode($first.value, $rest.value) : $first.value; }
	;

term returns [RegexNode value]
	:	assertion { return $assertion.value; }
	|	atom { return $atom.value; }
	;

assertion returns [RegexNode value]
	:	CARAT { return new StringStartAnchorNode(); }
	|	DOLLAR { return new StringEndAnchorNode(); }
	;

atom returns [RegexNode value]
	:	CHAR { return new CharacterClassNode($CHAR.Text[0]); }
	;

CHAR
	:	~('\\' | '|' | '[' | '{' | '(')
	;
