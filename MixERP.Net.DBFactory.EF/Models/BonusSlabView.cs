using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class BonusSlabView
{
    public int? BonusSlabId { get; set; }

    public string? BonusSlabCode { get; set; }

    public string? BonusSlabName { get; set; }

    public int? CheckingFrequencyId { get; set; }

    public string? FrequencyName { get; set; }
}
