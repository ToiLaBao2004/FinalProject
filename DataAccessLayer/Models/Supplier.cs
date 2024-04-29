using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Imports = new HashSet<Import>();
        }

        [Key]
        [StringLength(10)]
        public string Supplier_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string AddressSupplier { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public virtual ICollection<Import> Imports { get; set; }
    }
}
