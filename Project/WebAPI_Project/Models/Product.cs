using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Project.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(100)]
        public string? Name { get; set; }

        [Column("description")]
        [StringLength(500)]
        public string? Description { get; set; }

       
        [Column("image")]
        public string? Image { get; set; }
    }
}
