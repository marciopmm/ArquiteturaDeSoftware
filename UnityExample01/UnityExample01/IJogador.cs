using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityExample01
{
    public interface IJogador
    {
        string Nome { get; set; }
        int Idade { get; set; }
        string Liga { get; set; }
        string Raca { get; set; }

        void Detalhes();
    }
}
