﻿using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class SourceCreate
    {
        [Display(Name = "Name *")]
        public string Name { get; set; }
        public string WebSite { get; set; }
        [MaxLength(200, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Show or Location *")]
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