using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models;

public class Perro : Animal
{
    public override void Hablar()
    {
        base.Hablar();
        Console.WriteLine("El perro dice wuff");
    }

    public override void Desplazarse()
    {
        Console.WriteLine("El perro camina");
    }
}
