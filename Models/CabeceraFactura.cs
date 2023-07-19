using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class CabeceraFactura
{
    public int CabeceraId { get; set; }

    public int? PerId { get; set; }

    public int? ProId { get; set; }

    public int? ComId { get; set; }

    public int? SucId { get; set; }

    public int? DeliId { get; set; }

    public int? DesId { get; set; }

    public int? FileId { get; set; }

    public int? FormaId { get; set; }

    public virtual Combo Com { get; set; }

    public virtual TblDelivery Deli { get; set; }

    public virtual Descuento Des { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual Profile File { get; set; }

    public virtual FormaPago Forma { get; set; }

    public virtual Persona Per { get; set; }

    public virtual Prod Pro { get; set; }

    public virtual Sucursal Suc { get; set; }
}
