using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Biblioteca.Classes;

public class Library
{
    public List<Libro> ListaLibros { get; set; }

    // Constructor
    public Library()
    {
        ListaLibros = [];
    }

    // Método para agregar libros a la biblioteca
    public void AgregarLibro(Libro libro)
    {
        ListaLibros.Add(libro);
    }

    public void EliminarLibro(Libro libro)
    {
        ListaLibros.Remove(libro);
    }

    public void MostrarTodosLosLibros()
    {
        foreach (var libro in ListaLibros)
        {
            Console.WriteLine(@$"----------------------------------------------------------
        LIBRO {libro.IdLibro}
        autor:{libro.Autor}
        ISBN:{libro.ISBN}
        genero:{libro.Genero}
        precio Base:${libro.Precio}
        Descuento:{libro.descuentoFinal}%
        PrecioFinal:${libro.PrecioFinal()}
        ");
        }
    }

    public void BuscarPorGenero()
    {
        Console.WriteLine("Ingrese el genero que desea buscar:");
        var genre = Console.ReadLine();
        int counter = 0;
        foreach (var libro in ListaLibros)
        {
            if (libro.Genero == genre.ToLower())
            {
                Console.WriteLine(libro.Titulo);
            }
            else
            {
                counter++;
            }
        }
        if (counter == ListaLibros.Count)
        {
            Console.WriteLine("No existen libros de ese genero en la Biblioteca");
        }
    }

    public void BuscarPorAutor()
    {
        Console.WriteLine("Ingrese el nombre del autor que desea buscar:");
        var autor = Console.ReadLine();
        int counter = 0;
        foreach (var libro in ListaLibros)
        {
            if (libro.Autor == autor)
            {
                Console.WriteLine(libro.Titulo);
            }
            else
            {
                counter++;
            }
        }
        if (counter == ListaLibros.Count)
        {
            Console.WriteLine($"No existen libros escritos por {autor} en la Biblioteca");
        }
    }

    public void BuscarPorRangodeAños()
    {
        Console.WriteLine("Ingrese el primer año del rango:");
        var añoInicio = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese el fin del rango de años:");
        var añoFin = Convert.ToInt16(Console.ReadLine());

        int counter = 0;
        foreach (var libro in ListaLibros)
        {
            if (libro.AñoPublicacion > añoInicio && libro.AñoPublicacion < añoFin)
            {
                Console.WriteLine(libro.Titulo);
            }
            else
            {
                counter++;
            }
        }
        if (counter == ListaLibros.Count)
        {
            Console.WriteLine($"No existen libros escritos entre {añoInicio} y {añoFin} en la Biblioteca");
        }
    }
}
