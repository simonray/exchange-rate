
using ExchangeRate.Model;
using System.Net;

namespace ExchangeRate.Providers
{
    /// <exclude />
    public class YahooProvider : BaseProvider
    {
        /// <exclude />
        const string URL = "http://finance.yahoo.com/d/quotes.csv?e=.csv&f=c4l1&s={0}{1}=X";

        /// <exclude />
        public override string Name { get { return "Yahoo"; } }

        /// <exclude />
        public override Rate Fetch(Pair pair)
        {
            string url = pair.Construct(URL);
            var data = new GZipWebClient().DownloadString(url);
            if (data == null)
                ThrowFormatChanged();

            var value = data.Split(',')[1].Trim();

            return new Rate(double.Parse(value));
        }
    }
}
