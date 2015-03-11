using ExchangeRate.Model;
using ExchangeRate.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRate.Tests
{
    [TestClass]
    public class GoogleProviderFixture
    {
        [TestMethod]
        public void Create_Google_Provider_Fetch_By_Iso_Success()
        {
            IProvider provider = new GoogleProvider();
            Rate rate = provider.Fetch(Iso4217.GBP, Iso4217.USD);
            Assert.IsNotNull(rate);
            Assert.AreNotEqual(rate.Value, 0);
        }

        [TestMethod]
        public void Create_Google_Provider_Fetch_By_Raw_Success()
        {
            IProvider provider = new GoogleProvider();
            Rate rate = provider.Fetch("GBP", "USD");
            Assert.IsNotNull(rate);
            Assert.AreNotEqual(rate.Value, 0);
        }

        [TestMethod]
        public void Create_Google_Provider_Fetch_By_Pair_Success()
        {
            IProvider provider = new GoogleProvider();
            Rate rate = provider.Fetch(new Pair("GBP", "USD"));
            Assert.IsNotNull(rate);
            Assert.AreNotEqual(rate.Value, 0);
        }

        [TestMethod]
        public void Create_Google_Rate_Conversion_Success()
        {
            IProvider provider = new GoogleProvider();
            Rate rate = provider.Fetch(Iso4217.GBP, Iso4217.USD);
            Calc calc = new Calc(rate, 500);
            Assert.IsNotNull(rate);
            Assert.AreNotEqual(rate.Value, 0);
            Assert.AreNotEqual(calc.Result, 0);
        }
    }
}
