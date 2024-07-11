
public class Venta
{
    // Propiedades de la clase Venta
    public Guid Id { get; }
    public DateTime FechaDeVenta { get; }
    public Double ValorProducto { get; set; }
    public Int32 CantidadDeProductos { get; set; }
    public String Vendedor { get; set; }
    public String Comprador { get; set; }
    public String TiempoGarantia { get; set; }

    // Constructor para inicializar la venta
    public Venta(Double valorProducto, Int32 cantidadDeProductos, String vendedor, String comprador, String tiempoGarantia)
    {
        Id = Guid.NewGuid();
        FechaDeVenta = DateTime.Now;
        this.ValorProducto = valorProducto;
        this.CantidadDeProductos = cantidadDeProductos;
        this.Vendedor = vendedor;
        this.Comprador = comprador;
        this.TiempoGarantia = tiempoGarantia;
    }

    // Método para calcular el valor total de la venta
    public Double CalcularTotalVenta()
    {
        return ValorProducto * CantidadDeProductos;
    }
}

public class Program
{
    static List<Venta> ventas = new List<Venta>();

    public static void Main()
    {
        // Ejemplo de creación de ventas
        CrearVentasDePrueba();

        // Ejemplos de uso de funcionalidades
        CalcularTotalDeVentaEspecifica();
        CalcularPromedioVentasDiarias();
        MostrarEmpleadoDelMes();
        MostrarClienteDelMes();
        FiltrarVentasPorFecha();
        SeleccionarVendedoresPorValor();
        AgruparVentasPorMes();
        EncontrarVendedorConMasVentas();
        OrdenarVentasPorValorYMostrarNPrimeras();
        EncontrarProductosMasVendidosEnAnio();
        ValidarExistenciaDeVentaConValorEspecifico();
        BuscarVentasDeClienteEspecifico();
        CalcularTotalVentasPorVendedorYPromedio();
        EncontrarMesConMasVentasYMostrarVentas();
    }

    // Funciones de ejemplo (debes implementar cada una según la lógica requerida)

    static void CrearVentasDePrueba()
    {
        ventas.Add(new Venta(50, 2, "Juan", "Cliente A", "2 meses"));
        ventas.Add(new Venta(30, 1, "Maria", "Cliente B", "6 meses"));
        ventas.Add(new Venta(100, 3, "Juan", "Cliente C", "12 meses"));
        ventas.Add(new Venta(20, 1, "Pedro", "Cliente A", "1 mes"));
    }

    static void CalcularTotalDeVentaEspecifica()
    {

    }

    static void CalcularPromedioVentasDiarias()
    {
        // Implementar lógica para calcular promedio de ventas diarias
    }

    static void MostrarEmpleadoDelMes()
    {
        // Implementar lógica para determinar empleado del mes
    }

    static void MostrarClienteDelMes()
    {
        // Implementar lógica para determinar cliente del mes
    }

    static void FiltrarVentasPorFecha()
    {
        // Implementar lógica para filtrar ventas por fecha específica
    }

    static void SeleccionarVendedoresPorValor()
    {
        // Implementar lógica para seleccionar vendedores por valor de ventas
    }

    static void AgruparVentasPorMes()
    {
        // Implementar lógica para agrupar ventas por mes y calcular total mensual
    }

    static void EncontrarVendedorConMasVentas()
    {
        // Implementar lógica para encontrar vendedor con más ventas en un período específico
    }

    static void OrdenarVentasPorValorYMostrarNPrimeras()
    {
        // Implementar lógica para ordenar ventas por valor descendente y mostrar las primeras N ventas
    }

    static void EncontrarProductosMasVendidosEnAnio()
    {
        // Implementar lógica para encontrar productos más vendidos por cantidad en un año determinado
    }

    static void ValidarExistenciaDeVentaConValorEspecifico()
    {
        // Implementar lógica para validar si existe alguna venta con un valor específico
    }

    static void BuscarVentasDeClienteEspecifico()
    {
        // Implementar lógica para buscar todas las ventas realizadas a un cliente específico
    }

    static void CalcularTotalVentasPorVendedorYPromedio()
    {
        // Implementar lógica para calcular total de ventas por vendedor y promedio de ventas
    }

    static void EncontrarMesConMasVentasYMostrarVentas()
    {
        // Implementar lógica para encontrar el mes con más ventas y mostrar las ventas de ese mes
    }
}
