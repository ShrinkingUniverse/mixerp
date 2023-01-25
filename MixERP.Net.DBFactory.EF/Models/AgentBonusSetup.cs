using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AgentBonusSetup
{
    public int AgentBonusSetupId { get; set; }

    public int AgentId { get; set; }

    public int BonusSlabId { get; set; }

    public virtual Agent Agent { get; set; } = null!;

    public virtual BonusSlab BonusSlab { get; set; } = null!;
}
