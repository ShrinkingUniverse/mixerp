using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class BonusSlabDetail
{
    public int BonusSlabDetailId { get; set; }

    public int BonusSlabId { get; set; }

    public decimal AmountFrom { get; set; }

    public decimal AmountTo { get; set; }

    public decimal BonusRate { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual BonusSlab BonusSlab { get; set; } = null!;
}
