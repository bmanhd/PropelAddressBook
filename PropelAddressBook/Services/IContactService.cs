using PropelAddressBook.Dtos;

namespace PropelAddressBook.Services
{
    public interface IContactService
    {
        ContactDTO GetContactById(int id);
    }
}
