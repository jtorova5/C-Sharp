
using taller_practico.Models;

AdministradorApp.AgregarEstudiante(new Estudiante("Juan", "Porras", "ti", "1036402699", "juan@gmail.com", "3007755896", "Alejandra Ramirez", "6A", new DateOnly(2012, 01, 15), new List<double> { 3.4, 4, 4.2, 3.2, 5, 1.2, 4.5, 2 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Miguel", "Díaz", "ti", "1036402799", "miguel@gmail.com", "3007455896", "Freddy Hoyos", "6A", new DateOnly(2012, 02, 15), new List<double> { 4, 4.1, 2, 3, 2.5, 3.2, 4, 2.9 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Valeria", "Ramirez", "ti", "1026402699", "vale@gmail.com", "3037755896", "Camila Restrepo", "6A", new DateOnly(2012, 04, 20), new List<double> { 3.4, 4, 4.5, 3.5, 3.7, 3.8, 4, 3.2 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Mateo", "Montoya", "ti", "1036402659", "gman@gmail.com", "3007255896", "Armando Casas", "6A", new DateOnly(2012, 03, 10), new List<double> { 4.7, 4.4, 4.2, 5, 5, 4.6, 4.5, 5 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Ferxxo", "Giraldo", "ti", "1086402699", "lindop@gmail.com", "3107755896", "Elza Pito", "6A", new DateOnly(2012, 04, 12), new List<double> { 3.9, 4.6, 4.2, 3.2, 3.5, 2.9, 4, 4.2 }));


AdministradorApp.AgregarProfesor(new Profesor("Jhony", "Se", "cc", "1073402629", "jyc@gmail.com", "3007802663", "Matemáticas", 5600000, new DateTime(2009, 01, 22), new List<string> { "11A" }));
AdministradorApp.AgregarProfesor(new Profesor("Fernando", "Giraldo", "cc", "1086402629", "fer@gmail.com", "3007802563", "Lengua", 2600000, new DateTime(2012, 08, 09), new List<string> { "6A", "9B" }));
AdministradorApp.AgregarProfesor(new Profesor("Majo", "Spector", "cc", "1086402239", "majito@gmail.com", "3007342563", "Informatica", 3000000, new DateTime(2020, 01, 12), new List<string> { "10A", "8B" }));


void ListarEstudiantes()
{
    Interfaz.EncabezadoEstudiantes();
    AdministradorApp.MostrarEstudiantes();
    Interfaz.SeparadorEstudiantes();
    Console.Write(@"
Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Main();
}

void ListarProfesores()
{
    Interfaz.EncabezadoProfesores();
    AdministradorApp.MostrarProfesores();
    Interfaz.SeparadorProfesores();
    Console.Write(@"
Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Main();
}

static void salirPrograma()
{
    Console.WriteLine("Saliendo del programa...");
    Console.WriteLine("Gracias por usar el sistema de gestión de la escuela.");
    Environment.Exit(0);
}

void Main()
{
    Console.Clear();
    Console.Write(@$"---------------------------------------------------------------------------------------------
|                   SISTEMA DE ADMINISTRACIÓN DE ESTUDIANTES Y PROFESORES                   |
---------------------------------------------------------------------------------------------
| 1. Listar estudiantes                                                                     |
| 2. Listar profesores                                                                      |
| 0. Salir                                                                                  |
---------------------------------------------------------------------------------------------
POR FAVOR SELECCIONE UN NÚMERO: ");

    byte opcion = Convert.ToByte(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear();
            ListarEstudiantes();
            break;

        case 2:
            Console.Clear();
            ListarProfesores();
            break;

        case 0:
            Console.Clear();
            salirPrograma();
            break;

        default:
            Main();
            break;
    }
}

Main();




