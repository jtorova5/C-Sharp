// 1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.

Console.WriteLine("                Ejercicio 1");
Console.WriteLine("-------------------------------------------");

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-------------------------------------------");

// 2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números pares desde 1 hasta ese número usando un ciclo for.

Console.WriteLine("                Ejercicio 2");
Console.WriteLine("-------------------------------------------");

Console.Write("Ingrese un número entero positivo: ");
byte num1 = Convert.ToByte(Console.ReadLine());

for (int i = 1; i <= num1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i}");
    }
}

Console.WriteLine("-------------------------------------------");

// 3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de multiplicar de ese número del 1 al 10 usando un ciclo for.

Console.WriteLine("                Ejercicio 3");
Console.WriteLine("-------------------------------------------");

Console.Write("Ingrese un número entero positivo: ");
byte num2 = Convert.ToByte(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num2} x {i} = {num2 * i}");
}

Console.WriteLine("-------------------------------------------");

// 4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que adivine correctamente usando un ciclo do-while.

Console.WriteLine("                Ejercicio 4");
Console.WriteLine("-------------------------------------------");

Random num3 = new Random();

int min = 1, max = 100;
int randomNumber = num3.Next(min, max + 1);
Console.WriteLine($"Número aleatorio: {randomNumber}");
Console.Write("Adivina el número de 1 - 100: ");
int respuesta = Convert.ToInt32(Console.ReadLine());

do
{
    if (respuesta > randomNumber)
    {
        Console.Write("Demasiado alto, elige otro número: ");
        respuesta = Convert.ToInt32(Console.ReadLine());
    } else if (respuesta < randomNumber)
    {
        Console.Write("Demasiado bajo, elige otro número: ");
        respuesta = Convert.ToInt32(Console.ReadLine());
    } else 
    {
        Console.WriteLine("!Acertaste¡");
        break;
    }
} while (true);

Console.WriteLine("-------------------------------------------");

// 5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los números impares desde ese número hasta 1 usando un ciclo while.

Console.WriteLine("                Ejercicio 5");
Console.WriteLine("-------------------------------------------");

Console.Write("Ingrese un número entero positivo: ");
byte num4 = Convert.ToByte(Console.ReadLine());

while (num4 >= 1)
{
    if (num4 % 2 != 0)
    {
        Console.WriteLine(num4);
    }
    num4--;
}

Console.WriteLine("-------------------------------------------");

// 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta usando un ciclo while.

Console.WriteLine("                Ejercicio 6");
Console.WriteLine("-------------------------------------------");

string password = "secreta";
Console.Write("Ingrese la contraseña: ");
string? st1 = Console.ReadLine().ToLower();

while (true)
{
    if (st1 != password)
    {
        Console.Write("Contraseña incorrecta, vuelve a intentarlo: ");
        st1 = Console.ReadLine().ToLower();
    } else {
        Console.WriteLine("Bienvenido, contraseña correcta");
        break;
    }
}

Console.WriteLine("-------------------------------------------");

// 7. Escribe un programa que solicite al usuario un número entero positivo e imprima la secuencia de Fibonacci hasta ese número usando un ciclo for.

Console.WriteLine("                Ejercicio 7");
Console.WriteLine("-------------------------------------------");

int a = 0, b = 1;

Console.Write("Ingrese un número entero positivo: ");
byte num5 = Convert.ToByte(Console.ReadLine());

Console.WriteLine($"Secuencia de Fibonacci de {num5} términos:");
Console.Write($"{a}, {b}");

for (int i = 2; i < num5; i++)
{
    int c = a + b;
    Console.Write($", {c}");
    a = b;
    b = c;
}

Console.WriteLine("");
Console.WriteLine("-------------------------------------------");

// 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el número es primo o no usando un ciclo for.

Console.WriteLine("                Ejercicio 8");
Console.WriteLine("-------------------------------------------");

Console.Write("Ingrese un número entero positivo: ");
byte num6 = Convert.ToByte(Console.ReadLine());
bool bandera = true;

for (int i = 2; i < num6/2; i++)
{
    if (num6 % i == 0)
    {
        bandera = false;
        break;
    }
}

if (bandera)
{
    Console.WriteLine($"El número {num6} es primo");
} else {
    Console.WriteLine($"El número {num6} NO es primo");
}

Console.WriteLine("-------------------------------------------");

// 9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la palabra en una línea separada usando un ciclo foreach.

Console.WriteLine("                Ejercicio 9");
Console.WriteLine("-------------------------------------------");

Console.Write("Ingrese una palabra: ");
string? st2 = Console.ReadLine();

foreach (char letra in st2)
{
    Console.WriteLine($"{letra}");
}

Console.WriteLine("-------------------------------------------");

// 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma de todos los números desde 1 hasta ese número usando un ciclo for.

Console.WriteLine("                Ejercicio 10");
Console.WriteLine("-------------------------------------------");

Console.Write("Ingrese un número entero positivo: ");
byte num7 = Convert.ToByte(Console.ReadLine());
int suma = 0;

for (int i = 1; i <= num7; i++)
{
    suma += i;
}

Console.WriteLine($"La suma de todos los números desde 1 hasta {num7} es: {suma}");

Console.WriteLine("-------------------------------------------");
