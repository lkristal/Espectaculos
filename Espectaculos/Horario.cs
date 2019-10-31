using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculos
{
    public class Horario
    {
        private int _IdHorario;
        private int _IdShow;
        private string _Dia;
        private string _Hora;
        private string _Canal;

        public string HorarioCompleto { get => _Dia + " " + _Hora + " " + Canal; }

        public Horario(int IdHorario, int IdShow, string Dia, string Hora, string Canal)
        {
            _IdHorario = IdHorario;
            _IdShow = IdShow;
            _Dia = Dia;
            _Hora = Hora;
            _Canal = Canal;
        }
        public Horario()
        {
        }

        public int IdHorario { get => _IdHorario; set => _IdHorario = value; }
        public int IdShow { get => _IdShow; set => _IdShow = value; }
        public string Dia { get => _Dia; set => _Dia = value; }
        public string Hora { get => _Hora; set => _Hora = value; }
        public string Canal { get => _Canal; set => _Canal = value; }
    }
}
