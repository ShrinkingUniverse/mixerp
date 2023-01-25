using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class MenuLocale
{
    public int MenuLocaleId { get; set; }

    public int MenuId { get; set; }

    public string Culture { get; set; } = null!;

    public string MenuText { get; set; } = null!;

    public virtual Menu Menu { get; set; } = null!;
}
