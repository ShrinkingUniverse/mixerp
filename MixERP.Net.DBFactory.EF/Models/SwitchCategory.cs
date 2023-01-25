using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class SwitchCategory
{
    public int SwitchCategoryId { get; set; }

    public string SwitchCategoryName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }
}
