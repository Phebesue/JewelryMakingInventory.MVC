using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace JewelryMaking.Models
{
   public class FileUpload
    {
        [DataType(DataType.Upload)]
        [Display(Name = "Upload Image")]
        [Required(ErrorMessage = "Please choose file to upload.")]
        public string File { get; set; }

    }
}