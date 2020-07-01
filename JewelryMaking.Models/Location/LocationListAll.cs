using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
    public class LocationListAll
    {
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        public string Kind { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        //public string Place { get; set; }

    }
}
