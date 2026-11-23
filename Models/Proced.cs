using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Proced
{
    public int Id { get; set; }

    public DateOnly Pdate { get; set; }

    public int Caseofid { get; set; }

    public int Empid { get; set; }

    public virtual Caseof Caseof { get; set; } = null!;

    public virtual Emp Emp { get; set; } = null!;
}
