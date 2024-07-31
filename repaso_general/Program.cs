using System.ComponentModel.Design;
using repaso_general.Models;

var empresa = new Empresa();
var empleado1 = new Empleado("Jhonatan", "Toro", "1036402697", 27, "Analista", 2500000);
var empleado2 = new Empleado("Majo", "Pino", "43727596", 19, "Practicante", 1300000);

Empresa.AgregarEmpleado(empleado1);
Empresa.AgregarEmpleado(empleado2);

void irMenu()
{
    Console.Write(@"
Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    Menu();
}

void AgregarEmpleado()
{
    Console.WriteLine("Ingrese los datos del nuevo empleado:");
    Console.Write("Nombre: ");
    var nombre = Console.ReadLine().Trim().ToLower();
    Console.Write("Apellido: ");
    var apellido = Console.ReadLine().Trim().ToLower();
    Console.Write("Número de Identificación: ");
    var numeroDeIdentificacion = Console.ReadLine().Trim().ToLower();
    Console.Write("Edad: ");
    var edad = Convert.ToByte(Console.ReadLine());
    Console.Write("Posición: ");
    var posicion = Console.ReadLine().Trim().ToLower();
    Console.Write("Salario: ");
    var salario = Convert.ToDouble(Console.ReadLine());

    var empleado = new Empleado(nombre, apellido, numeroDeIdentificacion, edad, posicion, salario);
    Empresa.AgregarEmpleado(empleado);
}

void EliminarEmpleado()
{
    Console.Write("Ingrese el nombre completo del empleado a eliminar: ");
    var nombreCompleto = Console.ReadLine().Trim().ToLower();
    Empresa.EliminarEmpleado(nombreCompleto);
}

void Menu()
{
    Console.Clear();
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Agregar empleado");
    Console.WriteLine("2. Eliminar empleado");
    Console.WriteLine("3. Mostrar todos los empleados");
    Console.WriteLine("4. Actualizar empleado");
    Console.WriteLine("5. Buscar empleado");
    Console.WriteLine("6. Mostrar empleados por cargo");
    Console.WriteLine("7. Salir");
    Console.Write("Opción: ");
    var opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.Clear();
            AgregarEmpleado();
            irMenu();
            break;
        case 2:
            Console.Clear();
            Empresa.MostrarTodosLosEmpleados();
            EliminarEmpleado();
            irMenu();
            break;
        case 3:
            Console.Clear();
            Empresa.MostrarTodosLosEmpleados();
            irMenu();
            break;
        case 4:
            Console.Clear();
            Empresa.MostrarTodosLosEmpleados();
            Empresa.ActualizarEmpleado();
            irMenu();
            break;
        case 5:
            Console.Clear();
            Empresa.BuscarEmpleado();
            irMenu();
            break;
        case 6:
            Console.Clear();
            Empresa.MostrarEmpleadosPorCargo();
            irMenu();
            break;
        case 7:
            Console.Clear();
            return;
        default:
            Console.WriteLine("Opción inválida, intente nuevamente");
            irMenu();
            break;
    }
}

Menu();