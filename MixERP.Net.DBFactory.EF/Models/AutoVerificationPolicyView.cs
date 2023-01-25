using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AutoVerificationPolicyView
{
    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public bool? VerifySalesTransactions { get; set; }

    public decimal? SalesVerificationLimit { get; set; }

    public bool? VerifyPurchaseTransactions { get; set; }

    public decimal? PurchaseVerificationLimit { get; set; }

    public bool? VerifyGlTransactions { get; set; }

    public decimal? GlVerificationLimit { get; set; }

    public DateOnly? EffectiveFrom { get; set; }

    public DateOnly? EndsOn { get; set; }

    public bool? IsActive { get; set; }
}
