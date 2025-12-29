using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFramework.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("Student_Name")]
        public string? Name { get; set; }
        [Column("Student_Age")]
        public int Age { get; set; }
    }
}
