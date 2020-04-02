using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.DAL.Entities;
using ComputerNet.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerNet.BLL.Services
{
    public class DeviceService : IDeviceService
    {
        protected readonly IMapper _mp;
        protected readonly IGenericRepository<Computer> _comuterRepo;
        protected readonly IGenericRepository<Router> _routerRepo;

        public DeviceService(IGenericRepository<Computer> comuterRepository,
                             IGenericRepository<Router> routerRepository,                            
                             IMapper mapper)
        {
            _comuterRepo = comuterRepository;
            _routerRepo = routerRepository;
            _mp = mapper;
        }

        public IEnumerable<DeviceDTO> SearchByBuildingName(string buildingName)
        {
            if (buildingName == null)
            {
                return null;
            }

            IEnumerable<Computer> computers = _comuterRepo.GetAll().Where(c => c.Room.Building.Name == buildingName);
            IEnumerable<Router> routers = _routerRepo.GetAll().Where(c => c.Room.Building.Name == buildingName);

            return MapAndConcat(computers, routers);
        }

        public DeviceDTO SearchByHardwareAddress(string adress)
        {
            Computer computer = _comuterRepo.GetAll().Where(c => c.HardwareAddress == adress).FirstOrDefault();
            if (computer != null)
            {
                return _mp.Map<DeviceDTO>(computer);            
            }

            Router router = _routerRepo.GetAll().Where(c => c.HardwareAddress == adress).FirstOrDefault();
            return _mp.Map<DeviceDTO>(router);
        }

        public IEnumerable<DeviceDTO> SearchByLogicAddress(long adress)
        {
            var computers = _comuterRepo.GetAll().Where(c => c.LogicAddress == adress);
            var routers = _routerRepo.GetAll().Where(c => c.LogicAddress == adress);

            return MapAndConcat(computers, routers);
        }

        public IEnumerable<DeviceDTO> SearchByManufactureDate(DateTime manufactured)
        {
            var computers = _comuterRepo.GetAll().Where(c => c.Manufactured == manufactured);
            var routers = _routerRepo.GetAll().Where(c => c.Manufactured == manufactured);

            return MapAndConcat(computers, routers);
        }

        public IEnumerable<DeviceDTO> SearchByModel(string modelName)
        {
            if (modelName == null)
            {
                return null;
            }

            var computers = _comuterRepo.GetAll().Where(c => c.Model == modelName);
            var routers = _routerRepo.GetAll().Where(c => c.Model == modelName);

            return MapAndConcat(computers, routers);
        }

        public IEnumerable<DeviceDTO> SearchByRoomNumber(int roomNumber)
        {
            IEnumerable<Computer> computers = _comuterRepo.GetAll().Where(c => c.Room.Number == roomNumber);
            IEnumerable<Router> routers = _routerRepo.GetAll().Where(c => c.Room.Number == roomNumber);

            return MapAndConcat(computers, routers);
        }

        private IEnumerable<DeviceDTO> MapAndConcat(IEnumerable<Computer> computers, IEnumerable<Router> routers)
        {
            return _mp.Map<IEnumerable<DeviceDTO>>(computers)
                   .Concat(_mp.Map<IEnumerable<DeviceDTO>>(routers));
        }
    }
}
