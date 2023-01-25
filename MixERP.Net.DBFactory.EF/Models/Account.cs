using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public int AccountMasterId { get; set; }

    public string AccountCode { get; set; } = null!;

    public string? ExternalCode { get; set; }

    public bool Confidential { get; set; }

    public string AccountName { get; set; } = null!;

    public string? Description { get; set; }

    public bool SysType { get; set; }

    public bool IsCash { get; set; }

    public int? ParentAccountId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual AccountMaster AccountMaster { get; set; } = null!;

    public virtual ICollection<AccountParameter> AccountParameters { get; } = new List<AccountParameter>();

    public virtual ICollection<Agent> Agents { get; } = new List<Agent>();

    public virtual User? AuditUser { get; set; }

    public virtual BankAccount? BankAccount { get; set; }

    public virtual ICollection<Account> InverseParentAccount { get; } = new List<Account>();

    public virtual Account? ParentAccount { get; set; }

    public virtual ICollection<Party> Parties { get; } = new List<Party>();

    public virtual ICollection<Shipper> Shippers { get; } = new List<Shipper>();

    public virtual ICollection<Taxis> Taxes { get; } = new List<Taxis>();

    public virtual ICollection<TransactionDetail> TransactionDetails { get; } = new List<TransactionDetail>();
}
