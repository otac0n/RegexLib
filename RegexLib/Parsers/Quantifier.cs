namespace RegexLib.Parsers
{
    internal class Quantifier
    {
        private readonly int min;
        private readonly int? max;
        private readonly bool eager;

        public Quantifier(int min, int? max = null, bool eager = true)
        {
            this.min = min;
            this.max = max;
            this.eager = eager;
        }

        public int Min
        {
            get { return this.min; }
        }

        public int? Max
        {
            get { return this.max; }
        }

        public bool Eager
        {
            get { return this.eager; }
        }
    }
}
