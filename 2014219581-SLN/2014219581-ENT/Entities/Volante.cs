﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT
{
    public class Volante
    {
        public int VolantesId { get; set; }
        public string NumSerie { get; set; }

        public Carro Carros { get; set; }
    }
}