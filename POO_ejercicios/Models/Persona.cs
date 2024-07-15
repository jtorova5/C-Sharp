using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ejercicios.Models;

// Crea una clase Persona con propiedades Nombre y Edad.
public class Persona
{
    public string? Nombre { get; set; }
    public int Edad { get; set; }

    // Añade un método Saludar() a la clase Persona que imprima "Hola, mi nombre es [Nombre]".
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}");
    }

    public Persona()
    {

    }

    // Añade un constructor a la clase Persona que acepte Nombre y Edad como parámetros.
    public Persona(string nombre, int edad)
    {
        // Modifica la clase Persona para que el nombre siempre se almacene en minúsculas.
        Nombre = nombre.ToLower();
        Edad = edad;
    }

    // Añade un método MostrarDetalles() que imprima el nombre y la edad.
    public void MostrarDetalles()
    {
        Console.WriteLine(@$"Nombre: {Nombre}
Edad: {Edad} años");
    }
}
