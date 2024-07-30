using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_interfaces.Interfaces;

namespace POO_interfaces.Models;

public class Leon : Animal, IAnimal
{
    public bool Melena { get; set; }

    public Leon(string nombre, double pesoKG, bool melena) : base(nombre, pesoKG)
    {
        Melena = melena;
    }

    public override void Respirar()
    {
        Console.WriteLine($"{Nombre} está respirando.");
    }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }

    public void Dormir()
    {
        Console.WriteLine($"{Nombre} está durmiendo.");
    }

    public void Desplazar()
    {
        Console.WriteLine($"{Nombre} está desplazándose.");
    }
}
