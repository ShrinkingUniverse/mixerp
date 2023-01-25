using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Party
{
    public int PartyId { get; set; }

    public short PartyTypeId { get; set; }

    public string? PartyCode { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? PartyName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

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

    public string? PanNumber { get; set; }

    public string? SstNumber { get; set; }

    public string? CstNumber { get; set; }

    public bool? AllowCredit { get; set; }

    public short? MaximumCreditPeriod { get; set; }

    public decimal? MaximumCreditAmount { get; set; }

    public bool? ChargeInterest { get; set; }

    public decimal? InterestRate { get; set; }

    public int? InterestCompoundingFrequencyId { get; set; }

    public int AccountId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual User? AuditUser { get; set; }

    public virtual Frequency? InterestCompoundingFrequency { get; set; }

    public virtual ICollection<ItemCostPrice> ItemCostPrices { get; } = new List<ItemCostPrice>();

    public virtual ICollection<Item> Items { get; } = new List<Item>();

    public virtual ICollection<NonGlStockMaster> NonGlStockMasters { get; } = new List<NonGlStockMaster>();

    public virtual PartyType PartyType { get; set; } = null!;

    public virtual ICollection<ShippingAddress> ShippingAddresses { get; } = new List<ShippingAddress>();

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();
}
