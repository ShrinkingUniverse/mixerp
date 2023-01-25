using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class StockMasterNonGlRelation
{
    public long StockMasterNonGlRelationId { get; set; }

    public long StockMasterId { get; set; }

    public long NonGlStockMasterId { get; set; }

    public virtual NonGlStockMaster NonGlStockMaster { get; set; } = null!;

    public virtual StockMaster StockMaster { get; set; } = null!;
}
