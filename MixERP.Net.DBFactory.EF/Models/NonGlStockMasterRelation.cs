using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class NonGlStockMasterRelation
{
    public long NonGlStockMasterRelationId { get; set; }

    public long OrderNonGlStockMasterId { get; set; }

    public long QuotationNonGlStockMasterId { get; set; }

    public virtual NonGlStockMaster OrderNonGlStockMaster { get; set; } = null!;

    public virtual NonGlStockMaster QuotationNonGlStockMaster { get; set; } = null!;
}
