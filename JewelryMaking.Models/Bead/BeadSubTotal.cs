using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class BeadSubTotal
    {
        [Display(Name = "Bead ID #")]
        public int BeadId { get; set; }
        public string Type { get; set; }
        public string Shape { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        [DataType(DataType.Currency)]
        public double SubTotal { get; set; }
    }
}