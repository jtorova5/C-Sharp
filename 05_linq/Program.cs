using System.Collections.Immutable;
using System.ComponentModel;

Console.Clear();

/* 
Variables:

-Cadenas de caracteres - (string-char(1 solo caracter - se asigna con ''))
-Numericos (int, double, byte, float, long, decimal...)
-Booleanos (true, false)

*/

char nombre = 'j';
Console.WriteLine($"Tipo de dato de {nombre}: {nombre.GetType().Name}");

// array - estricto en su tipado
var frutas = new string[]
{
    "banano",
    "pera",
    "sandia"
};

Console.WriteLine($"Tipo de dato: {frutas.GetType().Name}");
Console.WriteLine($"Fruta inicial: {frutas[1]}");
frutas[1] = "fresa";
Console.WriteLine($"Fruta modificada: {frutas[1]}");

// lista números
var numerosLista = new List<byte> {10, 8, 9, 7, 4, 5, 6, 2, 1, 3, 3, 10, 4, 5};

// array números
var numerosArray = new byte[] {10, 8, 9, 7, 4, 5, 6, 2, 1, 3};

// recorrer la lista
Console.Write("Lista recorrida: ");
foreach (var numero in numerosLista)
{
    if (numero % 2 == 0)
    {
    Console.Write($"{numero} ");
    }
}

// recorrer array
Console.WriteLine();
Console.Write("Array recorrido: ");
foreach (var numero in numerosArray)
{
    if (numero % 2 == 0)
    {
    Console.Write($"{numero} ");
    }
}

// numeros con linQ
var numerosParesArray = numerosArray.Where(numero => numero % 2 == 0).ToList();

Console.WriteLine();
Console.Write("List con linq: ");
foreach (var numero in numerosParesArray)
{
    Console.Write($"{numero} ");
}

// números ordenados de forma ascendente
var numerosAsc = numerosArray.OrderBy(numero => numero).ToList();

var numerosDesc = numerosArray.OrderByDescending(numero => numero);

var distinct = numerosLista.Where(numero => numero > 7).Distinct().OrderBy(numero => numero).ToList();

Console.WriteLine();
Console.Write("Números sin duplicados: ");
foreach (var item in distinct)
{
    Console.Write($"{item} ");
}