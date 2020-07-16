﻿using System.ComponentModel.DataAnnotations;
using System.Web;

namespace JewelryMaking.Models
{
    public class StringingMaterialEdit
    {
        [Required]
        [Display(Name = "Stringing ID # *")]
        public int StringingMaterialId { get; set; }
        [Required]
        [Display(Name = "Type *")]
        public string Type { get; set; }
        [Required]
        [Display(Name = "Material *")]
        public string Material { get; set; }
        [Display(Name = "Size *")]
        public double Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        [Required]
        [Display(Name = "Length in Inches *")]
        public double Length { get; set; }
        [Display(Name = "Cost per Inch *")]
        public double Cost { get; set; }
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        [Display(Name = "Location ID # *")]
        public int LocationId { get; set; }
        [Display(Name = "Source ID #")]
        public int? SourceId { get; set; }
        // for uploading a new file
        [Display(Name = "Image")]
        [DataType(DataType.Upload)]
        public HttpPostedFileBase File { get; set; }


        // for displaying the current image
        public byte[] FileAsBytes { get; set; } // this is like a backing field.
        public string ImageFile { get; set; }
    }
}