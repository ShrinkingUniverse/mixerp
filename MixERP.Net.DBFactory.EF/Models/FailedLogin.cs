using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class FailedLogin
{
    public long FailedLoginId { get; set; }

    public int? UserId { get; set; }

    public string UserName { get; set; } = null!;

    public int? OfficeId { get; set; }

    public string Browser { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public DateTime FailedDateTime { get; set; }

    public string RemoteUser { get; set; } = null!;

    public string? Details { get; set; }

    public virtual Office? Office { get; set; }

    public virtual User? User { get; set; }
}
