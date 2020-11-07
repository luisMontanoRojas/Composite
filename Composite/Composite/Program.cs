using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingrediente oIngrediente1 = new Ingrediente("Harina", 100, 200, "gramos");
            Ingrediente oIngrediente2 = new Ingrediente("Leche", 20, 1, "litro");
            Ingrediente oIngrediente3 = new Ingrediente("Huevo", 20, 1, "kilo");

            PastelComposite oPastel = new PastelComposite("Pastel de Leche");
            oPastel.add(oIngrediente1);
            oPastel.add(oIngrediente2);
            oPastel.add(oIngrediente3);

            Console.WriteLine(oPastel.costoTotal);

            Ingrediente oIngrediente4 = new Ingrediente("Chocolate", 200, 1, "litro");
            PastelComposite oPastelChocolateYLeche = new PastelComposite("Pastel Compuesto");

            oPastelChocolateYLeche.add(oIngrediente4);
            oPastelChocolateYLeche.add(oPastel);

            Console.WriteLine(oPastelChocolateYLeche.costoTotal);
        }
    }
}
