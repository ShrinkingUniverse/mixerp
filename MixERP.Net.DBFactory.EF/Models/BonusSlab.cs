using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class BonusSlab
{
    public int BonusSlabId { get; set; }

    public string BonusSlabCode { get; set; } = null!;

    public string BonusSlabName { get; set; } = null!;

    public int CheckingFrequencyId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual ICollection<AgentBonusSetup> AgentBonusSetups { get; } = new List<AgentBonusSetup>();

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<BonusSlabDetail> BonusSlabDetails { get; } = new List<BonusSlabDetail>();

    public virtual Frequency CheckingFrequency { get; set; } = null!;
}
