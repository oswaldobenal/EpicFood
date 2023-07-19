using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class Persona
{
    public int PerId { get; set; }

    public int? RolId { get; set; }

    public int? EstId { get; set; }

    public string PerNombre { get; set; }

    public string PerApellido { get; set; }

    public string PerNick { get; set; }

    public string PerClave { get; set; }

    public string PerPregSeg1 { get; set; }

    public string PerPregSeg2 { get; set; }

    public string PerTipoDoc { get; set; }

    public string PerNumDoc { get; set; }

    public string PerTipoLic { get; set; }

    public DateTime? PerFechaNac { get; set; }

    public DateTime? PerFechaIngre { get; set; }

    public DateTime? PerFechaSalida { get; set; }

    public string PerTelefono { get; set; }

    public string PerCorreo { get; set; }

    public string PerDireccion { get; set; }

    public virtual ICollection<CabeceraFactura> CabeceraFacturas { get; set; } = new List<CabeceraFactura>();

    public virtual Estado Est { get; set; }

    public virtual ICollection<FormaPago> FormaPagos { get; set; } = new List<FormaPago>();

    public virtual ICollection<HistorialRefreshToken> HistorialRefreshTokens { get; set; } = new List<HistorialRefreshToken>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual Rol Rol { get; set; }

    public virtual ICollection<TblDelivery> TblDeliveryPerPers { get; set; } = new List<TblDelivery>();

    public virtual ICollection<TblDelivery> TblDeliveryPers { get; set; } = new List<TblDelivery>();

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
}
