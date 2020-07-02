using JewelryMaking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
   public class StringingMaterialCreate
    {
        
        [Required]
        public string Type { get; set; }
        [Required]
        public string Material { get; set; }
        public double Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        [Required]
        [Display(Name = "Length in Inches")]
        public double Length { get; set; }
        [Display(Name = "Cost per Inch")]
        public double Cost { get; set; }
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        [Display(Name = "Source ID #")]
        public int SourceId { get; set; }

        //[Display(Name = "Image")]
        //public virtual ImageFile BeadImage { get; set; }
    }
}