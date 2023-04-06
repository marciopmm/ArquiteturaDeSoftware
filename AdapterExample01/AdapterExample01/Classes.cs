using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample01
{
    public class PatoDomestico : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Quack Quack! Estou grasnando!");
        }

        public void Voar()
        {
            Console.WriteLine("Estou voando!");
        }
    }

    public class PeruSelvagem : IPeru
    {

        public void Gorgojear()
        {
            Console.WriteLine("Glu Glu! Estou gorjeando! HA! Yeah Yeah! Glu Glu! Salci Fufu!");
        }

        public void Voar()
        {
            Console.WriteLine("Estou voando uma pequena distância!");
        }
    }
}
