using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abstract.Models;

public abstract class Animal
{
    public abstract int Id { get; set; }
    public abstract string Nombre { get; set; }
    public abstract string Especie { get; set; }

    public Animal(int id, string nombre, string especie)
    {
        Id = id;
        Nombre = nombre;
        Especie = especie;
    }

    public abstract void Saludar();
}
