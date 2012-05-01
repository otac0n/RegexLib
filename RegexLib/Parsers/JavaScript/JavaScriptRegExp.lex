%namespace RegexLib.Parsers.JavaScript
%visibility internal

%option nofiles

pipe                     \|
carat                    \^
dollar                   \$
backSlash                \\
boundary                 b
notBoundary              B
lParen                   \(
rParen                   \)
positive                 \?=
negative                 \?!
lazy                     \?
anyNumber                \*
oneOrMore                \+
zeroOrOne                \?
lBrace                   \{
rBrace                   \}
comma                    ,
anyChar                  \.
suppress                 \?:
patternCharacter         [^\]\\^$.*+?()[{}|]
control                  c
controlEscape            f|n|r|t|v
controlLetter            [a-zA-Z]
identityEscape           .
lookaheadNotDecimalDigit (?![0-9])
characterClassEscape     d|D|s|S|w|W
lBracket                 \[
rBracket                 \]
lookaheadNotCarat        (?!\^)
dash                     -
classAtomCharacter       [^\-\]\\]
b                        b
zero                     0
decimalDigit             [0-9]
nonZeroDigit             [1-9]
x                        x
u                        u
hexDigit                 [0-9a-fA-F]

%%
