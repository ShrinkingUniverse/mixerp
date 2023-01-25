using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class FiscalYear
{
    public string FiscalYearCode { get; set; } = null!;

    public string FiscalYearName { get; set; } = null!;

    public DateOnly StartsFrom { get; set; }

    public DateOnly EndsOn { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<FrequencySetup> FrequencySetups { get; } = new List<FrequencySetup>();
}
