%namespace RegexLib.Parsers.JavaScript
%visibility internal

%token pipe
%token carat
%token dollar
%token backSlash
%token boundary
%token notBoundary
%token lParen
%token rParen
%token positive
%token negative
%token lazy
%token anyNumber
%token oneOrMore
%token zeroOrOne
%token lBrace
%token rBrace
%token comma
%token anyChar
%token suppress
%token patternCharacter
%token control
%token controlEscape
%token controlLetter
%token identityEscape
%token lookaheadNotDecimalDigit
%token characterClassEscape
%token lBracket
%token rBracket
%token lookaheadNotCarat
%token dash
%token classAtomCharacter
%token b
%token zero
%token decimalDigit
%token nonZeroDigit
%token x
%token u
%token hexDigit

%{
	internal Parser(Scanner lex)
		: base(lex)
	{
	}
%}

%%

Start
	: Disjunction
	;

Disjunction
	: Alternative
	| Alternative pipe Disjunction
	;

Alternative
	: /* empty */
	| Alternative Term
	;

Term
	: Assertion
	| Atom
	| Atom Quantifier
	;

Assertion
	: carat
	| dollar
	| backSlash boundary
	| backSlash notBoundary
	| lParen positive Disjunction rParen
	| lParen negative Disjunction rParen
	;

Quantifier
	: QuantifierPrefix
	| QuantifierPrefix lazy
	;

QuantifierPrefix
	: anyNumber
	| oneOrMore
	| zeroOrOne
	| lBrace DecimalDigits rBrace
	| lBrace DecimalDigits comma rBrace
	| lBrace DecimalDigits comma DecimalDigits rBrace
	;

Atom
	: PatternCharacter
	| anyChar
	| backSlash AtomEscape
	| CharacterClass
	| lParen Disjunction rParen
	| lParen suppress Disjunction rParen
	;

PatternCharacter
	: patternCharacter
	;

AtomEscape
	: DecimalEscape
	| CharacterEscape
	| CharacterClassEscape
	;

CharacterEscape
	: ControlEscape
	| control ControlLetter
	| HexEscapeSequence
	| UnicodeEscapeSequence
	| IdentityEscape
	;

ControlEscape
	: controlEscape
	;

ControlLetter
	: controlLetter
	;

IdentityEscape
	: identityEscape
	;

DecimalEscape
	: DecimalIntegerLiteral lookaheadNotDecimalDigit
	;

CharacterClassEscape
	: characterClassEscape
	;

CharacterClass
	: lBracket lookaheadNotCarat ClassRanges rBracket
	| lBracket carat ClassRanges rBracket
	;

ClassRanges
	: /* empty */
	| NonemptyClassRanges
	;

NonemptyClassRanges
	: ClassAtom
	| ClassAtom NonemptyClassRangesNoDash
	| ClassAtom dash ClassAtom ClassRanges
	;

NonemptyClassRangesNoDash
	: ClassAtom
	| ClassAtomNoDash NonemptyClassRangesNoDash
	| ClassAtomNoDash dash ClassAtom ClassRanges
	;

ClassAtom
	: dash
	| ClassAtomNoDash
	;

ClassAtomNoDash
	: classAtomCharacter
	| backSlash ClassEscape
	;

ClassEscape
	: DecimalEscape
	| b
	| CharacterEscape
	| CharacterClassEscape
	;

DecimalIntegerLiteral
	: zero
	| NonZeroDigit
	| NonZeroDigit DecimalDigits
	;

DecimalDigits
	: DecimalDigit
	| DecimalDigit DecimalDigits
	;

DecimalDigit
	: decimalDigit
	;

NonZeroDigit
	: nonZeroDigit
	;

HexEscapeSequence
	: x HexDigit HexDigit
	;

UnicodeEscapeSequence
	: u HexDigit HexDigit HexDigit HexDigit
	;

HexDigit
	: hexDigit
	;
