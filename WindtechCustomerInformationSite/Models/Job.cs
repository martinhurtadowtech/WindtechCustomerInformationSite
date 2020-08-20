using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    public partial class Job
    {
        [Key]
        [Column("Job")]
        [StringLength(10)]
        public string Job1 { get; set; }
        [Column("Sales_Rep")]
        [StringLength(6)]
        public string SalesRep { get; set; }
        [StringLength(10)]
        public string Customer { get; set; }
        [Column("Ship_To")]
        public int? ShipTo { get; set; }
        [Column("User_Values")]
        public int? UserValues { get; set; }
        [StringLength(10)]
        public string Quote { get; set; }
        public int? Contact { get; set; }
        [Column("Ship_Via")]
        [StringLength(15)]
        public string ShipVia { get; set; }
        [StringLength(15)]
        public string Terms { get; set; }
        [Column("Tax_Code")]
        [StringLength(15)]
        public string TaxCode { get; set; }
        [Column("Sales_Code")]
        [StringLength(15)]
        public string SalesCode { get; set; }
        [Column("Top_Lvl_Job")]
        [StringLength(10)]
        public string TopLvlJob { get; set; }
        [Required]
        [StringLength(8)]
        public string Type { get; set; }
        [Column("Order_Date", TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
        [Required]
        [StringLength(8)]
        public string Status { get; set; }
        [Column("Status_Date", TypeName = "datetime")]
        public DateTime StatusDate { get; set; }
        [Column("Part_Number")]
        [StringLength(30)]
        public string PartNumber { get; set; }
        [StringLength(10)]
        public string Rev { get; set; }
        [StringLength(30)]
        public string Description { get; set; }
        [Column("Ext_Description", TypeName = "text")]
        public string ExtDescription { get; set; }
        [StringLength(30)]
        public string Drawing { get; set; }
        [Column("Build_To_Stock")]
        public bool BuildToStock { get; set; }
        [Column("Order_Quantity")]
        public int OrderQuantity { get; set; }
        [Column("Extra_Quantity")]
        public int? ExtraQuantity { get; set; }
        [Column("Pick_Quantity")]
        public int? PickQuantity { get; set; }
        [Column("Make_Quantity")]
        public int MakeQuantity { get; set; }
        [Column("Split_Quantity")]
        public int? SplitQuantity { get; set; }
        [Column("Completed_Quantity")]
        public int? CompletedQuantity { get; set; }
        [Column("Shipped_Quantity")]
        public int? ShippedQuantity { get; set; }
        [Column("FG_Transfer_Qty")]
        public int? FgTransferQty { get; set; }
        [Column("Returned_Quantity")]
        public int? ReturnedQuantity { get; set; }
        [Column("In_Production_Quantity")]
        public int InProductionQuantity { get; set; }
        [Column("Assembly_Level")]
        public short? AssemblyLevel { get; set; }
        [Column("Certs_Required")]
        public bool CertsRequired { get; set; }
        [Column("Time_And_Materials")]
        public bool TimeAndMaterials { get; set; }
        [Column("Open_Operations")]
        public short? OpenOperations { get; set; }
        [Column("Scrap_Pct")]
        public double ScrapPct { get; set; }
        [Column("Est_Scrap_Qty")]
        public int? EstScrapQty { get; set; }
        [Column("Est_Rem_Hrs")]
        public double? EstRemHrs { get; set; }
        [Column("Est_Total_Hrs")]
        public double? EstTotalHrs { get; set; }
        [Column("Est_Labor", TypeName = "money")]
        public decimal? EstLabor { get; set; }
        [Column("Est_Material", TypeName = "money")]
        public decimal? EstMaterial { get; set; }
        [Column("Est_Service", TypeName = "money")]
        public decimal? EstService { get; set; }
        [Column("Est_Labor_Burden", TypeName = "money")]
        public decimal? EstLaborBurden { get; set; }
        [Column("Est_Machine_Burden", TypeName = "money")]
        public decimal? EstMachineBurden { get; set; }
        [Column("Est_GA_Burden", TypeName = "money")]
        public decimal? EstGaBurden { get; set; }
        [Column("Act_Revenue", TypeName = "money")]
        public decimal? ActRevenue { get; set; }
        [Column("Act_Scrap_Quantity")]
        public int? ActScrapQuantity { get; set; }
        [Column("Act_Total_Hrs")]
        public double? ActTotalHrs { get; set; }
        [Column("Act_Labor", TypeName = "money")]
        public decimal? ActLabor { get; set; }
        [Column("Act_Material", TypeName = "money")]
        public decimal? ActMaterial { get; set; }
        [Column("Act_Service", TypeName = "money")]
        public decimal? ActService { get; set; }
        [Column("Act_Labor_Burden", TypeName = "money")]
        public decimal? ActLaborBurden { get; set; }
        [Column("Act_Machine_Burden", TypeName = "money")]
        public decimal? ActMachineBurden { get; set; }
        [Column("Act_GA_Burden", TypeName = "money")]
        public decimal? ActGaBurden { get; set; }
        public short? Priority { get; set; }
        [Column("Unit_Price")]
        public double? UnitPrice { get; set; }
        [Column("Total_Price", TypeName = "money")]
        public decimal? TotalPrice { get; set; }
        [Column("Price_UofM")]
        [StringLength(4)]
        public string PriceUofM { get; set; }
        [Column("Currency_Conv_Rate")]
        public double CurrencyConvRate { get; set; }
        [Column("Trade_Currency")]
        public int? TradeCurrency { get; set; }
        [Required]
        [Column("Fixed_Rate")]
        public bool? FixedRate { get; set; }
        [Column("Trade_Date", TypeName = "datetime")]
        public DateTime? TradeDate { get; set; }
        [Column("Commission_Pct")]
        public double? CommissionPct { get; set; }
        [Column("Customer_PO")]
        [StringLength(20)]
        public string CustomerPo { get; set; }
        [Column("Customer_PO_LN")]
        [StringLength(6)]
        public string CustomerPoLn { get; set; }
        [Column("Sched_End", TypeName = "datetime")]
        public DateTime? SchedEnd { get; set; }
        [Column("Sched_Start", TypeName = "datetime")]
        public DateTime? SchedStart { get; set; }
        [Column("Quantity_Per")]
        public double? QuantityPer { get; set; }
        [Column("Profit_Pct")]
        public double? ProfitPct { get; set; }
        [Column("Labor_Markup_Pct")]
        public double LaborMarkupPct { get; set; }
        [Column("Mat_Markup_Pct")]
        public double MatMarkupPct { get; set; }
        [Column("Serv_Markup_Pct")]
        public double ServMarkupPct { get; set; }
        [Column("Labor_Burden_Markup_Pct")]
        public double LaborBurdenMarkupPct { get; set; }
        [Column("Machine_Burden_Markup_Pct")]
        public double MachineBurdenMarkupPct { get; set; }
        [Column("GA_Burden_Markup_Pct")]
        public double GaBurdenMarkupPct { get; set; }
        [Column("Lead_Days")]
        public short? LeadDays { get; set; }
        [Column("Profit_Markup")]
        [StringLength(1)]
        public string ProfitMarkup { get; set; }
        [Column("Prepaid_Amt", TypeName = "money")]
        public decimal? PrepaidAmt { get; set; }
        [Column("Split_To_Job")]
        public bool SplitToJob { get; set; }
        [Column("Note_Text", TypeName = "text")]
        public string NoteText { get; set; }
        [Column(TypeName = "text")]
        public string Comment { get; set; }
        [Column("Last_Updated", TypeName = "datetime")]
        public DateTime LastUpdated { get; set; }
        [Column("Order_Unit")]
        [StringLength(4)]
        public string OrderUnit { get; set; }
        [Column("Price_Unit_Conv")]
        public double? PriceUnitConv { get; set; }
        [Column("Holder_ID")]
        [StringLength(50)]
        public string HolderId { get; set; }
        [StringLength(20)]
        public string Source { get; set; }
        [Column("Order_Taken_By")]
        [StringLength(50)]
        public string OrderTakenBy { get; set; }
        [Column("Plan_Modified")]
        public bool? PlanModified { get; set; }
        [Column("ObjectID")]
        public Guid ObjectId { get; set; }
        [Column("Released_Date", TypeName = "datetime")]
        public DateTime? ReleasedDate { get; set; }
        [Column("Prepaid_Tax_Amount", TypeName = "money")]
        public decimal? PrepaidTaxAmount { get; set; }
        [Column("Prepaid_Trade_Amt", TypeName = "money")]
        public decimal? PrepaidTradeAmt { get; set; }
        [Column("Last_Updated_By")]
        [StringLength(50)]
        public string LastUpdatedBy { get; set; }
        public bool CommissionIncluded { get; set; }
    }
}
