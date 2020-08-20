using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    public partial class MaterialCode
    {
        [Required]
        [Column("materialcode")]
        [StringLength(50)]
        public string Materialcode1 { get; set; }
        [Required]
        [Column("customercode")]
        [StringLength(200)]
        public string Customercode { get; set; }
    }
}
