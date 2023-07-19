using System;
using System.Collections.Generic;

namespace EpicFood_API.Models;

public partial class AudEmp
{
    public int AudiEmpId { get; set; }

    public string AudiEmpNombreComercial { get; set; }

    public string AudiEmpRuc { get; set; }

    public string AudiEmpRazonSocial { get; set; }

    public string AudiEmpRepresentanteLegal { get; set; }

    public string AudiEmpDireccion { get; set; }

    public DateTime? AudiEmpFechaRegistro { get; set; }

    public string AudiEmpActividadComercial { get; set; }

    public string AudiEmpTelefono { get; set; }

    public string AudiIdModificador { get; set; }

    public string AudiNickModificador { get; set; }

    public string AudiAccionModificador { get; set; }
}
