﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT
{
    public class Cinturon
    {
        public int CinturonId { get; set; }

        public string NumSerie { get; set; }
        public int Metraje { get; set; }

        //1 a *
        public Asiento Asiento { get; set; }

        public int AsientoId { get; set; }


    }
}
