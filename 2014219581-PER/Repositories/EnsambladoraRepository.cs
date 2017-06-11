using _2014219581_ENT;
using _2014219581_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2014219581_PER.Repositories
{
    public class EnsambladoraRepository : Repository<Ensambladora> , IEnsambladoraRepository
    {
        public EnsambladoraRepository(DbContext context) : base(context)
        {
        }
    }
}
