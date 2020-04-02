using AutoMapper;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ComputerNet.WEB.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IDeviceService _service;
        private readonly IMapper _mp;

        public DeviceController(IMapper mapper, IDeviceService service)
        {
            _service = service;
            _mp = mapper;
        }

        public ActionResult Index(IEnumerable<DeviceVM> devices)
        {
            return View(devices);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SearchByLogicAddress(long LogicAddress) 
        {
            var devicesDTO = _service.SearchByLogicAddress(LogicAddress);
            var devicesVM = _mp.Map<IEnumerable<DeviceVM>>(devicesDTO);

            return View("Index", devicesVM);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SearchByHardwareAddress(string HardwareAddress) 
        {
            var deviceDTO = _service.SearchByHardwareAddress(HardwareAddress);
            var deviceVM = _mp.Map<DeviceVM>(deviceDTO);

            return View("Index", new List<DeviceVM> { deviceVM } );
        }

        [ValidateAntiForgeryToken]
        public ActionResult SearchByModel(string Model)
        {
            var devicesDTO = _service.SearchByModel(Model);
            var devicesVM = _mp.Map<IEnumerable<DeviceVM>>(devicesDTO);

            return View("Index", devicesVM);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SearchByManufactureDate(DateTime Manufactured) 
        {
            var devicesDTO = _service.SearchByManufactureDate(Manufactured);
            var devicesVM = _mp.Map<IEnumerable<DeviceVM>>(devicesDTO);

            return View("Index", devicesVM);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SearchByRoomNumber(int Number) 
        {
            var devicesDTO = _service.SearchByRoomNumber(Number);
            var devicesVM = _mp.Map<IEnumerable<DeviceVM>>(devicesDTO);

            return View("Index", devicesVM);
        }

        [ValidateAntiForgeryToken]
        public ActionResult SearchByBuildingName(string Name)
        {
            var devicesDTO = _service.SearchByBuildingName(Name);
            var devicesVM = _mp.Map<IEnumerable<DeviceVM>>(devicesDTO);

            return View("Index", devicesVM);
        }
    }
}