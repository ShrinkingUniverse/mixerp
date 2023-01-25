using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class OpportunityStage
{
    public int OpportunityStageId { get; set; }

    public string OpportunityStageCode { get; set; } = null!;

    public string OpportunityStageName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }
}
