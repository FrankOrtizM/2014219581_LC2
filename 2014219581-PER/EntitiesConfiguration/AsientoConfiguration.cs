using _2014219581_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            //Configuracion de tabla
            ToTable("Asientos");
            HasKey(a => a.AsientoId);

            Property(a => a.AsientoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);



            //Configuracion de relaciones
            HasMany(a => a.Cinturon)
                .WithRequired(a => a.Asiento);

        }
    }
}
