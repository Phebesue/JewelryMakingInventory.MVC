using JewelryMaking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
    public class BeadListAll
    {
        [Display(Name = "Bead ID #")]
        public int BeadId { get; set; }
        public string Type { get; set; }
        public string Shape { get; set; }     
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        //public int Quantity { get; set; }
        public int LocationId { get; set; }
        //[Display(Name = "Image")]
        //public virtual ImageFile BeadImage { get; set; }
    }
}