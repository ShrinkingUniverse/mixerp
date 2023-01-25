using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string MenuText { get; set; } = null!;

    public string? Url { get; set; }

    public string MenuCode { get; set; } = null!;

    public short Level { get; set; }

    public int? ParentMenuId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<Menu> InverseParentMenu { get; } = new List<Menu>();

    public virtual ICollection<MenuAccess> MenuAccesses { get; } = new List<MenuAccess>();

    public virtual ICollection<MenuLocale> MenuLocales { get; } = new List<MenuLocale>();

    public virtual ICollection<MenuPolicy> MenuPolicies { get; } = new List<MenuPolicy>();

    public virtual Menu? ParentMenu { get; set; }
}
