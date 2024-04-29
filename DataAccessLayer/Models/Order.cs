using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [StringLength(15)]
        public string Order_ID { get; set; }

        [Required]
        [StringLength(7)]
        public string Customers_ID { get; set; }

        [Required]
        [StringLength(5)]
        public string Employee_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public int TotalMoney { get; set; }

        [StringLength(10)]
        public string DiscountCode { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Discount Discount { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
