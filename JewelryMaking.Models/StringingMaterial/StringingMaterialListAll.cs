using JewelryMaking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
   public class StringingMaterialListAll
    {
        public int StringingMaterialId { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public double Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        //[Display(Name = "Length in Inches")]
        //public double Length { get; set; }
        //[Display(Name = "Cost per Inch")]
       // public double Cost { get; set; }
        public virtual Location Location { get; set; }
        //[Display(Name = "Image")]
        //public ImageFile StringingImage { get; set; }
    }
}