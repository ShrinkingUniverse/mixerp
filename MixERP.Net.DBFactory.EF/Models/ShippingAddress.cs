using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class ShippingAddress
{
    public long ShippingAddressId { get; set; }

    public string ShippingAddressCode { get; set; } = null!;

    public int PartyId { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? Street { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Party Party { get; set; } = null!;

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();
}
