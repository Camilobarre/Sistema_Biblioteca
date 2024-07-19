using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models;
public class Biblioteca
{
    private Guid Id { get; set; }
    public List<Libro>? Libros { get; set; }
    public Biblioteca(Guid id)
    {
        this.Id = id;
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
    public void MostrarLibros()
    {
        foreach (var libro in Libros)
        {
            Console.WriteLine($"ID: {libro.Id} - Título: {libro.Titulo} - Autor: {libro.Autor} - Año de Publicación: {libro.AñoPublicacion}");
        }
    }
    public void EliminarLibro(Guid id, string autor, string isbn, string genero, double precio, string titulo, int añoPublicacion)
    {
        Libro? libroAEliminar = Libros.Find(libro => libro.Id == id && libro.Autor == autor && libro.ISBN == isbn && libro.Genero == genero && libro.Precio == precio && libro.Titulo == titulo && libro.AñoPublicacion == añoPublicacion);
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
            foreach (var libro in librosEncontrados)
            {
                Console.WriteLine($"ID: {libro.Id} - Título: {libro.Titulo} - Autor: {libro.Autor} - Año de Publicación: {libro.AñoPublicacion}");
            }

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
            foreach (var libro in librosEncontrados)
            {
                Console.WriteLine($"ID: {libro.Id} - Título: {libro.Titulo} - Autor: {libro.Autor} - Año de Publicación: {libro.AñoPublicacion}");
            }

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
            foreach (var libro in librosEncontrados)
            {
                Console.WriteLine($"ID: {libro.Id} - Título: {libro.Titulo} - Autor: {libro.Autor} - Año de Publicación: {libro.AñoPublicacion}");
            }

        }
        else
        {
            Console.WriteLine("No se encontraron libros con el título ingresado");
        }
    }
    public void DeterminarReciente()
    {
        var libroReciente = Libros.OrderByDescending(libro => libro.AñoPublicacion);
        if (libroReciente != null)
        {
            Console.WriteLine($"Libro más reciente: ID: {libroReciente.Id} - Título: {libroReciente.Titulo} - Autor: {libroReciente.Autor} - Año de Publicación: {libroReciente.AñoPublicacion}");
        }
        else
        {
            Console.WriteLine("No hay libros en la biblioteca");
        }
    }
}