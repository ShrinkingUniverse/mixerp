using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AccountsView
{
    public int? AccountId { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? Description { get; set; }

    public bool? SysType { get; set; }

    public int? ParentAccountId { get; set; }

    public string? ParentAccountCode { get; set; }

    public string? ParentAccountName { get; set; }

    public int? AccountMasterId { get; set; }

    public string? AccountMasterCode { get; set; }

    public string? AccountMasterName { get; set; }
}
