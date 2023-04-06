using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample01
{
    public class Assinante : IObservador
    {
        private IEditor _editoraObservada;

        public Assinante(IEditor editora)
        {
            _editoraObservada = editora;
            _editoraObservada.Registrar(this);
        }

        public void Atualizar(IEditor editora)
        {
            if (_editoraObservada == editora)
            {
                Console.WriteLine("[NOTIFICAÇÃO] - A editora mudou sua edição para " + _editoraObservada.Edicao.ToString());
            }
        }
    }

    public class Editora : IEditor
    {
        private List<IObservador> _assinantes = new List<IObservador>();
        private int _edicao;
        public int Edicao
        {
            get
            {
                return _edicao;
            }
            set
            {
                if (value != _edicao)
                {
                    _edicao = value;
                    NotificarObservadores();
                }
            }
        }

        public void NotificarObservadores()
        {
            foreach (IObservador assinante in _assinantes)
            {
                assinante.Atualizar(this);
            }
        }

        public void Registrar(IObservador assinante)
        {
            _assinantes.Add(assinante);
        }

        public void Remover(IObservador assinante)
        {
            _assinantes.Remove(assinante);
        }
    }
}
