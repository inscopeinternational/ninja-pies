using System;
using System.Collections.Generic;
using NinjaPies.SharedKernel;

namespace NinjaPies.Domain.Model
{
    public enum ToppingType
    {
        Pepperoni = 1,
        Bacon = 2,
        Sausage = 3,
        Beef = 4,
        Anchovies = 5
    }

    public class Topping: ValueObject<Topping>
    {
        public ToppingType Id { get; private set; }
        public string Name { get; set; }
        public float Cost { get; set; }

        public Topping(int id, string name, float cost)
        {
            Id = (ToppingType)id;
            Name = name;
            Cost = cost;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            throw new NotImplementedException();
        }
    }
}
