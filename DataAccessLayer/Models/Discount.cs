using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public partial class Discount
    {
        public Discount()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [StringLength(10)]
        public string DiscountCode { get; set; }

        public int PercentageDiscount { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDay { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDay { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
