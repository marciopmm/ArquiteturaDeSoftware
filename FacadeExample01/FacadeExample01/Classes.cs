using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample01
{
    public class BluRayPlayer
    {
        public void Ligar()
        {
            Console.WriteLine("BLURAY PLAYER - Ligado");
        }

        public void Desligar()
        {
            Console.WriteLine("BLURAY PLAYER - Desligado");
        }
    }

    public class DataShow
    {
        public void Ligar()
        {
            Console.WriteLine("DATA SHOW - Ligado");
        }

        public void Desligar()
        {
            Console.WriteLine("DATA SHOW - Desligado");
        }
    }

    public class Tela
    {
        public void Extender()
        {
            Console.WriteLine("TELA - Extendida");
        }

        public void Recolher()
        {
            Console.WriteLine("TELA - Recolhida");
        }
    }

    public class Som
    {
        public void Ligar()
        {
            Console.WriteLine("SOM - Ligado");
        }

        public void Desligar()
        {
            Console.WriteLine("SOM - Desligado");
        }
    }

    public class ControladorLuz
    {
        public void RegularLuzes(int porcentagem)
        {
            Console.WriteLine("LUZES - Reguladas para {0} por cento", porcentagem);
        }
    }
}
