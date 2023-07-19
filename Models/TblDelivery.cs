using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class TblDelivery
{
    public int DeliId { get; set; }

    public int? PerId { get; set; }

    public int? PerPerId { get; set; }

    public string DeliEstado { get; set; }

    public string DeliUsuLongi { get; set; }

    public string DeliUsuLati { get; set; }

    public string DeliDeliLongi { get; set; }

    public string DeliDeliLati { get; set; }

    public DateTime? DeliDatetiPeticion { get; set; }

    public DateTime? DeliDatetiEntrega { get; set; }

    public virtual ICollection<CabeceraFactura> CabeceraFacturas { get; set; } = new List<CabeceraFactura>();

    public virtual Persona Per { get; set; }

    public virtual Persona PerPer { get; set; }
}
