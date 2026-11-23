using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Dayweek
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
}
