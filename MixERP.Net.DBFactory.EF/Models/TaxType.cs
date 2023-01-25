using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class TaxType
{
    public int TaxTypeId { get; set; }

    public string TaxTypeCode { get; set; } = null!;

    public string TaxTypeName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<Taxis> Taxes { get; } = new List<Taxis>();
}
