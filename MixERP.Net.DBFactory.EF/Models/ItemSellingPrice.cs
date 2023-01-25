using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class ItemSellingPrice
{
    public long ItemSellingPriceId { get; set; }

    public int ItemId { get; set; }

    public int UnitId { get; set; }

    public short? PartyTypeId { get; set; }

    public short? PriceTypeId { get; set; }

    public bool IncludesTax { get; set; }

    public decimal Price { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual PartyType? PartyType { get; set; }

    public virtual PriceType? PriceType { get; set; }

    public virtual Unit Unit { get; set; } = null!;
}
