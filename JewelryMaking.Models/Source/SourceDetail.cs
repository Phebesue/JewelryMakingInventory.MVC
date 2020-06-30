using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
   public class SourceDetail
    {
        public string Name { get; set; }
        public string WebSite { get; set; }
        [Display(Name = "Show or Location")]
        public string ShowOrLocation { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Notes { get; set; }
    }
}

