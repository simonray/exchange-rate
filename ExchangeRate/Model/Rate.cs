// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;

namespace ExchangeRate.Model
{
    /// <exclude />
    public class Rate
    {
        /// <exclude />
        public double Value { get; set; }
        /// <exclude />
        public DateTime Created { get; set; }

        /// <exclude />
        public Rate(double value)
        {
            Value = value;
            Created = DateTime.Now;
        }
    }
}
