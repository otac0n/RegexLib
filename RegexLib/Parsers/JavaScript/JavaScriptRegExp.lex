%namespace RegexLib.Parsers.JavaScript
%visibility internal

%option nofiles

anyChar                  .

%%

"|"                     { yylval.Token = new Token(Tokens.PIPE, yytext, yyline, yycol); return (int)Tokens.PIPE; }
"^"                     { yylval.Token = new Token(Tokens.CARAT, yytext, yyline, yycol); return (int)Tokens.CARAT; }
"$"                     { yylval.Token = new Token(Tokens.DOLLAR, yytext, yyline, yycol); return (int)Tokens.DOLLAR; }
"("                     { yylval.Token = new Token(Tokens.PAREN_L, yytext, yyline, yycol); return (int)Tokens.PAREN_L; }
")"                     { yylval.Token = new Token(Tokens.PAREN_R, yytext, yyline, yycol); return (int)Tokens.PAREN_R; }
"?"                     { yylval.Token = new Token(Tokens.QUESTION, yytext, yyline, yycol); return (int)Tokens.QUESTION; }
"*"                     { yylval.Token = new Token(Tokens.STAR, yytext, yyline, yycol); return (int)Tokens.STAR; }
"+"                     { yylval.Token = new Token(Tokens.PLUS, yytext, yyline, yycol); return (int)Tokens.PLUS; }
"["                     { yylval.Token = new Token(Tokens.BRACKET_L, yytext, yyline, yycol); return (int)Tokens.BRACKET_L; }
"]"                     { yylval.Token = new Token(Tokens.BRACKET_R, yytext, yyline, yycol); return (int)Tokens.BRACKET_R; }

{anyChar}               { yylval.Token = new Token(Tokens.LITERAL_CHAR, yytext, yyline, yycol); return (int)Tokens.LITERAL_CHAR; }
