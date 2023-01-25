using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AccountMaster
{
    public int AccountMasterId { get; set; }

    public string AccountMasterCode { get; set; } = null!;

    public string AccountMasterName { get; set; } = null!;

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
