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
    class ParabrisaConfiguration : EntityTypeConfiguration<Parabrisa>
    {
        public ParabrisaConfiguration()
        {
            //Configuracion de tabla
            ToTable("Parabrisas");
            HasKey(a => a.ParabrisasId);

            Property(a => a.ParabrisasId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
