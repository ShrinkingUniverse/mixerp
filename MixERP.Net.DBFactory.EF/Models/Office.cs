using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Office
{
    public int OfficeId { get; set; }

    public string OfficeCode { get; set; } = null!;

    public string OfficeName { get; set; } = null!;

    public string? NickName { get; set; }

    public DateOnly RegistrationDate { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public string? RegistrationNumber { get; set; }

    public string? PanNumber { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public int? ParentOfficeId { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<CashRepository> CashRepositories { get; } = new List<CashRepository>();

    public virtual Currency CurrencyCodeNavigation { get; set; } = null!;

    public virtual ICollection<FailedLogin> FailedLogins { get; } = new List<FailedLogin>();

    public virtual ICollection<Office> InverseParentOffice { get; } = new List<Office>();

    public virtual ICollection<Login> Logins { get; } = new List<Login>();

    public virtual ICollection<MenuAccess> MenuAccesses { get; } = new List<MenuAccess>();

    public virtual ICollection<MenuPolicy> MenuPolicies { get; } = new List<MenuPolicy>();

    public virtual ICollection<NonGlStockMaster> NonGlStockMasters { get; } = new List<NonGlStockMaster>();

    public virtual Office? ParentOffice { get; set; }

    public virtual ICollection<Store> Stores { get; } = new List<Store>();

    public virtual ICollection<TransactionMaster> TransactionMasters { get; } = new List<TransactionMaster>();

    public virtual ICollection<User> Users { get; } = new List<User>();

    public virtual ICollection<WorkCenter> WorkCenters { get; } = new List<WorkCenter>();
}
