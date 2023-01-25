using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class CashRepository
{
    public long CashRepositoryId { get; set; }

    public int OfficeId { get; set; }

    public string CashRepositoryCode { get; set; } = null!;

    public string CashRepositoryName { get; set; } = null!;

    public long? ParentCashRepositoryId { get; set; }

    public string? Description { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<Counter> Counters { get; } = new List<Counter>();

    public virtual ICollection<CashRepository> InverseParentCashRepository { get; } = new List<CashRepository>();

    public virtual Office Office { get; set; } = null!;

    public virtual CashRepository? ParentCashRepository { get; set; }

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();

    public virtual ICollection<TransactionDetail> TransactionDetails { get; } = new List<TransactionDetail>();
}
