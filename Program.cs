using SistemaBiblioteca.Models;

Console.Clear();

var biblioteca = new Biblioteca();

void Menu()
{
    CrearLibros();
    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("======================================================================================");
        Console.WriteLine("                                  Menú de Biblioteca                                  ");
        Console.WriteLine("======================================================================================");
        Console.WriteLine("0. Cerrar");
        Console.WriteLine("1. Mostrar libros");
        Console.WriteLine("2. Agregar libro");
        Console.WriteLine("3. Eliminar libro");
        Console.WriteLine("4. Buscar por un género específico");
        Console.WriteLine("5. Buscar por un autor específico");
        Console.WriteLine("6. Buscar por un rango de años");
        Console.WriteLine("7. Ordenar libros por año de publicación");
        Console.WriteLine("8. Aplicar descuento a un libro");
        Console.WriteLine("===========================================");
        Console.Write("Selecciona una opción: ");

        string opcion = Console.ReadLine();
        switch (opcion)
        {
            case "1":
                biblioteca.MostrarLibros(biblioteca.Libros);
                PausarMenu();
                break;
            case "2":
                biblioteca.AgregarLibro();
                PausarMenu();
                break;
            case "3":
                biblioteca.EliminarLibro();
                PausarMenu();
                break;
            case "4":
                biblioteca.BuscarLibroGenero();
                PausarMenu();
                break;
            case "5":
                biblioteca.BuscarLibroAutor();
                PausarMenu();
                break;
            case "6":
                biblioteca.BuscarLibroAño();
                PausarMenu();
                break;
            case "7":
                biblioteca.OrdenarLibros();
                PausarMenu();
                break;
            case "8":
                biblioteca.AplicarDescuento();
                PausarMenu();
                break;
            case "0":
                Console.WriteLine("Hasta luego");
                continuar = false;
                break;
            default:
                Console.WriteLine("Opción no válida, intenta de nuevo");
                break;
        }
    }
}

void PausarMenu(){
    Console.WriteLine("Presiona una tecla para continuar");
    Console.ReadKey();
}