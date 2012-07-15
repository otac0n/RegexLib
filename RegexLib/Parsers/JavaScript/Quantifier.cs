namespace RegexLib.Parsers.JavaScript
{
    internal class Quantifier
    {
        public int Min { get; set; }

        public int? Max { get; set; }

        public bool Eager { get; set; }
    }
}