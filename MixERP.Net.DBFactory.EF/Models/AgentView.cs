using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class AgentView
{
    public int? AgentId { get; set; }

    public string? AgentCode { get; set; }

    public string? AgentName { get; set; }

    public string? Address { get; set; }

    public string? ContactNumber { get; set; }

    public decimal? CommissionRate { get; set; }

    public string? AccountName { get; set; }
}
