using PropelAddressBook.Dtos;
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
            var result = _contactService.GetContacts();

            Xunit.Assert.NotNull(result);
            Xunit.Assert.Equal(2, result.Count());
        }

        [Fact]
        public void CreateContact_ReturnsCreatedContact()
        {
            var contactToCreate = new ContactDto
            {
                Id = 4,
                FirstName = "Bryan",
                LastName = "Bryanson",
                PhoneNumber = "1234567890",
                Address = new PropelAddressBook.Dto.AddressDto
                {
                    Id = 4,
                    Name = "4 new street",
                    Postcode = "hd4 4dh",
                    State = "Yorkshire",

                }
            };
            var result = _contactService.CreateContact(contactToCreate);

            Xunit.Assert.NotNull(result);
            Xunit.Assert.Equal(result.FirstName, contactToCreate.FirstName);
            Xunit.Assert.Equal(result.LastName, contactToCreate.LastName);
            Xunit.Assert.Equal(result.PhoneNumber, contactToCreate.PhoneNumber);
            Xunit.Assert.Equal(result.Address.Name, contactToCreate.Address.Name);
            Xunit.Assert.Equal(result.Address.Postcode, contactToCreate.Address.Postcode);
            Xunit.Assert.Equal(result.Address.State, contactToCreate.Address.State);
        }

        [Fact]
        public void UpdateContact_ReturnsUpdateContact()
        {
            var contactToUpdate = new ContactDto
            {
                Id = 3,
                FirstName = "Bryan",
                LastName = "Tucker",
                PhoneNumber = "234512345",
                Address = new PropelAddressBook.Dto.AddressDto
                {
                    Id = 4,
                    Name = "5 newer street",
                    Postcode = "hd5 5dh",
                    State = "Yorkshire",

                }
            };

            var result = _contactService.UpdateContact(contactToUpdate);

            Xunit.Assert.NotNull(result);
            Xunit.Assert.Equal(result.FirstName, contactToUpdate.FirstName);
            Xunit.Assert.Equal(result.LastName, contactToUpdate.LastName);
            Xunit.Assert.Equal(result.PhoneNumber, contactToUpdate.PhoneNumber);
            Xunit.Assert.Equal(result.Address.Name, contactToUpdate.Address.Name);
            Xunit.Assert.Equal(result.Address.Postcode, contactToUpdate.Address.Postcode);
            Xunit.Assert.Equal(result.Address.State, contactToUpdate.Address.State);
        }

        [Fact]
        public void DeleteContact_ReturnsTrue()
        {
            var id = 3;

            var result = _contactService.DeleteContact(id);

            Xunit.Assert.NotNull(result);
            Xunit.Assert.True(result);
        }

    }
}