using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample01
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeTheaterFacade facade = new HomeTheaterFacade();
            facade.AssistirFilme(30);
        }
    }
}
