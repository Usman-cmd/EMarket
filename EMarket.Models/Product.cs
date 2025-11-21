using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace EMarket.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [Display(Name = "Model Number")]
        public string ModelNumber { get; set; } 

        [Required]
        public string Brand { get; set; } 

        [Required]
        [Display(Name = "MSRP")] 
        [Range(1, 10000)] 
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price (1-9 units)")]
        [Range(1, 10000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price (10-49 units)")]
        [Range(1, 10000)]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Price (50+ units)")]
        [Range(1, 10000)]
        public double Price100 { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}