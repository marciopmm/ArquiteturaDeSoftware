using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    public class MussarelaPaulista : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public MussarelaPaulista(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Mussarela Paulista...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class CalabresaPaulista : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public CalabresaPaulista(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Calabresa Paulista...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class GregaPaulista : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public GregaPaulista(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Grega Paulista...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class MargueritaPaulista : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public MargueritaPaulista(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Marguerita Paulista...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class NapolitanaPaulista : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public NapolitanaPaulista(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Napolitana Paulista...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class MussarelaMineira : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public MussarelaMineira(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Mussarela Mineira...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class CalabresaMineira : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public CalabresaMineira(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Calabresa Mineira...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class GregaMineira : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public GregaMineira(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Grega Mineira...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class MargueritaMineira : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public MargueritaMineira(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Marguerita Mineira...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }

    public class NapolitanaMineira : Pizza
    {
        IIngredienteFactory _ingredienteFactory;
        public NapolitanaMineira(IIngredienteFactory ingredienteFactory)
        {
            _ingredienteFactory = ingredienteFactory;
        }

        public override void Preparar()
        {
            Console.WriteLine("Preparando a Pizza Napolitana Mineira...");
            this.Massa = _ingredienteFactory.CriarMassa();
            this.Molho = _ingredienteFactory.CriarMolho();
            this.Mussarela = _ingredienteFactory.CriarMussarela();
            this.Azeitona = _ingredienteFactory.CriarAzeitona();
        }
    }
}
