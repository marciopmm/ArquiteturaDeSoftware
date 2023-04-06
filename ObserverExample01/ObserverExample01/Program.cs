using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            IEditor editora = new Editora();

            IObservador assinante1 = new Assinante(editora);
            IObservador assinante2 = new Assinante(editora);
            IObservador assinante3 = new Assinante(editora);
            IObservador assinante4 = new Assinante(editora);

            Console.WriteLine("Aguardando a nova edição...");
            Thread.Sleep(2000);
            editora.Edicao = 22;

            Console.WriteLine("Aguardando a nova edição...");
            Thread.Sleep(3000);
            editora.Edicao = 23;

            Console.WriteLine("O 02 cansou ...");
            Thread.Sleep(3000);
            editora.Remover(assinante2);
            editora.Edicao = 24;
        }
    }
}
