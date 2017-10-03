// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace ExchangeRate.Model
{
    /// <exclude />
    public class Calc
    {
        /// <exclude />
        public double Result { get; private set; }

        /// <exclude />
        public Calc(Rate rate, double amount)
        {
            Result = amount * rate.Value;
        }
    }
}
