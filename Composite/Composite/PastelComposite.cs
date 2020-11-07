using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class PastelComposite : Component
    {
        List<Component> ingredientes = new List<Component>();

        public decimal costoTotal 
        {
            get
            {
                decimal costo = 0;
                foreach (var oElemento in ingredientes)
                {
                    if (oElemento.GetType().Name == "PastelComposite")
                        costo += ((PastelComposite)oElemento).costoTotal;
                    else
                        costo += oElemento.costo;
                }
                return costo;
            }
        }

        public void add(Component oElemento) 
        {
            ingredientes.Add(oElemento);
        }

        public void remove(Component oElemento)
        {
            ingredientes.Remove(oElemento);
        }


        public PastelComposite(string nombre, decimal costo=0): base(nombre, costo)
        {

        }
    }
}
