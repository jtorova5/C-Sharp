using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abstract.Models;

public static class InterfazGrafica
{
    public static void Encabezado()
    {
        Console.Clear();
        Console.Write(@$"-------------------
      Sistema   
-------------------
1. Iniciar sesión
2. Cerrar sesión
-------------------
¿Qué desea hacer? ");
    }
}
