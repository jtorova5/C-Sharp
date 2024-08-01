using System.ComponentModel.Design;
using repaso_general.Models;

var empleado1 = new Empleado("Jhonatan", "Toro", "1036402697", 27, "Analista", 2500000);
var empleado2 = new Empleado("Majo", "Pino", "43727596", 19, "Practicante", 1300000);

Empresa.AgregarEmpleado(empleado1);
Empresa.AgregarEmpleado(empleado2);

var cliente1 = new Cliente("david", "torres", 24, "davidtorres@gmail.com", "3007762853");
var cliente2 = new Cliente("felipe", "dominguez", 18, "felipedomin10@gmail.com", "3007476283");

Empresa.AgregarCliente(cliente1);
Empresa.AgregarCliente(cliente2);

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
    Console.WriteLine();
    var empleado = Administracion.CrearEmpleado();
    Empresa.AgregarEmpleado(empleado);
}

void EliminarEmpleado()
{
    Console.Write("Ingrese el número de identifiación del empleado a eliminar: ");
    var numeroDeIdentificacion = Console.ReadLine().Trim();
    Empresa.EliminarEmpleado(numeroDeIdentificacion);
}

void AgregarCliente()
{
    Console.WriteLine("Ingrese los datos del nuevo cliente:");
    Console.WriteLine();
    var cliente = Administracion.CrearCliente();
    Empresa.AgregarCliente(cliente);
}

void EliminarCliente()
{
    Empresa.EliminarCliente();
}

void MostrarTodosLosClientes()
{
    Empresa.MostrarTodosLosClientes();
}

void Salir()
{
    Console.WriteLine("Saliendo...");
    Console.WriteLine("Gracias por usar nuestro programa!");
    Environment.Exit(0);
}

void Menu()
{
    Console.Clear();
    Administracion.MostrarMenu();
    string input = Console.ReadLine();

    if (int.TryParse(input, out int opcion) || opcion < 1 || opcion > 7)
    {
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
                Empresa.MostrarTodosLosEmpleados();
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
                AgregarCliente();
                irMenu();
                break;
            case 8:
                Console.Clear();
                MostrarTodosLosClientes();
                EliminarCliente();
                irMenu();
                break;
            case 9:
                Console.Clear();
                MostrarTodosLosClientes();
                irMenu();
                break;
            case 10:
                Console.Clear();
                Salir();
                return;
            default:
                Console.WriteLine("Opción inválida, intente nuevamente.");
                irMenu();
                break;
        }
    }
}

Menu();