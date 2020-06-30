using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Models
{
  public  class SourceListAll
    {
        public int SourceId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Show or Location")]
        public string ShowOrLocation { get; set; }
    }
}