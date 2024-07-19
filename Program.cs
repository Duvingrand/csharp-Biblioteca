using System;

namespace Biblioteca.Classes;
public class Program
{
    public static void Main(string[] args)
    {
        var biblioteca = new Library();

        void NuevoLibro()
        {
            {
                Console.WriteLine("Ingrese los datos para crear un nuevo libro:");

                // Pedir al usuario que ingrese los datos
                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Autor: ");
                string autor = Console.ReadLine();

                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();

                Console.Write("Año de Publicación: ");
                int añoPublicacion;
                while (!int.TryParse(Console.ReadLine(), out añoPublicacion))
                {
                    Console.WriteLine("Ingrese un año válido.");
                    Console.Write("Año de Publicación: ");
                }

                Console.Write("Género: ");
                string genero = Console.ReadLine();

                Console.Write("Precio: ");
                double precio;
                while (!double.TryParse(Console.ReadLine(), out precio))
                {
                    Console.WriteLine("Ingrese un precio válido.");
                    Console.Write("Precio: ");
                }


                // Crear el nuevo libro utilizando el constructor
                Libro nuevoLibro = new Libro(titulo, autor, isbn, añoPublicacion, genero, precio);
                biblioteca.AgregarLibro(nuevoLibro);

                nuevoLibro.Descripcion();
            }

        }
        Console.Clear();
        // Creacion de la instancia de la Biblioteca

        // Crear instancias de la clase Libro
        var libro1 = new Libro("El Hobbit", "J.R.R. Tolkien", "978-0547928227", 1937, "fantasia", 15);
        var libro2 = new Libro("1984", "George Orwell", "978-0451524935", 1949, "distopía", 12);
        var libro3 = new Libro("Cien años de soledad", "Gabriel García Márquez", "978-6073132500", 1967, "realismo mágico", 18);
        var libro4 = new Libro("Ready Player One", "Ernest Cline", "978-0307887443", 2011, "ciencia ficción", 20);
        var libro5 = new Libro("El nombre del viento", "Patrick Rothfuss", "978-8401352836", 2007, "fantasía épica", 22);
        var libro6 = new Libro("The Silent Patient", "Alex Michaelides", "978-1250301697", 2019, "suspenso", 25);
        var libro7 = new Libro("El psicoanalista", "John Katzenbach", "978-0451210365", 2002, "thriller psicológico", 17);
        var libro8 = new Libro("Klara and the Sun", "Kazuo Ishiguro", "978-0593318171", 2021, "ciencia ficción", 30);
        var libro9 = new Libro("Project Hail Mary", "Andy Weir", "978-0593135204", 2021, "ciencia ficción", 28);
        var libro10 = new Libro("Las Crónicas de Narnia", "C.S. Lewis", "978-0066238500", 1950, "fantasía", 16);
        var libro11 = new Libro("Brave New World", "Aldous Huxley", "978-0060850524", 1932, "distopía", 14);
        var libro12 = new Libro("Crónica de una muerte anunciada", "Gabriel García Márquez", "978-1400034956", 1981, "realismo mágico", 19);
        var libro13 = new Libro("Neuromancer", "William Gibson", "978-0441569595", 1984, "ciencia ficción", 21);
        var libro14 = new Libro("El Señor de los Anillos", "J.R.R. Tolkien", "978-0544003415", 1954, "fantasía épica", 23);
        var libro15 = new Libro("Gone Girl", "Gillian Flynn", "978-0307588371", 2012, "suspenso", 24);
        var libro16 = new Libro("The Girl with the Dragon Tattoo", "Stieg Larsson", "978-0307454546", 2005, "thriller", 18);
        var libro17 = new Libro("Never Let Me Go", "Kazuo Ishiguro", "978-1400078776", 2005, "ficción literaria", 26);
        var libro18 = new Libro("Dark Matter", "Blake Crouch", "978-1101904220", 2016, "ciencia ficción", 27);
        var libro19 = new Libro("El Laberinto de los Espíritus", "Carlos Ruiz Zafón", "978-8408163386", 2016, "novela histórica", 18);


        // Agregando cada libro a la lista de la biblioteca
        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);
        biblioteca.AgregarLibro(libro3);
        biblioteca.AgregarLibro(libro4);
        biblioteca.AgregarLibro(libro5);
        biblioteca.AgregarLibro(libro6);
        biblioteca.AgregarLibro(libro7);
        biblioteca.AgregarLibro(libro8);
        biblioteca.AgregarLibro(libro9);
        biblioteca.AgregarLibro(libro10);
        biblioteca.AgregarLibro(libro11);
        biblioteca.AgregarLibro(libro12);
        biblioteca.AgregarLibro(libro13);
        biblioteca.AgregarLibro(libro14);
        biblioteca.AgregarLibro(libro15);
        biblioteca.AgregarLibro(libro16);
        biblioteca.AgregarLibro(libro17);
        biblioteca.AgregarLibro(libro18);
        biblioteca.AgregarLibro(libro19);


        // Ciclo principal del menú
        while (true)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Mostrar todos los libros");
            Console.WriteLine("2. Buscar por rango de años");
            Console.WriteLine("3. Buscar por autor");
            Console.WriteLine("4. Buscar por género");
            Console.WriteLine("5. Agregar libro");
            Console.WriteLine("6. Eliminar libro");
            Console.WriteLine("7. ¿Este libro es reciente?");
            Console.WriteLine("8. Agregar descuento a un libro");
            Console.WriteLine("9. Mostrar datos de un libro detalladamente");
            Console.WriteLine("10. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción (1-9): ");

            // Leer la opción del usuario
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":

                    biblioteca.MostrarTodosLosLibros();
                    break;
                case "2":

                    biblioteca.BuscarPorRangodeAños();
                    break;
                case "3":

                    biblioteca.BuscarPorAutor();
                    break;
                case "4":

                    biblioteca.BuscarPorGenero();
                    break;
                case "5":
                    NuevoLibro();
                    break;
                case "6":
                    biblioteca.BusquedaEspecificaEliminar();

                    break;
                case "7":
                    biblioteca.MostrarSiEsReciente();
                    break;
                case "8":
                    biblioteca.AgregarDescuentoBuscar();
                    break;
                case "9":
                    biblioteca.MostrarDetalladamente();
                    break;
                case "10":
                    Console.WriteLine("Saliendo del programa...");
                    return; // Salir del programa
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida (1-9).");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear(); // Limpiar la consola para el próximo ciclo del menú
        }
    }
}
