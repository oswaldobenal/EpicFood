using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Vehiculo
{
    public int VhlId { get; set; }

    public int? PerId { get; set; }

    public int? EstId { get; set; }

    public string? VhlPlaca { get; set; }

    public string? VhlTipo { get; set; }

    public virtual Estado? Est { get; set; }

    public virtual Persona? Per { get; set; }
}
