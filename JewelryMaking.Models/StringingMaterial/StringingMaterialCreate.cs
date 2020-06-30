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
        [Required]
        public virtual Location Location { get; set; }
        public virtual Source Source { get; set; }
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        [Display(Name = "Image")]
        public ImageFile StringingImage { get; set; }
    }
}