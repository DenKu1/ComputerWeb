using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using AutoMapper;
using ComputerNet.BLL.Interfaces;

namespace ComputerNet.API.Controllers
{
    public abstract class GenericController<TEntityDTO, TEntityVM> : ApiController
    {
        private readonly IGenericService<TEntityDTO> _service;
        private readonly IMapper _mp;

        public GenericController(IMapper mapper, IGenericService<TEntityDTO> service)
        {
            _service = service;
            _mp = mapper;
        }

        [HttpGet]
        public virtual IEnumerable<TEntityVM> GetItems()
        {
            IEnumerable<TEntityDTO> itemDTOs = _service.GetAll();
            IEnumerable<TEntityVM> itemVMs = _mp.Map<IEnumerable<TEntityVM>>(itemDTOs);

            return itemVMs;
        }

        [HttpGet]
        public virtual IHttpActionResult GetItem(int id)
        {
            TEntityDTO itemDTO = _service.GetById(id);

            if (itemDTO == null)
            {
                return BadRequest();
            }

            TEntityVM itemVM = _mp.Map<TEntityVM>(itemDTO);

            return Ok(itemVM);
        }

        [HttpPost]
        public IHttpActionResult PostItem([ModelBinder]TEntityVM entityVM)
        {
            if (entityVM == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TEntityDTO entityDTO = _mp.Map<TEntityDTO>(entityVM);

            _service.Create(entityDTO);

            return Ok();
        }

        [HttpPut]
        public virtual IHttpActionResult PutItem([ModelBinder]TEntityVM entityVM)
        {
            if (entityVM == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            TEntityDTO entityDTO = _mp.Map<TEntityDTO>(entityVM);

            _service.Update(entityDTO);

            return Ok();
        }

        [HttpDelete]
        public virtual IHttpActionResult DeleteItem([FromUri]int id)
        {
            if (_service.GetById(id) == null)
            {
                return BadRequest();
            }

            _service.Delete(id);

            return Ok();
        }
    }
}
