using System;
using System.Collections.Generic;

namespace ApuestasWebCaballos.Models.DataAcces;

public partial class Caballo
{
    public int IdCaballo { get; set; }

    public string? Nombre { get; set; }

    public string? Pigmentacion { get; set; }

    public string? Sexo { get; set; }

    public virtual Jockey? Jockey { get; set; }
}
