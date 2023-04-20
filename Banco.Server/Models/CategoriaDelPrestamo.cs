using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace banco.Banco.Server.Models;

public  class CategoriaDelPrestamo
{
    [Key]
    public int IdCategoria { get; set; }

    public double Cantidad { get; set; }

    public virtual ICollection<Historial> Historials { get; } = new List<Historial>();
}
