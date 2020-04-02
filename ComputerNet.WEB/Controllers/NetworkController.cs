using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;
using System.Web.Mvc;

namespace ComputerNet.WEB.Controllers
{
    public class NetworkController : Controller
    {
        private readonly IGenericService<ComputerDTO> _computerService;
        private readonly IGenericService<RouterDTO> _routerService;
        private readonly INetworkService _networkService;
        private readonly IMapper _mp;

        public NetworkController(IMapper mapper, IGenericService<ComputerDTO> computerService,
                                 IGenericService<RouterDTO> routerService, INetworkService networkService)
        {
            _computerService = computerService;
            _routerService = routerService;
            _networkService = networkService;
            _mp = mapper;
        }
     
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var computerDTO = _computerService.GetById(id.Value);
            var computerVM = _mp.Map<ComputerVM>(computerDTO);  

            return View(computerVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int? id, long logicAddress)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var oldComputerDTO = _computerService.GetById(id.Value);
            var routerDTO = _routerService.GetById(oldComputerDTO.RouterId);

            if (!_networkService.CheckIPRange(id.Value, logicAddress))
            {
                var computerVM = _mp.Map<ComputerVM>(oldComputerDTO);

                ModelState.AddModelError("", "Ip is out of range!");
                return View(computerVM);            
            }

            _computerService.Update(new ComputerDTO {
                Model = oldComputerDTO.Model,
                HardwareAddress = oldComputerDTO.HardwareAddress,
                Id = oldComputerDTO.Id,
                Manufactured = oldComputerDTO.Manufactured,
                RoomId = oldComputerDTO.RoomId,
                RouterId = oldComputerDTO.RouterId,
                LogicAddress = logicAddress,
                Mask = routerDTO.Mask
            });

            return RedirectToAction("Index", "Computer");
        }
    }
}