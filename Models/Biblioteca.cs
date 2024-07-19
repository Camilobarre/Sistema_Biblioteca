using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models;
public class Biblioteca
{
    private Guid Id { get; set; }
    public List<Libro>? Libros { get; set; }
    public Biblioteca()
    {
        this.Id = Guid.NewGuid();
        this.Libros = new List<Libro>();
    }
    public void AgregarLibro(Guid id, string autor, string isbn, string genero, double precio, string titulo, int añoPublicacion)
    {
        Console.Write("Ingresa un Titulo: ");
        string? nuevoTitulo = Console.ReadLine();
        Console.Write("Ingresa un Autor: ");
        string? nuevoAutor = Console.ReadLine();
        Console.Write("Ingresa un Genero: ");
        string? nuevoGenero = Console.ReadLine();
        Console.Write("Ingresa un Precio: ");
        double nuevoPrecio = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingresa un Año de Publicacion: ");
        int nuevoAñoPublicacion = Convert.ToByte(Console.ReadLine());
        Libro nuevoLibro = new Libro(id, nuevoAutor, isbn, nuevoGenero, nuevoPrecio, nuevoTitulo, nuevoAñoPublicacion);
        Libros.Add(nuevoLibro);
    }
    public void MostrarLibros(List<Libro> ListaLibros)
    {
        foreach (var libro in ListaLibros)
        {
            Console.WriteLine($"ID: {libro.Id} - Título: {libro.Titulo} - Autor: {libro.Autor} - Año de Publicación: {libro.AñoPublicacion}");
        }
    }
    public void EliminarLibro()
    {
        Console.Write("Ingresa un Titulo para eliminar: ");
        string? tituloEliminar = Console.ReadLine().ToLower();
        Libro? libroAEliminar = Libros.Find(libro => libro.Titulo.ToLower() == tituloEliminar);
        if (libroAEliminar != null)
        {
            Libros.Remove(libroAEliminar);
        }
        else
        {
            Console.WriteLine("No se encontró el libro a eliminar");
        }
    }
    public void BuscarLibroAño()
    {
        Console.Write("Ingresa el año a buscar: ");
        int añoBuscar = Convert.ToByte(Console.ReadLine());
        List<Libro>? librosEncontrados = Libros.FindAll(libro => libro.AñoPublicacion == añoBuscar);
        if (librosEncontrados.Count > 0)
        {
            Console.WriteLine("Libros encontrados:");
            MostrarLibros(librosEncontrados);
        }
        else
        {
            Console.WriteLine("No se encontraron libros con el año ingresado");
        }
    }
    public void BuscarLibroAutor()
    {
        Console.Write("Ingresa el autor a buscar: ");
        string autorBuscar = Console.ReadLine().ToLower();
        List<Libro>? librosEncontrados = Libros.FindAll(libro => libro.Autor.ToLower() == autorBuscar);
        if (librosEncontrados.Count > 0)
        {
            Console.WriteLine("Libros encontrados:");
            MostrarLibros(librosEncontrados);
        }
        else
        {
            Console.WriteLine("No se encontraron libros con el autor ingresado");
        }
    }
    public void BuscarLibroGenero()
    {
        Console.Write("Ingresa el género a buscar: ");
        string generoBuscar = Console.ReadLine().ToLower();
        List<Libro>? librosEncontrados = Libros.FindAll(libro => libro.Genero.ToLower() == generoBuscar);
        if (librosEncontrados.Count > 0)
        {
            Console.WriteLine("Libros encontrados:");
            MostrarLibros(librosEncontrados);

        }
        else
        {
            Console.WriteLine("No se encontraron libros con el título ingresado");
        }
    }
    public void OrdenarLibros()
    {
        Console.WriteLine("Lista de libros ordenados por año");
        var listaOrdenada = Libros.OrderByDescending(Libro => Libro.AñoPublicacion).ToList();
        MostrarLibros(listaOrdenada);
    }
    public void LibroReciente()
    {
        Console.WriteLine("Escribe el título del libro para identificar si es reciente: ");
        var tituloLibro = Console.ReadLine().ToLower();
        var libroEncontrado = Libros.Find(libro => libro.Titulo.ToLower() == tituloLibro);
        var añoActual = DateTime.Now.Year;
        if (añoActual - 5 <= libroEncontrado.AñoPublicacion)
        {
            Console.WriteLine("El libro es reciente");
        }
        else
        {
            Console.WriteLine("El libro no es reciente");
        }
    }
}