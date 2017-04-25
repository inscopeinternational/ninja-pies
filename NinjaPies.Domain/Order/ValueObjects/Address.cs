

namespace NinjaPies.Domain.Order.ValueObjects
{
    public class AddressBook
    {
        public string Address1 { get; private set; }
        public string Address2 { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public int ZipCode { get; private set; }
        public string Phone { get; private set; }

        public AddressBook(string address1, string address2, string city, string state, int zip, string phone)
        {
            Address1 = address1;
            Address2 = address2;
            City = city;
            State = state;
            ZipCode = zip;
            Phone = phone;
        }
    }
}
