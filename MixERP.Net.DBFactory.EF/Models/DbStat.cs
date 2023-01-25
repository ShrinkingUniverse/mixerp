using System;
using System.Collections.Generic;

namespace MixERP.Net.DBFactory.EF.Models;

public partial class DbStat
{
    public DateTime? LastVacuum { get; set; }

    public DateTime? LastAutovacuum { get; set; }

    public DateTime? LastAnalyze { get; set; }

    public DateTime? LastAutoanalyze { get; set; }

    public long? VacuumCount { get; set; }

    public long? AutovacuumCount { get; set; }

    public long? AnalyzeCount { get; set; }

    public long? AutoanalyzeCount { get; set; }
}
