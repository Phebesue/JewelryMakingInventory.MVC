using System;
using System.ComponentModel.DataAnnotations;

namespace JewelryMaking.Models
{
    public class FindingDetail
    {
        [Display(Name = "Finding ID #")]
        public int FindingId { get; set; }
        public string Category { get; set; }
        public string SubType { get; set; }
        public string Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        public string Association { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Cost per Item")]
        [DataType(DataType.Currency)]
        public double Cost { get; set; }
        [DataType(DataType.Currency)]
        public double SubTotal { get; set; }
        public string Description { get; set; }
        [Display(Name = "Location ID #")]
        public int LocationId { get; set; }
        [Display(Name = "Source ID #")]
        public int? SourceId { get; set; }

        public byte[] FileAsBytes { get; set; } // this is like a backing field. 
        [Display(Name = "Image")]
        public string ImageFile
        {
            get
            {
                if (FileAsBytes != null)
                {
                    string mimeType = "image/jpeg" /* Get mime type somehow (e.g. "image/png") */;
                    string base64 = Convert.ToBase64String(FileAsBytes);
                    return string.Format("data:{0};base64,{1}", mimeType, base64);
                }
                else { return ""; }
            }
        }
    }
}