using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Caseof
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public int Typecaseid { get; set; }

    public int Visitscheduleid { get; set; }

    public virtual ICollection<Proced> Proceds { get; set; } = new List<Proced>();

    public virtual Typecase Typecase { get; set; } = null!;

    public virtual Visitschedule Visitschedule { get; set; } = null!;
}
