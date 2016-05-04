using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPez
{
    class Pecera
    {
        private List<Salvatierra.Franco.Pez> _peces;
        private Single _volumen;
        private int _capacidadDePeces;
        private bool _aguaCaliente;

        private Pecera()
        {
            this._peces = new List<Salvatierra.Franco.Pez>(3);
        }

        public Pecera(Single volumen, bool aguaCaliente):this()
        {
            this._volumen = volumen;
            this._aguaCaliente = aguaCaliente;
        }
    }
}
