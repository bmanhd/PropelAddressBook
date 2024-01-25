using PropelAddressBook.Entities;

namespace Propel.Test
{
    public class AddressBookFixture
    {
        public readonly IList<Contact> _contacts;
        public AddressBookFixture()
        {
            _contacts = new List<Contact>()
            {
                new Contact() { Id = 1, FirstName = "Jack", LastName = "Jackson", PhoneNumber = "111-111-1111",
                    Address = new Address{
                        Name = "1 Main Street",
                        Postcode = "hd1 1dh",
                        State = "Yorkshire",
                        Active = true
                    },
                    Active = true},
                new Contact() { Id = 2, FirstName = "John", LastName = "Johnson", PhoneNumber = "222-222-2222",
                    Address = new Address{
                        Name = "2 Side Street",
                        Postcode = "hd2 2dh",
                        State = "Yorkshire",
                        Active = true
                    },
                    Active = true},
                new Contact() { Id = 3, FirstName = "Sarah", LastName = "Sarahson", PhoneNumber = "333-333-3333",
                    Address = new Address{
                        Name = "3 Otherside Street",
                        Postcode = "hd3 3dh",
                        State = "Yorkshire",
                        Active = true
                    },
                    Active = false}
            };
        }
    }
}

