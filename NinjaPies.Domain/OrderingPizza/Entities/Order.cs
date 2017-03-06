using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaPies.Domain.Order
{
    public class Order
    {
        public DateTime OrderDate { get; set; }

        public Payment Payment { get; set; }

        // Customer....

        public SalesLineItem LineItem { get; set; }

    }
}
