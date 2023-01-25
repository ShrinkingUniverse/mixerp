using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AgentBonusSetupView
{
    public int? AgentBonusSetupId { get; set; }

    public string? AgentName { get; set; }

    public string? BonusSlabName { get; set; }
}
