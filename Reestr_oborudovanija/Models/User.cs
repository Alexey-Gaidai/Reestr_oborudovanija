using System.ComponentModel.DataAnnotations.Schema;

namespace Reestr_oborudovanija.Models
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Role { get; set; }
    }
}
