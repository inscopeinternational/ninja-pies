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
        public string Name { get; private set; }
        public float Cost { get; private set; }

        public Cheese(int id, string name, float cost)
        {
            Id = (CheeseType)id;
            Name = name;
            Cost = cost;
        }
    }
}
