using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class VoucherVerificationPolicyView
{
    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public bool? CanVerifySalesTransactions { get; set; }

    public decimal? SalesVerificationLimit { get; set; }

    public bool? CanVerifyPurchaseTransactions { get; set; }

    public decimal? PurchaseVerificationLimit { get; set; }

    public bool? CanVerifyGlTransactions { get; set; }

    public decimal? GlVerificationLimit { get; set; }

    public bool? CanSelfVerify { get; set; }

    public decimal? SelfVerificationLimit { get; set; }

    public DateOnly? EffectiveFrom { get; set; }

    public DateOnly? EndsOn { get; set; }

    public bool? IsActive { get; set; }
}
