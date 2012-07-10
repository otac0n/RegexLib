grammar JavaScriptRegExp;
options {
	language = 'CSharp3';
}

@lexer::namespace { RegexLib.Parsers.JavaScript }
@parser::namespace { RegexLib.Parsers.JavaScript }
@modifier { internal }

public pattern returns [RegexNode value]
	:	res='a' EOF { return new CharacterClassNode($res.Text[0]); }
	;
