using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace static_ejercicios.Models;

public class Convertidor
{
    public static double Celsius { get; set; }

    public static double Fahrenheit { get; set; }

    public static double CelsiusAFahrenheit()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("           Ejercicio 2           ");
        Console.WriteLine("---------------------------------");
        Console.Write("Ingrese la temperatura en Celsius: ");
        Celsius = Convert.ToDouble(Console.ReadLine());
        Fahrenheit = (Celsius * 9 / 5) + 32;
        Console.WriteLine($"Ahora, {Celsius} C° equivalen a {Fahrenheit} F°");
        Console.WriteLine("---------------------------------");
        return Fahrenheit;
    }
}
