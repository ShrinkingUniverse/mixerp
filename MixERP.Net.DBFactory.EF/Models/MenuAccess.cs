using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class MenuAccess
{
    public long AccessId { get; set; }

    public int OfficeId { get; set; }

    public int MenuId { get; set; }

    public int? UserId { get; set; }

    public virtual Menu Menu { get; set; } = null!;

    public virtual Office Office { get; set; } = null!;

    public virtual User? User { get; set; }
}
