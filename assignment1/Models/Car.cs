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
        public int ID;

        [Required]
        public string Make;

        [Required]
        public string Model;

        [Required]
        public string Colour;

        public int Year;

        [DataType(DataType.Date)]
        [Display(Name = "Purchase")]

        public DateTime? PurchaseDate { get; set; }

        [Range(0, 999999)]
        public int Kilometers { get; set; }
    }
}
