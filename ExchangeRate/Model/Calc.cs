using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
