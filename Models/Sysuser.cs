using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Sysuser
{
    public int Id { get; set; }

    public int Sysroleid { get; set; }

    public string? Login { get; set; }

    public string? PasswordHash { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();

    public virtual ICollection<Sysoperator> Sysoperators { get; set; } = new List<Sysoperator>();

    public virtual Sysrole Sysrole { get; set; } = null!;
}
