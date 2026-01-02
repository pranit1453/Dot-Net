using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Project.Models
{
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        public string? Username { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("email")]
        public string? Email { get; set; }
    }

}
