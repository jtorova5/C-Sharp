using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abstract.Models;

public class Usuario : Administrador
{
    public override void IniciarSesion()
    {
        Console.Clear();
        Console.WriteLine("Bienvenido!");
    }

    public override void CerrarSesion()
    {     
        Console.Clear();
        Console.WriteLine("Cerrando sesión...");
        Console.WriteLine("Vuelva pronto!");
    }
}
