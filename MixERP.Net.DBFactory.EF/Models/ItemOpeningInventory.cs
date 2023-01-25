using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class ItemOpeningInventory
{
    public long ItemOpeningInventoryId { get; set; }

    public DateTime EntryTs { get; set; }

    public int ItemId { get; set; }

    public int StoreId { get; set; }

    public int UnitId { get; set; }

    public int Quantity { get; set; }

    public decimal Amount { get; set; }

    public int BaseUnitId { get; set; }

    public decimal BaseQuantity { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Unit BaseUnit { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual Store Store { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
