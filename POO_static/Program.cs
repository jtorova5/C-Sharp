using POO_static.Models;

// uso de propieades y métodos
// var Ejemplo1 = new Ejemplo();
// Console.WriteLine($"Nombre: {Ejemplo1.Nombre}");
// Console.WriteLine($"Apellido: {Ejemplo1.Apellido}");
// Ejemplo1.Saludar();

// uso de propiedades y métodos pero con el static
// EjemploEstatico.Nombre = "Jhonatan";
// EjemploEstatico.Apellido = "Toro Vásquez";

// Console.WriteLine($"Nombre: {EjemploEstatico.Nombre}");
// Console.WriteLine($"Apellido: {EjemploEstatico.Apellido}");
// EjemploEstatico.Saludar();

// uso de un constructor static
// EjemploEstatico.Saludar();

EjemploHibrido.MostrarHeader();
var nuevoUsuario = new EjemploHibrido(1, "Jhonatan", "Toro Vásquez", 180);
Console.WriteLine(EjemploHibrido.FechaActual);
nuevoUsuario.mostrarInformacion();
EjemploHibrido.MostrarFooter();
