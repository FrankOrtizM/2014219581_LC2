using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT
{
    public class Bus : Carro
    {
        //Enumerador
        public TipoBus TipoBus { get; set; }
        public int BusId { get; set; }


        public Bus(Volante volante, Parabrisa parabrisas, int numLlantas,
                         int numAsientos, Propietario propietario, TipoCarro tipoCarro, TipoBus tipoBus)
            : base(volante, parabrisas, numLlantas, numAsientos, propietario, tipoCarro)
        {
            TipoBus = tipoBus;
        }


        public Bus()
        {
            TipoBus = TipoBus.NoDefinido;
        }
    }
}
