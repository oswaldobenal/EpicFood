using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Rol
{
    public int RolId { get; set; }

    public int? EstId { get; set; }

    public string RolTipo { get; set; }

    public virtual Estado Est { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
