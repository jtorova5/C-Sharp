using POO_abstract.Models;

// usando clase padre
// var objetoPadre = new Animal(1, "dogpool", "canina");

// usando clase hija
// var objetoHijo = new Perro(2, "taitus", "canino", false);


void Main()
{
    InterfazGrafica.Encabezado();
    byte opcion = Convert.ToByte(Console.ReadLine());
    var iniciarSesion = new Usuario();

    switch (opcion)
    {
        case 1:
            iniciarSesion.IniciarSesion();
            Console.Write(@"
Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
            Main();
            break;

        case 2:
            iniciarSesion.CerrarSesion();
            break;
            
        default:
        Console.WriteLine(@$"
Opción incorrecta. Intente de nuevo.");
        Main();
        break;
    }
}

Main();