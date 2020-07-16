using System.ComponentModel.DataAnnotations;
using System.Web;

namespace JewelryMaking.Models
{
    public class FindingEdit
    {

        [Required]
        [Display(Name = "Finding ID # *")]
        public int FindingId { get; set; }
        [Required]
        [Display(Name = "Category *")]
        public string Category { get; set; }
        public string SubType { get; set; }
        public string Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        public string Association { get; set; }
        [Required]
        [Display(Name = "Quantity *")]
        public int Quantity { get; set; }
        [Display(Name = "Cost per Item")]
        public double Cost { get; set; }
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        [Display(Name = "Location ID # *")]
        public int LocationId { get; set; }
        [Display(Name = "Source ID #")]
        public int? SourceId { get; set; }


        // for uploading a new file
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase File { get; set; }


        // for displaying the current image
        public byte[] FileAsBytes { get; set; } // this is like a backing field.
        public string ImageFile { get; set; }
    }
}