using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NinjaPies.Domain.Model;
using NinjaPies.SharedKernel;

namespace NinjaPies.Domain.ValueObjects
{
    public enum CheeseType
    {
        Normal = 1,
        Light = 2,
        None = 3
    }
    public class Cheese : ValueObject<Cheese>
    {
        public CheeseType Id { get; private set; }
        public string Name { get; set; }
        public float Cost { get; set; }

        public Cheese(int id, string name, float cost)
        {
            Id = (CheeseType)id;
            Name = name;
            Cost = cost;
        }
    }
}
