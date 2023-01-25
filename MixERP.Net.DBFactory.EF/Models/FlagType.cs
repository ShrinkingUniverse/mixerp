using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class FlagType
{
    public int FlagTypeId { get; set; }

    public string FlagTypeName { get; set; } = null!;

    public string BackgroundColor { get; set; } = null!;

    public string ForegroundColor { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<Flag> Flags { get; } = new List<Flag>();
}
