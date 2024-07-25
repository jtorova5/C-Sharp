using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_practico.Models;

public class Estudiante : Persona
{
    public string? NombreAcudiente { get; set; }
    public string? CursoActual { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public List<double> Calificaciones { get; set; }
    public int Edad { get; set; }
    
    
    public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento, List<double> calificaciones) : base(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono)
    {
        NombreAcudiente = nombreAcudiente.Trim();
        CursoActual = cursoActual.Trim();
        FechaNacimiento = fechaNacimiento;
        Edad = CalcularEdad();
        Calificaciones = calificaciones;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.Write(@$" {NombreAcudiente, -21} | {CursoActual, -3} | {Edad, -3} años |");
        CalcularPromedio();
    }

    public void AgregarCalificacion(double calificacion)
    {
        Calificaciones.Add(calificacion);
        Console.WriteLine("La calificación se ha agregado correctamente!");
    }

    private void CalcularPromedio()
    {
        double sumaCalificaciones = Calificaciones.Sum();
        double promedio = sumaCalificaciones / Calificaciones.Count;
        Console.WriteLine(@$"  {promedio.ToString("0.00"), -5} |");
    }

    public int CalcularEdad()
    {
        int edad = DateTime.Now.Year - FechaNacimiento.Year;
        return edad;
    }
}
