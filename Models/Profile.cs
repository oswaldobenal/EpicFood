using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Profile
{
    public int FileId { get; set; }

    public int? PerId { get; set; }

    public int? EstId { get; set; }

    public string? FileNombre { get; set; }

    public string? FileCallep { get; set; }

    public string? FileCalles { get; set; }

    public string? FileReferencia { get; set; }

    public string? FileLongi { get; set; }

    public string? FileLati { get; set; }

    public virtual ICollection<CabeceraFactura> CabeceraFacturas { get; set; } = new List<CabeceraFactura>();

    public virtual Estado? Est { get; set; }

    public virtual Persona? Per { get; set; }
}
