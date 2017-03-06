﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NinjaPies.SharedKernel;

namespace NinjaPies.Domain.Model
{
    public enum CrustType
    {
        Original = 1,
        Thin = 2,
        Pan = 3
    }

    public class Crust: ValueObject<Crust>
    {
         public CrustType Id { get; private set; }
        public string Name { get; set; }
        public float Cost { get; set; }

        public Crust(int id, string name, float cost)
        {
            Id = (CrustType)id;
            Name = name;
            Cost = cost;
        }
    }
}
