using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repaso_general.Models;

public abstract class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public static List<Empleado> ListaEmpleados { get; set; } = new List<Empleado>();
    public static List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

    public static void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }

    public static void EliminarEmpleado(string numeroDeIdentificacion)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion.Trim() == numeroDeIdentificacion);

        if (empleado != null)
        {
            ListaEmpleados.Remove(empleado);
            Console.Clear();
            Console.WriteLine($"Empleado con id: {numeroDeIdentificacion} eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public static void MostrarTodosLosEmpleados()
    {
        Administracion.MostrarSeparadorTodosLosEmpleados();
        Administracion.MostrarTituloTodosLosEmpleados();
        Administracion.MostrarSeparadorTodosLosEmpleados();

        foreach (var empleado in ListaEmpleados)
        {
            empleado.MostrarInformacion();
        }
        Administracion.MostrarSeparadorTodosLosEmpleados();
    }

    public static void ActualizarEmpleado()
    {
        Console.Write("Ingrese el número de identificación del empleado a actualizar: ");
        var numeroDeIdentificacion = Console.ReadLine().Trim().ToLower();

        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);

        if (empleado != null)
        {
            Console.WriteLine();
            Console.WriteLine("Ingreso de nuevos datos");
            Console.WriteLine();
            Console.Write("Nombre: ");
            var nombre = Console.ReadLine().Trim().ToLower();
            Persona.ActualizarNombre(nombre);
            Console.Write("Apellido: ");
            var apellido = Console.ReadLine().Trim().ToLower();
            Persona.ActualizarApellido(apellido);
            empleado.NombreCompleto = nombre + " " + apellido;
            Console.Write("Posición: ");
            empleado.Posicion = Console.ReadLine().Trim().ToLower();
            Console.Write("Salario: ");
            empleado.Salario = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Empleado {empleado.NombreCompleto} actualizado exitosamente.");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public static void BuscarEmpleado()
    {
        Console.Write("Ingrese el número de identificación del empleado a buscar: ");
        var numeroDeIdentificacion = Console.ReadLine().Trim().ToLower();
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        Console.Clear();

        Administracion.MostrarSeparadorBuscarEmpleado();
        Console.WriteLine($"|                Empleado con número de identificación {numeroDeIdentificacion,-23} |");
        Administracion.MostrarSeparadorBuscarEmpleado();
        Administracion.MostrarTituloBuscarEmpleado();
        Administracion.MostrarSeparadorBuscarEmpleado();
        if (empleado != null)
        {
            empleado.MostrarInformacion();
            Administracion.MostrarSeparadorBuscarEmpleado();
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public static void MostrarEmpleadosPorCargo()
    {
        Administracion.MostrarSeparadorEmpleadoPorCargo();
        Administracion.MostrarTituloEmpleadoPorCargo();
        Administracion.MostrarSeparadorEmpleadoPorCargo();

        foreach (var posicion in ListaEmpleados.Select(e => e.Posicion).Distinct())
        {
            Console.WriteLine($"| {posicion,-18} |");
        }
        Administracion.MostrarSeparadorEmpleadoPorCargo();

        Console.Write("Ingrese el cargo para buscar: ");
        var cargo = Console.ReadLine().Trim().ToLower();

        Console.Clear();
        Administracion.MostrarSeparadorEmpleadoPorCargo2();
        Console.WriteLine($"|                      Empleados con cargo de {cargo,-33}|");
        Administracion.MostrarSeparadorEmpleadoPorCargo2();
        Administracion.MostrarTituloEmpleadoPorCargo2();
        Administracion.MostrarSeparadorEmpleadoPorCargo2();
        var empleadosPorCargo = ListaEmpleados.Where(e => e.Posicion == cargo).ToList();
        foreach (var empleado in empleadosPorCargo)
        {
            empleado.MostrarInformacion();
        }
        Administracion.MostrarSeparadorEmpleadoPorCargo2();
    }

    public static void AgregarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
    }

    public static void EliminarCliente()
    {
        Console.Write("Ingrese el nombre completo del cliente a eliminar: ");
        var nombreCompleto = Console.ReadLine().Trim().ToLower();

        var cliente = ListaClientes.FirstOrDefault(c => c.NombreCompleto.ToLower() == nombreCompleto);

        if (cliente != null)
        {
            ListaClientes.Remove(cliente);
            Console.Clear();
            Console.WriteLine($"Cliente {nombreCompleto} eliminado exitosamente.");
        }
        else
        {
            Console.WriteLine("Cliente no encontrado.");
        }
    }

    public static void MostrarTodosLosClientes()
    {
        Administracion.MostrarSeparadorTodosLosClientes();
        Administracion.MostrarTituloTodosLosClientes();
        Administracion.MostrarSeparadorTodosLosClientes();

        foreach (var cliente in ListaClientes)
        {
            cliente.MostrarInformacion();
        }
        Administracion.MostrarSeparadorTodosLosClientes();
    }
}
