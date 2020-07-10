using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelryMaking.Data
{
    public class Bead
    {
        [Key]
        public int BeadId { get; set; }
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

        [ForeignKey("Location")]
        [Required]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        [ForeignKey("Source")]
        public int? SourceId { get; set; }
        public virtual Source Source { get; set; }

        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        public double SubTotal
        {
            get
            {
                if (Quantity == 0)
                {
                    return 0;
                }
                return (Quantity * Cost);
            }
        }

        //[Display(Name = "File")]
        //[DataType(DataType.Upload)]
        //public HttpPostedFileBase File { get; set; }
    }
}