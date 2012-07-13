grammar JavaScriptRegExp;
options {
	language = 'CSharp3';
}

@lexer::namespace { RegexLib.Parsers.JavaScript }
@parser::namespace { RegexLib.Parsers.JavaScript }
@modifier { internal }

public pattern returns [RegexNode value]
	:	disjunction EOF { return $disjunction.value; }
	;

disjunction returns [RegexNode value]
	:	term=atom (PIPE rest=disjunction)? { return $rest.value != null ? new AlternationNode($term.value, $rest.value) : $term.value; }
	;

PIPE
	:	'|'
	;

atom returns [RegexNode value]
	:	CHAR { return new CharacterClassNode($CHAR.Text[0]); }
	;

CHAR
	:	~('\\' | '|' | '[' | '{' | '(')
	;
