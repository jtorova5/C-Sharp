using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace POO_herencia.Models;

public class Entrenador : PersonalTecnico
{
    public byte ExperienciaEnAños { get; set; }
    public byte CantidadTitulos { get; set; }
    private double Salario { get; set; }
    public string? Nacionalidad { get; set; }

    public Entrenador(byte experienciaEnAños, byte cantidadTitulos, double salario, string nacionalidad)
    {
        ExperienciaEnAños = experienciaEnAños;
        CantidadTitulos = cantidadTitulos;
        Salario = salario;
        Nacionalidad = nacionalidad;
    }
}
