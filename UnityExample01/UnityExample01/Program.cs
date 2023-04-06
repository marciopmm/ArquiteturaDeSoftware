using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            IJogador obj1 = Factory.CreateInstance();
            obj1.Nome = "Marcio";
            obj1.Idade = 38;
            obj1.Liga = "Bronze";
            obj1.Raca = "Terrano";
            obj1.Detalhes();
            IJogador obj2 = Factory.CreateInstance();
            obj2.Nome = "Pedro";
            obj2.Idade = 18;
            obj2.Liga = "Ouro";
            obj2.Raca = "Protoss";
            obj2.Detalhes();
        }
    }
}
