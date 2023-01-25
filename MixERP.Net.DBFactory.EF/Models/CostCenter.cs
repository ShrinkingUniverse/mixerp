using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class CostCenter
{
    public int CostCenterId { get; set; }

    public string CostCenterCode { get; set; } = null!;

    public string CostCenterName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<TransactionMaster> TransactionMasters { get; } = new List<TransactionMaster>();
}
