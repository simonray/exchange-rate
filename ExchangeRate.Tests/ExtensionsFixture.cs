// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using ExchangeRate.Model;
using ExchangeRate.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExchangeRate.Tests
{
    [TestClass]
    public class ExtensionsFixture
    {
        [TestMethod]
        public void Get_Provider_Instance_Using_Enum_Success()
        {
            IProvider instance = Provider.Google.Instance();
            Assert.IsNotNull(instance);
            Assert.IsInstanceOfType(instance, typeof(GoogleProvider));
        }

        [TestMethod]
        public void Get_Rate_Using_Enum_Success()
        {
            Rate rate = Provider.Google.Fetch(Iso4217.GBP, Iso4217.USD);
            Assert.IsNotNull(rate);
            Assert.AreNotEqual(rate.Value, 0);
        }

        [TestMethod]
        public void Get_Rate_Value_Using_Enum_Success()
        {
            double value = Provider.Google.Rate(Iso4217.GBP, Iso4217.USD);
            Assert.AreNotEqual(value, 0);
        }

        [TestMethod]
        public void Get_Rate_Conversion_Using_Enum_Success()
        {
            double conversion = Provider.Google.Convert(Iso4217.GBP, Iso4217.USD, 500);
            Assert.AreNotEqual(conversion, 0);
        }
    }
}
