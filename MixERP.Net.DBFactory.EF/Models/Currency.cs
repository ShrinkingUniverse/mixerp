using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Currency
{
    public string CurrencyCode { get; set; } = null!;

    public string CurrencySymbol { get; set; } = null!;

    public string CurrencyName { get; set; } = null!;

    public string HundredthName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<Office> Offices { get; } = new List<Office>();
}
