using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    public class IngredientePaulistaFactory : IIngredienteFactory
    {
        public Massa CriarMassa()
        {
            return new MassaFinaCrocante();
        }

        public Molho CriarMolho()
        {
            return new MolhoRefogadoTomate();
        }

        public Mussarela CriarMussarela()
        {
            return new MussarelaAmarela();
        }

        public Alho CriarAlho()
        {
            return new AlhoFritoEmCubos();
        }

        public Manjericao CriarManjericao()
        {
            return new ManjericaoDesidratado();
        }

        public Pimentao CriarPimentao()
        {
            return new PimentaoPicado();
        }

        public Calabresa CriarCalabresa()
        {
            return new CalabresaMoida();
        }

        public Azeitona CriarAzeitona()
        {
            return new AzeitonaVerde();
        }
    }
}
