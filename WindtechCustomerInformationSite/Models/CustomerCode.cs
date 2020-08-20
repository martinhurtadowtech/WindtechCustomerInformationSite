using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    public partial class CustomerCode
    {
        [Required]
        [Column("user")]
        [StringLength(100)]
        public string User { get; set; }
        [Required]
        [Column("customercode")]
        [StringLength(200)]
        public string Customercode1 { get; set; }
    }
}
