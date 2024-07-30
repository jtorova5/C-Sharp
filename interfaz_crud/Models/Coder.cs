using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using interfaz_crud.Interfaces;

namespace interfaz_crud.Models;

public class Coder : ICoder
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Coder(string nombre, string apellido, string email, string telefono)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Telefono = telefono;
    }

    public void Actualizar()
    {
        Console.Write("Ingrese email del estudiante a actualizar: ");
        string Email = Console.ReadLine();
        Console.Write("Ingrese nombre nuevo: ");
        string Nombre = Console.ReadLine();
        Console.Write("Ingrese apellido nuevo: ");
        string Apellido = Console.ReadLine();
        Console.Write("Ingrese email nuevo: ");
        string EmailNuevo = Console.ReadLine();
        Console.Write("Ingrese telefono nuevo: ");
        string Telefono = Console.ReadLine();

        var coder = Storage.Coders.FirstOrDefault(c => c.Email == Email);
        if (coder != null)
        {
            coder.Nombre = Nombre;
            coder.Apellido = Apellido;
            coder.Email = EmailNuevo;
            coder.Telefono = Telefono;
            Console.WriteLine("Datos actualizados correctamente.");
        }
    }

    public void Agregar()
    {
        Console.WriteLine("Ingrese nombre: ");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese apellido: ");
        string Apellido = Console.ReadLine();
        Console.WriteLine("Ingrese email: ");
        string Email = Console.ReadLine();
        Console.WriteLine("Ingrese telefono: ");
        string Telefono = Console.ReadLine();

        Storage.Coders.Add(new Coder(Nombre, Apellido, Email, Telefono));
    }

    public void Eliminar()
    {
        Console.Write("Ingrese email del estudiante a eliminar: ");
        string Email = Console.ReadLine();

        var coder = Storage.Coders.FirstOrDefault(c => c.Email == Email);
        if (coder != null)
        {
            Storage.Coders.Remove(coder);
            Console.WriteLine("Estudiante eliminado correctamente.");
        }
    }

    public void Mostrar()
    {
        Console.WriteLine("Listado de estudiantes:");
        Console.WriteLine();
        foreach (var coder in Storage.Coders)
        {
            Console.WriteLine($"ID: {coder.Id}, Nombre: {coder.Nombre} {coder.Apellido}, Email: {coder.Email}, Teléfono: {coder.Telefono}");
        }
    }
}
