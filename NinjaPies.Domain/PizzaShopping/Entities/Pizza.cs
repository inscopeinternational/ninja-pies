using System.Collections.Generic;
using NinjaPies.Domain.ValueObjects;
using NinjaPies.SharedKernel;

namespace NinjaPies.Domain.Model
{
    public class Pizza: Entity<int>
    {
        public string Name { get; set; }        // Custom, Hawaiin Pizza, Veggie Pizza, ..

        public IEnumerable<Topping> Toppings { get; set; }
        public Crust Crust { get; set; }
        public Cheese Cheese { get; set; }
        public Sauce Sauce { get; set; }

        // Size
        // Cut
        // Bake

        public float TotalCost { get; }
        public void SetCost(float cost)
        {
            // Set the cost
        }

    }
}
