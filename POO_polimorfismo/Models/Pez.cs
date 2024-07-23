using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models;

public class Pez : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El pez dice psss");
    }

    public override void Desplazarse()
    {
        Console.WriteLine("El pez nada");
    }
}
