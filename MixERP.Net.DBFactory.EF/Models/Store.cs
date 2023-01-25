using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Store
{
    public int StoreId { get; set; }

    public int OfficeId { get; set; }

    public string StoreCode { get; set; } = null!;

    public string StoreName { get; set; } = null!;

    public string? Address { get; set; }

    public int StoreTypeId { get; set; }

    public bool? AllowSales { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<Counter> Counters { get; } = new List<Counter>();

    public virtual ICollection<ItemOpeningInventory> ItemOpeningInventories { get; } = new List<ItemOpeningInventory>();

    public virtual Office Office { get; set; } = null!;

    public virtual ICollection<StockDetail> StockDetails { get; } = new List<StockDetail>();

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();

    public virtual ICollection<StorePolicyDetail> StorePolicyDetails { get; } = new List<StorePolicyDetail>();

    public virtual StoreType StoreType { get; set; } = null!;
}
