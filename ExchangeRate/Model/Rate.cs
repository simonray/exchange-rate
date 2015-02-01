using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
