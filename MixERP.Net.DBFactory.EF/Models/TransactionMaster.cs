using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class TransactionMaster
{
    public long TransactionMasterId { get; set; }

    public int TransactionCounter { get; set; }

    public string TransactionCode { get; set; } = null!;

    public string Book { get; set; } = null!;

    public DateOnly ValueDate { get; set; }

    public DateTime TransactionTs { get; set; }

    public long LoginId { get; set; }

    public int UserId { get; set; }

    public int? SysUserId { get; set; }

    public int OfficeId { get; set; }

    public int? CostCenterId { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? StatementReference { get; set; }

    public DateTime? LastVerifiedOn { get; set; }

    public int? VerifiedByUserId { get; set; }

    public short VerificationStatusId { get; set; }

    public string VerificationReason { get; set; } = null!;

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual User? AuditUser { get; set; }

    public virtual CostCenter? CostCenter { get; set; }

    public virtual Login Login { get; set; } = null!;

    public virtual Office Office { get; set; } = null!;

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();

    public virtual User? SysUser { get; set; }

    public virtual ICollection<TransactionDetail> TransactionDetails { get; } = new List<TransactionDetail>();

    public virtual User User { get; set; } = null!;

    public virtual VerificationStatus VerificationStatus { get; set; } = null!;

    public virtual User? VerifiedByUser { get; set; }
}
