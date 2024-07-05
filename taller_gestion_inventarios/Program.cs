// listas
using System.ComponentModel.DataAnnotations;

List<Dictionary<string, object>> inventario = new List<Dictionary<string, object>>()
{
    new Dictionary<string,object>{
        {"nombre", "doritos"},
        {"precio", 2400},
        {"cantidad", 15}
    },
    new Dictionary<string,object>{
        {"nombre", "papas"},
        {"precio", 2500},
        {"cantidad", 7}
    },
    new Dictionary<string,object>{
        {"nombre", "pan"},
        {"precio", 200},
        {"cantidad", 4}
    }
};

// calculo de total por producto
void totalProductoUnitario()
{
    foreach (var producto in inventario)
    {
        double precio = Convert.ToDouble(producto["precio"]);
        int cantidad = Convert.ToInt32(producto["cantidad"]);
        double total = precio * cantidad;
        producto["total"] = total;

        producto["precio"] = precio.ToString("#,##0.00");
        producto["total"] = total.ToString("#,##0.00");
    }
}

// calculo de total general
double totalGeneral = 0;
void totalProductoGeneral()
{
    foreach (var producto in inventario)
    {
        totalGeneral += Convert.ToDouble(producto["total"]);
    }
}

// listado de productos
void listadoProductos()
{
    Console.WriteLine(@$"###############################################################################################
#                                   LISTADO DE PRODUCTOS                                      #
###############################################################################################
Nro | Nombre                                   | Valor           | Cantidad   | Total          
-----------------------------------------------------------------------------------------------");
    int i = 1;
    foreach (var item in inventario)
    {
        Console.WriteLine(@$"{i,-4}| {item["nombre"],-41}| ${item["precio"],-15}| {item["cantidad"],-11}| ${item["total"],-11}");
        i++;
    }
    Console.WriteLine(@"-----------------------------------------------------------------------------------------------");
}

// opción 1 - agregar producto
void agregarProducto()
{
    Console.Clear();
    Console.Write(@"###############################################################################################
#                                     AGREGAR PRODUCTO                                        #
###############################################################################################
Ingrese nombre del producto: ");
    string? nombre = Convert.ToString(Console.ReadLine());
    Console.Write("Ingrese valor por unidad: ");
    double valorUnitario = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese cantidad de unidades: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());

    Dictionary<string, object> producto = new Dictionary<string, object>()
    {
        {"nombre" , nombre},
        {"precio" , valorUnitario},
        {"cantidad" , cantidad}
    };

    inventario.Add(producto);

    Console.WriteLine(@"-----------------------------------------------------------------------------------------------
Producto agregado exitosamente.
Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    main();
}

// opción 2 - modificar producto
void modificarProducto()
{
    Console.Clear();
    totalProductoUnitario();
    totalProductoGeneral();
    listadoProductos();

    Console.Write("Ingrese el número de producto que desea modificar (0 para salir): ");
    int opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion > 0 && opcion <= inventario.Count())
    {
        Console.WriteLine($"Modificando producto #{opcion} - {inventario[opcion - 1]["nombre"]}");
        Console.Write($"Nuevo nombre: ");
        string? nombre = Convert.ToString(Console.ReadLine());
        Console.Write("Nuevo valor por unidad: ");
        double valorUnitario = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nueva cantidad de unidades: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        inventario[opcion - 1]["nombre"] = nombre;
        inventario[opcion - 1]["precio"] = valorUnitario;
        inventario[opcion - 1]["cantidad"] = cantidad;

        Console.WriteLine(@"-----------------------------------------------------------------------------------------------
Producto modificado exitosamente.
Presione cualquier tecla para volver al menú principal.");
        Console.ReadKey();
        main();
    }
    else if (opcion == 0)
    {
        main();
    }
    else
    {
        Console.WriteLine(@"Número de producto inválido.
Presione cualquier tecla para volver al menú principal.");
        Console.ReadKey();
        main();
    };
}

// opción 3 - eliminar producto
void eliminarProducto()
{
    Console.Clear();
    totalProductoUnitario();
    listadoProductos();

    Console.Write("Ingrese el número de producto que desea eliminar (0 para salir): ");
    int opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion > 0 && opcion <= inventario.Count())
    {
        Console.WriteLine($"Eliminando producto #{opcion} - {inventario[opcion - 1]["nombre"]}");
        Console.Write("¿Está seguro que desea eliminar este producto? (s/n): ");
        string? confirmar = Console.ReadLine();

        if (confirmar.ToLower() == "s")
        {
            inventario.RemoveAt(opcion - 1);
            Console.WriteLine(@"Producto eliminado exitosamente.
Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
            main();
        }
        else
        {
            Console.WriteLine(@"Eliminación cancelada.
Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
            main();
        }
    }
    else if (opcion == 0)
    {
        main();
    }
    else
    {
        Console.WriteLine(@"Número de producto inválido.
Presione cualquier tecla para volver al menú principal.");
        Console.ReadKey();
        main();
    };
}

// opción 4 - listar productos
void listarProductos()
{
    Console.Clear();
    totalProductoUnitario();
    totalProductoGeneral();
    listadoProductos();

    Console.WriteLine(@$"TOTAL GENERAL => ${totalGeneral.ToString("#,##0.00")}                                                               
-----------------------------------------------------------------------------------------------
Presione cualquier tecla para volver al menú principal.");
    Console.ReadKey();
    main();
}

// opción 5 - salir del programa
static void salirPrograma()
{
    Console.WriteLine("Saliendo del programa...");
    Console.WriteLine("Gracias por usar el sistema de inventario.");
    Environment.Exit(0);
}

// menú
void main()
{
    Console.Clear();
    Console.Write(@"###############################################################################################
#                                        INVENTARIO                                           #
###############################################################################################
1. Agregar producto
2. Modificar producto
3. Eliminar producto
4. Listar productos
5. Salir
-----------------------------------------------------------------------------------------------
INGRESE OPCIÓN: ");
    byte proceso = Convert.ToByte(Console.ReadLine());
    switch (proceso)
    {
        case 1:
            agregarProducto();
            break;
        case 2:
            modificarProducto();
            break;
        case 3:
            eliminarProducto();
            break;
        case 4:
            listarProductos();
            break;
        case 5:
            salirPrograma();
            break;
        default:
            main();
            break;
    }
}

// display menú
main();











