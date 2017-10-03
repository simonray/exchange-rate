// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

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
