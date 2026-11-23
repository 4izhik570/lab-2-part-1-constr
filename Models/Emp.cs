using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Emp
{
    public int Id { get; set; }

    public DateOnly CertDate { get; set; }

    public string Fio { get; set; } = null!;

    public int Areaid { get; set; }

    public int Categoryid { get; set; }

    public int Specid { get; set; }

    public int Sysuserid { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Proced> Proceds { get; set; } = new List<Proced>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual Spec Spec { get; set; } = null!;

    public virtual Sysuser Sysuser { get; set; } = null!;

    public virtual ICollection<Visitschedule> Visitschedules { get; set; } = new List<Visitschedule>();
}
