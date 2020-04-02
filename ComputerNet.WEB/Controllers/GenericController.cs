using AutoMapper;
using ComputerNet.BLL.Interfaces;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ComputerNet.WEB.Controllers
{
    public abstract class GenericController<TEntityDTO, TEntityVM> : Controller
    {
        private readonly IGenericService<TEntityDTO> _service;
        private readonly IMapper _mp;

        public GenericController(IMapper mapper, IGenericService<TEntityDTO> service)
        {
            _service = service;
            _mp = mapper;
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            IEnumerable<TEntityDTO> itemDTOs = _service.GetAll();
            IEnumerable<TEntityVM> itemVMs = _mp.Map<IEnumerable<TEntityVM>>(itemDTOs);

            return View(itemVMs);
        }

        [HttpGet]
        public virtual ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TEntityDTO itemDTO = _service.GetById(id.Value);
            TEntityVM itemVM = _mp.Map<TEntityVM>(itemDTO);

            return View(itemVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit(TEntityVM entityVM)
        {
            if (!ModelState.IsValid)
            {
                return View(entityVM);
            }

            TEntityDTO entityDTO = _mp.Map<TEntityDTO>(entityVM);

            _service.Update(entityDTO);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public virtual ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            TEntityDTO itemDTO = _service.GetById(id.Value);
            TEntityVM itemVM = _mp.Map<TEntityVM>(itemDTO);

            return View(itemVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Delete(int id)
        {
            _service.Delete(id);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create(TEntityVM entityVM)
        {
            if (!ModelState.IsValid)
            {
                return View(entityVM);           
            }

            TEntityDTO entityDTO = _mp.Map<TEntityDTO>(entityVM);

            _service.Create(entityDTO);

            return RedirectToAction("Index");
        }

    }
}