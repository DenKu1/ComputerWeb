using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;
using System.Web.Mvc;

namespace ComputerNet.WEB.Controllers
{
    [Authorize]
    public class RouterController : GenericController<RouterDTO, RouterVM>
    {
        public RouterController(IMapper mapper, IGenericService<RouterDTO> service) : base(mapper, service)
        {
        }
    }
}