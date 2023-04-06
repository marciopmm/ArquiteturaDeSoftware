using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            IPato pato = new PatoDomestico();
            pato.Grasnar();
            pato.Voar();

            IPeru peru = new PeruSelvagem();
            peru.Gorgojear();
            peru.Voar();

            IPeru adapter = new PatoAdapter(pato);
            adapter.Gorgojear();
            adapter.Voar();
        }
    }
}
