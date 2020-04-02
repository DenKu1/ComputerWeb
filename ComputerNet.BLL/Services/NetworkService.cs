using AutoMapper;
using ComputerNet.BLL.Interfaces;
using ComputerNet.DAL.Entities;
using ComputerNet.DAL.Interfaces;
using System;

namespace ComputerNet.BLL.Services
{
    public class NetworkService : INetworkService
    {
        protected readonly IMapper _mp;
        protected readonly IGenericRepository<Computer> _computerRepo;
        protected readonly IGenericRepository<Router> _routerRepo;

        public NetworkService(IGenericRepository<Computer> computerRepository,
                             IGenericRepository<Router> routerRepository,
                             IMapper mapper)
        {
            _computerRepo = computerRepository;
            _routerRepo = routerRepository;
            _mp = mapper;
        }

        public bool CheckIPRange(int computerId, long computerIP)
        {
            if (computerIP >= Math.Pow(2, 32))
            {
                return false;
            }

            Computer computer = _computerRepo.GetById(computerId);
            Router router = _routerRepo.GetById(computer.RouterId);

            if (computer == null)
            {
                return false;
            }
                        
            long routerIP = router.LogicAddress;
            long mask = router.Mask;

            if (routerIP == computerIP)
            {
                return false;
            }

            return (routerIP & mask) == (computerIP & mask);
        }
    }
}
