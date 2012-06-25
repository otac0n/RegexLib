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
	|	'{' DecimalDigits (',' (DecimalDigits)?)? '}'
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
	:	ControlEscape
	|	'c' ControlLetter
	|	HexEscapeSequence
	|	UnicodeEscapeSequence
	|	IdentityEscape
	;

fragment ControlEscape
	:	'f'
	|	'n'
	|	'r'
	|	't'
	|	'v'
	;

fragment ControlLetter
	:	('a'..'z'|'A'..'Z')
	;

fragment HexEscapeSequence
	:	'x' HexDigit HexDigit
	;

fragment UnicodeEscapeSequence
	:	'u' HexDigit HexDigit HexDigit HexDigit
	;

fragment HexDigit
	:	('0'..'9'|'a'..'f'|'A'..'F')
	;

fragment IdentityEscape
	:	~('b'|'B'|'0'..'9'|'f'|'n'|'r'|'t'|'v'|'c'|'x'|'u')
	;

decimalEscape
	:	DecimalIntegerLiteral /* TODO: Negative Lookahead for Decimal */
	;

fragment DecimalIntegerLiteral
	:	'0'
	|	NonZeroDigit DecimalDigits?
	;
	
fragment NonZeroDigit
	:	'1'..'9'
	;

fragment DecimalDigits
	:	DecimalDigit+
	;

fragment DecimalDigit
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
