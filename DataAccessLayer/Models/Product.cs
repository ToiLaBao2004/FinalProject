using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public partial class Product
    {
        public Product()
        {
            ImportDetails = new HashSet<ImportDetail>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [StringLength(15)]
        public string Product_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(10)]
        public string Brand_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Category_ID { get; set; }

        public int? Picture_ID { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<ImportDetail> ImportDetails { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual PictureProduct PictureProduct { get; set; }
    }
}
