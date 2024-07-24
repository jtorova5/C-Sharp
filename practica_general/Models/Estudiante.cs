using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica_general.Models;

public class Estudiante
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public byte Edad { get; set; }
    public string? Matricula { get; set; }

    public Estudiante(int id, string nombre, byte edad, string matricula)
    {
        Id = id;
        Nombre = nombre;
        Edad = edad;
        Matricula = matricula;
    }

    public void MostrarEstudiante()
    {
        Console.WriteLine(@$"|{Id,-5}| {Nombre,-19}| {Edad,-4}años |      {Matricula,-9}|");
    }
}
