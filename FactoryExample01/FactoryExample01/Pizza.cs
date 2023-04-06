using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    public abstract class Pizza
    {
        public string Nome { get; set; }
        public Massa Massa { get; set; }
        public Molho Molho { get; set; }
        public Mussarela Mussarela { get; set; }
        public Calabresa Calabresa { get; set; }
        public Azeitona Azeitona { get; set; }
        public Alho Alho { get; set; }
        public Pimentao Pimentao { get; set; }
        public Manjericao Manjericao { get; set; }

        public abstract void Preparar();

        public void Assar()
        {
            Console.WriteLine("Assando a Pizza... 3... 2... 1... PRONTO!");
        }

        public void Embalar()
        {
            Console.WriteLine("Colocando a Pizza na embalagem oficial ... PRONTO!");
        }

        public void Cortar()
        {
            Console.WriteLine("Cortando a Pizza: 1, 2, 3, 4 vezes ... contando pedaços: 1..2..3..4..5..6..7..8 ... PRONTO!");
        }
    }
}
