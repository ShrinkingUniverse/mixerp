using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class ItemGroup
{
    public int ItemGroupId { get; set; }

    public string ItemGroupCode { get; set; } = null!;

    public string ItemGroupName { get; set; } = null!;

    public bool ExcludeFromPurchase { get; set; }

    public bool ExcludeFromSales { get; set; }

    public int TaxId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual Taxis Tax { get; set; } = null!;
}
