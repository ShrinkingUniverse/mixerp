using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AutoVerificationPolicy
{
    public int UserId { get; set; }

    public bool VerifySalesTransactions { get; set; }

    public decimal SalesVerificationLimit { get; set; }

    public bool VerifyPurchaseTransactions { get; set; }

    public decimal PurchaseVerificationLimit { get; set; }

    public bool VerifyGlTransactions { get; set; }

    public decimal GlVerificationLimit { get; set; }

    public DateOnly EffectiveFrom { get; set; }

    public DateOnly EndsOn { get; set; }

    public bool IsActive { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual User User { get; set; } = null!;
}
