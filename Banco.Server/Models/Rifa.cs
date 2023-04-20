using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace banco.Banco.Server.Models;

public  class Rifa
{
    [Key]
    public int NoBoleto { get; set; }
    public long FechaBoleto { get; set; }
    public string CuentaBol { get; set; }


}
