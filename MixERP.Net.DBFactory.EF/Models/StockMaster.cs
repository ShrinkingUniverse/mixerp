using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class StockMaster
{
    public long StockMasterId { get; set; }

    public long TransactionMasterId { get; set; }

    public int? PartyId { get; set; }

    public int? AgentId { get; set; }

    public short? PriceTypeId { get; set; }

    public bool IsCredit { get; set; }

    public long? ShipperId { get; set; }

    public long? ShippingAddressId { get; set; }

    public decimal ShippingCharge { get; set; }

    public int? StoreId { get; set; }

    public long? CashRepositoryId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual Agent? Agent { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual CashRepository? CashRepository { get; set; }

    public virtual Party? Party { get; set; }

    public virtual PriceType? PriceType { get; set; }

    public virtual Shipper? Shipper { get; set; }

    public virtual ShippingAddress? ShippingAddress { get; set; }

    public virtual ICollection<StockDetail> StockDetails { get; } = new List<StockDetail>();

    public virtual ICollection<StockMasterNonGlRelation> StockMasterNonGlRelations { get; } = new List<StockMasterNonGlRelation>();

    public virtual Store? Store { get; set; }

    public virtual TransactionMaster TransactionMaster { get; set; } = null!;
}
