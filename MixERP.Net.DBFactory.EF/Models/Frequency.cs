using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class Frequency
{
    public int FrequencyId { get; set; }

    public string FrequencyCode { get; set; } = null!;

    public string FrequencyName { get; set; } = null!;

    public virtual ICollection<BonusSlab> BonusSlabs { get; } = new List<BonusSlab>();

    public virtual ICollection<FrequencySetup> FrequencySetups { get; } = new List<FrequencySetup>();

    public virtual ICollection<Party> Parties { get; } = new List<Party>();
}
