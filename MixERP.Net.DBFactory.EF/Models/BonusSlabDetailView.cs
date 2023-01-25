using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class BonusSlabDetailView
{
    public int? BonusSlabDetailId { get; set; }

    public int? BonusSlabId { get; set; }

    public string? SlabName { get; set; }

    public decimal? AmountFrom { get; set; }

    public decimal? AmountTo { get; set; }

    public decimal? BonusRate { get; set; }
}
