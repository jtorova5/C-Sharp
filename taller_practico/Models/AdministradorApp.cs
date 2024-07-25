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
        AdministradorApp.Estudiantes.Add(estudiante);
    }

    public static void AgregarProfesor(Profesor profesor)
    {
        AdministradorApp.Profesores.Add(profesor);
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
}
