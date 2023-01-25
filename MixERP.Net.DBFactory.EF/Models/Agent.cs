using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Agent
{
    public int AgentId { get; set; }

    public string AgentCode { get; set; } = null!;

    public string AgentName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public decimal CommissionRate { get; set; }

    public int AccountId { get; set; }

    public int? AuditUserId { get; set; }

    public DateTime? AuditTs { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<AgentBonusSetup> AgentBonusSetups { get; } = new List<AgentBonusSetup>();

    public virtual User? AuditUser { get; set; }

    public virtual ICollection<StockMaster> StockMasters { get; } = new List<StockMaster>();
}
