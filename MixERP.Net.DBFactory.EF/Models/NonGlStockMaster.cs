using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class NonGlStockMaster
{
    public long NonGlStockMasterId { get; set; }

    public DateOnly ValueDate { get; set; }

    public string Book { get; set; } = null!;

    public int? PartyId { get; set; }

    public short? PriceTypeId { get; set; }

    public DateTime TransactionTs { get; set; }

    public long LoginId { get; set; }

    public int UserId { get; set; }

    public int OfficeId { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? StatementReference { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual Login Login { get; set; } = null!;

    public virtual ICollection<NonGlStockDetail> NonGlStockDetails { get; } = new List<NonGlStockDetail>();

    public virtual ICollection<NonGlStockMasterRelation> NonGlStockMasterRelationOrderNonGlStockMasters { get; } = new List<NonGlStockMasterRelation>();

    public virtual ICollection<NonGlStockMasterRelation> NonGlStockMasterRelationQuotationNonGlStockMasters { get; } = new List<NonGlStockMasterRelation>();

    public virtual Office Office { get; set; } = null!;

    public virtual Party? Party { get; set; }

    public virtual PriceType? PriceType { get; set; }

    public virtual ICollection<StockMasterNonGlRelation> StockMasterNonGlRelations { get; } = new List<StockMasterNonGlRelation>();

    public virtual User User { get; set; } = null!;
}
