using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    public class IngredienteMineiroFactory : IIngredienteFactory
    {
        public Massa CriarMassa()
        {
            return new MassaGrossaTemperada();
        }

        public Molho CriarMolho()
        {
            return new MolhoExtratoTomate();
        }

        public Mussarela CriarMussarela()
        {
            return new MussarelaBranca();
        }

        public Alho CriarAlho()
        {
            return new AlhoFritoEmFatias();
        }

        public Manjericao CriarManjericao()
        {
            return new ManjericaoFresco();
        }

        public Pimentao CriarPimentao()
        {
            return new PimentaoFatiado();
        }

        public Calabresa CriarCalabresa()
        {
            return new CalabresaFatiada();
        }

        public Azeitona CriarAzeitona()
        {
            return new AzeitonaPreta();
        }
    }
}
