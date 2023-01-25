using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class TrialBalanceView
{
    public string? GetAccountName { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }
}
