using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample01
{
    public abstract class Pizzaria
    {
        public Pizza Fazer(string tipo)
        {
            Pizza pizza = Create(tipo);      

            pizza.Preparar();
            pizza.Assar();
            pizza.Embalar();
            pizza.Cortar();

            return pizza;
        }

        protected abstract Pizza Create(string tipo);
    }
}
