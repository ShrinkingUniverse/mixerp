using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Taxis
{
    public int TaxId { get; set; }

    public int TaxTypeId { get; set; }

    public string TaxCode { get; set; } = null!;

    public string TaxName { get; set; } = null!;

    public decimal Rate { get; set; }

    public int AccountId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<ItemGroup> ItemGroups { get; } = new List<ItemGroup>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual TaxType TaxType { get; set; } = null!;
}
