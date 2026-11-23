using System;
using System.Collections.Generic;

namespace Lab2_EF.Models;

public partial class Street
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Areaid { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
