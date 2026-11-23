using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public TimeOnly? Workfrom { get; set; }

    public TimeOnly? Workto { get; set; }

    public int Statusid { get; set; }

    public int Empid { get; set; }

    public int Dayweekid { get; set; }

    public virtual Dayweek Dayweek { get; set; } = null!;

    public virtual Emp Emp { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual ICollection<Visitschedule> Visitschedules { get; set; } = new List<Visitschedule>();
}
