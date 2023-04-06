using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    public class PizzariaPaulista : Pizzaria
    {
        protected override Pizza Create(string tipo)
        {
            Pizza pizza;
            IIngredienteFactory ingredienteFactory = new IngredientePaulistaFactory();

            if (tipo == "Calabresa")
                pizza = new CalabresaPaulista(ingredienteFactory);
            else if (tipo == "Grega")
                pizza = new GregaPaulista(ingredienteFactory);
            else if (tipo == "Marguerita")
                pizza = new MargueritaPaulista(ingredienteFactory);
            else if (tipo == "Napolitana")
                pizza = new NapolitanaPaulista(ingredienteFactory);
            else
                pizza = new MussarelaPaulista(ingredienteFactory);

            return pizza;
        }
    }

    public class PizzariaMineira : Pizzaria
    {
        protected override Pizza Create(string tipo)
        {
            Pizza pizza;
            IIngredienteFactory ingredienteFactory = new IngredienteMineiroFactory();

            if (tipo == "Calabresa")
                pizza = new CalabresaMineira(ingredienteFactory);
            else if (tipo == "Grega")
                pizza = new GregaMineira(ingredienteFactory);
            else if (tipo == "Marguerita")
                pizza = new MargueritaMineira(ingredienteFactory);
            else if (tipo == "Napolitana")
                pizza = new NapolitanaMineira(ingredienteFactory);
            else
                pizza = new MussarelaMineira(ingredienteFactory);

            return pizza;
        }
    }
}
