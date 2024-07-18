using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Biblioteca.Classes;

public class Libro : Publicacion
{
    private static int idLibroUpdater = 0;
    public int IdLibro { get; private set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public virtual double Precio { get; set; }
    public int DescuentoPorcentaje { get; set; }

    public Libro(string titulo, string autor, string isbn, int añoPublicacion, string genero, double precio) : base(titulo, añoPublicacion)
    {
        IdLibro = idLibroUpdater++;
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        AñoPublicacion = añoPublicacion;
        Genero = genero;
        Precio = precio;
    }

    public void Description()
    {
        Console.WriteLine(@$"----------------------------------------------------------
        LIBRO {IdLibro}
        autor:{Autor}
        ISBN:{ISBN}
        genero:{Genero}
        precio Base:${Precio}
        Descuento:{descuentoFinal}%
        PrecioFinal:${PrecioFinal()}
        ");
    }

    double descuentoFinal=0;

    public double DescuentoPorcentajeM()
    {
        Console.Write($"Ingrese el descuento que se le aplicará al libro {Titulo}: ");
        var descuentoPorcentaje = Convert.ToDouble(Console.ReadLine());
        descuentoFinal = descuentoPorcentaje / 100;
        return descuentoFinal;
    }
    public double PrecioFinal()
    {
        var resultado = Precio - (Precio * descuentoFinal);
        return resultado;
    }

    public bool EsReciente()
    {
        if (AñoPublicacion>(2024-5))
        {
            return true;
        } else
        {
            return false;
        }
    }

}
