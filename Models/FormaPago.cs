using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class FormaPago
{
    public int FormaId { get; set; }

    public int? EstId { get; set; }

    public int? PerId { get; set; }

    public string? FormaTipoT { get; set; }

    public string? FormaNumT { get; set; }

    public DateTime? FormaFechaCad { get; set; }

    public string? FormaCodSeg { get; set; }

    public string? FormaNom { get; set; }

    public string? FormaApellido { get; set; }

    public virtual ICollection<CabeceraFactura> CabeceraFacturas { get; set; } = new List<CabeceraFactura>();

    public virtual Estado? Est { get; set; }

    public virtual Persona? Per { get; set; }
}
