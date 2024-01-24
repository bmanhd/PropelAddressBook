using AutoMapper;
using PropelAddressBook.Dtos;
using PropelAddressBook.Entities;

namespace PropelAddressBook.Services
{
    public class ContactService : IContactService
    {
        private readonly IMapper _automapper;

        public ContactService(IMapper automapper)
        {

            _automapper = automapper;
        }

        //Mock data set
        private static List<Contact> Contacts = new List<Contact>()
        {
                new Contact() { Id = 1, FirstName = "Jack", LastName = "Jackson", Phone = "111-111-1111", 
                    Address = new Address{
                        Name = "1 Main Street",
                        Postcode = "hd1 1dh",
                        State = "Yorkshire"
                    }},
                new Contact() { Id = 2, FirstName = "John", LastName = "Johnson", Phone = "222-222-2222",  
                    Address = new Address{
                        Name = "2 Side Street",
                        Postcode = "hd2 2dh",
                        State = "Yorkshire"
                    }},
                new Contact() { Id = 3, FirstName = "Sarah", LastName = "Sarahson", Phone = "333-333-3333",  
                    Address = new Address{
                        Name = "3 Otherside Street",
                        Postcode = "hd3 3dh",
                        State = "Yorkshire"
                    }},
        };

        public ContactDTO GetContactById(int id)
        {
            var contact = Contacts.FirstOrDefault(contact => contact.Id == id);

            if (contact == null)
                return null;

            return _automapper.Map<ContactDTO>(contact);    
        }
    }
}
