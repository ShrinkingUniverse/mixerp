using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class NonGlStockDetail
{
    public long NonGlStockDetailId { get; set; }

    public long NonGlStockMasterId { get; set; }

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

    public virtual NonGlStockMaster NonGlStockMaster { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
