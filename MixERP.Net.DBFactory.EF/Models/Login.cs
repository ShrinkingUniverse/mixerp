using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Login
{
    public long LoginId { get; set; }

    public int UserId { get; set; }

    public int OfficeId { get; set; }

    public string Browser { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public DateTime LoginDateTime { get; set; }

    public string RemoteUser { get; set; } = null!;

    public string Culture { get; set; } = null!;

    public virtual ICollection<NonGlStockMaster> NonGlStockMasters { get; } = new List<NonGlStockMaster>();

    public virtual Office Office { get; set; } = null!;

    public virtual ICollection<TransactionMaster> TransactionMasters { get; } = new List<TransactionMaster>();

    public virtual User User { get; set; } = null!;
}
