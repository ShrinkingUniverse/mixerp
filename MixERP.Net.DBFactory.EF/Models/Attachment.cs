using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Attachment
{
    public long AttachmentId { get; set; }

    public int UserId { get; set; }

    public string? Resource { get; set; }

    public string? ResourceKey { get; set; }

    public int? ResourceId { get; set; }

    public string OriginalFileName { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public DateTime AddedOn { get; set; }

    public virtual User User { get; set; } = null!;
}
