using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espectaculos
{
    public class Actor
    {
        private int _IdActor;
        private int _IdShow;
        private string _Nombre;

        public Actor(int IdActor, int IdShow, string Nombre)
        {
            this.IdActor = IdActor;
            this.IdShow = IdShow;
            this.Nombre = Nombre;
        }
        public Actor()
        {
        }
        public int IdActor { get => _IdActor; set => _IdActor = value; }
        public int IdShow { get => _IdShow; set => _IdShow = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}
