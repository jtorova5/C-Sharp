using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repaso_general.Models;

public abstract class Persona
{
    protected Guid Id { get; set; }
    protected static string Nombre { get; set; }
    protected static string Apellido { get; set; }
    public string NombreCompleto { get; set; }
    protected int Edad { get; set; }

    public Persona(string nombre, string apellido, int edad)
    {
        Id = Guid.NewGuid();
        Nombre = nombre.Trim().ToLower();
        Apellido = apellido.Trim().ToLower();
        NombreCompleto = Nombre + " " + Apellido;
        Edad = edad;
    }

    public static void ActualizarNombre(string nombre)
    {
        Nombre = nombre;
    }

      public static void ActualizarApellido(string apellido)
    {
        Apellido = apellido;
    }

    public abstract void MostrarInformacion();
}
