﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT
{
   public  class Propietario
    {
        public int PropietarioId { get; set; }

        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string LicenciaConducir { get; set; }

        //1 a muchos
        public List<Carro> Carros { get; set; }

        public Propietario()
        {
            //1 a muchos
            Carros = new List<Carro>();
        }
    }
}
