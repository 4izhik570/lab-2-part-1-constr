using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Maindiag
{
    public string Name { get; set; } = null!;

    public string Id { get; set; } = null!;

    public virtual ICollection<Visitschedule> Visitschedules { get; set; } = new List<Visitschedule>();
}
