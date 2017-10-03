// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using ExchangeRate.Model;
using System.Net;
using System.Text.RegularExpressions;

namespace ExchangeRate.Providers
{
    /// <exclude />
    public class GoogleProvider : BaseProvider
    {
        /// <exclude />
        const string URL = "http://finance.google.com/finance/converter?a=1&from={0}&to={1}";

        /// <exclude />
        public override string Name { get { return "Google"; } }

        /// <exclude />
        public override Rate Fetch(Pair pair)
        {
            string url = pair.Construct(URL);
            var data = new GZipWebClient().DownloadString(url);

            var result = Regex.Matches(data, "<span class=\"?bld\"?>([^<]+)</span>")[0].Groups[1].Value;
            if (result == null)
                ThrowFormatChanged();
            
            var value = Regex.Match(result, @"[0-9]*(?:\.[0-9]+)?");
            if (value == null)
                ThrowFormatChanged();

            return new Rate(double.Parse(value.Value));
        }
    }
}
