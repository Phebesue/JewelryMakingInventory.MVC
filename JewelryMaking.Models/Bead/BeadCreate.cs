using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class BeadCreate
    {


        public string Brand { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        [Required]
        public string Shape { get; set; }
        public string Size { get; set; }
        [Required]
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Display(Name = "Cost per Item")]
        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        [Display(Name = "Source ID #")]
        public int? SourceId { get; set; }

        //[Display(Name = "Image")]
        //public virtual File File { get; set; }
        //[Display(Name = "File")]
        //[DataType(DataType.Upload)]
        //public HttpPostedFileBase File { get; set; }
    }
}