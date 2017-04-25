using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaPies.Domain
{
    public class Payment
    {
        public string MonetaryUnit { get; set; }    // US Dollar
        public decimal Amount { get; set; }

        public Payment(string unit, decimal amount)
        {
            MonetaryUnit = unit;
            Amount = amount;
        }

    }
}
