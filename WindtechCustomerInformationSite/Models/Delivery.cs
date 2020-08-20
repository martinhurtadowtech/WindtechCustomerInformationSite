using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    public partial class Delivery
    {
        [Key]
        public int DeliveryKey { get; set; }
        [Column("Delivery")]
        public int? Delivery1 { get; set; }
        [StringLength(8)]
        public string Packlist { get; set; }
        [StringLength(10)]
        public string Job { get; set; }
        [StringLength(50)]
        public string Invoice { get; set; }
        [StringLength(50)]
        public string CrMemo { get; set; }
        [Column("Invoice_Line")]
        [StringLength(50)]
        public string InvoiceLine { get; set; }
        [Column("CrMemo_Line")]
        [StringLength(50)]
        public string CrMemoLine { get; set; }
        [Column("SO_Detail")]
        public int? SoDetail { get; set; }
        [Column("Requested_Date", TypeName = "datetime")]
        public DateTime? RequestedDate { get; set; }
        [Column("Promised_Date", TypeName = "datetime")]
        public DateTime PromisedDate { get; set; }
        [Column("Shipped_Date", TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }
        [Column("Invoice_Date", TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }
        [Column("Returned_Date", TypeName = "datetime")]
        public DateTime? ReturnedDate { get; set; }
        [Column("CrMemo_Date", TypeName = "datetime")]
        public DateTime? CrMemoDate { get; set; }
        [Column("Promised_Quantity")]
        public int PromisedQuantity { get; set; }
        [Column("Shipped_Quantity")]
        public int? ShippedQuantity { get; set; }
        [Column("Remaining_Quantity")]
        public int? RemainingQuantity { get; set; }
        [Column("Returned_Quantity")]
        public int? ReturnedQuantity { get; set; }
        [Column("NCP_Quantity")]
        public int? NcpQuantity { get; set; }
        [Column("Return_Document")]
        [StringLength(15)]
        public string ReturnDocument { get; set; }
        [Column(TypeName = "text")]
        public string Comment { get; set; }
        [Column("Last_Updated", TypeName = "datetime")]
        public DateTime LastUpdated { get; set; }
        [Column("ObjectID")]
        public Guid ObjectId { get; set; }
        [Column("Job_OID")]
        public Guid? JobOid { get; set; }
        [Column("Last_Updated_By")]
        [StringLength(50)]
        public string LastUpdatedBy { get; set; }
    }
}
