using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT
{
    public class Ensambladora
    {
        public int EnsambladoraId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        //1 a muchos
        public List<Carro> Carros { get; set; }
        public TipoCarro TipoCarro { get; set; }

        public Ensambladora()
        {
            //Composicion 1 a muchos
            Carros = new List<Carro>();
            TipoCarro = TipoCarro.NoDefinido;

        }

        public Ensambladora(TipoCarro tipoCarro)
        {
            //Enumerador
            TipoCarro = tipoCarro;
        }

    }
}
