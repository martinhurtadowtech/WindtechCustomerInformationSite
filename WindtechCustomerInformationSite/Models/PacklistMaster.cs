using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    public partial class PacklistMaster
    {
        [Required]
        [StringLength(100)]
        public string Packlist { get; set; }
        [StringLength(100)]
        public string Invoice { get; set; }
        [Column("shipped_date", TypeName = "datetime")]
        public DateTime ShippedDate { get; set; }
        [Column("bandera")]
        [StringLength(100)]
        public string Bandera { get; set; }
        [Column("PacklistID")]
        [StringLength(100)]
        public string PacklistId { get; set; }
        [Column("text1")]
        [StringLength(200)]
        public string Text1 { get; set; }
    }
}
