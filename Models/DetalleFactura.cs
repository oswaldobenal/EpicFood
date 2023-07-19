using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class DetalleFactura
{
    public int DetId { get; set; }

    public int? CabeceraId { get; set; }

    public double? DetTotal { get; set; }

    public double? DetSubtotal { get; set; }

    public virtual CabeceraFactura? Cabecera { get; set; }
}
