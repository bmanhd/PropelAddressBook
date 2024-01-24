using PropelAddressBook.Dto;
using System.ComponentModel.DataAnnotations;

namespace PropelAddressBook.Dtos
{
    public class ContactDTO
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        [StringLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;
        public AddressDto? Address { get; set; }
    }
}