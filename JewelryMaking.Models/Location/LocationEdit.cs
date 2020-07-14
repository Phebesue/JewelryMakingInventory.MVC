using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class LocationEdit
    {
        [Required]
        [Display(Name = "Location ID # *")]
        public int LocationId { get; set; }
        [Required]
        [Display(Name ="Kind")]
        public string Kind { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [Required]
        [Display(Name = "Place *")]
        public string Place { get; set; }
    }
}