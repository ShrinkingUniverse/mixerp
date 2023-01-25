using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleCode { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public bool IsAdmin { get; set; }

    public bool IsSystem { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<MenuPolicy> MenuPolicies { get; } = new List<MenuPolicy>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
