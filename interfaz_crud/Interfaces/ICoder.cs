using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using interfaz_crud.Models;

namespace interfaz_crud.Interfaces;

public interface ICoder
{
    // implementar a la clase coder operaciones CRUD con interfaz
    public void Mostrar();
    public void Agregar();
    public void Actualizar();
    public void Eliminar();

}
