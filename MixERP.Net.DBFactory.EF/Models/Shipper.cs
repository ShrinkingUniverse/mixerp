using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Shipper
{
    public long ShipperId { get; set; }

    public string? ShipperCode { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ShipperName { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Cell { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactAddressLine1 { get; set; }

    public string? ContactAddressLine2 { get; set; }

    public string? ContactStreet { get; set; }

    public string? ContactCity { get; set; }

    public string? ContactState { get; set; }

    public string? ContactCountry { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public string? ContactCell { get; set; }

    public string? FactoryAddress { get; set; }

    public string? PanNumber { get; set; }

    public string? SstNumber { get; set; }

    public string? CstNumber { get; set; }

    public int AccountId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();
}
