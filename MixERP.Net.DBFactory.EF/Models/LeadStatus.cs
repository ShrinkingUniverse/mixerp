using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class LeadStatus
{
    public int LeadStatusId { get; set; }

    public string LeadStatusCode { get; set; } = null!;

    public string LeadStatusName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }
}
