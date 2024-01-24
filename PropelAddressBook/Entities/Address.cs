namespace PropelAddressBook.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Postcode { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public bool Active { get; set; }
    }
}
