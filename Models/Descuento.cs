using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Descuento
{
    public int DesId { get; set; }

    public int? EstId { get; set; }

    public string? DesTipo { get; set; }

    public string? DesValor { get; set; }

    public double? DesValornum { get; set; }

    public virtual ICollection<CabeceraFactura> CabeceraFacturas { get; set; } = new List<CabeceraFactura>();

    public virtual Estado? Est { get; set; }
}
