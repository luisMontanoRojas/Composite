using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Ingrediente : Component
    {
        public int cantidad { get; set; }
        public string unidad { get; set; }

        public Ingrediente(string nombre, decimal costo, int cantidad, string unidad)
            :base(nombre,costo)
        {
            this.cantidad = cantidad;
            this.unidad = unidad;
        }

    }
}
