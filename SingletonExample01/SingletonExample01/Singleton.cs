using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample01
{
    public class Singleton
    {
        private volatile static Singleton _instance = new Singleton();
        public string Id { get; private set; }


        private Singleton()
        {
            Id = Guid.NewGuid().ToString();
        }

        public static Singleton GetInstance()
        {
            lock (_instance)
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }

    }
}
