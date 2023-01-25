using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Counter
{
    public int CounterId { get; set; }

    public int StoreId { get; set; }

    public long CashRepositoryId { get; set; }

    public string CounterCode { get; set; } = null!;

    public string CounterName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual CashRepository CashRepository { get; set; } = null!;

    public virtual ICollection<Cashier> Cashiers { get; } = new List<Cashier>();

    public virtual Store Store { get; set; } = null!;
}
