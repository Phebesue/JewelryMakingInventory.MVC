using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class SourceListAll
    {
        public int SourceId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Show or Location")]
        public string ShowOrLocation { get; set; }
    }
}