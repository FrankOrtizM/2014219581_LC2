using _2014219581_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_PER.EntitiesConfiguration
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {
        public AsientoConfiguration()
        {
            //Configuracion de las tablas
            ToTable("Asientos");
            HasKey(a => a.AsientoId);

            //Configuracion de relaciones

            HasRequired(c => c.Cinturon)
                .WithRequiredPrincipal(c => c.Asiento);
            
        }
    }
}
