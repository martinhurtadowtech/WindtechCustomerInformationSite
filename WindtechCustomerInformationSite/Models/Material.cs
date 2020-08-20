using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindtechCustomerInformationSite.Models
{
    public partial class Material
    {
        [Key]
        [Column("Material")]
        [StringLength(30)]
        public string Material1 { get; set; }
        [Column("Primary_Vendor")]
        [StringLength(10)]
        public string PrimaryVendor { get; set; }
        [Column("User_Values")]
        public int? UserValues { get; set; }
        [StringLength(10)]
        public string Shape { get; set; }
        [Required]
        [Column("Location_ID")]
        [StringLength(10)]
        public string LocationId { get; set; }
        [Column("Sales_Code")]
        [StringLength(15)]
        public string SalesCode { get; set; }
        [StringLength(30)]
        public string Description { get; set; }
        [Required]
        [StringLength(1)]
        public string Type { get; set; }
        [Required]
        [StringLength(8)]
        public string Status { get; set; }
        [Required]
        [Column("Pick_Buy_Indicator")]
        [StringLength(1)]
        public string PickBuyIndicator { get; set; }
        [StringLength(10)]
        public string Class { get; set; }
        [StringLength(8)]
        public string Rev { get; set; }
        [Required]
        [Column("Stocked_UofM")]
        [StringLength(4)]
        public string StockedUofM { get; set; }
        [Required]
        [Column("Purchase_UofM")]
        [StringLength(4)]
        public string PurchaseUofM { get; set; }
        [Required]
        [Column("Cost_UofM")]
        [StringLength(4)]
        public string CostUofM { get; set; }
        [Required]
        [Column("Price_UofM")]
        [StringLength(4)]
        public string PriceUofM { get; set; }
        [Column("Selling_Price")]
        public double? SellingPrice { get; set; }
        [Column("Standard_Cost")]
        public double StandardCost { get; set; }
        [Column("Average_Cost")]
        public double? AverageCost { get; set; }
        [Column("Last_Cost")]
        public double? LastCost { get; set; }
        [Column("On_Order_Qty")]
        public double? OnOrderQty { get; set; }
        [Column("Order_Point")]
        public double? OrderPoint { get; set; }
        [Column("Reorder_Qty")]
        public double ReorderQty { get; set; }
        [Column("Lead_Days")]
        public short LeadDays { get; set; }
        [Column("UofM_Conv_Factor")]
        public double UofMConvFactor { get; set; }
        [Column("Lot_Trace")]
        public bool LotTrace { get; set; }
        [Column("Rd_Whole_Unit")]
        public bool RdWholeUnit { get; set; }
        [Column("Ext_Description", TypeName = "text")]
        public string ExtDescription { get; set; }
        [Required]
        [Column("Make_Buy")]
        [StringLength(1)]
        public string MakeBuy { get; set; }
        [Column("Vendor_Reference")]
        [StringLength(30)]
        public string VendorReference { get; set; }
        [StringLength(30)]
        public string Drawing { get; set; }
        [Column("Use_Price_Breaks")]
        public bool UsePriceBreaks { get; set; }
        [Column("Note_Text", TypeName = "text")]
        public string NoteText { get; set; }
        [Column("Last_Updated", TypeName = "datetime")]
        public DateTime LastUpdated { get; set; }
        [Column("GL_Account")]
        [StringLength(100)]
        public string GlAccount { get; set; }
        [Column("Price_Unit_Conv")]
        public double? PriceUnitConv { get; set; }
        [Column("Holder_ID")]
        [StringLength(50)]
        public string HolderId { get; set; }
        [StringLength(10)]
        public string Job { get; set; }
        [Column("Tax_Code")]
        [StringLength(15)]
        public string TaxCode { get; set; }
        public bool? Taxable { get; set; }
        [Column("IS_Length")]
        public double? IsLength { get; set; }
        [Column("IS_Width")]
        public double? IsWidth { get; set; }
        [Column("IS_Weight_Factor")]
        public double? IsWeightFactor { get; set; }
        [Column("IS_Thickness")]
        public double? IsThickness { get; set; }
        [Column("Stock_Item")]
        [StringLength(50)]
        public string StockItem { get; set; }
        [Column("Affects_Schedule")]
        public bool? AffectsSchedule { get; set; }
        [Column("ObjectID")]
        public Guid ObjectId { get; set; }
        [Column("Shape_OID")]
        public Guid? ShapeOid { get; set; }
        public bool? Tooling { get; set; }
        public bool IsSerialized { get; set; }
        public int? MaxUsage { get; set; }
        public double? ShelfLife { get; set; }
        [StringLength(10)]
        public string ShelfLifeUofM { get; set; }
    }
}
