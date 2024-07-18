using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Classes;

public class Publicacion
{
    private static int idUpdater = 0;
    public int Id { get; private set; }
    public string? Titulo { get; set; }
    public int AñoPublicacion { get; set; }

    public Publicacion(string titulo, int añoPublicacion)
    {

        Id = idUpdater++;
        Titulo = titulo;
        AñoPublicacion = añoPublicacion;
    }
}
