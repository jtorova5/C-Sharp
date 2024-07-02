// Escribe un programa que imprima “¡Hola, mundo!" en la consola.
using System.Text.RegularExpressions;

Console.WriteLine("-----------------Ejercicio 1---------------");

Console.WriteLine("Hola mundo!");

Console.WriteLine("-------------------------------------------");


// Declara un int y un string, asignarles valores e imprímelos.

Console.WriteLine("-----------------Ejercicio 2---------------");

int num1 = 26;
string st1 = "Jhonatan";

Console.WriteLine($"Mi nombre es {st1} y tengo {num1} años!");

Console.WriteLine("-------------------------------------------");

// Convierte un string a mayúsculas y a minúsculas.

Console.WriteLine("-----------------Ejercicio 3---------------");

string st2 = "Jhonatan";

Console.WriteLine(@$"Mi nombre en mayúsculas: {st2.ToUpper()} 
Mi nombre en minúsculas: {st2.ToLower()}");

Console.WriteLine("-------------------------------------------");

// Declara dos int, realizar suma, resta, multiplicación y división, y muestra los resultados.

Console.WriteLine("-----------------Ejercicio 4---------------");

byte num2 = 10, num3 = 20;

Console.WriteLine(@$"Suma: {num2} + {num3} = {num2 + num3}
Resta: {num3} - {num2} = {num3 - num2}
Multiplicación: {num2} * {num3} = {num2 * num3}
División: {num3} / {num2} = {num3 / num2}");

Console.WriteLine("-------------------------------------------");

// Declara dos int, realiza comparaciones de igualdad, desigualdad, mayor que y menor que, y muestra los resultados.

Console.WriteLine("-----------------Ejercicio 5---------------");

byte num4 = 5, num5 = 10;

Console.WriteLine(@$"{num4} = {num5}? {num4 == num5}
{num4} != {num5}? {num4 != num5}
{num4} > {num5}? {num4 > num5}
{num4} < {num5}? {num4 < num5}");

Console.WriteLine("-------------------------------------------");

// Busca una palabra específica en un string y reemplazarla por otra.

Console.WriteLine("-----------------Ejercicio 6---------------");

string st3 = "El clan Berners Lee es el mejor!";
Console.WriteLine($"Original: {st3}");
string buscada = "Berners Lee", reemplazo = "Gates", modificado = st3.Replace(buscada, reemplazo);

Console.WriteLine($"Modificado: {modificado}");

Console.WriteLine("-------------------------------------------");

// Pide al usuario su nombre y edad, luego imprime un mensaje con esta información.

Console.WriteLine("-----------------Ejercicio 7---------------");

Console.Write("Ingrese su nombre: ");
string ?nombreUser = Console.ReadLine();
Console.Write("Ingrese su edad: ");
byte edadUser = Convert.ToByte(Console.ReadLine());

Console.WriteLine(@$"Nombre: {nombreUser}
Edad: {edadUser} años");

Console.WriteLine("-------------------------------------------");

// Declara un int y escribe un programa que indique si es mayor, menor o igual a 10.

Console.WriteLine("-----------------Ejercicio 8---------------");

byte num6 = Convert.ToByte(Console.ReadLine()), num7 = Convert.ToByte(Console.ReadLine());

if (num6 > num7)
{
    Console.WriteLine($"{num6} es mayor que {num7}");
}
else if (num6 > num7)
{
    Console.WriteLine($"{num6} es menor que {num7}");
}
else
{
    Console.WriteLine($"{num6} es igual a {num7}");
}

Console.WriteLine("-------------------------------------------");

// Declara dos variables double, realiza suma, resta, multiplicación y división, y muestra los resultados.

Console.WriteLine("-----------------Ejercicio 8---------------");


Console.WriteLine("-------------------------------------------");

// ● Declarar dos variables string, concatenarlas y mostrar el resultado.
// ● Declara una variable int, conviértela a double y muestra ambos valores.
// ● Escribe un programa que pida al usuario un número y muestre si es positivo, negativo o
// cero.
// ● Usa un bucle for para imprimir los números del 1 al 10.
// ● Elimina los espacios en blanco al inicio y al final de un string, y formatea el string para que
// empiece con mayúscula y el resto en minúsculas.
// ● Escribe un programa que pida al usuario un número y muestre su tabla de multiplicar del 1
// al 10.
// ● Concatena dos strings y muestra la longitud de cada uno.
// ● Extrae una subcadena de un string y muestra la subcadena y su longitud.
