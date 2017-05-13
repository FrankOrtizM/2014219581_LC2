using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT
{
    public abstract class Carro
    {

        public int CarroId { get; set; }

        //Asociacion 1 a muchos
        public List<Llanta> Llantas { get; set; }
        public int LLantasId;

        //Asociacion 1 a muchos
        public List<Asiento> Asientos { get; set; }
        public int AsientosId;

        //Agregacion de 1 a 1
        public Volante Volante { get; set; }
        public int VolanteId { get; set; }

        //Agregacion de 1 a 1
        public Parabrisa Parabrisas { get; set; }
        public int ParabrisaId { get; set; }

        //Agregacion de 1 a 1
        public Propietario Propietario { get; set; }
        public int PropietarioId { get; set; }

        //Enumerador
        public TipoCarro TipoCarro { get; set; }

        

        public Carro()
        {
            Llantas = new List<Llanta>();
            Asientos = new List<Asiento>();
        }

        public Carro(Volante volante, Parabrisa parabrisas, int numLlantas,
            int numAsientos, Propietario propietario, TipoCarro tipoCarro)
        {
            Llantas = new List<Llanta>(numLlantas);
            Asientos = new List<Asiento>(numAsientos);

            Volante = volante;
            Parabrisas = parabrisas;
            Propietario = propietario;

            TipoCarro = tipoCarro;
        }

        public string NumSerieChasis { get; set; }
        public string NumSerieMotor { get; set; }
    }
}
