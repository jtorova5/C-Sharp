// ciclo for

using System.Net;

for (int i = 0; i < 10; i++)
{
Console.WriteLine($"{i+1}. Hola mundo!");
}

// ciclo foreach

string[] nombres = { "Juan", "Pedro", "Ana" };

foreach (string nombre in nombres)
{
Console.WriteLine($"Hola {nombre}!");
}

// ciclo while

bool bandera = true;

while (bandera)
{
    Console.WriteLine("Sigue adelante");
    Console.Write("¿Quieres repetir la iteración? ");
    string? respuesta = Console.ReadLine();
    if (respuesta?.ToLower() == "no")
    {
        bandera = false;
    }
}

// ciclo do-while

do
{
    Console.WriteLine("Sigue adelante");
    Console.Write("¿Quieres repetir la iteración? ");
    string? respuesta = Console.ReadLine();
    if (respuesta?.ToLower() == "no")
    {
        break;
    }
} while (true);