using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class TransactionDetail
{
    public long TransactionDetailId { get; set; }

    public long TransactionMasterId { get; set; }

    public string TranType { get; set; } = null!;

    public int AccountId { get; set; }

    public string? StatementReference { get; set; }

    public long? CashRepositoryId { get; set; }

    public decimal Amount { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual User? AuditUser { get; set; }

    public virtual CashRepository? CashRepository { get; set; }

    public virtual TransactionMaster TransactionMaster { get; set; } = null!;
}
