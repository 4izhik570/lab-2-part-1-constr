using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Sysrole
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Sysuser> Sysusers { get; set; } = new List<Sysuser>();
}
