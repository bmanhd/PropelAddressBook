namespace PropelAddressBook.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public virtual string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public Address? Address { get; set; }
        public bool Active { get; set; }
    }
}
