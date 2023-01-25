using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AgeingSlab
{
    public int AgeingSlabId { get; set; }

    public string AgeingSlabName { get; set; } = null!;

    public int FromDays { get; set; }

    public int ToDays { get; set; }
}
