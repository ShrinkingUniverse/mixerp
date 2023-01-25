using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class UnitView
{
    public int? UnitId { get; set; }

    public string? UnitCode { get; set; }

    public string? UnitName { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }
}
