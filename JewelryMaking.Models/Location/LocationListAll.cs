using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class LocationListAll
    {
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        public string Kind { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        //public string Place { get; set; }

    }
}
