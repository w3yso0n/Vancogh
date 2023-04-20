using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace banco.Banco.Server.Models;

public class Usuario
{
    [Key]
    public int IdUsuario { get; set; } 
    public string CurpUsr { get; set; } = null;
    public double SaldoUsr { get; set; }
    public int IdHistorial { get; set; }
    
}
