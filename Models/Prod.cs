using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Prod
{
    public int ProId { get; set; }

    public int? EstId { get; set; }

    public string? ProProducto { get; set; }

    public string? ProDescripcionProducto { get; set; }

    public double? ProPrecio { get; set; }

    public int? ProCantidad { get; set; }

    public DateTime? ProFecha { get; set; }

    public virtual ICollection<CabeceraFactura> CabeceraFacturas { get; set; } = new List<CabeceraFactura>();

    public virtual ICollection<Combo> ComboProPros { get; set; } = new List<Combo>();

    public virtual ICollection<Combo> ComboPros { get; set; } = new List<Combo>();

    public virtual Estado? Est { get; set; }
}
