using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    [Table("Material_Location")]
    public partial class MaterialLocation
    {
        [Key]
        [Column("Material_LocationKey")]
        public int MaterialLocationKey { get; set; }
        [Column("Material_Location")]
        public int? MaterialLocation1 { get; set; }
        [Required]
        [Column("Location_ID")]
        [StringLength(10)]
        public string LocationId { get; set; }
        [Required]
        [StringLength(30)]
        public string Material { get; set; }
        [StringLength(20)]
        public string Lot { get; set; }
        [Column("On_Hand_Qty")]
        public double OnHandQty { get; set; }
        [Column("Unit_Cost")]
        public double? UnitCost { get; set; }
        [Column("Last_Updated", TypeName = "datetime")]
        public DateTime LastUpdated { get; set; }
        [Column("ObjectID")]
        public Guid ObjectId { get; set; }
    }
}
