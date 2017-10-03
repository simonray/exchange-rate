
using ExchangeRate.Model;
using System;

namespace ExchangeRate.Providers
{
    /// <exclude />
    public abstract class BaseProvider : IProvider
    {
        /// <exclude />
        public override string ToString() { return string.Format("{0}", Name); }

        /// <exclude />
        public void ThrowFormatChanged()
        {
            throw new Exception("The currency is not supported or the provider has changed the response format");
        }

        /// <exclude />
        public abstract string Name { get; }

        /// <exclude />
        public Rate Fetch(string source, string quote)
        {
            return Fetch(new Pair(source, quote));
        }

        /// <exclude />
        public Rate Fetch(Iso4217 source, Iso4217 quote)
        {
            return Fetch(new Pair(source.ToString(), quote.ToString()));
        }

        /// <exclude />
        public abstract Rate Fetch(Pair pair);
    }
}
