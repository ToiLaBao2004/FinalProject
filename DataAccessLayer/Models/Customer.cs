using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [StringLength(7)]
        public string Customers_ID { get; set; }

        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string NameCustomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        [Required]
        [StringLength(3)]
        public string Gender { get; set; }

        [StringLength(100)]
        public string AddressCustomer { get; set; }

        public int? TotalMoney { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
