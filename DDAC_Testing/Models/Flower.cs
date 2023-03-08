using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DDAC_Testing.Models
{
    public class Flower
    {
        [Key]
        public int FlowerID { get; set; }

        public string FlowerName { get; set; }

        [Required(ErrorMessage = "Please key in the flower produced date!")]
        [DataType(DataType.Date)]
        [Display(Name = "Flower Produced Date")]
        public DateTime FlowerProducedDate { get; set; }

        [Required(ErrorMessage = "Please key in the flower type!")]
        [Display(Name = "Flower Type")]
        public string FlowerType { get; set; }

        [Required(ErrorMessage = "Please key in the flower price!")]
        [Display(Name = "Flower Price ")]
        [Range(1,100, ErrorMessage = "Please key in your flower produced date!")]
        public decimal FlowerPrice { get; set; }
    }
}
