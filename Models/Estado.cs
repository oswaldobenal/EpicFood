using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Estado
{
    public int EstId { get; set; }

    public string EstNombre { get; set; }

    public string EstValor { get; set; }

    public virtual ICollection<Combo> Combos { get; set; } = new List<Combo>();

    public virtual ICollection<Descuento> Descuentos { get; set; } = new List<Descuento>();

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();

    public virtual ICollection<FormaPago> FormaPagos { get; set; } = new List<FormaPago>();

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();

    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<Rol> Rols { get; set; } = new List<Rol>();

    public virtual ICollection<Sucursal> Sucursals { get; set; } = new List<Sucursal>();

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
}
