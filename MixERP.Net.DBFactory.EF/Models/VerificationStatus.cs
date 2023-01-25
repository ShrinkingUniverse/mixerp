using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class VerificationStatus
{
    public short VerificationStatusId { get; set; }

    public string VerificationStatusName { get; set; } = null!;

    public virtual ICollection<TransactionMaster> TransactionMasters { get; } = new List<TransactionMaster>();
}
