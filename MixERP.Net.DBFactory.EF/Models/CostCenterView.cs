using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class CostCenterView
{
    public int? CostCenterId { get; set; }

    public string? CostCenterCode { get; set; }

    public string? CostCenterName { get; set; }
}
