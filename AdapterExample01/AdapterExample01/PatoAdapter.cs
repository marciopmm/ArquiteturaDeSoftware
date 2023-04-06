using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample01
{
    public class PatoAdapter : IPeru
    {
        private IPato _pato;

        public PatoAdapter(IPato pato)
        {
            _pato = pato;
        }

        public void Gorgojear()
        {
            _pato.Grasnar();
        }

        public void Voar()
        {
            _pato.Voar();
        }
    }
}
