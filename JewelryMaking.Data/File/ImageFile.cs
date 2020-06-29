using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Data
{
    public class ImageFile : File
    {
        public virtual Bead Bead { get; set; }
        public virtual StringingMaterial StringingMaterial { get; set; }
        public virtual Finding Finding { get; set; }
    }
}
