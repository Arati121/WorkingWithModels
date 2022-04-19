using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace WorkingWithModels.Models
{
    public class Product1
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [DisplayName("Product name*")]
        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }

        [DisplayName("Price*")]
        [Required(ErrorMessage = "Please enter Price")]
        [DataType(DataType.Text)]
        public int Price { get; set; }

        [Required]
        [DisplayName("Product Quantity")]
        public int Quantity { get; set; }

        [Required]
        [DisplayName("Date And Time")]
        [DataType(DataType.DateTime)]

        public DateTime Ptime { get; set; }
    }
}
