using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CraftAContact.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; } //Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; }

        //Foreign Key for Category
        public int CategoryId { get; set; }

        //Navi property for Category
        public Category Category { get; set; }

        //Field to record logged-in user's username
        public string Username { get; set; }
    }
}
