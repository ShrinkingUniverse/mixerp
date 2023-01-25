using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class CompoundUnit
{
    public int CompoundUnitId { get; set; }

    public int BaseUnitId { get; set; }

    public short Value { get; set; }

    public int CompareUnitId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Unit BaseUnit { get; set; } = null!;

    public virtual Unit CompareUnit { get; set; } = null!;
}
