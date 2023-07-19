using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class AudPer
{
    public int AudPerId { get; set; }

    public string AudPerNombre { get; set; }

    public string AudPerApellido { get; set; }

    public string AudPerNick { get; set; }

    public string AudPerClave { get; set; }

    public string AudPerPregSeg1 { get; set; }

    public string AudPerPregSeg2 { get; set; }

    public string AudPerTipoDoc { get; set; }

    public string AudPerNumDoc { get; set; }

    public string AudPerTipoLic { get; set; }

    public DateTime? AduPerFechaNac { get; set; }

    public DateTime? AudPerFechaIngreso { get; set; }

    public DateTime? AudPerFechaSalida { get; set; }

    public string AudPerTelefono { get; set; }

    public string AudPerCorreo { get; set; }

    public string AudPerDireccion { get; set; }

    public string AudIdModifica { get; set; }

    public string AudNickModifica { get; set; }

    public string AudAccionModifica { get; set; }
}
