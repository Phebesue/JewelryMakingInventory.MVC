using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Data
{
    public class Finding
    {
        [Key]
        public int FindingId { get; set; }
        [Required]
        public string Category { get; set; }
        public string SubType { get; set; }
        public string Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        public string Association { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Display(Name = "Cost per Item")]
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

        //[Display(Name = "Image")]
        //public ImageFile FindingImage { get; set; }
    }
}