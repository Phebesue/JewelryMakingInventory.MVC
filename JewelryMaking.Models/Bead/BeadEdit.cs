using JewelryMaking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
    public class BeadEdit
    {
        [Required]
        [Display(Name = "Bead ID #")]
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
        public double Cost { get; set; }
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        [Display(Name = "Source ID #")] 
        public int? SourceId { get; set; }

        [Display(Name = "Image")]
        public File File { get; set; }
    }
}