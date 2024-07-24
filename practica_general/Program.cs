using practica_general.Models;

List<Estudiante> estudiantes = new List<Estudiante>();

estudiantes.Add(new Estudiante(1, "Juan", 8, "2A"));
estudiantes.Add(new Estudiante(2, "Maria", 8, "2B"));
estudiantes.Add(new Estudiante(3, "Pedro", 7, "2C"));
estudiantes.Add(new Estudiante(4, "Ana", 9, "3D"));

Console.WriteLine(@$"#######################################################
#                     ESTUDIANTES                     #
#######################################################
| Nro |       Nombre       |   Edad   |     Grupo     |     
-------------------------------------------------------");

foreach (var estudiante in estudiantes)
{
    estudiante.MostrarEstudiante();
}

Console.WriteLine("-------------------------------------------------------");

Console.WriteLine("-------------------------------------------------------");

Tienda tienda = new Tienda();
Prenda prendaNueva = new Prenda(1, "Camisa", "L", 52000);

tienda.prendas.Add(prendaNueva);

foreach (Prenda prenda in tienda.prendas)
{
    Console.WriteLine($"{prenda.Id}");
}

