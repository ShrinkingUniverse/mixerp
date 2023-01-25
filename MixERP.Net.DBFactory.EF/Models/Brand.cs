using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string BrandCode { get; set; } = null!;

    public string BrandName { get; set; } = null!;

    public virtual ICollection<Item> Items { get; } = new List<Item>();
}
