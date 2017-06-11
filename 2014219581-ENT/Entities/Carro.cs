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

        //1 a muchos
        public List<Llanta> Llantas { get; set; }

        //1 a muchos
        public List<Asiento> Asientos { get; set; }

        //1 a muchos
        public List<Volante> Volante { get; set; }


        //1 a muchos
        public List<Parabrisa> Parabrisas { get; set; }

        //1 a 1
        public Propietario Propietario { get; set; }
        public int PropietarioId { get; set; }

        //Enumerador
        public TipoCarro TipoCarro { get; set; }


        //1 a 1
        public Ensambladora Ensambladora { get; set; }
        public int EnsambladoraId { get; set; }

        public string NumSerieChasis { get; set; }

        public Carro()
        {
            Volante = new List<Volante>();

            //Composicion 1 a muchos
            Llantas = new List<Llanta>();

            //Composicion 1 a muchos
            Asientos = new List<Asiento>();

            //1 a muchos
            Parabrisas = new List<Parabrisa>();

            TipoCarro = TipoCarro.NoDefinido;
        }

        public Carro(List<Volante> volante, List<Parabrisa> parabrisas, Propietario propietario, TipoCarro tipoCarro)
        {

            //Agregacion
            Volante = volante;

            //Agregacion
            Parabrisas = parabrisas;

            //Agregacion
            Propietario = propietario;

            //Enumerador
            TipoCarro = tipoCarro;
        }

    }
}
