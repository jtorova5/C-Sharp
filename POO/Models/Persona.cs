using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Persona
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Genero { get; set; }
    public string? Nacionalidad { get; set; }
    public string? Telefono { get; set; }
    public string? Email { get; set; }
    public string? FechaDeNacimiento { get; set; }

    // Constructor
    public Persona(int id, string nombre, string genero, string nacionalidad, string telefono,string email, string fechaDeNacimiento)
    {
        Id = id;
        Nombre = nombre;
        Genero = genero;
        Nacionalidad = nacionalidad;
        Telefono = telefono;
        Email = email;
        FechaDeNacimiento = fechaDeNacimiento;
    }


    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}.");
    }
}
