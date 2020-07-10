using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class FindingDetail
    {
        [Display(Name = "Finding ID #")]
        public int FindingId { get; set; }
        public string Category { get; set; }
        public string SubType { get; set; }
        public string Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        public string Association { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Cost per Item")]
        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        [DataType(DataType.Currency)]
        public double SubTotal { get; set; }
        public string Description { get; set; }
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        [Display(Name = "Source ID #")]
        public int? SourceId { get; set; }

        //public ImageFile FindingImage { get; set; }
    }
}