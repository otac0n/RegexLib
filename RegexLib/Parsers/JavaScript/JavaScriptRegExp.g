grammar JavaScriptRegExp;
options {
	language = 'CSharp3';
}

tokens {
	PIPE = '|';
	CARAT = '^';
	DOLLAR = '$';
	DOT = '.';
	QUESTION = '?';
	STAR = '*';
	PLUS = '+';
	L_CURLY = '{';
	R_CURLY = '}';
	COMMA = ',';
}

@lexer::namespace { RegexLib.Parsers.JavaScript }
@parser::namespace { RegexLib.Parsers.JavaScript }
@modifier { internal }
@header {
	using System.Text;
}

public pattern returns [RegexNode value]
	:	disjunction EOF { return $disjunction.value; }
	;

disjunction returns [RegexNode value]
	:	first=alternative (PIPE rest=disjunction)? { return $rest.value != null ? new AlternationNode($first.value, $rest.value) : $first.value; }
	;

alternative returns [RegexNode value]
	:	terms { return $terms.value; }
	|	/* empty */ { return new EmptyNode(); }
	;

terms returns [RegexNode value]
	:	first=term rest=terms? { return $rest.value != null ? new ConcatenationNode($first.value, $rest.value) : $first.value; }
	;

term returns [RegexNode value]
	:	assertion { return $assertion.value; }
	|	atom quantifier? { return $quantifier.value != null ? new RepetitionNode($atom.value, $quantifier.value.Min, $quantifier.value.Max, $quantifier.value.Eager) : $atom.value; }
	;

assertion returns [RegexNode value]
	:	CARAT { return new StringStartAnchorNode(); }
	|	DOLLAR { return new StringEndAnchorNode(); }
	;

quantifier returns [Quantifier value]
	:	q=quantifierPrefix QUESTION?
		{
			var quant = $q.value;
			quant.Eager = $QUESTION == null;
			return quant;
		}
	;

quantifierPrefix returns [Quantifier value]
	:	STAR { return new Quantifier { Min = 0 }; }
	|	PLUS { return new Quantifier { Min = 1 }; }
	|	QUESTION { return new Quantifier { Min = 0, Max = 1 }; }
	|	L_CURLY min=decimalDigits (COMMA max=decimalDigits?)? R_CURLY
		{
			var minValue = $min.value.Value;
			if ($COMMA == null)
			{
				return new Quantifier { Min = minValue, Max = minValue };
			}
			else if (!$max.value.HasValue)
			{
				return new Quantifier { Min = minValue, Max = null };
			}
			else
			{
				var maxValue = $max.value.Value;
				return new Quantifier { Min = minValue, Max = maxValue };
			}
		}
	;

decimalDigits returns [int? value]
	:	(v+=DIGIT)+
		{
			var sb = new StringBuilder();
			$v.ForEach(d => sb.Append(d.Text));
			return int.Parse(sb.ToString());
		}
	;

DIGIT
	:	'0'..'9'
	;

atom returns [RegexNode value]
	:	c=(CHAR | DIGIT | COMMA) { return new CharacterClassNode($c.Text[0]); }
	|	DOT { return new CharacterClassNode(); }
	;

CHAR
	:	~('^' | '$' | '\\' | '.' | '*' | '+' | '?' | '(' | ')' | '[' | ']' | '{' | '}' | '|')
	;
