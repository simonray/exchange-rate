using ExchangeRate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    /// <exclude />
    public enum Provider
    {
        /// <exclude />
        Google,
        /// <exclude />
        Yahoo,
        /// <exclude />
        RateExchange,
    }

    /// <exclude />
    public interface IProvider
    {
        /// <exclude />
        string Name { get; }
        /// <exclude />
        Rate Fetch(string source, string quote);
        /// <exclude />
        Rate Fetch(Iso4217 source, Iso4217 quote);
        /// <exclude />
        Rate Fetch(Pair pair);
    }
}
