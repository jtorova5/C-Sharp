using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_static.Models;

public class EjemploEstatico
{
    public static string? Nombre { get; set; }
    public static string? Apellido { get; set; }

    static EjemploEstatico()
    {
        Nombre = "Jhonatan";
        Apellido = "Toro Vásquez";
    }

    public static void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} {Apellido}");
    }
}
