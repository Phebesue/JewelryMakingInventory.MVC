using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Data
{
    public class StringingMaterial
    {
        [Key]
        public int StringingMaterialId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Material { get; set; }
        public double Size { get; set; }
        [Display(Name = "Color or Finish")]
        public string Color { get; set; }
        [Required]
        [Display(Name = "Length in Inches")]
        public double Length { get; set; }
        [Display(Name = "Cost per Inch")]
        public double Cost { get; set; }
        [Required]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        [ForeignKey("Source")]
        public int? SourceId { get; set; }
        public virtual Source Source { get; set; }
        [MaxLength(8000, ErrorMessage = "Too Long.")]
        public string Description { get; set; }
        [ForeignKey("Location")]
        public double SubTotal
        {
            get
            {
                if (Length == 0)
                {
                    return 0;
                }
                return (Length * Cost);
            }
        }
        //[Display(Name = "Image")]
        //public ImageFile StringingImage { get; set; }
    }
}