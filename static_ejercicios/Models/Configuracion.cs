using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace static_ejercicios.Models;

public class Configuracion
{
    public static bool ModoOscuro { get; set; } = false;

    public static void CambiarModo()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("           Ejercicio 3           ");
        Console.WriteLine("---------------------------------");
        if (ModoOscuro == false)
        {
            Console.WriteLine("Modo oscuro activado");
            ModoOscuro = true;
        } else 
        {
            Console.WriteLine("Modo oscuro desactivado");
            ModoOscuro = false;
        }
        Console.WriteLine("---------------------------------");
    }

}
