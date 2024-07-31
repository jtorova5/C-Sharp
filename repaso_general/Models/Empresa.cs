using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repaso_general.Models;

public class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public static List<Empleado> ListaEmpleados { get; set; } = new List<Empleado>();

    public static void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }

    public static void EliminarEmpleado(string nombreCompleto)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NombreCompleto.ToLower() == nombreCompleto);

        if (empleado!= null)
        {
            ListaEmpleados.Remove(empleado);
            Console.WriteLine($"Empleado {nombreCompleto} eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public static void MostrarTodosLosEmpleados()
    {
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("|   Nombre Completo   |      Id      | Edad |    Posición    |    Salario    |");
        Console.WriteLine("------------------------------------------------------------------------------");

        foreach (var empleado in ListaEmpleados)
        {
            Console.WriteLine($"| {empleado.NombreCompleto, -19} | {empleado.NumeroDeIdentificacion, -12} |  {empleado.Edad, -3} | {empleado.Posicion, -14} | {empleado.Salario.ToString("0.00"), -13} |");
        }
        Console.WriteLine("------------------------------------------------------------------------------");
    }

    public static void ActualizarEmpleado()
    {
        Console.Write("Ingrese el número de identificación del empleado a actualizar: ");
        var numeroDeIdentificacion = Console.ReadLine().Trim().ToLower();

        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);

        if (empleado != null)
        {
            Console.WriteLine("Ingrese los nuevos datos:");
            Console.Write("Nombre: ");
            empleado.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            empleado.Apellido = Console.ReadLine();
            Console.Write("Posición: ");
            empleado.Posicion = Console.ReadLine();
            Console.Write("Salario: ");
            empleado.Salario = Convert.ToDouble(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public static void BuscarEmpleado()
    {
        Console.Write("Ingrese el número de identificación del empleado a actualizar: ");
        var numeroDeIdentificacion = Console.ReadLine().Trim().ToLower();

        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);

        if (empleado != null)
        {
            Console.WriteLine($"ID: {empleado.Id}, Nombre: {empleado.Nombre} {empleado.Apellido}, Posición: {empleado.Posicion}");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public static void MostrarEmpleadosPorCargo()
    {
        Console.WriteLine("Cargos disponibles: ");
        foreach (var posicion in ListaEmpleados.Select(e => e.Posicion).Distinct())
        {
            Console.WriteLine(posicion);
        }

        Console.WriteLine("Ingrese el cargo para buscar:");
        var cargo = Console.ReadLine().Trim().ToLower();

        var empleadosPorCargo = ListaEmpleados.Where(e => e.Posicion == cargo).ToList();
        Console.WriteLine($"Empleados con cargo {cargo}: ");
        foreach (var empleado in empleadosPorCargo)
        {
            Console.WriteLine($"Id: {empleado.Id}, Nombre: {empleado.Nombre} {empleado.Apellido}");
        }
    }
}
