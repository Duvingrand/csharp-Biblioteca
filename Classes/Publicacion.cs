using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Classes;

public class Publicacion
{
    public string? Titulo { get; set; }
    public int AñoPublicacion { get; set; }

    public Publicacion(string titulo, int añoPublicacion)
    {
        Titulo = titulo;
        AñoPublicacion = añoPublicacion;
    }
}
