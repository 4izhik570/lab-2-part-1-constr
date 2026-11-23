using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Sysoperator
{
    public int Id { get; set; }

    public int Sysuserid { get; set; }

    public virtual Sysuser Sysuser { get; set; } = null!;
}
