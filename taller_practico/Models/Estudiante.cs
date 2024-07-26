using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace taller_practico.Models;

public class Estudiante : Persona
{
    public string? NombreAcudiente { get; set; }
    public string? CursoActual { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public List<double>? Calificaciones { get; set; } = new List<double>();
    public int Edad => CalcularEdad();


    public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento, List<double> calificaciones) : base(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono)
    {
        NombreAcudiente = nombreAcudiente.Trim();
        CursoActual = cursoActual.Trim();
        FechaNacimiento = fechaNacimiento;
        Calificaciones = calificaciones;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.Write(@$" {NombreAcudiente,-21} | {CursoActual,-3} | {Edad,-3} años |");
        CalcularPromedio();
    }

    public static List<double> AgregarCalificaciones()
    {
        List<double> calificaciones = new List<double>();
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("                   Agregar calificaciones");
        Console.WriteLine("----------------------------------------------------------------");
        Console.Write("Nota matemáticas: ");
        double matematicas = Convert.ToDouble(Console.ReadLine());
        calificaciones.Add(matematicas);
        Console.Write("Física: ");
        double fisica = Convert.ToDouble(Console.ReadLine());
        calificaciones.Add(fisica);
        Console.Write("Química: ");
        double quimica = Convert.ToDouble(Console.ReadLine());
        calificaciones.Add(quimica);
        Console.Write("Historia: ");
        double historia = Convert.ToDouble(Console.ReadLine());
        calificaciones.Add(historia);
        Console.Write("Lengua: ");
        double lengua = Convert.ToDouble(Console.ReadLine());
        calificaciones.Add(lengua);
        Console.Write("Biología: ");
        double biologia = Convert.ToDouble(Console.ReadLine());
        calificaciones.Add(biologia);
        Console.Write("Informática: ");
        double informatica = Convert.ToDouble(Console.ReadLine());
        calificaciones.Add(informatica);
        Console.Write("Educación Física: ");
        double educacionFisica = Convert.ToDouble(Console.ReadLine());
        calificaciones.Add(educacionFisica);
        Console.WriteLine("Las calificaciones se han agregado correctamente!");
        Console.WriteLine("----------------------------------------------------------------");

        return calificaciones;
    }

    private void CalcularPromedio()
    {
        if (Calificaciones.Count > 0)
        {
            double promedio = Calificaciones.Average();
            Console.WriteLine(@$"  {promedio.ToString("0.00"),-5} |");
        }
        else
        {
            Console.WriteLine(@$"  {"N/A",-5} |");
        }
    }

    public int CalcularEdad()
    {
        var edad = DateTime.Now.Year - FechaNacimiento.Year;
        if (DateTime.Now.DayOfYear < new DateTime(DateTime.Now.Year, FechaNacimiento.Month, FechaNacimiento.Day).DayOfYear)
        {
            edad--;
        }
        return edad;
    }

    public void ActualizarMisDatos()
    {
        Console.Write("Nombre: ");
        Nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        Apellido = Console.ReadLine();
        Console.Write("Tipo de documento: ");
        TipoDocumento = Console.ReadLine();
        Console.Write("Email: ");
        Email = Console.ReadLine();
        Console.Write("Teléfono: ");
        Telefono = Console.ReadLine();
        Console.Write("Nombre del acudiente: ");
        NombreAcudiente = Console.ReadLine();
        Console.Write("Curso actual: ");
        CursoActual = Console.ReadLine();
        Console.Write("Fecha de nacimiento (AAAA/DD/MM): ");
        FechaNacimiento = DateOnly.Parse(Console.ReadLine());
    }

    public string? MiNumeroDocumento()
    {
        return NumeroDocumento;
    }

    public double? MiPromedio()
    {
        double promedio = Calificaciones.Average();
        return promedio;
    }

    public string? MiNombre()
    {
        return Nombre;
    }

    public string? MiApellido()
    {
        return Apellido;
    }
}

