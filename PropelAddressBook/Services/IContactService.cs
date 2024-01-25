using PropelAddressBook.Dtos;

namespace PropelAddressBook.Services
{
    public interface IContactService
    {
        ContactDto GetContactById(int id);
        IEnumerable<ContactDto> GetContacts();
        ContactDto CreateContact(ContactDto newContact);
        ContactDto UpdateContact(ContactDto updateContact);
        bool DeleteContact(int id);
    }
}
