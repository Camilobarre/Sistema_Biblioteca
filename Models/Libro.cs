using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Models;
public class Libro : Publicacion
{
    public string Autor { get; set; }
    public Guid ISBN { get; set; }
    public string Genero { get; set; }
    public double Precio { get; set; }

    public Libro(string autor, string genero, double precio, string titulo, int añoPublicacion)
    {
        this.Autor = autor;
        this.ISBN = Guid.NewGuid();
        this.Genero = genero;
        this.Precio = precio;
        this.Titulo = titulo;
        this.AñoPublicacion = añoPublicacion;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($@"Título: {Titulo} 
                      Autor: {Autor}
                      ISBN: {ISBN}
                      Género: {Genero}
                      Precio: {Precio}");
    }

    public void Descuento()
    {
        Console.Write("Ingresa un descuento a aplicar: ");
        int descuento = Convert.ToInt32(Console.ReadLine());
        double Total = Precio - (Precio * descuento / 100);
        Console.WriteLine(@$"Título: {Titulo} 
                            Autor: {Autor}
                            Precio: {Precio}
                            Precio con descuento: {Total}");
    }
}
