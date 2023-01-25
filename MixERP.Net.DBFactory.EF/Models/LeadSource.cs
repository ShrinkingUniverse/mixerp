using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class LeadSource
{
    public int LeadSourceId { get; set; }

    public string LeadSourceCode { get; set; } = null!;

    public string LeadSourceName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }
}
