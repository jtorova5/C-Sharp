using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_interfaces.Interfaces;

public interface IAnimal
{
    void Comer(); //no es necesario usar el public, porque todos los métodos de las interfaces son públicos
    public void Dormir();
    public void Respirar();
    public void Desplazar();
}
