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
    public class CinturonConfiguration : EntityTypeConfiguration<Cinturon>
    {
        public CinturonConfiguration()
        {
            //Configuracion de tabla
            ToTable("Cinturones");
            HasKey(a => a.CinturonId);

            Property(a => a.CinturonId)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

       
    }
}
