using _2014219581_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_PER.EntitiesConfiguration
{
    public class VolanteConfiguration : EntityTypeConfiguration<Volante>
    {
        public VolanteConfiguration()
        {
            //Configuracion de las tablas
            ToTable("Volantes");
            HasKey(a => a.VolantesId);
        }
    }
}
