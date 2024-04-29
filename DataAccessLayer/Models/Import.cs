using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public partial class Import
    {
        public Import()
        {
            ImportDetails = new HashSet<ImportDetail>();
        }

        [Key]
        [StringLength(10)]
        public string Import_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Supplier_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime ImportDay { get; set; }

        public int TotalMoney { get; set; }

        public virtual ICollection<ImportDetail> ImportDetails { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
