using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;

public class Empleado
{
    private Guid Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Correo { get; set; }
    private double SueldoBase { get; set; }
    public double PorcentajePension { get; set; }
    public double PorcentajeSalud { get; set; }
    private double PorcentajeAhorroCooperativa { get; set; }


    public Empleado(string nombre, string apellido, string correo, double sueldoBase, double porcentajePension, double porcentajeSalud, double porcentajeAhorroCooperativa)
    {
        this.Id = Guid.NewGuid();
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Correo = correo;
        this.SueldoBase = sueldoBase;
        this.PorcentajePension = porcentajePension;
        this.PorcentajeSalud = porcentajeSalud;
        this.PorcentajeAhorroCooperativa = porcentajeAhorroCooperativa;
    }

    public double CalcularSueldoEmpleado()
    {
        double deducciones = CalcularDeducciones();
        double ahorro = CalcularAhorro();
        double sueldoBruto = SueldoBase - deducciones - ahorro;
        Console.WriteLine(@$"
-----------------------------------------------------------------
Id: {Id}
Nombre: {Nombre} {Apellido}
-----------------------------------------------------------------
Sueldo Base: ${SueldoBase.ToString("#,##0.00")}
Deducciones: ${deducciones.ToString("#,##0.00")}
Ahorro: ${ahorro.ToString("#,##0.00")}
-----------------------------------------------------------------
Sueldo Bruto: ${sueldoBruto.ToString("#,##0.00")}
-----------------------------------------------------------------");
        return sueldoBruto;
    }

    private double CalcularDeducciones()
    {
        double deducciones = (SueldoBase * (PorcentajePension / 100)) + (SueldoBase * (PorcentajeSalud / 100));
        return deducciones;
    }

    private double CalcularAhorro()
    {
        double ahorro = SueldoBase * (PorcentajeAhorroCooperativa / 100);
        return ahorro;
    }
}
