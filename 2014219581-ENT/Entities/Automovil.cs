using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT
{
    public class Automovil : Carro
    {
        //Enumerador
        public TipoAuto TipoAuto { get; set; }


        public Automovil(TipoAuto tipoAuto)
        {
            //Enumerador
            TipoAuto = tipoAuto;
        }

        public Automovil()
        {
            TipoAuto = TipoAuto.NoDefinido;
        }
    }
}
