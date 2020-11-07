using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    abstract class Component
    {
        public string nombre { get; set; }
        public decimal costo { get; set; }

        public Component(string nombre, decimal costo)
        {
            this.nombre = nombre;
            this.costo = costo;
        }
    }
}
