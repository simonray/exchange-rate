// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using ExchangeRate.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExchangeRate.Tests
{
    [TestClass]
    public class FactoryFixture
    {
        [TestMethod]
        public void Create_Google_Instance_Success()
        {
            var instance = Factory.Make(Provider.Google);
            Assert.IsInstanceOfType(instance, typeof(GoogleProvider));
        }

        [TestMethod]
        public void Create_Yahoo_Instance_Success()
        {
            var instance = Factory.Make(Provider.Yahoo);
            Assert.IsInstanceOfType(instance, typeof(YahooProvider));
        }
    }
}
