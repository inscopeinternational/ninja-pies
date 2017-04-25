using System;
using System.Collections.Generic;
using NinjaPies.Domain.ValueObjects;
using NinjaPies.SharedKernel;

namespace NinjaPies.Domain.Model
{
    public class Pizza
    {
        //public Guid Id { get; private set; }
        public string Name { get; private set; }       
        public IEnumerable<Topping> Toppings { get; private set; }
        public Crust Crust { get; private set; }
        public Cheese Cheese { get; private set; }
        public Sauce Sauce { get; private set; }
        public Decimal Cost { get; private set; }       // Cost before coupons, specials, etc


        public Pizza(string name, IEnumerable<Topping> toppings, Crust crust, Cheese cheese, Sauce sauce, decimal cost)
        {
            //Id = id;
            Name = name;
            Toppings = toppings;
            Crust = crust;
            Cheese = cheese;
            Sauce = sauce;
            Cost = cost;
        }
    }
}
