using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace assignment1.Models
{
    public class Car
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Colour { get; set; }

        public int Year { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Purchase")]

        public DateTime? PurchaseDate { get; set; }

        [Range(0, 999999)]
        public int Kilometers { get; set; }
    }
}
