using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class StoreView
{
    public int? StoreId { get; set; }

    public int? OfficeId { get; set; }

    public string? StoreCode { get; set; }

    public string? StoreName { get; set; }

    public string? Address { get; set; }

    public int? StoreTypeId { get; set; }

    public bool? AllowSales { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }
}
