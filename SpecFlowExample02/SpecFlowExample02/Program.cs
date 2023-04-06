using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = null;
            Example.GeradorFrases gerador = new Example.GeradorFrases();

            while (string.IsNullOrEmpty(result) || result != "S")
            {
                Console.Clear();
                Console.WriteLine("Gerador de Frases");
                Console.WriteLine("Frase do dia: ");
                Console.WriteLine(gerador.Gerar());
                Console.WriteLine();
                Console.WriteLine("Pressione S para sair ou outra tecla para gerar outra frase.");
                result = Console.ReadLine().ToUpper();
            }
        }
    }
}
