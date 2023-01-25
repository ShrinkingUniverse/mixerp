using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class StoreType
{
    public int StoreTypeId { get; set; }

    public string StoreTypeCode { get; set; } = null!;

    public string StoreTypeName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<Store> Stores { get; } = new List<Store>();
}
