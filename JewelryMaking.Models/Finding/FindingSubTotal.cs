using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
    public class FindingSubTotal
    {
        [Display(Name = "Finding ID #")]
        public int FindingId { get; set; }
        public string Category { get; set; }
        public string SubType { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        //public string Association { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Cost per Item")]
        public double Cost { get; set; }
        public double SubTotal { get; set; }
    }
}