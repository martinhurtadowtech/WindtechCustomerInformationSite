using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    [Table("User_Values")]
    public partial class UserValues
    {
        [Key]
        [Column("User_ValuesKey")]
        public int UserValuesKey { get; set; }
        [Column("User_Values")]
        public int UserValues1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date2 { get; set; }
        [StringLength(15)]
        public string Text1 { get; set; }
        [StringLength(15)]
        public string Text2 { get; set; }
        [StringLength(15)]
        public string Text3 { get; set; }
        [StringLength(25)]
        public string Text4 { get; set; }
        [StringLength(25)]
        public string Text5 { get; set; }
        [Column(TypeName = "money")]
        public decimal? Amount1 { get; set; }
        [Column(TypeName = "money")]
        public decimal? Amount2 { get; set; }
        public double? Numeric1 { get; set; }
        public double? Numeric2 { get; set; }
        public double? Decimal1 { get; set; }
        [Column("Note_Text", TypeName = "text")]
        public string NoteText { get; set; }
        [Column("Last_Updated", TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
    }
}
