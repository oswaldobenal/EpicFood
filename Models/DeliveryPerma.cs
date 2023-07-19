using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class DeliveryPerma
{
    public int AuDeliId { get; set; }

    public string AuDeliEstado { get; set; }

    public string AuDeliUsuLongi { get; set; }

    public string AuDeliUsuLati { get; set; }

    public string AuDeliDeliLongi { get; set; }

    public string AuDeliDeliLati { get; set; }

    public DateTime? AuDeliDatetiPeticion { get; set; }

    public DateTime? AuDeliDatetiEntrega { get; set; }

    public DateTime? AuDeliDateRegistro { get; set; }
}
