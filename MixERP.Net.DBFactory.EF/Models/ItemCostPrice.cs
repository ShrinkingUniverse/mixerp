using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class ItemCostPrice
{
    public long ItemCostPriceId { get; set; }

    public int ItemId { get; set; }

    public DateTime EntryTs { get; set; }

    public int UnitId { get; set; }

    public int? PartyId { get; set; }

    public int LeadTimeInDays { get; set; }

    public bool IncludesTax { get; set; }

    public decimal Price { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Party? Party { get; set; }

    public virtual Unit Unit { get; set; } = null!;
}
