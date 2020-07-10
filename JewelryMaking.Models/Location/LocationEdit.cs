using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class LocationEdit
    {
        [Required]
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        [Required]
        public string Kind { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [Required]
        public string Place { get; set; }
    }
}
