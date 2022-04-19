using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace WorkingWithModels.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BId  { get; set; }

        [DisplayName("Book Name *")]
        [Required(ErrorMessage ="Enter Book Name")]
        [DataType(DataType.Text)]
        public int BName { get; set; }

        [DisplayName("Book Author *")]
        [Required(ErrorMessage = "Enter Book Author")]
        [DataType(DataType.Text)]
        public int BAuthor { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public int BDate { get; set; }
    }
}
