using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POO_herencia.Models;

public class PersonalTecnico
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? TipoDocumento { get; set; }
    public string? NumeroDocumento { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public string? RH { get; set; }
    public string? TallaSuperior { get; set; }
    public string? TallaInferior { get; set; }
    public string? TallaZapatos { get; set; }

    public byte CalcularEdad()
    {
        return (byte)(DateTime.Today.Year - FechaNacimiento.Year);
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Tipo Documento: {TipoDocumento}");
        Console.WriteLine($"Número Documento: {NumeroDocumento}");
        Console.WriteLine($"Fecha Nacimiento: {FechaNacimiento:dd/MM/yyyy}");
        Console.WriteLine($"Edad: {CalcularEdad()} años");
        Console.WriteLine($"RH: {RH}");
        Console.WriteLine($"Talla Superior: {TallaSuperior}");
        Console.WriteLine($"Talla Inferior: {TallaInferior}");
        Console.WriteLine($"Talla Zapatos: {TallaZapatos}");
    }
}
