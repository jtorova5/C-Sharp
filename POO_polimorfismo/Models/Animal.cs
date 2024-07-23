using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models;

public class Animal
{
    public Guid Id { get; set; }
    public string? Nombre { get; set; }
    public string? Genero { get; set; }
    public string? Especie { get; set; }
    public double PesoEnKG { get; set; }

    public Animal(string nombre, string genero, string especie, double pesoEnKG)
    {
        Id = new Guid();
        Nombre = nombre;
        Genero = genero;
        Especie = especie;
        PesoEnKG = pesoEnKG;
    }

    public virtual void Hablar()
    {
        Console.WriteLine("El animal está hablando");
    }

    public virtual void Desplazarse()
    {
        Console.WriteLine("El animal se está moviendo");
    }
}
