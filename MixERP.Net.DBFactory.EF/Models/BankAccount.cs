using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class BankAccount
{
    public int AccountId { get; set; }

    public int MaintainedByUserId { get; set; }

    public string BankName { get; set; } = null!;

    public string BankBranch { get; set; } = null!;

    public string? BankContactNumber { get; set; }

    public string? BankAddress { get; set; }

    public string? BankAccountCode { get; set; }

    public string? BankAccountType { get; set; }

    public string? RelationshipOfficerName { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual User? AuditUser { get; set; }

    public virtual User MaintainedByUser { get; set; } = null!;
}
