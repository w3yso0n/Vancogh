using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace banco.Banco.Server.Models;

public  class Puesto
{
    [Key]
    public int IdPuesto { get; set; }
    public string? Puesto1 { get; set; }
    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();
}
