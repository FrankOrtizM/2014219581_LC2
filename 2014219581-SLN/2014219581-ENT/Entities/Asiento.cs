using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT
{
    public class Asiento
    {
        

        public int AsientoId { get; set; }
        public string NumSerie { get; set; }
        
        // Composicion 1 a 1
        public Cinturon Cinturon { get; set; }
        public Carro Carros { get; set; }

        public Asiento()
        {
            Cinturon = new Cinturon();
        }
    }
}
