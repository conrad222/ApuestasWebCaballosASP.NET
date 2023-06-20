using System;
using System.Collections.Generic;

namespace ApuestasWebCaballos.Models.DataAcces;

public partial class Trabajador
{
    public int IdTrabajador { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public double? CajaApuesta { get; set; }
}
