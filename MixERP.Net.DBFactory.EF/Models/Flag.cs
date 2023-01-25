using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Flag
{
    public long FlagId { get; set; }

    public int UserId { get; set; }

    public int FlagTypeId { get; set; }

    public string? Resource { get; set; }

    public string? ResourceKey { get; set; }

    public int? ResourceId { get; set; }

    public DateTime? FlaggedOn { get; set; }

    public virtual FlagType FlagType { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
