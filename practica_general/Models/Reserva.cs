using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica_general.Models;

public class Reserva : Habitacion
{
    public DateOnly FechaInicio { get; set; }
    public DateOnly FechaFin { get; set; }

}
