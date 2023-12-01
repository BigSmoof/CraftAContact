namespace CraftAContact.Models
{
    public class Category
    {
        public int CategoryId { get; set; } //Primary key
        public string CategoryName { get; set; }

        //Nav property to related Contacts
        public List<Contact> Contacts { get; set; }
    }
}
