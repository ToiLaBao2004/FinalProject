using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public partial class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string Order_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string Product_ID { get; set; }

        public int Quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
