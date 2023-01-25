using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class History
{
    public long ActivityId { get; set; }

    public DateTime EventTs { get; set; }

    public string PrincipalUser { get; set; } = null!;

    public int? UserId { get; set; }

    public string Type { get; set; } = null!;

    public string TableSchema { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public string PrimaryKeyId { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string? OldVal { get; set; }

    public string? NewVal { get; set; }

    public virtual User? User { get; set; }
}
