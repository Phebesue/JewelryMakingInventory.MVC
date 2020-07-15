using System;
using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class StringingMaterialDetail
    {
        public int StringingMaterialId { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public double Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        [Display(Name = "Length in Inches")]
        public double Length { get; set; }
        [Display(Name = "Cost per Inch")]
        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        [DataType(DataType.Currency)]
        public double SubTotal { get; set; }
        public string Description { get; set; }
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        [Display(Name = "Source ID #")]
        public int? SourceId { get; set; }

        public byte[] FileAsBytes { get; set; }
        [Display(Name = "Image")]
        public string File
        {
            get
            {
                string mimeType = "image/jpeg" /* Get mime type somehow (e.g. "image/png") */;
                string base64 = Convert.ToBase64String(FileAsBytes);
                return string.Format("data:{0};base64,{1}", mimeType, base64);
            }
        }
    }
}