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
    public class ParabrisaRepository : Repository<Parabrisa> , IParabrisaRepository

    {
        public ParabrisaRepository(DbContext context) : base(context)
        {

        }
    }
}
