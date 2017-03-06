using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaPies.Domain.Order
{
    public class SalesLineItem
    {
        public int Quantity { get; set; }       // Quantity of Pizzas being ordered            
        public int PizzaId { get; set; }        // Exact Pizza being ordered

        public SalesLineItem(int quantity, int pizzaId)
        {
            PizzaId = pizzaId;
            Quantity = quantity;
        }

    }
}
