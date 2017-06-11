using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {

        //Propiedades de solo lectura
        IAsientoRepository Asientos { get; }
        IAutomovilRepository Automoviles { get; }
        IBusRepository Buses { get; }
        ICinturonRepository Cinturones { get; }
        IEnsambladoraRepository Ensambladoras { get; }
        ILlantaRepository Llantas { get; }
        IPropietarioRepository Propietarios { get; }
        IParabrisaRepository Parabrisas { get; }
        IVolanteRepository Volantes { get; }

        ICarroRepository Carros { get; }

        //Metodo que guardara los cambios en la BD
        int SaveChanges();

        void StateModified(object entity);
    }
}
