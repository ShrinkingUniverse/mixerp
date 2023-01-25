using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class MenuPolicy
{
    public int PolicyId { get; set; }

    public int MenuId { get; set; }

    public int? OfficeId { get; set; }

    public bool InheritInChildOffices { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public string Scope { get; set; } = null!;

    public virtual Menu Menu { get; set; } = null!;

    public virtual Office? Office { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
