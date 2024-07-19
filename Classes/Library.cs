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
            Console.WriteLine(libro.Titulo);
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
}
