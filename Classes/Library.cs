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
        ''{libro.Titulo}'' de {libro.Autor}
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

public void BusquedaEspecificaEliminar()
{
    Console.WriteLine("Ingrese el ID del libro que desea borrar");
    var libroElegido = Convert.ToInt16(Console.ReadLine());

    var librosEncontrados = BuscarLibrosPorId(libroElegido);

    if (librosEncontrados.Count > 0)
    {
        foreach (var libro in librosEncontrados)
        {
            EliminarLibro(libro);
            Console.WriteLine($"Se eliminó el libro {libro.Titulo}.");
        }
    }
    else
    {
        Console.WriteLine("No existe un libro con ese ID en el sistema.");
    }
}

public void MostrarSiEsReciente()
{
    Console.WriteLine("Ingrese el ID que desea consultar");
    var libroElegido = Convert.ToInt16(Console.ReadLine());

    var librosEncontrados = BuscarLibrosPorId(libroElegido);

    if (librosEncontrados.Count > 0)
    {
        foreach (var libro in librosEncontrados)
        {
            libro.EsReciente();
        }
    }
    else
    {
        Console.WriteLine("No existe un libro con ese ID en el sistema.");
    }
}

public void AgregarDescuentoBuscar()
{
    Console.WriteLine("Ingrese el ID que desea agregar un descuento");
    var libroElegido = Convert.ToInt16(Console.ReadLine());

    var librosEncontrados = BuscarLibrosPorId(libroElegido);

    if (librosEncontrados.Count > 0)
    {
        foreach (var libro in librosEncontrados)
        {
            libro.DescuentoPorcentajeM();
        }
    }
    else
    {
        Console.WriteLine("No existe un libro con ese ID en el sistema.");
    }
}

public void MostrarDetalladamente()
{
    Console.WriteLine("Ingrese el ID que desea Consultar detalladamente");
    var libroElegido = Convert.ToInt16(Console.ReadLine());

    var librosEncontrados = BuscarLibrosPorId(libroElegido);

    if (librosEncontrados.Count > 0)
    {
        foreach (var libro in librosEncontrados)
        {
            libro.Descripcion();
        }
    }
    else
    {
        Console.WriteLine("No existe un libro con ese ID en el sistema.");
    }
}

public List<Libro> BuscarLibrosPorId(int id)
{
    var librosEncontrados = new List<Libro>();

    foreach (var libro in ListaLibros)
    {
        if (libro.IdLibro == id)
        {
            librosEncontrados.Add(libro);
        }
    }

    return librosEncontrados;
}
}
