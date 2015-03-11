using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExchangeRate.Providers;

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
        public void Create_Rate_Exchange_Instance_Success()
        {
            var instance = Factory.Make(Provider.RateExchange);
            Assert.IsInstanceOfType(instance, typeof(RateExchangeProvider));
        }

        [TestMethod]
        public void Create_Yahoo_Instance_Success()
        {
            var instance = Factory.Make(Provider.Yahoo);
            Assert.IsInstanceOfType(instance, typeof(YahooProvider));
        }
    }
}
