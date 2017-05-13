using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT.IRepositories
{
    public class IPropietarioRepository : IRepository<Propietario>
    {
        void IRepository<Propietario>.Add(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.AddRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Propietario> IRepository<Propietario>.Find(Expression<Func<Propietario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Propietario IRepository<Propietario>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Propietario> IRepository<Propietario>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Remove(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.RemoveRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Update(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.UpdateRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

      
    }
}
