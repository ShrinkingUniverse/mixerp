using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class BankAccountView
{
    public int? AccountId { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? MaintainedBy { get; set; }

    public string? BankName { get; set; }

    public string? BankBranch { get; set; }

    public string? BankContactNumber { get; set; }

    public string? BankAddress { get; set; }

    public string? BankAccountCode { get; set; }

    public string? BankAccountType { get; set; }

    public string? RelationOfficer { get; set; }
}
