
using POO_ejercicios.Models;

Console.Clear();

// Crea una instancia de Persona y asigna valores a sus propiedades.
var instanciaPersona = new Persona();
instanciaPersona.Nombre = "Juan Manuel";
instanciaPersona.Edad = 30;

// Muestra los valores en la consola.
Console.WriteLine($"Soy {instanciaPersona.Nombre} y tengo {instanciaPersona.Edad} años");

// Crea una instancia de Persona, asigna valores y llama al método Saludar ().
var instanciaPersona2 = new Persona();
instanciaPersona2.Nombre = "Mariana";
instanciaPersona2.Edad = 28;

instanciaPersona2.Saludar();

// Crea una instancia de Persona usando el constructor y muestra los valores en la consola.

var instanciaPersona3 = new Persona("Cristian", 35);
Console.WriteLine($"Soy {instanciaPersona3.Nombre} y tengo {instanciaPersona3.Edad} años");

var instanciaPersona4 = new Persona("Majo", 19);
instanciaPersona4.MostrarDetalles();