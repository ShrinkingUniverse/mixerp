using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public int ItemGroupId { get; set; }

    public int BrandId { get; set; }

    public int PreferredSupplierId { get; set; }

    public int LeadTimeInDays { get; set; }

    public int UnitId { get; set; }

    public bool HotItem { get; set; }

    public decimal CostPrice { get; set; }

    public bool CostPriceIncludesTax { get; set; }

    public decimal SellingPrice { get; set; }

    public bool SellingPriceIncludesTax { get; set; }

    public int TaxId { get; set; }

    public int ReorderLevel { get; set; }

    public string? ItemImage { get; set; }

    public bool? MaintainStock { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<ItemCostPrice> ItemCostPrices { get; } = new List<ItemCostPrice>();

    public virtual ItemGroup ItemGroup { get; set; } = null!;

    public virtual ICollection<ItemOpeningInventory> ItemOpeningInventories { get; } = new List<ItemOpeningInventory>();

    public virtual ICollection<ItemSellingPrice> ItemSellingPrices { get; } = new List<ItemSellingPrice>();

    public virtual ICollection<NonGlStockDetail> NonGlStockDetails { get; } = new List<NonGlStockDetail>();

    public virtual Party PreferredSupplier { get; set; } = null!;

    public virtual ICollection<StockDetail> StockDetails { get; } = new List<StockDetail>();

    public virtual Taxis Tax { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
