using _2014219581_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_PER.EntitiesConfiguration
{
    public class LlantaConfiguration : EntityTypeConfiguration<Llanta>
    {
        public LlantaConfiguration()
        {
            //Configuracion de las tablas
            ToTable("Llantas");
            HasKey(a => a.LlantaId);

           

        }
    }
}
