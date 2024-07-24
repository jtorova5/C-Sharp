using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace practica_general.Models;
public class Prenda
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Talla { get; set; }
    public double Precio { get; set; }

    public Prenda(int id, string nombre, string talla, double precio)
    {
        Id = id;
        Nombre = nombre;
        Talla = talla;
        Precio = precio;
    }
}
