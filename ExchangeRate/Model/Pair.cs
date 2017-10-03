
namespace ExchangeRate.Model
{
    /// <exclude />
    public class Pair
    {
        /// <exclude />
        public string Source { get; set; }
        /// <exclude />
        public string Quote { get; set; }

        /// <exclude />
        public Pair(string source, string quote)
        {
            Source = source;
            Quote = quote;
        }

        /// <exclude />
        internal string Construct(string format)
        {
            return string.Format(format, Source, Quote);
        }
    }
}
