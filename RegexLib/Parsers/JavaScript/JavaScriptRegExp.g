grammar JavaScriptRegExp;
options {
	language = 'CSharp3';
	output = AST;
	backtrack = true;
	memoize = true;
}

pattern
	:	disjunction EOF
	;

disjunction
	:	alternative ('|' disjunction)?
	;

alternative
	:	term*
	;

term
	:	assertion
	|	atom quantifier?
	;

assertion
	:	'^'
	|	'$'
	|	'\\b'
	|	'\\B'
	|	'(?=' disjunction ')'
	|	'(?!' disjunction ')'
	;

quantifier
	:	quantifierPrefix ('?')?
	;

quantifierPrefix
	:	'*'
	|	'+'
	|	'?'
	|	'{' decimalDigits (',' (decimalDigits)?)? '}'
	;

atom
	:	patternCharacter
	|	'.'
	|	'\\' atomEscape
	|	characterClass
	|	'(' disjunction ')'
	|	'(:?' disjunction ')'
	;

patternCharacter
	:	~('^'|'$'|'\\'|'.'|'*'|'+'|'?'|'('|')'|'['|']'|'{'|'}'|'|')
	;

atomEscape
	:	decimalEscape
	|	characterEscape
	|	characterClassEscape
	;

characterEscape
	:	controlEscape
	|	'c' controlLetter
	|	hexEscapeSequence
	|	unicodeEscapeSequence
	|	identityEscape
	;

controlEscape
	:	'f'
	|	'n'
	|	'r'
	|	't'
	|	'v'
	;

controlLetter
	:	('a'..'z'|'A'..'Z')
	;

hexEscapeSequence
	:	'x' hexDigit hexDigit
	;

unicodeEscapeSequence
	:	'u' hexDigit hexDigit hexDigit hexDigit
	;

hexDigit
	:	('0'..'9'|'a'..'f'|'A'..'F')
	;

identityEscape
	:	~('b'|'B'|'0'..'9'|'f'|'n'|'r'|'t'|'v'|'c'|'x'|'u')
	;

decimalEscape
	:	decimalIntegerLiteral /* TODO: Negative Lookahead for Decimal */
	;

decimalIntegerLiteral
	:	'0'
	|	nonZeroDigit decimalDigits?
	;
	
nonZeroDigit
	:	'1'..'9'
	;

decimalDigits
	:	decimalDigit+
	;

decimalDigit
	:	'0'..'9'
	;

characterClassEscape
	:	'd'
	|	'D'
	|	's'
	|	'S'
	|	'w'
	|	'W'
	;

characterClass
	:	'[' t=~'^' classRanges ']'
	|	'[^' classRanges ']'
	;

classRanges
	:	nonEmptyClassRanges?
	;

nonEmptyClassRanges
	:	classAtom nonEmptyClassRangesContinued
	;

nonEmptyClassRangesContinued
	: /* empty */
	| nonEmptyClassRangesNoDash
	| '-' classAtom classRanges
	;

nonEmptyClassRangesNoDash
	:	t='-' classAtom
	|	t=~'-' classAtomNoDash nonEmptyClassRangesNoDashContinued
	;

nonEmptyClassRangesNoDashContinued
	: /* empty */
	|	nonEmptyClassRangesNoDash
	|	'-' classAtom classRanges
	;

classAtom
	:	'-'
	|	classAtomNoDash
	;

classAtomNoDash
	:	~('\\' | ']' | '-')
	|	'\\' classEscape
	;

classEscape
	:	decimalEscape
	|	'b'
	|	characterEscape
	|	characterClassEscape
	;
