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

void imprimirDouble(string mensaje, List<double> lista)
{
    Console.Write(mensaje);
    foreach (var item in lista)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

// 1. Filtra los números mayores a 10 en una lista de enteros.

var listaEnteros = new List<int> { 10, 13, 9, 8, 25, 30, 22, 11, 7, 6, 2, 9, 77, 20, 80, 3, 55};

var listMayorA10 = listaEnteros.Where(numero => numero > 10).OrderBy(numero => numero).ToList();

Console.WriteLine("----------------------------------------------------------------");

imprimirInt("1. Números mayores a 10: ", listMayorA10);

Console.WriteLine("----------------------------------------------------------------");

// 2. Obtén una lista con los cuadrados de cada número en una lista de enteros.

var cuadrado = listaEnteros.Select(numero => Convert.ToInt32(Math.Pow(numero, 2))).ToList();

Console.WriteLine("----------------------------------------------------------------");

imprimirInt("2. Lista original: ", listaEnteros);
imprimirInt("2. Lista cuadrada: ", cuadrado);

Console.WriteLine("----------------------------------------------------------------");

// 3. Ordena alfabéticamente una lista de nombres.

var listaNombres = new List<string> { "jhonatan", "mariajose", "mateo", "juan jose", "miguel", "faryd", "catalina", "fredy", "salvador", "arlex", "luisa", "valentina"};

var ordenString = listaNombres.OrderBy(nombre => nombre).ToList();

Console.WriteLine("----------------------------------------------------------------");

imprimirString("3. Nombres ordenados: ", ordenString);

Console.WriteLine("----------------------------------------------------------------");

// 4. Ordena una lista de precios de mayor a menor.

var listaPrecios = new List<double> { 500, 1000, 250, 150.2, 20000, 100000, 53000, 30000, 25000, 9500, 2500, 70000, 85200, 300000, 34550, 278000, 2500.99 };

var ordenPrecio = listaPrecios.OrderByDescending(precio => precio).ToList();

Console.WriteLine("----------------------------------------------------------------");

imprimirDouble("4. Precios ordenados: ", ordenPrecio);

Console.WriteLine("----------------------------------------------------------------");

// 5. Encuentra el primer número par en una lista de enteros.

var primerPar = listaEnteros.First(numero => numero % 2 == 0);

Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine($"5. Primer número par: {primerPar}");

Console.WriteLine("----------------------------------------------------------------");

// 6. Encuentra el último nombre en una lista de nombres.

var ultimoNombre = listaNombres.Last();

Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine($"6. Último nombre de la lista: {ultimoNombre}");

Console.WriteLine("----------------------------------------------------------------");

// 7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay ninguno.

var listaEnterosConNegativo = new List<int> { 10, 13, 9, 8, 25, 30, 22, 11, 7, 6, 2, 9, 77, -2};

var negativoSinNegativo = listaEnteros.FirstOrDefault(numero => numero <= 0);
var negativoConNegativo = listaEnterosConNegativo.FirstOrDefault(numero => numero <= 0);

Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine($"7. Primer negativo: {negativoSinNegativo}");
Console.WriteLine($"7. Primer negativo: {negativoConNegativo}");

Console.WriteLine("----------------------------------------------------------------");

// 8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si no hay ninguno.

var ultimoMayorA50 = listaEnteros.Where(numero => numero > 50).Last();

Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine($"8. último mayor a 50: {ultimoMayorA50}");


Console.WriteLine("----------------------------------------------------------------");

// 9. Verifica si algún elemento en una lista de booleanos es verdadero.

var listaBooleanos = new List<bool> {false, false, false, false, false, true};

var hayVerdadero = listaBooleanos.Any(elemento => elemento == true);

Console.WriteLine("----------------------------------------------------------------");

Console.WriteLine($"9. ¿Hay verdadero?: {hayVerdadero}");

Console.WriteLine("----------------------------------------------------------------");

// 10. Verifica si todos los elementos en una lista de números son mayores a 0.

var todosMayores = listaEnteros.All(numero => numero > 0);

Console.WriteLine("----------------------------------------------------------------");

imprimirInt("10. Listado de enteros: ", listaEnteros);
Console.WriteLine($"10. ¿Todos son mayores a 0?: {hayVerdadero}");

Console.WriteLine("----------------------------------------------------------------");

// 11. Comprueba si una lista de palabras contiene la palabra "LINQ".

var listaPalabras = new List<string> { "Hola", "mundo", "esto", "es", "un", "ejemplo", "de", "listado", "de", "palabras", "LINQ" };

var tieneLinq = listaPalabras.Contains("LINQ");

Console.WriteLine("----------------------------------------------------------------");

imprimirString("11. Listado de palabras: ", listaPalabras);
Console.WriteLine($"11. ¿Contiene la palabra 'LINQ'?: {tieneLinq}");

Console.WriteLine("----------------------------------------------------------------");

// 12. Cuenta cuántos números pares hay en una lista de enteros.

var cantidadPares = listaEnteros.Where(numero => numero % 2 == 0).Count();

Console.WriteLine("----------------------------------------------------------------");

imprimirInt("12. Listado de números: ", listaEnteros);
Console.WriteLine($"12. Cantidad de pares: {cantidadPares}");

Console.WriteLine("----------------------------------------------------------------");

// 13. Calcula la suma de los elementos en una lista de precios.

var listaPrecios2 = new List<double> {2500, 1000, 5000, 3200};

var sumaPrecios = listaPrecios2.Sum();

Console.WriteLine("----------------------------------------------------------------");

imprimirDouble("13. Lista precios: ", listaPrecios2);
Console.WriteLine($"13. Suma: {sumaPrecios}");

Console.WriteLine("----------------------------------------------------------------");

// 14. Calcula el promedio de una lista de edades.

var listaEdades = new List<int> { 25, 30, 28, 22, 35, 27, 26, 32, 29, 31 };

var promedioEdades = listaEdades.Average();

Console.WriteLine("----------------------------------------------------------------");

imprimirInt("14. Lista edades: ", listaEdades);
Console.WriteLine($"14. Promedio edad: {promedioEdades}");

Console.WriteLine("----------------------------------------------------------------");

// 15. Encuentra el número mínimo en una lista de temperaturas.

var listaTemperaturas = new List<double> { 25.5, 30.2, 28.9, 22.3, 35.8, 27.6, 26.4, 32.1, 29.7, 31.2 };

var minTemperatura = listaTemperaturas.Min();

Console.WriteLine("----------------------------------------------------------------");

imprimirDouble("15. Lista temperaturas: ", listaTemperaturas);
Console.WriteLine($"15. Temperatura mínima: {minTemperatura}");

Console.WriteLine("----------------------------------------------------------------");

// 16. Encuentra el número máximo en una lista de alturas.

var listaAlturas = new List<double> { 1.75, 1.80, 1.68, 1.72, 1.85, 1.76, 1.74, 1.82, 1.70, 1.78 };

var maxAltura = listaAlturas.Max();

Console.WriteLine("----------------------------------------------------------------");

imprimirDouble("16. Lista alturas: ", listaAlturas);
Console.WriteLine($"16. Temperatura mínima: {maxAltura}");

Console.WriteLine("----------------------------------------------------------------");

// 17. Obtén los primeros 5 elementos de una lista de puntuaciones.

var listaPuntuaciones = new List<double> { 85, 92, 78, 95, 88, 90, 82, 89, 97, 81 };

var primeras5Puntuaciones = listaPuntuaciones.Take(5);

Console.WriteLine("----------------------------------------------------------------");

imprimirDouble("17. Lista puntuaciones: ", listaPuntuaciones);
Console.Write($"17. Primeras 5 puntuaciones: ");

foreach (var item in primeras5Puntuaciones)
{
    Console.Write($"{item} ");
}

Console.WriteLine();
Console.WriteLine("----------------------------------------------------------------");

// 18. Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.
// 19. Elimina los elementos duplicados en una lista de números.
// 20. Convierte una lista de palabras en una lista.
// 21. Convierte una lista de números en un array.
// 22. Filtra los números negativos de una lista y ordénalos de menor a mayor.
// 23. Obtén una lista de longitudes de cada palabra en una lista de palabras.
// 24. Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.
// 25. Obtén los nombres más largos en una lista de nombres.
// 26. Encuentra el primer número mayor a 100 en una lista de precios.
// 27. Encuentra el último día del mes en una lista de fechas.
// 28. Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por
// defecto si no hay ninguno.
// 29. Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay
// ninguno.
// 30. Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.
// 31. Verifica si todas las edades en una lista son mayores de 18.
// 32. Comprueba si una lista de ciudades contiene la ciudad "Madrid".
// 33. Cuenta cuántos números mayores a 50 hay en una lista de puntuaciones.
// 34. Calcula la suma de los números positivos en una lista de enteros.
// 35. Calcula el promedio de las calificaciones en una lista de calificaciones.
// 36. Encuentra la temperatura mínima en una lista de temperaturas.
// 37. Encuentra la altura máxima en una lista de alturas.
// 38. Obtén los primeros 10 elementos de una lista de productos.
// 39. Salta los primeros 5 elementos de una lista de palabras y obtén los siguientes.
// 40. Elimina los elementos duplicados en una lista de nombres y ordénalos alfabéticamente.