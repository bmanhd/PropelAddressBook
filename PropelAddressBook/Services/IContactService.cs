using PropelAddressBook.Dtos;

namespace PropelAddressBook.Services
{
    public interface IContactService
    {
        ContactDto GetContactById(int id);
        IEnumerable<ContactDto> GetContacts();
    }
}
