using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class FindingListAll
    {
        [Display(Name = "Finding ID #")]
        public int FindingId { get; set; }
        public string Category { get; set; }
        public string SubType { get; set; }
        //public string Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        //public string Association { get; set; }
        public int Quantity { get; set; }
    }
}