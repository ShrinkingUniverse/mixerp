using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class WorkCenter
{
    public int WorkCenterId { get; set; }

    public int OfficeId { get; set; }

    public string WorkCenterCode { get; set; } = null!;

    public string WorkCenterName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Office Office { get; set; } = null!;
}
