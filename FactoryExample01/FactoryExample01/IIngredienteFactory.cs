using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    public interface IIngredienteFactory
    {
        Massa CriarMassa();
        Molho CriarMolho();
        Mussarela CriarMussarela();
        Alho CriarAlho();
        Manjericao CriarManjericao();
        Pimentao CriarPimentao();
        Calabresa CriarCalabresa();
        Azeitona CriarAzeitona();
    }
}
