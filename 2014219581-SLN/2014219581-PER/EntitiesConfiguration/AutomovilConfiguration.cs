﻿using _2014219581_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_PER.EntitiesConfiguration
{
   public  class AutomovilConfiguration : EntityTypeConfiguration<Automovil>
    {
        public AutomovilConfiguration()
        {
            //Configuracion de las tablas
            ToTable("Automoviles");
            HasKey(a => a.AutomovilId);
        }
    }
}