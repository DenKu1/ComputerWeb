using AutoMapper;
using ComputerNet.API.Models;
using ComputerNet.BLL.DTO;
using ComputerNet.BLL.Interfaces;

namespace ComputerNet.API.Controllers
{
    public class ComputerController : GenericController<ComputerDTO, ComputerVM>
    {
        public ComputerController(IMapper mapper, IGenericService<ComputerDTO> service) : base(mapper, service)
        {
        }
    }
}