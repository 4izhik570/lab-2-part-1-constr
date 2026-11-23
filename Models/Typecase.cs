using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Typecase
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Caseof> Caseofs { get; set; } = new List<Caseof>();
}
