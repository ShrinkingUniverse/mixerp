using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class StockDetail
{
    public long StockMasterDetailId { get; set; }

    public long StockMasterId { get; set; }

    public string TranType { get; set; } = null!;

    public int? StoreId { get; set; }

    public int ItemId { get; set; }

    public int Quantity { get; set; }

    public int UnitId { get; set; }

    public decimal BaseQuantity { get; set; }

    public int BaseUnitId { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal TaxRate { get; set; }

    public decimal Tax { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Unit BaseUnit { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual StockMaster StockMaster { get; set; } = null!;

    public virtual Store? Store { get; set; }

    public virtual Unit Unit { get; set; } = null!;
}
