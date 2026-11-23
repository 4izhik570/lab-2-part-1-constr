using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Area
{
    public int Id { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();
}
