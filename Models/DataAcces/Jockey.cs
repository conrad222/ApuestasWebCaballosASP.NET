using System;
using System.Collections.Generic;

namespace ApuestasWebCaballos.Models.DataAcces;

public partial class Jockey
{
    public int IdJockey { get; set; }

    public int? Numero { get; set; }

    public int? Copas { get; set; }

    public string? ColorEquipo { get; set; }

    public virtual Caballo IdJockeyNavigation { get; set; } = null!;
}
