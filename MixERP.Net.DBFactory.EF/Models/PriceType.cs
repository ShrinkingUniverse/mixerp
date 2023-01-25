using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class PriceType
{
    public short PriceTypeId { get; set; }

    public string PriceTypeCode { get; set; } = null!;

    public string PriceTypeName { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<ItemSellingPrice> ItemSellingPrices { get; } = new List<ItemSellingPrice>();

    public virtual ICollection<NonGlStockMaster> NonGlStockMasters { get; } = new List<NonGlStockMaster>();

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();
}
