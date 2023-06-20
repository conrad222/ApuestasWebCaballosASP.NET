using System;
using System.Collections.Generic;

namespace ApuestasWebCaballos.Models.DataAcces;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Correo { get; set; }

    public string? Password { get; set; }

    public double? Dinero { get; set; }

    public double? RoleId { get; set; }
}
