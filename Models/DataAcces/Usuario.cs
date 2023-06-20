using System;
using System.Collections.Generic;

namespace ApuestasWebCaballos.Models.DataAcces;

public partial class Usuario
{
    public int UserId { get; set; }

    public string? Nombre { get; set; }

    public string? Contraseña { get; set; }

    public string? Correo { get; set; }

    public double? Dinero { get; set; }
}
