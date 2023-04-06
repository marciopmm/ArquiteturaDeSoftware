using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamada 1
            Thread t1 = new Thread(new ThreadStart(Acao));
            t1.Start();
            Thread.Sleep(2000);
            Thread t2 = new Thread(new ThreadStart(Acao));
            t2.Start();
        }

        static void Acao()
        {
            Singleton s = Singleton.GetInstance();
            Console.WriteLine("ID da Instância: " + s.Id);
            Thread.Sleep(1000);
        }
    }
}
