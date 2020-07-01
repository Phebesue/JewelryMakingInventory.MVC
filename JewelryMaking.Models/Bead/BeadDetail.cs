using JewelryMaking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
   public class BeadDetail
    {
        [Display(Name = "Bead ID #")]
        public int BeadId { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string Shape { get; set; }
        public string Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Cost per Item")]
        public double Cost { get; set; }
        public virtual Location Location { get; set; }
        public virtual Source Source { get; set; }
        public string Description { get; set; }
        //[Display(Name = "Image")]
        //public virtual ImageFile BeadImage { get; set; }
    }
}