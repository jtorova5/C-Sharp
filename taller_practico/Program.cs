
using System.Security.Cryptography.X509Certificates;
using taller_practico.Models;

AdministradorApp.AgregarEstudiante(new Estudiante("Juan", "Porras", "ti", "1036402699", "juan@gmail.com", "3007755896", "María Ramirez", "6A", new DateOnly(2012, 01, 15), new List<double> { 0, 60, 35, 44, 79, 45, 97, 100 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Miguel", "Díaz", "ti", "1036402799", "miguel@gmail.com", "3007455896", "Freddy Hoyos", "6A", new DateOnly(2012, 02, 15), new List<double> { 0, 60, 35, 44, 79, 45, 97, 100 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Valeria", "Ramirez", "ti", "1026402699", "vale@gmail.com", "3037755896", "María Restrepo", "6A", new DateOnly(2012, 04, 20), new List<double> { 0, 60, 35, 44, 79, 45, 97, 100 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Mateo", "Montoya", "ti", "1036402659", "gman@gmail.com", "3007255896", "Armando Casas", "6A", new DateOnly(2012, 03, 10), new List<double> { 100, 80, 90, 92, 88, 93, 100, 100 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Ferxxo", "Giraldo", "ti", "1086402699", "lindop@gmail.com", "3107755896", "Elza Pito", "6A", new DateOnly(2012, 04, 12), new List<double> { 90, 88, 89, 96, 94, 95, 86, 100 }));
AdministradorApp.AgregarEstudiante(new Estudiante("Majito", "Pinito", "ti", "6143", "mj@gmail.com", "3304582585", "Mario Neta", "11A", new DateOnly(2007, 02, 12), new List<double> { 60, 95, 89, 79, 88, 95, 83, 100 }));


AdministradorApp.AgregarProfesor(new Profesor("Jhony", "Se", "cc", "1073402629", "jyc@gmail.com", "3007802663", "Matemáticas", 5600000, new DateTime(2009, 01, 22), new List<string> { "11A" }));
AdministradorApp.AgregarProfesor(new Profesor("Fernando", "Giraldo", "cc", "1086402629", "fer@gmail.com", "3007802563", "Lengua", 2600000, new DateTime(2012, 08, 09), new List<string> { "6A", "9B" }));
AdministradorApp.AgregarProfesor(new Profesor("Majo", "Spector", "cc", "1086402239", "majito@gmail.com", "3007342563", "Informatica", 3000000, new DateTime(2020, 01, 12), new List<string> { "9C" }));
AdministradorApp.AgregarProfesor(new Profesor("Walter", "Avilez", "cc", "10654134", "wally@gmail.com", "38265435", "Matemáticas", 4200000, new DateTime(2015, 02, 22), new List<string> { "11B", "11C" }));

void irMenu()
{
    Console.Write(@"
Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Main();
}

void ListarEstudiantes()
{
    InterfazGrafica.EncabezadoEstudiantes();
    AdministradorApp.MostrarEstudiantes();
    InterfazGrafica.SeparadorEstudiantes();
}

void ListarProfesores()
{
    InterfazGrafica.EncabezadoProfesores();
    AdministradorApp.MostrarProfesores();
    InterfazGrafica.SeparadorProfesores();
}

void AgregarEstudiante()
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("                      AGREGAR ESTUDIANTE                        ");
    Console.WriteLine("----------------------------------------------------------------");
    Console.Write("Nombre: ");
    string? nombre = Console.ReadLine();
    Console.Write("Apellido: ");
    string? apellido = Console.ReadLine();
    Console.Write("Tipo de documento: ");
    string? tipoDocumento = Console.ReadLine();
    Console.Write("Número de documento: ");
    string? numeroDocumento = Console.ReadLine();
    Console.Write("Correo electrónico: ");
    string? email = Console.ReadLine();
    Console.Write("Teléfono: ");
    string? telefono = Console.ReadLine();
    Console.Write("Nombre del acudiente: ");
    string? nombreAcudiente = Console.ReadLine();
    Console.Write("Curso actual: ");
    string? cursoActual = Console.ReadLine();
    Console.Write("Fecha de nacimiento (AAAA/DD/MM): ");
    DateOnly fechaNacimiento = DateOnly.Parse(Console.ReadLine());
    var calificaciones = Estudiante.AgregarCalificaciones();

    AdministradorApp.AgregarEstudiante(new Estudiante(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, nombreAcudiente, cursoActual, fechaNacimiento, calificaciones));
    Console.WriteLine("El estudiante se agregó correctamente!");
    irMenu();
}

void AgregarProfesor()
{
    Console.Clear();
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("                       AGREGAR PROFESOR");
    Console.WriteLine("----------------------------------------------------------------");
    Console.Write("Nombre: ");
    string? nombre = Console.ReadLine();
    Console.Write("Apellido: ");
    string? apellido = Console.ReadLine();
    Console.Write("Tipo de documento: ");
    string? tipoDocumento = Console.ReadLine();
    Console.Write("Número de documento: ");
    string? numeroDocumento = Console.ReadLine();
    Console.Write("Correo electrónico: ");
    string? email = Console.ReadLine();
    Console.Write("Teléfono: ");
    string? telefono = Console.ReadLine();
    Console.Write("Asignatura: ");
    string? asignatura = Console.ReadLine();
    Console.Write("Salario (COP): ");
    double salario = double.Parse(Console.ReadLine());
    Console.Write("Fecha de inicio de contrato (AAAA/MM/DD): ");
    DateTime fechaContrato = DateTime.Parse(Console.ReadLine());
    var cursos = Profesor.AgregarCursos();

    AdministradorApp.AgregarProfesor(new Profesor(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, asignatura, salario, fechaContrato, cursos));
    Console.WriteLine("El profesor se agregó correctamente!");
    irMenu();
}

void ActualizarEstudiante()
{
    Console.Clear();
    ListarEstudiantes();
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("                       ACTUALIZAR ESTUDIANTE");
    Console.WriteLine("----------------------------------------------------------------");
    Console.Write("INGRESE EL NÚMERO DE DOCUMENTO DEL ESTUDIANTE: ");
    string? numeroDocumento = Console.ReadLine();
    AdministradorApp.ActualizarEstudiante(numeroDocumento);
    irMenu();
}

void ActualizarProfesor()
{
    Console.Clear();
    ListarProfesores();
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("                       ACTUALIZAR PROFESOR");
    Console.WriteLine("----------------------------------------------------------------");
    Console.Write("INGRESE EL NÚMERO DE DOCUMENTO DEL PROFESOR: ");
    string? numeroDocumento = Console.ReadLine();
    AdministradorApp.ActualizarProfesor(numeroDocumento);
    irMenu();
}

void EliminarEstudiante()
{
    Console.Clear();
    ListarEstudiantes();
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("                      ELIMINAR ESTUDIANTE");
    Console.WriteLine("----------------------------------------------------------------");
    Console.Write("INGRESE EL NÚMERO DE DOCUMENTO DEL ESTUDIANTE: ");
    string? numeroDocumento = Console.ReadLine();
    AdministradorApp.EliminarEstudiante(numeroDocumento);
    irMenu();
}

void EliminarProfesor()
{
    Console.Clear();
    ListarProfesores();
    Console.WriteLine("----------------------------------------------------------------");
    Console.WriteLine("                      ELIMINAR PROFESOR");
    Console.WriteLine("----------------------------------------------------------------");
    Console.Write("INGRESE EL NÚMERO DE DOCUMENTO DEL PROFESOR: ");
    string? numeroDocumento = Console.ReadLine();
    AdministradorApp.EliminarProfesor(numeroDocumento);
    irMenu();
}

void MostrarEstudiantesConPromedioMayorA85()
{
    Console.Clear();
    InterfazGrafica.EncabezadoEstudiantes();
    AdministradorApp.MostrarEstudiantesConPromedioMayorA85();
    InterfazGrafica.SeparadorEstudiantes();
    irMenu();
}

void MostrarProfesoresConMasDeUnCurso()
{
    Console.Clear();
    InterfazGrafica.EncabezadoProfesores();
    AdministradorApp.MostrarProfesoresConMasDeUnCurso();
    InterfazGrafica.SeparadorProfesores();
    irMenu();
}

void MostrarEstudiantesMayoresDe16Años()
{
    Console.Clear();
    InterfazGrafica.EncabezadoEstudiantes();
    AdministradorApp.MostrarEstudiantesMayoresDe16Años();
    InterfazGrafica.SeparadorEstudiantes();
    irMenu();
}

void OrdenarEstudiantesPorApellidoAscendente()
{
    Console.Clear();
    InterfazGrafica.EncabezadoEstudiantes();
    AdministradorApp.OrdenarEstudiantesPorApellidoAscendente();
    InterfazGrafica.SeparadorEstudiantes();
    irMenu();
}

void CalcularSalarioTotalProfesores()
{
    ListarProfesores();
    AdministradorApp.CalcularSalarioTotalProfesores();
    irMenu();
}

void MostrarEstudianteConPromedioMasAlto()
{
    ListarEstudiantes();
    AdministradorApp.MostrarEstudianteConPromedioMasAlto();
    irMenu();
}

void DeterminarCantidadDeEstudiantesPorCurso()
{
    ListarEstudiantes();
    AdministradorApp.DeterminarCantidadDeEstudiantesPorCurso();
    irMenu();
}

void MostrarProfesoresConMasDe10Años()
{
    InterfazGrafica.EncabezadoProfesores();
    AdministradorApp.MostrarProfesoresConMasDe10Años();
    InterfazGrafica.SeparadorProfesores();
    irMenu();
}

void MostrarMateriasEscuela()
{
    InterfazGrafica.EncabezadoMaterias();
    AdministradorApp.MostrarMateriasEscuela();
    InterfazGrafica.SeparadorMaterias();
    irMenu();
}

void MostrarEstudiantesConAcudienteMaria()
{
    Console.Clear();
    InterfazGrafica.EncabezadoEstudiantes();
    AdministradorApp.MostrarEstudiantesConAcudienteMaria();
    InterfazGrafica.SeparadorEstudiantes();
    irMenu();
}

void OrdenarProfesoresPorSalarioDescendente()
{
    Console.Clear();
    InterfazGrafica.EncabezadoProfesores();
    AdministradorApp.OrdenarProfesoresPorSalarioDescendente();
    InterfazGrafica.SeparadorProfesores();
    irMenu();
}

void CalcularPromedioEdadEstudiantes()
{
    ListarEstudiantes();
    AdministradorApp.CalcularPromedioEdadEstudiantes();
    irMenu();
}

void MostrarProfesoresDeMatematicas()
{
    InterfazGrafica.EncabezadoProfesores();
    AdministradorApp.MostrarProfesoresDeMatematicas();
    InterfazGrafica.SeparadorProfesores();
    irMenu();
}

void MostrarEstudiantesConMasDe3CalificacionesRegistradas()
{
    InterfazGrafica.EncabezadoEstudiantes();
    AdministradorApp.MostrarEstudiantesConMasDe3CalificacionesRegistradas();
    InterfazGrafica.SeparadorEstudiantes();
    irMenu();
}

void CalcularAntiguedadPromedioProfesores()
{
    Console.Clear();
    ListarProfesores();
    AdministradorApp.CalcularAntiguedadPromedioProfesores();
    irMenu();
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
    InterfazGrafica.InterfazMenu();

    byte opcion = Convert.ToByte(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Clear();
            ListarEstudiantes();
            irMenu();
            break;

        case 2:
            Console.Clear();
            ListarProfesores();
            irMenu();
            break;

        case 3:
            Console.Clear();
            AgregarEstudiante();
            break;

        case 4:
            Console.Clear();
            AgregarProfesor();
            break;

        case 5:
            Console.Clear();
            ActualizarEstudiante();
            break;

        case 6:
            Console.Clear();
            ActualizarProfesor();
            break;

        case 7:
            Console.Clear();
            EliminarEstudiante();
            break;

        case 8:
            Console.Clear();
            EliminarProfesor();
            break;

        case 9:
            Console.Clear();
            MostrarEstudiantesConPromedioMayorA85();
            break;

        case 10:
            Console.Clear();
            MostrarProfesoresConMasDeUnCurso();
            break;

        case 11:
            Console.Clear();
            MostrarEstudiantesMayoresDe16Años();
            break;

        case 12:
            Console.Clear();
            OrdenarEstudiantesPorApellidoAscendente();
            break;

        case 13:
            Console.Clear();
            CalcularSalarioTotalProfesores();
            break;

        case 14:
            Console.Clear();
            MostrarEstudianteConPromedioMasAlto();
            break;

        case 15:
            Console.Clear();
            DeterminarCantidadDeEstudiantesPorCurso();
            break;

        case 16:
            Console.Clear();
            MostrarProfesoresConMasDe10Años();
            break;

        case 17:
            Console.Clear();
            MostrarMateriasEscuela();
            break;

        case 18:
            Console.Clear();
            MostrarEstudiantesConAcudienteMaria();
            break;

        case 19:
            Console.Clear();
            OrdenarProfesoresPorSalarioDescendente();
            break;

        case 20:
            Console.Clear();
            CalcularPromedioEdadEstudiantes();
            break;

        case 21:
            Console.Clear();
            MostrarProfesoresDeMatematicas();
            break;

        case 22:
            Console.Clear();
            MostrarEstudiantesConMasDe3CalificacionesRegistradas();
            break;

        case 23:
            Console.Clear();
            CalcularAntiguedadPromedioProfesores();
            break;

        case 24:
            Console.Clear();
            salirPrograma();
            break;

        default:
            Main();
            break;
    }
}

Main();




