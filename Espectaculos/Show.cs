using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculos
{
    public class Show
    {
        private int _IdShow;
        private int _IdTipoShow;
        private string _NombreShow;

        public Show(int IdShow, int IdTipoShow, string NombreShow)
        {
            _IdShow = IdShow;
            _IdTipoShow = IdTipoShow;
            _NombreShow = NombreShow;
        }
        public Show()
        {
        }

        public int IdShow { get => _IdShow; set => _IdShow = value; }
        public int IdTipoShow { get => _IdTipoShow; set => _IdTipoShow = value; }
        public string NombreShow { get => _NombreShow; set => _NombreShow = value; }
    }
}
