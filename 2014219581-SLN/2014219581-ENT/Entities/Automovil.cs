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

        public int AutomovilId { get; set; }

        public Automovil(Volante volante, Parabrisa parabrisas, int numLlantas,
                         int numAsientos, Propietario propietario, TipoCarro tipoCarro, TipoAuto tipoAuto)
            : base(volante, parabrisas, numLlantas, numAsientos, propietario, tipoCarro)
        {
            TipoAuto = tipoAuto;
        }

        public Automovil()
        {
            TipoAuto = TipoAuto.NoDefinido;
        }
    }
}
