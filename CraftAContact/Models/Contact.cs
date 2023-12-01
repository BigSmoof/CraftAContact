namespace CraftAContact.Models
{
    public class Contact
    {
        public int ContactId { get; set; } //Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string DateCreated { get; set; }

        //Foreign Key for Category
        public int CategoryId { get; set; }

        //Navi property for Category
        public Category Category { get; set; }

        //Field to record logged-in user's username
        public string Username { get; set; }
    }
}
