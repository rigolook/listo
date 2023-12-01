using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR_RLG
{
    public class Nodo
    {
        private Nodo _siguiente;
        public carro vehiculo = new carro();

        public Nodo()
        {
            _siguiente = null;
        }

        public Nodo Siguiente {
            
            get { return _siguiente; } set { _siguiente = value; } 
        }

    }
}
