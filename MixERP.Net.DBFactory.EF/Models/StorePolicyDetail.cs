using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class StorePolicyDetail
{
    public long StorePolicyDetailId { get; set; }

    public long StorePolicyId { get; set; }

    public int UserId { get; set; }

    public int StoreId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Store Store { get; set; } = null!;

    public virtual StorePolicy StorePolicy { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
