using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityExample01
{
    public class Jogador : IJogador
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Liga { get; set; }
        public string Raca { get; set; }

        public void Detalhes()
        {
            Console.WriteLine("---- Nome: " + Nome + " ----");
            Console.WriteLine("Idade: " + Idade.ToString());
            Console.WriteLine("Liga: " + Liga);
            Console.WriteLine("Raça: " + Raca);
            Console.WriteLine();
        }
    }
}
