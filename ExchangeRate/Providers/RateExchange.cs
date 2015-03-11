using ExchangeRate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace ExchangeRate.Providers
{
    /// <exclude />
    public class RateExchangeProvider : BaseProvider
    {
        /// <exclude />
        const string URL = "http://rate-exchange.appspot.com/currency?from={0}&to={1}";

        /// <exclude />
        public override string Name { get { return "Rate Exchange"; } }

        /// <exclude />
        public override Rate Fetch(Pair pair)
        {
            string url = pair.Construct(URL);
            var data = new GZipWebClient().DownloadString(url);

            var value = Regex.Matches(data, "\"rate\":?([^<]+),")[0].Groups[1].Value;
            if (value == null)
                ThrowFormatChanged();

            return new Rate(double.Parse(value));
        }
    }
}
