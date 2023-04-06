using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzaria pizzaria1 = new PizzariaPaulista();
            Pizzaria pizzaria2 = new PizzariaMineira();

            pizzaria1.Fazer("Mussarela");
            pizzaria2.Fazer("Calabresa");
        }
    }
}
