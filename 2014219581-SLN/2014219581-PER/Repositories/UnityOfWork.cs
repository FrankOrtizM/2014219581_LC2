using _2014219581_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014219581_PER.Repositories
{
    class UnityOfWork
    {
        private readonly FrankDbContext _Context;
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();


       public IAsientoRepository Asientos { get; private set; }

        public IAutomovilRepository Automoviles { get; private set; }

        public IBusRepository Buses { get; private set; }

        public ICarroRepository Carros { get; private set; }

        public ICinturonRepository Cinturones { get; private set; }

        public IEnsambladoraRepository Ensambladoras { get; private set; }

        public ILlantaRepository Llantas { get; private set; }

        public IParabrisaRepository Parabrisas { get; private set; }

        public IPropietarioRepository Propietarios { get; private set; }

         public  IVolanteRepository Volantes { get; private set; }


        private UnityOfWork()
        {
            _Context = new FrankDbContext();

            Asientos = new AsientoRepository(_Context);

            Automoviles = new AutomovilRepository(_Context);

            Buses = new BusRepository(_Context);

  

            Volantes = new VolanteRepository(_Context);


        }

        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }
        }

       
    }
}
