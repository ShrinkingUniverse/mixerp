using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Cashier
{
    public long CashierId { get; set; }

    public int CounterId { get; set; }

    public int UserId { get; set; }

    public int AssignedByUserId { get; set; }

    public DateOnly TransactionDate { get; set; }

    public bool Closed { get; set; }

    public virtual User AssignedByUser { get; set; } = null!;

    public virtual Counter Counter { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
