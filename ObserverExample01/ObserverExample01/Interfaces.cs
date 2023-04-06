using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample01
{
    public interface IObservador
    {
        void Atualizar(IEditor editora);
    }

    public interface IEditor
    {
        int Edicao { get; set; }

        void NotificarObservadores();
        void Registrar(IObservador observador);
        void Remover(IObservador observador);
    }
}
