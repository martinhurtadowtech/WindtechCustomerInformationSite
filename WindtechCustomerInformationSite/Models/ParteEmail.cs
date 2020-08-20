using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    public partial class ParteEmail
    {
        [Required]
        [Column("Part_Number")]
        [StringLength(200)]
        public string PartNumber { get; set; }
        [StringLength(500)]
        public string Email { get; set; }
    }
}
