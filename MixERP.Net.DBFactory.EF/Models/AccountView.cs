using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AccountView
{
    public int? AccountId { get; set; }

    public string? AccountMasterCode { get; set; }

    public string? AccountCode { get; set; }

    public string? ExternalCode { get; set; }

    public string? AccountName { get; set; }

    public bool? Confidential { get; set; }

    public string? Description { get; set; }

    public bool? SysType { get; set; }

    public bool? IsCash { get; set; }

    public string? Parent { get; set; }

    public bool? HasChild { get; set; }
}
