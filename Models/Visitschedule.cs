using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Visitschedule
{
    public int Id { get; set; }

    public string Patientsnils { get; set; } = null!;

    public int Scheduleid { get; set; }

    public DateTime Vfrom { get; set; }

    public DateTime Vto { get; set; }

    public int Empid { get; set; }

    public string Maindiagid { get; set; } = null!;

    public virtual ICollection<Caseof> Caseofs { get; set; } = new List<Caseof>();

    public virtual Emp Emp { get; set; } = null!;

    public virtual Maindiag Maindiag { get; set; } = null!;

    public virtual Patient PatientsnilsNavigation { get; set; } = null!;

    public virtual Schedule Schedule { get; set; } = null!;
}
