using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Data
{
    public class Source
    {
        [Key]
        [Display(Name = "Source #")]
        public int SourceId { get; set; }
        [Required]
        public string Name { get; set; }
        [Url]
        public string WebSite { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Show or Location")]
        public string ShowOrLocation { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [MaxLength(10, ErrorMessage = "There are too many characters in this field.")]
        public string ZipCode { get; set; }
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Note { get; set; }
    }
}