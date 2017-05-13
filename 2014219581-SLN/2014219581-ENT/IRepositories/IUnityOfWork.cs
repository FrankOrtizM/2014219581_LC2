using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {

        IAsientoRepository Asiento { get; }

        IAutomovilRepository Automovil { get; }

        IBusRepository Bus { get; }

        IVolanteRepository Volante { get; }

      
        int SaveChanges();

    }
}
