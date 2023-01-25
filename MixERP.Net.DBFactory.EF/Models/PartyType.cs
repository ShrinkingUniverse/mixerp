using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class PartyType
{
    public short PartyTypeId { get; set; }

    public string PartyTypeCode { get; set; } = null!;

    public string PartyTypeName { get; set; } = null!;

    public bool IsSupplier { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<ItemSellingPrice> ItemSellingPrices { get; } = new List<ItemSellingPrice>();

    public virtual ICollection<Party> Parties { get; } = new List<Party>();
}
