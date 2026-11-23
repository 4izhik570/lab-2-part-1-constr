using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Spec
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public TimeOnly Vtime { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
