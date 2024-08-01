using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace repaso_general.Models;

public class Empleado : Persona
{
    public new Guid Id { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public string Posicion { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, string apellido, string numeroDeIdentificacion, int edad, string posicion, double salario) : base(nombre, apellido, edad)
    {
        Id = Guid.NewGuid();
        NumeroDeIdentificacion = numeroDeIdentificacion;
        Posicion = posicion.Trim().ToLower();
        Salario = salario;
    }

    private double CalcularBonificacion()
    {
        double Bonificacion = Salario * 0.1;
        return Bonificacion;
    }

    public override void MostrarInformacion()
    {
        var bonificacion = CalcularBonificacion();

        Console.WriteLine($"| {NombreCompleto,-19} | {NumeroDeIdentificacion,-12} |  {Edad,-3} | {Posicion,-14} | ${(Salario + bonificacion).ToString("#,##0.00"),-14} |");
    }

    
}
