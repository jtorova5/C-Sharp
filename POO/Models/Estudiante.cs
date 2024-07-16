using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;

public class Estudiante
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public int Edad { get; set; }
    public string? Correo { get; set; }

    public Estudiante(int id, string nombre, string apellido, int edad, string correo)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Correo = correo;
    }

    public void LlegarTemprano()
    {
        Console.WriteLine("El estudiante llegó a las 06:00");
    }
}


