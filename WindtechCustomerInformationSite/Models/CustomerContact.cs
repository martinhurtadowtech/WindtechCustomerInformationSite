using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    public partial class CustomerContact
    {
        [StringLength(200)]
        public string Customer { get; set; }
        [StringLength(500)]
        public string Email { get; set; }
    }
}
