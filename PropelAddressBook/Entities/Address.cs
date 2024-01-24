using System.ComponentModel.DataAnnotations;

namespace PropelAddressBook.Entities
{
    public class Address
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string Name { get; set; } = string.Empty;

        [StringLength(10)]
        public string Postcode { get; set; } = string.Empty;

        [StringLength(50)]
        public string State { get; set; } = string.Empty;

        public bool Active { get; set; }
    }
}
