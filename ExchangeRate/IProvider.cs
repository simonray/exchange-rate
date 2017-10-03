// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using ExchangeRate.Model;

namespace ExchangeRate
{
    /// <exclude />
    public enum Provider
    {
        /// <exclude />
        Google,
        /// <exclude />
        Yahoo,
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
