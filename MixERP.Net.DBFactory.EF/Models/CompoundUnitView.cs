using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class CompoundUnitView
{
    public int? CompoundUnitId { get; set; }

    public string? BaseUnitName { get; set; }

    public short? Value { get; set; }

    public string? CompareUnitName { get; set; }
}
