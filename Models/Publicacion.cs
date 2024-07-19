using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models;
public class Publicacion
{
    private Guid Id {get; set; }
    public string? Titulo {get; set;}
    public int AñoPublicacion {get; set;}
}