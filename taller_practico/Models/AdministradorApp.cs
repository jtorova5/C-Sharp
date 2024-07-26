using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_practico.Models;

public class AdministradorApp
{
    public static List<Estudiante> Estudiantes { get; set; }
    public static List<Profesor> Profesores { get; set; }

    static AdministradorApp()
    {
        Estudiantes = new List<Estudiante>();
        Profesores = new List<Profesor>();
    }

    public static void AgregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
    }

    public static void AgregarProfesor(Profesor profesor)
    {
        Profesores.Add(profesor);
    }

    public static void MostrarEstudiantes()
    {
        foreach (Estudiante estudiante in Estudiantes)
        {
            estudiante.MostrarDetalles();
        }
    }

    public static void MostrarProfesores()
    {
        foreach (Profesor profesor in Profesores)
        {
            profesor.MostrarDetalles();
        }
    }

    public static void ActualizarEstudiante(string numeroDocumento)
    {
        var estudiante = Estudiantes.FirstOrDefault(e => e.MiNumeroDocumento() == numeroDocumento);

        if (estudiante != null)
        {

            Console.WriteLine("Ingrese los nuevos datos:");
            estudiante.ActualizarMisDatos();
            estudiante.Calificaciones = Estudiante.AgregarCalificaciones();
            Console.WriteLine("Datos actualizados correctamente.");
        }
        else
        {
            Console.WriteLine("Estudiante no encontrado.");
        }
    }

    public static void ActualizarProfesor(string numeroDocumento)
    {
        var profesor = Profesores.FirstOrDefault(p => p.MiNumeroDocumento() == numeroDocumento);

        if (profesor != null)
        {

            Console.WriteLine("Ingrese los nuevos datos:");
            profesor.ActualizarMisDatos();
            profesor.Cursos = Profesor.AgregarCursos();
            Console.WriteLine("Datos actualizados correctamente.");
        }
        else
        {
            Console.WriteLine("Profesor no encontrado.");
        }
    }

    public static void EliminarEstudiante(string numeroDocumento)
    {
        var estudiante = Estudiantes.FirstOrDefault(e => e.MiNumeroDocumento() == numeroDocumento);

        if (estudiante != null)
        {
            Estudiantes.Remove(estudiante);
            Console.WriteLine("Estudiante eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Estudiante no encontrado.");
        }
    }

    public static void EliminarProfesor(string numeroDocumento)
    {
        var profesor = Profesores.FirstOrDefault(p => p.MiNumeroDocumento() == numeroDocumento);

        if (profesor != null)
        {
            Profesores.Remove(profesor);
            Console.WriteLine("Profesor eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("Profesor no encontrado.");
        }
    }

    public static void MostrarEstudiantesConPromedioMayorA85()
    {
        var estudiantesConPromedioMayorA85 = Estudiantes.Where(e => e.MiPromedio() > 85).ToList();

        foreach (Estudiante estudiante in estudiantesConPromedioMayorA85)
        {
            estudiante.MostrarDetalles();
        }
    }

    public static void MostrarProfesoresConMasDeUnCurso()
    {
        var profesoresConMasDeUnCurso = Profesores.Where(p => p.Cursos.Count > 1).ToList();

        foreach (Profesor profesor in profesoresConMasDeUnCurso)
        {
            profesor.MostrarDetalles();
        }
    }

    public static void MostrarEstudiantesMayoresDe16Años()
    {
        var estudiantesMayoresDe16Años = Estudiantes.Where(e => e.Edad > 16).ToList();

        foreach (Estudiante estudiante in estudiantesMayoresDe16Años)
        {
            estudiante.MostrarDetalles();
        }
    }

    public static void OrdenarEstudiantesPorApellidoAscendente()
    {
        var estudiantesOrdenadosPorApellidoAscendente = Estudiantes.OrderBy(e => e.MiApellido()).ToList();

        foreach (Estudiante estudiante in estudiantesOrdenadosPorApellidoAscendente)
        {
            estudiante.MostrarDetalles();
        }
    }

    public static void CalcularSalarioTotalProfesores()
    {
        double salarioTotal = Profesores.Sum(p => p.MiSalario());
        Console.WriteLine($"El salario total de todos los profesores es ${salarioTotal.ToString("#,##")} COP.");
    }

    public static void MostrarEstudianteConPromedioMasAlto()
    {
        var estudianteConPromedioMasAlto = Estudiantes.OrderByDescending(e => e.MiPromedio()).FirstOrDefault();
        Console.WriteLine(@$"
Estudiante con promedio más alto:
Nombre: {estudianteConPromedioMasAlto.MiNombre()}
Apellido: {estudianteConPromedioMasAlto.MiApellido()}
Documento: {estudianteConPromedioMasAlto.MiNumeroDocumento()}
Promedio: {estudianteConPromedioMasAlto.MiPromedio().Value.ToString("#,##.00")}");
    }

    public static void DeterminarCantidadDeEstudiantesPorCurso()
    {
        var estudiantesPorCurso = Estudiantes.GroupBy(e => e.CursoActual).ToDictionary(g => g.Key, g => g.Count());
        Console.WriteLine("Cantidad de estudiantes por curso:");

        foreach (var estudiantes in estudiantesPorCurso)
        {
            Console.WriteLine($"Curso: {estudiantes.Key} - Cantidad de estudiantes: {estudiantes.Value}");
        }
    }

    public static void MostrarProfesoresConMasDe10Años()
    {
        var profesoresConMasDe10Años = Profesores.Where(p => p.Antiguedad > 10).ToList();

        foreach (Profesor profesor in profesoresConMasDe10Años)
        {
            profesor.MostrarDetalles();
        }
    }

    public static void MostrarMateriasEscuela()
    {
        var materiasEscuela = Profesores.Select(p => p.Asignatura).Distinct().ToList();

        foreach (var materia in materiasEscuela)
        {
            Console.WriteLine(materia);
        }
    }

    public static void MostrarEstudiantesConAcudienteMaria()
    {
        var estudiantesConAcudienteMaria = Estudiantes.Where(e => e.NombreAcudiente.ToLower().Contains("maría")).ToList();

        foreach (Estudiante estudiante in estudiantesConAcudienteMaria)
        {
            estudiante.MostrarDetalles();
        }
    }

    public static void OrdenarProfesoresPorSalarioDescendente()
    {
        var profesoresOrdenadosPorSalarioDescendente = Profesores.OrderByDescending(p => p.MiSalario()).ToList();

        foreach (Profesor profesor in profesoresOrdenadosPorSalarioDescendente)
        {
            profesor.MostrarDetalles();
        }
    }

    public static void CalcularPromedioEdadEstudiantes()
    {
        double promedioEdadEstudiantes = Estudiantes.Average(e => e.Edad);
        Console.WriteLine($"El promedio de edad de todos los estudiantes es {promedioEdadEstudiantes.ToString("0.00")} años.");
    }

    public static void MostrarProfesoresDeMatematicas()
    {
        var profesoresDeMatematicas = Profesores.Where(p => p.Asignatura.ToLower().Contains("matemáticas")).ToList();

        foreach (Profesor profesor in profesoresDeMatematicas)
        {
            profesor.MostrarDetalles();
        }
    }

    public static void MostrarEstudiantesConMasDe3CalificacionesRegistradas()
    {
        var estudiantesConMasDe3Calificaciones = Estudiantes.Where(e => e.Calificaciones.Count > 3).ToList();

        foreach (Estudiante estudiante in estudiantesConMasDe3Calificaciones)
        {
            estudiante.MostrarDetalles();
        }
    }

    public static void CalcularAntiguedadPromedioProfesores()
    {
        double antiguedadPromedioProfesores = Profesores.Average(p => p.Antiguedad);
        Console.WriteLine($"El promedio de antigüedad de todos los profesores es {antiguedadPromedioProfesores.ToString("0.00")} años.");
    }
}

