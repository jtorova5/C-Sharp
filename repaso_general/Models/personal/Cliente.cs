using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repaso_general.Models;

public class Cliente : Persona
{
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Cliente(string nombre, string apellido, int edad, string email, string telefono) : base(nombre, apellido, edad)
    {
        Email = email.Trim().ToLower();
        Telefono = telefono.Trim().ToLower();
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"| {NombreCompleto,-19} |  {Edad,-3} | {Email,-27} | {Telefono,-16} |");
    }
}
