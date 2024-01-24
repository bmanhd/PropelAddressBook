using AutoMapper;
using PropelAddressBook.Services;
using Xunit;

namespace Propel.Test
{
    [TestClass]
    public class AddressBookTest
    {
        private readonly ContactService _contactService = new();
        private readonly AddressBookFixture _bookFixture = new AddressBookFixture();
    
        [Fact]
        public void GetContactById_ReturnsContact()
        {
            var id = 1;
            var address = _bookFixture._contacts.First().Address;

            var result = _contactService.GetContactById(id);
            
            Xunit.Assert.NotNull(result);
            Xunit.Assert.Equal(id, result.Id);
            Xunit.Assert.Equal(address.Name, result.Address.Name);
            Xunit.Assert.Equal(address.Postcode, result.Address.Postcode);
            Xunit.Assert.Equal(address.State, result.Address.State);
            Xunit.Assert.Equal(address.Active, result.Address.Active);
        }

        [Fact]
        public void GetAllContacts_ReturnsActiveContacts()
        {
            var result = _contactService.GetAllContacts();

            Xunit.Assert.NotNull(result);
            Xunit.Assert.Equal(2, result.Count());
        }


    }
}