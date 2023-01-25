using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class WorkCenterView
{
    public int? WorkCenterId { get; set; }

    public string? Office { get; set; }

    public string? WorkCenterCode { get; set; }

    public string? WorkCenterName { get; set; }
}
