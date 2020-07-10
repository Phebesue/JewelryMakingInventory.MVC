using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class FindingSubTotal
    {
        [Display(Name = "Finding ID #")]
        public int FindingId { get; set; }
        public string Category { get; set; }
        public string SubType { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        //public string Association { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Cost per Item")]
        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        [DataType(DataType.Currency)]
        public double SubTotal { get; set; }
    }
}