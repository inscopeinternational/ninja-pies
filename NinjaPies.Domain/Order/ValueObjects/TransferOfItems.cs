using NinjaPies.Domain.Order;
using NinjaPies.SharedKernel;


namespace NinjaPies.Domain.OrderingPizza.ValueObjects
{
    public enum TransferType
    {
        InStorePickup = 1,
        Delivery = 2
    }

    public class TransferOfItems : ValueObject<TransferOfItems>
    {
        public TransferType Id { get; private set; }

        public AddressBook Location { get; private set; }

        public TransferOfItems(int id, AddressBook location)
        {
            Id = (TransferType)id;
            Location = location;

            if (Id == TransferType.Delivery && location == null)
            {
                throw new Exception("Delivery requires a location");
            }

        }






    }
}
