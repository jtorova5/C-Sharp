using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace repaso_general.Models;

public class Empleado
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NombreCompleto { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public byte Edad { get; set; }
    public string Posicion { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, string apellido, string numeroDeIdentificacion, byte edad, string posicion, double salario)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        NombreCompleto = Nombre + " " + Apellido;
        NumeroDeIdentificacion = numeroDeIdentificacion;
        Edad = edad;
        Posicion = posicion;
        Salario = salario;
    }

    private double CalcularBonificacion()
    {
        var Bonificacion = Salario * 0.1;
        return Bonificacion;
    }

    public void MostrarInformacion()
    {
        var bonificacion = CalcularBonificacion();

        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("|   Nombre Completo   |      Id      | Edad |    Posición    |    Salario    |");
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine($"| {NombreCompleto, -19} | {NumeroDeIdentificacion, -12} |  {Edad, -3} | {Posicion, -14} | {Salario + bonificacion, -13} |");
    }
}
