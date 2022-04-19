using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithModels.Models
{
    public class Employe
    {

        [Key]
        [DisplayName("ID *")]
        public int Id { get; set; }

        [DisplayName("Employee Name  *")]
        [MinLength(4)]
        [MaxLength(15)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Name is requried")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email ID *")]
        [Required(ErrorMessage ="Email Id Requried")]
        public string EmailId { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [Display]
        [MaxLength(8)]
        [DataType(DataType.Password)]
        [DisplayName("Password *")]
        public string Password { get; set; }

    }
}
