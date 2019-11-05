using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculos
{
    public class TipoShow
    {
        private int _IdTipoShow;
        private string _Nombre;

        public TipoShow(int IdTipoShow, string Nombre)
        {
            _IdTipoShow = IdTipoShow;
            _Nombre = Nombre;
        }
        public TipoShow()
        {
            _IdTipoShow=-1;
        }

        public int IdTipoShow { get => _IdTipoShow; set => _IdTipoShow = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}
