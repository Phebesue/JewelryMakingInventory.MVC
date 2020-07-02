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
      [Display(Name ="Stringing Material ID #")]
        public int StringingMaterialId { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public double Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }

        //[Display(Name = "Image")]
        //public virtual ImageFile BeadImage { get; set; }
    }
}