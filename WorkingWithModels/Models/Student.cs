using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WorkingWithModels.Models
{
    public class Student
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RollNo { get; set; }

        [DisplayName("Student Name")]
        [MinLength(2)]
        [MaxLength(15)]

        [DataType(DataType.Text)]
        [Required(ErrorMessage ="name is requried")]
        public string Name { get; set; }
    


        [Required]
        public decimal Percentage { get; set; }
    }
    public class ProductContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
