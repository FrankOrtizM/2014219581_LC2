using _2014219581_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_PER.EntitiesConfiguration
{
    public class CarroConfiguration : EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
        {
            //Configuracion de las tablas
            ToTable("Carros");
            HasKey(a => a.CarroId);

            //Configuracion  de relaciones
           

            HasRequired(a => a.Parabrisas)
                .WithRequiredPrincipal(c => c.Carros);

            HasRequired(a => a.Volante)
                .WithRequiredPrincipal(c => c.Carros);

            HasRequired(a => a.Propietario)
                .WithRequiredPrincipal(c => c.Carros);

            HasMany(a => a.Llantas)
                .WithRequired(c => c.Carros);

            HasMany(a => a.Asientos)
                .WithRequired(c => c.Carros);

           
        }
    }
}
