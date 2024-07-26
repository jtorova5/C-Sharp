using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_practico.Models;

public static class InterfazGrafica
{
    public static void SeparadorEstudiantes()
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
    }

    public static void EncabezadoEstudiantes()
    {
        Console.WriteLine(@$"-----------------------------------------------------------------------------------------------------------------------------------
|                                                           ESTUDIANTES                                                           |
-----------------------------------------------------------------------------------------------------------------------------------
|         Nombre         |    Documento    |         Email         |  Teléfono  |       Acudiente       |Curso|   Edad   |Promedio|     
-----------------------------------------------------------------------------------------------------------------------------------");
    }

    public static void SeparadorProfesores()
    {
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------");
    }

    public static void EncabezadoProfesores()
    {
        Console.WriteLine(@$"-----------------------------------------------------------------------------------------------------------------------------------------
|                                                              PROFESORES                                                               |
-----------------------------------------------------------------------------------------------------------------------------------------
|         Nombre         |    Documento    |         Email         |  Teléfono  |   Asignatura   |  Salario   |Antigüedad|    Cursos    |     
-----------------------------------------------------------------------------------------------------------------------------------------");
    }

    public static void SeparadorMaterias()
    {
        Console.WriteLine("-------------------------------------");
    }

    public static void EncabezadoMaterias()
    {
        Console.WriteLine(@"-------------------------------------
|             MATERIAS              |
-------------------------------------");
    }

    public static void InterfazMenu()
    {
        Console.Write(@$"---------------------------------------------------------------------------------------------
|                   SISTEMA DE ADMINISTRACIÓN DE ESTUDIANTES Y PROFESORES                   |
---------------------------------------------------------------------------------------------
| 1.  Listar estudiantes                                                                    |
| 2.  Listar profesores                                                                     |
| 3.  Agregar estudiante                                                                    |
| 4.  Agregar profesor                                                                      |
| 5.  Actualizar estudiante                                                                 |
| 6.  Actualizar profesor                                                                   |
| 7.  Eliminar estudiante                                                                   |
| 8.  Eliminar profesor                                                                     |
| 9.  Mostrar estudiantes con promedio mayor a 85                                           |
| 10. Profesores con más de un curso                                                        |
| 11. Mostrar estudiantes mayores de 16 años                                                |
| 12. Ordenar estudiantes por apellido en orden ascendente                                  |
| 13. Calcular el salario total de todos los profesores                                     |
| 14. Encontrar el estudiante con el promedio más alto                                      |
| 15. Determina el número de estudiantes de cada curso                                      |
| 16. Mostrar profesores con más de 10 años en la institución                               |
| 17. Listar asignaturas únicas dadas en la escuela                                         |
| 18. Mostrar estudiantes cuyo nombre de acudiente sea 'María'                              |
| 19. Ordenar profesores por salario en orden descendente                                   |
| 20. Calcular el promedio de edad de los estudiantes                                       |
| 21. Mostrar profesores de matemáticas                                                     |
| 22. Mostrar estudiantes con más de 3 calificaciones registradas                           |
| 23. Calcular antigüedad promedio de los profesores                                        |
|                                                                                           |
| 24. Salir                                                                                 |
---------------------------------------------------------------------------------------------
POR FAVOR SELECCIONE UN NÚMERO: ");
    }

}
