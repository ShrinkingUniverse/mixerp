using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class LockOut
{
    public long LockOutId { get; set; }

    public int UserId { get; set; }

    public DateTime LockOutTime { get; set; }

    public DateTime LockOutTill { get; set; }

    public virtual User User { get; set; } = null!;
}
