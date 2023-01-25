using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class StorePolicy
{
    public long StorePolicyId { get; set; }

    public int WrittenByUserId { get; set; }

    public bool Status { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<StorePolicyDetail> StorePolicyDetails { get; } = new List<StorePolicyDetail>();

    public virtual User WrittenByUser { get; set; } = null!;
}
