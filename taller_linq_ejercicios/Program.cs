// funciones

void imprimirInt(string mensaje, List<int> lista)
{
    Console.Write(mensaje);
    foreach (var item in lista)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

void imprimirString(string mensaje, List<string> lista)
{
    Console.Write(mensaje);
    foreach (var item in lista)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

// ------------------------------------------------------------------

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Filtrar y mostrar solo los números pares de la lista numbers.

var pares = numbers.Where(number => number % 2 == 0).ToList();

Console.WriteLine("------------------------------------------------");

imprimirInt("1. Lista números: ", numbers);
imprimirInt("1. Lista números pares: ", pares);

Console.WriteLine("------------------------------------------------");

// Usando LINQ, calcular la suma de todos los números impares en la lista numbers.

var sumaImpares = numbers.Where(number => number % 2!= 0).Sum();

Console.WriteLine("------------------------------------------------");

imprimirInt("2. Lista números: ", numbers);
Console.Write($"2. Suma de números impares: {sumaImpares}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Ordenar de manera descendente los números mayores que 5 en la lista numbers.

var mayores5 = numbers.Where(number => number > 5).OrderByDescending(number => number).ToList();

Console.WriteLine("------------------------------------------------");

imprimirInt("3. Lista números: ", numbers);
imprimirInt("3. Lista números mayores que 5: ", mayores5);

Console.WriteLine("------------------------------------------------");

// Contar cuántos números son menores o iguales a 3 en la lista numbers.

var menores3 = numbers.Count(number => number <= 3);

Console.WriteLine("------------------------------------------------");

imprimirInt("4. Lista números: ", numbers);
Console.Write($"4. Números menores o iguales a 3: {menores3}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Seleccionar cada número en la lista numbers y multiplicarlo por 2.

var multiplicados = numbers.Select(number => number * 2).ToList();

Console.WriteLine("------------------------------------------------");

imprimirInt("5. Lista números: ", numbers);
imprimirInt("5. Lista multiplicados por 2: ", multiplicados);

Console.WriteLine("------------------------------------------------");

// ------------------------------------------------------------------

List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };

// Ordenar los nombres en la lista names alfabéticamente.

var ordenados = names.OrderBy(name => name).ToList();

Console.WriteLine("------------------------------------------------");

imprimirString("6. Lista nombres: ", names);
imprimirString("6. Lista ordenada: ", ordenados);

Console.WriteLine("------------------------------------------------");

// Seleccionar los nombres en la lista names que empiezan con la letra 'A'.

var empiezanA = names.Where(name => name.StartsWith("A")).ToList();

Console.WriteLine("------------------------------------------------");

imprimirString("7. Lista nombres: ", names);
imprimirString("7. Nombres con 'A': ", empiezanA);

Console.WriteLine("------------------------------------------------");

// Contar cuántos nombres en la lista names tienen más de 5 caracteres.

var conMasDe5Caracteres = names.Count(name => name.Length > 5);

Console.WriteLine("------------------------------------------------");

imprimirString("8. Lista nombres: ", names);
Console.Write($"8. Nombres con más de 5 caracteres: {conMasDe5Caracteres}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.

var concatenados = string.Join(" ", names);

Console.WriteLine("------------------------------------------------");

imprimirString("9. Lista nombres: ", names);
Console.Write($"9. Nombres concatenados: {concatenados}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Encontrar y mostrar el nombre más largo en la lista names.

var nombreMasLargo = names.OrderByDescending(name => name.Length).FirstOrDefault();

Console.WriteLine("------------------------------------------------");

imprimirString("10. Lista nombres: ", names);
Console.Write($"10. Nombre más largo: {nombreMasLargo}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// ------------------------------------------------------------------

List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

// Verificar si todas las palabras en la lista words tienen más de 3 caracteres.

var todasMasDe3Caracteres = words.All(word => word.Length > 3);

Console.WriteLine("------------------------------------------------");

imprimirString("11. Lista palabras: ", words);
Console.Write($"11. ¿Todas tienen más de 3 caracteres?: {todasMasDe3Caracteres}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.

var primeraB = words.FirstOrDefault(word => word.StartsWith('b'));

Console.WriteLine("------------------------------------------------");

imprimirString("12. Lista palabras: ", words);
Console.Write($"12. Primera palabra que empieza con 'b': {primeraB ?? "No se encontró ninguna palabra que empieza con 'b'"}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Contar cuántas palabras en la lista words contienen la letra 'e'.

var conE = words.Count(word => word.Contains('e'));

Console.WriteLine("------------------------------------------------");

imprimirString("13. Lista palabras: ", words);
Console.Write($"13. Palabras que contienen la letra 'e': {conE}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.

var mayusculas = words.Select(word => word.ToUpper()).ToList();

Console.WriteLine("------------------------------------------------");

imprimirString("14. Lista palabras: ", words);
imprimirString("14. Palabras en mayúsculas: ", mayusculas);

Console.WriteLine("------------------------------------------------");

// Verificar si alguna palabra en la lista words termina con la letra 'y'.

var terminaY = words.Any(word => word.EndsWith('y'));

Console.WriteLine("------------------------------------------------");

imprimirString("15. Lista palabras: ", words);
Console.Write($"15. ¿Alguna palabra termina con 'y'?: {terminaY}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// ------------------------------------------------------------------

List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };

// Combinar y ordenar las listas data y moreData de forma ascendente.

var combined = data.Concat(moreData).OrderBy(number => number).ToList();

Console.WriteLine("------------------------------------------------");

imprimirInt("16. Lista data: ", data);
imprimirInt("16. Lista moreData: ", moreData);
imprimirInt("16. Lista combinada y ordenada: ", combined);

Console.WriteLine("------------------------------------------------");

// Calcular la suma de todos los números pares en la lista data.

var sumaPares = data.Where(number => number % 2 == 0).Sum();

Console.WriteLine("------------------------------------------------");

imprimirInt("17. Lista data: ", data);
Console.Write($"17. Suma de números pares: {sumaPares}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Encontrar el número más grande en la lista data.

var numeroMasGrande = data.Max();

Console.WriteLine("------------------------------------------------");

imprimirInt("18. Lista data: ", data);
Console.Write($"18. Número más grande: {numeroMasGrande}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");

// Unir las listas data y moreData, eliminando los elementos duplicados.

var union = data.Union(moreData).ToList();

Console.WriteLine("------------------------------------------------");

imprimirInt("19. Lista data: ", data);
imprimirInt("19. Lista moreData: ", moreData);
imprimirInt("19. Lista union sin duplicados: ", union);

Console.WriteLine("------------------------------------------------");

// Calcular el promedio de la lista moreData y seleccionar los números en data que son mayores que ese promedio.

var promedio = moreData.Average();
var mayoresPromedio = data.Where(number => number > promedio).ToList();

Console.WriteLine("------------------------------------------------");

imprimirInt("20. Lista moreData: ", moreData);
Console.Write($"20. Promedio moreData: {promedio}");
imprimirInt("20. Lista data: ", data);
imprimirInt("20. Números en data mayores que el promedio de moreData: ", mayoresPromedio);

Console.WriteLine("------------------------------------------------");

// Contar cuántos números en la lista moreData son números primos(te recomiendo crear una función independiente que valide si el número es primo o no lo es, luego esa funciona pasala al método LINQ adecuado).

bool EsPrimo(int number)
{
    if (number <= 1)
        return false;
    for (int i = 2; i <= number/2; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}   

var primos = moreData.Count(number => EsPrimo(number));

Console.WriteLine("------------------------------------------------");

imprimirInt("21. Lista moreData: ", moreData);
Console.Write($"21. Cantidad de números primos en moreData: {primos}");
Console.WriteLine();

Console.WriteLine("------------------------------------------------");