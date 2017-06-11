using _2014219581_ENT;
using _2014219581_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_PER.Repositories
{
    public class LlantaRepository : Repository<Llanta> , ILlantaRepository
    {
        public LlantaRepository(DbContext context) : base(context)
        {

        }
    }
}
