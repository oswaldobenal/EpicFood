using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Combo
{
    public int ComId { get; set; }

    public int? EstId { get; set; }

    public int? ProId { get; set; }

    public int? ProProId { get; set; }

    public string ComNombre { get; set; }

    public string ComDescripcion { get; set; }

    public double? ComPrecio { get; set; }

    public int? ComCantidad { get; set; }

    public DateTime? ComFecha { get; set; }

    public virtual ICollection<CabeceraFactura> CabeceraFacturas { get; set; } = new List<CabeceraFactura>();

    public virtual Estado Est { get; set; }

    public virtual Prod Pro { get; set; }

    public virtual Prod ProPro { get; set; }
}
