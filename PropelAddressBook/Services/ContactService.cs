using AutoMapper;
using PropelAddressBook.Dtos;
using PropelAddressBook.Entities;
using PropelAddressBook.Mappers;

namespace PropelAddressBook.Services
{
    public class ContactService : IContactService
    {
        private Mapper _mapperConfig = MapperConfig.InitializeAutomapper();

        //Mock data set
        private static List<Contact> Contacts = new List<Contact>()
        {
                new Contact() { Id = 1, FirstName = "Jack", LastName = "Jackson", Phone = "111-111-1111", 
                    Address = new Address{
                        Name = "1 Main Street",
                        Postcode = "hd1 1dh",
                        State = "Yorkshire",
                        Active = true
                    },
                    Active = true},
                new Contact() { Id = 2, FirstName = "John", LastName = "Johnson", Phone = "222-222-2222",  
                    Address = new Address{
                        Name = "2 Side Street",
                        Postcode = "hd2 2dh",
                        State = "Yorkshire",
                        Active = true,
                    },
                    Active = true},
                new Contact() { Id = 3, FirstName = "Sarah", LastName = "Sarahson", Phone = "333-333-3333",  
                    Address = new Address{
                        Name = "3 Otherside Street",
                        Postcode = "hd3 3dh",
                        State = "Yorkshire",
                        Active = true,
                    },
                    Active = false},
        };

        public ContactDto GetContactById(int id)
        {
            var contact = Contacts.FirstOrDefault(contact => contact.Id == id);

            if (contact == null)
                return null;

            return _mapperConfig.Map<ContactDto>(contact);    
        }

        public IEnumerable<ContactDto> GetContacts()
        {
            var contacts = Contacts.Where(x => x.Active);

            if (contacts == null)
                return null;

            return _mapperConfig.Map<List<ContactDto>>(contacts);         
        }
    }
}
