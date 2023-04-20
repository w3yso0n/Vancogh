using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace banco.Banco.Server.Models;



public  class Estatus
{
    [Key]
    public int IdEstado { get; set; }

    public string Estado { get; set; } = null!;


}
