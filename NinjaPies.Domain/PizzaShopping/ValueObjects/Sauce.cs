using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NinjaPies.SharedKernel;

namespace NinjaPies.Domain.ValueObjects
{
    public enum SauceType
    {
        Normal = 1,
        Light = 2,
        Extra = 3,
        None = 4
    }

    public class Sauce: ValueObject<Sauce>
    {
        public SauceType Id { get; private set; }
        public string Name { get; set; }
        public float Cost { get; set; }

        public Sauce(int id, string name, float cost)
        {
            Id = (SauceType)id;
            Name = name;
            Cost = cost;
        }
    }
}
