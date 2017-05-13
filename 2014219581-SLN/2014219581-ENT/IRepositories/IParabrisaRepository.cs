using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT.IRepositories
{
    public class IParabrisaRepository : IRepository<Parabrisa>
    {
        void IRepository<Parabrisa>.Add(Parabrisa entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.AddRange(IEnumerable<Parabrisa> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Parabrisa> IRepository<Parabrisa>.Find(Expression<Func<Parabrisa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Parabrisa IRepository<Parabrisa>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Parabrisa> IRepository<Parabrisa>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.Remove(Parabrisa entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.RemoveRange(IEnumerable<Parabrisa> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.Update(Parabrisa entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisa>.UpdateRange(IEnumerable<Parabrisa> entities)
        {
            throw new NotImplementedException();
        }
    }
}
