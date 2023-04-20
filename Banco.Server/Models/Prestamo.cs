using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace banco.Banco.Server.Models;


public  class Prestamo
{
    [Key]
    public int FolioPrestamo { get; set; }

    public int CantidadPrestamo { get; set; }

    public string FecSolicitudPrestamo { get; set; } = null!;

    public string FecAprobacionPrestamo { get; set; } = null!;

    public int IdUsuario { get; set; }

    public int Plazos { get; set; }

    public int IdEmpleado { get; set; }
    
    

    public virtual ICollection<Historial> Historials { get; } = new List<Historial>();
    public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

    public virtual Plazo PlazosNavigation { get; set; } = null!;
}
