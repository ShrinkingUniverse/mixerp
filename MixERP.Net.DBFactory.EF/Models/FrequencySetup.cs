using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class FrequencySetup
{
    public int FrequencySetupId { get; set; }

    public string FiscalYearCode { get; set; } = null!;

    public DateOnly ValueDate { get; set; }

    public int FrequencyId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual FiscalYear FiscalYearCodeNavigation { get; set; } = null!;

    public virtual Frequency Frequency { get; set; } = null!;
}
