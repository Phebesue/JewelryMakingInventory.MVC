using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JewelryMaking.Data
{
    public class File
    {
        [Key]
        [ForeignKey("Bead")]
        public int FileId { get; set; }

        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Image { get; set; }


        //public int BeadId { get; set; }
        public virtual Bead Bead { get; set; }
    }
}