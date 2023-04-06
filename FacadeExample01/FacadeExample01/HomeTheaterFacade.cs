using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample01
{
    public class HomeTheaterFacade
    {
        private BluRayPlayer _player = new BluRayPlayer();
        private DataShow _dataShow = new DataShow();
        private Tela _tela = new Tela();
        private Som _som = new Som();
        private ControladorLuz _luz = new ControladorLuz();

        public void AssistirFilme(int intensidadeLuzes)
        {
            _player.Ligar();
            _dataShow.Ligar();
            _tela.Extender();
            _som.Ligar();
            _luz.RegularLuzes(intensidadeLuzes);
        }
    }
}
