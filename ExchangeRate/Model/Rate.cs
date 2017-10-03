
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
