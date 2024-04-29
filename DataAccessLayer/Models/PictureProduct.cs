using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public partial class PictureProduct
    {
        public PictureProduct()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Picture_ID { get; set; }

        [StringLength(100)]
        public string PictureName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
