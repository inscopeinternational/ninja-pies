using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinjaPies.Domain.Order
{
    public class SalesLineItem
    {
        public Guid Id { get; private set; }
        public int Quantity { get; private set; }       // Quantity of Pizzas being ordered            
        public int PizzaId { get; private set; }        // Exact Pizza being ordered

        public SalesLineItem(Guid id,  int quantity, int pizzaId)
        {
            if (quantity > 0)
                throw  new Exception("You must have a line item with a quantity greater than zero.");

            Id = id;
            PizzaId = pizzaId;
            Quantity = quantity;
        }

    }
}
