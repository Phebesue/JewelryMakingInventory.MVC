using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class SourceDetail
    {
        public int SourceId { get; set; }
        public string Name { get; set; }
        public string WebSite { get; set; }
        [Display(Name = "Show or Location")]
        public string ShowOrLocation { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Note { get; set; }
    }
}

