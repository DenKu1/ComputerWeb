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
        protected readonly IUnitOfWork _db;
        protected readonly IGenericRepository<Computer> _computerRepo;
        protected readonly IGenericRepository<Router> _routerRepo;

        public NetworkService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _db = unitOfWork;
            _computerRepo = unitOfWork.Computers;
            _routerRepo = unitOfWork.Routers;
            _mp = mapper;
        }

        public bool CheckIPRange(int computerId, long computerIP)
        {
            if (computerIP >= Math.Pow(2, 32))
            {
                return false;
            }

            Computer computer = _computerRepo.GetById(computerId);

            if (computer == null || computer.RouterId == null)
            {
                return false;
            }

            Router router = _routerRepo.GetById(computer.RouterId.Value);

            if (router.LogicAddress == null || router.Mask == null)
            {
                return false;
            }    

            long routerIP = router.LogicAddress.Value;
            long mask = router.Mask.Value;

            if (routerIP == computerIP)
            {
                return false;
            }

            return (routerIP & mask) == (computerIP & mask);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
