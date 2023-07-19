using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Sucursal
{
    public int SucId { get; set; }

    public int? EstId { get; set; }

    public int? EmpId { get; set; }

    public string? SucCallep { get; set; }

    public string? SucCalles { get; set; }

    public string? SucSector { get; set; }

    public virtual ICollection<CabeceraFactura> CabeceraFacturas { get; set; } = new List<CabeceraFactura>();

    public virtual Emp? Emp { get; set; }

    public virtual Estado? Est { get; set; }
}
