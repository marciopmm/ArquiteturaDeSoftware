using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowExample02.Example
{
    public class GeradorFrases
    {
        public string Gerar()
        {
            Random r = new Random();
            return Gerar(r.Next(1, 5));
        }

        public string Gerar(int indice)
        {
            switch (indice)
            {
                case 1:
                    return "Eu gosto de lasanha.";
                case 2:
                    return "Eu gosto de picanha.";
                case 3:
                    return "Eu gosto de piranha.";
                case 4:
                    return "Eu não gosto do Devilin, mas como assim mesmo.";
                default:
                    return "Qualquer coisa.";
            }
        }
    }
}
