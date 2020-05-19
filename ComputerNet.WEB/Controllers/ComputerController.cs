using AutoMapper;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;
using ComputerNet.WEB.Models;
using System.Web.Mvc;

namespace ComputerNet.WEB.Controllers
{
    [Authorize]
    public class ComputerController : GenericController<ComputerDTO, ComputerVM>
    {
        public ComputerController(IMapper mapper, IGenericService<ComputerDTO> service) : base(mapper, service)
        {
        }

    }
}