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

    public static List<string> AgregarCursos()
    {
        List<string> cursos = new List<string>();
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("                       Agregar cursos");
        Console.WriteLine("----------------------------------------------------------------");
        var flag = true;
        while (flag)
        {
            Console.Write("Nombre del curso: ");
            string? curso = Console.ReadLine();
            cursos.Add(curso);
            Console.Write("¿Desea agregar otro curso? (s/n): ");
            var respuesta = Console.ReadLine();
            if (respuesta.ToLower() != "s")
            {
                flag = false;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Los cursos se han agregado correctamente!");
        Console.WriteLine("----------------------------------------------------------------");

        return cursos;
    }


    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.Write(@$" {Asignatura,-14} | ${Salario.ToString("#,##"),-9} | {Antiguedad,-3} años |");

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
        Console.Write("Asignatura: ");
        Asignatura = Console.ReadLine();
        Console.Write("Salario (COP): ");
        Salario = double.Parse(Console.ReadLine());
        Console.Write("Fecha de contrato (AAAA/MM/DD): ");
        FechaContratacion = DateTime.Parse(Console.ReadLine());
    }

    public string? MiNumeroDocumento()
    {
        return NumeroDocumento;
    }

    public double MiSalario()
    {
        return Salario;
    }
}
