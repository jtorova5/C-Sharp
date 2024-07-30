using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_interfaces.Models;

public class Oso : Animal
{
    public bool Hibernar { get; set; }

    public Oso(string nombre, double pesoKG, bool hibernar) : base(nombre, pesoKG)
    {
        Hibernar = hibernar;
    }

    public override void Respirar()
    {
        Console.WriteLine($"{Nombre} está respirando.");
    }
}
