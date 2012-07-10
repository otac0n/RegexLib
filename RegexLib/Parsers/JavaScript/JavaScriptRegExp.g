grammar JavaScriptRegExp;
options {
	language = 'CSharp3';
}

@lexer::namespace { RegexLib.Parsers.JavaScript }
@parser::namespace { RegexLib.Parsers.JavaScript }
@modifier { internal }

public pattern returns [RegexNode value]
	:	atom EOF { return $atom.value; }
	;

atom returns [RegexNode value]
	:	CHAR { return new CharacterClassNode($CHAR.Text[0]); }
	;

CHAR
	:	'a'
	;
