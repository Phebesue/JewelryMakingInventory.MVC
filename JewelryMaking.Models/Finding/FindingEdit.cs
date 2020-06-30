using JewelryMaking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
   public class FindingEdit
    {
        
        [Required]
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
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        [Required]
        public virtual Location Location { get; set; }
        public virtual Source Source { get; set; }
        public ImageFile FindingImage { get; set; }

    }
}
