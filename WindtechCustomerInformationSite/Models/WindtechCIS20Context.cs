using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WindtechCustomerInformationSite.Models
{
    public partial class WindtechCIS20Context : DbContext
    {
        public WindtechCIS20Context()
        {
        }

        public WindtechCIS20Context(DbContextOptions<WindtechCIS20Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CustomerCode> CustomerCode { get; set; }
        public virtual DbSet<CustomerContact> CustomerContact { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MaterialCode> MaterialCode { get; set; }
        public virtual DbSet<MaterialLocation> MaterialLocation { get; set; }
        public virtual DbSet<MaterialReq> MaterialReq { get; set; }
        public virtual DbSet<PacklistMaster> PacklistMaster { get; set; }
        public virtual DbSet<ParteEmail> ParteEmail { get; set; }
        public virtual DbSet<UserValues> UserValues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=Dataserver;Database=WindtechCIS20;user id=sa;password=Shaka+Venado;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");
            });

            modelBuilder.Entity<CustomerCode>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Customercode1)
                    .HasName("IX_CustomerCode_1");

                entity.HasIndex(e => e.User)
                    .HasName("IX_CustomerCode");

                entity.Property(e => e.Customercode1).IsUnicode(false);

                entity.Property(e => e.User).IsUnicode(false);
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Customer).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasKey(e => e.DeliveryKey)
                    .HasName("PK_DeliveryKey")
                    .IsClustered(false);

                entity.HasIndex(e => e.CrMemo);

                entity.HasIndex(e => e.Delivery1)
                    .IsUnique()
                    .HasFilter("([Delivery] IS NOT NULL)");

                entity.HasIndex(e => e.Invoice);

                entity.HasIndex(e => e.JobOid);

                entity.HasIndex(e => e.ObjectId)
                    .IsUnique();

                entity.HasIndex(e => e.Packlist);

                entity.HasIndex(e => e.SoDetail)
                    .HasName("IX_Delivery_SODetail");

                entity.HasIndex(e => new { e.Job, e.PromisedDate })
                    .HasName("IX_Delivery_Job")
                    .IsClustered();

                entity.Property(e => e.CrMemo).IsUnicode(false);

                entity.Property(e => e.CrMemoLine).IsUnicode(false);

                entity.Property(e => e.Invoice).IsUnicode(false);

                entity.Property(e => e.InvoiceLine).IsUnicode(false);

                entity.Property(e => e.Job).IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.NcpQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Packlist).IsUnicode(false);

                entity.Property(e => e.RemainingQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnDocument).IsUnicode(false);

                entity.Property(e => e.ReturnedQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShippedQuantity).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => e.Job1)
                    .IsClustered(false);

                entity.HasIndex(e => e.Customer);

                entity.HasIndex(e => e.CustomerPo)
                    .HasName("IX_JOB_CUSTOMERPO");

                entity.HasIndex(e => e.ObjectId)
                    .IsUnique();

                entity.HasIndex(e => e.PartNumber);

                entity.HasIndex(e => e.Status)
                    .IsClustered();

                entity.HasIndex(e => e.TopLvlJob)
                    .HasName("IX_Job_TopLvlJob");

                entity.HasIndex(e => e.UserValues);

                entity.HasIndex(e => new { e.Status, e.AssemblyLevel })
                    .HasName("IX_Job_StAssem");

                entity.HasIndex(e => new { e.Status, e.Customer })
                    .HasName("IX_Job_StCust");

                entity.HasIndex(e => new { e.Status, e.Type })
                    .HasName("IX_Job_StType");

                entity.HasIndex(e => new { e.Job1, e.TopLvlJob, e.PartNumber, e.CustomerPo, e.CustomerPoLn, e.UserValues })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.Property(e => e.Job1).IsUnicode(false);

                entity.Property(e => e.ActGaBurden).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActLabor).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActLaborBurden).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActMachineBurden).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActMaterial).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActRevenue).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActScrapQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActService).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActTotalHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.AssemblyLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommissionPct).HasDefaultValueSql("((0))");

                entity.Property(e => e.CompletedQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyConvRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Customer).IsUnicode(false);

                entity.Property(e => e.CustomerPo).IsUnicode(false);

                entity.Property(e => e.CustomerPoLn).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Drawing).IsUnicode(false);

                entity.Property(e => e.EstGaBurden).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstLabor).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstLaborBurden).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstMachineBurden).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstMaterial).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstRemHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstScrapQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstService).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstTotalHrs).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExtraQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.FgTransferQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.HolderId).IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.LeadDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenOperations).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderTakenBy).IsUnicode(false);

                entity.Property(e => e.OrderUnit).IsUnicode(false);

                entity.Property(e => e.PartNumber).IsUnicode(false);

                entity.Property(e => e.PickQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepaidAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepaidTaxAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrepaidTradeAmt).HasDefaultValueSql("((0))");

                entity.Property(e => e.PriceUnitConv).HasDefaultValueSql("((1))");

                entity.Property(e => e.PriceUofM).IsUnicode(false);

                entity.Property(e => e.Priority).HasDefaultValueSql("((5))");

                entity.Property(e => e.ProfitMarkup).IsUnicode(false);

                entity.Property(e => e.ProfitPct).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityPer).HasDefaultValueSql("((1))");

                entity.Property(e => e.Quote).IsUnicode(false);

                entity.Property(e => e.ReturnedQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rev).IsUnicode(false);

                entity.Property(e => e.SalesCode).IsUnicode(false);

                entity.Property(e => e.SalesRep).IsUnicode(false);

                entity.Property(e => e.ShipVia).IsUnicode(false);

                entity.Property(e => e.ShippedQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.SplitQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TaxCode).IsUnicode(false);

                entity.Property(e => e.Terms).IsUnicode(false);

                entity.Property(e => e.TopLvlJob).IsUnicode(false);

                entity.Property(e => e.TotalPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasKey(e => e.Material1)
                    .IsClustered(false);

                entity.HasIndex(e => e.Class);

                entity.HasIndex(e => e.ObjectId)
                    .IsUnique();

                entity.HasIndex(e => e.Shape);

                entity.HasIndex(e => e.ShapeOid);

                entity.HasIndex(e => e.StockItem);

                entity.HasIndex(e => e.Type)
                    .IsClustered();

                entity.HasIndex(e => e.UserValues);

                entity.Property(e => e.Material1).IsUnicode(false);

                entity.Property(e => e.AverageCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.CostUofM).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Drawing).IsUnicode(false);

                entity.Property(e => e.GlAccount).IsUnicode(false);

                entity.Property(e => e.HolderId).IsUnicode(false);

                entity.Property(e => e.Job).IsUnicode(false);

                entity.Property(e => e.LastCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationId).IsUnicode(false);

                entity.Property(e => e.MakeBuy).IsUnicode(false);

                entity.Property(e => e.MaxUsage).HasDefaultValueSql("((0))");

                entity.Property(e => e.OnOrderQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderPoint).HasDefaultValueSql("((0))");

                entity.Property(e => e.PickBuyIndicator).IsUnicode(false);

                entity.Property(e => e.PriceUnitConv).HasDefaultValueSql("((1))");

                entity.Property(e => e.PriceUofM).IsUnicode(false);

                entity.Property(e => e.PrimaryVendor).IsUnicode(false);

                entity.Property(e => e.PurchaseUofM).IsUnicode(false);

                entity.Property(e => e.Rev).IsUnicode(false);

                entity.Property(e => e.SalesCode).IsUnicode(false);

                entity.Property(e => e.SellingPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Shape).IsUnicode(false);

                entity.Property(e => e.ShelfLife).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShelfLifeUofM).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StockItem).IsUnicode(false);

                entity.Property(e => e.StockedUofM).IsUnicode(false);

                entity.Property(e => e.TaxCode).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.VendorReference).IsUnicode(false);
            });

            modelBuilder.Entity<MaterialCode>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Customercode).IsUnicode(false);

                entity.Property(e => e.Materialcode1).IsUnicode(false);
            });

            modelBuilder.Entity<MaterialLocation>(entity =>
            {
                entity.HasKey(e => e.MaterialLocationKey)
                    .IsClustered(false);

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_Material_Location_Location");

                entity.HasIndex(e => e.Material)
                    .IsClustered();

                entity.HasIndex(e => e.MaterialLocation1)
                    .IsUnique()
                    .HasFilter("([Material_Location] IS NOT NULL)");

                entity.HasIndex(e => e.ObjectId)
                    .IsUnique();

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationId).IsUnicode(false);

                entity.Property(e => e.Lot).IsUnicode(false);

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.UnitCost).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MaterialReq>(entity =>
            {
                entity.HasKey(e => e.MaterialReqKey)
                    .IsClustered(false);

                entity.HasIndex(e => e.Job)
                    .IsClustered();

                entity.HasIndex(e => e.JobOid);

                entity.HasIndex(e => e.JobOperation);

                entity.HasIndex(e => e.JobOperationOid);

                entity.HasIndex(e => e.Material);

                entity.HasIndex(e => e.MaterialOid)
                    .HasName("IX_Material_Req_Job_Material_OID");

                entity.HasIndex(e => e.MaterialReq1)
                    .IsUnique()
                    .HasFilter("([Material_Req] IS NOT NULL)");

                entity.HasIndex(e => e.ObjectId)
                    .IsUnique();

                entity.HasIndex(e => e.Type);

                entity.HasIndex(e => new { e.MaterialReq1, e.Material })
                    .HasName("IndiceIndex");

                entity.HasIndex(e => new { e.PickBuyIndicator, e.Status })
                    .HasName("IX_Material_Req_PBStatus");

                entity.Property(e => e.ActAddlCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActTotalCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActUnitCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.AddlCostDesc).IsUnicode(false);

                entity.Property(e => e.BarEnd).HasDefaultValueSql("((0))");

                entity.Property(e => e.BarLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.CostUofM).IsUnicode(false);

                entity.Property(e => e.CurrencyConvRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DrawingId).IsUnicode(false);

                entity.Property(e => e.EstAddlCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstTotalCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.EstUnitCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.Facing).HasDefaultValueSql("((0))");

                entity.Property(e => e.FixedRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.HolderId).IsUnicode(false);

                entity.Property(e => e.Job).IsUnicode(false);

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LeadDays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.PartLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.PickBuyIndicator).IsUnicode(false);

                entity.Property(e => e.QuantityPer).HasDefaultValueSql("((1))");

                entity.Property(e => e.QuantityPerBasis).IsUnicode(false);

                entity.Property(e => e.ResId).IsUnicode(false);

                entity.Property(e => e.Rounded).HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.UofM).IsUnicode(false);

                entity.Property(e => e.Vendor).IsUnicode(false);

                entity.Property(e => e.VendorReference).IsUnicode(false);
            });

            modelBuilder.Entity<PacklistMaster>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Bandera).IsUnicode(false);

                entity.Property(e => e.Invoice).IsUnicode(false);

                entity.Property(e => e.Packlist).IsUnicode(false);

                entity.Property(e => e.PacklistId).IsUnicode(false);

                entity.Property(e => e.Text1).IsUnicode(false);
            });

            modelBuilder.Entity<ParteEmail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.PartNumber).IsUnicode(false);
            });

            modelBuilder.Entity<UserValues>(entity =>
            {
                entity.HasKey(e => e.UserValuesKey)
                    .HasName("PK_User_ValuesKey")
                    .IsClustered(false);

                entity.HasIndex(e => e.UserValues1)
                    .IsUnique();

                entity.Property(e => e.Amount1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Amount2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Decimal1).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Numeric1).HasDefaultValueSql("((0))");

                entity.Property(e => e.Numeric2).HasDefaultValueSql("((0))");

                entity.Property(e => e.Text1).IsUnicode(false);

                entity.Property(e => e.Text2).IsUnicode(false);

                entity.Property(e => e.Text3).IsUnicode(false);

                entity.Property(e => e.Text4).IsUnicode(false);

                entity.Property(e => e.Text5).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
