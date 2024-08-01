using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repaso_general.Models;

public static class Administracion
{
    public static Empleado CrearEmpleado()
    {
        Console.Write("Ingrese el nombre del empleado: ");
        var nombre = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese el apellido del empleado: ");
        var apellido = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese el número de identificación del empleado: ");
        var numeroDeIdentificacion = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese la edad del empleado: ");
        var edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la posición del empleado: ");
        var posicion = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese el salario del empleado: ");
        var salario = Convert.ToDouble(Console.ReadLine());

        return new Empleado(nombre, apellido, numeroDeIdentificacion, edad, posicion, salario);
    }

    public static Cliente CrearCliente()
    {
        Console.Write("Ingrese el nombre del cliente: ");
        var nombre = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese el apellido del cliente: ");
        var apellido = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese la edad del cliente: ");
        var edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el email del cliente: ");
        var email = Console.ReadLine().Trim().ToLower();

        Console.Write("Ingrese el teléfono del cliente: ");
        var telefono = Console.ReadLine().Trim().ToLower();

        return new Cliente(nombre, apellido, edad, email, telefono);
    }

    public static void MostrarTituloTodosLosEmpleados()
    {
        Console.WriteLine("|   Nombre Completo   |      Id      | Edad |    Posición    |     Salario     |");
    }

    public static void MostrarSeparadorTodosLosEmpleados()
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
    }

    public static void MostrarTituloBuscarEmpleado()
    {
        Console.WriteLine("|   Nombre Completo   |      Id      | Edad |    Posición    |     Salario     |");
    }

    public static void MostrarSeparadorBuscarEmpleado()
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
    }

    public static void MostrarTituloEmpleadoPorCargo()
    {
        Console.WriteLine("| Cargos disponibles |");
    }

    public static void MostrarSeparadorEmpleadoPorCargo()
    {
        Console.WriteLine("----------------------");
    }

    public static void MostrarTituloEmpleadoPorCargo2()
    {
        Console.WriteLine("|   Nombre Completo   |      Id      | Edad |    Posición    |     Salario     |");
    }

    public static void MostrarSeparadorEmpleadoPorCargo2()
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
    }

    public static void MostrarTituloTodosLosClientes()
    {
        Console.WriteLine("|   Nombre Completo   | Edad |            Email            |     Teléfono     |");
    }

    public static void MostrarSeparadorTodosLosClientes()
    {
        Console.WriteLine("-------------------------------------------------------------------------------");
    }

    public static void MostrarMenu()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("|               Menú              |");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("| 1.  Agregar empleado            |");
        Console.WriteLine("| 2.  Eliminar empleado           |");
        Console.WriteLine("| 3.  Mostrar todos los empleados |");
        Console.WriteLine("| 4.  Actualizar empleado         |");
        Console.WriteLine("| 5.  Buscar empleado             |");
        Console.WriteLine("| 6.  Mostrar empleados por cargo |");
        Console.WriteLine("| 7.  Agregar cliente             |");
        Console.WriteLine("| 8.  Eliminar cliente            |");
        Console.WriteLine("| 9.  Mostrar todos los clientes  |");
        Console.WriteLine("| 10. Salir                       |");
        Console.WriteLine("-----------------------------------");
        Console.Write("Indique el número de la opción deseada: ");
    }
}
