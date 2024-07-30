using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_interfaces.Models;

public abstract class Animal
{
    public string Nombre { get; set; }
    public double PesoKG { get; set; }

    public Animal(string nombre, double pesoKG)
    {
        Nombre = nombre;
        PesoKG = pesoKG;
    }

    public abstract void Respirar();
}
