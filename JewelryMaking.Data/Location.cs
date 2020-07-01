using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JewelryMaking.Data
{
    public class Location
    {
        [Key]
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        [Required]
        public string Kind { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        [Required]
        public string Place { get; set; }
    }
}
