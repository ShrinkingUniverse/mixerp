using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Unit
{
    public int UnitId { get; set; }

    public string UnitCode { get; set; } = null!;

    public string UnitName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<CompoundUnit> CompoundUnitBaseUnits { get; } = new List<CompoundUnit>();

    public virtual ICollection<CompoundUnit> CompoundUnitCompareUnits { get; } = new List<CompoundUnit>();

    public virtual ICollection<ItemCostPrice> ItemCostPrices { get; } = new List<ItemCostPrice>();

    public virtual ICollection<ItemOpeningInventory> ItemOpeningInventoryBaseUnits { get; } = new List<ItemOpeningInventory>();

    public virtual ICollection<ItemOpeningInventory> ItemOpeningInventoryUnits { get; } = new List<ItemOpeningInventory>();

    public virtual ICollection<ItemSellingPrice> ItemSellingPrices { get; } = new List<ItemSellingPrice>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual ICollection<NonGlStockDetail> NonGlStockDetailBaseUnits { get; } = new List<NonGlStockDetail>();

    public virtual ICollection<NonGlStockDetail> NonGlStockDetailUnits { get; } = new List<NonGlStockDetail>();

    public virtual ICollection<StockDetail> StockDetailBaseUnits { get; } = new List<StockDetail>();

    public virtual ICollection<StockDetail> StockDetailUnits { get; } = new List<StockDetail>();
}
