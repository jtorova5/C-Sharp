using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_practico.Models;

public class Profesor : Persona
{
    public string? Asignatura { get; set; }
    private double Salario { get; set; }
    public DateTime FechaContratacion { get; set; }
    public List<string> Cursos { get; set; }
    public int Antiguedad { get; set; }

    public Profesor(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string asignatura, double salario, DateTime fechaContratacion, List<string> cursos) : base(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono)
    {
        Asignatura = asignatura.Trim();
        Salario = salario;
        FechaContratacion = fechaContratacion;
        Antiguedad = CalcularAntiguedad(FechaContratacion.Year);
        Cursos = cursos;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.Write(@$" {Asignatura,-14} | ${Salario.ToString("#,##"),-4} | {Antiguedad,-3} años |");

        foreach (var curso in Cursos)
        {
            Console.Write($" {curso}");
        }
        Console.WriteLine();
    }

    public int CalcularAntiguedad(int fechaInicio)
    {
        int antiguedad = DateTime.Now.Year - fechaInicio;
        return antiguedad;
    }

    public void ObtenerSalario()
    {
        Console.WriteLine($"El salario del profesor {Nombre} {Apellido} es: {Salario}");
    }
}
