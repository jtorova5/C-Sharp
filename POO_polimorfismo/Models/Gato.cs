using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models;

public class Gato : Animal
{
    public double TamañoBigotes { get; set; }
    public bool Orejas { get; set; }

    public Gato(string nombre, string genero, string especie, double pesoEnKG, double tamañoBigotes, bool orejas) : base(nombre, genero, especie, pesoEnKG)
    {
        TamañoBigotes = tamañoBigotes;
        Orejas = orejas;
    }

    public override void Hablar()
    {
        Console.WriteLine("El gato dice miaw");
    }

    public override void Desplazarse()
    {
        Console.WriteLine("El gato camina");
    }

}
