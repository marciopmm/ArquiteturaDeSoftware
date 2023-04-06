using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityExample01
{
    class Factory
    {
        static public IJogador CreateInstance()
        {
            IUnityContainer _container = new UnityContainer();
            _container.RegisterType(typeof(IJogador), typeof(Jogador));
            IJogador obj = _container.Resolve<IJogador>();
            return obj;
        }
    }
}
