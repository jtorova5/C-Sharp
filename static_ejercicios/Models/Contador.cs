using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace static_ejercicios.Models;

public class Contador
{
    public static int TotalContadores { get; set; }

    public static void Incrementar()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("           Ejercicio 1           ");
        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Total anterior: {TotalContadores}");
        TotalContadores++;
        Console.WriteLine($"Total actual: {TotalContadores}");
        Console.WriteLine("---------------------------------");
    }
}
