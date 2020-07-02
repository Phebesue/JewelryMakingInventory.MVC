﻿using JewelryMaking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
   public class FindingListAll
    {
        [Display(Name = "Finding ID #")] 
        public int FindingId { get; set; }
        public string Category { get; set; }
        public string SubType { get; set; }
        //public string Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        //public string Association { get; set; }
        public int Quantity { get; set; }
        //[Display(Name = "Cost per Item")]
        //public double Cost { get; set; }
        //public string Description { get; set; }

        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
       
        //[Display(Name = "Image")]
        //public virtual ImageFile BeadImage { get; set; }
    }
}