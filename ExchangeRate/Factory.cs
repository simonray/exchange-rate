using ExchangeRate.Model;
using ExchangeRate.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate
{
    /// <exclude />
    public static class FactoryExtensions
    {
        /// <exclude />
        public static IProvider Instance(this Provider provider)
        {
            return Factory.Make(provider);
        }

        /// <exclude />
        public static Rate Fetch(this Provider provider, string source, string quote)
        {
            return Factory.Make(provider).Fetch(source, quote);
        }

        /// <exclude />
        public static Rate Fetch(this Provider provider, Iso4217 source, Iso4217 quote)
        {
            return Factory.Make(provider).Fetch(source, quote);
        }

        /// <exclude />
        public static double Rate(this Provider provider, string source, string quote)
        {
            return Factory.Make(provider).Fetch(source, quote).Value;
        }

        /// <exclude />
        public static double Rate(this Provider provider, Iso4217 source, Iso4217 quote)
        {
            return Factory.Make(provider).Fetch(source, quote).Value;
        }
    }

    /// <exclude />
    public class Factory
    {
        /// <exclude />
        public static IProvider Make(Provider option)
        {
            switch(option)
            {
                case Provider.Google:
                    return new GoogleProvider();
                case Provider.Yahoo:
                    return new YahooProvider();
                case Provider.RateExchange:
                    return new RateExchange();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
