using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    [Table("Material_Req")]
    public partial class MaterialReq
    {
        [Key]
        [Column("Material_ReqKey")]
        public int MaterialReqKey { get; set; }
        [Column("Material_Req")]
        public int? MaterialReq1 { get; set; }
        [Column("Job_Operation")]
        public int? JobOperation { get; set; }
        [Required]
        [StringLength(10)]
        public string Job { get; set; }
        [StringLength(30)]
        public string Material { get; set; }
        [StringLength(10)]
        public string Vendor { get; set; }
        [StringLength(30)]
        public string Description { get; set; }
        [Required]
        [Column("Pick_Buy_Indicator")]
        [StringLength(1)]
        public string PickBuyIndicator { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        [StringLength(1)]
        public string Status { get; set; }
        [Column("Quantity_Per_Basis")]
        [StringLength(1)]
        public string QuantityPerBasis { get; set; }
        [Column("Quantity_Per")]
        public double? QuantityPer { get; set; }
        [Required]
        [StringLength(4)]
        public string UofM { get; set; }
        [Column("Deferred_Qty")]
        public double DeferredQty { get; set; }
        [Column("Est_Qty")]
        public double? EstQty { get; set; }
        [Column("Est_Unit_Cost")]
        public double? EstUnitCost { get; set; }
        [Column("Est_Addl_Cost", TypeName = "money")]
        public decimal? EstAddlCost { get; set; }
        [Column("Est_Total_Cost", TypeName = "money")]
        public decimal? EstTotalCost { get; set; }
        [Column("Addl_Cost_Desc")]
        [StringLength(25)]
        public string AddlCostDesc { get; set; }
        [Column("Act_Qty")]
        public double? ActQty { get; set; }
        [Column("Act_Unit_Cost")]
        public double? ActUnitCost { get; set; }
        [Column("Act_Addl_Cost", TypeName = "money")]
        public decimal? ActAddlCost { get; set; }
        [Column("Act_Total_Cost", TypeName = "money")]
        public decimal? ActTotalCost { get; set; }
        [Column("Part_Length")]
        public double? PartLength { get; set; }
        [Column("Part_Width")]
        public double? PartWidth { get; set; }
        [Column("Bar_End")]
        public double? BarEnd { get; set; }
        public double? Cutoff { get; set; }
        public double? Facing { get; set; }
        [Column("Bar_Length")]
        public double? BarLength { get; set; }
        [Column("Lead_Days")]
        public short? LeadDays { get; set; }
        [Column("Currency_Conv_Rate")]
        public double CurrencyConvRate { get; set; }
        [Column("Trade_Currency")]
        public int? TradeCurrency { get; set; }
        [Required]
        [Column("Fixed_Rate")]
        public bool? FixedRate { get; set; }
        [Column("Trade_Date", TypeName = "datetime")]
        public DateTime? TradeDate { get; set; }
        [Column("Certs_Required")]
        public bool CertsRequired { get; set; }
        [Column("Manual_Link")]
        public bool ManualLink { get; set; }
        [Column("Due_Date", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("Sched_Start_Date", TypeName = "datetime")]
        public DateTime? SchedStartDate { get; set; }
        [Column("Sched_End_Date", TypeName = "datetime")]
        public DateTime? SchedEndDate { get; set; }
        [Column("Vendor_Reference")]
        [StringLength(30)]
        public string VendorReference { get; set; }
        [Column("Note_Text", TypeName = "text")]
        public string NoteText { get; set; }
        [Column("Last_Updated", TypeName = "datetime")]
        public DateTime LastUpdated { get; set; }
        [Column("Holder_ID")]
        [StringLength(50)]
        public string HolderId { get; set; }
        [Column("Cost_UofM")]
        [StringLength(4)]
        public string CostUofM { get; set; }
        [Column("Cost_Unit_Conv")]
        public double? CostUnitConv { get; set; }
        [Column("Quantity_Multiplier")]
        public double? QuantityMultiplier { get; set; }
        [Column("Drawing_ID")]
        [StringLength(30)]
        public string DrawingId { get; set; }
        [Column("Res_Type")]
        public short? ResType { get; set; }
        [Column("Res_ID")]
        [StringLength(50)]
        public string ResId { get; set; }
        [Column("Res_Qty")]
        public double? ResQty { get; set; }
        [Column("Partial_Res")]
        public bool? PartialRes { get; set; }
        [Column("ObjectID")]
        public Guid ObjectId { get; set; }
        [Column("Job_Operation_OID")]
        public Guid? JobOperationOid { get; set; }
        [Column("Job_OID")]
        public Guid? JobOid { get; set; }
        [Column("Affects_Schedule")]
        public bool? AffectsSchedule { get; set; }
        [Column("Material_OID")]
        public Guid? MaterialOid { get; set; }
        [Required]
        public bool? Rounded { get; set; }
    }
}
