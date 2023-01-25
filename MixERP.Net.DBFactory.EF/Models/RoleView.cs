using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class RoleView
{
    public int? RoleId { get; set; }

    public string? RoleCode { get; set; }

    public string? RoleName { get; set; }
}
