using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Emp
{
    public int EmpId { get; set; }

    public int? EstId { get; set; }

    public string EmpNombreComercial { get; set; }

    public string EmpRuc { get; set; }

    public string EmpRazonSocial { get; set; }

    public string EmpRepresentanteLegal { get; set; }

    public string EmpDireccion { get; set; }

    public DateTime? EmpFechaRegistro { get; set; }

    public string EmpActividadComercial { get; set; }

    public string EmpTelefono { get; set; }

    public virtual Estado Est { get; set; }

    public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();
}
