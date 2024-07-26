using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taller_practico.Models;

public class Persona
{
    protected Guid Id { get; set; }
    protected string? Nombre { get; set; }
    protected string? Apellido { get; set; }
    protected string? TipoDocumento { get; set; }
    protected string? NumeroDocumento { get; set; }
    protected string? Email { get; set; }
    protected string? Telefono { get; set; }

    public Persona(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono)
    {
        Id = Guid.NewGuid();
        Nombre = nombre.Trim();
        Apellido = apellido.Trim();
        TipoDocumento = tipoDocumento.Trim();
        NumeroDocumento = numeroDocumento.Trim();
        Email = email.Trim();
        Telefono = telefono.Trim();
    }

    

    public virtual void MostrarDetalles()
    {
        Console.Write(@$"| {Nombre + " " + Apellido, -22} | {TipoDocumento}: {NumeroDocumento, -11} | {Email, -21} | {Telefono, -10} |");
    }
}
