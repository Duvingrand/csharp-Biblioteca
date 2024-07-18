using System;

namespace Biblioteca.Classes;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        // Crear instancias de la clase Libro
        var libro1 = new Libro("El Hobbit", "J.R.R. Tolkien", "978-0547928227", 1937, "Fantasia", 15);
        var libro2 = new Libro("1984", "George Orwell", "978-0451524935", 1949, "Distopía", 12);
        var libro3 = new Libro("Señor de los anillos", "J.R.R. Tolkien", "978-0574797234", 1954, "Fantasia", 10);


    }
}
